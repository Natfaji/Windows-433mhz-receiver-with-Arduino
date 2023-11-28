using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		SerialPort sp;
		List<Item> devices;
		string lastReceivedData = "";
		DateTime lastProcessedTimestamp = DateTime.MinValue;
		int messageProcessInterval = 5000;

		public Form1()
		{
			InitializeComponent();

			// Create a new SerialPort object with default settings.
			sp = new SerialPort(Properties.Settings.Default.SerialPortName ?? "COM3", Properties.Settings.Default.SerialPortBaudRate != 0 ? Properties.Settings.Default.SerialPortBaudRate : 9600);

			// Update the list
			UpdateList();

			// Set the datareceived event handler
			sp.DataReceived += new SerialDataReceivedEventHandler(UpdateState);

			// Try to open the serial port
			try
			{
				// Open the serial port
				sp.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnAddDevice_Click(object sender, EventArgs e)
		{
			AddNewItem addNewItem = new AddNewItem(this, sp);
			addNewItem.ShowDialog();
		}

		public void UpdateList()
		{
			// Clear the list
			lvDevices.Items.Clear();

			// Get the devices
			devices = helpers.device.GetDevices();

			// Fill the list
			foreach (Item device in devices)
			{
				// Create a new ListViewItem
				ListViewItem listItem = new ListViewItem
				{
					Tag = device,
					Text = device.Name,
					SubItems = {
						"Waiting...",
						device.Type,
						device.Notifications ? "On" : "Off"
					}
				};

				lvDevices.Items.Add(listItem);
			}
		}

		private void UpdateState(object sender, SerialDataReceivedEventArgs e)
		{
			// If the serial port is not open, return
			if (!sp.IsOpen) return;

			// Read the serial port data
			string receivedData = sp.ReadExisting();

			// Get the current timestamp
			DateTime currentTimestamp = DateTime.Now;

			// If the data is the same as the last received data, or it was processed recently, return
			if (receivedData == lastReceivedData && (currentTimestamp - lastProcessedTimestamp).TotalMilliseconds < messageProcessInterval)
			{
				// If the timer is not enabled, start it
				//if (!timer.Enabled) timer.Start();
				Debug.WriteLine("Data is the same as the last received data, or it was processed recently, return");

				return;
			}

			Debug.WriteLine("Data is not the same as the last received data, or it was not processed recently, continue");

			// Set the last received data
			lastReceivedData = receivedData;

			// Set the last processed timestamp
			lastProcessedTimestamp = currentTimestamp;

			// Trim the data
			receivedData = receivedData.TrimEnd('\r', '\n');

			// Use Invoke to update the UI controls on the UI thread
			this.Invoke((MethodInvoker)delegate
			{
				foreach (Item device in devices)
				{
					foreach (ItemState deviceState in device.States)
					{
						if (deviceState.Code == receivedData)
						{
							foreach (ListViewItem item in lvDevices.Items)
							{
								if (((Item)item.Tag).Id == device.Id)
								{
									item.SubItems[1].Text = deviceState.State;

									if (device.Notifications)
									{
										// Send a notification
										helpers.notification.SendNotification((Item)item.Tag, deviceState.State);
									}
								}

							}
						}
					}
				}
			});
		}

		private void btnSelectReceiver_Click(object sender, EventArgs e)
		{
			SelectReceiver selectReceiver = new SelectReceiver();
			selectReceiver.ShowDialog();
		}

		private void tsmiToggleNotifications_Click(object sender, EventArgs e)
		{
			Item lvDeviceTag = (Item)lvDevices.SelectedItems[0].Tag;
			var lvDeviceNotifications = lvDevices.SelectedItems[0].SubItems[3];

			// toggle the notifications
			if (lvDeviceNotifications.Text == "On")
			{
				lvDeviceNotifications.Text = "Off";
				lvDeviceTag.Notifications = false;
			}
			else
			{
				lvDeviceNotifications.Text = "On";
				lvDeviceTag.Notifications = true;
			}

			// update the device
			helpers.device.UpdateDevice(lvDeviceTag);

			// update the list
			UpdateList();
		}
	}
}

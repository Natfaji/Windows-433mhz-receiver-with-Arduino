using System;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;

namespace WindowsFormsApp1
{
	public partial class AddNewItem : Form
	{
		List<ucAddStatus> userControlsList = new List<ucAddStatus>();
		SerialPort sp;

		private Form1 parentForm;

		public AddNewItem(Form1 form1, SerialPort Parentsp)
		{
			InitializeComponent();

			// Set the parent form
			parentForm = form1;

			// Set the serial port
			sp = Parentsp;

			// Create a new instance of your user control
			CreateNewState();
		}

		private void btnAddNewState_Click(object sender, EventArgs e)
		{
			// Create a new instance of state
			CreateNewState();
		}

		private void CreateNewState()
		{
			// Create a new instance of your user control
			ucAddStatus ucAddStatus = new ucAddStatus(sp);

			// Add the user control to the layout panel
			flpStates.Controls.Add(ucAddStatus);

			// Add the user control to the list
			userControlsList.Add(ucAddStatus);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			int id = 1;

			// Get devices
			List<Item> devices = helpers.device.GetDevices();

			// If the list is empty, set the ID to 1
			if (devices.Count != 0) id = devices.Last().Id + 1;

			// Create a new device
			Item device = new Item
			{
				Id = id,
				Name = txtDeviceName.Text,
				Type = txtDeviceType.Text,
				States = new List<ItemState>()
			};

			// Loop through the list of device states
			foreach (ucAddStatus userControl in userControlsList)
			{
				// Create a new state
				ItemState newState = new ItemState
				{
					State = userControl.TXTState.Text,
					Code = userControl.TXTCode.Text
				};

				// Add the new state to the list of states
				device.States.Add(newState);
			}

			// Add the new device to the file
			helpers.device.AddDevice(device);

			// reload the list on main form
			parentForm.UpdateList();

			// Close the form
			this.Close();
		}
	}
}

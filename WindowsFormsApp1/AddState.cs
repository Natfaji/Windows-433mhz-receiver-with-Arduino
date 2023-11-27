using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class ucAddStatus : UserControl
	{
		public TextBox TXTState => txtState;
		public TextBox TXTCode => txtCode;

		SerialPort sp;

		public ucAddStatus(SerialPort Parentsp)
		{
			InitializeComponent();
			this.sp = Parentsp;
			if (!sp.IsOpen) Debug.WriteLine("Error | port is closed! A");
		}

		private void btnDetectCode_Click(object sender, EventArgs e)
		{
			// Set the datareceived event handler
			sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);

			// Disable the button to prevent multiple clicks while the port is open
			btnDetectCode.Enabled = false;
			btnDetectCode.Text = "Detecting...";
			if (!sp.IsOpen) Debug.WriteLine("Error | port is closed! B");
		}

		private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			if (!sp.IsOpen) Debug.WriteLine("Error | port is closed! C");

			// Read the serial port data
			string receivedData = sp.ReadLine();

			receivedData = receivedData.TrimEnd('\r', '\n');

			// Use Invoke to update the UI controls on the UI thread
			this.Invoke((MethodInvoker)delegate
			{
				txtCode.Text = receivedData;
				btnDetectCode.Enabled = true;
				btnDetectCode.Text = "Detect Code";
			});

			sp.DataReceived -= new SerialDataReceivedEventHandler(sp_DataReceived);
			return;
		}
	}
}
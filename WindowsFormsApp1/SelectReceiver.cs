using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class SelectReceiver : Form
	{
		public SelectReceiver()
		{
			InitializeComponent();
			txtPortName.Text = Properties.Settings.Default.SerialPortName;
			txtBaudRate.Text = Properties.Settings.Default.SerialPortBaudRate.ToString();
		}

		private void txtportname_DropDown(object sender, EventArgs e)
		{
			txtPortName.Items.Clear();
			string[] comports = SerialPort.GetPortNames();
			foreach (var comport in comports)
			{
				txtPortName.Items.Add(comport);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.SerialPortName = txtPortName.Text;
			Properties.Settings.Default.SerialPortBaudRate = int.Parse(txtBaudRate.Text);
			Properties.Settings.Default.Save();
			this.Close();
		}
	}
}

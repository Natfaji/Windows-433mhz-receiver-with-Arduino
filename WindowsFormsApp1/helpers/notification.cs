using System.Net.Mail;
using System.Net;
using Microsoft.Toolkit.Uwp.Notifications;

namespace WindowsFormsApp1.helpers
{
	internal class notification
	{
		public static void SendNotification(Item device, string deviceState)
		{
			new ToastContentBuilder()
				.AddText($"Alert from {device.Name}")
				.AddText($"Device state has changed to {deviceState}")
				.Show();
		}

		//public static void SendNotification(Item device, string deviceState)
		//{
		//	// If the device has no receivers, return
		//	if (device.Receivers.Count == 0) return;

		//	// Create a new instance of the SmtpClient class
		//	SmtpClient smtpClient = new SmtpClient();

		//	// Set the SMTP server
		//	smtpClient.Host = "smtp.gmail.com";

		//	// Set the SMTP port
		//	smtpClient.Port = 587;

		//	// Set the SMTP credentials
		//	smtpClient.Credentials = new NetworkCredential("email", "password");

		//	// Enable SSL
		//	smtpClient.EnableSsl = true;

		//	// Create a new instance of the MailMessage class
		//	MailMessage mailMessage = new MailMessage();

		//	// Set the sender
		//	mailMessage.From = new MailAddress("email");

		//	// Set the subject
		//	mailMessage.Subject = "Device state changed";

		//	// Set the body
		//	mailMessage.Body = "The state of the device " + deviceName + " has changed to " + deviceState;

		//	// Add the receivers
		//	foreach (string receiver in device.Receivers)
		//	{
		//		mailMessage.To.Add(receiver);
		//	}

		//	// Send the email
		//	smtpClient.Send(mailMessage);
		//}
	}
}

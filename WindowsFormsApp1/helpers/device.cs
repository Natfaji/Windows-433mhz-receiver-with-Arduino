using System.Collections.Generic;
using System.IO;

namespace WindowsFormsApp1.helpers
{
	internal class device
	{
		public static List<Item> GetDevices()
		{
			// Get the list of items from the JSON file
			string data = File.ReadAllText("settings.json");

			// Deserialize the JSON to a list of items
			List<Item> devices = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Item>>(data);

			// If the list is null, create a new list
			if (devices == null)
			{
				devices = new List<Item>();
			}

			return devices;
		}

		public static void SaveDevices(List<Item> devices)
		{
			// Serialize the list of items to JSON
			string data = Newtonsoft.Json.JsonConvert.SerializeObject(devices);

			// Write the JSON to the file
			File.WriteAllText("settings.json", data);
		}

		public static void AddDevice(Item device)
		{
			// Get the list of items from the JSON file
			List<Item> devices = GetDevices();

			// Add the new item to the list
			devices.Add(device);

			// Save the list of items
			SaveDevices(devices);
		}

		public static void UpdateDevice(Item device)
		{
			// Get the list of items from the JSON file
			List<Item> devices = GetDevices();

			// Find the index of the item
			int index = devices.FindIndex(x => x.Id == device.Id);

			// Update the item
			devices[index] = device;

			// Save the list of items
			SaveDevices(devices);
		}
	}
}

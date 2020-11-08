using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Streaming.Adaptive;
using Windows.Storage;

namespace DataAccess.Data
{
    public static class SettingsContext
    {
        private static string fileName = "settings.json";
        private static Settings _settings { get; set; }

        public static async Task CreateSettingsFile()
        {
            FileInfo fInfo = new FileInfo(fileName);
            if (fInfo.Exists)
            {
                StorageFile storageFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName);
            }



        }
        //public static void GetSettingsInformation()
        //{
        //    //StorageFile settingsFile = await ApplicationData.Current.LocalFolder.GetFileAsync("settings.json");
        //    //var settings = JsonConvert.DeserializeObject<Settings>(await FileIO.ReadTextAsync(settingsFile));

        //    var settingsFile = "{\"status\": [\"Open\", \"Waiting\", \"Closed\"], \"maxItemsCount\": 4}";
        //    _settings = JsonConvert.DeserializeObject<Settings>(settingsFile);
        //}

        public static async Task GetSettingsInfo()
        {




            StorageFile settingsFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);



            _settings = JsonConvert.DeserializeObject<Settings>(await FileIO.ReadTextAsync(settingsFile));
        }

        public static IEnumerable<string> GetStatus()
        {
            List<string> list = new List<string>();


            foreach (var status in _settings.status)
            {
                list.Add(status);
            }

            return list;
        }

        public static int GetMaxItemsCount()
        {
            return _settings.maxItemsCount;
        }
    }



    public class Settings
    {
        public string[] status { get; set; }
        public int maxItemsCount { get; set; }
    }

}
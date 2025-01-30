using System.IO;
using InterviewCR.Models;
using Newtonsoft.Json;

namespace InterviewCR.Utilities
{
    public class JsonParser
    {
        private string _rootFolder = "resources";
        private string _itemsPath = "items.json";

        public Menu LoadMenuItems()
        {
            string fullPath = Path.Combine(_rootFolder, _itemsPath);
            string json = File.ReadAllText(fullPath);

            return JsonConvert.DeserializeObject<Menu>(json);
        }
    }
}

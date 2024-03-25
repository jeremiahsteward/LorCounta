using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json.Serialization;

namespace LorCounta
{
    public static class Data
    {
        public static string Path = "./Data/";
    }

    public class HostInfo
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public DateTime LastUpdated { get; set; } = DateTime.Now;
        private List<Guid> TrackedEvents { get; set; } = new List<Guid>();
        public List<Guid> KnownEvents { get; set; } = new List<Guid>();



        public bool SaveToFile()
        {
            bool isSuccess = true;
            try
            {
                string filePath = Path.Combine(Data.Path, $"{ID.ToString()}.json");
                if (!Directory.Exists(Data.Path))
                {
                    Directory.CreateDirectory(Data.Path);
                }

                if(!File.Exists(filePath)) 
                {
                    File.Create(filePath).Close();
                }


            }
            catch
            {
                isSuccess = false;
            }
            return isSuccess;
        }
    }

    public class Player
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

    }

    public class Event
    {

    }

}

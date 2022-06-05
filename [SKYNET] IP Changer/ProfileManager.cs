using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using SKYNET.Models;

namespace SKYNET
{
    public class ProfileManager
    {
        public List<Profile> Profiles { get; set; }
        private string filePath;

        public ProfileManager()
        {
            Profiles = new List<Profile>();
            filePath = Path.Combine(modCommon.GetPath(), "Profiles.json");
        }
        public void Load()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string JSON = File.ReadAllText(filePath);
                    Profiles = new JavaScriptSerializer().Deserialize<List<Profile>>(JSON);
                }
                catch (Exception)
                {
                    Profiles = new List<Profile>();
                }
            }
            else
            {
                Profiles = new List<Profile>();
            }
        }
        public void Save()
        {
            string JSON = new JavaScriptSerializer().Serialize(Profiles);
            try
            {
                File.WriteAllText(filePath, JSON);
            }
            catch 
            {
            }
        }

        public void Add(string adapter, string name, NetworkSettings settings)
        {
            var profile = Profiles.Find(p => p.Name == name && p.Adapter == adapter);
            if (profile != null)
            {
                modCommon.Show($"The Profile {name} exists");
                return;
            }
            Profiles.Add(new Profile()
            {
                Name = name,
                Adapter = adapter,
                AdapterSettings = settings
            });
            Save();
        }
        public void Update(string adapter, string name, NetworkSettings settings)
        {
            var profile = Profiles.Find(p => p.Name == name && p.Adapter == adapter);
            if (profile == null)
            {
                modCommon.Show($"The Profile {name} not exists");
                return;
            }
            profile.AdapterSettings = settings;
            Save();
        }

        public bool Remove(string adapter, string name)
        {
            var profile = Profiles.Find(p => p.Name == name && p.Adapter == adapter);
            if (profile == null)
            {
                return false;
            }
            else
            {
                Profiles.Remove(profile);
                Save();
                return true;
            }
        }
    }
}

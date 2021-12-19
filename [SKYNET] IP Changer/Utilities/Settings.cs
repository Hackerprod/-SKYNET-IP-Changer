using Microsoft.Win32;
using SKYNET.Models;
using System;
using System.Web.Script.Serialization;
using System.Windows;
using static SKYNET.frmMain;

namespace SKYNET.Utils
{
    public class Settings
    {
        public static Profile Profile { get; set; }

        private static RegistryKey registry { get; set; }
        private static string SubKey = @"SOFTWARE\SKYNET\[SKYNET] IP Changer\";

        public static void Initialice()
        {
            registry = Registry.CurrentUser.OpenSubKey(SubKey, true);
            if (registry == null)
            {
                Registry.CurrentUser.CreateSubKey(SubKey);
                registry = Registry.CurrentUser.OpenSubKey(SubKey, true);

                frm.TB_IP.Text = modCommon.GetIP();
                frm.TB_Mask.Text = "255.255.255.0";
                NetworkConfigurator.GetIpAddress(Profile.Adapter, out string[] IPs, out string[] SubMasks, out string[] IPGateways, out string[] DNSServer);
                Profile = new Profile()
                {
                    Adapter = "",
                    AdapterSettings = new NetworkSettings()
                    {
                        IP = IPs[0],
                        Mask = SubMasks[0],
                        Gateway = IPGateways[0],
                        DNS_1 = DNSServer[0]
                    }
                };
                Save();

            }
        }
        public static void Load()
        {
            try
            {
                if (registry != null)
                {
                    string JSON = registry.GetValue("ParsedSettings", RegistryValueKind.String).ToString();

                    Profile = new JavaScriptSerializer().Deserialize<Profile>(JSON);
                }
            }
            catch
            {
                Profile = new Profile();
            }
        }

        public static void Save()
        {
            registry = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(SubKey, true);
            string JSON = new JavaScriptSerializer().Serialize(Profile);
            try
            {
                registry.SetValue("ParsedSettings", JSON);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}

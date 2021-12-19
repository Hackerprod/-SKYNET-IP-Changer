using System;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.Win32;
using System.Net;
using System.Net.NetworkInformation;

namespace SKYNET.Utils
{
    public class NetworkConfigurator
    {
        /// <param name="ipAddress">The IP Address</param>
        /// <param name="subnetMask">The Submask IP Address</param>
        /// <param name="gateway">The gateway.</param>
        static string[] IPs = new string[2];

        public static void SetIP(string AdapterName, string ipAddress, string subnetMask)
        {
            using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (var networkConfigs = networkConfigMng.GetInstances())
                {
                    var managementObject = networkConfigs.Cast<ManagementObject>().ToList().Find(obj => obj["Description"].ToString() == AdapterName);

                    if (managementObject != null)
                    {
                        using (ManagementBaseObject newIP = managementObject.GetMethodParameters("EnableStatic"))
                        {
                            // Set new IP address and subnet if needed
                            if ((!string.IsNullOrEmpty(ipAddress)) || (!string.IsNullOrEmpty(subnetMask)))
                            {
                                if (!string.IsNullOrEmpty(ipAddress))
                                {
                                    newIP["IPAddress"] = new[] { ipAddress };
                                }

                                if (!string.IsNullOrEmpty(subnetMask))
                                {
                                    newIP["SubnetMask"] = new[] { subnetMask };
                                }

                                managementObject.InvokeMethod("EnableStatic", newIP, null);
                            }
                        }
                    }
                }
            }
        }
        public static void SetIP(string AdapterName, string[] ipAddress, string[] subnetMask)
        {
            using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (var networkConfigs = networkConfigMng.GetInstances())
                {
                    var managementObject = networkConfigs.Cast<ManagementObject>().ToList().Find(obj => obj["Description"].ToString() == AdapterName);
                    if (managementObject != null)
                    {
                        using (ManagementBaseObject newIP = managementObject.GetMethodParameters("EnableStatic"))
                        {
                            // Set new IP address and subnet if needed
                            if (ipAddress.Any())
                            {
                                newIP["IPAddress"] = ipAddress;
                            }
                            if (subnetMask.Any())
                            {
                                newIP["SubnetMask"] = subnetMask;
                            }

                            managementObject.InvokeMethod("EnableStatic", newIP, null);
                        }
                    }
                    else
                    {
                        modCommon.Show("error");
                    }
                }
            }
        }
        public static void GetIpAddress(string Adapter, out string[] IPAddress, out string[] SubnetMasks, out string[] IPGateways, out string[] DNSServer)
        {
            IPAddress = null;
            SubnetMasks = null;
            IPGateways = null;
            DNSServer = null;
            try
            {
                ManagementObjectSearcher query = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
                ManagementObjectCollection nics = query.Get();
                var nic = nics.Cast<ManagementObject>().ToList().Find(obj => obj["Description"].ToString() == Adapter);

                if (nic != null)
                {
                    if (Convert.ToBoolean(nic["ipEnabled"]) == true)
                    {
                        string mac = nic["MacAddress"].ToString();
                        IPAddress = (nic["IPAddress"] as string[]);
                        SubnetMasks = (nic["IPSubnet"] as string[]);
                        IPGateways = (nic["DefaultIPGateway"] as string[]);
                        DNSServer = (nic["DNSServerSearchOrder"] as string[]);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        public static void SetGateway(string AdapterName, string DnsString)
        {
            string[] Dns = { DnsString };
            using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (var networkConfigs = networkConfigMng.GetInstances())
                {
                    var managementObject = networkConfigs.Cast<ManagementObject>().ToList().Find(obj => obj["Description"].ToString() == AdapterName);

                    if (managementObject != null)
                    {
                        using (ManagementBaseObject objdns = managementObject.GetMethodParameters("SetGateways"))
                        {
                            objdns["DefaultIPGateway"] = Dns;
                            objdns["GatewayCostMetric"] = new[] { 1 };
                            managementObject.InvokeMethod("SetGateways", objdns, null);
                        }
                    }
                }
            }
        }
        internal static void SetDHCP()
        {
            using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (var networkConfigs = networkConfigMng.GetInstances())
                {
                    foreach (var managementObject in networkConfigs.Cast<ManagementObject>().Where(managementObject => (bool)managementObject["IPEnabled"]))
                    {
                        using (ManagementBaseObject newIP = managementObject.GetMethodParameters("EnableDHCP"))
                        {
                            managementObject.InvokeMethod("EnableDHCP", newIP, null);
                        }
                    }
                }
            }
        }
        public static bool DHCPEnabled(string AdapterName)
        {
            bool enabled = false;
            using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (var networkConfigs = networkConfigMng.GetInstances())
                {
                    var managementObject = networkConfigs.Cast<ManagementObject>().ToList().Find(obj => obj["Description"].ToString() == AdapterName);

                    if (managementObject != null)
                    {
                        using (ManagementBaseObject newIP = managementObject.GetMethodParameters("EnableDHCP"))
                        {
                            var obj = managementObject.GetPropertyValue("DHCPEnabled");
                            if (obj != null)
                            {
                                bool.TryParse(obj.ToString(), out enabled);
                            }
                        }
                    }
                }
            }
            return enabled;
        }

        public static void SetDNS(string AdapterName, string DnsCommaSeparated)
        {
            using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (var networkConfigs = networkConfigMng.GetInstances())
                {
                    var managementObject = networkConfigs.Cast<ManagementObject>().ToList().Find(obj => obj["Description"].ToString() == AdapterName);

                    if (managementObject != null)
                    {
                        using (ManagementBaseObject objdns = managementObject.GetMethodParameters("SetDNSServerSearchOrder"))
                        {
                            objdns["DNSServerSearchOrder"] = DnsCommaSeparated.Split(',');
                            managementObject.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                        }
                    }
                }
            }
        }
        public static void UnsetDNS()
        {
            using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (var networkConfigs = networkConfigMng.GetInstances())
                {
                    foreach (var managementObject in networkConfigs.Cast<ManagementObject>().Where(managementObject => (bool)managementObject["IPEnabled"]))
                    {
                        using (ManagementBaseObject objdns = managementObject.GetMethodParameters("SetDNSServerSearchOrder"))
                        {
                            objdns["DNSServerSearchOrder"] = null;
                            managementObject.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                        }
                    }
                }
            }
        }

        public static IPAddress GetDefaultGateway()
        {
            return NetworkInterface
                .GetAllNetworkInterfaces()
                .Where(n => n.OperationalStatus == OperationalStatus.Up)
                .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                .SelectMany(n => n.GetIPProperties()?.GatewayAddresses)
                .Select(g => g?.Address)
                .Where(a => a != null)
                // .Where(a => a.AddressFamily == AddressFamily.InterNetwork)
                // .Where(a => Array.FindIndex(a.GetAddressBytes(), b => b != 0) >= 0)
                .FirstOrDefault();
        }
        public static List<NetworkInterface> GetNetworkInterface()
        {
            return NetworkInterface
                .GetAllNetworkInterfaces().ToList();        
        }
    }
}
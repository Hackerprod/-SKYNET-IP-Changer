using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;
using SKYNET.Models;

namespace SKYNET
{
    public class modCommon
    {
        public static string GetIP()
        {
            string Ip = "";
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress[] addressList = host.AddressList;
                foreach (IPAddress ip in addressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        Ip = ip.ToString();
                    }
                }
            }
            return Ip;
        }

        internal static void Show(object v)
        {
            string text = v == null ? "NULL" : v.ToString();
            MessageBox.Show(text);
        }
        public static bool IsValidIP(string Address)
        {
            IPAddress ip;
            if (IPAddress.TryParse(Address, out ip))
            {
                switch (ip.AddressFamily)
                {
                    case AddressFamily.InterNetwork:
                        if (Address.Length > 6 && Address.Contains("."))
                        {
                            string[] s = Address.Split('.');
                            if (s.Length == 4 && s[0].Length > 0 && s[1].Length > 0 && s[2].Length > 0 && s[3].Length > 0)
                                return true;
                        }
                        break;
                    case AddressFamily.InterNetworkV6:
                        if (Address.Contains(":") && Address.Length > 15)
                            return true;
                        break;
                    default:
                        break;
                }
            }

            return false;
        }

        public static NetworkSettings CreateOne(string IP, string Mask, string Gateway, string DNS_1, string DNS_2, string IP_Secondary, string Mask_Secondary)
        {
            if (!IPAddress.TryParse(IP, out _))
            {
                MessageBox.Show("Invalid IP Address, please ... correct it." + Environment.NewLine + IP);
                return null;
            }
            if (!IPAddress.TryParse(Mask, out _))
            {
                MessageBox.Show("The specified Subnet Mask is invalid, please ... correct it. " + Environment.NewLine + Mask);
                return null;
            }
            var settings = new NetworkSettings()
            {
                IP = IP,
                Mask = Mask,
                Gateway = Gateway,
                DNS_1 = DNS_1,
                DNS_2 = DNS_2,
                IP_Secondary = IP_Secondary,
                Mask_Secondary = Mask_Secondary
            };

            return settings;
        }

    }
}
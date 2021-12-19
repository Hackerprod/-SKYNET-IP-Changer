using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

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

    }
}
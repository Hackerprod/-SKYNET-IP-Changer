using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using SKYNET.Utils;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using SKYNET.Models;

namespace SKYNET
{
    public partial class frmMain : Form
    {
        public static frmMain frm;
        public ProfileManager ProfileManager;

        public frmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;  
            frm = this;

            Settings.Initialice();
            Settings.Load();

            ProfileManager = new ProfileManager();
            ProfileManager.Load();

            foreach (var item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == NetworkInterfaceType.Ethernet || item.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    CH_Adapters.Items.Add(item.Name);
                }
            }

            LoadProfile();
        }
        private bool isProfile
        {
            get { return BT_AddProfile.Text == "UPDATE" ? true : false; }
            set { BT_AddProfile.Text = value ? "UPDATE" : "CREATE"; }
        }

        private void LoadProfile()
        {
            try
            {
                for (int i = 0; i < CH_Adapters.Items.Count; i++)
                {
                    object item = CH_Adapters.Items[i];
                    if (item.ToString() == Settings.Profile.Adapter)
                    {
                        CH_Adapters.SelectedIndex = i;
                    }
                }
                TB_IP.Text = Settings.Profile.AdapterSettings.IP;
                TB_Mask.Text = Settings.Profile.AdapterSettings.Mask;
                TB_Gateway.Text = Settings.Profile.AdapterSettings.Gateway;
                TB_DNS_1.Text = Settings.Profile.AdapterSettings.DNS_1;
                TB_DNS_2.Text = Settings.Profile.AdapterSettings.DNS_2;

                TB_IP_Secondary.Text = Settings.Profile.AdapterSettings.IP_Secondary;
                TB_Mask_Secondary.Text = Settings.Profile.AdapterSettings.Mask_Secondary;
            }
            catch (Exception)
            {
                
            }

        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (DHCP.Checked)
            {
                NetworkConfigurator.SetDHCP();
                NetworkConfigurator.UnsetDNS();
            }
            else
            {
                if (!IPAddress.TryParse(TB_IP.Text, out _))
                {
                    MessageBox.Show("Invalid IP Address, please ... correct it." + Environment.NewLine + TB_IP.Text);
                    return;
                }
                if (!IPAddress.TryParse(TB_Mask.Text, out _))
                {
                    MessageBox.Show("The specified Subnet Mask is invalid, please ... correct it. " + Environment.NewLine + TB_Mask.Text);
                    return;
                }
                if (!string.IsNullOrEmpty(TB_Gateway.Text) && !IPAddress.TryParse(TB_Gateway.Text, out _))
                {
                    MessageBox.Show("The specified Gateway is invalid, please ... correct it." + Environment.NewLine + TB_Gateway.Text);
                    return;
                }
                if (!string.IsNullOrEmpty(TB_DNS_1.Text) && !IPAddress.TryParse(TB_DNS_1.Text, out _))
                {
                    MessageBox.Show("The specified Preferred DNS Server is invalid, please ... correct it." + Environment.NewLine + TB_DNS_1.Text);
                    return;
                }
                if (!string.IsNullOrEmpty(TB_DNS_2.Text) && !IPAddress.TryParse(TB_DNS_2.Text, out _))
                {
                    MessageBox.Show("The specified Alternate DNS Server is invalid, please ... correct it." + Environment.NewLine + TB_DNS_1.Text);
                    return;
                }
                if (!string.IsNullOrEmpty(TB_IP_Secondary.Text) && !IPAddress.TryParse(TB_IP_Secondary.Text, out _))
                {
                    MessageBox.Show("The specified Secondary IP Address is invalid, please ... correct it." + Environment.NewLine + TB_IP.Text);
                    return;
                }
                if (!string.IsNullOrEmpty(TB_Mask_Secondary.Text) && !IPAddress.TryParse(TB_Mask_Secondary.Text, out _))
                {
                    MessageBox.Show("The specified Secondary Subnet Mask is invalid, please ... correct it." + Environment.NewLine + TB_Mask.Text);
                    return;
                }
                string Adapter = "";
                if (string.IsNullOrEmpty(CH_Adapters.Text))
                {
                    MessageBox.Show("Specify the adapter that you want to configure.");
                    return;
                }
                else
                {
                    foreach (var item in NetworkInterface.GetAllNetworkInterfaces())
                    {
                        if (item.NetworkInterfaceType == NetworkInterfaceType.Ethernet || item.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                        {
                            if (item.Name == CH_Adapters.Text)
                            {
                                Adapter = item.Description;
                            } 
                        }
                    }
                }

                if (!string.IsNullOrEmpty(TB_IP.Text) && !string.IsNullOrEmpty(TB_IP_Secondary.Text) && !string.IsNullOrEmpty(TB_Mask.Text) && !string.IsNullOrEmpty(TB_Mask_Secondary.Text))
                {
                    NetworkConfigurator.SetIP(Adapter, new string[] { TB_IP.Text, TB_IP_Secondary.Text }, new string[] { TB_Mask.Text, TB_Mask_Secondary.Text });
                }
                else
                {
                    NetworkConfigurator.SetIP(Adapter, TB_IP.Text, TB_Mask.Text);
                }

                NetworkConfigurator.SetGateway(Adapter, TB_Gateway.Text);

                if (!string.IsNullOrEmpty(TB_DNS_1.Text) && !string.IsNullOrEmpty(TB_DNS_2.Text))
                {
                    NetworkConfigurator.SetDNS(Adapter, $"{TB_DNS_1.Text},{TB_DNS_2.Text}");
                }
                else if (!string.IsNullOrEmpty(TB_DNS_1.Text))
                {
                    NetworkConfigurator.SetDNS(Adapter, $"{TB_DNS_1.Text}");
                }
                else if (!string.IsNullOrEmpty(TB_DNS_2.Text))
                {
                    NetworkConfigurator.SetDNS(Adapter, $"{TB_DNS_2.Text}");
                }
                LoadIps(Adapter);

            }
            Settings.Save();
        }

        private void IP_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            var panel = textbox.Parent.Parent;
            if (textbox.Text.Length == 0)
            {
                panel.BackColor = Color.FromArgb(17, 199, 255);
            }
            else
            {
                if (modCommon.IsValidIP(textbox.Text))
                {
                    panel.BackColor = Color.FromArgb(17, 199, 255);
                }
                else
                    panel.BackColor = Color.Red;
            }

            if (isProfile)
            {
                BT_AddProfile.Text = "UPDATE";
            }
            else
            {
                BT_AddProfile.Text = "CREATE";
            }
        }

        private void Check_CheckedChanged(object sender, bool e)
        {
            MakeDHCPControls(DHCP.Checked);
        }
        private void MakeDHCPControls(bool v)
        {
            if (DHCP.Checked)
            {
                panel1.Enabled = false;
                panel5.Enabled = false;
            }
            else
            {
                panel1.Enabled = true;
                panel5.Enabled = true;
            }
        }

        private void LoadIps(string adapter)
        {
            LB_Current_IP.Text = "0.0.0.0";
            LB_Current_IP_Secondary.Text = "0.0.0.0";
            LB_Current_SubMask.Text = "0.0.0.0";
            LB_Current_Mask_Secondary.Text = "0.0.0.0";
            LB_Current_Gateway.Text = "0.0.0.0";
            LB_Current_DNS1.Text = "0.0.0.0";
            LB_Current_DNS2.Text = "0.0.0.0";

            NetworkConfigurator.GetIpAddress(adapter, out string[] IPs, out string[] SubMasks, out string[] IPGateways, out string[] DNSServer);
            if (IPs != null)
            {
                for (int i = 0; i < IPs.Length; i++)
                {
                    if (i == 0)
                    {
                        if (IPAddress.TryParse(IPs[i], out IPAddress addr))
                        {
                            if (addr.AddressFamily == AddressFamily.InterNetwork)
                            {
                                LB_Current_IP.Text = IPs[i];
                            }
                        }
                    }
                    else if (i == 1)
                    {
                        if (IPAddress.TryParse(IPs[i], out IPAddress addr))
                        {
                            if (addr.AddressFamily == AddressFamily.InterNetwork)
                            {
                                LB_Current_IP_Secondary.Text = IPs[i];
                            }
                        }
                    }
                }
            }
            //else { modCommon.Show("null"); }

            if (SubMasks != null)
            {
                for (int i = 0; i < SubMasks.Length; i++)
                {
                    if (i == 0)
                    {
                        if (IPAddress.TryParse(SubMasks[i], out _))
                        {
                            LB_Current_SubMask.Text = SubMasks[i];
                        }
                    }
                    else if (i == 1)
                    {
                        if (IPAddress.TryParse(SubMasks[i], out _) && SubMasks[i].Length > 2)
                        {
                            LB_Current_Mask_Secondary.Text = SubMasks[i];
                        }
                    }
                }
            }

            if (IPGateways != null)
            {
                for (int i = 0; i < IPGateways.Length; i++)
                {
                    if (i == 0)
                    {
                        LB_Current_Gateway.Text = IPGateways[i];
                    }
                }
            }

            if (DNSServer != null)
            {
                for (int i = 0; i < DNSServer.Length; i++)
                {
                    if (i == 0)
                    {
                        LB_Current_DNS1.Text = DNSServer[i];
                    }
                    else if (i == 1)
                    {
                        LB_Current_DNS2.Text = DNSServer[i];
                    }
                }
            }
        }

        private void Adapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            CH_Profiles.Items.Clear();
            isProfile = false;

            foreach (var item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.Name == CH_Adapters.Text)
                {
                    string MAC = "";
                    int count = 1;
                    foreach (var ch in item.GetPhysicalAddress().ToString())
                    {
                        MAC += ch;
                        if (count == 2)
                        {
                            MAC += ":";
                            count = 1;
                        }
                        else
                            count++;
                    }
                    LB_MAC.Text = item.Description;
                    LB_MAC.Text += Environment.NewLine;
                    LB_MAC.Text += $"MAC Address: {MAC.Remove(MAC.Length - 1, 1)}";
                    Settings.Profile.Adapter = item.Name;
                    Settings.Save();

                    var profiles = ProfileManager.Profiles.FindAll(p => p.Adapter == CH_Adapters.Text);
                    foreach (var profile in profiles)
                    {
                        CH_Profiles.Items.Add(profile.Name);
                    }
                    LoadIps(item.Description);

                    bool DHCPEnabled = NetworkConfigurator.DHCPEnabled(item.Description);
                    DHCP.Checked = DHCPEnabled;

                }
            }
        }

        private void CH_Profiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var profile = ProfileManager.Profiles.Find(p => p.Name == CH_Profiles.Text);
            if (profile != null)
            {
                TB_IP.Text = profile.AdapterSettings.IP;
                TB_IP_Secondary.Text = profile.AdapterSettings.IP_Secondary;
                TB_Mask.Text = profile.AdapterSettings.Mask;
                TB_Mask_Secondary.Text = profile.AdapterSettings.Mask_Secondary;
                TB_Gateway.Text = profile.AdapterSettings.Gateway;
                TB_DNS_1.Text = profile.AdapterSettings.DNS_1;
                TB_DNS_2.Text = profile.AdapterSettings.DNS_2;
            }
            isProfile = true;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProfileManager.Save();
            Settings.Save();
        }

        private void AddProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CH_Profiles.Text))
            {
                modCommon.Show("Enter the name of the new profile");
                return;
            }
            if (string.IsNullOrEmpty(CH_Adapters.Text))
            {
                modCommon.Show("Specify the adapter that you want to save in profile");
                return;
            }
            var settings = modCommon.CreateOne(TB_IP.Text, TB_Mask.Text, TB_Gateway.Text, TB_DNS_1.Text, TB_DNS_2.Text, TB_IP_Secondary.Text, TB_Mask_Secondary.Text);
            if (settings != null)
            {
                if (isProfile)
                {
                    ProfileManager.Update(CH_Adapters.Text, CH_Profiles.Text, settings);
                }
                else
                {
                    ProfileManager.Add(CH_Adapters.Text, CH_Profiles.Text, settings);
                }
            }
            CH_Profiles.Items.Add(CH_Profiles.Text);
        }

        private void BT_RemoveProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CH_Profiles.Text))
            {
                modCommon.Show("Select the Profile");
                return;
            }
            if (string.IsNullOrEmpty(CH_Adapters.Text))
            {
                modCommon.Show("Select the profile you want to delete");
                return;
            }
            if (ProfileManager.Remove(CH_Adapters.Text, CH_Profiles.Text))
            {
                CH_Profiles.Items.Remove(CH_Profiles.Text);
            }
        }

        private void Mask_Click(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Mask.Text) && !string.IsNullOrEmpty(TB_IP.Text))
            {
                TB_Mask.Text = "255.255.255.0";
            }
        }
        private void Mask_Secondary_Click(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Mask_Secondary.Text) && !string.IsNullOrEmpty(TB_IP_Secondary.Text))
            {
                TB_Mask_Secondary.Text = "255.255.255.0";
            }
        }
    }
}

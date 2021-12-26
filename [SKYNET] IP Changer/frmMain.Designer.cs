using System;
using System.Windows.Forms;

namespace SKYNET
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.TB_IP = new System.Windows.Forms.TextBox();
            this.lblip = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIPColor = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaskColor = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TB_Mask = new System.Windows.Forms.TextBox();
            this.txtGatewayColor = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TB_Gateway = new System.Windows.Forms.TextBox();
            this.txtDNSColor = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.TB_DNS_1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.TB_DNS_2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.TB_Mask_Secondary = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.TB_IP_Secondary = new System.Windows.Forms.TextBox();
            this.DHCP = new SKYNET.Controls.SKYNET_Check();
            this.Aolicar = new SKYNET_Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.LB_Current_DNS2 = new System.Windows.Forms.Label();
            this.LB_Current_DNS1 = new System.Windows.Forms.Label();
            this.LB_Current_Gateway = new System.Windows.Forms.Label();
            this.LB_Current_SubMask = new System.Windows.Forms.Label();
            this.LB_Current_IP = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.LB_Current_Mask_Secondary = new System.Windows.Forms.Label();
            this.LB_Current_IP_Secondary = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.CH_Adapters = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.CH_Profiles = new System.Windows.Forms.ComboBox();
            this.BT_RemoveProfile = new SKYNET_Button();
            this.BT_AddProfile = new SKYNET_Button();
            this.LB_MAC = new System.Windows.Forms.Label();
            this.txtIPColor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.txtMaskColor.SuspendLayout();
            this.panel4.SuspendLayout();
            this.txtGatewayColor.SuspendLayout();
            this.panel6.SuspendLayout();
            this.txtDNSColor.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_IP
            // 
            this.TB_IP.BackColor = System.Drawing.Color.White;
            this.TB_IP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_IP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TB_IP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TB_IP.Location = new System.Drawing.Point(3, 5);
            this.TB_IP.Name = "TB_IP";
            this.TB_IP.Size = new System.Drawing.Size(113, 16);
            this.TB_IP.TabIndex = 6;
            this.TB_IP.TextChanged += new System.EventHandler(this.IP_TextChanged);
            // 
            // lblip
            // 
            this.lblip.AutoSize = true;
            this.lblip.BackColor = System.Drawing.Color.Transparent;
            this.lblip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblip.Location = new System.Drawing.Point(9, 16);
            this.lblip.Name = "lblip";
            this.lblip.Size = new System.Drawing.Size(60, 15);
            this.lblip.TabIndex = 9;
            this.lblip.Text = "IP address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(9, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Subnet masks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(9, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Default gateway";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(9, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Preferred DNS";
            // 
            // txtIPColor
            // 
            this.txtIPColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.txtIPColor.Controls.Add(this.panel2);
            this.txtIPColor.Location = new System.Drawing.Point(168, 10);
            this.txtIPColor.Name = "txtIPColor";
            this.txtIPColor.Padding = new System.Windows.Forms.Padding(1);
            this.txtIPColor.Size = new System.Drawing.Size(121, 28);
            this.txtIPColor.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.TB_IP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 26);
            this.panel2.TabIndex = 21;
            // 
            // txtMaskColor
            // 
            this.txtMaskColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.txtMaskColor.Controls.Add(this.panel4);
            this.txtMaskColor.Location = new System.Drawing.Point(168, 46);
            this.txtMaskColor.Name = "txtMaskColor";
            this.txtMaskColor.Padding = new System.Windows.Forms.Padding(1);
            this.txtMaskColor.Size = new System.Drawing.Size(121, 28);
            this.txtMaskColor.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.TB_Mask);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 26);
            this.panel4.TabIndex = 21;
            // 
            // TB_Mask
            // 
            this.TB_Mask.BackColor = System.Drawing.Color.White;
            this.TB_Mask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Mask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TB_Mask.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TB_Mask.Location = new System.Drawing.Point(3, 5);
            this.TB_Mask.Name = "TB_Mask";
            this.TB_Mask.Size = new System.Drawing.Size(113, 16);
            this.TB_Mask.TabIndex = 6;
            this.TB_Mask.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mask_Click);
            this.TB_Mask.TextChanged += new System.EventHandler(this.IP_TextChanged);
            // 
            // txtGatewayColor
            // 
            this.txtGatewayColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.txtGatewayColor.Controls.Add(this.panel6);
            this.txtGatewayColor.Location = new System.Drawing.Point(168, 83);
            this.txtGatewayColor.Name = "txtGatewayColor";
            this.txtGatewayColor.Padding = new System.Windows.Forms.Padding(1);
            this.txtGatewayColor.Size = new System.Drawing.Size(121, 28);
            this.txtGatewayColor.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.TB_Gateway);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(119, 26);
            this.panel6.TabIndex = 21;
            // 
            // TB_Gateway
            // 
            this.TB_Gateway.BackColor = System.Drawing.Color.White;
            this.TB_Gateway.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Gateway.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TB_Gateway.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TB_Gateway.Location = new System.Drawing.Point(3, 5);
            this.TB_Gateway.Name = "TB_Gateway";
            this.TB_Gateway.Size = new System.Drawing.Size(113, 16);
            this.TB_Gateway.TabIndex = 6;
            this.TB_Gateway.TextChanged += new System.EventHandler(this.IP_TextChanged);
            // 
            // txtDNSColor
            // 
            this.txtDNSColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.txtDNSColor.Controls.Add(this.panel8);
            this.txtDNSColor.Location = new System.Drawing.Point(168, 134);
            this.txtDNSColor.Name = "txtDNSColor";
            this.txtDNSColor.Padding = new System.Windows.Forms.Padding(1);
            this.txtDNSColor.Size = new System.Drawing.Size(121, 28);
            this.txtDNSColor.TabIndex = 23;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.TB_DNS_1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(1, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(119, 26);
            this.panel8.TabIndex = 21;
            // 
            // TB_DNS_1
            // 
            this.TB_DNS_1.BackColor = System.Drawing.Color.White;
            this.TB_DNS_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_DNS_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TB_DNS_1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TB_DNS_1.Location = new System.Drawing.Point(3, 5);
            this.TB_DNS_1.Name = "TB_DNS_1";
            this.TB_DNS_1.Size = new System.Drawing.Size(113, 16);
            this.TB_DNS_1.TabIndex = 6;
            this.TB_DNS_1.TextChanged += new System.EventHandler(this.IP_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblip);
            this.panel1.Controls.Add(this.txtDNSColor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtGatewayColor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMaskColor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIPColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 211);
            this.panel1.TabIndex = 24;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Gainsboro;
            this.panel11.Location = new System.Drawing.Point(11, 121);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(280, 1);
            this.panel11.TabIndex = 26;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Location = new System.Drawing.Point(168, 171);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(1);
            this.panel7.Size = new System.Drawing.Size(121, 28);
            this.panel7.TabIndex = 25;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.TB_DNS_2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(1, 1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(119, 26);
            this.panel9.TabIndex = 21;
            // 
            // TB_DNS_2
            // 
            this.TB_DNS_2.BackColor = System.Drawing.Color.White;
            this.TB_DNS_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_DNS_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TB_DNS_2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TB_DNS_2.Location = new System.Drawing.Point(3, 5);
            this.TB_DNS_2.Name = "TB_DNS_2";
            this.TB_DNS_2.Size = new System.Drawing.Size(113, 16);
            this.TB_DNS_2.TabIndex = 6;
            this.TB_DNS_2.TextChanged += new System.EventHandler(this.IP_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label8.Location = new System.Drawing.Point(9, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Alternative DNS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(24, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Obtain an IP address automatically";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label7.Location = new System.Drawing.Point(24, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Additional IP address ";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(173)))), ((int)(((byte)(251)))));
            this.panel10.Controls.Add(this.panel1);
            this.panel10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(27, 127);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(1);
            this.panel10.Size = new System.Drawing.Size(310, 213);
            this.panel10.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(173)))), ((int)(((byte)(251)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(27, 366);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(1);
            this.panel3.Size = new System.Drawing.Size(310, 89);
            this.panel3.TabIndex = 34;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.panel13);
            this.panel5.Controls.Add(this.panel15);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(308, 87);
            this.panel5.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(9, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "IP address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(9, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Subnet masks";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Location = new System.Drawing.Point(168, 46);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(1);
            this.panel13.Size = new System.Drawing.Size(121, 28);
            this.panel13.TabIndex = 21;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Controls.Add(this.TB_Mask_Secondary);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(1, 1);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(119, 26);
            this.panel14.TabIndex = 21;
            // 
            // TB_Mask_Secondary
            // 
            this.TB_Mask_Secondary.BackColor = System.Drawing.Color.White;
            this.TB_Mask_Secondary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Mask_Secondary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TB_Mask_Secondary.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TB_Mask_Secondary.Location = new System.Drawing.Point(3, 5);
            this.TB_Mask_Secondary.Name = "TB_Mask_Secondary";
            this.TB_Mask_Secondary.Size = new System.Drawing.Size(113, 16);
            this.TB_Mask_Secondary.TabIndex = 6;
            this.TB_Mask_Secondary.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mask_Secondary_Click);
            this.TB_Mask_Secondary.TextChanged += new System.EventHandler(this.IP_TextChanged);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Location = new System.Drawing.Point(168, 10);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(1);
            this.panel15.Size = new System.Drawing.Size(121, 28);
            this.panel15.TabIndex = 20;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.Controls.Add(this.TB_IP_Secondary);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(1, 1);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(119, 26);
            this.panel16.TabIndex = 21;
            // 
            // TB_IP_Secondary
            // 
            this.TB_IP_Secondary.BackColor = System.Drawing.Color.White;
            this.TB_IP_Secondary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_IP_Secondary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TB_IP_Secondary.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TB_IP_Secondary.Location = new System.Drawing.Point(3, 5);
            this.TB_IP_Secondary.Name = "TB_IP_Secondary";
            this.TB_IP_Secondary.Size = new System.Drawing.Size(113, 16);
            this.TB_IP_Secondary.TabIndex = 6;
            this.TB_IP_Secondary.TextChanged += new System.EventHandler(this.IP_TextChanged);
            // 
            // DHCP
            // 
            this.DHCP.BackColor = System.Drawing.Color.Transparent;
            this.DHCP.Checked = false;
            this.DHCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DHCP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DHCP.Location = new System.Drawing.Point(296, 92);
            this.DHCP.Name = "DHCP";
            this.DHCP.Size = new System.Drawing.Size(40, 29);
            this.DHCP.TabIndex = 27;
            this.DHCP.CheckedChanged += new System.EventHandler<bool>(this.Check_CheckedChanged);
            // 
            // Aolicar
            // 
            this.Aolicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(173)))), ((int)(((byte)(251)))));
            this.Aolicar.BackColorMouseOver = System.Drawing.Color.Empty;
            this.Aolicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aolicar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aolicar.ForeColor = System.Drawing.Color.White;
            this.Aolicar.ForeColorMouseOver = System.Drawing.Color.Empty;
            this.Aolicar.ImageAlignment = SKYNET_Button._ImgAlign.Left;
            this.Aolicar.ImageIcon = null;
            this.Aolicar.Location = new System.Drawing.Point(219, 464);
            this.Aolicar.MenuMode = false;
            this.Aolicar.Name = "Aolicar";
            this.Aolicar.Rounded = false;
            this.Aolicar.Size = new System.Drawing.Size(117, 30);
            this.Aolicar.Style = SKYNET_Button._Style.TextOnly;
            this.Aolicar.TabIndex = 16;
            this.Aolicar.Text = "OK";
            this.Aolicar.Click += new System.EventHandler(this.Change_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(369, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Current configuration";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel12.Controls.Add(this.LB_Current_DNS2);
            this.panel12.Controls.Add(this.LB_Current_DNS1);
            this.panel12.Controls.Add(this.LB_Current_Gateway);
            this.panel12.Controls.Add(this.LB_Current_SubMask);
            this.panel12.Controls.Add(this.LB_Current_IP);
            this.panel12.Controls.Add(this.panel17);
            this.panel12.Controls.Add(this.label10);
            this.panel12.Controls.Add(this.label11);
            this.panel12.Controls.Add(this.label12);
            this.panel12.Controls.Add(this.label13);
            this.panel12.Controls.Add(this.label14);
            this.panel12.Location = new System.Drawing.Point(372, 127);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(260, 211);
            this.panel12.TabIndex = 36;
            // 
            // LB_Current_DNS2
            // 
            this.LB_Current_DNS2.BackColor = System.Drawing.Color.Transparent;
            this.LB_Current_DNS2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LB_Current_DNS2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LB_Current_DNS2.Location = new System.Drawing.Point(154, 178);
            this.LB_Current_DNS2.Name = "LB_Current_DNS2";
            this.LB_Current_DNS2.Size = new System.Drawing.Size(94, 15);
            this.LB_Current_DNS2.TabIndex = 37;
            this.LB_Current_DNS2.Text = "0.0.0.0";
            this.LB_Current_DNS2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LB_Current_DNS1
            // 
            this.LB_Current_DNS1.BackColor = System.Drawing.Color.Transparent;
            this.LB_Current_DNS1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LB_Current_DNS1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LB_Current_DNS1.Location = new System.Drawing.Point(154, 141);
            this.LB_Current_DNS1.Name = "LB_Current_DNS1";
            this.LB_Current_DNS1.Size = new System.Drawing.Size(94, 15);
            this.LB_Current_DNS1.TabIndex = 36;
            this.LB_Current_DNS1.Text = "0.0.0.0";
            this.LB_Current_DNS1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LB_Current_Gateway
            // 
            this.LB_Current_Gateway.BackColor = System.Drawing.Color.Transparent;
            this.LB_Current_Gateway.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LB_Current_Gateway.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LB_Current_Gateway.Location = new System.Drawing.Point(154, 90);
            this.LB_Current_Gateway.Name = "LB_Current_Gateway";
            this.LB_Current_Gateway.Size = new System.Drawing.Size(94, 15);
            this.LB_Current_Gateway.TabIndex = 35;
            this.LB_Current_Gateway.Text = "0.0.0.0";
            this.LB_Current_Gateway.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LB_Current_SubMask
            // 
            this.LB_Current_SubMask.BackColor = System.Drawing.Color.Transparent;
            this.LB_Current_SubMask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LB_Current_SubMask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LB_Current_SubMask.Location = new System.Drawing.Point(154, 51);
            this.LB_Current_SubMask.Name = "LB_Current_SubMask";
            this.LB_Current_SubMask.Size = new System.Drawing.Size(94, 15);
            this.LB_Current_SubMask.TabIndex = 34;
            this.LB_Current_SubMask.Text = "0.0.0.0";
            this.LB_Current_SubMask.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LB_Current_IP
            // 
            this.LB_Current_IP.BackColor = System.Drawing.Color.Transparent;
            this.LB_Current_IP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LB_Current_IP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LB_Current_IP.Location = new System.Drawing.Point(154, 17);
            this.LB_Current_IP.Name = "LB_Current_IP";
            this.LB_Current_IP.Size = new System.Drawing.Size(94, 15);
            this.LB_Current_IP.TabIndex = 33;
            this.LB_Current_IP.Text = "0.0.0.0";
            this.LB_Current_IP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Gainsboro;
            this.panel17.Location = new System.Drawing.Point(10, 122);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(230, 1);
            this.panel17.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label10.Location = new System.Drawing.Point(8, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Alternative DNS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label11.Location = new System.Drawing.Point(8, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "IP address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label12.Location = new System.Drawing.Point(8, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Subnet masks";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label13.Location = new System.Drawing.Point(8, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "Default gateway";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label14.Location = new System.Drawing.Point(8, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "Preferred DNS";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel18.Controls.Add(this.LB_Current_Mask_Secondary);
            this.panel18.Controls.Add(this.LB_Current_IP_Secondary);
            this.panel18.Controls.Add(this.label15);
            this.panel18.Controls.Add(this.label16);
            this.panel18.Location = new System.Drawing.Point(372, 367);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(260, 88);
            this.panel18.TabIndex = 38;
            // 
            // LB_Current_Mask_Secondary
            // 
            this.LB_Current_Mask_Secondary.BackColor = System.Drawing.Color.Transparent;
            this.LB_Current_Mask_Secondary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LB_Current_Mask_Secondary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LB_Current_Mask_Secondary.Location = new System.Drawing.Point(154, 50);
            this.LB_Current_Mask_Secondary.Name = "LB_Current_Mask_Secondary";
            this.LB_Current_Mask_Secondary.Size = new System.Drawing.Size(94, 15);
            this.LB_Current_Mask_Secondary.TabIndex = 39;
            this.LB_Current_Mask_Secondary.Text = "0.0.0.0";
            this.LB_Current_Mask_Secondary.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LB_Current_IP_Secondary
            // 
            this.LB_Current_IP_Secondary.BackColor = System.Drawing.Color.Transparent;
            this.LB_Current_IP_Secondary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LB_Current_IP_Secondary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LB_Current_IP_Secondary.Location = new System.Drawing.Point(154, 16);
            this.LB_Current_IP_Secondary.Name = "LB_Current_IP_Secondary";
            this.LB_Current_IP_Secondary.Size = new System.Drawing.Size(94, 15);
            this.LB_Current_IP_Secondary.TabIndex = 38;
            this.LB_Current_IP_Secondary.Text = "0.0.0.0";
            this.LB_Current_IP_Secondary.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label15.Location = new System.Drawing.Point(9, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 15);
            this.label15.TabIndex = 11;
            this.label15.Text = "IP address";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label16.Location = new System.Drawing.Point(9, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 15);
            this.label16.TabIndex = 12;
            this.label16.Text = "Subnet masks";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(24, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 15);
            this.label17.TabIndex = 39;
            this.label17.Text = "Network Adapter";
            // 
            // CH_Adapters
            // 
            this.CH_Adapters.FormattingEnabled = true;
            this.CH_Adapters.Location = new System.Drawing.Point(27, 27);
            this.CH_Adapters.Name = "CH_Adapters";
            this.CH_Adapters.Size = new System.Drawing.Size(310, 23);
            this.CH_Adapters.TabIndex = 40;
            this.CH_Adapters.SelectedIndexChanged += new System.EventHandler(this.Adapters_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(370, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 15);
            this.label18.TabIndex = 41;
            this.label18.Text = "Network Profiles";
            // 
            // CH_Profiles
            // 
            this.CH_Profiles.FormattingEnabled = true;
            this.CH_Profiles.Location = new System.Drawing.Point(372, 27);
            this.CH_Profiles.Name = "CH_Profiles";
            this.CH_Profiles.Size = new System.Drawing.Size(260, 23);
            this.CH_Profiles.TabIndex = 42;
            this.CH_Profiles.SelectedIndexChanged += new System.EventHandler(this.CH_Profiles_SelectedIndexChanged);
            // 
            // BT_RemoveProfile
            // 
            this.BT_RemoveProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(173)))), ((int)(((byte)(251)))));
            this.BT_RemoveProfile.BackColorMouseOver = System.Drawing.Color.Empty;
            this.BT_RemoveProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_RemoveProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_RemoveProfile.ForeColor = System.Drawing.Color.White;
            this.BT_RemoveProfile.ForeColorMouseOver = System.Drawing.Color.Empty;
            this.BT_RemoveProfile.ImageAlignment = SKYNET_Button._ImgAlign.Left;
            this.BT_RemoveProfile.ImageIcon = null;
            this.BT_RemoveProfile.Location = new System.Drawing.Point(507, 56);
            this.BT_RemoveProfile.MenuMode = false;
            this.BT_RemoveProfile.Name = "BT_RemoveProfile";
            this.BT_RemoveProfile.Rounded = false;
            this.BT_RemoveProfile.Size = new System.Drawing.Size(125, 30);
            this.BT_RemoveProfile.Style = SKYNET_Button._Style.TextOnly;
            this.BT_RemoveProfile.TabIndex = 43;
            this.BT_RemoveProfile.Text = "REMOVE";
            this.BT_RemoveProfile.Click += new System.EventHandler(this.BT_RemoveProfile_Click);
            // 
            // BT_AddProfile
            // 
            this.BT_AddProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(173)))), ((int)(((byte)(251)))));
            this.BT_AddProfile.BackColorMouseOver = System.Drawing.Color.Empty;
            this.BT_AddProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_AddProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AddProfile.ForeColor = System.Drawing.Color.White;
            this.BT_AddProfile.ForeColorMouseOver = System.Drawing.Color.Empty;
            this.BT_AddProfile.ImageAlignment = SKYNET_Button._ImgAlign.Left;
            this.BT_AddProfile.ImageIcon = null;
            this.BT_AddProfile.Location = new System.Drawing.Point(372, 56);
            this.BT_AddProfile.MenuMode = false;
            this.BT_AddProfile.Name = "BT_AddProfile";
            this.BT_AddProfile.Rounded = false;
            this.BT_AddProfile.Size = new System.Drawing.Size(125, 30);
            this.BT_AddProfile.Style = SKYNET_Button._Style.TextOnly;
            this.BT_AddProfile.TabIndex = 44;
            this.BT_AddProfile.Text = "CREATE";
            this.BT_AddProfile.Click += new System.EventHandler(this.AddProfile_Click);
            // 
            // LB_MAC
            // 
            this.LB_MAC.AutoSize = true;
            this.LB_MAC.BackColor = System.Drawing.Color.Transparent;
            this.LB_MAC.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LB_MAC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LB_MAC.Location = new System.Drawing.Point(24, 55);
            this.LB_MAC.Name = "LB_MAC";
            this.LB_MAC.Size = new System.Drawing.Size(0, 13);
            this.LB_MAC.TabIndex = 45;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 520);
            this.Controls.Add(this.LB_MAC);
            this.Controls.Add(this.BT_AddProfile);
            this.Controls.Add(this.BT_RemoveProfile);
            this.Controls.Add(this.CH_Profiles);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CH_Adapters);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DHCP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Aolicar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.txtIPColor.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.txtMaskColor.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.txtGatewayColor.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.txtDNSColor.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private SKYNET_Button Aolicar;
        public System.Windows.Forms.TextBox TB_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel txtIPColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel txtMaskColor;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox TB_Mask;
        private System.Windows.Forms.Panel txtGatewayColor;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.TextBox TB_Gateway;
        private System.Windows.Forms.Panel txtDNSColor;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.TextBox TB_DNS_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private SKYNET.Controls.SKYNET_Check DHCP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        public System.Windows.Forms.TextBox TB_Mask_Secondary;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        public System.Windows.Forms.TextBox TB_IP_Secondary;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.TextBox TB_DNS_2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label LB_Current_IP;
        private System.Windows.Forms.Label LB_Current_DNS2;
        private System.Windows.Forms.Label LB_Current_DNS1;
        private System.Windows.Forms.Label LB_Current_Gateway;
        private System.Windows.Forms.Label LB_Current_SubMask;
        private System.Windows.Forms.Label LB_Current_Mask_Secondary;
        private System.Windows.Forms.Label LB_Current_IP_Secondary;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox CH_Adapters;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox CH_Profiles;
        private SKYNET_Button BT_RemoveProfile;
        private SKYNET_Button BT_AddProfile;
        private System.Windows.Forms.Label LB_MAC;
    }
}


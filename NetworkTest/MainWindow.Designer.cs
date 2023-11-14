namespace NetworkTest
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            button1 = new Button();
            address = new TextBox();
            port = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pingTime = new TextBox();
            pingResult = new TextBox();
            label3 = new Label();
            label4 = new Label();
            portStatus = new TextBox();
            label5 = new Label();
            gateway = new TextBox();
            label6 = new Label();
            menuStrip1 = new MenuStrip();
            logsToolStripMenuItem = new ToolStripMenuItem();
            logsToolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            label7 = new Label();
            version = new Label();
            ipAddress = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(235, 133);
            button1.Name = "button1";
            button1.Size = new Size(311, 45);
            button1.TabIndex = 0;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonGoClick;
            // 
            // address
            // 
            address.Location = new Point(235, 70);
            address.MaxLength = 50;
            address.Name = "address";
            address.Size = new Size(245, 23);
            address.TabIndex = 1;
            address.TextAlign = HorizontalAlignment.Center;
            // 
            // port
            // 
            port.Location = new Point(486, 70);
            port.MaxLength = 5;
            port.Name = "port";
            port.Size = new Size(57, 23);
            port.TabIndex = 2;
            port.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 52);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(486, 52);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 4;
            label2.Text = "Port";
            // 
            // pingTime
            // 
            pingTime.Enabled = false;
            pingTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pingTime.Location = new Point(397, 365);
            pingTime.Name = "pingTime";
            pingTime.ReadOnly = true;
            pingTime.Size = new Size(235, 23);
            pingTime.TabIndex = 5;
            pingTime.TextAlign = HorizontalAlignment.Center;
            // 
            // pingResult
            // 
            pingResult.Enabled = false;
            pingResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pingResult.Location = new Point(145, 365);
            pingResult.Name = "pingResult";
            pingResult.ReadOnly = true;
            pingResult.Size = new Size(235, 23);
            pingResult.TabIndex = 6;
            pingResult.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 347);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 7;
            label3.Text = "Ping result";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 347);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 8;
            label4.Text = "Ping time";
            // 
            // portStatus
            // 
            portStatus.Enabled = false;
            portStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            portStatus.Location = new Point(145, 301);
            portStatus.Name = "portStatus";
            portStatus.ReadOnly = true;
            portStatus.Size = new Size(235, 23);
            portStatus.TabIndex = 9;
            portStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 283);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 10;
            label5.Text = "Port status";
            // 
            // gateway
            // 
            gateway.Enabled = false;
            gateway.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gateway.Location = new Point(397, 301);
            gateway.Name = "gateway";
            gateway.ReadOnly = true;
            gateway.Size = new Size(235, 23);
            gateway.TabIndex = 11;
            gateway.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(397, 283);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 12;
            label6.Text = "Gateway";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { logsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // logsToolStripMenuItem
            // 
            logsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logsToolStripMenuItem1, aboutToolStripMenuItem });
            logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            logsToolStripMenuItem.Size = new Size(46, 20);
            logsToolStripMenuItem.Text = "Tools";
            // 
            // logsToolStripMenuItem1
            // 
            logsToolStripMenuItem1.Name = "logsToolStripMenuItem1";
            logsToolStripMenuItem1.Size = new Size(107, 22);
            logsToolStripMenuItem1.Text = "Logs";
            logsToolStripMenuItem1.Click += OpenLogsWindow;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += ShowAbout;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(145, 230);
            label7.Name = "label7";
            label7.Size = new Size(487, 2);
            label7.TabIndex = 14;
            // 
            // version
            // 
            version.AutoSize = true;
            version.Location = new Point(718, 426);
            version.Name = "version";
            version.Size = new Size(70, 15);
            version.TabIndex = 15;
            version.Text = "App version";
            // 
            // ipAddress
            // 
            ipAddress.AutoSize = true;
            ipAddress.Location = new Point(235, 96);
            ipAddress.Name = "ipAddress";
            ipAddress.Size = new Size(0, 15);
            ipAddress.TabIndex = 16;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(ipAddress);
            Controls.Add(version);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(gateway);
            Controls.Add(label5);
            Controls.Add(portStatus);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pingResult);
            Controls.Add(pingTime);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(port);
            Controls.Add(address);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Network Test";
            Load += MainWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox address;
        private TextBox port;
        private Label label1;
        private Label label2;
        private TextBox pingTime;
        private TextBox pingResult;
        private Label label3;
        private Label label4;
        private TextBox portStatus;
        private Label label5;
        private TextBox gateway;
        private Label label6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem logsToolStripMenuItem;
        private ToolStripMenuItem logsToolStripMenuItem1;
        private Label label7;
        private Label version;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label ipAddress;
    }
}
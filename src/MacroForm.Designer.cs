namespace NotesTasks
{
    partial class MacroForm
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
            components = new System.ComponentModel.Container();
            mainPanel = new Panel();
            debugPanel = new Panel();
            debugLabel = new TextBox();
            btnToggleDebug = new Button();
            chkJitterEnabled = new CheckBox();
            strengthPanel1 = new Panel();
            lblRecoilStrengthValue = new Label();
            lblRecoilStrengthPrefix = new Label();
            trackBarRecoil = new TrackBar();
            strengthPanel2 = new Panel();
            lblJitterStrengthValue = new Label();
            lblJitterStrengthPrefix = new Label();
            trackBarJitter = new TrackBar();
            settingsPanel = new Panel();
            lblCurrentKeyValue = new Label();
            lblCurrentKeyPrefix = new Label();
            btnSetKey = new Button();
            chkMinimizeToTray = new CheckBox();
            notifyIcon = new NotifyIcon(components);
            trayContextMenu = new ContextMenuStrip(components);
            showWindowMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            mainPanel.SuspendLayout();
            debugPanel.SuspendLayout();
            strengthPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarRecoil).BeginInit();
            strengthPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarJitter).BeginInit();
            settingsPanel.SuspendLayout();
            trayContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.FromArgb(30, 30, 30);
            mainPanel.Controls.Add(debugPanel);
            mainPanel.Controls.Add(strengthPanel1);
            mainPanel.Controls.Add(btnToggleDebug);
            mainPanel.Controls.Add(strengthPanel2);
            mainPanel.Controls.Add(settingsPanel);
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(14, 12, 14, 12);
            mainPanel.Size = new Size(434, 593);
            mainPanel.TabIndex = 0;
            // 
            // debugPanel
            // 
            debugPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            debugPanel.AutoScroll = true;
            debugPanel.BackColor = Color.FromArgb(20, 20, 20);
            debugPanel.BorderStyle = BorderStyle.FixedSingle;
            debugPanel.Controls.Add(debugLabel);
            debugPanel.Location = new Point(14, 477);
            debugPanel.Margin = new Padding(3, 2, 3, 2);
            debugPanel.Name = "debugPanel";
            debugPanel.Padding = new Padding(7, 6, 7, 6);
            debugPanel.Size = new Size(406, 102);
            debugPanel.TabIndex = 7;
            debugPanel.Visible = false;
            // 
            // debugLabel
            // 
            debugLabel.BackColor = Color.FromArgb(20, 20, 20);
            debugLabel.BorderStyle = BorderStyle.None;
            debugLabel.Dock = DockStyle.Fill;
            debugLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            debugLabel.ForeColor = Color.White;
            debugLabel.Location = new Point(7, 6);
            debugLabel.Margin = new Padding(3, 2, 3, 2);
            debugLabel.Multiline = true;
            debugLabel.Name = "debugLabel";
            debugLabel.ReadOnly = true;
            debugLabel.ScrollBars = ScrollBars.Vertical;
            debugLabel.Size = new Size(390, 88);
            debugLabel.TabIndex = 0;
            // 
            // btnToggleDebug
            // 
            btnToggleDebug.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnToggleDebug.FlatStyle = FlatStyle.Flat;
            btnToggleDebug.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnToggleDebug.ForeColor = Color.White;
            btnToggleDebug.Location = new Point(14, 433);
            btnToggleDebug.Margin = new Padding(0, 0, 0, 12);
            btnToggleDebug.Name = "btnToggleDebug";
            btnToggleDebug.Size = new Size(406, 30);
            btnToggleDebug.TabIndex = 5;
            btnToggleDebug.Text = "Show Debug Info";
            // 
            // chkJitterEnabled
            // 
            chkJitterEnabled.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkJitterEnabled.AutoSize = true;
            chkJitterEnabled.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chkJitterEnabled.ForeColor = Color.White;
            chkJitterEnabled.Location = new Point(261, 7);
            chkJitterEnabled.Margin = new Padding(0, 0, 0, 12);
            chkJitterEnabled.Name = "chkJitterEnabled";
            chkJitterEnabled.Size = new Size(142, 23);
            chkJitterEnabled.TabIndex = 4;
            chkJitterEnabled.Text = "Enable Jitter Mode";
            // 
            // strengthPanel1
            // 
            strengthPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            strengthPanel1.Controls.Add(lblJitterStrengthValue);
            strengthPanel1.Controls.Add(trackBarJitter);
            strengthPanel1.Controls.Add(lblJitterStrengthPrefix);
            strengthPanel1.Controls.Add(chkJitterEnabled);
            strengthPanel1.Location = new Point(14, 318);
            strengthPanel1.Margin = new Padding(0, 0, 0, 12);
            strengthPanel1.Name = "strengthPanel1";
            strengthPanel1.Size = new Size(406, 101);
            strengthPanel1.TabIndex = 9;
            // 
            // lblRecoilStrengthValue
            // 
            lblRecoilStrengthValue.AutoSize = true;
            lblRecoilStrengthValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecoilStrengthValue.ForeColor = Color.White;
            lblRecoilStrengthValue.Location = new Point(111, 10);
            lblRecoilStrengthValue.Margin = new Padding(0);
            lblRecoilStrengthValue.Name = "lblRecoilStrengthValue";
            lblRecoilStrengthValue.Size = new Size(17, 19);
            lblRecoilStrengthValue.TabIndex = 1;
            lblRecoilStrengthValue.Text = "3";
            // 
            // lblRecoilStrengthPrefix
            // 
            lblRecoilStrengthPrefix.AutoSize = true;
            lblRecoilStrengthPrefix.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecoilStrengthPrefix.ForeColor = Color.White;
            lblRecoilStrengthPrefix.Location = new Point(8, 10);
            lblRecoilStrengthPrefix.Margin = new Padding(0);
            lblRecoilStrengthPrefix.Name = "lblRecoilStrengthPrefix";
            lblRecoilStrengthPrefix.Size = new Size(108, 19);
            lblRecoilStrengthPrefix.TabIndex = 0;
            lblRecoilStrengthPrefix.Text = "Recoil Strength: ";
            // 
            // trackBarRecoil
            // 
            trackBarRecoil.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackBarRecoil.Location = new Point(0, 48);
            trackBarRecoil.Margin = new Padding(0);
            trackBarRecoil.Maximum = 20;
            trackBarRecoil.Minimum = 1;
            trackBarRecoil.Name = "trackBarRecoil";
            trackBarRecoil.Size = new Size(406, 45);
            trackBarRecoil.TabIndex = 8;
            trackBarRecoil.Value = 3;
            // 
            // strengthPanel2
            // 
            strengthPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            strengthPanel2.Controls.Add(lblRecoilStrengthPrefix);
            strengthPanel2.Controls.Add(lblRecoilStrengthValue);
            strengthPanel2.Controls.Add(trackBarRecoil);
            strengthPanel2.Location = new Point(14, 204);
            strengthPanel2.Margin = new Padding(0, 0, 0, 12);
            strengthPanel2.Name = "strengthPanel2";
            strengthPanel2.Size = new Size(406, 102);
            strengthPanel2.TabIndex = 10;
            // 
            // lblJitterStrengthValue
            // 
            lblJitterStrengthValue.AutoSize = true;
            lblJitterStrengthValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblJitterStrengthValue.ForeColor = Color.White;
            lblJitterStrengthValue.Location = new Point(111, 11);
            lblJitterStrengthValue.Margin = new Padding(0);
            lblJitterStrengthValue.Name = "lblJitterStrengthValue";
            lblJitterStrengthValue.Size = new Size(17, 19);
            lblJitterStrengthValue.TabIndex = 1;
            lblJitterStrengthValue.Text = "3";
            lblJitterStrengthValue.Click += lblJitterStrengthValue_Click;
            // 
            // lblJitterStrengthPrefix
            // 
            lblJitterStrengthPrefix.AutoSize = true;
            lblJitterStrengthPrefix.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblJitterStrengthPrefix.ForeColor = Color.White;
            lblJitterStrengthPrefix.Location = new Point(8, 11);
            lblJitterStrengthPrefix.Margin = new Padding(0);
            lblJitterStrengthPrefix.Name = "lblJitterStrengthPrefix";
            lblJitterStrengthPrefix.Size = new Size(103, 19);
            lblJitterStrengthPrefix.TabIndex = 0;
            lblJitterStrengthPrefix.Text = "Jitter Strength: ";
            // 
            // trackBarJitter
            // 
            trackBarJitter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackBarJitter.Location = new Point(0, 46);
            trackBarJitter.Margin = new Padding(0);
            trackBarJitter.Maximum = 20;
            trackBarJitter.Minimum = 1;
            trackBarJitter.Name = "trackBarJitter";
            trackBarJitter.Size = new Size(406, 45);
            trackBarJitter.TabIndex = 3;
            trackBarJitter.Value = 3;
            // 
            // settingsPanel
            // 
            settingsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            settingsPanel.Controls.Add(button1);
            settingsPanel.Controls.Add(label1);
            settingsPanel.Controls.Add(label2);
            settingsPanel.Controls.Add(btnSetKey);
            settingsPanel.Controls.Add(lblCurrentKeyValue);
            settingsPanel.Controls.Add(lblCurrentKeyPrefix);
            settingsPanel.Controls.Add(chkMinimizeToTray);
            settingsPanel.Location = new Point(14, 12);
            settingsPanel.Margin = new Padding(0, 0, 0, 12);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(406, 180);
            settingsPanel.TabIndex = 11;
            // 
            // lblCurrentKeyValue
            // 
            lblCurrentKeyValue.AutoSize = true;
            lblCurrentKeyValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentKeyValue.ForeColor = Color.White;
            lblCurrentKeyValue.Location = new Point(131, 17);
            lblCurrentKeyValue.Margin = new Padding(0);
            lblCurrentKeyValue.Name = "lblCurrentKeyValue";
            lblCurrentKeyValue.Size = new Size(56, 19);
            lblCurrentKeyValue.TabIndex = 1;
            lblCurrentKeyValue.Text = "Capital";
            // 
            // lblCurrentKeyPrefix
            // 
            lblCurrentKeyPrefix.AutoSize = true;
            lblCurrentKeyPrefix.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentKeyPrefix.ForeColor = Color.White;
            lblCurrentKeyPrefix.Location = new Point(8, 17);
            lblCurrentKeyPrefix.Margin = new Padding(0);
            lblCurrentKeyPrefix.Name = "lblCurrentKeyPrefix";
            lblCurrentKeyPrefix.Size = new Size(125, 19);
            lblCurrentKeyPrefix.TabIndex = 0;
            lblCurrentKeyPrefix.Text = "Macro Toggle Key: ";
            // 
            // btnSetKey
            // 
            btnSetKey.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSetKey.FlatStyle = FlatStyle.Flat;
            btnSetKey.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetKey.ForeColor = Color.White;
            btnSetKey.Location = new Point(0, 49);
            btnSetKey.Margin = new Padding(0, 0, 0, 12);
            btnSetKey.Name = "btnSetKey";
            btnSetKey.Size = new Size(406, 30);
            btnSetKey.TabIndex = 1;
            btnSetKey.Text = "Set Toggle Key";
            // 
            // chkMinimizeToTray
            // 
            chkMinimizeToTray.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkMinimizeToTray.AutoSize = true;
            chkMinimizeToTray.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chkMinimizeToTray.ForeColor = Color.White;
            chkMinimizeToTray.Location = new Point(274, 2);
            chkMinimizeToTray.Margin = new Padding(3, 2, 3, 2);
            chkMinimizeToTray.Name = "chkMinimizeToTray";
            chkMinimizeToTray.Size = new Size(129, 23);
            chkMinimizeToTray.TabIndex = 6;
            chkMinimizeToTray.Text = "Minimize to Tray";
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = trayContextMenu;
            notifyIcon.Text = "Mouse Macro";
            notifyIcon.Visible = true;
            // 
            // trayContextMenu
            // 
            trayContextMenu.Items.AddRange(new ToolStripItem[] { showWindowMenuItem, exitMenuItem });
            trayContextMenu.Name = "trayContextMenu";
            trayContextMenu.Size = new Size(151, 48);
            // 
            // showWindowMenuItem
            // 
            showWindowMenuItem.Name = "showWindowMenuItem";
            showWindowMenuItem.Size = new Size(150, 22);
            showWindowMenuItem.Text = "Show Window";
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(150, 22);
            exitMenuItem.Text = "Exit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(131, 98);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(20, 19);
            label1.TabIndex = 8;
            label1.Text = "Q";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 98);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(116, 19);
            label2.TabIndex = 7;
            label2.Text = "Jitter Toggle Key: ";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 130);
            button1.Margin = new Padding(0, 0, 0, 12);
            button1.Name = "button1";
            button1.Size = new Size(406, 30);
            button1.TabIndex = 9;
            button1.Text = "Set Toggle Key";
            // 
            // MacroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(434, 593);
            Controls.Add(mainPanel);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(352, 385);
            Name = "MacroForm";
            Text = "Notes&Tasks";
            mainPanel.ResumeLayout(false);
            debugPanel.ResumeLayout(false);
            debugPanel.PerformLayout();
            strengthPanel1.ResumeLayout(false);
            strengthPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarRecoil).EndInit();
            strengthPanel2.ResumeLayout(false);
            strengthPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarJitter).EndInit();
            settingsPanel.ResumeLayout(false);
            settingsPanel.PerformLayout();
            trayContextMenu.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnSetKey;
        private System.Windows.Forms.Label lblCurrentKeyPrefix;
        private System.Windows.Forms.Label lblCurrentKeyValue;
        private System.Windows.Forms.TrackBar trackBarJitter;
        private System.Windows.Forms.Label lblJitterStrengthPrefix;
        private System.Windows.Forms.Label lblJitterStrengthValue;
        private System.Windows.Forms.TrackBar trackBarRecoil;
        private System.Windows.Forms.Label lblRecoilStrengthPrefix;
        private System.Windows.Forms.Label lblRecoilStrengthValue;
        private System.Windows.Forms.Button btnToggleDebug;
        private System.Windows.Forms.Panel debugPanel;
        private System.Windows.Forms.TextBox debugLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem showWindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.CheckBox chkMinimizeToTray;
        private System.Windows.Forms.CheckBox chkJitterEnabled;
        private System.Windows.Forms.Panel strengthPanel1;
        private System.Windows.Forms.Panel strengthPanel2;
        private System.Windows.Forms.Panel settingsPanel;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}

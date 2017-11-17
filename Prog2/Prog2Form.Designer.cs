namespace UPVApp
{
    partial class Prog2Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addressMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createLetterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertAddressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertParcelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addressMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressMenuStrip
            // 
            this.addressMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.addressMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.addressMenuStrip.Name = "addressMenuStrip";
            this.addressMenuStrip.Size = new System.Drawing.Size(440, 24);
            this.addressMenuStrip.TabIndex = 0;
            this.addressMenuStrip.Text = "addressMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Delete)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About ";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.End)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAddressToolStripMenuItem,
            this.createLetterToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F10)));
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.insertToolStripMenuItem.Text = "&Insert";
            // 
            // createAddressToolStripMenuItem
            // 
            this.createAddressToolStripMenuItem.Name = "createAddressToolStripMenuItem";
            this.createAddressToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.createAddressToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.createAddressToolStripMenuItem.Text = "Create Address";
            this.createAddressToolStripMenuItem.Click += new System.EventHandler(this.createAddressToolStripMenuItem_Click);
            // 
            // createLetterToolStripMenuItem
            // 
            this.createLetterToolStripMenuItem.Name = "createLetterToolStripMenuItem";
            this.createLetterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.createLetterToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.createLetterToolStripMenuItem.Text = "Create Letter";
            this.createLetterToolStripMenuItem.Click += new System.EventHandler(this.createLetterToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertAddressesToolStripMenuItem,
            this.insertParcelsToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F11)));
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "&Report";
            // 
            // insertAddressesToolStripMenuItem
            // 
            this.insertAddressesToolStripMenuItem.Name = "insertAddressesToolStripMenuItem";
            this.insertAddressesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.insertAddressesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.insertAddressesToolStripMenuItem.Text = "Insert Addresses";
            this.insertAddressesToolStripMenuItem.Click += new System.EventHandler(this.insertAddressesToolStripMenuItem_Click);
            // 
            // insertParcelsToolStripMenuItem
            // 
            this.insertParcelsToolStripMenuItem.Name = "insertParcelsToolStripMenuItem";
            this.insertParcelsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.insertParcelsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.insertParcelsToolStripMenuItem.Text = "Insert Parcels";
            this.insertParcelsToolStripMenuItem.Click += new System.EventHandler(this.insertParcelsToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(440, 387);
            this.textBox1.TabIndex = 3;
            // 
            // Prog2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 411);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addressMenuStrip);
            this.MainMenuStrip = this.addressMenuStrip;
            this.Name = "Prog2Form";
            this.Text = "Form1";
            this.addressMenuStrip.ResumeLayout(false);
            this.addressMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip addressMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createLetterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertAddressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertParcelsToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}


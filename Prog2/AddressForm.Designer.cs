namespace UPVApp
{
    partial class AddressForm
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
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.addressErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cityErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.stateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.zipErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(10, 55);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(20, 112);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(13, 142);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 3;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(23, 170);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(25, 13);
            this.zipLabel.TabIndex = 4;
            this.zipLabel.Text = "Zip:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(76, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(172, 20);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            this.nameTextBox.Validated += new System.EventHandler(this.nameTextBox_Validated);
            // 
            // address1TextBox
            // 
            this.address1TextBox.Location = new System.Drawing.Point(76, 55);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(172, 20);
            this.address1TextBox.TabIndex = 6;
            this.address1TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.address1TextBox_Validating);
            this.address1TextBox.Validated += new System.EventHandler(this.address1TextBox_Validated);
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(76, 82);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(172, 20);
            this.address2TextBox.TabIndex = 7;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(76, 112);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(142, 20);
            this.cityTextBox.TabIndex = 8;
            this.cityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cityTextBox_Validating);
            this.cityTextBox.Validated += new System.EventHandler(this.cityTextBox_Validated);
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(76, 170);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipTextBox.TabIndex = 10;
            this.zipTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.zipTextBox_Validating);
            this.zipTextBox.Validated += new System.EventHandler(this.zipTextBox_Validated);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(101, 214);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 11;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(13, 214);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(76, 142);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(100, 21);
            this.stateComboBox.TabIndex = 13;
            this.stateComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.stateComboBox_Validating);
            this.stateComboBox.Validated += new System.EventHandler(this.stateComboBox_Validated);
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // addressErrorProvider
            // 
            this.addressErrorProvider.ContainerControl = this;
            // 
            // cityErrorProvider
            // 
            this.cityErrorProvider.ContainerControl = this;
            // 
            // stateErrorProvider
            // 
            this.stateErrorProvider.ContainerControl = this;
            // 
            // zipErrorProvider
            // 
            this.zipErrorProvider.ContainerControl = this;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 261);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddressForm";
            this.Text = "Address";
            this.Load += new System.EventHandler(this.AddressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.ErrorProvider addressErrorProvider;
        private System.Windows.Forms.ErrorProvider cityErrorProvider;
        private System.Windows.Forms.ErrorProvider stateErrorProvider;
        private System.Windows.Forms.ErrorProvider zipErrorProvider;
    }
}
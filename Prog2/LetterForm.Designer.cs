namespace UPVApp
{
    partial class LetterForm
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
            this.originLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.originComboBox = new System.Windows.Forms.ComboBox();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.originErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.destErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.costErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.originErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(12, 10);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(78, 13);
            this.originLabel.TabIndex = 0;
            this.originLabel.Text = "Origin Address:";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(0, 38);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(104, 13);
            this.destinationLabel.TabIndex = 1;
            this.destinationLabel.Text = "Destination Address:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(12, 67);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(31, 13);
            this.costLabel.TabIndex = 2;
            this.costLabel.Text = "Cost:";
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(105, 64);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(121, 20);
            this.costTextBox.TabIndex = 5;
            this.costTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.costTextBox_Validating);
            this.costTextBox.Validated += new System.EventHandler(this.costTextBox_Validated);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(29, 102);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(151, 102);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 7;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // originComboBox
            // 
            this.originComboBox.FormattingEnabled = true;
            this.originComboBox.Location = new System.Drawing.Point(105, 7);
            this.originComboBox.Name = "originComboBox";
            this.originComboBox.Size = new System.Drawing.Size(121, 21);
            this.originComboBox.TabIndex = 8;
            this.originComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.originComboBox_Validating);
            this.originComboBox.Validated += new System.EventHandler(this.originComboBox_Validated);
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.Location = new System.Drawing.Point(105, 35);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(121, 21);
            this.destinationComboBox.TabIndex = 9;
            this.destinationComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.destinationComboBox_Validating);
            this.destinationComboBox.Validated += new System.EventHandler(this.destinationComboBox_Validated);
            // 
            // originErrorProvider
            // 
            this.originErrorProvider.ContainerControl = this;
            // 
            // destErrorProvider
            // 
            this.destErrorProvider.ContainerControl = this;
            // 
            // costErrorProvider
            // 
            this.costErrorProvider.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 137);
            this.Controls.Add(this.destinationComboBox);
            this.Controls.Add(this.originComboBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.originLabel);
            this.Name = "LetterForm";
            this.Text = "Letter";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.originErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.ComboBox originComboBox;
        private System.Windows.Forms.ComboBox destinationComboBox;
        private System.Windows.Forms.ErrorProvider originErrorProvider;
        private System.Windows.Forms.ErrorProvider destErrorProvider;
        private System.Windows.Forms.ErrorProvider costErrorProvider;
    }
}
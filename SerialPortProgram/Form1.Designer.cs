namespace SerialPortTerminal
{
    partial class Form1
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
            this.AvailablePortsBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.SendingMessageBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReceivedStrings = new System.Windows.Forms.ListBox();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.ControlBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AvailablePortsBox
            // 
            this.AvailablePortsBox.FormattingEnabled = true;
            this.AvailablePortsBox.Location = new System.Drawing.Point(42, 60);
            this.AvailablePortsBox.Name = "AvailablePortsBox";
            this.AvailablePortsBox.Size = new System.Drawing.Size(121, 24);
            this.AvailablePortsBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Available Ports";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(68, 102);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(85, 23);
            this.ConnectButton.TabIndex = 3;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(659, 323);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(89, 46);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SendingMessageBox
            // 
            this.SendingMessageBox.Location = new System.Drawing.Point(287, 335);
            this.SendingMessageBox.Name = "SendingMessageBox";
            this.SendingMessageBox.Size = new System.Drawing.Size(344, 22);
            this.SendingMessageBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Command";
            // 
            // ReceivedStrings
            // 
            this.ReceivedStrings.FormattingEnabled = true;
            this.ReceivedStrings.ItemHeight = 16;
            this.ReceivedStrings.Items.AddRange(new object[] {
            "asasf",
            "asf",
            "saf",
            "fas",
            "sfa",
            "fas"});
            this.ReceivedStrings.Location = new System.Drawing.Point(333, 60);
            this.ReceivedStrings.Name = "ReceivedStrings";
            this.ReceivedStrings.Size = new System.Drawing.Size(271, 196);
            this.ReceivedStrings.TabIndex = 8;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(68, 140);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(95, 33);
            this.DisconnectButton.TabIndex = 9;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ControlBox
            // 
            this.ControlBox.FormattingEnabled = true;
            this.ControlBox.ItemHeight = 16;
            this.ControlBox.Location = new System.Drawing.Point(43, 254);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(120, 84);
            this.ControlBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 478);
            this.Controls.Add(this.ControlBox);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ReceivedStrings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendingMessageBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AvailablePortsBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AvailablePortsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox SendingMessageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ReceivedStrings;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.ListBox ControlBox;
    }
}


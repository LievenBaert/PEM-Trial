namespace ADF.UCM.Demo.HIC
{
    partial class FormTest
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
      this.ButtonSayHello = new System.Windows.Forms.Button();
      this.ButtonSendMessage = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.labelVersion = new System.Windows.Forms.Label();
      this.labelDescription = new System.Windows.Forms.Label();
      this.textBoxVersion = new System.Windows.Forms.TextBox();
      this.textBoxDescription = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // ButtonSayHello
      // 
      this.ButtonSayHello.Location = new System.Drawing.Point(13, 12);
      this.ButtonSayHello.Name = "ButtonSayHello";
      this.ButtonSayHello.Size = new System.Drawing.Size(98, 23);
      this.ButtonSayHello.TabIndex = 0;
      this.ButtonSayHello.Text = "Say Hello";
      this.ButtonSayHello.UseVisualStyleBackColor = true;
      this.ButtonSayHello.Click += new System.EventHandler(this.ButtonSayHello_Click);
      // 
      // ButtonSendMessage
      // 
      this.ButtonSendMessage.Location = new System.Drawing.Point(182, 12);
      this.ButtonSendMessage.Name = "ButtonSendMessage";
      this.ButtonSendMessage.Size = new System.Drawing.Size(98, 23);
      this.ButtonSendMessage.TabIndex = 1;
      this.ButtonSendMessage.Text = "SendMessage";
      this.ButtonSendMessage.UseVisualStyleBackColor = true;
      this.ButtonSendMessage.Click += new System.EventHandler(this.ButtonSendMessage_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.textBoxDescription);
      this.groupBox1.Controls.Add(this.textBoxVersion);
      this.groupBox1.Controls.Add(this.labelDescription);
      this.groupBox1.Controls.Add(this.labelVersion);
      this.groupBox1.Location = new System.Drawing.Point(13, 57);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(267, 197);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Assembly";
      // 
      // labelVersion
      // 
      this.labelVersion.AutoSize = true;
      this.labelVersion.Location = new System.Drawing.Point(7, 20);
      this.labelVersion.Name = "labelVersion";
      this.labelVersion.Size = new System.Drawing.Size(45, 13);
      this.labelVersion.TabIndex = 0;
      this.labelVersion.Text = "Version:";
      // 
      // labelDescription
      // 
      this.labelDescription.AutoSize = true;
      this.labelDescription.Location = new System.Drawing.Point(7, 46);
      this.labelDescription.Name = "labelDescription";
      this.labelDescription.Size = new System.Drawing.Size(63, 13);
      this.labelDescription.TabIndex = 1;
      this.labelDescription.Text = "Description:";
      // 
      // textBoxVersion
      // 
      this.textBoxVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxVersion.Location = new System.Drawing.Point(81, 17);
      this.textBoxVersion.Name = "textBoxVersion";
      this.textBoxVersion.Size = new System.Drawing.Size(180, 20);
      this.textBoxVersion.TabIndex = 2;
      // 
      // textBoxDescription
      // 
      this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxDescription.Location = new System.Drawing.Point(25, 62);
      this.textBoxDescription.Multiline = true;
      this.textBoxDescription.Name = "textBoxDescription";
      this.textBoxDescription.Size = new System.Drawing.Size(236, 129);
      this.textBoxDescription.TabIndex = 3;
      // 
      // FormTest
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 266);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.ButtonSendMessage);
      this.Controls.Add(this.ButtonSayHello);
      this.Name = "FormTest";
      this.Text = "FormTest";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSayHello;
        private System.Windows.Forms.Button ButtonSendMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxVersion;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelVersion;
    }
}
namespace SendDataToPipe
{
    partial class SendDataToPipeForm
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
            this.TextBoxSendData = new System.Windows.Forms.TextBox();
            this.ButtonSendData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxSendData
            // 
            this.TextBoxSendData.Location = new System.Drawing.Point(26, 102);
            this.TextBoxSendData.Name = "TextBoxSendData";
            this.TextBoxSendData.Size = new System.Drawing.Size(328, 22);
            this.TextBoxSendData.TabIndex = 0;
            // 
            // ButtonSendData
            // 
            this.ButtonSendData.Location = new System.Drawing.Point(139, 130);
            this.ButtonSendData.Name = "ButtonSendData";
            this.ButtonSendData.Size = new System.Drawing.Size(81, 36);
            this.ButtonSendData.TabIndex = 1;
            this.ButtonSendData.Text = "SEND";
            this.ButtonSendData.UseVisualStyleBackColor = true;
            this.ButtonSendData.Click += new System.EventHandler(this.ButtonSendData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "This form send\'s data into it a \r\nnamed pipe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Send data to pipe:";
            // 
            // SendDataToPipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 299);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSendData);
            this.Controls.Add(this.TextBoxSendData);
            this.Name = "SendDataToPipeForm";
            this.Text = "Send Data To Pipe Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxSendData;
        private System.Windows.Forms.Button ButtonSendData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


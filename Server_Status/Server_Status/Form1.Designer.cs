namespace Server_Status
{
    partial class Form1
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
            this.Check_BTN = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Check_BTN
            // 
            this.Check_BTN.Location = new System.Drawing.Point(242, 55);
            this.Check_BTN.Name = "Check_BTN";
            this.Check_BTN.Size = new System.Drawing.Size(94, 31);
            this.Check_BTN.TabIndex = 0;
            this.Check_BTN.Text = "Check";
            this.Check_BTN.UseVisualStyleBackColor = true;
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(12, 22);
            this.URL.Name = "URL";
            this.URL.PlaceholderText = "URL";
            this.URL.Size = new System.Drawing.Size(324, 27);
            this.URL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Status: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Null";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 97);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.Check_BTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Check_BTN;
        private TextBox URL;
        private Label label1;
        private Label label2;
    }
}
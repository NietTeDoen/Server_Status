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
            this.URL_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Status_LBL = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Check_BTN
            // 
            this.Check_BTN.Location = new System.Drawing.Point(374, 20);
            this.Check_BTN.Name = "Check_BTN";
            this.Check_BTN.Size = new System.Drawing.Size(109, 31);
            this.Check_BTN.TabIndex = 0;
            this.Check_BTN.Text = "Check";
            this.Check_BTN.UseVisualStyleBackColor = true;
            this.Check_BTN.Click += new System.EventHandler(this.Check_BTN_Click);
            // 
            // URL_TXT
            // 
            this.URL_TXT.Location = new System.Drawing.Point(12, 22);
            this.URL_TXT.Name = "URL_TXT";
            this.URL_TXT.PlaceholderText = "URL";
            this.URL_TXT.Size = new System.Drawing.Size(356, 27);
            this.URL_TXT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Status: ";
            // 
            // Status_LBL
            // 
            this.Status_LBL.AutoSize = true;
            this.Status_LBL.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Status_LBL.Location = new System.Drawing.Point(110, 52);
            this.Status_LBL.Name = "Status_LBL";
            this.Status_LBL.Size = new System.Drawing.Size(32, 17);
            this.Status_LBL.TabIndex = 3;
            this.Status_LBL.Text = "Null";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(466, 124);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(495, 215);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Status_LBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URL_TXT);
            this.Controls.Add(this.Check_BTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Check_BTN;
        private TextBox URL_TXT;
        private Label label1;
        private Label Status_LBL;
        private ListBox listBox1;
    }
}
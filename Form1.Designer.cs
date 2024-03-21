namespace MLdemo
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
            this.richTextBoxInputEmail = new System.Windows.Forms.RichTextBox();
            this.buttonDection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxresult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelspam = new System.Windows.Forms.Label();
            this.labelnotspam = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxInputEmail
            // 
            this.richTextBoxInputEmail.Location = new System.Drawing.Point(130, 116);
            this.richTextBoxInputEmail.Name = "richTextBoxInputEmail";
            this.richTextBoxInputEmail.Size = new System.Drawing.Size(565, 96);
            this.richTextBoxInputEmail.TabIndex = 1;
            this.richTextBoxInputEmail.Text = "";
            this.richTextBoxInputEmail.TextChanged += new System.EventHandler(this.richTextBoxInputEmail_TextChanged);
            // 
            // buttonDection
            // 
            this.buttonDection.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDection.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDection.Location = new System.Drawing.Point(294, 239);
            this.buttonDection.Name = "buttonDection";
            this.buttonDection.Size = new System.Drawing.Size(258, 41);
            this.buttonDection.TabIndex = 3;
            this.buttonDection.Text = "Detect Email";
            this.buttonDection.UseVisualStyleBackColor = false;
            this.buttonDection.Click += new System.EventHandler(this.buttonDection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 327);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result (Spam/Not Spam):";
            // 
            // textBoxresult
            // 
            this.textBoxresult.Location = new System.Drawing.Point(130, 363);
            this.textBoxresult.Name = "textBoxresult";
            this.textBoxresult.Size = new System.Drawing.Size(343, 29);
            this.textBoxresult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 416);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Spam : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelspam
            // 
            this.labelspam.AutoSize = true;
            this.labelspam.Location = new System.Drawing.Point(193, 416);
            this.labelspam.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelspam.Name = "labelspam";
            this.labelspam.Size = new System.Drawing.Size(55, 24);
            this.labelspam.TabIndex = 7;
            this.labelspam.Text = "00:00";
            // 
            // labelnotspam
            // 
            this.labelnotspam.AutoSize = true;
            this.labelnotspam.Location = new System.Drawing.Point(418, 416);
            this.labelnotspam.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelnotspam.Name = "labelnotspam";
            this.labelnotspam.Size = new System.Drawing.Size(55, 24);
            this.labelnotspam.TabIndex = 9;
            this.labelnotspam.Text = "00:00";
            this.labelnotspam.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 416);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Not Spam : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.labelnotspam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelspam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxresult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDection);
            this.Controls.Add(this.richTextBoxInputEmail);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxInputEmail;
        private System.Windows.Forms.Button buttonDection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxresult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelspam;
        private System.Windows.Forms.Label labelnotspam;
        private System.Windows.Forms.Label label6;
    }
}


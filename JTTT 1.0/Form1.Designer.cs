using System;

namespace JTTT_1._0
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBoxIF = new System.Windows.Forms.ComboBox();
            this.comboBoxTHEN = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.htmlService = new JTTT_1._0.HtmlService();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(64, 257);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 20);
            this.textBox3.TabIndex = 2;
            // 
            // comboBoxIF
            // 
            this.comboBoxIF.FormattingEnabled = true;
            this.comboBoxIF.Location = new System.Drawing.Point(310, 9);
            this.comboBoxIF.Name = "comboBoxIF";
            this.comboBoxIF.Size = new System.Drawing.Size(137, 21);
            this.comboBoxIF.TabIndex = 5;
            this.comboBoxIF.SelectedIndexChanged += new System.EventHandler(this.comboBoxIF_SelectedIndexChanged);
            // 
            // comboBoxTHEN
            // 
            this.comboBoxTHEN.FormattingEnabled = true;
            this.comboBoxTHEN.Location = new System.Drawing.Point(310, 192);
            this.comboBoxTHEN.Name = "comboBoxTHEN";
            this.comboBoxTHEN.Size = new System.Drawing.Size(137, 21);
            this.comboBoxTHEN.TabIndex = 4;
            this.comboBoxTHEN.SelectedIndexChanged += new System.EventHandler(this.comboBoxTHEN_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "To wykonaj to: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jeżeli to: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Wybierz warunek";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Wybierz typ akcji";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Wyślij wiadomośc email";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Wykonaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // htmlService
            // 
            this.htmlService.Location = new System.Drawing.Point(100, 100);
            this.htmlService.Name = "htmlService";
            this.htmlService.Size = new System.Drawing.Size(150, 150);
            this.htmlService.TabIndex = 15;
            this.htmlService.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTHEN);
            this.Controls.Add(this.comboBoxIF);
            this.Controls.Add(this.textBox3);
            this.Name = "Form1";
            this.Text = "JTTT v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBoxIF;
        private System.Windows.Forms.ComboBox comboBoxTHEN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private HtmlService htmlService;
    }
}


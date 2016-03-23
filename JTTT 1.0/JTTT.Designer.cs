using System;

namespace JTTT_1._0
{
    partial class JTTT
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
            this.URL = new System.Windows.Forms.TextBox();
            this.actionsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KeyWord = new System.Windows.Forms.TextBox();
            this.reactionsLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EmailAdress = new System.Windows.Forms.TextBox();
            this.AddToList = new System.Windows.Forms.Button();
            this.actionsBox = new System.Windows.Forms.ComboBox();
            this.reactionsBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TaskList = new System.Windows.Forms.ListBox();
            this.Execute = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Serialize = new System.Windows.Forms.Button();
            this.DeSerialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(78, 88);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(147, 20);
            this.URL.TabIndex = 0;
            // 
            // actionsLabel
            // 
            this.actionsLabel.AutoSize = true;
            this.actionsLabel.Location = new System.Drawing.Point(4, 12);
            this.actionsLabel.Name = "actionsLabel";
            this.actionsLabel.Size = new System.Drawing.Size(33, 13);
            this.actionsLabel.TabIndex = 1;
            this.actionsLabel.Text = "Jeżeli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Na danej stronie znajduje sie obrazek, ktorego podpis zawiera tekst";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "URL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tekst";
            // 
            // KeyWord
            // 
            this.KeyWord.Location = new System.Drawing.Point(78, 137);
            this.KeyWord.Name = "KeyWord";
            this.KeyWord.Size = new System.Drawing.Size(147, 20);
            this.KeyWord.TabIndex = 6;
            // 
            // reactionsLabel
            // 
            this.reactionsLabel.AutoSize = true;
            this.reactionsLabel.Location = new System.Drawing.Point(3, 187);
            this.reactionsLabel.Name = "reactionsLabel";
            this.reactionsLabel.Size = new System.Drawing.Size(73, 13);
            this.reactionsLabel.TabIndex = 7;
            this.reactionsLabel.Text = "to wykonaj to:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "wyślij na podany email wiadomośc ze znalezionym obrazkiem ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "e-mail";
            // 
            // EmailAdress
            // 
            this.EmailAdress.Location = new System.Drawing.Point(78, 265);
            this.EmailAdress.Name = "EmailAdress";
            this.EmailAdress.Size = new System.Drawing.Size(147, 20);
            this.EmailAdress.TabIndex = 10;
            // 
            // AddToList
            // 
            this.AddToList.Location = new System.Drawing.Point(78, 326);
            this.AddToList.Name = "AddToList";
            this.AddToList.Size = new System.Drawing.Size(149, 23);
            this.AddToList.TabIndex = 11;
            this.AddToList.Text = "Dodaj do listy";
            this.AddToList.UseVisualStyleBackColor = true;
            this.AddToList.Click += new System.EventHandler(this.AddToList_Click);
            // 
            // actionsBox
            // 
            this.actionsBox.FormattingEnabled = true;
            this.actionsBox.Location = new System.Drawing.Point(78, 9);
            this.actionsBox.Name = "actionsBox";
            this.actionsBox.Size = new System.Drawing.Size(147, 21);
            this.actionsBox.TabIndex = 12;
            this.actionsBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // reactionsBox
            // 
            this.reactionsBox.FormattingEnabled = true;
            this.reactionsBox.Location = new System.Drawing.Point(78, 184);
            this.reactionsBox.Name = "reactionsBox";
            this.reactionsBox.Size = new System.Drawing.Size(147, 21);
            this.reactionsBox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nazwa tasku";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 296);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 15;
            // 
            // TaskList
            // 
            this.TaskList.FormattingEnabled = true;
            this.TaskList.Location = new System.Drawing.Point(349, 9);
            this.TaskList.Name = "TaskList";
            this.TaskList.Size = new System.Drawing.Size(327, 147);
            this.TaskList.TabIndex = 16;
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(349, 162);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(101, 43);
            this.Execute.TabIndex = 17;
            this.Execute.Text = "Wykonaj";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(466, 162);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(101, 43);
            this.Clear.TabIndex = 18;
            this.Clear.Text = "Czyść";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Serialize
            // 
            this.Serialize.Location = new System.Drawing.Point(575, 162);
            this.Serialize.Name = "Serialize";
            this.Serialize.Size = new System.Drawing.Size(101, 22);
            this.Serialize.TabIndex = 19;
            this.Serialize.Text = "Serialize";
            this.Serialize.UseVisualStyleBackColor = true;
            this.Serialize.Click += new System.EventHandler(this.Serialize_Click);
            // 
            // DeSerialize
            // 
            this.DeSerialize.Location = new System.Drawing.Point(575, 184);
            this.DeSerialize.Name = "DeSerialize";
            this.DeSerialize.Size = new System.Drawing.Size(101, 22);
            this.DeSerialize.TabIndex = 20;
            this.DeSerialize.Text = "Deserialize";
            this.DeSerialize.UseVisualStyleBackColor = true;
            this.DeSerialize.Click += new System.EventHandler(this.DeSerialize_Click);
            // 
            // JTTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 371);
            this.Controls.Add(this.DeSerialize);
            this.Controls.Add(this.Serialize);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.TaskList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.reactionsBox);
            this.Controls.Add(this.actionsBox);
            this.Controls.Add(this.AddToList);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reactionsLabel);
            this.Controls.Add(this.KeyWord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.actionsLabel);
            this.Controls.Add(this.EmailAdress);
            this.Name = "JTTT";
            this.Text = "JTTT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Label actionsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox KeyWord;
        private System.Windows.Forms.Label reactionsLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmailAdress;
        private System.Windows.Forms.Button AddToList;
        private System.Windows.Forms.ComboBox actionsBox;
        private System.Windows.Forms.ComboBox reactionsBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox TaskList;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Serialize;
        private System.Windows.Forms.Button DeSerialize;
    }
}
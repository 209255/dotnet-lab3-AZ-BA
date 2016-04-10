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
            this.TaskName = new System.Windows.Forms.TextBox();
            this.TaskList = new System.Windows.Forms.ListBox();
            this.Execute = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Serialize = new System.Windows.Forms.Button();
            this.DeSerialize = new System.Windows.Forms.Button();
            this.CheckWeatherButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(67, 62);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(147, 20);
            this.URL.TabIndex = 0;
            // 
            // actionsLabel
            // 
            this.actionsLabel.AutoSize = true;
            this.actionsLabel.Location = new System.Drawing.Point(19, 17);
            this.actionsLabel.Name = "actionsLabel";
            this.actionsLabel.Size = new System.Drawing.Size(33, 13);
            this.actionsLabel.TabIndex = 1;
            this.actionsLabel.Text = "Jeżeli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Na danej stronie znajduje sie obrazek, ktorego podpis zawiera tekst";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "URL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tekst";
            // 
            // KeyWord
            // 
            this.KeyWord.Location = new System.Drawing.Point(67, 93);
            this.KeyWord.Name = "KeyWord";
            this.KeyWord.Size = new System.Drawing.Size(147, 20);
            this.KeyWord.TabIndex = 6;
            // 
            // reactionsLabel
            // 
            this.reactionsLabel.AutoSize = true;
            this.reactionsLabel.Location = new System.Drawing.Point(6, 20);
            this.reactionsLabel.Name = "reactionsLabel";
            this.reactionsLabel.Size = new System.Drawing.Size(73, 13);
            this.reactionsLabel.TabIndex = 7;
            this.reactionsLabel.Text = "to wykonaj to:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "wyślij na podany email wiadomośc ze znalezionym obrazkiem ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "e-mail";
            // 
            // EmailAdress
            // 
            this.EmailAdress.Location = new System.Drawing.Point(85, 72);
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
            this.actionsBox.Location = new System.Drawing.Point(67, 14);
            this.actionsBox.Name = "actionsBox";
            this.actionsBox.Size = new System.Drawing.Size(209, 21);
            this.actionsBox.TabIndex = 12;
            this.actionsBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // reactionsBox
            // 
            this.reactionsBox.FormattingEnabled = true;
            this.reactionsBox.Location = new System.Drawing.Point(85, 17);
            this.reactionsBox.Name = "reactionsBox";
            this.reactionsBox.Size = new System.Drawing.Size(209, 21);
            this.reactionsBox.TabIndex = 13;
            this.reactionsBox.SelectedIndexChanged += new System.EventHandler(this.reactionsBox_SelectedIndexChanged);
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
            // TaskName
            // 
            this.TaskName.Location = new System.Drawing.Point(78, 296);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(149, 20);
            this.TaskName.TabIndex = 15;
            // 
            // TaskList
            // 
            this.TaskList.FormattingEnabled = true;
            this.TaskList.Location = new System.Drawing.Point(349, 9);
            this.TaskList.Name = "TaskList";
            this.TaskList.Size = new System.Drawing.Size(486, 147);
            this.TaskList.TabIndex = 16;
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(349, 162);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(113, 43);
            this.Execute.TabIndex = 17;
            this.Execute.Text = "Wykonaj";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(484, 162);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(111, 43);
            this.Clear.TabIndex = 18;
            this.Clear.Text = "Czyść";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Serialize
            // 
            this.Serialize.Location = new System.Drawing.Point(616, 162);
            this.Serialize.Name = "Serialize";
            this.Serialize.Size = new System.Drawing.Size(101, 43);
            this.Serialize.TabIndex = 19;
            this.Serialize.Text = "Serialize";
            this.Serialize.UseVisualStyleBackColor = true;
            this.Serialize.Click += new System.EventHandler(this.Serialize_Click);
            // 
            // DeSerialize
            // 
            this.DeSerialize.Location = new System.Drawing.Point(734, 162);
            this.DeSerialize.Name = "DeSerialize";
            this.DeSerialize.Size = new System.Drawing.Size(101, 43);
            this.DeSerialize.TabIndex = 20;
            this.DeSerialize.Text = "Deserialize";
            this.DeSerialize.UseVisualStyleBackColor = true;
            this.DeSerialize.Click += new System.EventHandler(this.DeSerialize_Click);
            // 
            // CheckWeatherButton
            // 
            this.CheckWeatherButton.Location = new System.Drawing.Point(734, 326);
            this.CheckWeatherButton.Name = "CheckWeatherButton";
            this.CheckWeatherButton.Size = new System.Drawing.Size(101, 23);
            this.CheckWeatherButton.TabIndex = 21;
            this.CheckWeatherButton.Text = "Sprawdź pogodę";
            this.CheckWeatherButton.UseVisualStyleBackColor = true;
            this.CheckWeatherButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 154);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.actionsBox);
            this.tabPage1.Controls.Add(this.actionsLabel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.URL);
            this.tabPage1.Controls.Add(this.KeyWord);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(336, 128);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(336, 156);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(-1, 158);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(344, 132);
            this.tabControl2.TabIndex = 23;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage3.Controls.Add(this.reactionsLabel);
            this.tabPage3.Controls.Add(this.reactionsBox);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.EmailAdress);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(336, 106);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(192, 74);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // JTTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 371);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CheckWeatherButton);
            this.Controls.Add(this.DeSerialize);
            this.Controls.Add(this.Serialize);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.TaskList);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AddToList);
            this.Name = "JTTT";
            this.Text = "JTTT";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.TextBox TaskName;
        private System.Windows.Forms.ListBox TaskList;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Serialize;
        private System.Windows.Forms.Button DeSerialize;
        private System.Windows.Forms.Button CheckWeatherButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}
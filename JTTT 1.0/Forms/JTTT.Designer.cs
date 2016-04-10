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
            this.components = new System.ComponentModel.Container();
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
            this.tabAction = new System.Windows.Forms.TabControl();
            this.AcImgOnWeb = new System.Windows.Forms.TabPage();
            this.AcTemp = new System.Windows.Forms.TabPage();
            this.city = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tempTrigger = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabReaction = new System.Windows.Forms.TabControl();
            this.RcEmail = new System.Windows.Forms.TabPage();
            this.RcDisplay = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabAction.SuspendLayout();
            this.AcImgOnWeb.SuspendLayout();
            this.AcTemp.SuspendLayout();
            this.tabReaction.SuspendLayout();
            this.RcEmail.SuspendLayout();
            this.RcDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(102, 62);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(174, 20);
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
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "URL/Miasto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tekst/Temp";
            // 
            // KeyWord
            // 
            this.KeyWord.Location = new System.Drawing.Point(111, 93);
            this.KeyWord.Name = "KeyWord";
            this.KeyWord.Size = new System.Drawing.Size(165, 20);
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
            // tabAction
            // 
            this.tabAction.Controls.Add(this.AcImgOnWeb);
            this.tabAction.Controls.Add(this.AcTemp);
            this.tabAction.Location = new System.Drawing.Point(-1, 2);
            this.tabAction.Name = "tabAction";
            this.tabAction.SelectedIndex = 0;
            this.tabAction.Size = new System.Drawing.Size(344, 154);
            this.tabAction.TabIndex = 22;
            // 
            // AcImgOnWeb
            // 
            this.AcImgOnWeb.BackColor = System.Drawing.Color.DarkGray;
            this.AcImgOnWeb.Controls.Add(this.actionsBox);
            this.AcImgOnWeb.Controls.Add(this.actionsLabel);
            this.AcImgOnWeb.Controls.Add(this.label3);
            this.AcImgOnWeb.Controls.Add(this.label4);
            this.AcImgOnWeb.Controls.Add(this.URL);
            this.AcImgOnWeb.Controls.Add(this.KeyWord);
            this.AcImgOnWeb.Controls.Add(this.label5);
            this.AcImgOnWeb.Location = new System.Drawing.Point(4, 22);
            this.AcImgOnWeb.Name = "AcImgOnWeb";
            this.AcImgOnWeb.Padding = new System.Windows.Forms.Padding(3);
            this.AcImgOnWeb.Size = new System.Drawing.Size(336, 128);
            this.AcImgOnWeb.TabIndex = 0;
            this.AcImgOnWeb.Text = "ObrazekNaStronie";
            // 
            // AcTemp
            // 
            this.AcTemp.BackColor = System.Drawing.Color.DarkGray;
            this.AcTemp.Controls.Add(this.city);
            this.AcTemp.Controls.Add(this.label11);
            this.AcTemp.Controls.Add(this.label10);
            this.AcTemp.Controls.Add(this.tempTrigger);
            this.AcTemp.Controls.Add(this.label6);
            this.AcTemp.Controls.Add(this.label2);
            this.AcTemp.Location = new System.Drawing.Point(4, 22);
            this.AcTemp.Name = "AcTemp";
            this.AcTemp.Padding = new System.Windows.Forms.Padding(3);
            this.AcTemp.Size = new System.Drawing.Size(336, 128);
            this.AcTemp.TabIndex = 1;
            this.AcTemp.Text = "TempWyzszaOd";
            this.AcTemp.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(75, 80);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(118, 20);
            this.city.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(9, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Miasto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(196, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "stopni Celcjuszka";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tempTrigger
            // 
            this.tempTrigger.Location = new System.Drawing.Point(113, 43);
            this.tempTrigger.Name = "tempTrigger";
            this.tempTrigger.Size = new System.Drawing.Size(77, 20);
            this.tempTrigger.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(9, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "jest wyższa od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jeżeli Temperatura w podanym mieście ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabReaction
            // 
            this.tabReaction.Controls.Add(this.RcEmail);
            this.tabReaction.Controls.Add(this.RcDisplay);
            this.tabReaction.Location = new System.Drawing.Point(-1, 158);
            this.tabReaction.Name = "tabReaction";
            this.tabReaction.SelectedIndex = 0;
            this.tabReaction.Size = new System.Drawing.Size(344, 132);
            this.tabReaction.TabIndex = 23;
            // 
            // RcEmail
            // 
            this.RcEmail.BackColor = System.Drawing.Color.DarkGray;
            this.RcEmail.Controls.Add(this.reactionsLabel);
            this.RcEmail.Controls.Add(this.reactionsBox);
            this.RcEmail.Controls.Add(this.label7);
            this.RcEmail.Controls.Add(this.EmailAdress);
            this.RcEmail.Controls.Add(this.label8);
            this.RcEmail.Location = new System.Drawing.Point(4, 22);
            this.RcEmail.Name = "RcEmail";
            this.RcEmail.Padding = new System.Windows.Forms.Padding(3);
            this.RcEmail.Size = new System.Drawing.Size(336, 106);
            this.RcEmail.TabIndex = 0;
            this.RcEmail.Text = "WyslijEmail";
            this.RcEmail.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // RcDisplay
            // 
            this.RcDisplay.Controls.Add(this.label1);
            this.RcDisplay.Location = new System.Drawing.Point(4, 22);
            this.RcDisplay.Name = "RcDisplay";
            this.RcDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.RcDisplay.Size = new System.Drawing.Size(336, 106);
            this.RcDisplay.TabIndex = 1;
            this.RcDisplay.Text = "Wyswietl";
            this.RcDisplay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wyświetl komunikat na ekranie";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // JTTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 371);
            this.Controls.Add(this.tabReaction);
            this.Controls.Add(this.tabAction);
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
            this.tabAction.ResumeLayout(false);
            this.AcImgOnWeb.ResumeLayout(false);
            this.AcImgOnWeb.PerformLayout();
            this.AcTemp.ResumeLayout(false);
            this.AcTemp.PerformLayout();
            this.tabReaction.ResumeLayout(false);
            this.RcEmail.ResumeLayout(false);
            this.RcEmail.PerformLayout();
            this.RcDisplay.ResumeLayout(false);
            this.RcDisplay.PerformLayout();
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
        private System.Windows.Forms.TabControl tabAction;
        private System.Windows.Forms.TabPage AcImgOnWeb;
        private System.Windows.Forms.TabPage AcTemp;
        private System.Windows.Forms.TabControl tabReaction;
        private System.Windows.Forms.TabPage RcEmail;
        private System.Windows.Forms.TabPage RcDisplay;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tempTrigger;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label11;
    }
}
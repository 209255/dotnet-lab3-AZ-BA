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
            this.actionArg0 = new System.Windows.Forms.TextBox();
            this.actionsLabel = new System.Windows.Forms.Label();
            this.labelActionDescription = new System.Windows.Forms.Label();
            this.labelActionArg0 = new System.Windows.Forms.Label();
            this.labelActionArg1 = new System.Windows.Forms.Label();
            this.actionArg1 = new System.Windows.Forms.TextBox();
            this.reactionsLabel = new System.Windows.Forms.Label();
            this.labelReactionDescription = new System.Windows.Forms.Label();
            this.labelReactionArg0 = new System.Windows.Forms.Label();
            this.reactionArg0 = new System.Windows.Forms.TextBox();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // actionArg0
            // 
            this.actionArg0.Location = new System.Drawing.Point(107, 67);
            this.actionArg0.Name = "actionArg0";
            this.actionArg0.Size = new System.Drawing.Size(174, 20);
            this.actionArg0.TabIndex = 0;
            // 
            // actionsLabel
            // 
            this.actionsLabel.AutoSize = true;
            this.actionsLabel.Location = new System.Drawing.Point(12, 12);
            this.actionsLabel.Name = "actionsLabel";
            this.actionsLabel.Size = new System.Drawing.Size(33, 13);
            this.actionsLabel.TabIndex = 1;
            this.actionsLabel.Text = "Jeżeli";
            this.actionsLabel.Click += new System.EventHandler(this.actionsLabel_Click);
            // 
            // labelActionDescription
            // 
            this.labelActionDescription.AutoSize = true;
            this.labelActionDescription.Location = new System.Drawing.Point(15, 43);
            this.labelActionDescription.Name = "labelActionDescription";
            this.labelActionDescription.Size = new System.Drawing.Size(324, 13);
            this.labelActionDescription.TabIndex = 3;
            this.labelActionDescription.Text = "Na danej stronie znajduje sie obrazek, ktorego podpis zawiera tekst";
            this.labelActionDescription.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelActionArg0
            // 
            this.labelActionArg0.AutoSize = true;
            this.labelActionArg0.Location = new System.Drawing.Point(17, 70);
            this.labelActionArg0.Name = "labelActionArg0";
            this.labelActionArg0.Size = new System.Drawing.Size(65, 13);
            this.labelActionArg0.TabIndex = 4;
            this.labelActionArg0.Text = "URL/Miasto";
            this.labelActionArg0.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelActionArg1
            // 
            this.labelActionArg1.AutoSize = true;
            this.labelActionArg1.Location = new System.Drawing.Point(17, 102);
            this.labelActionArg1.Name = "labelActionArg1";
            this.labelActionArg1.Size = new System.Drawing.Size(66, 13);
            this.labelActionArg1.TabIndex = 5;
            this.labelActionArg1.Text = "Tekst/Temp";
            // 
            // actionArg1
            // 
            this.actionArg1.Location = new System.Drawing.Point(107, 99);
            this.actionArg1.Name = "actionArg1";
            this.actionArg1.Size = new System.Drawing.Size(174, 20);
            this.actionArg1.TabIndex = 6;
            // 
            // reactionsLabel
            // 
            this.reactionsLabel.AutoSize = true;
            this.reactionsLabel.Location = new System.Drawing.Point(12, 177);
            this.reactionsLabel.Name = "reactionsLabel";
            this.reactionsLabel.Size = new System.Drawing.Size(73, 13);
            this.reactionsLabel.TabIndex = 7;
            this.reactionsLabel.Text = "to wykonaj to:";
            // 
            // labelReactionDescription
            // 
            this.labelReactionDescription.AutoSize = true;
            this.labelReactionDescription.Location = new System.Drawing.Point(11, 210);
            this.labelReactionDescription.Name = "labelReactionDescription";
            this.labelReactionDescription.Size = new System.Drawing.Size(295, 13);
            this.labelReactionDescription.TabIndex = 8;
            this.labelReactionDescription.Text = "wyślij na podany email wiadomośc ze znalezionym obrazkiem ";
            // 
            // labelReactionArg0
            // 
            this.labelReactionArg0.AutoSize = true;
            this.labelReactionArg0.Location = new System.Drawing.Point(11, 245);
            this.labelReactionArg0.Name = "labelReactionArg0";
            this.labelReactionArg0.Size = new System.Drawing.Size(34, 13);
            this.labelReactionArg0.TabIndex = 9;
            this.labelReactionArg0.Text = "e-mail";
            // 
            // reactionArg0
            // 
            this.reactionArg0.Location = new System.Drawing.Point(91, 242);
            this.reactionArg0.Name = "reactionArg0";
            this.reactionArg0.Size = new System.Drawing.Size(170, 20);
            this.reactionArg0.TabIndex = 10;
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
            this.actionsBox.Location = new System.Drawing.Point(63, 9);
            this.actionsBox.Name = "actionsBox";
            this.actionsBox.Size = new System.Drawing.Size(209, 21);
            this.actionsBox.TabIndex = 12;
            this.actionsBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // reactionsBox
            // 
            this.reactionsBox.FormattingEnabled = true;
            this.reactionsBox.Location = new System.Drawing.Point(91, 174);
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
            this.Controls.Add(this.reactionArg0);
            this.Controls.Add(this.labelReactionDescription);
            this.Controls.Add(this.labelReactionArg0);
            this.Controls.Add(this.reactionsBox);
            this.Controls.Add(this.reactionsLabel);
            this.Controls.Add(this.actionArg1);
            this.Controls.Add(this.actionArg0);
            this.Controls.Add(this.labelActionArg1);
            this.Controls.Add(this.labelActionArg0);
            this.Controls.Add(this.labelActionDescription);
            this.Controls.Add(this.actionsBox);
            this.Controls.Add(this.actionsLabel);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox actionArg0;
        private System.Windows.Forms.Label actionsLabel;
        private System.Windows.Forms.Label labelActionDescription;
        private System.Windows.Forms.Label labelActionArg0;
        private System.Windows.Forms.Label labelActionArg1;
        private System.Windows.Forms.TextBox actionArg1;
        private System.Windows.Forms.Label reactionsLabel;
        private System.Windows.Forms.Label labelReactionDescription;
        private System.Windows.Forms.Label labelReactionArg0;
        private System.Windows.Forms.TextBox reactionArg0;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
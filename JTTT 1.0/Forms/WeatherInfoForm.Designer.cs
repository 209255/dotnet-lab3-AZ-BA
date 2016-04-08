namespace JTTT_1._0
{
    partial class WeatherInfoForm
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
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.weatherButton = new System.Windows.Forms.Button();
            this.weatherDescription = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cityLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.cityLabel.Location = new System.Drawing.Point(12, 25);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(60, 20);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "Miasto:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(79, 24);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(193, 20);
            this.cityTextBox.TabIndex = 1;
            // 
            // weatherButton
            // 
            this.weatherButton.Location = new System.Drawing.Point(13, 69);
            this.weatherButton.Name = "weatherButton";
            this.weatherButton.Size = new System.Drawing.Size(259, 36);
            this.weatherButton.TabIndex = 2;
            this.weatherButton.Text = "Sprawdź pogodę";
            this.weatherButton.UseVisualStyleBackColor = true;
            this.weatherButton.Click += new System.EventHandler(this.weatherButton_Click);
            // 
            // weatherDescription
            // 
            this.weatherDescription.Location = new System.Drawing.Point(16, 112);
            this.weatherDescription.Multiline = true;
            this.weatherDescription.Name = "weatherDescription";
            this.weatherDescription.Size = new System.Drawing.Size(160, 87);
            this.weatherDescription.TabIndex = 3;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(182, 112);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(81, 87);
            this.picture.TabIndex = 4;
            this.picture.TabStop = false;
            // 
            // WeatherInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.weatherDescription);
            this.Controls.Add(this.weatherButton);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.cityLabel);
            this.Name = "WeatherInfoForm";
            this.Text = "WeatherInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button weatherButton;
        private System.Windows.Forms.TextBox weatherDescription;
        private System.Windows.Forms.PictureBox picture;
    }
}
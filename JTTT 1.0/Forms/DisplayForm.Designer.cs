namespace JTTT_1._0
{
    partial class DisplayForm
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
            this.descriptionDisplBox = new System.Windows.Forms.TextBox();
            this.displayPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionDisplBox
            // 
            this.descriptionDisplBox.Location = new System.Drawing.Point(12, 311);
            this.descriptionDisplBox.Multiline = true;
            this.descriptionDisplBox.Name = "descriptionDisplBox";
            this.descriptionDisplBox.Size = new System.Drawing.Size(553, 77);
            this.descriptionDisplBox.TabIndex = 0;
            // 
            // displayPicBox
            // 
            this.displayPicBox.Location = new System.Drawing.Point(12, 12);
            this.displayPicBox.Name = "displayPicBox";
            this.displayPicBox.Size = new System.Drawing.Size(553, 293);
            this.displayPicBox.TabIndex = 1;
            this.displayPicBox.TabStop = false;
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 400);
            this.Controls.Add(this.displayPicBox);
            this.Controls.Add(this.descriptionDisplBox);
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            ((System.ComponentModel.ISupportInitialize)(this.displayPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionDisplBox;
        private System.Windows.Forms.PictureBox displayPicBox;
    }
}
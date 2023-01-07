namespace custom_image_button
{
    partial class MainForm
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
            this.buttonWithImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonWithImage
            // 
            this.buttonWithImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWithImage.Location = new System.Drawing.Point(43, 65);
            this.buttonWithImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonWithImage.Name = "buttonWithImage";
            this.buttonWithImage.Size = new System.Drawing.Size(107, 38);
            this.buttonWithImage.TabIndex = 0;
            this.buttonWithImage.Text = "Add Folder";
            this.buttonWithImage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "256x256 image shown as 27x27";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 185);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonWithImage);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonWithImage;
        private Label label1;
    }
}
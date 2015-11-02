namespace PhotoOrganizer
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
            this.dataOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataOutputLabel
            // 
            this.dataOutputLabel.AutoSize = true;
            this.dataOutputLabel.Location = new System.Drawing.Point(65, 38);
            this.dataOutputLabel.Name = "dataOutputLabel";
            this.dataOutputLabel.Size = new System.Drawing.Size(114, 17);
            this.dataOutputLabel.TabIndex = 0;
            this.dataOutputLabel.Text = "dataOutputLabel";
            this.dataOutputLabel.Click += new System.EventHandler(this.dataOutputLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 504);
            this.Controls.Add(this.dataOutputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dataOutputLabel;
    }
}


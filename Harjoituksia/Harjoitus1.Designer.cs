namespace Harjoitus1
{
    partial class OtsikkoLabel
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
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonLabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "OtsikkoLabel";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Otsikko";
            // 
            // ButtonLabel
            // 
            this.ButtonLabel.AccessibleName = "ButtonLabel";
            this.ButtonLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.ButtonLabel.Location = new System.Drawing.Point(61, 74);
            this.ButtonLabel.Name = "ButtonLabel";
            this.ButtonLabel.Size = new System.Drawing.Size(111, 64);
            this.ButtonLabel.TabIndex = 1;
            this.ButtonLabel.Text = "Vaihda teksti";
            this.ButtonLabel.UseVisualStyleBackColor = false;
            this.ButtonLabel.Click += new System.EventHandler(this.button1_Click);
            // 
            // OtsikkoLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 595);
            this.Controls.Add(this.ButtonLabel);
            this.Controls.Add(this.label1);
            this.Name = "OtsikkoLabel";
            this.Text = "Harjoitus 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonLabel;
    }
}


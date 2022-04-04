namespace LukujenJarjestys
{
    partial class LukuJarjestys
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
            this.EkaLB = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.UusiLukuTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EkaLB
            // 
            this.EkaLB.AutoSize = true;
            this.EkaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EkaLB.Location = new System.Drawing.Point(80, 70);
            this.EkaLB.Name = "EkaLB";
            this.EkaLB.Size = new System.Drawing.Size(219, 24);
            this.EkaLB.TabIndex = 0;
            this.EkaLB.Text = "Anna luku (-999 lopetus):";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(80, 126);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(60, 24);
            this.VastausLB.TabIndex = 1;
            this.VastausLB.Text = "label2";
            this.VastausLB.Visible = false;
            // 
            // UusiLukuTB
            // 
            this.UusiLukuTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UusiLukuTB.Location = new System.Drawing.Point(305, 67);
            this.UusiLukuTB.Name = "UusiLukuTB";
            this.UusiLukuTB.Size = new System.Drawing.Size(167, 29);
            this.UusiLukuTB.TabIndex = 2;
            this.UusiLukuTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UusiLukuTB_KeyPress);
            // 
            // LukuJarjestys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UusiLukuTB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.EkaLB);
            this.Name = "LukuJarjestys";
            this.Text = "Lukujen Järjestys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EkaLB;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.TextBox UusiLukuTB;
    }
}


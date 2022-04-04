namespace Autokululaskuri
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
            this.KilometriCB = new System.Windows.Forms.ComboBox();
            this.LainaLB = new System.Windows.Forms.Label();
            this.NesteetLB = new System.Windows.Forms.Label();
            this.VakuutusLB = new System.Windows.Forms.Label();
            this.MuutLB = new System.Windows.Forms.Label();
            this.PolttonesteLB = new System.Windows.Forms.Label();
            this.PesutLB = new System.Windows.Forms.Label();
            this.HuollotLB = new System.Windows.Forms.Label();
            this.RenkaatLB = new System.Windows.Forms.Label();
            this.KilometritLB = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.LainaTB = new System.Windows.Forms.TextBox();
            this.NesteetTB = new System.Windows.Forms.TextBox();
            this.VakuutusTB = new System.Windows.Forms.TextBox();
            this.MuutTB = new System.Windows.Forms.TextBox();
            this.PolttonesteTB = new System.Windows.Forms.TextBox();
            this.PesutTB = new System.Windows.Forms.TextBox();
            this.HuollotTB = new System.Windows.Forms.TextBox();
            this.RenkaatTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // KilometriCB
            // 
            this.KilometriCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KilometriCB.FormattingEnabled = true;
            this.KilometriCB.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000",
            "4000"});
            this.KilometriCB.Location = new System.Drawing.Point(510, 190);
            this.KilometriCB.Name = "KilometriCB";
            this.KilometriCB.Size = new System.Drawing.Size(121, 24);
            this.KilometriCB.TabIndex = 0;
            this.KilometriCB.SelectedIndexChanged += new System.EventHandler(this.KilometriCB_SelectedIndexChanged);
            // 
            // LainaLB
            // 
            this.LainaLB.AutoSize = true;
            this.LainaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LainaLB.Location = new System.Drawing.Point(34, 41);
            this.LainaLB.Name = "LainaLB";
            this.LainaLB.Size = new System.Drawing.Size(176, 16);
            this.LainaLB.TabIndex = 1;
            this.LainaLB.Text = "Lainan lyhennys korkoineen:";
            this.LainaLB.Click += new System.EventHandler(this.LainaLB_Click);
            // 
            // NesteetLB
            // 
            this.NesteetLB.AutoSize = true;
            this.NesteetLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NesteetLB.Location = new System.Drawing.Point(34, 92);
            this.NesteetLB.Name = "NesteetLB";
            this.NesteetLB.Size = new System.Drawing.Size(142, 16);
            this.NesteetLB.TabIndex = 2;
            this.NesteetLB.Text = "Lisättävät nesteet yms:";
            // 
            // VakuutusLB
            // 
            this.VakuutusLB.AutoSize = true;
            this.VakuutusLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VakuutusLB.Location = new System.Drawing.Point(34, 141);
            this.VakuutusLB.Name = "VakuutusLB";
            this.VakuutusLB.Size = new System.Drawing.Size(108, 16);
            this.VakuutusLB.TabIndex = 3;
            this.VakuutusLB.Text = "Vakuutusmaksut:";
            // 
            // MuutLB
            // 
            this.MuutLB.AutoSize = true;
            this.MuutLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuutLB.Location = new System.Drawing.Point(34, 190);
            this.MuutLB.Name = "MuutLB";
            this.MuutLB.Size = new System.Drawing.Size(68, 16);
            this.MuutLB.TabIndex = 4;
            this.MuutLB.Text = "Muut kulut:";
            // 
            // PolttonesteLB
            // 
            this.PolttonesteLB.AutoSize = true;
            this.PolttonesteLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PolttonesteLB.Location = new System.Drawing.Point(34, 240);
            this.PolttonesteLB.Name = "PolttonesteLB";
            this.PolttonesteLB.Size = new System.Drawing.Size(77, 16);
            this.PolttonesteLB.TabIndex = 5;
            this.PolttonesteLB.Text = "Polttoneste:";
            // 
            // PesutLB
            // 
            this.PesutLB.AutoSize = true;
            this.PesutLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesutLB.Location = new System.Drawing.Point(390, 41);
            this.PesutLB.Name = "PesutLB";
            this.PesutLB.Size = new System.Drawing.Size(44, 16);
            this.PesutLB.TabIndex = 6;
            this.PesutLB.Text = "Pesut:";
            // 
            // HuollotLB
            // 
            this.HuollotLB.AutoSize = true;
            this.HuollotLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuollotLB.Location = new System.Drawing.Point(390, 92);
            this.HuollotLB.Name = "HuollotLB";
            this.HuollotLB.Size = new System.Drawing.Size(52, 16);
            this.HuollotLB.TabIndex = 7;
            this.HuollotLB.Text = "Huollot:";
            // 
            // RenkaatLB
            // 
            this.RenkaatLB.AutoSize = true;
            this.RenkaatLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenkaatLB.Location = new System.Drawing.Point(390, 141);
            this.RenkaatLB.Name = "RenkaatLB";
            this.RenkaatLB.Size = new System.Drawing.Size(61, 16);
            this.RenkaatLB.TabIndex = 8;
            this.RenkaatLB.Text = "Renkaat:";
            // 
            // KilometritLB
            // 
            this.KilometritLB.AutoSize = true;
            this.KilometritLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KilometritLB.Location = new System.Drawing.Point(390, 190);
            this.KilometritLB.Name = "KilometritLB";
            this.KilometritLB.Size = new System.Drawing.Size(97, 16);
            this.KilometritLB.TabIndex = 9;
            this.KilometritLB.Text = "Kilometrit/vuosi";
            this.KilometritLB.Click += new System.EventHandler(this.label8_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(395, 256);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(0, 16);
            this.VastausLB.TabIndex = 10;
            // 
            // LainaTB
            // 
            this.LainaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LainaTB.Location = new System.Drawing.Point(216, 41);
            this.LainaTB.Name = "LainaTB";
            this.LainaTB.Size = new System.Drawing.Size(100, 22);
            this.LainaTB.TabIndex = 11;
            // 
            // NesteetTB
            // 
            this.NesteetTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NesteetTB.Location = new System.Drawing.Point(216, 86);
            this.NesteetTB.Name = "NesteetTB";
            this.NesteetTB.Size = new System.Drawing.Size(100, 22);
            this.NesteetTB.TabIndex = 12;
            // 
            // VakuutusTB
            // 
            this.VakuutusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VakuutusTB.Location = new System.Drawing.Point(216, 138);
            this.VakuutusTB.Name = "VakuutusTB";
            this.VakuutusTB.Size = new System.Drawing.Size(100, 22);
            this.VakuutusTB.TabIndex = 13;
            // 
            // MuutTB
            // 
            this.MuutTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuutTB.Location = new System.Drawing.Point(216, 184);
            this.MuutTB.Name = "MuutTB";
            this.MuutTB.Size = new System.Drawing.Size(100, 22);
            this.MuutTB.TabIndex = 14;
            // 
            // PolttonesteTB
            // 
            this.PolttonesteTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PolttonesteTB.Location = new System.Drawing.Point(216, 234);
            this.PolttonesteTB.Name = "PolttonesteTB";
            this.PolttonesteTB.Size = new System.Drawing.Size(100, 22);
            this.PolttonesteTB.TabIndex = 15;
            // 
            // PesutTB
            // 
            this.PesutTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesutTB.Location = new System.Drawing.Point(510, 41);
            this.PesutTB.Name = "PesutTB";
            this.PesutTB.Size = new System.Drawing.Size(100, 22);
            this.PesutTB.TabIndex = 16;
            // 
            // HuollotTB
            // 
            this.HuollotTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuollotTB.Location = new System.Drawing.Point(510, 92);
            this.HuollotTB.Name = "HuollotTB";
            this.HuollotTB.Size = new System.Drawing.Size(100, 22);
            this.HuollotTB.TabIndex = 17;
            // 
            // RenkaatTB
            // 
            this.RenkaatTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenkaatTB.Location = new System.Drawing.Point(510, 135);
            this.RenkaatTB.Name = "RenkaatTB";
            this.RenkaatTB.Size = new System.Drawing.Size(100, 22);
            this.RenkaatTB.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RenkaatTB);
            this.Controls.Add(this.HuollotTB);
            this.Controls.Add(this.PesutTB);
            this.Controls.Add(this.PolttonesteTB);
            this.Controls.Add(this.MuutTB);
            this.Controls.Add(this.VakuutusTB);
            this.Controls.Add(this.NesteetTB);
            this.Controls.Add(this.LainaTB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.KilometritLB);
            this.Controls.Add(this.RenkaatLB);
            this.Controls.Add(this.HuollotLB);
            this.Controls.Add(this.PesutLB);
            this.Controls.Add(this.PolttonesteLB);
            this.Controls.Add(this.MuutLB);
            this.Controls.Add(this.VakuutusLB);
            this.Controls.Add(this.NesteetLB);
            this.Controls.Add(this.LainaLB);
            this.Controls.Add(this.KilometriCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox KilometriCB;
        private System.Windows.Forms.Label LainaLB;
        private System.Windows.Forms.Label NesteetLB;
        private System.Windows.Forms.Label VakuutusLB;
        private System.Windows.Forms.Label MuutLB;
        private System.Windows.Forms.Label PolttonesteLB;
        private System.Windows.Forms.Label PesutLB;
        private System.Windows.Forms.Label HuollotLB;
        private System.Windows.Forms.Label RenkaatLB;
        private System.Windows.Forms.Label KilometritLB;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.TextBox LainaTB;
        private System.Windows.Forms.TextBox NesteetTB;
        private System.Windows.Forms.TextBox VakuutusTB;
        private System.Windows.Forms.TextBox MuutTB;
        private System.Windows.Forms.TextBox PolttonesteTB;
        private System.Windows.Forms.TextBox PesutTB;
        private System.Windows.Forms.TextBox HuollotTB;
        private System.Windows.Forms.TextBox RenkaatTB;
    }
}


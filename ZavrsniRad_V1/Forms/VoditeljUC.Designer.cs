namespace ZavrsniRad_V1.Forms
{
    partial class VoditeljUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.popisTabPage = new System.Windows.Forms.TabPage();
            this.unosTabPage = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.korisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.popisTabPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.popisTabPage);
            this.tabControl1.Controls.Add(this.unosTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1020, 504);
            this.tabControl1.TabIndex = 0;
            // 
            // popisTabPage
            // 
            this.popisTabPage.Controls.Add(this.dataGridView1);
            this.popisTabPage.Location = new System.Drawing.Point(4, 22);
            this.popisTabPage.Name = "popisTabPage";
            this.popisTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.popisTabPage.Size = new System.Drawing.Size(1012, 478);
            this.popisTabPage.TabIndex = 0;
            this.popisTabPage.Text = "Popis zaposlenika";
            this.popisTabPage.UseVisualStyleBackColor = true;
            // 
            // unosTabPage
            // 
            this.unosTabPage.Location = new System.Drawing.Point(4, 22);
            this.unosTabPage.Name = "unosTabPage";
            this.unosTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.unosTabPage.Size = new System.Drawing.Size(1012, 506);
            this.unosTabPage.TabIndex = 1;
            this.unosTabPage.Text = "Dodavanje zaposlenika";
            this.unosTabPage.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisnikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // korisnikToolStripMenuItem
            // 
            this.korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            this.korisnikToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.korisnikToolStripMenuItem.Text = "Korisnik";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(830, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // VoditeljUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "VoditeljUC";
            this.Size = new System.Drawing.Size(1020, 528);
            this.tabControl1.ResumeLayout(false);
            this.popisTabPage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage popisTabPage;
        private System.Windows.Forms.TabPage unosTabPage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem korisnikToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

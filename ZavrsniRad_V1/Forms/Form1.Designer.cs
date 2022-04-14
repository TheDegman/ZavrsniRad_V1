namespace ZavrsniRad_V1
{
    partial class Glavna
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.prijavaBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lozinkaTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.voditeljUC1 = new ZavrsniRad_V1.Forms.VoditeljUC();
            this.korisnikUC1 = new ZavrsniRad_V1.Forms.KorisnikUC();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.prijavaBTN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lozinkaTB);
            this.panel1.Controls.Add(this.emailTB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 517);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // prijavaBTN
            // 
            this.prijavaBTN.Location = new System.Drawing.Point(480, 285);
            this.prijavaBTN.Name = "prijavaBTN";
            this.prijavaBTN.Size = new System.Drawing.Size(75, 23);
            this.prijavaBTN.TabIndex = 16;
            this.prijavaBTN.Text = "Prijava";
            this.prijavaBTN.UseVisualStyleBackColor = true;
            this.prijavaBTN.Click += new System.EventHandler(this.prijavaBTN_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lozinka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Email";
            // 
            // lozinkaTB
            // 
            this.lozinkaTB.Location = new System.Drawing.Point(460, 214);
            this.lozinkaTB.Name = "lozinkaTB";
            this.lozinkaTB.Size = new System.Drawing.Size(192, 20);
            this.lozinkaTB.TabIndex = 13;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(460, 170);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(192, 20);
            this.emailTB.TabIndex = 12;
            // 
            // voditeljUC1
            // 
            this.voditeljUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voditeljUC1.Location = new System.Drawing.Point(0, 0);
            this.voditeljUC1.Name = "voditeljUC1";
            this.voditeljUC1.Size = new System.Drawing.Size(1004, 517);
            this.voditeljUC1.TabIndex = 0;
            // 
            // korisnikUC1
            // 
            this.korisnikUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.korisnikUC1.Location = new System.Drawing.Point(0, 0);
            this.korisnikUC1.Name = "korisnikUC1";
            this.korisnikUC1.Size = new System.Drawing.Size(1004, 517);
            this.korisnikUC1.TabIndex = 2;
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.voditeljUC1);
            this.Controls.Add(this.korisnikUC1);
            this.Name = "Glavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private Forms.VoditeljUC voditeljUC1;
        private Forms.KorisnikUC korisnikUC1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button prijavaBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lozinkaTB;
        private System.Windows.Forms.TextBox emailTB;
    }
}


namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtAffecte = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtResultat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 20);
            this.textBox2.TabIndex = 2;
            // 
            // BtAffecte
            // 
            this.BtAffecte.Location = new System.Drawing.Point(25, 72);
            this.BtAffecte.Name = "BtAffecte";
            this.BtAffecte.Size = new System.Drawing.Size(117, 24);
            this.BtAffecte.TabIndex = 3;
            this.BtAffecte.Text = "Affecte";
            this.BtAffecte.UseVisualStyleBackColor = true;
            this.BtAffecte.Click += new System.EventHandler(this.BtAffecte_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(369, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 199);
            this.listBox1.TabIndex = 4;
            // 
            // BtResultat
            // 
            this.BtResultat.Location = new System.Drawing.Point(25, 139);
            this.BtResultat.Name = "BtResultat";
            this.BtResultat.Size = new System.Drawing.Size(126, 27);
            this.BtResultat.TabIndex = 5;
            this.BtResultat.Text = "Résultat";
            this.BtResultat.UseVisualStyleBackColor = true;
            this.BtResultat.Click += new System.EventHandler(this.BtResultat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 264);
            this.Controls.Add(this.BtResultat);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtAffecte);
            this.Controls.Add(this.textBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtAffecte;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtResultat;
    }
}


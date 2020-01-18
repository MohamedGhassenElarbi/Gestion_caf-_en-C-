namespace WindowsFormsApplication1
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.Nomlab = new System.Windows.Forms.Label();
            this.mdplab = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.mdp = new System.Windows.Forms.TextBox();
            this.connectionbtn = new System.Windows.Forms.Button();
            this.sortirbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nomlab
            // 
            this.Nomlab.AutoSize = true;
            this.Nomlab.BackColor = System.Drawing.Color.Transparent;
            this.Nomlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nomlab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nomlab.Location = new System.Drawing.Point(28, 284);
            this.Nomlab.Name = "Nomlab";
            this.Nomlab.Size = new System.Drawing.Size(45, 20);
            this.Nomlab.TabIndex = 1;
            this.Nomlab.Text = "Nom";
            // 
            // mdplab
            // 
            this.mdplab.AutoSize = true;
            this.mdplab.BackColor = System.Drawing.Color.Transparent;
            this.mdplab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdplab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mdplab.Location = new System.Drawing.Point(28, 323);
            this.mdplab.Name = "mdplab";
            this.mdplab.Size = new System.Drawing.Size(121, 20);
            this.mdplab.TabIndex = 2;
            this.mdplab.Text = "Mot De Passe";
            // 
            // Nom
            // 
            this.Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.Location = new System.Drawing.Point(160, 271);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(159, 26);
            this.Nom.TabIndex = 3;
            // 
            // mdp
            // 
            this.mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdp.Location = new System.Drawing.Point(160, 323);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(159, 26);
            this.mdp.TabIndex = 4;
            this.mdp.UseSystemPasswordChar = true;
            // 
            // connectionbtn
            // 
            this.connectionbtn.BackColor = System.Drawing.Color.Transparent;
            this.connectionbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connectionbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionbtn.ForeColor = System.Drawing.Color.Maroon;
            this.connectionbtn.Image = ((System.Drawing.Image)(resources.GetObject("connectionbtn.Image")));
            this.connectionbtn.Location = new System.Drawing.Point(90, 369);
            this.connectionbtn.Name = "connectionbtn";
            this.connectionbtn.Size = new System.Drawing.Size(105, 105);
            this.connectionbtn.TabIndex = 5;
            this.connectionbtn.UseVisualStyleBackColor = false;
            this.connectionbtn.Click += new System.EventHandler(this.connectionbtn_Click);
            // 
            // sortirbtn
            // 
            this.sortirbtn.BackColor = System.Drawing.Color.Transparent;
            this.sortirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortirbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortirbtn.ForeColor = System.Drawing.Color.Maroon;
            this.sortirbtn.Image = ((System.Drawing.Image)(resources.GetObject("sortirbtn.Image")));
            this.sortirbtn.Location = new System.Drawing.Point(279, 369);
            this.sortirbtn.Name = "sortirbtn";
            this.sortirbtn.Size = new System.Drawing.Size(105, 105);
            this.sortirbtn.TabIndex = 6;
            this.sortirbtn.UseVisualStyleBackColor = false;
            this.sortirbtn.Click += new System.EventHandler(this.sortirbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 235);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(482, 481);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sortirbtn);
            this.Controls.Add(this.connectionbtn);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.mdplab);
            this.Controls.Add(this.Nomlab);
            this.Name = "Connexion";
            this.Text = "Connection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nomlab;
        private System.Windows.Forms.Label mdplab;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox mdp;
        private System.Windows.Forms.Button connectionbtn;
        private System.Windows.Forms.Button sortirbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


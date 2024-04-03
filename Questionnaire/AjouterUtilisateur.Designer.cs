namespace Questionnaire
{
    partial class AjouterUtilisateur
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_AjouterUtilisateur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_AjouterUtilisateur
            // 
            this.BTN_AjouterUtilisateur.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AjouterUtilisateur.Location = new System.Drawing.Point(184, 60);
            this.BTN_AjouterUtilisateur.Name = "BTN_AjouterUtilisateur";
            this.BTN_AjouterUtilisateur.Size = new System.Drawing.Size(303, 49);
            this.BTN_AjouterUtilisateur.TabIndex = 0;
            this.BTN_AjouterUtilisateur.Text = "Ajouter";
            this.BTN_AjouterUtilisateur.UseVisualStyleBackColor = true;
            this.BTN_AjouterUtilisateur.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ajouter un Utilisateur ";
            // 
            // AjouterUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_AjouterUtilisateur);
            this.Name = "AjouterUtilisateur";
            this.Size = new System.Drawing.Size(1024, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_AjouterUtilisateur;
        private System.Windows.Forms.Label label2;
    }
}

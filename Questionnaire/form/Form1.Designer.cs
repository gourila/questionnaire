namespace Questionnaire
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
        

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Connection_btn = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.Text_login = new System.Windows.Forms.TextBox();
            this.txt_mp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AjouterUtilisateur = new System.Windows.Forms.LinkLabel();
            
            // 
            // Connection_btn
            // 
            this.Connection_btn.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connection_btn.Location = new System.Drawing.Point(360, 208);
            this.Connection_btn.Name = "Connection_btn";
            this.Connection_btn.Size = new System.Drawing.Size(115, 36);
            this.Connection_btn.TabIndex = 2;
            this.Connection_btn.Text = "Connexion ";
            this.Connection_btn.UseVisualStyleBackColor = true;
           
            // 
            // Annuler
            // 
            this.Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuler.Location = new System.Drawing.Point(360, 250);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(115, 36);
            this.Annuler.TabIndex = 3;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            
            // 
            // Text_login
            // 
            this.Text_login.Location = new System.Drawing.Point(318, 122);
            this.Text_login.Multiline = true;
            this.Text_login.Name = "Text_login";
            this.Text_login.Size = new System.Drawing.Size(196, 31);
            this.Text_login.TabIndex = 4;
            // 
            // txt_mp
            // 
            this.txt_mp.Location = new System.Drawing.Point(318, 171);
            this.txt_mp.Multiline = true;
            this.txt_mp.Name = "txt_mp";
            this.txt_mp.PasswordChar = '*';
            this.txt_mp.Size = new System.Drawing.Size(196, 31);
            this.txt_mp.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(136, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(136, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mot de passe";
            // 
            // AjouterUtilisateur
            // 
            this.AjouterUtilisateur.AutoSize = true;
            this.AjouterUtilisateur.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterUtilisateur.LinkColor = System.Drawing.Color.Cyan;
            this.AjouterUtilisateur.Location = new System.Drawing.Point(438, 408);
            this.AjouterUtilisateur.Name = "AjouterUtilisateur";
            this.AjouterUtilisateur.Size = new System.Drawing.Size(350, 33);
            this.AjouterUtilisateur.TabIndex = 8;
            this.AjouterUtilisateur.TabStop = true;
            this.AjouterUtilisateur.Text = "Ajouter Nouvel utilisateur ";
            // 
            // Form1
            // 
            

        }

        #endregion

        private System.Windows.Forms.Button Connection_btn;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.TextBox Text_login;
        private System.Windows.Forms.TextBox txt_mp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel AjouterUtilisateur;
    }
}


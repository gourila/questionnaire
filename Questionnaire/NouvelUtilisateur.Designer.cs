namespace Questionnaire
{
    partial class NouvelUtilisateur.Designer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Login_Select = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouter_Utilisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimer_Utilisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chercherUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CenterPanel = new System.Windows.Forms.TableLayoutPanel();
            this.qToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esultatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.nouvelUtilisateurToolStripMenuItem,
            this.qToolStripMenuItem,
            this.esultatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Login_Select});
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.connexionToolStripMenuItem.Text = "Connexion";
            // 
            // Login_Select
            // 
            this.Login_Select.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.utilisateurToolStripMenuItem});
            this.Login_Select.Name = "Login_Select";
            this.Login_Select.Size = new System.Drawing.Size(224, 26);
            this.Login_Select.Text = "Login";
            this.Login_Select.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // nouvelUtilisateurToolStripMenuItem
            // 
            this.nouvelUtilisateurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouter_Utilisateur,
            this.supprimer_Utilisateur,
            this.modifierToolStripMenuItem,
            this.chercherUtilisateurToolStripMenuItem});
            this.nouvelUtilisateurToolStripMenuItem.Name = "nouvelUtilisateurToolStripMenuItem";
            this.nouvelUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.nouvelUtilisateurToolStripMenuItem.Text = "Utilisateur";
            // 
            // ajouter_Utilisateur
            // 
            this.ajouter_Utilisateur.Name = "ajouter_Utilisateur";
            this.ajouter_Utilisateur.Size = new System.Drawing.Size(232, 26);
            this.ajouter_Utilisateur.Text = "Ajouter Utilisateur";
            this.ajouter_Utilisateur.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // supprimer_Utilisateur
            // 
            this.supprimer_Utilisateur.Name = "supprimer_Utilisateur";
            this.supprimer_Utilisateur.Size = new System.Drawing.Size(232, 26);
            this.supprimer_Utilisateur.Text = "Supprimer Utilisateur";
            this.supprimer_Utilisateur.Click += new System.EventHandler(this.supprimerUtilisaToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.modifierToolStripMenuItem.Text = "Modifier Utilisateur ";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // chercherUtilisateurToolStripMenuItem
            // 
            this.chercherUtilisateurToolStripMenuItem.Name = "chercherUtilisateurToolStripMenuItem";
            this.chercherUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.chercherUtilisateurToolStripMenuItem.Text = "Chercher Utilisateur ";
            this.chercherUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.chercherUtilisateurToolStripMenuItem_Click);
            // 
            // CenterPanel
            // 
            this.CenterPanel.ColumnCount = 1;
            this.CenterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(0, 28);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.RowCount = 1;
            this.CenterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CenterPanel.Size = new System.Drawing.Size(800, 422);
            this.CenterPanel.TabIndex = 1;
            // 
            // qToolStripMenuItem
            // 
            this.qToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.supprimerQuestionToolStripMenuItem,
            this.modifierQuestionToolStripMenuItem,
            this.rechercherQuestionToolStripMenuItem});
            this.qToolStripMenuItem.Name = "qToolStripMenuItem";
            this.qToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.qToolStripMenuItem.Text = "Question";
            this.qToolStripMenuItem.Click += new System.EventHandler(this.qToolStripMenuItem_Click);
            // 
            // esultatToolStripMenuItem
            // 
            this.esultatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToolStripMenuItem});
            this.esultatToolStripMenuItem.Name = "esultatToolStripMenuItem";
            this.esultatToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.esultatToolStripMenuItem.Text = "Resultat";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ajouterToolStripMenuItem.Text = " Ajouter Question ";
            // 
            // supprimerQuestionToolStripMenuItem
            // 
            this.supprimerQuestionToolStripMenuItem.Name = "supprimerQuestionToolStripMenuItem";
            this.supprimerQuestionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.supprimerQuestionToolStripMenuItem.Text = "Supprimer Question";
            // 
            // modifierQuestionToolStripMenuItem
            // 
            this.modifierQuestionToolStripMenuItem.Name = "modifierQuestionToolStripMenuItem";
            this.modifierQuestionToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.modifierQuestionToolStripMenuItem.Text = "Modifier Question";
            // 
            // rechercherQuestionToolStripMenuItem
            // 
            this.rechercherQuestionToolStripMenuItem.Name = "rechercherQuestionToolStripMenuItem";
            this.rechercherQuestionToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.rechercherQuestionToolStripMenuItem.Text = "Rechercher Question";
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.afficherToolStripMenuItem.Text = "Afficher";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.utilisateurToolStripMenuItem.Text = "Utilisateur";
            // 
            // NouvelUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NouvelUtilisateur";
            this.Text = "NouvelUtilisateur";
            this.Load += new System.EventHandler(this.NouvelUtilisateur_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Login_Select;
        private System.Windows.Forms.ToolStripMenuItem nouvelUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouter_Utilisateur;
        private System.Windows.Forms.TableLayoutPanel CenterPanel;
        private System.Windows.Forms.ToolStripMenuItem supprimer_Utilisateur;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chercherUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esultatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
    }
}
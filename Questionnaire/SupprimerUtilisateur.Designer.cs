namespace Questionnaire
{
    partial class SupprimerUtilisateur.Designer
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
            this.label_Supprimer = new System.Windows.Forms.Label();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Resultat_Rechercher_Supprimer = new System.Windows.Forms.ListView();
            this.CheckBox_Supprimer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_Supprimer
            // 
            this.label_Supprimer.AutoSize = true;
            this.label_Supprimer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Supprimer.Location = new System.Drawing.Point(199, 9);
            this.label_Supprimer.Name = "label_Supprimer";
            this.label_Supprimer.Size = new System.Drawing.Size(218, 23);
            this.label_Supprimer.TabIndex = 1;
            this.label_Supprimer.Text = "Supprimer un Utilisateur";
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Font = new System.Drawing.Font("Arial Black", 18.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTN_Supprimer.Location = new System.Drawing.Point(203, 207);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(214, 60);
            this.BTN_Supprimer.TabIndex = 0;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entrez NOM";
            // 
            // Resultat_Rechercher_Supprimer
            // 
            this.Resultat_Rechercher_Supprimer.HideSelection = false;
            this.Resultat_Rechercher_Supprimer.Location = new System.Drawing.Point(203, 94);
            this.Resultat_Rechercher_Supprimer.Name = "Resultat_Rechercher_Supprimer";
            this.Resultat_Rechercher_Supprimer.Size = new System.Drawing.Size(214, 97);
            this.Resultat_Rechercher_Supprimer.TabIndex = 4;
            this.Resultat_Rechercher_Supprimer.UseCompatibleStateImageBehavior = false;
            this.Resultat_Rechercher_Supprimer.Visible = false;
            // 
            // CheckBox_Supprimer
            // 
            this.CheckBox_Supprimer.AutoSize = true;
            this.CheckBox_Supprimer.Location = new System.Drawing.Point(424, 132);
            this.CheckBox_Supprimer.Name = "CheckBox_Supprimer";
            this.CheckBox_Supprimer.Size = new System.Drawing.Size(165, 20);
            this.CheckBox_Supprimer.TabIndex = 5;
            this.CheckBox_Supprimer.Text = "Confirmer Suppression";
            this.CheckBox_Supprimer.UseVisualStyleBackColor = true;
            this.CheckBox_Supprimer.CheckedChanged += new System.EventHandler(this.CheckBox_Supprimer_CheckedChanged);
            // 
            // SupprimerUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckBox_Supprimer);
            this.Controls.Add(this.Resultat_Rechercher_Supprimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Supprimer);
            this.Controls.Add(this.BTN_Supprimer);
            this.Name = "SupprimerUtilisateur";
            this.Text = "SupprimerUtilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Supprimer;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Resultat_Rechercher_Supprimer;
        private System.Windows.Forms.CheckBox CheckBox_Supprimer;
    }
}
namespace Questionnaire
{
    partial class ChercherUtilisateur
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Chercher = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RechercherUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RechercherUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 38);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rechercher un Utilisateur";
            // 
            // BTN_Chercher
            // 
            this.BTN_Chercher.Location = new System.Drawing.Point(12, 87);
            this.BTN_Chercher.Name = "BTN_Chercher";
            this.BTN_Chercher.Size = new System.Drawing.Size(159, 52);
            this.BTN_Chercher.TabIndex = 2;
            this.BTN_Chercher.Text = "Chercher";
            this.BTN_Chercher.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RechercherUsers
            // 
            this.RechercherUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RechercherUsers.Location = new System.Drawing.Point(303, 43);
            this.RechercherUsers.Name = "RechercherUsers";
            this.RechercherUsers.RowHeadersWidth = 51;
            this.RechercherUsers.RowTemplate.Height = 24;
            this.RechercherUsers.Size = new System.Drawing.Size(485, 194);
            this.RechercherUsers.TabIndex = 4;
            this.RechercherUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ChercherUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RechercherUsers);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTN_Chercher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "ChercherUtilisateur";
            this.Text = "ChercherUtilisateur";
            this.Load += new System.EventHandler(this.ChercherUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RechercherUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Chercher;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView RechercherUsers;
    }
}
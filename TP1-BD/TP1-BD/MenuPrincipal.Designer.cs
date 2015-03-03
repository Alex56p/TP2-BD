namespace TP1_BD
{
   partial class MenuPrincipal
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_Statistiques = new System.Windows.Forms.Button();
            this.BTN_Classement = new System.Windows.Forms.Button();
            this.BTN_CommencerPartie = new System.Windows.Forms.Button();
            this.BTN_Quitter = new System.Windows.Forms.Button();
            this.BTN_AjouterQuestion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Prenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Alias = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_Statistiques);
            this.groupBox2.Controls.Add(this.BTN_Classement);
            this.groupBox2.Controls.Add(this.BTN_CommencerPartie);
            this.groupBox2.Controls.Add(this.BTN_Quitter);
            this.groupBox2.Controls.Add(this.BTN_AjouterQuestion);
            this.groupBox2.Font = new System.Drawing.Font("Bauhaus 93", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(14, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 234);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // BTN_Statistiques
            // 
            this.BTN_Statistiques.Location = new System.Drawing.Point(23, 34);
            this.BTN_Statistiques.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Statistiques.Name = "BTN_Statistiques";
            this.BTN_Statistiques.Size = new System.Drawing.Size(189, 28);
            this.BTN_Statistiques.TabIndex = 2;
            this.BTN_Statistiques.Text = "Statistiques...";
            this.BTN_Statistiques.UseVisualStyleBackColor = true;
            this.BTN_Statistiques.Click += new System.EventHandler(this.BTN_Statistiques_Click);
            // 
            // BTN_Classement
            // 
            this.BTN_Classement.Location = new System.Drawing.Point(23, 144);
            this.BTN_Classement.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Classement.Name = "BTN_Classement";
            this.BTN_Classement.Size = new System.Drawing.Size(189, 28);
            this.BTN_Classement.TabIndex = 7;
            this.BTN_Classement.Text = "Classement...";
            this.BTN_Classement.UseVisualStyleBackColor = true;
            this.BTN_Classement.Click += new System.EventHandler(this.BTN_Classement_Click);
            // 
            // BTN_CommencerPartie
            // 
            this.BTN_CommencerPartie.Location = new System.Drawing.Point(23, 70);
            this.BTN_CommencerPartie.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_CommencerPartie.Name = "BTN_CommencerPartie";
            this.BTN_CommencerPartie.Size = new System.Drawing.Size(189, 28);
            this.BTN_CommencerPartie.TabIndex = 3;
            this.BTN_CommencerPartie.Text = "Commencer une partie...";
            this.BTN_CommencerPartie.UseVisualStyleBackColor = true;
            this.BTN_CommencerPartie.Click += new System.EventHandler(this.BTN_CommencerPartie_Click);
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.Location = new System.Drawing.Point(23, 180);
            this.BTN_Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(189, 28);
            this.BTN_Quitter.TabIndex = 6;
            this.BTN_Quitter.Text = "Quitter";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            this.BTN_Quitter.Click += new System.EventHandler(this.BTN_Quitter_Click);
            // 
            // BTN_AjouterQuestion
            // 
            this.BTN_AjouterQuestion.Location = new System.Drawing.Point(23, 106);
            this.BTN_AjouterQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_AjouterQuestion.Name = "BTN_AjouterQuestion";
            this.BTN_AjouterQuestion.Size = new System.Drawing.Size(189, 28);
            this.BTN_AjouterQuestion.TabIndex = 4;
            this.BTN_AjouterQuestion.Text = "Ajouter une Question...";
            this.BTN_AjouterQuestion.UseVisualStyleBackColor = true;
            this.BTN_AjouterQuestion.Click += new System.EventHandler(this.BTN_AjouterQuestion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_Nom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TB_Prenom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_Alias);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Bauhaus 93", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(302, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(213, 234);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations";
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(8, 191);
            this.TB_Nom.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.ReadOnly = true;
            this.TB_Nom.Size = new System.Drawing.Size(181, 29);
            this.TB_Nom.TabIndex = 5;
            this.TB_Nom.Text = "Parent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nom :";
            // 
            // TB_Prenom
            // 
            this.TB_Prenom.Location = new System.Drawing.Point(8, 123);
            this.TB_Prenom.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Prenom.Name = "TB_Prenom";
            this.TB_Prenom.ReadOnly = true;
            this.TB_Prenom.Size = new System.Drawing.Size(181, 29);
            this.TB_Prenom.TabIndex = 3;
            this.TB_Prenom.Text = "Alexis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom :";
            // 
            // TB_Alias
            // 
            this.TB_Alias.Location = new System.Drawing.Point(13, 52);
            this.TB_Alias.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Alias.Name = "TB_Alias";
            this.TB_Alias.ReadOnly = true;
            this.TB_Alias.Size = new System.Drawing.Size(181, 29);
            this.TB_Alias.TabIndex = 1;
            this.TB_Alias.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom d\'utilisateur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Menu Principal";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 344);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Button BTN_Statistiques;
      private System.Windows.Forms.Button BTN_Classement;
      private System.Windows.Forms.Button BTN_CommencerPartie;
      private System.Windows.Forms.Button BTN_Quitter;
      private System.Windows.Forms.Button BTN_AjouterQuestion;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox TB_Nom;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox TB_Prenom;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox TB_Alias;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;

   }
}


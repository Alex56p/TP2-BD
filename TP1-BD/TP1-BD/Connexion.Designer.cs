namespace TP1_BD
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
            this.BTN_Inscription = new System.Windows.Forms.Button();
            this.BTN_Connexion = new System.Windows.Forms.Button();
            this.TB_Alias = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Inscription
            // 
            this.BTN_Inscription.Location = new System.Drawing.Point(146, 126);
            this.BTN_Inscription.Name = "BTN_Inscription";
            this.BTN_Inscription.Size = new System.Drawing.Size(75, 23);
            this.BTN_Inscription.TabIndex = 9;
            this.BTN_Inscription.Text = "Inscription...";
            this.BTN_Inscription.UseVisualStyleBackColor = true;
            // 
            // BTN_Connexion
            // 
            this.BTN_Connexion.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Connexion.Location = new System.Drawing.Point(227, 126);
            this.BTN_Connexion.Name = "BTN_Connexion";
            this.BTN_Connexion.Size = new System.Drawing.Size(75, 23);
            this.BTN_Connexion.TabIndex = 8;
            this.BTN_Connexion.Text = "Connexion";
            this.BTN_Connexion.UseVisualStyleBackColor = true;
            // 
            // TB_Alias
            // 
            this.TB_Alias.Location = new System.Drawing.Point(153, 81);
            this.TB_Alias.Name = "TB_Alias";
            this.TB_Alias.Size = new System.Drawing.Size(150, 20);
            this.TB_Alias.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom d\'utilisateur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "IntelliCrack";
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 166);
            this.Controls.Add(this.BTN_Inscription);
            this.Controls.Add(this.BTN_Connexion);
            this.Controls.Add(this.TB_Alias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Connexion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button BTN_Inscription;
      private System.Windows.Forms.Button BTN_Connexion;
      private System.Windows.Forms.TextBox TB_Alias;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
   }
}


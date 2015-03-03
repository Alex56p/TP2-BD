namespace TP1_BD
{
    partial class Connexion
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
            this.BTN_Inscription = new System.Windows.Forms.Button();
            this.BTN_Connexion = new System.Windows.Forms.Button();
            this.TB_Alias = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Inscription
            // 
            this.BTN_Inscription.Location = new System.Drawing.Point(154, 102);
            this.BTN_Inscription.Name = "BTN_Inscription";
            this.BTN_Inscription.Size = new System.Drawing.Size(75, 23);
            this.BTN_Inscription.TabIndex = 16;
            this.BTN_Inscription.Text = "Inscription...";
            this.BTN_Inscription.UseVisualStyleBackColor = true;
            this.BTN_Inscription.Click += new System.EventHandler(this.BTN_Inscription_Click);
            // 
            // BTN_Connexion
            // 
            this.BTN_Connexion.Location = new System.Drawing.Point(235, 102);
            this.BTN_Connexion.Name = "BTN_Connexion";
            this.BTN_Connexion.Size = new System.Drawing.Size(75, 23);
            this.BTN_Connexion.TabIndex = 15;
            this.BTN_Connexion.Text = "Connexion";
            this.BTN_Connexion.UseVisualStyleBackColor = true;
            this.BTN_Connexion.Click += new System.EventHandler(this.BTN_Connexion_Click);
            // 
            // TB_Alias
            // 
            this.TB_Alias.Location = new System.Drawing.Point(161, 57);
            this.TB_Alias.Name = "TB_Alias";
            this.TB_Alias.Size = new System.Drawing.Size(150, 20);
            this.TB_Alias.TabIndex = 14;
            this.TB_Alias.TextChanged += new System.EventHandler(this.TB_Alias_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nom d\'utilisateur :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "IntelliCrack";
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 134);
            this.Controls.Add(this.BTN_Inscription);
            this.Controls.Add(this.BTN_Connexion);
            this.Controls.Add(this.TB_Alias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Inscription;
        private System.Windows.Forms.Button BTN_Connexion;
        private System.Windows.Forms.TextBox TB_Alias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

    }
}
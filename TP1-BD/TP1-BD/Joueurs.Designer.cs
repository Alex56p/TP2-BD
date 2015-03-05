namespace TP1_BD
{
    partial class Joueurs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Joueur2 = new System.Windows.Forms.ComboBox();
            this.CB_Joueur4 = new System.Windows.Forms.ComboBox();
            this.CB_Joueur3 = new System.Windows.Forms.ComboBox();
            this.BTN_CommencerPartie = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.BTN_CreerJoueur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "Joueurs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Joueur #4 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Joueur #3 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Joueur #2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Choisissez les joueurs contre qui vous voulez jouer";
            // 
            // CB_Joueur2
            // 
            this.CB_Joueur2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Joueur2.FormattingEnabled = true;
            this.CB_Joueur2.Location = new System.Drawing.Point(115, 47);
            this.CB_Joueur2.Name = "CB_Joueur2";
            this.CB_Joueur2.Size = new System.Drawing.Size(121, 21);
            this.CB_Joueur2.TabIndex = 20;
            this.CB_Joueur2.SelectedIndexChanged += new System.EventHandler(this.CB_Joueur2_SelectedIndexChanged);
            // 
            // CB_Joueur4
            // 
            this.CB_Joueur4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Joueur4.FormattingEnabled = true;
            this.CB_Joueur4.Location = new System.Drawing.Point(115, 101);
            this.CB_Joueur4.Name = "CB_Joueur4";
            this.CB_Joueur4.Size = new System.Drawing.Size(121, 21);
            this.CB_Joueur4.TabIndex = 21;
            // 
            // CB_Joueur3
            // 
            this.CB_Joueur3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Joueur3.FormattingEnabled = true;
            this.CB_Joueur3.Location = new System.Drawing.Point(115, 74);
            this.CB_Joueur3.Name = "CB_Joueur3";
            this.CB_Joueur3.Size = new System.Drawing.Size(121, 21);
            this.CB_Joueur3.TabIndex = 22;
            this.CB_Joueur3.SelectedIndexChanged += new System.EventHandler(this.CB_Joueur3_SelectedIndexChanged);
            // 
            // BTN_CommencerPartie
            // 
            this.BTN_CommencerPartie.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_CommencerPartie.Location = new System.Drawing.Point(198, 227);
            this.BTN_CommencerPartie.Name = "BTN_CommencerPartie";
            this.BTN_CommencerPartie.Size = new System.Drawing.Size(121, 23);
            this.BTN_CommencerPartie.TabIndex = 23;
            this.BTN_CommencerPartie.Text = "Commencer la Partie";
            this.BTN_CommencerPartie.UseVisualStyleBackColor = true;
            this.BTN_CommencerPartie.Click += new System.EventHandler(this.BTN_CommencerPartie_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Location = new System.Drawing.Point(123, 227);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(69, 23);
            this.BTN_Annuler.TabIndex = 24;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // BTN_CreerJoueur
            // 
            this.BTN_CreerJoueur.Location = new System.Drawing.Point(115, 18);
            this.BTN_CreerJoueur.Name = "BTN_CreerJoueur";
            this.BTN_CreerJoueur.Size = new System.Drawing.Size(121, 23);
            this.BTN_CreerJoueur.TabIndex = 25;
            this.BTN_CreerJoueur.Text = "Créer un Joueur";
            this.BTN_CreerJoueur.UseVisualStyleBackColor = true;
            this.BTN_CreerJoueur.Click += new System.EventHandler(this.BTN_CreerJoueur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BTN_CreerJoueur);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CB_Joueur2);
            this.groupBox1.Controls.Add(this.CB_Joueur3);
            this.groupBox1.Controls.Add(this.CB_Joueur4);
            this.groupBox1.Location = new System.Drawing.Point(51, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 134);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // Joueurs
            // 
            this.AcceptButton = this.BTN_CommencerPartie;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 271);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_CommencerPartie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Joueurs";
            this.Text = "Joueurs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_Joueur2;
        private System.Windows.Forms.ComboBox CB_Joueur4;
        private System.Windows.Forms.ComboBox CB_Joueur3;
        private System.Windows.Forms.Button BTN_CommencerPartie;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Button BTN_CreerJoueur;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
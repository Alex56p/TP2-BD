namespace TP1_BD
{
    partial class AjouterQuestion
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
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.BTN_AjouterQuestion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_BonneReponse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Reponse3 = new System.Windows.Forms.TextBox();
            this.TB_Reponse2 = new System.Windows.Forms.TextBox();
            this.TB_Reponse4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Question = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_Categories = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Location = new System.Drawing.Point(282, 333);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(61, 23);
            this.BTN_Annuler.TabIndex = 17;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // BTN_AjouterQuestion
            // 
            this.BTN_AjouterQuestion.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_AjouterQuestion.Location = new System.Drawing.Point(349, 333);
            this.BTN_AjouterQuestion.Name = "BTN_AjouterQuestion";
            this.BTN_AjouterQuestion.Size = new System.Drawing.Size(112, 23);
            this.BTN_AjouterQuestion.TabIndex = 16;
            this.BTN_AjouterQuestion.Text = "Ajouter la Question";
            this.BTN_AjouterQuestion.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TB_Reponse3);
            this.groupBox1.Controls.Add(this.TB_Reponse2);
            this.groupBox1.Controls.Add(this.TB_Reponse4);
            this.groupBox1.Location = new System.Drawing.Point(12, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 164);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Réponses";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TB_BonneReponse);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 45);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bonne Réponse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Réponse :";
            // 
            // TB_BonneReponse
            // 
            this.TB_BonneReponse.Location = new System.Drawing.Point(89, 18);
            this.TB_BonneReponse.Name = "TB_BonneReponse";
            this.TB_BonneReponse.Size = new System.Drawing.Size(339, 20);
            this.TB_BonneReponse.TabIndex = 8;
            this.TB_BonneReponse.TextChanged += new System.EventHandler(this.TB_BonneReponse_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Réponse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Réponse :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Réponse :";
            // 
            // TB_Reponse3
            // 
            this.TB_Reponse3.Location = new System.Drawing.Point(95, 102);
            this.TB_Reponse3.Name = "TB_Reponse3";
            this.TB_Reponse3.Size = new System.Drawing.Size(339, 20);
            this.TB_Reponse3.TabIndex = 5;
            this.TB_Reponse3.TextChanged += new System.EventHandler(this.TB_Reponse3_TextChanged);
            // 
            // TB_Reponse2
            // 
            this.TB_Reponse2.Location = new System.Drawing.Point(95, 76);
            this.TB_Reponse2.Name = "TB_Reponse2";
            this.TB_Reponse2.Size = new System.Drawing.Size(339, 20);
            this.TB_Reponse2.TabIndex = 7;
            this.TB_Reponse2.TextChanged += new System.EventHandler(this.TB_Reponse2_TextChanged);
            // 
            // TB_Reponse4
            // 
            this.TB_Reponse4.Location = new System.Drawing.Point(95, 128);
            this.TB_Reponse4.Name = "TB_Reponse4";
            this.TB_Reponse4.Size = new System.Drawing.Size(339, 20);
            this.TB_Reponse4.TabIndex = 6;
            this.TB_Reponse4.TextChanged += new System.EventHandler(this.TB_Reponse4_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Question :";
            // 
            // TB_Question
            // 
            this.TB_Question.Location = new System.Drawing.Point(93, 90);
            this.TB_Question.Name = "TB_Question";
            this.TB_Question.Size = new System.Drawing.Size(339, 20);
            this.TB_Question.TabIndex = 13;
            this.TB_Question.TextChanged += new System.EventHandler(this.TB_Question_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ajouter une Question";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Catégorie :";
            // 
            // CB_Categories
            // 
            this.CB_Categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Categories.FormattingEnabled = true;
            this.CB_Categories.Location = new System.Drawing.Point(93, 58);
            this.CB_Categories.Name = "CB_Categories";
            this.CB_Categories.Size = new System.Drawing.Size(151, 21);
            this.CB_Categories.TabIndex = 1;
            this.CB_Categories.SelectedIndexChanged += new System.EventHandler(this.CB_Categories_SelectedIndexChanged);
            // 
            // AjouterQuestion
            // 
            this.AcceptButton = this.BTN_AjouterQuestion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 370);
            this.Controls.Add(this.CB_Categories);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_AjouterQuestion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Question);
            this.Controls.Add(this.label1);
            this.Name = "AjouterQuestion";
            this.Text = "AjouterQuestion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Button BTN_AjouterQuestion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_BonneReponse;
        private System.Windows.Forms.TextBox TB_Reponse3;
        private System.Windows.Forms.TextBox TB_Reponse2;
        private System.Windows.Forms.TextBox TB_Reponse4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_Categories;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
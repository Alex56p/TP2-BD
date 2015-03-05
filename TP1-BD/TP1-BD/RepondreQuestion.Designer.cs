namespace TP1_BD
{
    partial class RepondreQuestion
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_Reponse4 = new System.Windows.Forms.Button();
            this.TB_Reponse3 = new System.Windows.Forms.Button();
            this.TB_Reponse1 = new System.Windows.Forms.Button();
            this.TB_Reponse2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LB_Question = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_Reponse4);
            this.groupBox2.Controls.Add(this.TB_Reponse3);
            this.groupBox2.Controls.Add(this.TB_Reponse1);
            this.groupBox2.Controls.Add(this.TB_Reponse2);
            this.groupBox2.Location = new System.Drawing.Point(61, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 196);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Réponses";
            // 
            // TB_Reponse4
            // 
            this.TB_Reponse4.Location = new System.Drawing.Point(34, 142);
            this.TB_Reponse4.Name = "TB_Reponse4";
            this.TB_Reponse4.Size = new System.Drawing.Size(335, 23);
            this.TB_Reponse4.TabIndex = 4;
            this.TB_Reponse4.Text = "Lucien Desbiens";
            this.TB_Reponse4.UseVisualStyleBackColor = true;
            // 
            // TB_Reponse3
            // 
            this.TB_Reponse3.Location = new System.Drawing.Point(34, 101);
            this.TB_Reponse3.Name = "TB_Reponse3";
            this.TB_Reponse3.Size = new System.Drawing.Size(335, 23);
            this.TB_Reponse3.TabIndex = 3;
            this.TB_Reponse3.Text = "Sidney Crosby";
            this.TB_Reponse3.UseVisualStyleBackColor = true;
            // 
            // TB_Reponse1
            // 
            this.TB_Reponse1.Location = new System.Drawing.Point(34, 19);
            this.TB_Reponse1.Name = "TB_Reponse1";
            this.TB_Reponse1.Size = new System.Drawing.Size(335, 23);
            this.TB_Reponse1.TabIndex = 1;
            this.TB_Reponse1.Text = "P.K. Subban";
            this.TB_Reponse1.UseVisualStyleBackColor = true;
            this.TB_Reponse1.Click += new System.EventHandler(this.TB_Reponse1_Click);
            // 
            // TB_Reponse2
            // 
            this.TB_Reponse2.Location = new System.Drawing.Point(34, 58);
            this.TB_Reponse2.Name = "TB_Reponse2";
            this.TB_Reponse2.Size = new System.Drawing.Size(335, 23);
            this.TB_Reponse2.TabIndex = 2;
            this.TB_Reponse2.Text = "Carey Price";
            this.TB_Reponse2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LB_Question);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question";
            // 
            // LB_Question
            // 
            this.LB_Question.AutoEllipsis = true;
            this.LB_Question.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Question.Location = new System.Drawing.Point(6, 28);
            this.LB_Question.Name = "LB_Question";
            this.LB_Question.Size = new System.Drawing.Size(489, 131);
            this.LB_Question.TabIndex = 0;
            this.LB_Question.Text = "Quelle est le nom du joueur portant le numéro 76 dans l\'équipe des Canadiens de M" +
    "ontréal?";
            this.LB_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RepondreQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 418);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RepondreQuestion";
            this.Text = "RepondreQuestion";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button TB_Reponse4;
        private System.Windows.Forms.Button TB_Reponse3;
        private System.Windows.Forms.Button TB_Reponse1;
        private System.Windows.Forms.Button TB_Reponse2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LB_Question;
    }
}
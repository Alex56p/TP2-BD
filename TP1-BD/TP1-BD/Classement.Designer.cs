namespace TP1_BD
{
    partial class Classement
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
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Stats = new System.Windows.Forms.DataGridView();
            this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbVictoires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LB_2nd_Points = new System.Windows.Forms.Label();
            this.LB_2nd_Nom = new System.Windows.Forms.Label();
            this.PB_2nd_Photo = new System.Windows.Forms.PictureBox();
            this.PB_2nd = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LB_1st_Nom = new System.Windows.Forms.Label();
            this.LB_1st_Points = new System.Windows.Forms.Label();
            this.PB_1st = new System.Windows.Forms.PictureBox();
            this.PB_1st_Photo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LB_3rd_Points = new System.Windows.Forms.Label();
            this.LB_3rd_Nom = new System.Windows.Forms.Label();
            this.PB_3rd_Photo = new System.Windows.Forms.PictureBox();
            this.PB_3rd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stats)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_2nd_Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_2nd)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_1st)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_1st_Photo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_3rd_Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_3rd)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(442, 569);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 20;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Classement";
            // 
            // DGV_Stats
            // 
            this.DGV_Stats.AllowUserToAddRows = false;
            this.DGV_Stats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Stats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alias,
            this.Nom,
            this.Prenom,
            this.Points,
            this.NbVictoires});
            this.DGV_Stats.Location = new System.Drawing.Point(13, 423);
            this.DGV_Stats.Name = "DGV_Stats";
            this.DGV_Stats.RowHeadersVisible = false;
            this.DGV_Stats.Size = new System.Drawing.Size(504, 121);
            this.DGV_Stats.TabIndex = 18;
            // 
            // Alias
            // 
            this.Alias.HeaderText = "Alias";
            this.Alias.Name = "Alias";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            // 
            // Points
            // 
            this.Points.HeaderText = "Points";
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            // 
            // NbVictoires
            // 
            this.NbVictoires.HeaderText = "Nombre de victoires";
            this.NbVictoires.Name = "NbVictoires";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LB_2nd_Points);
            this.groupBox2.Controls.Add(this.LB_2nd_Nom);
            this.groupBox2.Controls.Add(this.PB_2nd_Photo);
            this.groupBox2.Controls.Add(this.PB_2nd);
            this.groupBox2.Location = new System.Drawing.Point(28, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 321);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // LB_2nd_Points
            // 
            this.LB_2nd_Points.AutoSize = true;
            this.LB_2nd_Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_2nd_Points.ForeColor = System.Drawing.Color.Black;
            this.LB_2nd_Points.Location = new System.Drawing.Point(7, 290);
            this.LB_2nd_Points.Name = "LB_2nd_Points";
            this.LB_2nd_Points.Size = new System.Drawing.Size(65, 13);
            this.LB_2nd_Points.TabIndex = 6;
            this.LB_2nd_Points.Text = "POINTS : ";
            // 
            // LB_2nd_Nom
            // 
            this.LB_2nd_Nom.AutoSize = true;
            this.LB_2nd_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_2nd_Nom.ForeColor = System.Drawing.Color.Black;
            this.LB_2nd_Nom.Location = new System.Drawing.Point(7, 139);
            this.LB_2nd_Nom.Name = "LB_2nd_Nom";
            this.LB_2nd_Nom.Size = new System.Drawing.Size(47, 13);
            this.LB_2nd_Nom.TabIndex = 6;
            this.LB_2nd_Nom.Text = "NOM : ";
            // 
            // PB_2nd_Photo
            // 
            this.PB_2nd_Photo.BackColor = System.Drawing.Color.Silver;
            this.PB_2nd_Photo.Location = new System.Drawing.Point(10, 155);
            this.PB_2nd_Photo.Name = "PB_2nd_Photo";
            this.PB_2nd_Photo.Size = new System.Drawing.Size(130, 132);
            this.PB_2nd_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_2nd_Photo.TabIndex = 5;
            this.PB_2nd_Photo.TabStop = false;
            // 
            // PB_2nd
            // 
            this.PB_2nd.Location = new System.Drawing.Point(10, 18);
            this.PB_2nd.Name = "PB_2nd";
            this.PB_2nd.Size = new System.Drawing.Size(126, 118);
            this.PB_2nd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_2nd.TabIndex = 1;
            this.PB_2nd.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.LB_1st_Nom);
            this.groupBox3.Controls.Add(this.LB_1st_Points);
            this.groupBox3.Controls.Add(this.PB_1st);
            this.groupBox3.Controls.Add(this.PB_1st_Photo);
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(206, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(141, 317);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // LB_1st_Nom
            // 
            this.LB_1st_Nom.AutoSize = true;
            this.LB_1st_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_1st_Nom.ForeColor = System.Drawing.Color.Black;
            this.LB_1st_Nom.Location = new System.Drawing.Point(7, 133);
            this.LB_1st_Nom.Name = "LB_1st_Nom";
            this.LB_1st_Nom.Size = new System.Drawing.Size(47, 13);
            this.LB_1st_Nom.TabIndex = 6;
            this.LB_1st_Nom.Text = "NOM : ";
            // 
            // LB_1st_Points
            // 
            this.LB_1st_Points.AutoSize = true;
            this.LB_1st_Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_1st_Points.ForeColor = System.Drawing.Color.Black;
            this.LB_1st_Points.Location = new System.Drawing.Point(7, 287);
            this.LB_1st_Points.Name = "LB_1st_Points";
            this.LB_1st_Points.Size = new System.Drawing.Size(65, 13);
            this.LB_1st_Points.TabIndex = 5;
            this.LB_1st_Points.Text = "POINTS : ";
            // 
            // PB_1st
            // 
            this.PB_1st.Location = new System.Drawing.Point(11, 18);
            this.PB_1st.Name = "PB_1st";
            this.PB_1st.Size = new System.Drawing.Size(118, 111);
            this.PB_1st.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_1st.TabIndex = 0;
            this.PB_1st.TabStop = false;
            // 
            // PB_1st_Photo
            // 
            this.PB_1st_Photo.BackColor = System.Drawing.Color.Gold;
            this.PB_1st_Photo.ImageLocation = "";
            this.PB_1st_Photo.Location = new System.Drawing.Point(10, 149);
            this.PB_1st_Photo.Name = "PB_1st_Photo";
            this.PB_1st_Photo.Size = new System.Drawing.Size(118, 135);
            this.PB_1st_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_1st_Photo.TabIndex = 4;
            this.PB_1st_Photo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LB_3rd_Points);
            this.groupBox1.Controls.Add(this.LB_3rd_Nom);
            this.groupBox1.Controls.Add(this.PB_3rd_Photo);
            this.groupBox1.Controls.Add(this.PB_3rd);
            this.groupBox1.Location = new System.Drawing.Point(370, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 321);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // LB_3rd_Points
            // 
            this.LB_3rd_Points.AutoSize = true;
            this.LB_3rd_Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_3rd_Points.ForeColor = System.Drawing.Color.Black;
            this.LB_3rd_Points.Location = new System.Drawing.Point(7, 290);
            this.LB_3rd_Points.Name = "LB_3rd_Points";
            this.LB_3rd_Points.Size = new System.Drawing.Size(65, 13);
            this.LB_3rd_Points.TabIndex = 7;
            this.LB_3rd_Points.Text = "POINTS : ";
            // 
            // LB_3rd_Nom
            // 
            this.LB_3rd_Nom.AutoSize = true;
            this.LB_3rd_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_3rd_Nom.ForeColor = System.Drawing.Color.Black;
            this.LB_3rd_Nom.Location = new System.Drawing.Point(7, 139);
            this.LB_3rd_Nom.Name = "LB_3rd_Nom";
            this.LB_3rd_Nom.Size = new System.Drawing.Size(47, 13);
            this.LB_3rd_Nom.TabIndex = 7;
            this.LB_3rd_Nom.Text = "NOM : ";
            // 
            // PB_3rd_Photo
            // 
            this.PB_3rd_Photo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PB_3rd_Photo.Location = new System.Drawing.Point(10, 155);
            this.PB_3rd_Photo.Name = "PB_3rd_Photo";
            this.PB_3rd_Photo.Size = new System.Drawing.Size(124, 132);
            this.PB_3rd_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_3rd_Photo.TabIndex = 6;
            this.PB_3rd_Photo.TabStop = false;
            // 
            // PB_3rd
            // 
            this.PB_3rd.Location = new System.Drawing.Point(10, 19);
            this.PB_3rd.Name = "PB_3rd";
            this.PB_3rd.Size = new System.Drawing.Size(124, 117);
            this.PB_3rd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_3rd.TabIndex = 2;
            this.PB_3rd.TabStop = false;
            // 
            // Classement
            // 
            this.AcceptButton = this.BTN_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 606);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Stats);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Classement";
            this.Text = "Classement";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stats)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_2nd_Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_2nd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_1st)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_1st_Photo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_3rd_Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_3rd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Stats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbVictoires;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LB_2nd_Points;
        private System.Windows.Forms.Label LB_2nd_Nom;
        private System.Windows.Forms.PictureBox PB_2nd_Photo;
        private System.Windows.Forms.PictureBox PB_2nd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LB_1st_Nom;
        private System.Windows.Forms.Label LB_1st_Points;
        private System.Windows.Forms.PictureBox PB_1st;
        private System.Windows.Forms.PictureBox PB_1st_Photo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LB_3rd_Points;
        private System.Windows.Forms.Label LB_3rd_Nom;
        private System.Windows.Forms.PictureBox PB_3rd_Photo;
        private System.Windows.Forms.PictureBox PB_3rd;
    }
}
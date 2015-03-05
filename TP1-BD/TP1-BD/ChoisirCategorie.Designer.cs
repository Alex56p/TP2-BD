namespace TP1_BD
{
    partial class ChoisirCategorie
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
            this.GB_Categories = new System.Windows.Forms.GroupBox();
            this.RB_Divertissement = new System.Windows.Forms.RadioButton();
            this.RB_JV = new System.Windows.Forms.RadioButton();
            this.RB_Sport = new System.Windows.Forms.RadioButton();
            this.RB_Sciences = new System.Windows.Forms.RadioButton();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.GB_Categories.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Categories
            // 
            this.GB_Categories.Controls.Add(this.RB_Divertissement);
            this.GB_Categories.Controls.Add(this.RB_JV);
            this.GB_Categories.Controls.Add(this.RB_Sport);
            this.GB_Categories.Controls.Add(this.RB_Sciences);
            this.GB_Categories.Location = new System.Drawing.Point(13, 13);
            this.GB_Categories.Name = "GB_Categories";
            this.GB_Categories.Size = new System.Drawing.Size(102, 117);
            this.GB_Categories.TabIndex = 0;
            this.GB_Categories.TabStop = false;
            this.GB_Categories.Text = "Categories";
            // 
            // RB_Divertissement
            // 
            this.RB_Divertissement.AutoSize = true;
            this.RB_Divertissement.Location = new System.Drawing.Point(7, 89);
            this.RB_Divertissement.Name = "RB_Divertissement";
            this.RB_Divertissement.Size = new System.Drawing.Size(94, 17);
            this.RB_Divertissement.TabIndex = 3;
            this.RB_Divertissement.TabStop = true;
            this.RB_Divertissement.Text = "Divertissement";
            this.RB_Divertissement.UseVisualStyleBackColor = true;
            this.RB_Divertissement.CheckedChanged += new System.EventHandler(this.RB_Divertissement_CheckedChanged);
            // 
            // RB_JV
            // 
            this.RB_JV.AutoSize = true;
            this.RB_JV.Location = new System.Drawing.Point(7, 66);
            this.RB_JV.Name = "RB_JV";
            this.RB_JV.Size = new System.Drawing.Size(77, 17);
            this.RB_JV.TabIndex = 2;
            this.RB_JV.TabStop = true;
            this.RB_JV.Text = "Jeux Vidéo";
            this.RB_JV.UseVisualStyleBackColor = true;
            this.RB_JV.CheckedChanged += new System.EventHandler(this.RB_JV_CheckedChanged);
            // 
            // RB_Sport
            // 
            this.RB_Sport.AutoSize = true;
            this.RB_Sport.Location = new System.Drawing.Point(7, 43);
            this.RB_Sport.Name = "RB_Sport";
            this.RB_Sport.Size = new System.Drawing.Size(50, 17);
            this.RB_Sport.TabIndex = 1;
            this.RB_Sport.TabStop = true;
            this.RB_Sport.Text = "Sport";
            this.RB_Sport.UseVisualStyleBackColor = true;
            this.RB_Sport.CheckedChanged += new System.EventHandler(this.RB_Sport_CheckedChanged);
            // 
            // RB_Sciences
            // 
            this.RB_Sciences.AutoSize = true;
            this.RB_Sciences.Location = new System.Drawing.Point(7, 20);
            this.RB_Sciences.Name = "RB_Sciences";
            this.RB_Sciences.Size = new System.Drawing.Size(69, 17);
            this.RB_Sciences.TabIndex = 0;
            this.RB_Sciences.TabStop = true;
            this.RB_Sciences.Text = "Sciences";
            this.RB_Sciences.UseVisualStyleBackColor = true;
            this.RB_Sciences.CheckedChanged += new System.EventHandler(this.RB_Sciences_CheckedChanged);
            // 
            // BTN_OK
            // 
            this.BTN_OK.Enabled = false;
            this.BTN_OK.Location = new System.Drawing.Point(28, 150);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.TabIndex = 1;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // ChoisirCategorie
            // 
            this.AcceptButton = this.BTN_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(127, 185);
            this.ControlBox = false;
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.GB_Categories);
            this.Name = "ChoisirCategorie";
            this.Text = "ChoisirCategorie";
            this.GB_Categories.ResumeLayout(false);
            this.GB_Categories.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Categories;
        private System.Windows.Forms.RadioButton RB_Divertissement;
        private System.Windows.Forms.RadioButton RB_JV;
        private System.Windows.Forms.RadioButton RB_Sport;
        private System.Windows.Forms.RadioButton RB_Sciences;
        private System.Windows.Forms.Button BTN_OK;
    }
}
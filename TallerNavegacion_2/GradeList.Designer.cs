﻿namespace TallerNavegacion_2
{
    partial class GradeList
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurePorcentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCodeSubject = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurePorcentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(440, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurePorcentToolStripMenuItem
            // 
            this.configurePorcentToolStripMenuItem.Name = "configurePorcentToolStripMenuItem";
            this.configurePorcentToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.configurePorcentToolStripMenuItem.Text = "Configure Porcent";
            this.configurePorcentToolStripMenuItem.Click += new System.EventHandler(this.configurePorcentToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCodeSubject);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dgvSubjects);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbWelcome);
            this.panel1.Location = new System.Drawing.Point(10, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 292);
            this.panel1.TabIndex = 1;
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Location = new System.Drawing.Point(26, 15);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(77, 13);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Welcome User";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Subject ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Location = new System.Drawing.Point(18, 80);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.Size = new System.Drawing.Size(378, 150);
            this.dgvSubjects.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cargar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtCodeSubject
            // 
            this.txtCodeSubject.Location = new System.Drawing.Point(18, 252);
            this.txtCodeSubject.Name = "txtCodeSubject";
            this.txtCodeSubject.Size = new System.Drawing.Size(159, 20);
            this.txtCodeSubject.TabIndex = 4;
            this.txtCodeSubject.Text = "Enter the code subject";
            // 
            // GradeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 333);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GradeList";
            this.Text = "GradeList";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurePorcentToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodeSubject;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbWelcome;
    }
}
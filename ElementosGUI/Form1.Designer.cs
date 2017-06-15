namespace ElementosGUI
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbComedia = new System.Windows.Forms.CheckBox();
            this.chbAccion = new System.Windows.Forms.CheckBox();
            this.chbCiencia = new System.Windows.Forms.CheckBox();
            this.chbAventura = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbComedia = new System.Windows.Forms.RadioButton();
            this.rbAccion = new System.Windows.Forms.RadioButton();
            this.rbCiencia = new System.Windows.Forms.RadioButton();
            this.rbAventura = new System.Windows.Forms.RadioButton();
            this.cbCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbAventura);
            this.groupBox1.Controls.Add(this.chbCiencia);
            this.groupBox1.Controls.Add(this.chbAccion);
            this.groupBox1.Controls.Add(this.chbComedia);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generos Peliculas";
            // 
            // chbComedia
            // 
            this.chbComedia.AutoSize = true;
            this.chbComedia.Location = new System.Drawing.Point(16, 58);
            this.chbComedia.Name = "chbComedia";
            this.chbComedia.Size = new System.Drawing.Size(67, 17);
            this.chbComedia.TabIndex = 0;
            this.chbComedia.Text = "Comedia";
            this.chbComedia.UseVisualStyleBackColor = true;
            // 
            // chbAccion
            // 
            this.chbAccion.AutoSize = true;
            this.chbAccion.Location = new System.Drawing.Point(16, 109);
            this.chbAccion.Name = "chbAccion";
            this.chbAccion.Size = new System.Drawing.Size(59, 17);
            this.chbAccion.TabIndex = 1;
            this.chbAccion.Text = "Acción";
            this.chbAccion.UseVisualStyleBackColor = true;
            // 
            // chbCiencia
            // 
            this.chbCiencia.AutoSize = true;
            this.chbCiencia.Location = new System.Drawing.Point(16, 152);
            this.chbCiencia.Name = "chbCiencia";
            this.chbCiencia.Size = new System.Drawing.Size(61, 17);
            this.chbCiencia.TabIndex = 2;
            this.chbCiencia.Text = "Ciencia";
            this.chbCiencia.UseVisualStyleBackColor = true;
            // 
            // chbAventura
            // 
            this.chbAventura.AutoSize = true;
            this.chbAventura.Location = new System.Drawing.Point(16, 203);
            this.chbAventura.Name = "chbAventura";
            this.chbAventura.Size = new System.Drawing.Size(69, 17);
            this.chbAventura.TabIndex = 3;
            this.chbAventura.Text = "Aventura";
            this.chbAventura.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAventura);
            this.groupBox2.Controls.Add(this.rbCiencia);
            this.groupBox2.Controls.Add(this.rbAccion);
            this.groupBox2.Controls.Add(this.rbComedia);
            this.groupBox2.Location = new System.Drawing.Point(296, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genero Favorito";
            // 
            // rbComedia
            // 
            this.rbComedia.AutoSize = true;
            this.rbComedia.Location = new System.Drawing.Point(15, 57);
            this.rbComedia.Name = "rbComedia";
            this.rbComedia.Size = new System.Drawing.Size(66, 17);
            this.rbComedia.TabIndex = 0;
            this.rbComedia.TabStop = true;
            this.rbComedia.Text = "Comedia";
            this.rbComedia.UseVisualStyleBackColor = true;
            // 
            // rbAccion
            // 
            this.rbAccion.AutoSize = true;
            this.rbAccion.Location = new System.Drawing.Point(15, 109);
            this.rbAccion.Name = "rbAccion";
            this.rbAccion.Size = new System.Drawing.Size(58, 17);
            this.rbAccion.TabIndex = 1;
            this.rbAccion.TabStop = true;
            this.rbAccion.Text = "Acción";
            this.rbAccion.UseVisualStyleBackColor = true;
            // 
            // rbCiencia
            // 
            this.rbCiencia.AutoSize = true;
            this.rbCiencia.Location = new System.Drawing.Point(15, 152);
            this.rbCiencia.Name = "rbCiencia";
            this.rbCiencia.Size = new System.Drawing.Size(60, 17);
            this.rbCiencia.TabIndex = 2;
            this.rbCiencia.TabStop = true;
            this.rbCiencia.Text = "Ciencia";
            this.rbCiencia.UseVisualStyleBackColor = true;
            // 
            // rbAventura
            // 
            this.rbAventura.AutoSize = true;
            this.rbAventura.Location = new System.Drawing.Point(15, 203);
            this.rbAventura.Name = "rbAventura";
            this.rbAventura.Size = new System.Drawing.Size(68, 17);
            this.rbAventura.TabIndex = 3;
            this.rbAventura.TabStop = true;
            this.rbAventura.Text = "Aventura";
            this.rbAventura.UseVisualStyleBackColor = true;
            // 
            // cbCombo
            // 
            this.cbCombo.FormattingEnabled = true;
            this.cbCombo.Items.AddRange(new object[] {
            "Genero que te gusta",
            "Genero Favorito"});
            this.cbCombo.Location = new System.Drawing.Point(296, 300);
            this.cbCombo.Name = "cbCombo";
            this.cbCombo.Size = new System.Drawing.Size(205, 21);
            this.cbCombo.TabIndex = 2;
            this.cbCombo.Text = "Seleccione --";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ver Seleccionadas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 333);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbCombo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Elementos Graficos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbAventura;
        private System.Windows.Forms.CheckBox chbCiencia;
        private System.Windows.Forms.CheckBox chbAccion;
        private System.Windows.Forms.CheckBox chbComedia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAventura;
        private System.Windows.Forms.RadioButton rbCiencia;
        private System.Windows.Forms.RadioButton rbAccion;
        private System.Windows.Forms.RadioButton rbComedia;
        private System.Windows.Forms.ComboBox cbCombo;
        private System.Windows.Forms.Button button1;
    }
}


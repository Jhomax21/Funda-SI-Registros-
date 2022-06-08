
namespace heroes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombreAlbum = new System.Windows.Forms.TextBox();
            this.txtCodigoAlbum = new System.Windows.Forms.TextBox();
            this.labelNombreAlbum = new System.Windows.Forms.Label();
            this.labelCodigoAlbum = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPoderheroe = new System.Windows.Forms.TextBox();
            this.cboAlbum = new System.Windows.Forms.ComboBox();
            this.txtcaracteristicaheroe = new System.Windows.Forms.TextBox();
            this.txtNombreheroe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombreHeroe = new System.Windows.Forms.Label();
            this.txtCodigoheroe = new System.Windows.Forms.TextBox();
            this.labelCodigoHeroe = new System.Windows.Forms.Label();
            this.lvAlbum = new System.Windows.Forms.ListView();
            this.lvHeroesXAlbum = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboAlbum2 = new System.Windows.Forms.ComboBox();
            this.cboHeroe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAlbumMasHeroes = new System.Windows.Forms.Label();
            this.lblHeroesMasPoder = new System.Windows.Forms.Label();
            this.lblHeroeMenosPoder = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtNombreAlbum);
            this.groupBox1.Controls.Add(this.txtCodigoAlbum);
            this.groupBox1.Controls.Add(this.labelNombreAlbum);
            this.groupBox1.Controls.Add(this.labelCodigoAlbum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Album";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombreAlbum
            // 
            this.txtNombreAlbum.Location = new System.Drawing.Point(79, 49);
            this.txtNombreAlbum.Name = "txtNombreAlbum";
            this.txtNombreAlbum.Size = new System.Drawing.Size(133, 20);
            this.txtNombreAlbum.TabIndex = 3;
            // 
            // txtCodigoAlbum
            // 
            this.txtCodigoAlbum.Location = new System.Drawing.Point(79, 17);
            this.txtCodigoAlbum.Name = "txtCodigoAlbum";
            this.txtCodigoAlbum.Size = new System.Drawing.Size(133, 20);
            this.txtCodigoAlbum.TabIndex = 2;
            // 
            // labelNombreAlbum
            // 
            this.labelNombreAlbum.AutoSize = true;
            this.labelNombreAlbum.Location = new System.Drawing.Point(7, 52);
            this.labelNombreAlbum.Name = "labelNombreAlbum";
            this.labelNombreAlbum.Size = new System.Drawing.Size(44, 13);
            this.labelNombreAlbum.TabIndex = 1;
            this.labelNombreAlbum.Text = "Nombre";
            // 
            // labelCodigoAlbum
            // 
            this.labelCodigoAlbum.AutoSize = true;
            this.labelCodigoAlbum.Location = new System.Drawing.Point(7, 20);
            this.labelCodigoAlbum.Name = "labelCodigoAlbum";
            this.labelCodigoAlbum.Size = new System.Drawing.Size(40, 13);
            this.labelCodigoAlbum.TabIndex = 0;
            this.labelCodigoAlbum.Text = "Codigo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtPoderheroe);
            this.groupBox2.Controls.Add(this.cboAlbum);
            this.groupBox2.Controls.Add(this.txtcaracteristicaheroe);
            this.groupBox2.Controls.Add(this.txtNombreheroe);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.labelNombreHeroe);
            this.groupBox2.Controls.Add(this.txtCodigoheroe);
            this.groupBox2.Controls.Add(this.labelCodigoHeroe);
            this.groupBox2.Location = new System.Drawing.Point(2, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrar un heroe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Album";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPoderheroe
            // 
            this.txtPoderheroe.Location = new System.Drawing.Point(110, 127);
            this.txtPoderheroe.Name = "txtPoderheroe";
            this.txtPoderheroe.Size = new System.Drawing.Size(122, 20);
            this.txtPoderheroe.TabIndex = 7;
            // 
            // cboAlbum
            // 
            this.cboAlbum.FormattingEnabled = true;
            this.cboAlbum.Location = new System.Drawing.Point(110, 162);
            this.cboAlbum.Name = "cboAlbum";
            this.cboAlbum.Size = new System.Drawing.Size(121, 21);
            this.cboAlbum.TabIndex = 2;
            this.cboAlbum.SelectedIndexChanged += new System.EventHandler(this.cboAlbum_SelectedIndexChanged);
            // 
            // txtcaracteristicaheroe
            // 
            this.txtcaracteristicaheroe.Location = new System.Drawing.Point(110, 91);
            this.txtcaracteristicaheroe.Name = "txtcaracteristicaheroe";
            this.txtcaracteristicaheroe.Size = new System.Drawing.Size(122, 20);
            this.txtcaracteristicaheroe.TabIndex = 6;
            // 
            // txtNombreheroe
            // 
            this.txtNombreheroe.Location = new System.Drawing.Point(110, 53);
            this.txtNombreheroe.Name = "txtNombreheroe";
            this.txtNombreheroe.Size = new System.Drawing.Size(122, 20);
            this.txtNombreheroe.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Poder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Caracteristicas";
            // 
            // labelNombreHeroe
            // 
            this.labelNombreHeroe.AutoSize = true;
            this.labelNombreHeroe.Location = new System.Drawing.Point(15, 56);
            this.labelNombreHeroe.Name = "labelNombreHeroe";
            this.labelNombreHeroe.Size = new System.Drawing.Size(44, 13);
            this.labelNombreHeroe.TabIndex = 2;
            this.labelNombreHeroe.Text = "Nombre";
            // 
            // txtCodigoheroe
            // 
            this.txtCodigoheroe.Location = new System.Drawing.Point(110, 17);
            this.txtCodigoheroe.Name = "txtCodigoheroe";
            this.txtCodigoheroe.Size = new System.Drawing.Size(122, 20);
            this.txtCodigoheroe.TabIndex = 1;
            // 
            // labelCodigoHeroe
            // 
            this.labelCodigoHeroe.AutoSize = true;
            this.labelCodigoHeroe.Location = new System.Drawing.Point(15, 20);
            this.labelCodigoHeroe.Name = "labelCodigoHeroe";
            this.labelCodigoHeroe.Size = new System.Drawing.Size(40, 13);
            this.labelCodigoHeroe.TabIndex = 0;
            this.labelCodigoHeroe.Text = "Codigo";
            // 
            // lvAlbum
            // 
            this.lvAlbum.HideSelection = false;
            this.lvAlbum.Location = new System.Drawing.Point(483, 61);
            this.lvAlbum.Name = "lvAlbum";
            this.lvAlbum.Size = new System.Drawing.Size(249, 154);
            this.lvAlbum.TabIndex = 5;
            this.lvAlbum.UseCompatibleStateImageBehavior = false;
            // 
            // lvHeroesXAlbum
            // 
            this.lvHeroesXAlbum.HideSelection = false;
            this.lvHeroesXAlbum.Location = new System.Drawing.Point(266, 64);
            this.lvHeroesXAlbum.Name = "lvHeroesXAlbum";
            this.lvHeroesXAlbum.Size = new System.Drawing.Size(212, 151);
            this.lvHeroesXAlbum.TabIndex = 6;
            this.lvHeroesXAlbum.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Album con más héroes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Heroe con más poder:";
            // 
            // cboAlbum2
            // 
            this.cboAlbum2.FormattingEnabled = true;
            this.cboAlbum2.Location = new System.Drawing.Point(324, 38);
            this.cboAlbum2.Name = "cboAlbum2";
            this.cboAlbum2.Size = new System.Drawing.Size(121, 21);
            this.cboAlbum2.TabIndex = 10;
            this.cboAlbum2.SelectedIndexChanged += new System.EventHandler(this.cboAlbum2_SelectedIndexChanged);
            this.cboAlbum2.SelectedValueChanged += new System.EventHandler(this.cboAlbum2_SelectedValueChanged);
            // 
            // cboHeroe
            // 
            this.cboHeroe.FormattingEnabled = true;
            this.cboHeroe.Location = new System.Drawing.Point(563, 38);
            this.cboHeroe.Name = "cboHeroe";
            this.cboHeroe.Size = new System.Drawing.Size(121, 21);
            this.cboHeroe.TabIndex = 11;
            this.cboHeroe.SelectedIndexChanged += new System.EventHandler(this.cboHeroe_SelectedIndexChanged);
            this.cboHeroe.SelectedValueChanged += new System.EventHandler(this.cboHeroe_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Album";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Heroe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 317);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Heroe con menos poder";
            // 
            // lblAlbumMasHeroes
            // 
            this.lblAlbumMasHeroes.AutoSize = true;
            this.lblAlbumMasHeroes.Location = new System.Drawing.Point(399, 259);
            this.lblAlbumMasHeroes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlbumMasHeroes.Name = "lblAlbumMasHeroes";
            this.lblAlbumMasHeroes.Size = new System.Drawing.Size(117, 13);
            this.lblAlbumMasHeroes.TabIndex = 14;
            this.lblAlbumMasHeroes.Text = "Album con más héroes:";
            // 
            // lblHeroesMasPoder
            // 
            this.lblHeroesMasPoder.AutoSize = true;
            this.lblHeroesMasPoder.Location = new System.Drawing.Point(399, 288);
            this.lblHeroesMasPoder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeroesMasPoder.Name = "lblHeroesMasPoder";
            this.lblHeroesMasPoder.Size = new System.Drawing.Size(117, 13);
            this.lblHeroesMasPoder.TabIndex = 15;
            this.lblHeroesMasPoder.Text = "Album con más héroes:";
            // 
            // lblHeroeMenosPoder
            // 
            this.lblHeroeMenosPoder.AutoSize = true;
            this.lblHeroeMenosPoder.Location = new System.Drawing.Point(399, 317);
            this.lblHeroeMenosPoder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeroeMenosPoder.Name = "lblHeroeMenosPoder";
            this.lblHeroeMenosPoder.Size = new System.Drawing.Size(117, 13);
            this.lblHeroeMenosPoder.TabIndex = 16;
            this.lblHeroeMenosPoder.Text = "Album con más héroes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 394);
            this.Controls.Add(this.lblHeroeMenosPoder);
            this.Controls.Add(this.lblHeroesMasPoder);
            this.Controls.Add(this.lblAlbumMasHeroes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboHeroe);
            this.Controls.Add(this.cboAlbum2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvHeroesXAlbum);
            this.Controls.Add(this.lvAlbum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombreAlbum;
        private System.Windows.Forms.TextBox txtCodigoAlbum;
        private System.Windows.Forms.Label labelNombreAlbum;
        private System.Windows.Forms.Label labelCodigoAlbum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPoderheroe;
        private System.Windows.Forms.TextBox txtcaracteristicaheroe;
        private System.Windows.Forms.TextBox txtNombreheroe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombreHeroe;
        private System.Windows.Forms.TextBox txtCodigoheroe;
        private System.Windows.Forms.Label labelCodigoHeroe;
        private System.Windows.Forms.ComboBox cboAlbum;
        private System.Windows.Forms.ListView lvAlbum;
        private System.Windows.Forms.ListView lvHeroesXAlbum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboAlbum2;
        private System.Windows.Forms.ComboBox cboHeroe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAlbumMasHeroes;
        private System.Windows.Forms.Label lblHeroesMasPoder;
        private System.Windows.Forms.Label lblHeroeMenosPoder;
    }
}


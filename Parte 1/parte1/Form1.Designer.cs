
namespace parte1
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
            this.label2 = new System.Windows.Forms.Label();
            this.rbmanual = new System.Windows.Forms.RadioButton();
            this.rbelectrico = new System.Windows.Forms.RadioButton();
            this.sboferta = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.bagregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbprecio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelcant11 = new System.Windows.Forms.Label();
            this.labelcant19 = new System.Windows.Forms.Label();
            this.labelcant31 = new System.Windows.Forms.Label();
            this.labelcantfree = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tipo de scooter :";
            // 
            // rbmanual
            // 
            this.rbmanual.AutoSize = true;
            this.rbmanual.Location = new System.Drawing.Point(67, 64);
            this.rbmanual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbmanual.Name = "rbmanual";
            this.rbmanual.Size = new System.Drawing.Size(70, 20);
            this.rbmanual.TabIndex = 38;
            this.rbmanual.Text = "Manual";
            this.rbmanual.UseVisualStyleBackColor = true;
            // 
            // rbelectrico
            // 
            this.rbelectrico.AutoSize = true;
            this.rbelectrico.Location = new System.Drawing.Point(173, 64);
            this.rbelectrico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbelectrico.Name = "rbelectrico";
            this.rbelectrico.Size = new System.Drawing.Size(78, 20);
            this.rbelectrico.TabIndex = 39;
            this.rbelectrico.Text = "Electrico";
            this.rbelectrico.UseVisualStyleBackColor = true;
            // 
            // sboferta
            // 
            this.sboferta.FormattingEnabled = true;
            this.sboferta.Location = new System.Drawing.Point(80, 149);
            this.sboferta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sboferta.Name = "sboferta";
            this.sboferta.Size = new System.Drawing.Size(160, 24);
            this.sboferta.TabIndex = 40;
            this.sboferta.SelectedIndexChanged += new System.EventHandler(this.sboferta_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(67, 215);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(383, 171);
            this.listView1.TabIndex = 41;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // bagregar
            // 
            this.bagregar.Location = new System.Drawing.Point(336, 82);
            this.bagregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bagregar.Name = "bagregar";
            this.bagregar.Size = new System.Drawing.Size(100, 28);
            this.bagregar.TabIndex = 42;
            this.bagregar.Text = "Agregar";
            this.bagregar.UseVisualStyleBackColor = true;
            this.bagregar.Click += new System.EventHandler(this.bagregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Escoja oferta:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbprecio
            // 
            this.lbprecio.AutoSize = true;
            this.lbprecio.Location = new System.Drawing.Point(305, 159);
            this.lbprecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbprecio.Name = "lbprecio";
            this.lbprecio.Size = new System.Drawing.Size(14, 16);
            this.lbprecio.TabIndex = 44;
            this.lbprecio.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "S/";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(591, 82);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(248, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "Numero de veces que se tomo cada oferta";
            // 
            // labelcant11
            // 
            this.labelcant11.AutoSize = true;
            this.labelcant11.Location = new System.Drawing.Point(612, 149);
            this.labelcant11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcant11.Name = "labelcant11";
            this.labelcant11.Size = new System.Drawing.Size(14, 16);
            this.labelcant11.TabIndex = 47;
            this.labelcant11.Text = "x";
            // 
            // labelcant19
            // 
            this.labelcant19.AutoSize = true;
            this.labelcant19.Location = new System.Drawing.Point(716, 153);
            this.labelcant19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcant19.Name = "labelcant19";
            this.labelcant19.Size = new System.Drawing.Size(14, 16);
            this.labelcant19.TabIndex = 48;
            this.labelcant19.Text = "x";
            // 
            // labelcant31
            // 
            this.labelcant31.AutoSize = true;
            this.labelcant31.Location = new System.Drawing.Point(799, 153);
            this.labelcant31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcant31.Name = "labelcant31";
            this.labelcant31.Size = new System.Drawing.Size(14, 16);
            this.labelcant31.TabIndex = 49;
            this.labelcant31.Text = "x";
            // 
            // labelcantfree
            // 
            this.labelcantfree.AutoSize = true;
            this.labelcantfree.Location = new System.Drawing.Point(891, 153);
            this.labelcantfree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcantfree.Name = "labelcantfree";
            this.labelcantfree.Size = new System.Drawing.Size(14, 16);
            this.labelcantfree.TabIndex = 50;
            this.labelcantfree.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(591, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 51;
            this.label8.Text = "11 km";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "19 km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(785, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "31 km";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(869, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Free";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelcantfree);
            this.Controls.Add(this.labelcant31);
            this.Controls.Add(this.labelcant19);
            this.Controls.Add(this.labelcant11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbprecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bagregar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.sboferta);
            this.Controls.Add(this.rbelectrico);
            this.Controls.Add(this.rbmanual);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbmanual;
        private System.Windows.Forms.RadioButton rbelectrico;
        private System.Windows.Forms.ComboBox sboferta;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button bagregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbprecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelcant11;
        private System.Windows.Forms.Label labelcant19;
        private System.Windows.Forms.Label labelcant31;
        private System.Windows.Forms.Label labelcantfree;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


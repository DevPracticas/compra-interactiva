namespace winAppCompraInteractiva
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.picRopa2 = new System.Windows.Forms.PictureBox();
            this.picRopa1 = new System.Windows.Forms.PictureBox();
            this.picRopa3 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.picTranporte = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.picLineaBlanca = new System.Windows.Forms.PictureBox();
            this.picJugos = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRopa2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRopa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRopa3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTranporte)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLineaBlanca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJugos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(46, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ropa";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(15, 77);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(68, 19);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Zapatos";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 52);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(73, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Pantalon";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Camisa";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // picRopa2
            // 
            this.picRopa2.Location = new System.Drawing.Point(40, 277);
            this.picRopa2.Name = "picRopa2";
            this.picRopa2.Size = new System.Drawing.Size(100, 50);
            this.picRopa2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRopa2.TabIndex = 1;
            this.picRopa2.TabStop = false;
            // 
            // picRopa1
            // 
            this.picRopa1.Location = new System.Drawing.Point(109, 207);
            this.picRopa1.Name = "picRopa1";
            this.picRopa1.Size = new System.Drawing.Size(100, 50);
            this.picRopa1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRopa1.TabIndex = 2;
            this.picRopa1.TabStop = false;
            // 
            // picRopa3
            // 
            this.picRopa3.Location = new System.Drawing.Point(173, 277);
            this.picRopa3.Name = "picRopa3";
            this.picRopa3.Size = new System.Drawing.Size(100, 50);
            this.picRopa3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRopa3.TabIndex = 3;
            this.picRopa3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(294, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transporte";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Taxi";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bus";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // picTranporte
            // 
            this.picTranporte.Location = new System.Drawing.Point(351, 207);
            this.picTranporte.Name = "picTranporte";
            this.picTranporte.Size = new System.Drawing.Size(100, 50);
            this.picTranporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTranporte.TabIndex = 5;
            this.picTranporte.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(527, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jugos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mora",
            "Furtilla",
            "Mango"});
            this.comboBox1.Location = new System.Drawing.Point(15, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Location = new System.Drawing.Point(770, 84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Línea Blanca";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Cocina",
            "Refrigeradora",
            "lavadora"});
            this.listBox1.Location = new System.Drawing.Point(23, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(129, 64);
            this.listBox1.TabIndex = 0;
            // 
            // picLineaBlanca
            // 
            this.picLineaBlanca.Location = new System.Drawing.Point(806, 218);
            this.picLineaBlanca.Name = "picLineaBlanca";
            this.picLineaBlanca.Size = new System.Drawing.Size(100, 50);
            this.picLineaBlanca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLineaBlanca.TabIndex = 8;
            this.picLineaBlanca.TabStop = false;
            // 
            // picJugos
            // 
            this.picJugos.Location = new System.Drawing.Point(578, 218);
            this.picJugos.Name = "picJugos";
            this.picJugos.Size = new System.Drawing.Size(100, 50);
            this.picJugos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picJugos.TabIndex = 9;
            this.picJugos.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.picJugos);
            this.Controls.Add(this.picLineaBlanca);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.picTranporte);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.picRopa3);
            this.Controls.Add(this.picRopa1);
            this.Controls.Add(this.picRopa2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRopa2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRopa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRopa3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTranporte)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLineaBlanca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJugos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private PictureBox picRopa2;
        private PictureBox picRopa1;
        private PictureBox picRopa3;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private PictureBox picTranporte;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private GroupBox groupBox4;
        private ListBox listBox1;
        private PictureBox picLineaBlanca;
        private PictureBox picJugos;
    }
}
namespace Ej1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBmarca = new System.Windows.Forms.TextBox();
            this.tBvalor = new System.Windows.Forms.TextBox();
            this.tBvidaUtil = new System.Windows.Forms.TextBox();
            this.nAñoACalcular = new System.Windows.Forms.NumericUpDown();
            this.nModelo = new System.Windows.Forms.NumericUpDown();
            this.tbTasa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bCalcular = new System.Windows.Forms.Button();
            this.rBlineal = new System.Windows.Forms.RadioButton();
            this.rBanual = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAñoACalcular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nModelo);
            this.groupBox1.Controls.Add(this.tBvalor);
            this.groupBox1.Controls.Add(this.tBmarca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del vehiculo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBanual);
            this.groupBox2.Controls.Add(this.rBlineal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbTasa);
            this.groupBox2.Controls.Add(this.tBvidaUtil);
            this.groupBox2.Controls.Add(this.nAñoACalcular);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculo depreciación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo Año)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor de fabricación $";
            // 
            // tBmarca
            // 
            this.tBmarca.Location = new System.Drawing.Point(167, 32);
            this.tBmarca.Name = "tBmarca";
            this.tBmarca.Size = new System.Drawing.Size(100, 20);
            this.tBmarca.TabIndex = 3;
            // 
            // tBvalor
            // 
            this.tBvalor.Location = new System.Drawing.Point(167, 101);
            this.tBvalor.Name = "tBvalor";
            this.tBvalor.Size = new System.Drawing.Size(100, 20);
            this.tBvalor.TabIndex = 4;
            // 
            // tBvidaUtil
            // 
            this.tBvidaUtil.Location = new System.Drawing.Point(150, 134);
            this.tBvidaUtil.Name = "tBvidaUtil";
            this.tBvidaUtil.Size = new System.Drawing.Size(100, 20);
            this.tBvidaUtil.TabIndex = 5;
            // 
            // nAñoACalcular
            // 
            this.nAñoACalcular.Location = new System.Drawing.Point(147, 63);
            this.nAñoACalcular.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nAñoACalcular.Name = "nAñoACalcular";
            this.nAñoACalcular.Size = new System.Drawing.Size(120, 20);
            this.nAñoACalcular.TabIndex = 5;
            // 
            // nModelo
            // 
            this.nModelo.Location = new System.Drawing.Point(167, 68);
            this.nModelo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nModelo.Name = "nModelo";
            this.nModelo.Size = new System.Drawing.Size(120, 20);
            this.nModelo.TabIndex = 6;
            // 
            // tbTasa
            // 
            this.tbTasa.Location = new System.Drawing.Point(150, 92);
            this.tbTasa.Name = "tbTasa";
            this.tbTasa.Size = new System.Drawing.Size(100, 20);
            this.tbTasa.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vida Útil (Años)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tasa de depreciación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Año a calcular";
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(413, 301);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(89, 40);
            this.bCalcular.TabIndex = 10;
            this.bCalcular.Text = "Calcular costo";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // rBlineal
            // 
            this.rBlineal.AutoSize = true;
            this.rBlineal.Location = new System.Drawing.Point(70, 19);
            this.rBlineal.Name = "rBlineal";
            this.rBlineal.Size = new System.Drawing.Size(53, 17);
            this.rBlineal.TabIndex = 11;
            this.rBlineal.TabStop = true;
            this.rBlineal.Text = "Lineal";
            this.rBlineal.UseVisualStyleBackColor = true;
            // 
            // rBanual
            // 
            this.rBanual.AutoSize = true;
            this.rBanual.Location = new System.Drawing.Point(202, 19);
            this.rBanual.Name = "rBanual";
            this.rBanual.Size = new System.Drawing.Size(52, 17);
            this.rBanual.TabIndex = 12;
            this.rBanual.TabStop = true;
            this.rBanual.Text = "Anual";
            this.rBanual.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 364);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAñoACalcular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nModelo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tBvalor;
        private System.Windows.Forms.TextBox tBmarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBvidaUtil;
        private System.Windows.Forms.NumericUpDown nModelo;
        private System.Windows.Forms.RadioButton rBanual;
        private System.Windows.Forms.RadioButton rBlineal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTasa;
        private System.Windows.Forms.NumericUpDown nAñoACalcular;
        private System.Windows.Forms.Button bCalcular;
    }
}


namespace resto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.txtRestoDaDivisao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSubtracao1 = new System.Windows.Forms.TextBox();
            this.txtSubtracao2 = new System.Windows.Forms.TextBox();
            this.txtResultadoSubtracao = new System.Windows.Forms.TextBox();
            this.txtSoma1 = new System.Windows.Forms.TextBox();
            this.txtSoma2 = new System.Windows.Forms.TextBox();
            this.txtResultadoSoma = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtMultiplicao1 = new System.Windows.Forms.TextBox();
            this.txtMultiplicacao2 = new System.Windows.Forms.TextBox();
            this.txtResultadoMultiplicacao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dividendo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(129, 39);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(141, 26);
            this.txtDividendo.TabIndex = 1;
            this.txtDividendo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(404, 39);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(141, 26);
            this.txtDivisor.TabIndex = 2;
            // 
            // txtRestoDaDivisao
            // 
            this.txtRestoDaDivisao.Location = new System.Drawing.Point(404, 75);
            this.txtRestoDaDivisao.Name = "txtRestoDaDivisao";
            this.txtRestoDaDivisao.ReadOnly = true;
            this.txtRestoDaDivisao.Size = new System.Drawing.Size(141, 26);
            this.txtRestoDaDivisao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Divisor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resto:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Realizar divisão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Primeiro nº";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(819, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Segundo nº";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(819, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "R soma:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Realizar soma";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Primeiro nº";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Segundo nº";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "R subtração";
            // 
            // txtSubtracao1
            // 
            this.txtSubtracao1.Location = new System.Drawing.Point(129, 156);
            this.txtSubtracao1.Name = "txtSubtracao1";
            this.txtSubtracao1.Size = new System.Drawing.Size(141, 26);
            this.txtSubtracao1.TabIndex = 14;
            // 
            // txtSubtracao2
            // 
            this.txtSubtracao2.Location = new System.Drawing.Point(404, 156);
            this.txtSubtracao2.Name = "txtSubtracao2";
            this.txtSubtracao2.Size = new System.Drawing.Size(141, 26);
            this.txtSubtracao2.TabIndex = 15;
            // 
            // txtResultadoSubtracao
            // 
            this.txtResultadoSubtracao.Location = new System.Drawing.Point(404, 194);
            this.txtResultadoSubtracao.Name = "txtResultadoSubtracao";
            this.txtResultadoSubtracao.ReadOnly = true;
            this.txtResultadoSubtracao.Size = new System.Drawing.Size(141, 26);
            this.txtResultadoSubtracao.TabIndex = 16;
            this.txtResultadoSubtracao.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtSoma1
            // 
            this.txtSoma1.Location = new System.Drawing.Point(666, 36);
            this.txtSoma1.Name = "txtSoma1";
            this.txtSoma1.Size = new System.Drawing.Size(141, 26);
            this.txtSoma1.TabIndex = 18;
            // 
            // txtSoma2
            // 
            this.txtSoma2.Location = new System.Drawing.Point(969, 42);
            this.txtSoma2.Name = "txtSoma2";
            this.txtSoma2.Size = new System.Drawing.Size(141, 26);
            this.txtSoma2.TabIndex = 19;
            // 
            // txtResultadoSoma
            // 
            this.txtResultadoSoma.Location = new System.Drawing.Point(969, 77);
            this.txtResultadoSoma.Name = "txtResultadoSoma";
            this.txtResultadoSoma.ReadOnly = true;
            this.txtResultadoSoma.Size = new System.Drawing.Size(141, 26);
            this.txtResultadoSoma.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 34);
            this.button3.TabIndex = 21;
            this.button3.Text = "Realizar subtração";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(578, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 34);
            this.button4.TabIndex = 22;
            this.button4.Text = "Realizar multiplicação";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtMultiplicao1
            // 
            this.txtMultiplicao1.Location = new System.Drawing.Point(666, 156);
            this.txtMultiplicao1.Name = "txtMultiplicao1";
            this.txtMultiplicao1.Size = new System.Drawing.Size(141, 26);
            this.txtMultiplicao1.TabIndex = 23;
            // 
            // txtMultiplicacao2
            // 
            this.txtMultiplicacao2.Location = new System.Drawing.Point(969, 159);
            this.txtMultiplicacao2.Name = "txtMultiplicacao2";
            this.txtMultiplicacao2.Size = new System.Drawing.Size(141, 26);
            this.txtMultiplicacao2.TabIndex = 24;
            // 
            // txtResultadoMultiplicacao
            // 
            this.txtResultadoMultiplicacao.Location = new System.Drawing.Point(969, 196);
            this.txtResultadoMultiplicacao.Name = "txtResultadoMultiplicacao";
            this.txtResultadoMultiplicacao.ReadOnly = true;
            this.txtResultadoMultiplicacao.Size = new System.Drawing.Size(141, 26);
            this.txtResultadoMultiplicacao.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(578, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Primeiro nº";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(823, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Segundo nº";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(823, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "R multiplicação";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "label13";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 26);
            this.textBox1.TabIndex = 30;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 319);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 26);
            this.textBox2.TabIndex = 31;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 352);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 26);
            this.textBox3.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 703);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtResultadoMultiplicacao);
            this.Controls.Add(this.txtMultiplicacao2);
            this.Controls.Add(this.txtMultiplicao1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtResultadoSoma);
            this.Controls.Add(this.txtSoma2);
            this.Controls.Add(this.txtSoma1);
            this.Controls.Add(this.txtResultadoSubtracao);
            this.Controls.Add(this.txtSubtracao2);
            this.Controls.Add(this.txtSubtracao1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRestoDaDivisao);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.txtDividendo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.TextBox txtRestoDaDivisao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSubtracao1;
        private System.Windows.Forms.TextBox txtSubtracao2;
        private System.Windows.Forms.TextBox txtResultadoSubtracao;
        private System.Windows.Forms.TextBox txtSoma1;
        private System.Windows.Forms.TextBox txtSoma2;
        private System.Windows.Forms.TextBox txtResultadoSoma;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtMultiplicao1;
        private System.Windows.Forms.TextBox txtMultiplicacao2;
        private System.Windows.Forms.TextBox txtResultadoMultiplicacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}


namespace CalculadoraForms
{
    partial class App
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
            this.txtTela = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTela
            // 
            this.txtTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTela.Location = new System.Drawing.Point(13, 12);
            this.txtTela.Multiline = true;
            this.txtTela.Name = "txtTela";
            this.txtTela.Size = new System.Drawing.Size(338, 62);
            this.txtTela.TabIndex = 0;
            this.txtTela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTela.TextChanged += new System.EventHandler(this.txtTela_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(12, 81);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 70);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(98, 80);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(80, 70);
            this.btnDividir.TabIndex = 3;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.operador_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(184, 81);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(80, 70);
            this.btnMultiplicar.TabIndex = 4;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.operador_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.Location = new System.Drawing.Point(270, 81);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(80, 70);
            this.btnSubtrair.TabIndex = 8;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.operador_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(184, 157);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(80, 70);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.numero_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(98, 157);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 70);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.numero_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 157);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 70);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.numero_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(272, 157);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(80, 70);
            this.btnSomar.TabIndex = 12;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.operador_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(184, 233);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 70);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.numero_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(98, 233);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 70);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.numero_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(12, 233);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 70);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.numero_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Location = new System.Drawing.Point(270, 233);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(80, 222);
            this.btnResultado.TabIndex = 16;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(184, 309);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 70);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.numero_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(98, 309);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 70);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.numero_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 309);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 70);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.numero_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(13, 385);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(165, 70);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.numero_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(184, 385);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(80, 70);
            this.btnApagar.TabIndex = 18;
            this.btnApagar.Text = "<";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 484);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtTela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTela;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnApagar;
    }
}


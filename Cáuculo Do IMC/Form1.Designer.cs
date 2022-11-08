namespace Cáuculo_Do_IMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.lblIMC = new System.Windows.Forms.Label();
            this.txbN1 = new System.Windows.Forms.TextBox();
            this.txbN2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN1.Location = new System.Drawing.Point(28, 85);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(51, 20);
            this.lblN1.TabIndex = 0;
            this.lblN1.Text = "Altura";
            this.lblN1.Click += new System.EventHandler(this.lblN1_Click);
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.Location = new System.Drawing.Point(28, 124);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(45, 20);
            this.lblN2.TabIndex = 2;
            this.lblN2.Text = "Peso";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(32, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 25);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Calcule seu IMC";
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(35, 220);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(181, 35);
            this.btnResultado.TabIndex = 5;
            this.btnResultado.Text = "Calcular";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(31, 264);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(38, 20);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "IMC";
            this.lblResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbResultado
            // 
            this.txbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResultado.Location = new System.Drawing.Point(78, 261);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            this.txbResultado.Size = new System.Drawing.Size(100, 26);
            this.txbResultado.TabIndex = 7;
            this.txbResultado.TabStop = false;
            this.txbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbResultado.TextChanged += new System.EventHandler(this.txbResultado_TextChanged);
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(34, 303);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(0, 20);
            this.lblIMC.TabIndex = 8;
            // 
            // txbN1
            // 
            this.txbN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbN1.Location = new System.Drawing.Point(93, 82);
            this.txbN1.Name = "txbN1";
            this.txbN1.Size = new System.Drawing.Size(100, 26);
            this.txbN1.TabIndex = 9;
            // 
            // txbN2
            // 
            this.txbN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbN2.Location = new System.Drawing.Point(93, 121);
            this.txbN2.Name = "txbN2";
            this.txbN2.Size = new System.Drawing.Size(100, 26);
            this.txbN2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 345);
            this.Controls.Add(this.txbN2);
            this.Controls.Add(this.txbN1);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cálculo do IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txbResultado;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.TextBox txbN1;
        private System.Windows.Forms.TextBox txbN2;
    }
}


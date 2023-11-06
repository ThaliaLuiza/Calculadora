namespace Calculadora
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.rbSoma = new System.Windows.Forms.RadioButton();
            this.rbSub = new System.Windows.Forms.RadioButton();
            this.rbDiv = new System.Windows.Forms.RadioButton();
            this.rbMulti = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(95, 96);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(95, 146);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 1;
            // 
            // rbSoma
            // 
            this.rbSoma.AutoSize = true;
            this.rbSoma.Location = new System.Drawing.Point(95, 188);
            this.rbSoma.Name = "rbSoma";
            this.rbSoma.Size = new System.Drawing.Size(52, 17);
            this.rbSoma.TabIndex = 2;
            this.rbSoma.Text = "Soma";
            this.rbSoma.UseVisualStyleBackColor = true;
            // 
            // rbSub
            // 
            this.rbSub.AutoSize = true;
            this.rbSub.Location = new System.Drawing.Point(95, 212);
            this.rbSub.Name = "rbSub";
            this.rbSub.Size = new System.Drawing.Size(74, 17);
            this.rbSub.TabIndex = 3;
            this.rbSub.TabStop = true;
            this.rbSub.Text = "Subtração";
            this.rbSub.UseVisualStyleBackColor = true;
            // 
            // rbDiv
            // 
            this.rbDiv.AutoSize = true;
            this.rbDiv.Location = new System.Drawing.Point(95, 236);
            this.rbDiv.Name = "rbDiv";
            this.rbDiv.Size = new System.Drawing.Size(60, 17);
            this.rbDiv.TabIndex = 4;
            this.rbDiv.TabStop = true;
            this.rbDiv.Text = "Divisão";
            this.rbDiv.UseVisualStyleBackColor = true;
            // 
            // rbMulti
            // 
            this.rbMulti.AutoSize = true;
            this.rbMulti.Location = new System.Drawing.Point(95, 260);
            this.rbMulti.Name = "rbMulti";
            this.rbMulti.Size = new System.Drawing.Size(87, 17);
            this.rbMulti.TabIndex = 5;
            this.rbMulti.TabStop = true;
            this.rbMulti.Text = "Multiplicação";
            this.rbMulti.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(33, 404);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // bntCalcular
            // 
            this.bntCalcular.Location = new System.Drawing.Point(62, 295);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(155, 65);
            this.bntCalcular.TabIndex = 7;
            this.bntCalcular.Text = "CALCULAR";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(33, 99);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(56, 13);
            this.lblNum1.TabIndex = 8;
            this.lblNum1.Text = "Numero 1:";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(33, 149);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(56, 13);
            this.lblNum2.TabIndex = 9;
            this.lblNum2.Text = "Numero 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 446);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.rbMulti);
            this.Controls.Add(this.rbDiv);
            this.Controls.Add(this.rbSub);
            this.Controls.Add(this.rbSoma);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CALCULADORA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.RadioButton rbSoma;
        private System.Windows.Forms.RadioButton rbSub;
        private System.Windows.Forms.RadioButton rbDiv;
        private System.Windows.Forms.RadioButton rbMulti;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
    }
}


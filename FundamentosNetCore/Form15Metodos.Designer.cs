namespace FundamentosNetCore
{
    partial class Form15Metodos
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
            label1 = new Label();
            lblResultado = new Label();
            textBox1 = new TextBox();
            btnDobleValor = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            lbl = new Label();
            label3 = new Label();
            lblRaton = new Label();
            txtSoloNumeros = new TextBox();
            txtSoloLetras = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 84);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(103, 166);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(92, 20);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "lblResultado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(103, 189);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(144, 58);
            btnDobleValor.TabIndex = 3;
            btnDobleValor.Text = "Doble valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(103, 253);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(144, 53);
            btnDobleReferencia.TabIndex = 4;
            btnDobleReferencia.Text = "Doble referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(103, 312);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(144, 47);
            btnObjetoReferencia.TabIndex = 5;
            btnObjetoReferencia.Text = "ObjetoReferencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += button3_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(597, 66);
            lbl.Name = "lbl";
            lbl.Size = new Size(100, 20);
            lbl.TabIndex = 6;
            lbl.Text = "Solo numeros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(597, 136);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 7;
            label3.Text = "Solo letras";
            // 
            // lblRaton
            // 
            lblRaton.BackColor = Color.LimeGreen;
            lblRaton.Location = new Point(358, 199);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(364, 242);
            lblRaton.TabIndex = 8;
            lblRaton.Text = "lblRaton";
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // txtSoloNumeros
            // 
            txtSoloNumeros.Location = new Point(597, 89);
            txtSoloNumeros.Name = "txtSoloNumeros";
            txtSoloNumeros.Size = new Size(125, 27);
            txtSoloNumeros.TabIndex = 9;
            txtSoloNumeros.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // txtSoloLetras
            // 
            txtSoloLetras.Location = new Point(597, 159);
            txtSoloLetras.Name = "txtSoloLetras";
            txtSoloLetras.Size = new Size(125, 27);
            txtSoloLetras.TabIndex = 10;
            txtSoloLetras.KeyPress += txtSoloLetras_KeyPress;
            // 
            // Form15Metodos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSoloLetras);
            Controls.Add(txtSoloNumeros);
            Controls.Add(lblRaton);
            Controls.Add(label3);
            Controls.Add(lbl);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDobleValor);
            Controls.Add(textBox1);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Name = "Form15Metodos";
            Text = "Form15Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResultado;
        private TextBox textBox1;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private Label lbl;
        private Label label3;
        private Label lblRaton;
        private TextBox txtSoloNumeros;
        private TextBox txtSoloLetras;
    }
}
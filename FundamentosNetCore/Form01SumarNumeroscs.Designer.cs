namespace FundamentosNetCore
{
    partial class Form01SumarNumeroscs
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
            txtNumero1 = new TextBox();
            label2 = new Label();
            txtNumero2 = new TextBox();
            btnSumarNumeros = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 59);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero 1";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(228, 82);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(125, 27);
            txtNumero1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 136);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(228, 159);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(125, 27);
            txtNumero2.TabIndex = 3;
            // 
            // btnSumarNumeros
            // 
            btnSumarNumeros.Location = new Point(409, 127);
            btnSumarNumeros.Name = "btnSumarNumeros";
            btnSumarNumeros.Size = new Size(148, 59);
            btnSumarNumeros.TabIndex = 4;
            btnSumarNumeros.Text = "Sumar numeros";
            btnSumarNumeros.UseVisualStyleBackColor = true;
            btnSumarNumeros.Click += btnSumarNumeros_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = SystemColors.ButtonFace;
            lblResultado.ForeColor = SystemColors.Highlight;
            lblResultado.Location = new Point(228, 214);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(92, 20);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "lblResultado";
            // 
            // Form01SumarNumeroscs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnSumarNumeros);
            Controls.Add(txtNumero2);
            Controls.Add(label2);
            Controls.Add(txtNumero1);
            Controls.Add(label1);
            Name = "Form01SumarNumeroscs";
            Text = "Form01SumarNumeroscs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero1;
        private Label label2;
        private TextBox txtNumero2;
        private Button btnSumarNumeros;
        private Label lblResultado;
    }
}
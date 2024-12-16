namespace FundamentosNetCore
{
    partial class Form13ColeccionNumeros
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSuma = new TextBox();
            txtPares = new TextBox();
            txtImpares = new TextBox();
            btnMostrar = new Button();
            btnGenerar = new Button();
            lstNumeros = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 70);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Numeros";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(549, 213);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Suma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(549, 253);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Pares";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(549, 298);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Impares";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(639, 206);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(125, 27);
            txtSuma.TabIndex = 4;
            // 
            // txtPares
            // 
            txtPares.Location = new Point(639, 250);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(125, 27);
            txtPares.TabIndex = 5;
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(639, 291);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(125, 27);
            txtImpares.TabIndex = 6;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(593, 127);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(153, 54);
            btnMostrar.TabIndex = 7;
            btnMostrar.Text = "Mostrar datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(593, 61);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(153, 60);
            btnGenerar.TabIndex = 8;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(61, 93);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(138, 244);
            lstNumeros.TabIndex = 9;
            // 
            // Form13ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstNumeros);
            Controls.Add(btnGenerar);
            Controls.Add(btnMostrar);
            Controls.Add(txtImpares);
            Controls.Add(txtPares);
            Controls.Add(txtSuma);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form13ColeccionNumeros";
            Text = "Form13ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSuma;
        private TextBox txtPares;
        private TextBox txtImpares;
        private Button btnMostrar;
        private Button btnGenerar;
        private ListBox lstNumeros;
    }
}
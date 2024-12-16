namespace FundamentosNetCore
{
    partial class Form07SumarNumerosString
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
            btnSumar = new Button();
            txtNumeros = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 60);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduzca numeros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 190);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "resultado";
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(104, 134);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(125, 34);
            btnSumar.TabIndex = 2;
            btnSumar.Text = "Sumar numeros";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(104, 83);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(125, 27);
            txtNumeros.TabIndex = 3;
            // 
            // Form07SumarNumerosString
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumeros);
            Controls.Add(btnSumar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form07SumarNumerosString";
            Text = "Form07SumarNumerosString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSumar;
        private TextBox txtNumeros;
    }
}
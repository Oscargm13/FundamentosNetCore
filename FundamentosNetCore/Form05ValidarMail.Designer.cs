namespace FundamentosNetCore
{
    partial class Form05ValidarMail
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
            txtMail = new TextBox();
            btnValidar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 135);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduce tu email";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(175, 158);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(262, 27);
            txtMail.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(175, 191);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(262, 41);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.ForeColor = Color.Red;
            lblResultado.Location = new Point(275, 235);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado";
            // 
            // Form05ValidarMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnValidar);
            Controls.Add(txtMail);
            Controls.Add(label1);
            Name = "Form05ValidarMail";
            Text = "Form05ValidarMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMail;
        private Button btnValidar;
        private Label lblResultado;
    }
}
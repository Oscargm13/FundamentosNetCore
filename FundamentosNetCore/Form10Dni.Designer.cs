namespace FundamentosNetCore
{
    partial class Form10Dni
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
            lblCorrecto = new Label();
            txtDni = new TextBox();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 80);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduzca DNI";
            // 
            // lblCorrecto
            // 
            lblCorrecto.AutoSize = true;
            lblCorrecto.Location = new Point(76, 183);
            lblCorrecto.Name = "lblCorrecto";
            lblCorrecto.Size = new Size(96, 20);
            lblCorrecto.TabIndex = 1;
            lblCorrecto.Text = "DNI Correcto";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(76, 103);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 2;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(76, 136);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(94, 29);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Validar DNI";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // Form10Dni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnValidar);
            Controls.Add(txtDni);
            Controls.Add(lblCorrecto);
            Controls.Add(label1);
            Name = "Form10Dni";
            Text = "Form10Dni";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCorrecto;
        private TextBox txtDni;
        private Button btnValidar;
    }
}
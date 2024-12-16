namespace FundamentosNetCore
{
    partial class Form09Isbn
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
            txtISBN = new TextBox();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 71);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduzca ISBN";
            // 
            // lblCorrecto
            // 
            lblCorrecto.AutoSize = true;
            lblCorrecto.Location = new Point(163, 206);
            lblCorrecto.Name = "lblCorrecto";
            lblCorrecto.Size = new Size(102, 20);
            lblCorrecto.TabIndex = 1;
            lblCorrecto.Text = "ISBN Correcto";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(163, 108);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(164, 27);
            txtISBN.TabIndex = 2;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(163, 153);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(164, 36);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Validar ISBN";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // Form09Isbn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnValidar);
            Controls.Add(txtISBN);
            Controls.Add(lblCorrecto);
            Controls.Add(label1);
            Name = "Form09Isbn";
            Text = "Form09Isbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCorrecto;
        private TextBox txtISBN;
        private Button btnValidar;
    }
}
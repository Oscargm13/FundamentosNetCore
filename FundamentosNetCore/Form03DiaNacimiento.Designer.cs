namespace FundamentosNetCore
{
    partial class Form03DiaNacimiento
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblResultado = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnyo = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(609, 96);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 59);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 1;
            label1.Text = "Dia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 119);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 2;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 183);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 3;
            label3.Text = "Año";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(339, 213);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "label4";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(96, 82);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(125, 27);
            txtDia.TabIndex = 5;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(96, 142);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(125, 27);
            txtMes.TabIndex = 6;
            // 
            // txtAnyo
            // 
            txtAnyo.Location = new Point(96, 206);
            txtAnyo.Name = "txtAnyo";
            txtAnyo.Size = new Size(125, 27);
            txtAnyo.TabIndex = 7;
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAnyo);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(lblResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResultado;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnyo;
    }
}
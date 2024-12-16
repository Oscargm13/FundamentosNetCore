namespace FundamentosNetCore
{
    partial class Form08StringBuilder
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
            txtTexto = new RichTextBox();
            btnString = new Button();
            btnStringBuilder = new Button();
            lblTiempo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 51);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 0;
            label1.Text = "Copie el texto para trabajar";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(147, 74);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(442, 255);
            txtTexto.TabIndex = 1;
            txtTexto.Text = "";
            // 
            // btnString
            // 
            btnString.Location = new Point(147, 384);
            btnString.Name = "btnString";
            btnString.Size = new Size(208, 87);
            btnString.TabIndex = 2;
            btnString.Text = "Invertir String";
            btnString.UseVisualStyleBackColor = true;
            btnString.Click += btnString_Click;
            // 
            // btnStringBuilder
            // 
            btnStringBuilder.Location = new Point(393, 384);
            btnStringBuilder.Name = "btnStringBuilder";
            btnStringBuilder.Size = new Size(196, 87);
            btnStringBuilder.TabIndex = 3;
            btnStringBuilder.Text = "Invertir StringBuilder";
            btnStringBuilder.UseVisualStyleBackColor = true;
            btnStringBuilder.Click += btnStringBuilder_Click;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(147, 347);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(77, 20);
            lblTiempo.TabIndex = 4;
            lblTiempo.Text = "lblTiempo";
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(lblTiempo);
            Controls.Add(btnStringBuilder);
            Controls.Add(btnString);
            Controls.Add(txtTexto);
            Controls.Add(label1);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox txtTexto;
        private Button btnString;
        private Button btnStringBuilder;
        private Label lblTiempo;
    }
}
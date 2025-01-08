namespace FundamentosNetCore
{
    partial class Form20TestClases
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
            Clases = new Label();
            lstClases = new ListBox();
            btnPersona = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Clases
            // 
            Clases.AutoSize = true;
            Clases.Location = new Point(93, 43);
            Clases.Name = "Clases";
            Clases.Size = new Size(50, 20);
            Clases.TabIndex = 0;
            Clases.Text = "Clases";
            // 
            // lstClases
            // 
            lstClases.FormattingEnabled = true;
            lstClases.Location = new Point(93, 66);
            lstClases.Name = "lstClases";
            lstClases.Size = new Size(599, 244);
            lstClases.TabIndex = 1;
            // 
            // btnPersona
            // 
            btnPersona.Location = new Point(303, 316);
            btnPersona.Name = "btnPersona";
            btnPersona.Size = new Size(127, 62);
            btnPersona.TabIndex = 2;
            btnPersona.Text = "Persona";
            btnPersona.UseVisualStyleBackColor = true;
            btnPersona.Click += btnPersona_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(510, 316);
            button2.Name = "button2";
            button2.Size = new Size(132, 62);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form20TestClases
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnPersona);
            Controls.Add(lstClases);
            Controls.Add(Clases);
            Name = "Form20TestClases";
            Text = "Form20TestClases";
            Load += Form20TestClases_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Clases;
        private ListBox lstClases;
        private Button btnPersona;
        private Button button1;
        private Button button2;
    }
}
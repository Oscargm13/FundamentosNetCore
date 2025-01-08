namespace FundamentosNetCore
{
    partial class Form21Files
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
            txtNombre = new TextBox();
            btnNuevo = new Button();
            ReadFile = new Button();
            WriteFile = new Button();
            lstNombres = new ListBox();
            txtContenido = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Contenido File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 28);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(578, 28);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombres";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(290, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 4;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(290, 102);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(125, 47);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "Nuevo nombre";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += button1_Click;
            // 
            // ReadFile
            // 
            ReadFile.Location = new Point(290, 170);
            ReadFile.Name = "ReadFile";
            ReadFile.Size = new Size(125, 44);
            ReadFile.TabIndex = 6;
            ReadFile.Text = "ReadFile";
            ReadFile.UseVisualStyleBackColor = true;
            ReadFile.Click += ReadFile_Click;
            // 
            // WriteFile
            // 
            WriteFile.Location = new Point(290, 241);
            WriteFile.Name = "WriteFile";
            WriteFile.Size = new Size(125, 43);
            WriteFile.TabIndex = 7;
            WriteFile.Text = "Write file";
            WriteFile.UseVisualStyleBackColor = true;
            WriteFile.Click += WriteFile_Click;
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(578, 51);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(183, 324);
            lstNombres.TabIndex = 8;
            lstNombres.SelectedIndexChanged += lstNombres_SelectedIndexChanged;
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(12, 55);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(216, 324);
            txtContenido.TabIndex = 9;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContenido);
            Controls.Add(lstNombres);
            Controls.Add(WriteFile);
            Controls.Add(ReadFile);
            Controls.Add(btnNuevo);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private Button btnNuevo;
        private Button ReadFile;
        private Button WriteFile;
        private ListBox lstNombres;
        private TextBox txtContenido;
    }
}
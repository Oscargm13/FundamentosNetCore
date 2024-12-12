namespace FundamentosNetCore
{
    partial class Form04DateTime
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
            chkFormatoFecha = new CheckBox();
            txtFecha = new TextBox();
            groupBox1 = new GroupBox();
            btnIncrementar = new Button();
            label4 = new Label();
            txtIncrementar = new TextBox();
            label3 = new Label();
            txtNuevaFecha = new TextBox();
            rdbDia = new RadioButton();
            rdbMes = new RadioButton();
            rdbAnyo = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 55);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha actual";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 243);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // chkFormatoFecha
            // 
            chkFormatoFecha.AutoSize = true;
            chkFormatoFecha.Location = new Point(102, 111);
            chkFormatoFecha.Name = "chkFormatoFecha";
            chkFormatoFecha.Size = new Size(185, 24);
            chkFormatoFecha.TabIndex = 2;
            chkFormatoFecha.Text = "Cambiar formato fecha";
            chkFormatoFecha.UseVisualStyleBackColor = true;
            chkFormatoFecha.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(102, 78);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(125, 27);
            txtFecha.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbAnyo);
            groupBox1.Controls.Add(rdbMes);
            groupBox1.Controls.Add(rdbDia);
            groupBox1.Controls.Add(btnIncrementar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtIncrementar);
            groupBox1.Location = new Point(102, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 147);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(216, 84);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(94, 29);
            btnIncrementar.TabIndex = 9;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 26);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 8;
            label4.Text = "Incremento";
            // 
            // txtIncrementar
            // 
            txtIncrementar.Location = new Point(216, 49);
            txtIncrementar.Name = "txtIncrementar";
            txtIncrementar.Size = new Size(125, 27);
            txtIncrementar.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 309);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 5;
            label3.Text = "Nueva fecha";
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(102, 332);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(125, 27);
            txtNuevaFecha.TabIndex = 6;
            // 
            // rdbDia
            // 
            rdbDia.AutoSize = true;
            rdbDia.Location = new Point(18, 36);
            rdbDia.Name = "rdbDia";
            rdbDia.Size = new Size(53, 24);
            rdbDia.TabIndex = 10;
            rdbDia.TabStop = true;
            rdbDia.Text = "Dia";
            rdbDia.UseVisualStyleBackColor = true;
            // 
            // rdbMes
            // 
            rdbMes.AutoSize = true;
            rdbMes.Location = new Point(18, 66);
            rdbMes.Name = "rdbMes";
            rdbMes.Size = new Size(57, 24);
            rdbMes.TabIndex = 11;
            rdbMes.TabStop = true;
            rdbMes.Text = "Mes";
            rdbMes.UseVisualStyleBackColor = true;
            // 
            // rdbAnyo
            // 
            rdbAnyo.AutoSize = true;
            rdbAnyo.Location = new Point(18, 96);
            rdbAnyo.Name = "rdbAnyo";
            rdbAnyo.Size = new Size(57, 24);
            rdbAnyo.TabIndex = 12;
            rdbAnyo.TabStop = true;
            rdbAnyo.Text = "Año";
            rdbAnyo.UseVisualStyleBackColor = true;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNuevaFecha);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(txtFecha);
            Controls.Add(chkFormatoFecha);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox chkFormatoFecha;
        private TextBox txtFecha;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtIncrementar;
        private Label label3;
        private TextBox txtNuevaFecha;
        private Button btnIncrementar;
        private RadioButton rdbAnyo;
        private RadioButton rdbMes;
        private RadioButton rdbDia;
    }
}
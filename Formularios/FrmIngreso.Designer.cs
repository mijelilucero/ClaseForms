namespace ClaseForms.Formularios
{
    partial class FrmIngreso
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
            textBoxNumero1 = new TextBox();
            textBoxNumero2 = new TextBox();
            textBoxResultado = new TextBox();
            buttonSumar = new Button();
            comboBoxFacultades = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(178, 104);
            label1.Name = "label1";
            label1.Size = new Size(208, 32);
            label1.TabIndex = 0;
            label1.Text = "Ingrese número 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(178, 175);
            label2.Name = "label2";
            label2.Size = new Size(208, 32);
            label2.TabIndex = 1;
            label2.Text = "Ingrese número 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(178, 244);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 2;
            label3.Text = "Resultado:";
            // 
            // textBoxNumero1
            // 
            textBoxNumero1.Font = new Font("Segoe UI", 14F);
            textBoxNumero1.Location = new Point(419, 94);
            textBoxNumero1.Name = "textBoxNumero1";
            textBoxNumero1.Size = new Size(150, 45);
            textBoxNumero1.TabIndex = 3;
            // 
            // textBoxNumero2
            // 
            textBoxNumero2.Font = new Font("Segoe UI", 14F);
            textBoxNumero2.Location = new Point(419, 162);
            textBoxNumero2.Name = "textBoxNumero2";
            textBoxNumero2.Size = new Size(150, 45);
            textBoxNumero2.TabIndex = 4;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Font = new Font("Segoe UI", 14F);
            textBoxResultado.Location = new Point(419, 231);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(150, 45);
            textBoxResultado.TabIndex = 5;
            // 
            // buttonSumar
            // 
            buttonSumar.Location = new Point(419, 318);
            buttonSumar.Name = "buttonSumar";
            buttonSumar.Size = new Size(150, 52);
            buttonSumar.TabIndex = 6;
            buttonSumar.Text = "Sumar";
            buttonSumar.UseVisualStyleBackColor = true;
            buttonSumar.Click += buttonSumar_Click;
            // 
            // comboBoxFacultades
            // 
            comboBoxFacultades.FormattingEnabled = true;
            comboBoxFacultades.Location = new Point(264, 31);
            comboBoxFacultades.Name = "comboBoxFacultades";
            comboBoxFacultades.Size = new Size(240, 33);
            comboBoxFacultades.TabIndex = 7;
            comboBoxFacultades.SelectedIndexChanged += comboBoxFacultades_SelectedIndexChanged;
            // 
            // FrmIngreso
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxFacultades);
            Controls.Add(buttonSumar);
            Controls.Add(textBoxResultado);
            Controls.Add(textBoxNumero2);
            Controls.Add(textBoxNumero1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmIngreso";
            Text = "FrmIngreso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxNumero1;
        private TextBox textBoxNumero2;
        private TextBox textBoxResultado;
        private Button buttonSumar;
        private ComboBox comboBoxFacultades;
    }
}
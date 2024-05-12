namespace ClaseForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            buttonIngreso = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxUsr = new TextBox();
            textBoxPwd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(294, 39);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(59, 25);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "label1";
            // 
            // buttonIngreso
            // 
            buttonIngreso.Location = new Point(294, 311);
            buttonIngreso.Name = "buttonIngreso";
            buttonIngreso.Size = new Size(182, 54);
            buttonIngreso.TabIndex = 2;
            buttonIngreso.Text = "Ingreso";
            buttonIngreso.UseVisualStyleBackColor = true;
            buttonIngreso.Click += buttonIngreso_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(306, 146);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 216);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // textBoxUsr
            // 
            textBoxUsr.Location = new Point(425, 143);
            textBoxUsr.Name = "textBoxUsr";
            textBoxUsr.Size = new Size(150, 31);
            textBoxUsr.TabIndex = 5;
            // 
            // textBoxPwd
            // 
            textBoxPwd.Location = new Point(425, 213);
            textBoxPwd.Name = "textBoxPwd";
            textBoxPwd.PasswordChar = 'o';
            textBoxPwd.Size = new Size(154, 31);
            textBoxPwd.TabIndex = 6;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPwd);
            Controls.Add(textBoxUsr);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonIngreso);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyApp";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Button buttonIngreso;
        private Label label1;
        private Label label2;
        private TextBox textBoxUsr;
        private TextBox textBoxPwd;
    }
}

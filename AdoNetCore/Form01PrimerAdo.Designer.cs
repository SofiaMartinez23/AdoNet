namespace AdoNetCore
{
    partial class Form01PrimerAdo
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
            label1 = new Label();
            lstApellidos = new ListBox();
            lstColumnas = new ListBox();
            label2 = new Label();
            label3 = new Label();
            lstTipoDato = new ListBox();
            btnConectar = new Button();
            btnDesconectar = new Button();
            btnLeerDatos = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 22);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Apellidos";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.Location = new Point(118, 51);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(106, 139);
            lstApellidos.TabIndex = 2;
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.Location = new Point(275, 51);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(106, 139);
            lstColumnas.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 22);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Columnas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(435, 26);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 5;
            label3.Text = "Tipos Dato";
            // 
            // lstTipoDato
            // 
            lstTipoDato.FormattingEnabled = true;
            lstTipoDato.Location = new Point(435, 51);
            lstTipoDato.Name = "lstTipoDato";
            lstTipoDato.Size = new Size(106, 139);
            lstTipoDato.TabIndex = 6;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(14, 22);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 7;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(14, 51);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(75, 23);
            btnDesconectar.TabIndex = 8;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // btnLeerDatos
            // 
            btnLeerDatos.Location = new Point(14, 82);
            btnLeerDatos.Name = "btnLeerDatos";
            btnLeerDatos.Size = new Size(75, 23);
            btnLeerDatos.TabIndex = 9;
            btnLeerDatos.Text = "Leer Datos";
            btnLeerDatos.UseVisualStyleBackColor = true;
            btnLeerDatos.Click += btnLeerDatos_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(25, 224);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(64, 15);
            lblMensaje.TabIndex = 10;
            lblMensaje.Text = "lblMensaje";
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 259);
            Controls.Add(lblMensaje);
            Controls.Add(btnLeerDatos);
            Controls.Add(btnDesconectar);
            Controls.Add(btnConectar);
            Controls.Add(lstTipoDato);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstColumnas);
            Controls.Add(lstApellidos);
            Controls.Add(label1);
            Name = "Form01PrimerAdo";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstApellidos;
        private ListBox lstColumnas;
        private Label label2;
        private Label label3;
        private ListBox lstTipoDato;
        private Button btnConectar;
        private Button btnDesconectar;
        private Button btnLeerDatos;
        private Label lblMensaje;
    }
}

namespace AdoNetCore
{
    partial class Form12MensajesServidor
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
            txtNumero = new TextBox();
            txtNombre = new TextBox();
            txtLoc = new TextBox();
            btnInsertar = new Button();
            lblMensaje = new Label();
            lstDepartamentos = new ListBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 21);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 71);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 127);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Localidad";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(34, 39);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(71, 23);
            txtNumero.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(34, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtLoc
            // 
            txtLoc.Location = new Point(34, 145);
            txtLoc.Name = "txtLoc";
            txtLoc.Size = new Size(100, 23);
            txtLoc.TabIndex = 5;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(36, 191);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(98, 33);
            btnInsertar.TabIndex = 6;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(36, 271);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(64, 15);
            lblMensaje.TabIndex = 7;
            lblMensaje.Text = "lblMensaje";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(233, 39);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(193, 214);
            lstDepartamentos.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(233, 21);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 9;
            label5.Text = "Departamentos";
            // 
            // Form12MensajesServidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 323);
            Controls.Add(label5);
            Controls.Add(lstDepartamentos);
            Controls.Add(lblMensaje);
            Controls.Add(btnInsertar);
            Controls.Add(txtLoc);
            Controls.Add(txtNombre);
            Controls.Add(txtNumero);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form12MensajesServidor";
            Text = "Form12MensajesServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumero;
        private TextBox txtNombre;
        private TextBox txtLoc;
        private Button btnInsertar;
        private Label lblMensaje;
        private ListBox lstDepartamentos;
        private Label label5;
    }
}
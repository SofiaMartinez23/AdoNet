namespace AdoNetCore
{
    partial class Form13ParametrosSalida
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
            cmbDepartamentos = new ComboBox();
            btnMostrarDatos = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSumaSalarial = new TextBox();
            txtMediaSalarial = new TextBox();
            txtPersona = new TextBox();
            lstEmpleados = new ListBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(16, 49);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(121, 23);
            cmbDepartamentos.TabIndex = 1;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(12, 78);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(125, 32);
            btnMostrarDatos.TabIndex = 2;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 3;
            label1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 151);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 4;
            label2.Text = "Suma salarial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 217);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 5;
            label3.Text = "Media salarial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 280);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 6;
            label4.Text = "Personas";
            // 
            // txtSumaSalarial
            // 
            txtSumaSalarial.Location = new Point(16, 169);
            txtSumaSalarial.Name = "txtSumaSalarial";
            txtSumaSalarial.Size = new Size(100, 23);
            txtSumaSalarial.TabIndex = 7;
            // 
            // txtMediaSalarial
            // 
            txtMediaSalarial.Location = new Point(16, 235);
            txtMediaSalarial.Name = "txtMediaSalarial";
            txtMediaSalarial.Size = new Size(100, 23);
            txtMediaSalarial.TabIndex = 8;
            // 
            // txtPersona
            // 
            txtPersona.Location = new Point(16, 298);
            txtPersona.Name = "txtPersona";
            txtPersona.Size = new Size(100, 23);
            txtPersona.TabIndex = 9;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(180, 49);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(155, 274);
            lstEmpleados.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(180, 31);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 11;
            label5.Text = "Empleados";
            // 
            // Form13ParametrosSalida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 376);
            Controls.Add(label5);
            Controls.Add(lstEmpleados);
            Controls.Add(txtPersona);
            Controls.Add(txtMediaSalarial);
            Controls.Add(txtSumaSalarial);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMostrarDatos);
            Controls.Add(cmbDepartamentos);
            Name = "Form13ParametrosSalida";
            Text = "Form13ParametrosSalida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDepartamentos;
        private Button btnMostrarDatos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSumaSalarial;
        private TextBox txtMediaSalarial;
        private TextBox txtPersona;
        private ListBox lstEmpleados;
        private Label label5;
    }
}
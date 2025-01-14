namespace AdoNetCore
{
    partial class Form02BuscadorEmpleados
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
            txtSalario = new TextBox();
            btnBuscarEmpleados = new Button();
            lstEmpleados = new ListBox();
            label2 = new Label();
            btnOficio = new Button();
            txtOficio = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduzca salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(12, 27);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 1;
            // 
            // btnBuscarEmpleados
            // 
            btnBuscarEmpleados.Location = new Point(12, 56);
            btnBuscarEmpleados.Name = "btnBuscarEmpleados";
            btnBuscarEmpleados.Size = new Size(100, 40);
            btnBuscarEmpleados.TabIndex = 2;
            btnBuscarEmpleados.Text = "Buscar Empleados";
            btnBuscarEmpleados.UseVisualStyleBackColor = true;
            btnBuscarEmpleados.Click += btnBuscarEmpleados_Click;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(12, 138);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(213, 154);
            lstEmpleados.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 120);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Empleados";
            // 
            // btnOficio
            // 
            btnOficio.Location = new Point(160, 56);
            btnOficio.Name = "btnOficio";
            btnOficio.Size = new Size(100, 40);
            btnOficio.TabIndex = 7;
            btnOficio.Text = "Buscar Por Oficio";
            btnOficio.UseVisualStyleBackColor = true;
            btnOficio.Click += btnOficio_Click;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(160, 27);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(100, 23);
            txtOficio.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 9);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 5;
            label3.Text = "Introduzca oficio";
            // 
            // Form02BuscadorEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 321);
            Controls.Add(btnOficio);
            Controls.Add(txtOficio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstEmpleados);
            Controls.Add(btnBuscarEmpleados);
            Controls.Add(txtSalario);
            Controls.Add(label1);
            Name = "Form02BuscadorEmpleados";
            Text = "Form02BuscadorEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSalario;
        private Button btnBuscarEmpleados;
        private ListBox lstEmpleados;
        private Label label2;
        private Button btnOficio;
        private TextBox txtOficio;
        private Label label3;
    }
}
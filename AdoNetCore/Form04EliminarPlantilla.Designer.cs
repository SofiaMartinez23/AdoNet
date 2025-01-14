namespace AdoNetCore
{
    partial class Form04EliminarPlantilla
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
            btnEliminarPlantilla = new Button();
            lstEmpleados = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtIdEmpleado = new TextBox();
            SuspendLayout();
            // 
            // btnEliminarPlantilla
            // 
            btnEliminarPlantilla.Location = new Point(54, 92);
            btnEliminarPlantilla.Name = "btnEliminarPlantilla";
            btnEliminarPlantilla.Size = new Size(100, 43);
            btnEliminarPlantilla.TabIndex = 0;
            btnEliminarPlantilla.Text = "Eliminar Plantilla";
            btnEliminarPlantilla.UseVisualStyleBackColor = true;
            btnEliminarPlantilla.Click += btnEliminarPlantilla_Click;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(234, 63);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(150, 139);
            lstEmpleados.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 45);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "Id Empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 45);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Empleados";
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(54, 63);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(100, 23);
            txtIdEmpleado.TabIndex = 4;
            // 
            // Form04EliminarPlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 271);
            Controls.Add(txtIdEmpleado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstEmpleados);
            Controls.Add(btnEliminarPlantilla);
            Name = "Form04EliminarPlantilla";
            Text = "Form04EliminarPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminarPlantilla;
        private ListBox lstEmpleados;
        private Label label1;
        private Label label2;
        private TextBox txtIdEmpleado;
    }
}
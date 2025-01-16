namespace AdoNetCore
{
    partial class Form10UpdateEmpleadosOficio
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
            lstOficios = new ListBox();
            label2 = new Label();
            lstEmpleados = new ListBox();
            txtIncremento = new TextBox();
            label3 = new Label();
            btnIncrementoSalario = new Button();
            lblSumaSalarial = new Label();
            lblMediaSalarial = new Label();
            lblMaximoSalario = new Label();
            label7 = new Label();
            txtOficio = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Oficios";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.Location = new Point(12, 46);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(144, 124);
            lstOficios.TabIndex = 1;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 22);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(201, 46);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(133, 184);
            lstEmpleados.TabIndex = 3;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(384, 118);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(384, 94);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "Incremento";
            // 
            // btnIncrementoSalario
            // 
            btnIncrementoSalario.Location = new Point(384, 157);
            btnIncrementoSalario.Name = "btnIncrementoSalario";
            btnIncrementoSalario.Size = new Size(100, 44);
            btnIncrementoSalario.TabIndex = 6;
            btnIncrementoSalario.Text = "Incrementar Salario";
            btnIncrementoSalario.UseVisualStyleBackColor = true;
            btnIncrementoSalario.Click += btnIncrementoSalario_Click;
            // 
            // lblSumaSalarial
            // 
            lblSumaSalarial.AutoSize = true;
            lblSumaSalarial.Location = new Point(29, 227);
            lblSumaSalarial.Name = "lblSumaSalarial";
            lblSumaSalarial.Size = new Size(87, 15);
            lblSumaSalarial.TabIndex = 7;
            lblSumaSalarial.Text = "lblSumaSalarial";
            // 
            // lblMediaSalarial
            // 
            lblMediaSalarial.AutoSize = true;
            lblMediaSalarial.Location = new Point(29, 254);
            lblMediaSalarial.Name = "lblMediaSalarial";
            lblMediaSalarial.Size = new Size(90, 15);
            lblMediaSalarial.TabIndex = 8;
            lblMediaSalarial.Text = "lblMediaSalarial";
            // 
            // lblMaximoSalario
            // 
            lblMaximoSalario.AutoSize = true;
            lblMaximoSalario.Location = new Point(29, 283);
            lblMaximoSalario.Name = "lblMaximoSalario";
            lblMaximoSalario.Size = new Size(99, 15);
            lblMaximoSalario.TabIndex = 9;
            lblMaximoSalario.Text = "lblMaximoSalario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(382, 25);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 10;
            label7.Text = "Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(384, 48);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(100, 23);
            txtOficio.TabIndex = 11;
            // 
            // Form10UpdateEmpleadosOficio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 325);
            Controls.Add(txtOficio);
            Controls.Add(label7);
            Controls.Add(lblMaximoSalario);
            Controls.Add(lblMediaSalarial);
            Controls.Add(lblSumaSalarial);
            Controls.Add(btnIncrementoSalario);
            Controls.Add(label3);
            Controls.Add(txtIncremento);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(lstOficios);
            Controls.Add(label1);
            Name = "Form10UpdateEmpleadosOficio";
            Text = "Form10UpdateEmpleadosOficio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstOficios;
        private Label label2;
        private ListBox lstEmpleados;
        private TextBox txtIncremento;
        private Label label3;
        private Button btnIncrementoSalario;
        private Label lblSumaSalarial;
        private Label lblMediaSalarial;
        private Label lblMaximoSalario;
        private Label label7;
        private TextBox txtOficio;
    }
}
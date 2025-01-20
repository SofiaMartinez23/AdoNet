namespace AdoNetCore
{
    partial class Form11UpdatePlantillaProcedures
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
            cmbHospital = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtIncremento = new TextBox();
            btnModificarSalario = new Button();
            label3 = new Label();
            lstPlantilla = new ListBox();
            SuspendLayout();
            // 
            // cmbHospital
            // 
            cmbHospital.FormattingEnabled = true;
            cmbHospital.Location = new Point(49, 67);
            cmbHospital.Name = "cmbHospital";
            cmbHospital.Size = new Size(121, 23);
            cmbHospital.TabIndex = 0;
            cmbHospital.SelectedIndexChanged += cmbHospital_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 42);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Hospitales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 42);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(210, 67);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(121, 23);
            txtIncremento.TabIndex = 3;
            // 
            // btnModificarSalario
            // 
            btnModificarSalario.Location = new Point(128, 116);
            btnModificarSalario.Name = "btnModificarSalario";
            btnModificarSalario.Size = new Size(121, 27);
            btnModificarSalario.TabIndex = 4;
            btnModificarSalario.Text = "Modificar salarios";
            btnModificarSalario.UseVisualStyleBackColor = true;
            btnModificarSalario.Click += btnModificarSalario_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 170);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(50, 200);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(281, 124);
            lstPlantilla.TabIndex = 6;
            // 
            // Form11UpdatePlantillaProcedures
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 389);
            Controls.Add(lstPlantilla);
            Controls.Add(label3);
            Controls.Add(btnModificarSalario);
            Controls.Add(txtIncremento);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbHospital);
            Name = "Form11UpdatePlantillaProcedures";
            Text = "Form11UpdatePlantillaProcedures";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbHospital;
        private Label label1;
        private Label label2;
        private TextBox txtIncremento;
        private Button btnModificarSalario;
        private Label label3;
        private ListBox lstPlantilla;
    }
}
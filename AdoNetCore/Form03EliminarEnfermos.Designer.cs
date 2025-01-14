namespace AdoNetCore
{
    partial class Form03EliminarEnfermos
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
            btnEliminarEnfermo = new Button();
            txtInscripcion = new TextBox();
            label2 = new Label();
            lstEnfermos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Inscripcion";
            // 
            // btnEliminarEnfermo
            // 
            btnEliminarEnfermo.Location = new Point(27, 75);
            btnEliminarEnfermo.Name = "btnEliminarEnfermo";
            btnEliminarEnfermo.Size = new Size(100, 39);
            btnEliminarEnfermo.TabIndex = 1;
            btnEliminarEnfermo.Text = "Eliminar enfermo";
            btnEliminarEnfermo.UseVisualStyleBackColor = true;
            btnEliminarEnfermo.Click += btnEliminarEnfermo_Click;
            // 
            // txtInscripcion
            // 
            txtInscripcion.Location = new Point(27, 46);
            txtInscripcion.Name = "txtInscripcion";
            txtInscripcion.Size = new Size(100, 23);
            txtInscripcion.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 28);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Enfermos";
            // 
            // lstEnfermos
            // 
            lstEnfermos.FormattingEnabled = true;
            lstEnfermos.Location = new Point(177, 46);
            lstEnfermos.Name = "lstEnfermos";
            lstEnfermos.Size = new Size(133, 139);
            lstEnfermos.TabIndex = 4;
            // 
            // Form03EliminarEnfermos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 222);
            Controls.Add(lstEnfermos);
            Controls.Add(label2);
            Controls.Add(txtInscripcion);
            Controls.Add(btnEliminarEnfermo);
            Controls.Add(label1);
            Name = "Form03EliminarEnfermos";
            Text = "Form03EliminarEnfermos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEliminarEnfermo;
        private TextBox txtInscripcion;
        private Label label2;
        private ListBox lstEnfermos;
    }
}
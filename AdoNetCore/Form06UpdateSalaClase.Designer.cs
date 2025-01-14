namespace AdoNetCore
{
    partial class Form06UpdateSalaClase
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
            txtSala = new TextBox();
            btnModificarSala = new Button();
            label2 = new Label();
            label1 = new Label();
            lstSalas = new ListBox();
            SuspendLayout();
            // 
            // txtSala
            // 
            txtSala.Location = new Point(194, 62);
            txtSala.Name = "txtSala";
            txtSala.Size = new Size(100, 23);
            txtSala.TabIndex = 12;
            // 
            // btnModificarSala
            // 
            btnModificarSala.BackColor = SystemColors.ActiveCaption;
            btnModificarSala.Location = new Point(194, 102);
            btnModificarSala.Name = "btnModificarSala";
            btnModificarSala.Size = new Size(100, 29);
            btnModificarSala.TabIndex = 11;
            btnModificarSala.Text = "Modificar Sala";
            btnModificarSala.UseVisualStyleBackColor = false;
            btnModificarSala.Click += btnModificarSala_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 35);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 10;
            label2.Text = "Nueva Sala";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 35);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 9;
            label1.Text = "Salas";
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(17, 62);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(145, 124);
            lstSalas.TabIndex = 8;
            // 
            // Form06UpdateSalaClase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 230);
            Controls.Add(txtSala);
            Controls.Add(btnModificarSala);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstSalas);
            Name = "Form06UpdateSalaClase";
            Text = "Form06UpdateSalaClase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSala;
        private Button btnModificarSala;
        private Label label2;
        private Label label1;
        private ListBox lstSalas;
    }
}
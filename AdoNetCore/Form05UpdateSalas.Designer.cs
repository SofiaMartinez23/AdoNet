namespace AdoNetCore
{
    partial class Form05UpdateSalas
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
            lstSalas = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnModificarSala = new Button();
            txtSala = new TextBox();
            SuspendLayout();
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(25, 61);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(145, 124);
            lstSalas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 1;
            label1.Text = "Salas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 34);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Nueva Sala";
            // 
            // btnModificarSala
            // 
            btnModificarSala.Location = new Point(202, 101);
            btnModificarSala.Name = "btnModificarSala";
            btnModificarSala.Size = new Size(100, 29);
            btnModificarSala.TabIndex = 3;
            btnModificarSala.Text = "Modificar Sala";
            btnModificarSala.UseVisualStyleBackColor = true;
            btnModificarSala.Click += btnModificarSala_Click;
            // 
            // txtSala
            // 
            txtSala.Location = new Point(202, 61);
            txtSala.Name = "txtSala";
            txtSala.Size = new Size(100, 23);
            txtSala.TabIndex = 7;
            // 
            // Form05UpdateSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 237);
            Controls.Add(txtSala);
            Controls.Add(btnModificarSala);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstSalas);
            Name = "Form05UpdateSalas";
            Text = "Form05UpdateSalas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSalas;
        private Label label1;
        private Label label2;
        private Button btnModificarSala;
        private TextBox txtSala;
    }
}
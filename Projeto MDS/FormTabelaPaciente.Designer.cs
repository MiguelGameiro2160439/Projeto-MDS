namespace Projeto_MDS
{
    partial class FormTabelaPaciente
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPacientes = new System.Windows.Forms.ListBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pacientes";
            // 
            // listBoxPacientes
            // 
            this.listBoxPacientes.FormattingEnabled = true;
            this.listBoxPacientes.Location = new System.Drawing.Point(12, 25);
            this.listBoxPacientes.Name = "listBoxPacientes";
            this.listBoxPacientes.Size = new System.Drawing.Size(354, 134);
            this.listBoxPacientes.TabIndex = 1;
            this.listBoxPacientes.SelectedIndexChanged += new System.EventHandler(this.listBoxPacientes_SelectedIndexChanged);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(15, 181);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 23);
            this.buttonInserir.TabIndex = 2;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(149, 181);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Alterar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(291, 181);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 4;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // FormTabelaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 231);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.listBoxPacientes);
            this.Controls.Add(this.label1);
            this.Name = "FormTabelaPaciente";
            this.Text = "FormTabelaPaciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPacientes;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonRemover;
    }
}
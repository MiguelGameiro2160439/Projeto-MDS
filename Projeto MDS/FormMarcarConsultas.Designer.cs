namespace Projeto_MDS
{
    partial class FormMarcarConsultas
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxConsultas = new System.Windows.Forms.ListBox();
            this.listBoxMedicoEspecialidade = new System.Windows.Forms.ListBox();
            this.listBoxEspecialidade = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Registar Paciente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBoxConsultas
            // 
            this.listBoxConsultas.FormattingEnabled = true;
            this.listBoxConsultas.Location = new System.Drawing.Point(432, 107);
            this.listBoxConsultas.Name = "listBoxConsultas";
            this.listBoxConsultas.Size = new System.Drawing.Size(200, 173);
            this.listBoxConsultas.TabIndex = 23;
            // 
            // listBoxMedicoEspecialidade
            // 
            this.listBoxMedicoEspecialidade.FormattingEnabled = true;
            this.listBoxMedicoEspecialidade.Location = new System.Drawing.Point(217, 107);
            this.listBoxMedicoEspecialidade.Name = "listBoxMedicoEspecialidade";
            this.listBoxMedicoEspecialidade.Size = new System.Drawing.Size(209, 173);
            this.listBoxMedicoEspecialidade.TabIndex = 22;
            // 
            // listBoxEspecialidade
            // 
            this.listBoxEspecialidade.FormattingEnabled = true;
            this.listBoxEspecialidade.Location = new System.Drawing.Point(16, 107);
            this.listBoxEspecialidade.Name = "listBoxEspecialidade";
            this.listBoxEspecialidade.Size = new System.Drawing.Size(195, 173);
            this.listBoxEspecialidade.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Data e Hora da Consulta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Paciente";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Marcar Consulta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormMarcarConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 342);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxConsultas);
            this.Controls.Add(this.listBoxMedicoEspecialidade);
            this.Controls.Add(this.listBoxEspecialidade);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMarcarConsultas";
            this.Text = "FormMarcarConsultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxConsultas;
        private System.Windows.Forms.ListBox listBoxMedicoEspecialidade;
        private System.Windows.Forms.ListBox listBoxEspecialidade;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}
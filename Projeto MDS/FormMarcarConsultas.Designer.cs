﻿namespace Projeto_MDS
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
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.buttonRegistarPaciente = new System.Windows.Forms.Button();
            this.listBoxConsultas = new System.Windows.Forms.ListBox();
            this.dateTimePickerConsulta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMarcarConsulta = new System.Windows.Forms.Button();
            this.comboBoxMedico = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point(143, 23);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPaciente.TabIndex = 25;
            // 
            // buttonRegistarPaciente
            // 
            this.buttonRegistarPaciente.Location = new System.Drawing.Point(16, 296);
            this.buttonRegistarPaciente.Name = "buttonRegistarPaciente";
            this.buttonRegistarPaciente.Size = new System.Drawing.Size(121, 23);
            this.buttonRegistarPaciente.TabIndex = 24;
            this.buttonRegistarPaciente.Text = "Registar Paciente";
            this.buttonRegistarPaciente.UseVisualStyleBackColor = true;
            this.buttonRegistarPaciente.Click += new System.EventHandler(this.buttonRegistarPaciente_Click);
            // 
            // listBoxConsultas
            // 
            this.listBoxConsultas.FormattingEnabled = true;
            this.listBoxConsultas.Location = new System.Drawing.Point(432, 107);
            this.listBoxConsultas.Name = "listBoxConsultas";
            this.listBoxConsultas.Size = new System.Drawing.Size(200, 173);
            this.listBoxConsultas.TabIndex = 23;
            // 
            // dateTimePickerConsulta
            // 
            this.dateTimePickerConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerConsulta.Location = new System.Drawing.Point(142, 91);
            this.dateTimePickerConsulta.Name = "dateTimePickerConsulta";
            this.dateTimePickerConsulta.Size = new System.Drawing.Size(161, 20);
            this.dateTimePickerConsulta.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
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
            // buttonMarcarConsulta
            // 
            this.buttonMarcarConsulta.Location = new System.Drawing.Point(530, 296);
            this.buttonMarcarConsulta.Name = "buttonMarcarConsulta";
            this.buttonMarcarConsulta.Size = new System.Drawing.Size(102, 23);
            this.buttonMarcarConsulta.TabIndex = 26;
            this.buttonMarcarConsulta.Text = "Marcar Consulta";
            this.buttonMarcarConsulta.UseVisualStyleBackColor = true;
            this.buttonMarcarConsulta.Click += new System.EventHandler(this.buttonMarcarConsulta_Click);
            // 
            // comboBoxMedico
            // 
            this.comboBoxMedico.FormattingEnabled = true;
            this.comboBoxMedico.Location = new System.Drawing.Point(143, 48);
            this.comboBoxMedico.Name = "comboBoxMedico";
            this.comboBoxMedico.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMedico.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Medico";
            // 
            // FormMarcarConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 342);
            this.Controls.Add(this.comboBoxMedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonMarcarConsulta);
            this.Controls.Add(this.comboBoxPaciente);
            this.Controls.Add(this.buttonRegistarPaciente);
            this.Controls.Add(this.listBoxConsultas);
            this.Controls.Add(this.dateTimePickerConsulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMarcarConsultas";
            this.Text = "FormMarcarConsultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPaciente;
        private System.Windows.Forms.Button buttonRegistarPaciente;
        private System.Windows.Forms.ListBox listBoxConsultas;
        private System.Windows.Forms.DateTimePicker dateTimePickerConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMarcarConsulta;
        private System.Windows.Forms.ComboBox comboBoxMedico;
        private System.Windows.Forms.Label label3;
    }
}
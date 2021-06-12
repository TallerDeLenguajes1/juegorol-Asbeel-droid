
using System;

namespace JuegoRol
{
    partial class FrmCrearPersonaje
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblApodo = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApodo = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.dateTimeFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnCrearPersonajeRandom = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBoxCrearPersonaje = new System.Windows.Forms.GroupBox();
            this.groupBoxListaPersonajes = new System.Windows.Forms.GroupBox();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBatalla = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxCrearPersonaje.SuspendLayout();
            this.groupBoxListaPersonajes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(30, 32);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 15);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo";
            // 
            // lblApodo
            // 
            this.lblApodo.AutoSize = true;
            this.lblApodo.Location = new System.Drawing.Point(30, 127);
            this.lblApodo.Name = "lblApodo";
            this.lblApodo.Size = new System.Drawing.Size(43, 15);
            this.lblApodo.TabIndex = 2;
            this.lblApodo.Text = "Apodo";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(30, 172);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(119, 15);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(155, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApodo
            // 
            this.txtApodo.Location = new System.Drawing.Point(155, 119);
            this.txtApodo.Name = "txtApodo";
            this.txtApodo.Size = new System.Drawing.Size(208, 23);
            this.txtApodo.TabIndex = 5;
            // 
            // cboTipo
            // 
            this.cboTipo.Location = new System.Drawing.Point(155, 24);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(208, 23);
            this.cboTipo.TabIndex = 0;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // dateTimeFechaNacimiento
            // 
            this.dateTimeFechaNacimiento.Location = new System.Drawing.Point(155, 164);
            this.dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            this.dateTimeFechaNacimiento.Size = new System.Drawing.Size(208, 23);
            this.dateTimeFechaNacimiento.TabIndex = 6;
            // 
            // btnCrearPersonajeRandom
            // 
            this.btnCrearPersonajeRandom.Location = new System.Drawing.Point(155, 213);
            this.btnCrearPersonajeRandom.Name = "btnCrearPersonajeRandom";
            this.btnCrearPersonajeRandom.Size = new System.Drawing.Size(208, 23);
            this.btnCrearPersonajeRandom.TabIndex = 7;
            this.btnCrearPersonajeRandom.Text = "Crear datos random";
            this.btnCrearPersonajeRandom.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(394, 50);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 24);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(394, 99);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBoxCrearPersonaje
            // 
            this.groupBoxCrearPersonaje.Controls.Add(this.txtNombre);
            this.groupBoxCrearPersonaje.Controls.Add(this.btnLimpiar);
            this.groupBoxCrearPersonaje.Controls.Add(this.lblNombre);
            this.groupBoxCrearPersonaje.Controls.Add(this.btnGuardar);
            this.groupBoxCrearPersonaje.Controls.Add(this.lblTipo);
            this.groupBoxCrearPersonaje.Controls.Add(this.btnCrearPersonajeRandom);
            this.groupBoxCrearPersonaje.Controls.Add(this.lblApodo);
            this.groupBoxCrearPersonaje.Controls.Add(this.dateTimeFechaNacimiento);
            this.groupBoxCrearPersonaje.Controls.Add(this.lblFechaNacimiento);
            this.groupBoxCrearPersonaje.Controls.Add(this.cboTipo);
            this.groupBoxCrearPersonaje.Controls.Add(this.txtApodo);
            this.groupBoxCrearPersonaje.Location = new System.Drawing.Point(36, 23);
            this.groupBoxCrearPersonaje.Name = "groupBoxCrearPersonaje";
            this.groupBoxCrearPersonaje.Size = new System.Drawing.Size(522, 266);
            this.groupBoxCrearPersonaje.TabIndex = 10;
            this.groupBoxCrearPersonaje.TabStop = false;
            this.groupBoxCrearPersonaje.Text = "Crear personaje";
            // 
            // groupBoxListaPersonajes
            // 
            this.groupBoxListaPersonajes.Controls.Add(this.btnLimpiarLista);
            this.groupBoxListaPersonajes.Controls.Add(this.btnBorrar);
            this.groupBoxListaPersonajes.Controls.Add(this.btnEditar);
            this.groupBoxListaPersonajes.Controls.Add(this.btnBatalla);
            this.groupBoxListaPersonajes.Controls.Add(this.listBox1);
            this.groupBoxListaPersonajes.Location = new System.Drawing.Point(36, 306);
            this.groupBoxListaPersonajes.Name = "groupBoxListaPersonajes";
            this.groupBoxListaPersonajes.Size = new System.Drawing.Size(515, 229);
            this.groupBoxListaPersonajes.TabIndex = 11;
            this.groupBoxListaPersonajes.TabStop = false;
            this.groupBoxListaPersonajes.Text = "Lista de personajes";
            this.groupBoxListaPersonajes.Enter += new System.EventHandler(this.groupBoxListaPersonajes_Enter);
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.Location = new System.Drawing.Point(394, 150);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(88, 23);
            this.btnLimpiarLista.TabIndex = 4;
            this.btnLimpiarLista.Text = "Limpiar";
            this.btnLimpiarLista.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(394, 106);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(88, 23);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(394, 60);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnBatalla
            // 
            this.btnBatalla.Location = new System.Drawing.Point(155, 199);
            this.btnBatalla.Name = "btnBatalla";
            this.btnBatalla.Size = new System.Drawing.Size(204, 23);
            this.btnBatalla.TabIndex = 1;
            this.btnBatalla.Text = "Que inicie la batalla!";
            this.btnBatalla.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(26, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(333, 154);
            this.listBox1.TabIndex = 0;
            // 
            // FrmCrearPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 547);
            this.Controls.Add(this.groupBoxListaPersonajes);
            this.Controls.Add(this.groupBoxCrearPersonaje);
            this.Name = "FrmCrearPersonaje";
            this.Text = "FrmCrearPersonaje";
            this.Load += new System.EventHandler(this.FrmCrearPersonaje_Load);
            this.groupBoxCrearPersonaje.ResumeLayout(false);
            this.groupBoxCrearPersonaje.PerformLayout();
            this.groupBoxListaPersonajes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FrmCrearPersonaje_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void groupBoxListaPersonajes_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblApodo;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApodo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.DateTimePicker dateTimeFechaNacimiento;
        private System.Windows.Forms.Button btnCrearPersonajeRandom;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBoxCrearPersonaje;
        private System.Windows.Forms.GroupBox groupBoxListaPersonajes;
        private System.Windows.Forms.Button btnBatalla;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimpiarLista;
    }
}
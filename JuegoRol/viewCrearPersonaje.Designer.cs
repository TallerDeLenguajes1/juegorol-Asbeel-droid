
namespace JuegoRol
{
    partial class viewCrearPersonaje
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
            this.groupBoxListaPersonajes = new System.Windows.Forms.GroupBox();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBatalla = new System.Windows.Forms.Button();
            this.lstPersonajes = new System.Windows.Forms.ListBox();
            this.groupBoxCrearPersonaje = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnCrearPersonajeRandom = new System.Windows.Forms.Button();
            this.lblApodo = new System.Windows.Forms.Label();
            this.dateTimeFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtApodo = new System.Windows.Forms.TextBox();
            this.groupBoxListaPersonajes.SuspendLayout();
            this.groupBoxCrearPersonaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxListaPersonajes
            // 
            this.groupBoxListaPersonajes.Controls.Add(this.btnLimpiarLista);
            this.groupBoxListaPersonajes.Controls.Add(this.btnBorrar);
            this.groupBoxListaPersonajes.Controls.Add(this.btnEditar);
            this.groupBoxListaPersonajes.Controls.Add(this.btnBatalla);
            this.groupBoxListaPersonajes.Controls.Add(this.lstPersonajes);
            this.groupBoxListaPersonajes.Location = new System.Drawing.Point(38, 345);
            this.groupBoxListaPersonajes.Name = "groupBoxListaPersonajes";
            this.groupBoxListaPersonajes.Size = new System.Drawing.Size(515, 260);
            this.groupBoxListaPersonajes.TabIndex = 13;
            this.groupBoxListaPersonajes.TabStop = false;
            this.groupBoxListaPersonajes.Text = "Lista de personajes";
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.Location = new System.Drawing.Point(394, 170);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(88, 26);
            this.btnLimpiarLista.TabIndex = 4;
            this.btnLimpiarLista.Text = "Limpiar";
            this.btnLimpiarLista.UseVisualStyleBackColor = true;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(394, 120);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(88, 26);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(394, 68);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 26);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBatalla
            // 
            this.btnBatalla.Location = new System.Drawing.Point(155, 226);
            this.btnBatalla.Name = "btnBatalla";
            this.btnBatalla.Size = new System.Drawing.Size(204, 26);
            this.btnBatalla.TabIndex = 1;
            this.btnBatalla.Text = "Que inicie la batalla!";
            this.btnBatalla.UseVisualStyleBackColor = true;
            this.btnBatalla.Click += new System.EventHandler(this.btnBatalla_Click);
            // 
            // lstPersonajes
            // 
            this.lstPersonajes.FormattingEnabled = true;
            this.lstPersonajes.ItemHeight = 17;
            this.lstPersonajes.Location = new System.Drawing.Point(26, 44);
            this.lstPersonajes.Name = "lstPersonajes";
            this.lstPersonajes.Size = new System.Drawing.Size(333, 174);
            this.lstPersonajes.TabIndex = 0;
            this.lstPersonajes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPersonajes_MouseDoubleClick);
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
            this.groupBoxCrearPersonaje.Location = new System.Drawing.Point(38, 24);
            this.groupBoxCrearPersonaje.Name = "groupBoxCrearPersonaje";
            this.groupBoxCrearPersonaje.Size = new System.Drawing.Size(522, 301);
            this.groupBoxCrearPersonaje.TabIndex = 12;
            this.groupBoxCrearPersonaje.TabStop = false;
            this.groupBoxCrearPersonaje.Text = "Crear personaje";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(155, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 25);
            this.txtNombre.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(394, 112);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 26);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 88);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(394, 57);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 27);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(30, 36);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(34, 17);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo";
            // 
            // btnCrearPersonajeRandom
            // 
            this.btnCrearPersonajeRandom.Location = new System.Drawing.Point(155, 241);
            this.btnCrearPersonajeRandom.Name = "btnCrearPersonajeRandom";
            this.btnCrearPersonajeRandom.Size = new System.Drawing.Size(208, 26);
            this.btnCrearPersonajeRandom.TabIndex = 7;
            this.btnCrearPersonajeRandom.Text = "Generar personaje random";
            this.btnCrearPersonajeRandom.UseVisualStyleBackColor = true;
            this.btnCrearPersonajeRandom.Click += new System.EventHandler(this.btnCrearPersonajeRandom_Click);
            // 
            // lblApodo
            // 
            this.lblApodo.AutoSize = true;
            this.lblApodo.Location = new System.Drawing.Point(30, 144);
            this.lblApodo.Name = "lblApodo";
            this.lblApodo.Size = new System.Drawing.Size(48, 17);
            this.lblApodo.TabIndex = 2;
            this.lblApodo.Text = "Apodo";
            // 
            // dateTimeFechaNacimiento
            // 
            this.dateTimeFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaNacimiento.Location = new System.Drawing.Point(155, 189);
            this.dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            this.dateTimeFechaNacimiento.Size = new System.Drawing.Size(208, 25);
            this.dateTimeFechaNacimiento.TabIndex = 6;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(30, 195);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(130, 17);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // cboTipo
            // 
            this.cboTipo.Location = new System.Drawing.Point(155, 27);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(208, 25);
            this.cboTipo.TabIndex = 0;
            // 
            // txtApodo
            // 
            this.txtApodo.Location = new System.Drawing.Point(155, 135);
            this.txtApodo.Name = "txtApodo";
            this.txtApodo.Size = new System.Drawing.Size(208, 25);
            this.txtApodo.TabIndex = 5;
            // 
            // viewCrearPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 628);
            this.Controls.Add(this.groupBoxListaPersonajes);
            this.Controls.Add(this.groupBoxCrearPersonaje);
            this.Name = "viewCrearPersonaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewCrearPersonaje";
            this.groupBoxListaPersonajes.ResumeLayout(false);
            this.groupBoxCrearPersonaje.ResumeLayout(false);
            this.groupBoxCrearPersonaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListaPersonajes;
        private System.Windows.Forms.Button btnLimpiarLista;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBatalla;
        private System.Windows.Forms.ListBox lstPersonajes;
        private System.Windows.Forms.GroupBox groupBoxCrearPersonaje;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnCrearPersonajeRandom;
        private System.Windows.Forms.Label lblApodo;
        private System.Windows.Forms.DateTimePicker dateTimeFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtApodo;
    }
}
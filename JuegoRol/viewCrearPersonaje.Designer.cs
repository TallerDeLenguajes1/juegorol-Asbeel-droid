
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
            this.groupBoxListaPersonajes.Controls.Add(this.btnBatalla);
            this.groupBoxListaPersonajes.Controls.Add(this.lstPersonajes);
            this.groupBoxListaPersonajes.Location = new System.Drawing.Point(43, 386);
            this.groupBoxListaPersonajes.Name = "groupBoxListaPersonajes";
            this.groupBoxListaPersonajes.Size = new System.Drawing.Size(589, 291);
            this.groupBoxListaPersonajes.TabIndex = 13;
            this.groupBoxListaPersonajes.TabStop = false;
            this.groupBoxListaPersonajes.Text = "Lista de personajes";
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.Location = new System.Drawing.Point(160, 249);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(101, 29);
            this.btnLimpiarLista.TabIndex = 4;
            this.btnLimpiarLista.Text = "Limpiar";
            this.btnLimpiarLista.UseVisualStyleBackColor = true;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(53, 249);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(101, 29);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBatalla
            // 
            this.btnBatalla.Location = new System.Drawing.Point(333, 249);
            this.btnBatalla.Name = "btnBatalla";
            this.btnBatalla.Size = new System.Drawing.Size(233, 29);
            this.btnBatalla.TabIndex = 1;
            this.btnBatalla.Text = "Que inicie la batalla!";
            this.btnBatalla.UseVisualStyleBackColor = true;
            this.btnBatalla.Click += new System.EventHandler(this.btnBatalla_Click);
            // 
            // lstPersonajes
            // 
            this.lstPersonajes.FormattingEnabled = true;
            this.lstPersonajes.ItemHeight = 19;
            this.lstPersonajes.Location = new System.Drawing.Point(53, 36);
            this.lstPersonajes.Name = "lstPersonajes";
            this.lstPersonajes.Size = new System.Drawing.Size(470, 194);
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
            this.groupBoxCrearPersonaje.Location = new System.Drawing.Point(43, 27);
            this.groupBoxCrearPersonaje.Name = "groupBoxCrearPersonaje";
            this.groupBoxCrearPersonaje.Size = new System.Drawing.Size(597, 336);
            this.groupBoxCrearPersonaje.TabIndex = 12;
            this.groupBoxCrearPersonaje.TabStop = false;
            this.groupBoxCrearPersonaje.Text = "Crear personaje";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(177, 88);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(237, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(450, 125);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 29);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 98);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(450, 64);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 30);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(34, 40);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 19);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo";
            // 
            // btnCrearPersonajeRandom
            // 
            this.btnCrearPersonajeRandom.Location = new System.Drawing.Point(177, 269);
            this.btnCrearPersonajeRandom.Name = "btnCrearPersonajeRandom";
            this.btnCrearPersonajeRandom.Size = new System.Drawing.Size(238, 29);
            this.btnCrearPersonajeRandom.TabIndex = 7;
            this.btnCrearPersonajeRandom.Text = "Generar personaje random";
            this.btnCrearPersonajeRandom.UseVisualStyleBackColor = true;
            this.btnCrearPersonajeRandom.Click += new System.EventHandler(this.btnCrearPersonajeRandom_Click);
            // 
            // lblApodo
            // 
            this.lblApodo.AutoSize = true;
            this.lblApodo.Location = new System.Drawing.Point(34, 161);
            this.lblApodo.Name = "lblApodo";
            this.lblApodo.Size = new System.Drawing.Size(50, 19);
            this.lblApodo.TabIndex = 2;
            this.lblApodo.Text = "Apodo";
            // 
            // dateTimeFechaNacimiento
            // 
            this.dateTimeFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaNacimiento.Location = new System.Drawing.Point(177, 211);
            this.dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            this.dateTimeFechaNacimiento.Size = new System.Drawing.Size(237, 26);
            this.dateTimeFechaNacimiento.TabIndex = 6;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(34, 218);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(136, 19);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // cboTipo
            // 
            this.cboTipo.Location = new System.Drawing.Point(177, 30);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(237, 27);
            this.cboTipo.TabIndex = 0;
            // 
            // txtApodo
            // 
            this.txtApodo.Location = new System.Drawing.Point(177, 151);
            this.txtApodo.Name = "txtApodo";
            this.txtApodo.Size = new System.Drawing.Size(237, 26);
            this.txtApodo.TabIndex = 5;
            // 
            // viewCrearPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 702);
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
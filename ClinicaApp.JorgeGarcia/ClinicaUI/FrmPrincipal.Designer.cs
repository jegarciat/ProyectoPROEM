
namespace ClinicaUI
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.dgvClinica = new System.Windows.Forms.DataGridView();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnConsultasFinalizadas = new System.Windows.Forms.Button();
            this.btnConsultasActivas = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnPacientesEnEspera = new System.Windows.Forms.Button();
            this.btnMedicosLibres = new System.Windows.Forms.Button();
            this.btnMedicosAtendiendo = new System.Windows.Forms.Button();
            this.btnAsignarConsulta = new System.Windows.Forms.Button();
            this.btnFinalizarConsulta = new System.Windows.Forms.Button();
            this.btnIngresarPaciente = new System.Windows.Forms.Button();
            this.lblConteoPacientes = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFinalizarTodas = new System.Windows.Forms.Button();
            this.lblTurno = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClinica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlOpciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClinica
            // 
            this.dgvClinica.AllowUserToAddRows = false;
            this.dgvClinica.AllowUserToDeleteRows = false;
            this.dgvClinica.AllowUserToOrderColumns = true;
            this.dgvClinica.AllowUserToResizeColumns = false;
            this.dgvClinica.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.dgvClinica.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClinica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClinica.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvClinica.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvClinica.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClinica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClinica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClinica.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvClinica.Location = new System.Drawing.Point(161, 91);
            this.dgvClinica.MultiSelect = false;
            this.dgvClinica.Name = "dgvClinica";
            this.dgvClinica.ReadOnly = true;
            this.dgvClinica.RowTemplate.Height = 25;
            this.dgvClinica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClinica.Size = new System.Drawing.Size(792, 306);
            this.dgvClinica.TabIndex = 13;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.DodgerBlue;
            this.picLogo.BackgroundImage = global::ClinicaUI.Properties.Resources.medical_16_icon_icons_com_73921__1_;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Location = new System.Drawing.Point(0, 9);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(155, 69);
            this.picLogo.TabIndex = 15;
            this.picLogo.TabStop = false;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlOpciones.Controls.Add(this.btnEstadisticas);
            this.pnlOpciones.Controls.Add(this.btnConsultasFinalizadas);
            this.pnlOpciones.Controls.Add(this.btnConsultasActivas);
            this.pnlOpciones.Controls.Add(this.btnMedicos);
            this.pnlOpciones.Controls.Add(this.btnPacientesEnEspera);
            this.pnlOpciones.Controls.Add(this.btnMedicosLibres);
            this.pnlOpciones.Controls.Add(this.btnMedicosAtendiendo);
            this.pnlOpciones.Controls.Add(this.picLogo);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(155, 456);
            this.pnlOpciones.TabIndex = 0;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.MintCream;
            this.btnEstadisticas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstadisticas.Location = new System.Drawing.Point(12, 403);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(131, 46);
            this.btnEstadisticas.TabIndex = 23;
            this.btnEstadisticas.Text = "Estadísticas";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnConsultasFinalizadas
            // 
            this.btnConsultasFinalizadas.BackColor = System.Drawing.Color.MintCream;
            this.btnConsultasFinalizadas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultasFinalizadas.Location = new System.Drawing.Point(12, 351);
            this.btnConsultasFinalizadas.Name = "btnConsultasFinalizadas";
            this.btnConsultasFinalizadas.Size = new System.Drawing.Size(131, 46);
            this.btnConsultasFinalizadas.TabIndex = 22;
            this.btnConsultasFinalizadas.Text = "Consultas finalizadas";
            this.btnConsultasFinalizadas.UseVisualStyleBackColor = false;
            this.btnConsultasFinalizadas.Click += new System.EventHandler(this.btnConsultasFinalizadas_Click);
            // 
            // btnConsultasActivas
            // 
            this.btnConsultasActivas.BackColor = System.Drawing.Color.MintCream;
            this.btnConsultasActivas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultasActivas.Location = new System.Drawing.Point(12, 299);
            this.btnConsultasActivas.Name = "btnConsultasActivas";
            this.btnConsultasActivas.Size = new System.Drawing.Size(131, 46);
            this.btnConsultasActivas.TabIndex = 21;
            this.btnConsultasActivas.Text = "Consultas activas";
            this.btnConsultasActivas.UseVisualStyleBackColor = false;
            this.btnConsultasActivas.Click += new System.EventHandler(this.btnConsultasActivas_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.BackColor = System.Drawing.Color.MintCream;
            this.btnMedicos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMedicos.Location = new System.Drawing.Point(12, 91);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(131, 46);
            this.btnMedicos.TabIndex = 19;
            this.btnMedicos.Text = "Lista de médicos";
            this.btnMedicos.UseVisualStyleBackColor = false;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnPacientesEnEspera
            // 
            this.btnPacientesEnEspera.BackColor = System.Drawing.Color.MintCream;
            this.btnPacientesEnEspera.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPacientesEnEspera.Location = new System.Drawing.Point(12, 247);
            this.btnPacientesEnEspera.Name = "btnPacientesEnEspera";
            this.btnPacientesEnEspera.Size = new System.Drawing.Size(131, 46);
            this.btnPacientesEnEspera.TabIndex = 17;
            this.btnPacientesEnEspera.Text = "Lista de espera";
            this.btnPacientesEnEspera.UseVisualStyleBackColor = false;
            this.btnPacientesEnEspera.Click += new System.EventHandler(this.btnPacientesEnEspera_Click);
            // 
            // btnMedicosLibres
            // 
            this.btnMedicosLibres.BackColor = System.Drawing.Color.MintCream;
            this.btnMedicosLibres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMedicosLibres.Location = new System.Drawing.Point(12, 195);
            this.btnMedicosLibres.Name = "btnMedicosLibres";
            this.btnMedicosLibres.Size = new System.Drawing.Size(131, 46);
            this.btnMedicosLibres.TabIndex = 16;
            this.btnMedicosLibres.Text = "Médicos disponibles";
            this.btnMedicosLibres.UseVisualStyleBackColor = false;
            this.btnMedicosLibres.Click += new System.EventHandler(this.btnMedicosLibres_Click);
            // 
            // btnMedicosAtendiendo
            // 
            this.btnMedicosAtendiendo.BackColor = System.Drawing.Color.MintCream;
            this.btnMedicosAtendiendo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMedicosAtendiendo.Location = new System.Drawing.Point(12, 143);
            this.btnMedicosAtendiendo.Name = "btnMedicosAtendiendo";
            this.btnMedicosAtendiendo.Size = new System.Drawing.Size(131, 46);
            this.btnMedicosAtendiendo.TabIndex = 14;
            this.btnMedicosAtendiendo.Text = "Médicos en consulta";
            this.btnMedicosAtendiendo.UseVisualStyleBackColor = false;
            this.btnMedicosAtendiendo.Click += new System.EventHandler(this.btnMedicosAtendiendo_Click);
            // 
            // btnAsignarConsulta
            // 
            this.btnAsignarConsulta.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAsignarConsulta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAsignarConsulta.Location = new System.Drawing.Point(161, 403);
            this.btnAsignarConsulta.Name = "btnAsignarConsulta";
            this.btnAsignarConsulta.Size = new System.Drawing.Size(131, 41);
            this.btnAsignarConsulta.TabIndex = 23;
            this.btnAsignarConsulta.Text = "Asignar consulta";
            this.btnAsignarConsulta.UseVisualStyleBackColor = false;
            this.btnAsignarConsulta.Click += new System.EventHandler(this.btnAsignarConsulta_Click);
            // 
            // btnFinalizarConsulta
            // 
            this.btnFinalizarConsulta.BackColor = System.Drawing.Color.LightCoral;
            this.btnFinalizarConsulta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizarConsulta.Location = new System.Drawing.Point(298, 403);
            this.btnFinalizarConsulta.Name = "btnFinalizarConsulta";
            this.btnFinalizarConsulta.Size = new System.Drawing.Size(131, 41);
            this.btnFinalizarConsulta.TabIndex = 24;
            this.btnFinalizarConsulta.Text = "Finalizar consulta";
            this.btnFinalizarConsulta.UseVisualStyleBackColor = false;
            this.btnFinalizarConsulta.Click += new System.EventHandler(this.btnFinalizarConsulta_Click);
            // 
            // btnIngresarPaciente
            // 
            this.btnIngresarPaciente.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnIngresarPaciente.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresarPaciente.Location = new System.Drawing.Point(822, 403);
            this.btnIngresarPaciente.Name = "btnIngresarPaciente";
            this.btnIngresarPaciente.Size = new System.Drawing.Size(131, 41);
            this.btnIngresarPaciente.TabIndex = 25;
            this.btnIngresarPaciente.Text = "Ingresar paciente";
            this.btnIngresarPaciente.UseVisualStyleBackColor = false;
            this.btnIngresarPaciente.Click += new System.EventHandler(this.btnIngresarPaciente_Click);
            // 
            // lblConteoPacientes
            // 
            this.lblConteoPacientes.AutoSize = true;
            this.lblConteoPacientes.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblConteoPacientes.Location = new System.Drawing.Point(6, 9);
            this.lblConteoPacientes.Name = "lblConteoPacientes";
            this.lblConteoPacientes.Size = new System.Drawing.Size(154, 21);
            this.lblConteoPacientes.TabIndex = 26;
            this.lblConteoPacientes.Text = "Pacientes en espera: ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Azure;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(475, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(81, 32);
            this.lblTitulo.TabIndex = 27;
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFinalizarTodas
            // 
            this.btnFinalizarTodas.BackColor = System.Drawing.Color.Khaki;
            this.btnFinalizarTodas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizarTodas.Location = new System.Drawing.Point(435, 403);
            this.btnFinalizarTodas.Name = "btnFinalizarTodas";
            this.btnFinalizarTodas.Size = new System.Drawing.Size(131, 41);
            this.btnFinalizarTodas.TabIndex = 28;
            this.btnFinalizarTodas.Text = "Finalizar todas las consultas";
            this.btnFinalizarTodas.UseVisualStyleBackColor = false;
            this.btnFinalizarTodas.Click += new System.EventHandler(this.btnFinalizarTodas_Click);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTurno.Location = new System.Drawing.Point(683, 9);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(115, 21);
            this.lblTurno.TabIndex = 29;
            this.lblTurno.Text = "Proximo turno: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lblTurno);
            this.panel1.Controls.Add(this.lblConteoPacientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(155, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 37);
            this.panel1.TabIndex = 30;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(965, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFinalizarTodas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnIngresarPaciente);
            this.Controls.Add(this.btnFinalizarConsulta);
            this.Controls.Add(this.btnAsignarConsulta);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.dgvClinica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinica PROEM";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClinica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlOpciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClinica;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Button btnConsultasFinalizadas;
        private System.Windows.Forms.Button btnConsultasActivas;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnPacientesEnEspera;
        private System.Windows.Forms.Button btnMedicosLibres;
        private System.Windows.Forms.Button btnMedicosAtendiendo;
        private System.Windows.Forms.Button btnAsignarConsulta;
        private System.Windows.Forms.Button btnFinalizarConsulta;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnIngresarPaciente;
        private System.Windows.Forms.Label lblConteoPacientes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFinalizarTodas;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Panel panel1;
    }
}


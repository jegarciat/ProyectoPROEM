
namespace ClinicaUI
{
    partial class FrmEstadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticas));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.picEstadisticas = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rtxInformacion = new System.Windows.Forms.RichTextBox();
            this.lstMedicosOrdenados = new System.Windows.Forms.ListBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEstadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlTitulo.Controls.Add(this.picEstadisticas);
            this.pnlTitulo.Controls.Add(this.pic2);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(520, 68);
            this.pnlTitulo.TabIndex = 0;
            // 
            // picEstadisticas
            // 
            this.picEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.picEstadisticas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picEstadisticas.BackgroundImage")));
            this.picEstadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picEstadisticas.Dock = System.Windows.Forms.DockStyle.Left;
            this.picEstadisticas.Location = new System.Drawing.Point(0, 0);
            this.picEstadisticas.Name = "picEstadisticas";
            this.picEstadisticas.Size = new System.Drawing.Size(100, 68);
            this.picEstadisticas.TabIndex = 2;
            this.picEstadisticas.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.Transparent;
            this.pic2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic2.BackgroundImage")));
            this.pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic2.Location = new System.Drawing.Point(420, 0);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(100, 68);
            this.pic2.TabIndex = 4;
            this.pic2.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(155, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(214, 50);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Estadísticas";
            // 
            // rtxInformacion
            // 
            this.rtxInformacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxInformacion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxInformacion.Location = new System.Drawing.Point(0, 275);
            this.rtxInformacion.Name = "rtxInformacion";
            this.rtxInformacion.ReadOnly = true;
            this.rtxInformacion.Size = new System.Drawing.Size(520, 269);
            this.rtxInformacion.TabIndex = 1;
            this.rtxInformacion.Text = "";
            // 
            // lstMedicosOrdenados
            // 
            this.lstMedicosOrdenados.FormattingEnabled = true;
            this.lstMedicosOrdenados.ItemHeight = 20;
            this.lstMedicosOrdenados.Location = new System.Drawing.Point(15, 111);
            this.lstMedicosOrdenados.Name = "lstMedicosOrdenados";
            this.lstMedicosOrdenados.Size = new System.Drawing.Size(493, 144);
            this.lstMedicosOrdenados.TabIndex = 2;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(106, 88);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(310, 20);
            this.lblLista.TabIndex = 3;
            this.lblLista.Text = "Médicos ordenados por pacientes atendidos";
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(520, 544);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.lstMedicosOrdenados);
            this.Controls.Add(this.rtxInformacion);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadísticas";
            this.Load += new System.EventHandler(this.FrmEstadisticas_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEstadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox picEstadisticas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RichTextBox rtxInformacion;
        private System.Windows.Forms.ListBox lstMedicosOrdenados;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.PictureBox pic2;
    }
}
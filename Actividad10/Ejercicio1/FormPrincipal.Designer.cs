namespace Ejercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lsbVerSolicitudesImportadas = new System.Windows.Forms.ListBox();
            this.btnImportarSolicitudes = new System.Windows.Forms.Button();
            this.lbSolicitudSeleccionada = new System.Windows.Forms.Label();
            this.btnConfirmarAtencion = new System.Windows.Forms.Button();
            this.lsbColaSolicitudesAAtender = new System.Windows.Forms.ListBox();
            this.btnResolverSolicitud = new System.Windows.Forms.Button();
            this.lsbHistorialResoluciones = new System.Windows.Forms.ListBox();
            this.btnExportarResoluciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lsbVerSolicitudesImportadas
            // 
            this.lsbVerSolicitudesImportadas.FormattingEnabled = true;
            this.lsbVerSolicitudesImportadas.ItemHeight = 22;
            this.lsbVerSolicitudesImportadas.Location = new System.Drawing.Point(13, 170);
            this.lsbVerSolicitudesImportadas.Margin = new System.Windows.Forms.Padding(4);
            this.lsbVerSolicitudesImportadas.Name = "lsbVerSolicitudesImportadas";
            this.lsbVerSolicitudesImportadas.Size = new System.Drawing.Size(305, 356);
            this.lsbVerSolicitudesImportadas.TabIndex = 0;
            this.lsbVerSolicitudesImportadas.SelectedValueChanged += new System.EventHandler(this.lsbVerSolicitudesImportadas_SelectedValueChanged);
            // 
            // btnImportarSolicitudes
            // 
            this.btnImportarSolicitudes.Location = new System.Drawing.Point(13, 46);
            this.btnImportarSolicitudes.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportarSolicitudes.Name = "btnImportarSolicitudes";
            this.btnImportarSolicitudes.Size = new System.Drawing.Size(159, 74);
            this.btnImportarSolicitudes.TabIndex = 1;
            this.btnImportarSolicitudes.Text = "Importar Solicitudes";
            this.btnImportarSolicitudes.UseVisualStyleBackColor = true;
            this.btnImportarSolicitudes.Click += new System.EventHandler(this.btnImportarSolicitudes_Click);
            // 
            // lbSolicitudSeleccionada
            // 
            this.lbSolicitudSeleccionada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbSolicitudSeleccionada.Location = new System.Drawing.Point(339, 218);
            this.lbSolicitudSeleccionada.Name = "lbSolicitudSeleccionada";
            this.lbSolicitudSeleccionada.Size = new System.Drawing.Size(163, 140);
            this.lbSolicitudSeleccionada.TabIndex = 2;
            this.lbSolicitudSeleccionada.Text = "Seleccione desde la lista";
            // 
            // btnConfirmarAtencion
            // 
            this.btnConfirmarAtencion.Location = new System.Drawing.Point(343, 371);
            this.btnConfirmarAtencion.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmarAtencion.Name = "btnConfirmarAtencion";
            this.btnConfirmarAtencion.Size = new System.Drawing.Size(159, 109);
            this.btnConfirmarAtencion.TabIndex = 3;
            this.btnConfirmarAtencion.Text = "Confirmar Selecion hacia coa de atencion";
            this.btnConfirmarAtencion.UseVisualStyleBackColor = true;
            this.btnConfirmarAtencion.Click += new System.EventHandler(this.btnConfirmarAtencion_Click);
            // 
            // lsbColaSolicitudesAAtender
            // 
            this.lsbColaSolicitudesAAtender.FormattingEnabled = true;
            this.lsbColaSolicitudesAAtender.ItemHeight = 22;
            this.lsbColaSolicitudesAAtender.Location = new System.Drawing.Point(526, 170);
            this.lsbColaSolicitudesAAtender.Margin = new System.Windows.Forms.Padding(4);
            this.lsbColaSolicitudesAAtender.Name = "lsbColaSolicitudesAAtender";
            this.lsbColaSolicitudesAAtender.Size = new System.Drawing.Size(250, 356);
            this.lsbColaSolicitudesAAtender.TabIndex = 4;
            // 
            // btnResolverSolicitud
            // 
            this.btnResolverSolicitud.Location = new System.Drawing.Point(802, 371);
            this.btnResolverSolicitud.Margin = new System.Windows.Forms.Padding(4);
            this.btnResolverSolicitud.Name = "btnResolverSolicitud";
            this.btnResolverSolicitud.Size = new System.Drawing.Size(159, 109);
            this.btnResolverSolicitud.TabIndex = 5;
            this.btnResolverSolicitud.Text = "Resolver Solicitud";
            this.btnResolverSolicitud.UseVisualStyleBackColor = true;
            // 
            // lsbHistorialResoluciones
            // 
            this.lsbHistorialResoluciones.FormattingEnabled = true;
            this.lsbHistorialResoluciones.ItemHeight = 22;
            this.lsbHistorialResoluciones.Location = new System.Drawing.Point(986, 170);
            this.lsbHistorialResoluciones.Margin = new System.Windows.Forms.Padding(4);
            this.lsbHistorialResoluciones.Name = "lsbHistorialResoluciones";
            this.lsbHistorialResoluciones.Size = new System.Drawing.Size(281, 356);
            this.lsbHistorialResoluciones.TabIndex = 6;
            // 
            // btnExportarResoluciones
            // 
            this.btnExportarResoluciones.Location = new System.Drawing.Point(1108, 46);
            this.btnExportarResoluciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportarResoluciones.Name = "btnExportarResoluciones";
            this.btnExportarResoluciones.Size = new System.Drawing.Size(159, 74);
            this.btnExportarResoluciones.TabIndex = 7;
            this.btnExportarResoluciones.Text = "Exportar Resoluciones";
            this.btnExportarResoluciones.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 693);
            this.Controls.Add(this.btnExportarResoluciones);
            this.Controls.Add(this.lsbHistorialResoluciones);
            this.Controls.Add(this.btnResolverSolicitud);
            this.Controls.Add(this.lsbColaSolicitudesAAtender);
            this.Controls.Add(this.btnConfirmarAtencion);
            this.Controls.Add(this.lbSolicitudSeleccionada);
            this.Controls.Add(this.btnImportarSolicitudes);
            this.Controls.Add(this.lsbVerSolicitudesImportadas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lsbVerSolicitudesImportadas;
        private System.Windows.Forms.Button btnImportarSolicitudes;
        private System.Windows.Forms.Label lbSolicitudSeleccionada;
        private System.Windows.Forms.Button btnConfirmarAtencion;
        private System.Windows.Forms.ListBox lsbColaSolicitudesAAtender;
        private System.Windows.Forms.Button btnResolverSolicitud;
        private System.Windows.Forms.ListBox lsbHistorialResoluciones;
        private System.Windows.Forms.Button btnExportarResoluciones;
    }
}


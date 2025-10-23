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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lsbColaSolicitudesAAtender = new System.Windows.Forms.ListBox();
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
            this.lsbVerSolicitudesImportadas.Location = new System.Drawing.Point(40, 170);
            this.lsbVerSolicitudesImportadas.Margin = new System.Windows.Forms.Padding(4);
            this.lsbVerSolicitudesImportadas.Name = "lsbVerSolicitudesImportadas";
            this.lsbVerSolicitudesImportadas.Size = new System.Drawing.Size(404, 356);
            this.lsbVerSolicitudesImportadas.TabIndex = 0;
            // 
            // btnImportarSolicitudes
            // 
            this.btnImportarSolicitudes.Location = new System.Drawing.Point(40, 66);
            this.btnImportarSolicitudes.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportarSolicitudes.Name = "btnImportarSolicitudes";
            this.btnImportarSolicitudes.Size = new System.Drawing.Size(159, 54);
            this.btnImportarSolicitudes.TabIndex = 1;
            this.btnImportarSolicitudes.Text = "Importar Solicitudes";
            this.btnImportarSolicitudes.UseVisualStyleBackColor = true;
            this.btnImportarSolicitudes.Click += new System.EventHandler(this.btnImportarSolicitudes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione desde la lista";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 109);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirmar Selecion hacia coa de atencion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lsbColaSolicitudesAAtender
            // 
            this.lsbColaSolicitudesAAtender.FormattingEnabled = true;
            this.lsbColaSolicitudesAAtender.ItemHeight = 22;
            this.lsbColaSolicitudesAAtender.Location = new System.Drawing.Point(730, 170);
            this.lsbColaSolicitudesAAtender.Margin = new System.Windows.Forms.Padding(4);
            this.lsbColaSolicitudesAAtender.Name = "lsbColaSolicitudesAAtender";
            this.lsbColaSolicitudesAAtender.Size = new System.Drawing.Size(404, 356);
            this.lsbColaSolicitudesAAtender.TabIndex = 4;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 647);
            this.Controls.Add(this.lsbColaSolicitudesAAtender);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lsbVerSolicitudesImportadas;
        private System.Windows.Forms.Button btnImportarSolicitudes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lsbColaSolicitudesAAtender;
    }
}


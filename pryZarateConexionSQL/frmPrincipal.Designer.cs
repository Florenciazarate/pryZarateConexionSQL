namespace pryZarateConexionSQL
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.cmbTablas = new System.Windows.Forms.ComboBox();
            this.lblTablaSection = new System.Windows.Forms.Label();
            this.cmbBaseDatos = new System.Windows.Forms.ComboBox();
            this.lblBdSection = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.tbServidor = new System.Windows.Forms.TextBox();
            this.lblServidorSection = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlAcento = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTablaActual = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.pnlSidebar.Controls.Add(this.cmbTablas);
            this.pnlSidebar.Controls.Add(this.lblTablaSection);
            this.pnlSidebar.Controls.Add(this.cmbBaseDatos);
            this.pnlSidebar.Controls.Add(this.lblBdSection);
            this.pnlSidebar.Controls.Add(this.lblEstado);
            this.pnlSidebar.Controls.Add(this.btnConectar);
            this.pnlSidebar.Controls.Add(this.tbServidor);
            this.pnlSidebar.Controls.Add(this.lblServidorSection);
            this.pnlSidebar.Controls.Add(this.lblSubtitulo);
            this.pnlSidebar.Controls.Add(this.lblTitulo);
            this.pnlSidebar.Controls.Add(this.pnlAcento);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(290, 650);
            this.pnlSidebar.TabIndex = 0;
            // 
            // cmbTablas
            // 
            this.cmbTablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.cmbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablas.Enabled = false;
            this.cmbTablas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTablas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTablas.ForeColor = System.Drawing.Color.White;
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(30, 452);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(230, 25);
            this.cmbTablas.TabIndex = 7;
            this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);
            // 
            // lblTablaSection
            // 
            this.lblTablaSection.AutoSize = true;
            this.lblTablaSection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTablaSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.lblTablaSection.Location = new System.Drawing.Point(30, 434);
            this.lblTablaSection.Name = "lblTablaSection";
            this.lblTablaSection.Size = new System.Drawing.Size(43, 15);
            this.lblTablaSection.TabIndex = 6;
            this.lblTablaSection.Text = "TABLA";
            // 
            // cmbBaseDatos
            // 
            this.cmbBaseDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.cmbBaseDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaseDatos.Enabled = false;
            this.cmbBaseDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBaseDatos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBaseDatos.ForeColor = System.Drawing.Color.White;
            this.cmbBaseDatos.FormattingEnabled = true;
            this.cmbBaseDatos.Location = new System.Drawing.Point(30, 392);
            this.cmbBaseDatos.Name = "cmbBaseDatos";
            this.cmbBaseDatos.Size = new System.Drawing.Size(230, 25);
            this.cmbBaseDatos.TabIndex = 5;
            this.cmbBaseDatos.SelectedIndexChanged += new System.EventHandler(this.cmbBaseDatos_SelectedIndexChanged);
            // 
            // lblBdSection
            // 
            this.lblBdSection.AutoSize = true;
            this.lblBdSection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBdSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.lblBdSection.Location = new System.Drawing.Point(30, 374);
            this.lblBdSection.Name = "lblBdSection";
            this.lblBdSection.Size = new System.Drawing.Size(96, 15);
            this.lblBdSection.TabIndex = 4;
            this.lblBdSection.Text = "BASE DE DATOS";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblEstado.Location = new System.Drawing.Point(30, 305);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(106, 17);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "● Desconectado";
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnConectar.ForeColor = System.Drawing.Color.White;
            this.btnConectar.Location = new System.Drawing.Point(30, 260);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(230, 42);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "CONECTAR";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // tbServidor
            // 
            this.tbServidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.tbServidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbServidor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbServidor.ForeColor = System.Drawing.Color.White;
            this.tbServidor.Location = new System.Drawing.Point(30, 229);
            this.tbServidor.Name = "tbServidor";
            this.tbServidor.Size = new System.Drawing.Size(230, 25);
            this.tbServidor.TabIndex = 1;
            this.tbServidor.Text = "localhost\\SQLEXPRESS";
            // 
            // lblServidorSection
            // 
            this.lblServidorSection.AutoSize = true;
            this.lblServidorSection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblServidorSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.lblServidorSection.Location = new System.Drawing.Point(27, 211);
            this.lblServidorSection.Name = "lblServidorSection";
            this.lblServidorSection.Size = new System.Drawing.Size(66, 15);
            this.lblServidorSection.TabIndex = 0;
            this.lblServidorSection.Text = "SERVIDOR";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(30, 110);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(141, 19);
            this.lblSubtitulo.TabIndex = 0;
            this.lblSubtitulo.Text = "SQL Server · WinAuth";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(28, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(214, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Conexión SQL";
            // 
            // pnlAcento
            // 
            this.pnlAcento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.pnlAcento.Location = new System.Drawing.Point(0, 0);
            this.pnlAcento.Name = "pnlAcento";
            this.pnlAcento.Size = new System.Drawing.Size(6, 650);
            this.pnlAcento.TabIndex = 0;
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.pnlContenido.Controls.Add(this.dgvDatos);
            this.pnlContenido.Controls.Add(this.pnlSeparador);
            this.pnlContenido.Controls.Add(this.pnlHeader);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(290, 0);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContenido.Size = new System.Drawing.Size(810, 650);
            this.pnlContenido.TabIndex = 1;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDatos.ColumnHeadersHeight = 40;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.dgvDatos.Location = new System.Drawing.Point(20, 110);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowTemplate.Height = 32;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(770, 520);
            this.dgvDatos.TabIndex = 2;
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparador.Location = new System.Drawing.Point(20, 109);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(770, 1);
            this.pnlSeparador.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTablaActual);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(770, 89);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTablaActual
            // 
            this.lblTablaActual.AutoSize = true;
            this.lblTablaActual.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTablaActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(135)))), ((int)(((byte)(150)))));
            this.lblTablaActual.Location = new System.Drawing.Point(7, 47);
            this.lblTablaActual.Name = "lblTablaActual";
            this.lblTablaActual.Size = new System.Drawing.Size(184, 19);
            this.lblTablaActual.TabIndex = 1;
            this.lblTablaActual.Text = "Conectate para ver los datos";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.lblHeader.Location = new System.Drawing.Point(5, 17);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(206, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Datos de la tabla";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexión SQL Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlAcento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblServidorSection;
        private System.Windows.Forms.TextBox tbServidor;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblBdSection;
        private System.Windows.Forms.ComboBox cmbBaseDatos;
        private System.Windows.Forms.Label lblTablaSection;
        private System.Windows.Forms.ComboBox cmbTablas;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTablaActual;
        private System.Windows.Forms.Panel pnlSeparador;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}

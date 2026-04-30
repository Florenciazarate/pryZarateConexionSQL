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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSidebar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.cmbTablas = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTablaSection = new System.Windows.Forms.Label();
            this.cmbBaseDatos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblBdSection = new System.Windows.Forms.Label();
            this.pnlEstado = new Guna.UI2.WinForms.Guna2Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnConectar = new Guna.UI2.WinForms.Guna2Button();
            this.tbServidor = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblServidorSection = new System.Windows.Forms.Label();
            this.pnlSeparadorSidebar = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlAcento = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlDgvCard = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDatos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlBadge = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBadge = new System.Windows.Forms.Label();
            this.lblTablaActual = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlEstado.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlDgvCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlBadge.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.pnlSidebar.Controls.Add(this.cmbTablas);
            this.pnlSidebar.Controls.Add(this.lblTablaSection);
            this.pnlSidebar.Controls.Add(this.cmbBaseDatos);
            this.pnlSidebar.Controls.Add(this.lblBdSection);
            this.pnlSidebar.Controls.Add(this.pnlEstado);
            this.pnlSidebar.Controls.Add(this.btnConectar);
            this.pnlSidebar.Controls.Add(this.tbServidor);
            this.pnlSidebar.Controls.Add(this.lblServidorSection);
            this.pnlSidebar.Controls.Add(this.pnlSeparadorSidebar);
            this.pnlSidebar.Controls.Add(this.lblSubtitulo);
            this.pnlSidebar.Controls.Add(this.lblTitulo);
            this.pnlSidebar.Controls.Add(this.pnlAcento);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.pnlSidebar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(340, 720);
            this.pnlSidebar.TabIndex = 0;
            // 
            // cmbTablas
            // 
            this.cmbTablas.BackColor = System.Drawing.Color.Transparent;
            this.cmbTablas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.cmbTablas.BorderRadius = 10;
            this.cmbTablas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablas.Enabled = false;
            this.cmbTablas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.cmbTablas.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.cmbTablas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.cmbTablas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTablas.ForeColor = System.Drawing.Color.White;
            this.cmbTablas.ItemHeight = 32;
            this.cmbTablas.Location = new System.Drawing.Point(30, 480);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(280, 38);
            this.cmbTablas.TabIndex = 7;
            this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);
            // 
            // lblTablaSection
            // 
            this.lblTablaSection.AutoSize = true;
            this.lblTablaSection.BackColor = System.Drawing.Color.Transparent;
            this.lblTablaSection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTablaSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.lblTablaSection.Location = new System.Drawing.Point(30, 455);
            this.lblTablaSection.Name = "lblTablaSection";
            this.lblTablaSection.Size = new System.Drawing.Size(62, 15);
            this.lblTablaSection.TabIndex = 6;
            this.lblTablaSection.Text = "📊  TABLA";
            // 
            // cmbBaseDatos
            // 
            this.cmbBaseDatos.BackColor = System.Drawing.Color.Transparent;
            this.cmbBaseDatos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.cmbBaseDatos.BorderRadius = 10;
            this.cmbBaseDatos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBaseDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaseDatos.Enabled = false;
            this.cmbBaseDatos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.cmbBaseDatos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.cmbBaseDatos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.cmbBaseDatos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBaseDatos.ForeColor = System.Drawing.Color.White;
            this.cmbBaseDatos.ItemHeight = 32;
            this.cmbBaseDatos.Location = new System.Drawing.Point(30, 395);
            this.cmbBaseDatos.Name = "cmbBaseDatos";
            this.cmbBaseDatos.Size = new System.Drawing.Size(280, 38);
            this.cmbBaseDatos.TabIndex = 5;
            this.cmbBaseDatos.SelectedIndexChanged += new System.EventHandler(this.cmbBaseDatos_SelectedIndexChanged);
            // 
            // lblBdSection
            // 
            this.lblBdSection.AutoSize = true;
            this.lblBdSection.BackColor = System.Drawing.Color.Transparent;
            this.lblBdSection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBdSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.lblBdSection.Location = new System.Drawing.Point(30, 370);
            this.lblBdSection.Name = "lblBdSection";
            this.lblBdSection.Size = new System.Drawing.Size(115, 15);
            this.lblBdSection.TabIndex = 4;
            this.lblBdSection.Text = "🗄️  BASE DE DATOS";
            // 
            // pnlEstado
            // 
            this.pnlEstado.BackColor = System.Drawing.Color.Transparent;
            this.pnlEstado.BorderRadius = 21;
            this.pnlEstado.Controls.Add(this.lblEstado);
            this.pnlEstado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.pnlEstado.Location = new System.Drawing.Point(30, 660);
            this.pnlEstado.Name = "pnlEstado";
            this.pnlEstado.Size = new System.Drawing.Size(280, 42);
            this.pnlEstado.TabIndex = 3;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblEstado.Location = new System.Drawing.Point(0, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(280, 42);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "● Desconectado";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConectar
            // 
            this.btnConectar.BorderRadius = 12;
            this.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConectar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConectar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnConectar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConectar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnConectar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnConectar.ForeColor = System.Drawing.Color.White;
            this.btnConectar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnConectar.Location = new System.Drawing.Point(30, 290);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(220)))));
            this.btnConectar.Size = new System.Drawing.Size(280, 50);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "CONECTAR";
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // tbServidor
            // 
            this.tbServidor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.tbServidor.BorderRadius = 10;
            this.tbServidor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbServidor.DefaultText = "localhost\\SQLEXPRESS";
            this.tbServidor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbServidor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbServidor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbServidor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbServidor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.tbServidor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.tbServidor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbServidor.ForeColor = System.Drawing.Color.White;
            this.tbServidor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(135)))), ((int)(((byte)(155)))));
            this.tbServidor.Location = new System.Drawing.Point(30, 230);
            this.tbServidor.Name = "tbServidor";
            this.tbServidor.PasswordChar = '\0';
            this.tbServidor.PlaceholderText = "ej: localhost\\SQLEXPRESS";
            this.tbServidor.SelectedText = "";
            this.tbServidor.Size = new System.Drawing.Size(280, 44);
            this.tbServidor.TabIndex = 1;
            // 
            // lblServidorSection
            // 
            this.lblServidorSection.AutoSize = true;
            this.lblServidorSection.BackColor = System.Drawing.Color.Transparent;
            this.lblServidorSection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblServidorSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.lblServidorSection.Location = new System.Drawing.Point(30, 200);
            this.lblServidorSection.Name = "lblServidorSection";
            this.lblServidorSection.Size = new System.Drawing.Size(85, 15);
            this.lblServidorSection.TabIndex = 0;
            this.lblServidorSection.Text = "📡  SERVIDOR";
            // 
            // pnlSeparadorSidebar
            // 
            this.pnlSeparadorSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.pnlSeparadorSidebar.Location = new System.Drawing.Point(30, 165);
            this.pnlSeparadorSidebar.Name = "pnlSeparadorSidebar";
            this.pnlSeparadorSidebar.Size = new System.Drawing.Size(280, 1);
            this.pnlSeparadorSidebar.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(32, 134);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(112, 19);
            this.lblSubtitulo.TabIndex = 0;
            this.lblSubtitulo.Text = "SQL Server · Agu";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(25, 87);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(249, 47);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Conexión SQL";
            // 
            // pnlAcento
            // 
            this.pnlAcento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.pnlAcento.Location = new System.Drawing.Point(0, 0);
            this.pnlAcento.Name = "pnlAcento";
            this.pnlAcento.Size = new System.Drawing.Size(6, 720);
            this.pnlAcento.TabIndex = 0;
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.pnlContenido.Controls.Add(this.pnlDgvCard);
            this.pnlContenido.Controls.Add(this.pnlHeader);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(340, 0);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(30);
            this.pnlContenido.Size = new System.Drawing.Size(860, 720);
            this.pnlContenido.TabIndex = 1;
            // 
            // pnlDgvCard
            // 
            this.pnlDgvCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.pnlDgvCard.BorderRadius = 12;
            this.pnlDgvCard.BorderThickness = 1;
            this.pnlDgvCard.Controls.Add(this.dgvDatos);
            this.pnlDgvCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDgvCard.FillColor = System.Drawing.Color.White;
            this.pnlDgvCard.Location = new System.Drawing.Point(30, 140);
            this.pnlDgvCard.Name = "pnlDgvCard";
            this.pnlDgvCard.Padding = new System.Windows.Forms.Padding(2);
            this.pnlDgvCard.Size = new System.Drawing.Size(800, 550);
            this.pnlDgvCard.TabIndex = 1;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.ColumnHeadersHeight = 44;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dgvDatos.Location = new System.Drawing.Point(2, 2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowTemplate.Height = 36;
            this.dgvDatos.Size = new System.Drawing.Size(796, 546);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvDatos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDatos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDatos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDatos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDatos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dgvDatos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.dgvDatos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDatos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dgvDatos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDatos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDatos.ThemeStyle.HeaderStyle.Height = 44;
            this.dgvDatos.ThemeStyle.ReadOnly = true;
            this.dgvDatos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvDatos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.dgvDatos.ThemeStyle.RowsStyle.Height = 36;
            this.dgvDatos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.dgvDatos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.pnlBadge);
            this.pnlHeader.Controls.Add(this.lblTablaActual);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(30, 30);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 110);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlBadge
            // 
            this.pnlBadge.BorderRadius = 16;
            this.pnlBadge.Controls.Add(this.lblBadge);
            this.pnlBadge.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlBadge.Location = new System.Drawing.Point(640, 30);
            this.pnlBadge.Name = "pnlBadge";
            this.pnlBadge.Size = new System.Drawing.Size(150, 32);
            this.pnlBadge.TabIndex = 2;
            this.pnlBadge.Visible = false;
            // 
            // lblBadge
            // 
            this.lblBadge.BackColor = System.Drawing.Color.Transparent;
            this.lblBadge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBadge.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.lblBadge.Location = new System.Drawing.Point(0, 0);
            this.lblBadge.Name = "lblBadge";
            this.lblBadge.Size = new System.Drawing.Size(150, 32);
            this.lblBadge.TabIndex = 0;
            this.lblBadge.Text = "0 registros";
            this.lblBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTablaActual
            // 
            this.lblTablaActual.AutoSize = true;
            this.lblTablaActual.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTablaActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(135)))), ((int)(((byte)(150)))));
            this.lblTablaActual.Location = new System.Drawing.Point(7, 60);
            this.lblTablaActual.Name = "lblTablaActual";
            this.lblTablaActual.Size = new System.Drawing.Size(266, 20);
            this.lblTablaActual.TabIndex = 1;
            this.lblTablaActual.Text = "Conectate y elegí una tabla del combo";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.lblHeader.Location = new System.Drawing.Point(5, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(219, 41);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Visor de datos";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexión SQL Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlEstado.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlDgvCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBadge.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlSidebar;
        private System.Windows.Forms.Panel pnlAcento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlSeparadorSidebar;
        private System.Windows.Forms.Label lblServidorSection;
        private Guna.UI2.WinForms.Guna2TextBox tbServidor;
        private Guna.UI2.WinForms.Guna2Button btnConectar;
        private Guna.UI2.WinForms.Guna2Panel pnlEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblBdSection;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBaseDatos;
        private System.Windows.Forms.Label lblTablaSection;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTablas;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTablaActual;
        private Guna.UI2.WinForms.Guna2Panel pnlBadge;
        private System.Windows.Forms.Label lblBadge;
        private Guna.UI2.WinForms.Guna2Panel pnlDgvCard;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDatos;
    }
}

namespace MySqlFilm
{
    partial class Form1
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
			this.hopeTabPage1 = new ReaLTaiizor.Controls.HopeTabPage();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.notifyError = new ReaLTaiizor.Controls.HopeNotify();
			this.metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
			this.btnDelete = new ReaLTaiizor.Controls.HopeButton();
			this.btnUpdate = new ReaLTaiizor.Controls.HopeButton();
			this.btnNew = new ReaLTaiizor.Controls.HopeButton();
			this.grpUpdate = new ReaLTaiizor.Controls.HopeGroupBox();
			this.btnSave = new ReaLTaiizor.Controls.HopeButton();
			this.headerLabel6 = new ReaLTaiizor.Controls.HeaderLabel();
			this.headerLabel5 = new ReaLTaiizor.Controls.HeaderLabel();
			this.txtSynopsis = new ReaLTaiizor.Controls.HopeTextBox();
			this.headerLabel4 = new ReaLTaiizor.Controls.HeaderLabel();
			this.headerLabel3 = new ReaLTaiizor.Controls.HeaderLabel();
			this.headerLabel2 = new ReaLTaiizor.Controls.HeaderLabel();
			this.headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
			this.numMins = new ReaLTaiizor.Controls.HopeNumeric();
			this.dateReleaseDate = new ReaLTaiizor.Controls.HopeDatePicker();
			this.numHours = new ReaLTaiizor.Controls.HopeNumeric();
			this.txtName = new ReaLTaiizor.Controls.HopeTextBox();
			this.cmbGenre = new ReaLTaiizor.Controls.HopeComboBox();
			this.dataGridViewFilms = new System.Windows.Forms.DataGridView();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.dataGridViewProtag = new System.Windows.Forms.DataGridView();
			this.hopeTabPage1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.grpUpdate.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).BeginInit();
			this.tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProtag)).BeginInit();
			this.SuspendLayout();
			// 
			// hopeTabPage1
			// 
			this.hopeTabPage1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
			this.hopeTabPage1.Controls.Add(this.tabPage1);
			this.hopeTabPage1.Controls.Add(this.tabPage5);
			this.hopeTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hopeTabPage1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.hopeTabPage1.ForeColorA = System.Drawing.Color.Silver;
			this.hopeTabPage1.ForeColorB = System.Drawing.Color.Gray;
			this.hopeTabPage1.ForeColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.hopeTabPage1.ItemSize = new System.Drawing.Size(120, 40);
			this.hopeTabPage1.Location = new System.Drawing.Point(0, 0);
			this.hopeTabPage1.Name = "hopeTabPage1";
			this.hopeTabPage1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			this.hopeTabPage1.SelectedIndex = 0;
			this.hopeTabPage1.Size = new System.Drawing.Size(800, 624);
			this.hopeTabPage1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.hopeTabPage1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.hopeTabPage1.TabIndex = 0;
			this.hopeTabPage1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.hopeTabPage1.ThemeColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.hopeTabPage1.ThemeColorB = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.hopeTabPage1.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.notifyError);
			this.tabPage1.Controls.Add(this.metroDivider1);
			this.tabPage1.Controls.Add(this.btnDelete);
			this.tabPage1.Controls.Add(this.btnUpdate);
			this.tabPage1.Controls.Add(this.btnNew);
			this.tabPage1.Controls.Add(this.grpUpdate);
			this.tabPage1.Controls.Add(this.dataGridViewFilms);
			this.tabPage1.Location = new System.Drawing.Point(0, 40);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(800, 584);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Film";
			// 
			// notifyError
			// 
			this.notifyError.Close = true;
			this.notifyError.CloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(148)))), ((int)(((byte)(154)))));
			this.notifyError.Cursor = System.Windows.Forms.Cursors.Hand;
			this.notifyError.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
			this.notifyError.ErrorTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
			this.notifyError.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.notifyError.InfoBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
			this.notifyError.InfoTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
			this.notifyError.Location = new System.Drawing.Point(297, 14);
			this.notifyError.Name = "notifyError";
			this.notifyError.Size = new System.Drawing.Size(491, 34);
			this.notifyError.SuccessBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
			this.notifyError.SuccessTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
			this.notifyError.TabIndex = 14;
			this.notifyError.Text = "hopeNotify1";
			this.notifyError.Type = ReaLTaiizor.Controls.HopeNotify.AlertType.Error;
			this.notifyError.Visible = false;
			this.notifyError.WarningBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
			this.notifyError.WarningTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
			// 
			// metroDivider1
			// 
			this.metroDivider1.IsDerivedStyle = true;
			this.metroDivider1.Location = new System.Drawing.Point(6, 209);
			this.metroDivider1.Name = "metroDivider1";
			this.metroDivider1.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
			this.metroDivider1.Size = new System.Drawing.Size(215, 4);
			this.metroDivider1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
			this.metroDivider1.StyleManager = null;
			this.metroDivider1.TabIndex = 8;
			this.metroDivider1.Text = "metroDivider1";
			this.metroDivider1.ThemeAuthor = "Taiizor";
			this.metroDivider1.ThemeName = "MetroLight";
			this.metroDivider1.Thickness = 1;
			// 
			// btnDelete
			// 
			this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
			this.btnDelete.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
			this.btnDelete.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnDelete.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
			this.btnDelete.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
			this.btnDelete.Location = new System.Drawing.Point(6, 315);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.btnDelete.Size = new System.Drawing.Size(215, 40);
			this.btnDelete.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = "Elimina";
			this.btnDelete.TextColor = System.Drawing.Color.White;
			this.btnDelete.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
			this.btnUpdate.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
			this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpdate.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
			this.btnUpdate.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnUpdate.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
			this.btnUpdate.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
			this.btnUpdate.Location = new System.Drawing.Point(6, 267);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.btnUpdate.Size = new System.Drawing.Size(215, 40);
			this.btnUpdate.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
			this.btnUpdate.TabIndex = 5;
			this.btnUpdate.Text = "Modifica";
			this.btnUpdate.TextColor = System.Drawing.Color.White;
			this.btnUpdate.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnNew
			// 
			this.btnNew.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
			this.btnNew.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
			this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNew.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
			this.btnNew.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnNew.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnNew.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
			this.btnNew.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
			this.btnNew.Location = new System.Drawing.Point(6, 219);
			this.btnNew.Name = "btnNew";
			this.btnNew.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.btnNew.Size = new System.Drawing.Size(215, 40);
			this.btnNew.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
			this.btnNew.TabIndex = 1;
			this.btnNew.Text = "Nuovo";
			this.btnNew.TextColor = System.Drawing.Color.White;
			this.btnNew.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
			this.btnNew.Click += new System.EventHandler(this.hopeButton1_Click);
			// 
			// grpUpdate
			// 
			this.grpUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
			this.grpUpdate.Controls.Add(this.btnSave);
			this.grpUpdate.Controls.Add(this.headerLabel6);
			this.grpUpdate.Controls.Add(this.headerLabel5);
			this.grpUpdate.Controls.Add(this.txtSynopsis);
			this.grpUpdate.Controls.Add(this.headerLabel4);
			this.grpUpdate.Controls.Add(this.headerLabel3);
			this.grpUpdate.Controls.Add(this.headerLabel2);
			this.grpUpdate.Controls.Add(this.headerLabel1);
			this.grpUpdate.Controls.Add(this.numMins);
			this.grpUpdate.Controls.Add(this.dateReleaseDate);
			this.grpUpdate.Controls.Add(this.numHours);
			this.grpUpdate.Controls.Add(this.txtName);
			this.grpUpdate.Controls.Add(this.cmbGenre);
			this.grpUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.grpUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
			this.grpUpdate.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
			this.grpUpdate.Location = new System.Drawing.Point(227, 207);
			this.grpUpdate.Name = "grpUpdate";
			this.grpUpdate.ShowText = false;
			this.grpUpdate.Size = new System.Drawing.Size(567, 371);
			this.grpUpdate.TabIndex = 4;
			this.grpUpdate.TabStop = false;
			this.grpUpdate.Text = "hopeGroupBox1";
			this.grpUpdate.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.SystemColors.Control;
			this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
			this.btnSave.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
			this.btnSave.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnSave.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
			this.btnSave.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
			this.btnSave.Location = new System.Drawing.Point(311, 315);
			this.btnSave.Name = "btnSave";
			this.btnSave.PrimaryColor = System.Drawing.Color.White;
			this.btnSave.Size = new System.Drawing.Size(250, 36);
			this.btnSave.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
			this.btnSave.TabIndex = 15;
			this.btnSave.Text = "Salva";
			this.btnSave.TextColor = System.Drawing.Color.Black;
			this.btnSave.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// headerLabel6
			// 
			this.headerLabel6.AutoSize = true;
			this.headerLabel6.BackColor = System.Drawing.Color.Transparent;
			this.headerLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
			this.headerLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.headerLabel6.Location = new System.Drawing.Point(21, 294);
			this.headerLabel6.Name = "headerLabel6";
			this.headerLabel6.Size = new System.Drawing.Size(63, 18);
			this.headerLabel6.TabIndex = 13;
			this.headerLabel6.Text = "Genere";
			// 
			// headerLabel5
			// 
			this.headerLabel5.AutoSize = true;
			this.headerLabel5.BackColor = System.Drawing.Color.Transparent;
			this.headerLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
			this.headerLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.headerLabel5.Location = new System.Drawing.Point(22, 225);
			this.headerLabel5.Name = "headerLabel5";
			this.headerLabel5.Size = new System.Drawing.Size(58, 18);
			this.headerLabel5.TabIndex = 12;
			this.headerLabel5.Text = "Durata";
			// 
			// txtSynopsis
			// 
			this.txtSynopsis.BackColor = System.Drawing.Color.White;
			this.txtSynopsis.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
			this.txtSynopsis.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.txtSynopsis.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
			this.txtSynopsis.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtSynopsis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
			this.txtSynopsis.Hint = "";
			this.txtSynopsis.Location = new System.Drawing.Point(25, 108);
			this.txtSynopsis.MaxLength = 32767;
			this.txtSynopsis.Multiline = true;
			this.txtSynopsis.Name = "txtSynopsis";
			this.txtSynopsis.PasswordChar = '\0';
			this.txtSynopsis.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtSynopsis.SelectedText = "";
			this.txtSynopsis.SelectionLength = 0;
			this.txtSynopsis.SelectionStart = 0;
			this.txtSynopsis.Size = new System.Drawing.Size(265, 102);
			this.txtSynopsis.TabIndex = 11;
			this.txtSynopsis.TabStop = false;
			this.txtSynopsis.UseSystemPasswordChar = false;
			// 
			// headerLabel4
			// 
			this.headerLabel4.AutoSize = true;
			this.headerLabel4.BackColor = System.Drawing.Color.Transparent;
			this.headerLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
			this.headerLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.headerLabel4.Location = new System.Drawing.Point(22, 85);
			this.headerLabel4.Name = "headerLabel4";
			this.headerLabel4.Size = new System.Drawing.Size(56, 18);
			this.headerLabel4.TabIndex = 10;
			this.headerLabel4.Text = "Trama";
			// 
			// headerLabel3
			// 
			this.headerLabel3.AutoSize = true;
			this.headerLabel3.BackColor = System.Drawing.Color.Transparent;
			this.headerLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
			this.headerLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.headerLabel3.Location = new System.Drawing.Point(151, 254);
			this.headerLabel3.Name = "headerLabel3";
			this.headerLabel3.Size = new System.Drawing.Size(13, 18);
			this.headerLabel3.TabIndex = 9;
			this.headerLabel3.Text = ":";
			this.headerLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// headerLabel2
			// 
			this.headerLabel2.AutoSize = true;
			this.headerLabel2.BackColor = System.Drawing.Color.Transparent;
			this.headerLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
			this.headerLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.headerLabel2.Location = new System.Drawing.Point(311, 11);
			this.headerLabel2.Name = "headerLabel2";
			this.headerLabel2.Size = new System.Drawing.Size(111, 18);
			this.headerLabel2.TabIndex = 7;
			this.headerLabel2.Text = "Data di uscita";
			// 
			// headerLabel1
			// 
			this.headerLabel1.AutoSize = true;
			this.headerLabel1.BackColor = System.Drawing.Color.Transparent;
			this.headerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
			this.headerLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.headerLabel1.Location = new System.Drawing.Point(21, 11);
			this.headerLabel1.Name = "headerLabel1";
			this.headerLabel1.Size = new System.Drawing.Size(53, 18);
			this.headerLabel1.TabIndex = 6;
			this.headerLabel1.Text = "Nome";
			// 
			// numMins
			// 
			this.numMins.BackColor = System.Drawing.Color.White;
			this.numMins.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
			this.numMins.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
			this.numMins.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
			this.numMins.BorderHoverColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.numMins.ButtonTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
			this.numMins.ButtonTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
			this.numMins.Cursor = System.Windows.Forms.Cursors.Hand;
			this.numMins.EnterKey = true;
			this.numMins.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.numMins.ForeColor = System.Drawing.Color.Black;
			this.numMins.HoverButtonTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.numMins.HoverButtonTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.numMins.Location = new System.Drawing.Point(169, 246);
			this.numMins.MaxNum = 59F;
			this.numMins.MinNum = 0F;
			this.numMins.Name = "numMins";
			this.numMins.Precision = 0;
			this.numMins.Size = new System.Drawing.Size(120, 32);
			this.numMins.Step = 1F;
			this.numMins.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
			this.numMins.TabIndex = 5;
			this.numMins.Text = "hopeNumeric2";
			this.numMins.ValueNumber = 0F;
			// 
			// dateReleaseDate
			// 
			this.dateReleaseDate.BackColor = System.Drawing.Color.White;
			this.dateReleaseDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
			this.dateReleaseDate.Date = new System.DateTime(2024, 4, 11, 0, 0, 0, 0);
			this.dateReleaseDate.DayNames = "MTWTFSS";
			this.dateReleaseDate.DaysTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
			this.dateReleaseDate.DayTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
			this.dateReleaseDate.DayTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
			this.dateReleaseDate.HeaderFormat = "{0} Y - {1} M";
			this.dateReleaseDate.HeaderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
			this.dateReleaseDate.HeadLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
			this.dateReleaseDate.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
			this.dateReleaseDate.Location = new System.Drawing.Point(311, 32);
			this.dateReleaseDate.Name = "dateReleaseDate";
			this.dateReleaseDate.NMColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
			this.dateReleaseDate.NMHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.dateReleaseDate.NYColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
			this.dateReleaseDate.NYHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.dateReleaseDate.PMColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
			this.dateReleaseDate.PMHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.dateReleaseDate.PYColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
			this.dateReleaseDate.PYHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.dateReleaseDate.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.dateReleaseDate.SelectedTextColor = System.Drawing.Color.White;
			this.dateReleaseDate.Size = new System.Drawing.Size(250, 270);
			this.dateReleaseDate.TabIndex = 4;
			this.dateReleaseDate.Text = "hopeDatePicker1";
			this.dateReleaseDate.ValueTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
			// 
			// numHours
			// 
			this.numHours.BackColor = System.Drawing.Color.White;
			this.numHours.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
			this.numHours.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
			this.numHours.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
			this.numHours.BorderHoverColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.numHours.ButtonTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
			this.numHours.ButtonTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
			this.numHours.Cursor = System.Windows.Forms.Cursors.Hand;
			this.numHours.EnterKey = true;
			this.numHours.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.numHours.ForeColor = System.Drawing.Color.Black;
			this.numHours.HoverButtonTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.numHours.HoverButtonTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.numHours.Location = new System.Drawing.Point(25, 246);
			this.numHours.MaxNum = 999F;
			this.numHours.MinNum = 0F;
			this.numHours.Name = "numHours";
			this.numHours.Precision = 0;
			this.numHours.Size = new System.Drawing.Size(120, 32);
			this.numHours.Step = 1F;
			this.numHours.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
			this.numHours.TabIndex = 1;
			this.numHours.Text = "hopeNumeric1";
			this.numHours.ValueNumber = 0F;
			// 
			// txtName
			// 
			this.txtName.BackColor = System.Drawing.Color.White;
			this.txtName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
			this.txtName.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.txtName.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
			this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
			this.txtName.Hint = "";
			this.txtName.Location = new System.Drawing.Point(24, 32);
			this.txtName.MaxLength = 32767;
			this.txtName.Multiline = false;
			this.txtName.Name = "txtName";
			this.txtName.PasswordChar = '\0';
			this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtName.SelectedText = "";
			this.txtName.SelectionLength = 0;
			this.txtName.SelectionStart = 0;
			this.txtName.Size = new System.Drawing.Size(265, 38);
			this.txtName.TabIndex = 3;
			this.txtName.TabStop = false;
			this.txtName.UseSystemPasswordChar = false;
			// 
			// cmbGenre
			// 
			this.cmbGenre.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbGenre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbGenre.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.cmbGenre.FormattingEnabled = true;
			this.cmbGenre.ItemHeight = 30;
			this.cmbGenre.Location = new System.Drawing.Point(23, 315);
			this.cmbGenre.Name = "cmbGenre";
			this.cmbGenre.Size = new System.Drawing.Size(266, 36);
			this.cmbGenre.TabIndex = 2;
			// 
			// dataGridViewFilms
			// 
			this.dataGridViewFilms.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFilms.Location = new System.Drawing.Point(6, 6);
			this.dataGridViewFilms.MultiSelect = false;
			this.dataGridViewFilms.Name = "dataGridViewFilms";
			this.dataGridViewFilms.ReadOnly = true;
			this.dataGridViewFilms.Size = new System.Drawing.Size(788, 195);
			this.dataGridViewFilms.TabIndex = 0;
			this.dataGridViewFilms.SelectionChanged += new System.EventHandler(this.dataGridViewFilms_SelectionChanged);
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.dataGridViewProtag);
			this.tabPage5.Location = new System.Drawing.Point(0, 40);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(800, 584);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Attori Protag";
			// 
			// dataGridViewProtag
			// 
			this.dataGridViewProtag.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewProtag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProtag.Location = new System.Drawing.Point(6, 6);
			this.dataGridViewProtag.MultiSelect = false;
			this.dataGridViewProtag.Name = "dataGridViewProtag";
			this.dataGridViewProtag.ReadOnly = true;
			this.dataGridViewProtag.Size = new System.Drawing.Size(788, 572);
			this.dataGridViewProtag.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 624);
			this.Controls.Add(this.hopeTabPage1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Film";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.hopeTabPage1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.grpUpdate.ResumeLayout(false);
			this.grpUpdate.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).EndInit();
			this.tabPage5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProtag)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewFilms;
        private ReaLTaiizor.Controls.HopeNumeric numHours;
        private ReaLTaiizor.Controls.HopeTextBox txtName;
        private ReaLTaiizor.Controls.HopeComboBox cmbGenre;
        private ReaLTaiizor.Controls.HopeGroupBox grpUpdate;
        private ReaLTaiizor.Controls.HopeNumeric numMins;
        private ReaLTaiizor.Controls.HopeDatePicker dateReleaseDate;
        private ReaLTaiizor.Controls.HopeButton btnDelete;
        private ReaLTaiizor.Controls.HopeButton btnUpdate;
        private ReaLTaiizor.Controls.HopeButton btnNew;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel2;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
        private ReaLTaiizor.Controls.HopeTextBox txtSynopsis;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel4;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel3;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel5;
        private ReaLTaiizor.Controls.HopeNotify notifyError;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel6;
        private System.Windows.Forms.TabPage tabPage5;
		private ReaLTaiizor.Controls.HopeButton btnSave;
		private System.Windows.Forms.DataGridView dataGridViewProtag;
	}
}
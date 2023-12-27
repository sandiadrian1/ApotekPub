namespace ApotekPub.View
{
    partial class ManufakturAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDataGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridViewDrug = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.panelTitleCrud = new System.Windows.Forms.Panel();
            this.labelTitleCrud = new System.Windows.Forms.Label();
            this.dateTimePickerExpAdm = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelDrugPricesAdmin = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.labelExpiredAdmin = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.labelDrugStockAdmin = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.labelTypeDrugAdmin = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.labelDrugNameAdmin = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.LabelIdAdmin = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.textBoxDrugPricesAdm = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxDrugTypeAdm = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.textBoxDrugNameAdm = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxDrugStockAdm = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxIdAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaBtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBtnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBtnDel = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBtnClear = new Guna.UI2.WinForms.Guna2Button();
            this.labelWarning = new System.Windows.Forms.Label();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrug)).BeginInit();
            this.panelTitleCrud.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDataGrid.Controls.Add(this.dataGridViewDrug);
            this.panelDataGrid.Location = new System.Drawing.Point(327, 63);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(408, 294);
            this.panelDataGrid.TabIndex = 14;
            // 
            // dataGridViewDrug
            // 
            this.dataGridViewDrug.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dataGridViewDrug.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDrug.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDrug.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDrug.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDrug.ColumnHeadersHeight = 30;
            this.dataGridViewDrug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewDrug.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDrug.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDrug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDrug.GridColor = System.Drawing.Color.Black;
            this.dataGridViewDrug.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDrug.Name = "dataGridViewDrug";
            this.dataGridViewDrug.RowHeadersVisible = false;
            this.dataGridViewDrug.Size = new System.Drawing.Size(408, 294);
            this.dataGridViewDrug.TabIndex = 13;
            this.dataGridViewDrug.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dataGridViewDrug.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dataGridViewDrug.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewDrug.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewDrug.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewDrug.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewDrug.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDrug.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dataGridViewDrug.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dataGridViewDrug.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewDrug.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewDrug.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewDrug.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewDrug.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridViewDrug.ThemeStyle.ReadOnly = false;
            this.dataGridViewDrug.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dataGridViewDrug.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewDrug.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewDrug.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewDrug.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewDrug.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dataGridViewDrug.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDrug.Click += new System.EventHandler(this.dataGridViewDrug_Click_1);
            // 
            // panelTitleCrud
            // 
            this.panelTitleCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(78)))));
            this.panelTitleCrud.Controls.Add(this.labelTitleCrud);
            this.panelTitleCrud.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleCrud.Location = new System.Drawing.Point(0, 0);
            this.panelTitleCrud.Name = "panelTitleCrud";
            this.panelTitleCrud.Size = new System.Drawing.Size(735, 52);
            this.panelTitleCrud.TabIndex = 15;
            // 
            // labelTitleCrud
            // 
            this.labelTitleCrud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitleCrud.AutoSize = true;
            this.labelTitleCrud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitleCrud.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleCrud.ForeColor = System.Drawing.Color.Lime;
            this.labelTitleCrud.Location = new System.Drawing.Point(304, 16);
            this.labelTitleCrud.Name = "labelTitleCrud";
            this.labelTitleCrud.Size = new System.Drawing.Size(197, 21);
            this.labelTitleCrud.TabIndex = 0;
            this.labelTitleCrud.Text = "MANUFAKTUR CRUD";
            // 
            // dateTimePickerExpAdm
            // 
            this.dateTimePickerExpAdm.Animated = true;
            this.dateTimePickerExpAdm.BackColor = System.Drawing.Color.Transparent;
            this.dateTimePickerExpAdm.BorderColor = System.Drawing.Color.Gray;
            this.dateTimePickerExpAdm.BorderRadius = 10;
            this.dateTimePickerExpAdm.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.dateTimePickerExpAdm.Checked = true;
            this.dateTimePickerExpAdm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateTimePickerExpAdm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerExpAdm.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerExpAdm.IndicateFocus = true;
            this.dateTimePickerExpAdm.Location = new System.Drawing.Point(111, 312);
            this.dateTimePickerExpAdm.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerExpAdm.MinDate = new System.DateTime(2023, 12, 3, 0, 0, 0, 0);
            this.dateTimePickerExpAdm.Name = "dateTimePickerExpAdm";
            this.dateTimePickerExpAdm.Size = new System.Drawing.Size(185, 36);
            this.dateTimePickerExpAdm.TabIndex = 35;
            this.dateTimePickerExpAdm.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.dateTimePickerExpAdm.Value = new System.DateTime(2023, 12, 3, 0, 0, 0, 0);
            // 
            // labelDrugPricesAdmin
            // 
            this.labelDrugPricesAdmin.BackColor = System.Drawing.Color.Transparent;
            this.labelDrugPricesAdmin.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrugPricesAdmin.Location = new System.Drawing.Point(12, 269);
            this.labelDrugPricesAdmin.Name = "labelDrugPricesAdmin";
            this.labelDrugPricesAdmin.Size = new System.Drawing.Size(84, 16);
            this.labelDrugPricesAdmin.TabIndex = 34;
            this.labelDrugPricesAdmin.Text = " Prices Material";
            // 
            // labelExpiredAdmin
            // 
            this.labelExpiredAdmin.BackColor = System.Drawing.Color.Transparent;
            this.labelExpiredAdmin.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpiredAdmin.Location = new System.Drawing.Point(12, 323);
            this.labelExpiredAdmin.Name = "labelExpiredAdmin";
            this.labelExpiredAdmin.Size = new System.Drawing.Size(46, 16);
            this.labelExpiredAdmin.TabIndex = 33;
            this.labelExpiredAdmin.Text = "Expired";
            // 
            // labelDrugStockAdmin
            // 
            this.labelDrugStockAdmin.BackColor = System.Drawing.Color.Transparent;
            this.labelDrugStockAdmin.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrugStockAdmin.Location = new System.Drawing.Point(12, 222);
            this.labelDrugStockAdmin.Name = "labelDrugStockAdmin";
            this.labelDrugStockAdmin.Size = new System.Drawing.Size(83, 16);
            this.labelDrugStockAdmin.TabIndex = 32;
            this.labelDrugStockAdmin.Text = "Stock Material";
            // 
            // labelTypeDrugAdmin
            // 
            this.labelTypeDrugAdmin.BackColor = System.Drawing.Color.Transparent;
            this.labelTypeDrugAdmin.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeDrugAdmin.Location = new System.Drawing.Point(9, 170);
            this.labelTypeDrugAdmin.Name = "labelTypeDrugAdmin";
            this.labelTypeDrugAdmin.Size = new System.Drawing.Size(64, 16);
            this.labelTypeDrugAdmin.TabIndex = 31;
            this.labelTypeDrugAdmin.Text = "Proses type";
            // 
            // labelDrugNameAdmin
            // 
            this.labelDrugNameAdmin.BackColor = System.Drawing.Color.Transparent;
            this.labelDrugNameAdmin.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrugNameAdmin.Location = new System.Drawing.Point(12, 122);
            this.labelDrugNameAdmin.Name = "labelDrugNameAdmin";
            this.labelDrugNameAdmin.Size = new System.Drawing.Size(81, 16);
            this.labelDrugNameAdmin.TabIndex = 30;
            this.labelDrugNameAdmin.Text = "Material name";
            // 
            // LabelIdAdmin
            // 
            this.LabelIdAdmin.BackColor = System.Drawing.Color.Transparent;
            this.LabelIdAdmin.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIdAdmin.Location = new System.Drawing.Point(12, 70);
            this.LabelIdAdmin.Name = "LabelIdAdmin";
            this.LabelIdAdmin.Size = new System.Drawing.Size(61, 16);
            this.LabelIdAdmin.TabIndex = 29;
            this.LabelIdAdmin.Text = "Id material";
            // 
            // textBoxDrugPricesAdm
            // 
            this.textBoxDrugPricesAdm.BorderRadius = 10;
            this.textBoxDrugPricesAdm.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.textBoxDrugPricesAdm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDrugPricesAdm.DefaultText = "";
            this.textBoxDrugPricesAdm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxDrugPricesAdm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxDrugPricesAdm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDrugPricesAdm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDrugPricesAdm.FillColor = System.Drawing.Color.Gainsboro;
            this.textBoxDrugPricesAdm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDrugPricesAdm.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.textBoxDrugPricesAdm.ForeColor = System.Drawing.Color.Black;
            this.textBoxDrugPricesAdm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDrugPricesAdm.Location = new System.Drawing.Point(111, 262);
            this.textBoxDrugPricesAdm.Name = "textBoxDrugPricesAdm";
            this.textBoxDrugPricesAdm.PasswordChar = '\0';
            this.textBoxDrugPricesAdm.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textBoxDrugPricesAdm.PlaceholderText = "input prices";
            this.textBoxDrugPricesAdm.SelectedText = "";
            this.textBoxDrugPricesAdm.Size = new System.Drawing.Size(185, 28);
            this.textBoxDrugPricesAdm.TabIndex = 28;
            // 
            // comboBoxDrugTypeAdm
            // 
            this.comboBoxDrugTypeAdm.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxDrugTypeAdm.BorderRadius = 10;
            this.comboBoxDrugTypeAdm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDrugTypeAdm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrugTypeAdm.FillColor = System.Drawing.Color.LightGray;
            this.comboBoxDrugTypeAdm.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxDrugTypeAdm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxDrugTypeAdm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxDrugTypeAdm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxDrugTypeAdm.ItemHeight = 30;
            this.comboBoxDrugTypeAdm.Items.AddRange(new object[] {
            "Pencetakan",
            "Pembentukan",
            "Pemesinan",
            "Penggabungan"});
            this.comboBoxDrugTypeAdm.Location = new System.Drawing.Point(111, 160);
            this.comboBoxDrugTypeAdm.Name = "comboBoxDrugTypeAdm";
            this.comboBoxDrugTypeAdm.Size = new System.Drawing.Size(185, 36);
            this.comboBoxDrugTypeAdm.TabIndex = 27;
            // 
            // textBoxDrugNameAdm
            // 
            this.textBoxDrugNameAdm.BorderRadius = 10;
            this.textBoxDrugNameAdm.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.textBoxDrugNameAdm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDrugNameAdm.DefaultText = "";
            this.textBoxDrugNameAdm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxDrugNameAdm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxDrugNameAdm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDrugNameAdm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDrugNameAdm.FillColor = System.Drawing.Color.Gainsboro;
            this.textBoxDrugNameAdm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDrugNameAdm.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.textBoxDrugNameAdm.ForeColor = System.Drawing.Color.Black;
            this.textBoxDrugNameAdm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDrugNameAdm.Location = new System.Drawing.Point(111, 115);
            this.textBoxDrugNameAdm.Name = "textBoxDrugNameAdm";
            this.textBoxDrugNameAdm.PasswordChar = '\0';
            this.textBoxDrugNameAdm.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textBoxDrugNameAdm.PlaceholderText = "Material name";
            this.textBoxDrugNameAdm.SelectedText = "";
            this.textBoxDrugNameAdm.Size = new System.Drawing.Size(185, 28);
            this.textBoxDrugNameAdm.TabIndex = 26;
            // 
            // textBoxDrugStockAdm
            // 
            this.textBoxDrugStockAdm.Animated = true;
            this.textBoxDrugStockAdm.BorderRadius = 10;
            this.textBoxDrugStockAdm.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.textBoxDrugStockAdm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDrugStockAdm.DefaultText = "";
            this.textBoxDrugStockAdm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxDrugStockAdm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxDrugStockAdm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDrugStockAdm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDrugStockAdm.FillColor = System.Drawing.Color.Gainsboro;
            this.textBoxDrugStockAdm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDrugStockAdm.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.textBoxDrugStockAdm.ForeColor = System.Drawing.Color.Black;
            this.textBoxDrugStockAdm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDrugStockAdm.Location = new System.Drawing.Point(111, 215);
            this.textBoxDrugStockAdm.Name = "textBoxDrugStockAdm";
            this.textBoxDrugStockAdm.PasswordChar = '\0';
            this.textBoxDrugStockAdm.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textBoxDrugStockAdm.PlaceholderText = "input stock";
            this.textBoxDrugStockAdm.SelectedText = "";
            this.textBoxDrugStockAdm.Size = new System.Drawing.Size(185, 26);
            this.textBoxDrugStockAdm.TabIndex = 25;
            // 
            // textBoxIdAdmin
            // 
            this.textBoxIdAdmin.BorderRadius = 10;
            this.textBoxIdAdmin.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.textBoxIdAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxIdAdmin.DefaultText = "";
            this.textBoxIdAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxIdAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxIdAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxIdAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxIdAdmin.FillColor = System.Drawing.Color.Gainsboro;
            this.textBoxIdAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxIdAdmin.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.textBoxIdAdmin.ForeColor = System.Drawing.Color.Black;
            this.textBoxIdAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxIdAdmin.Location = new System.Drawing.Point(111, 65);
            this.textBoxIdAdmin.Name = "textBoxIdAdmin";
            this.textBoxIdAdmin.PasswordChar = '\0';
            this.textBoxIdAdmin.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textBoxIdAdmin.PlaceholderText = "Input  id";
            this.textBoxIdAdmin.SelectedText = "";
            this.textBoxIdAdmin.Size = new System.Drawing.Size(185, 28);
            this.textBoxIdAdmin.TabIndex = 24;
            // 
            // gunaBtnAdd
            // 
            this.gunaBtnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gunaBtnAdd.Animated = true;
            this.gunaBtnAdd.BorderColor = System.Drawing.Color.Transparent;
            this.gunaBtnAdd.BorderRadius = 10;
            this.gunaBtnAdd.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.gunaBtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBtnAdd.FillColor = System.Drawing.Color.DimGray;
            this.gunaBtnAdd.Font = new System.Drawing.Font("Cambria", 9F);
            this.gunaBtnAdd.ForeColor = System.Drawing.Color.White;
            this.gunaBtnAdd.Location = new System.Drawing.Point(12, 357);
            this.gunaBtnAdd.Name = "gunaBtnAdd";
            this.gunaBtnAdd.Size = new System.Drawing.Size(81, 27);
            this.gunaBtnAdd.TabIndex = 36;
            this.gunaBtnAdd.Text = "Add Data";
            this.gunaBtnAdd.Click += new System.EventHandler(this.gunaBtnAdd_Click);
            // 
            // gunaBtnUpdate
            // 
            this.gunaBtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gunaBtnUpdate.Animated = true;
            this.gunaBtnUpdate.BorderColor = System.Drawing.Color.Transparent;
            this.gunaBtnUpdate.BorderRadius = 10;
            this.gunaBtnUpdate.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.gunaBtnUpdate.DefaultAutoSize = true;
            this.gunaBtnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBtnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBtnUpdate.FillColor = System.Drawing.Color.DimGray;
            this.gunaBtnUpdate.Font = new System.Drawing.Font("Cambria", 9F);
            this.gunaBtnUpdate.ForeColor = System.Drawing.Color.White;
            this.gunaBtnUpdate.Location = new System.Drawing.Point(111, 357);
            this.gunaBtnUpdate.Name = "gunaBtnUpdate";
            this.gunaBtnUpdate.Size = new System.Drawing.Size(95, 25);
            this.gunaBtnUpdate.TabIndex = 37;
            this.gunaBtnUpdate.Text = "Update Data";
            this.gunaBtnUpdate.Click += new System.EventHandler(this.gunaBtnUpdate_Click);
            // 
            // gunaBtnDel
            // 
            this.gunaBtnDel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gunaBtnDel.Animated = true;
            this.gunaBtnDel.BorderColor = System.Drawing.Color.Transparent;
            this.gunaBtnDel.BorderRadius = 10;
            this.gunaBtnDel.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.gunaBtnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBtnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBtnDel.FillColor = System.Drawing.Color.DimGray;
            this.gunaBtnDel.Font = new System.Drawing.Font("Cambria", 9F);
            this.gunaBtnDel.ForeColor = System.Drawing.Color.White;
            this.gunaBtnDel.Location = new System.Drawing.Point(111, 396);
            this.gunaBtnDel.Name = "gunaBtnDel";
            this.gunaBtnDel.Size = new System.Drawing.Size(95, 25);
            this.gunaBtnDel.TabIndex = 38;
            this.gunaBtnDel.Text = "Delete Data";
            this.gunaBtnDel.Click += new System.EventHandler(this.gunaBtnDel_Click);
            // 
            // gunaBtnClear
            // 
            this.gunaBtnClear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gunaBtnClear.Animated = true;
            this.gunaBtnClear.BorderColor = System.Drawing.Color.Transparent;
            this.gunaBtnClear.BorderRadius = 10;
            this.gunaBtnClear.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.gunaBtnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBtnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBtnClear.FillColor = System.Drawing.Color.DimGray;
            this.gunaBtnClear.Font = new System.Drawing.Font("Cambria", 9F);
            this.gunaBtnClear.ForeColor = System.Drawing.Color.White;
            this.gunaBtnClear.Location = new System.Drawing.Point(12, 397);
            this.gunaBtnClear.Name = "gunaBtnClear";
            this.gunaBtnClear.Size = new System.Drawing.Size(81, 25);
            this.gunaBtnClear.TabIndex = 39;
            this.gunaBtnClear.Text = "Clear Data";
            this.gunaBtnClear.Click += new System.EventHandler(this.gunaBtnClear_Click);
            // 
            // labelWarning
            // 
            this.labelWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWarning.AutoSize = true;
            this.labelWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelWarning.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning.Location = new System.Drawing.Point(395, 396);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(316, 16);
            this.labelWarning.TabIndex = 40;
            this.labelWarning.Text = "Warningg Used Data Cannot Be Deleted !!!!";
            // 
            // MedicineAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 424);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.gunaBtnClear);
            this.Controls.Add(this.gunaBtnDel);
            this.Controls.Add(this.gunaBtnUpdate);
            this.Controls.Add(this.gunaBtnAdd);
            this.Controls.Add(this.dateTimePickerExpAdm);
            this.Controls.Add(this.labelDrugPricesAdmin);
            this.Controls.Add(this.labelExpiredAdmin);
            this.Controls.Add(this.labelDrugStockAdmin);
            this.Controls.Add(this.labelTypeDrugAdmin);
            this.Controls.Add(this.labelDrugNameAdmin);
            this.Controls.Add(this.LabelIdAdmin);
            this.Controls.Add(this.textBoxDrugPricesAdm);
            this.Controls.Add(this.comboBoxDrugTypeAdm);
            this.Controls.Add(this.textBoxDrugNameAdm);
            this.Controls.Add(this.textBoxDrugStockAdm);
            this.Controls.Add(this.textBoxIdAdmin);
            this.Controls.Add(this.panelTitleCrud);
            this.Controls.Add(this.panelDataGrid);
            this.Name = "MedicineAdmin";
            this.Text = "ManufakturAdmin";
            this.Load += new System.EventHandler(this.DrugAdmin_Load);
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrug)).EndInit();
            this.panelTitleCrud.ResumeLayout(false);
            this.panelTitleCrud.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridViewStyler siticoneDataGridViewStyler1;
        private Guna.UI2.WinForms.Guna2Panel panelDataGrid;
        private System.Windows.Forms.Panel panelTitleCrud;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerExpAdm;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelDrugPricesAdmin;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelExpiredAdmin;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelDrugStockAdmin;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelTypeDrugAdmin;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelDrugNameAdmin;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel LabelIdAdmin;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDrugPricesAdm;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboBoxDrugTypeAdm;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDrugNameAdm;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDrugStockAdm;
        private Guna.UI2.WinForms.Guna2TextBox textBoxIdAdmin;
        private Guna.UI2.WinForms.Guna2Button gunaBtnAdd;
        private Guna.UI2.WinForms.Guna2Button gunaBtnUpdate;
        private Guna.UI2.WinForms.Guna2Button gunaBtnDel;
        private Guna.UI2.WinForms.Guna2Button gunaBtnClear;
        private System.Windows.Forms.Label labelTitleCrud;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dataGridViewDrug;
        private System.Windows.Forms.Label labelWarning;
    }
}
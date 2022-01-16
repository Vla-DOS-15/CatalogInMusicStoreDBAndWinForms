namespace WindowsFormsAppStudentHelp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.INSERT = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tb_INSERTRECORDS = new System.Windows.Forms.Button();
            this.tb_Groups = new System.Windows.Forms.TextBox();
            this.tb_Professions = new System.Windows.Forms.TextBox();
            this.tb_PlaceOfBirth = new System.Windows.Forms.TextBox();
            this.DateOfBirth = new System.Windows.Forms.TextBox();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.tb_Performer = new System.Windows.Forms.TextBox();
            this.tb_Genre = new System.Windows.Forms.TextBox();
            this.tb_NumberOfSales = new System.Windows.Forms.TextBox();
            this.tb_DateOfSale = new System.Windows.Forms.TextBox();
            this.tb_AlbumTitle = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.tB_Quantity = new System.Windows.Forms.TextBox();
            this.tB_Price = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Album = new System.Windows.Forms.TextBox();
            this.btn_RecordCompanys = new System.Windows.Forms.Button();
            this.tb_RecordCompanys = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Perfomers = new System.Windows.Forms.Button();
            this.tb_Perfomers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Album = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_NumberOfSalesStore = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_InsertPerfomers = new System.Windows.Forms.Button();
            this.INSERT.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // INSERT
            // 
            this.INSERT.Controls.Add(this.tabPage1);
            this.INSERT.Controls.Add(this.tabPage2);
            this.INSERT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.INSERT.Location = new System.Drawing.Point(0, 0);
            this.INSERT.Name = "INSERT";
            this.INSERT.SelectedIndex = 0;
            this.INSERT.Size = new System.Drawing.Size(820, 503);
            this.INSERT.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_InsertPerfomers);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tb_NumberOfSalesStore);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tb_INSERTRECORDS);
            this.tabPage1.Controls.Add(this.tb_Groups);
            this.tabPage1.Controls.Add(this.tb_Professions);
            this.tabPage1.Controls.Add(this.tb_PlaceOfBirth);
            this.tabPage1.Controls.Add(this.DateOfBirth);
            this.tabPage1.Controls.Add(this.tb_LastName);
            this.tabPage1.Controls.Add(this.tb_FirstName);
            this.tabPage1.Controls.Add(this.tb_Performer);
            this.tabPage1.Controls.Add(this.tb_Genre);
            this.tabPage1.Controls.Add(this.tb_NumberOfSales);
            this.tabPage1.Controls.Add(this.tb_DateOfSale);
            this.tabPage1.Controls.Add(this.tb_AlbumTitle);
            this.tabPage1.Controls.Add(this.btn_insert);
            this.tabPage1.Controls.Add(this.tB_Quantity);
            this.tabPage1.Controls.Add(this.tB_Price);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(812, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "INSERT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tb_INSERTRECORDS
            // 
            this.tb_INSERTRECORDS.Location = new System.Drawing.Point(423, 115);
            this.tb_INSERTRECORDS.Name = "tb_INSERTRECORDS";
            this.tb_INSERTRECORDS.Size = new System.Drawing.Size(124, 23);
            this.tb_INSERTRECORDS.TabIndex = 29;
            this.tb_INSERTRECORDS.Text = "INSERT RECORDS";
            this.tb_INSERTRECORDS.UseVisualStyleBackColor = true;
            this.tb_INSERTRECORDS.Click += new System.EventHandler(this.tb_INSERTRECORDS_Click);
            // 
            // tb_Groups
            // 
            this.tb_Groups.Location = new System.Drawing.Point(552, 417);
            this.tb_Groups.Name = "tb_Groups";
            this.tb_Groups.Size = new System.Drawing.Size(100, 20);
            this.tb_Groups.TabIndex = 27;
            // 
            // tb_Professions
            // 
            this.tb_Professions.Location = new System.Drawing.Point(447, 417);
            this.tb_Professions.Name = "tb_Professions";
            this.tb_Professions.Size = new System.Drawing.Size(100, 20);
            this.tb_Professions.TabIndex = 26;
            // 
            // tb_PlaceOfBirth
            // 
            this.tb_PlaceOfBirth.Location = new System.Drawing.Point(340, 417);
            this.tb_PlaceOfBirth.Name = "tb_PlaceOfBirth";
            this.tb_PlaceOfBirth.Size = new System.Drawing.Size(100, 20);
            this.tb_PlaceOfBirth.TabIndex = 24;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(234, 417);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.DateOfBirth.TabIndex = 23;
            // 
            // tb_LastName
            // 
            this.tb_LastName.Location = new System.Drawing.Point(128, 417);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(100, 20);
            this.tb_LastName.TabIndex = 22;
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Location = new System.Drawing.Point(22, 417);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(100, 20);
            this.tb_FirstName.TabIndex = 21;
            // 
            // tb_Performer
            // 
            this.tb_Performer.Location = new System.Drawing.Point(22, 192);
            this.tb_Performer.Name = "tb_Performer";
            this.tb_Performer.Size = new System.Drawing.Size(100, 20);
            this.tb_Performer.TabIndex = 19;
            // 
            // tb_Genre
            // 
            this.tb_Genre.Location = new System.Drawing.Point(22, 279);
            this.tb_Genre.Name = "tb_Genre";
            this.tb_Genre.Size = new System.Drawing.Size(100, 20);
            this.tb_Genre.TabIndex = 17;
            // 
            // tb_NumberOfSales
            // 
            this.tb_NumberOfSales.Location = new System.Drawing.Point(255, 119);
            this.tb_NumberOfSales.Name = "tb_NumberOfSales";
            this.tb_NumberOfSales.Size = new System.Drawing.Size(149, 20);
            this.tb_NumberOfSales.TabIndex = 15;
            // 
            // tb_DateOfSale
            // 
            this.tb_DateOfSale.Location = new System.Drawing.Point(128, 118);
            this.tb_DateOfSale.Name = "tb_DateOfSale";
            this.tb_DateOfSale.Size = new System.Drawing.Size(117, 20);
            this.tb_DateOfSale.TabIndex = 14;
            // 
            // tb_AlbumTitle
            // 
            this.tb_AlbumTitle.Location = new System.Drawing.Point(25, 119);
            this.tb_AlbumTitle.Name = "tb_AlbumTitle";
            this.tb_AlbumTitle.Size = new System.Drawing.Size(100, 20);
            this.tb_AlbumTitle.TabIndex = 12;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(384, 56);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 10;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // tB_Quantity
            // 
            this.tB_Quantity.Location = new System.Drawing.Point(128, 58);
            this.tB_Quantity.Name = "tB_Quantity";
            this.tB_Quantity.Size = new System.Drawing.Size(108, 20);
            this.tB_Quantity.TabIndex = 6;
            // 
            // tB_Price
            // 
            this.tB_Price.Location = new System.Drawing.Point(22, 58);
            this.tB_Price.Name = "tB_Price";
            this.tB_Price.Size = new System.Drawing.Size(100, 20);
            this.tB_Price.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(812, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Кількість продаж",
            "Кількість альбомів"});
            this.comboBox1.Location = new System.Drawing.Point(670, 385);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tb_Album, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_RecordCompanys, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.tb_RecordCompanys, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.btn_Perfomers, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.tb_Perfomers, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btn_Album, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(624, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.85185F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(192, 362);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, -146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пошук за виконавцем";
            // 
            // tb_Album
            // 
            this.tb_Album.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Album.Location = new System.Drawing.Point(3, 37);
            this.tb_Album.Name = "tb_Album";
            this.tb_Album.Size = new System.Drawing.Size(186, 20);
            this.tb_Album.TabIndex = 9;
            // 
            // btn_RecordCompanys
            // 
            this.btn_RecordCompanys.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_RecordCompanys.Location = new System.Drawing.Point(3, 266);
            this.btn_RecordCompanys.Name = "btn_RecordCompanys";
            this.btn_RecordCompanys.Size = new System.Drawing.Size(186, 31);
            this.btn_RecordCompanys.TabIndex = 7;
            this.btn_RecordCompanys.Text = "ПОШУК";
            this.btn_RecordCompanys.UseVisualStyleBackColor = true;
            this.btn_RecordCompanys.Click += new System.EventHandler(this.btn_RecordCompanys_Click);
            // 
            // tb_RecordCompanys
            // 
            this.tb_RecordCompanys.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_RecordCompanys.Location = new System.Drawing.Point(3, 238);
            this.tb_RecordCompanys.Name = "tb_RecordCompanys";
            this.tb_RecordCompanys.Size = new System.Drawing.Size(186, 20);
            this.tb_RecordCompanys.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пошук за студією звукозапису";
            // 
            // btn_Perfomers
            // 
            this.btn_Perfomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Perfomers.Location = new System.Drawing.Point(3, 165);
            this.btn_Perfomers.Name = "btn_Perfomers";
            this.btn_Perfomers.Size = new System.Drawing.Size(186, 23);
            this.btn_Perfomers.TabIndex = 6;
            this.btn_Perfomers.Text = "ПОШУК";
            this.btn_Perfomers.UseVisualStyleBackColor = true;
            this.btn_Perfomers.Click += new System.EventHandler(this.btn_Perfomers_Click);
            // 
            // tb_Perfomers
            // 
            this.tb_Perfomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_Perfomers.Location = new System.Drawing.Point(3, 140);
            this.tb_Perfomers.Name = "tb_Perfomers";
            this.tb_Perfomers.Size = new System.Drawing.Size(186, 20);
            this.tb_Perfomers.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Пошук за виконавцем";
            // 
            // btn_Album
            // 
            this.btn_Album.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Album.Location = new System.Drawing.Point(3, 63);
            this.btn_Album.Name = "btn_Album";
            this.btn_Album.Size = new System.Drawing.Size(186, 28);
            this.btn_Album.TabIndex = 12;
            this.btn_Album.Text = "ПОШУК";
            this.btn_Album.UseVisualStyleBackColor = true;
            this.btn_Album.Click += new System.EventHandler(this.btn_Album_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Пошук за назвою альбома";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.10526F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.26316F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.53623F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(618, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(612, 192);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 201);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(612, 136);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 343);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(612, 125);
            this.dataGridView3.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ціна";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Кількість в наявності";
            // 
            // tb_NumberOfSalesStore
            // 
            this.tb_NumberOfSalesStore.Location = new System.Drawing.Point(255, 57);
            this.tb_NumberOfSalesStore.Name = "tb_NumberOfSalesStore";
            this.tb_NumberOfSalesStore.Size = new System.Drawing.Size(100, 20);
            this.tb_NumberOfSalesStore.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Кількість продаж";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Назва альбому";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(125, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Дата виходу в продаж";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Кількість проданих альбомів";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Виконавець";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Жанр";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 385);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Ім\'я виконавця";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(137, 385);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Прізвище";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(234, 385);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Дата народження";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(337, 385);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Місце народження";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(444, 385);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 44;
            this.label18.Text = "Професія";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(549, 385);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "Група";
            // 
            // btn_InsertPerfomers
            // 
            this.btn_InsertPerfomers.Location = new System.Drawing.Point(140, 192);
            this.btn_InsertPerfomers.Name = "btn_InsertPerfomers";
            this.btn_InsertPerfomers.Size = new System.Drawing.Size(75, 23);
            this.btn_InsertPerfomers.TabIndex = 46;
            this.btn_InsertPerfomers.UseVisualStyleBackColor = true;
            this.btn_InsertPerfomers.Click += new System.EventHandler(this.btn_InsertPerfomers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 503);
            this.Controls.Add(this.INSERT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.INSERT.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl INSERT;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox tB_Quantity;
        private System.Windows.Forms.TextBox tB_Price;
        private System.Windows.Forms.TextBox tb_Groups;
        private System.Windows.Forms.TextBox tb_Professions;
        private System.Windows.Forms.TextBox tb_PlaceOfBirth;
        private System.Windows.Forms.TextBox DateOfBirth;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.TextBox tb_Performer;
        private System.Windows.Forms.TextBox tb_Genre;
        private System.Windows.Forms.TextBox tb_NumberOfSales;
        private System.Windows.Forms.TextBox tb_DateOfSale;
        private System.Windows.Forms.TextBox tb_AlbumTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tb_Perfomers;
        private System.Windows.Forms.TextBox tb_RecordCompanys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Perfomers;
        private System.Windows.Forms.Button btn_RecordCompanys;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Album;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Album;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tb_INSERTRECORDS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_NumberOfSalesStore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_InsertPerfomers;
    }
}


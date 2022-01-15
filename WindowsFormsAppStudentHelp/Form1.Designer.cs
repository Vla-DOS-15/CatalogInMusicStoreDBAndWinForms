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
            this.tb_Groups = new System.Windows.Forms.TextBox();
            this.tb_Professions = new System.Windows.Forms.TextBox();
            this.tb_YearsOfActivity = new System.Windows.Forms.TextBox();
            this.tb_PlaceOfBirth = new System.Windows.Forms.TextBox();
            this.DateOfBirth = new System.Windows.Forms.TextBox();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.tb_IdPerfomersInfo = new System.Windows.Forms.TextBox();
            this.tb_Performer = new System.Windows.Forms.TextBox();
            this.tb_IdPerformer = new System.Windows.Forms.TextBox();
            this.tb_Genre = new System.Windows.Forms.TextBox();
            this.tb_IdGenre = new System.Windows.Forms.TextBox();
            this.tb_NumberOfSales = new System.Windows.Forms.TextBox();
            this.tb_DateOfSale = new System.Windows.Forms.TextBox();
            this.tb_YearOfRelease = new System.Windows.Forms.TextBox();
            this.tb_AlbumTitle = new System.Windows.Forms.TextBox();
            this.tb_IdRecord = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.tB_Quantity = new System.Windows.Forms.TextBox();
            this.tB_PlayingTime = new System.Windows.Forms.TextBox();
            this.tB_Media = new System.Windows.Forms.TextBox();
            this.tB_RecordCompany = new System.Windows.Forms.TextBox();
            this.tB_Year = new System.Windows.Forms.TextBox();
            this.tB_Artist = new System.Windows.Forms.TextBox();
            this.tB_AlbumName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Perfomers = new System.Windows.Forms.TextBox();
            this.tb_RecordCompanys = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Perfomers = new System.Windows.Forms.Button();
            this.btn_RecordCompanys = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Album = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Album = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.INSERT.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.tb_Groups);
            this.tabPage1.Controls.Add(this.tb_Professions);
            this.tabPage1.Controls.Add(this.tb_YearsOfActivity);
            this.tabPage1.Controls.Add(this.tb_PlaceOfBirth);
            this.tabPage1.Controls.Add(this.DateOfBirth);
            this.tabPage1.Controls.Add(this.tb_LastName);
            this.tabPage1.Controls.Add(this.tb_FirstName);
            this.tabPage1.Controls.Add(this.tb_IdPerfomersInfo);
            this.tabPage1.Controls.Add(this.tb_Performer);
            this.tabPage1.Controls.Add(this.tb_IdPerformer);
            this.tabPage1.Controls.Add(this.tb_Genre);
            this.tabPage1.Controls.Add(this.tb_IdGenre);
            this.tabPage1.Controls.Add(this.tb_NumberOfSales);
            this.tabPage1.Controls.Add(this.tb_DateOfSale);
            this.tabPage1.Controls.Add(this.tb_YearOfRelease);
            this.tabPage1.Controls.Add(this.tb_AlbumTitle);
            this.tabPage1.Controls.Add(this.tb_IdRecord);
            this.tabPage1.Controls.Add(this.btn_insert);
            this.tabPage1.Controls.Add(this.tB_Quantity);
            this.tabPage1.Controls.Add(this.tB_PlayingTime);
            this.tabPage1.Controls.Add(this.tB_Media);
            this.tabPage1.Controls.Add(this.tB_RecordCompany);
            this.tabPage1.Controls.Add(this.tB_Year);
            this.tabPage1.Controls.Add(this.tB_Artist);
            this.tabPage1.Controls.Add(this.tB_AlbumName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(812, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "INSERT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tb_Groups
            // 
            this.tb_Groups.Location = new System.Drawing.Point(22, 334);
            this.tb_Groups.Name = "tb_Groups";
            this.tb_Groups.Size = new System.Drawing.Size(100, 20);
            this.tb_Groups.TabIndex = 27;
            // 
            // tb_Professions
            // 
            this.tb_Professions.Location = new System.Drawing.Point(658, 291);
            this.tb_Professions.Name = "tb_Professions";
            this.tb_Professions.Size = new System.Drawing.Size(100, 20);
            this.tb_Professions.TabIndex = 26;
            // 
            // tb_YearsOfActivity
            // 
            this.tb_YearsOfActivity.Location = new System.Drawing.Point(552, 291);
            this.tb_YearsOfActivity.Name = "tb_YearsOfActivity";
            this.tb_YearsOfActivity.Size = new System.Drawing.Size(100, 20);
            this.tb_YearsOfActivity.TabIndex = 25;
            // 
            // tb_PlaceOfBirth
            // 
            this.tb_PlaceOfBirth.Location = new System.Drawing.Point(446, 291);
            this.tb_PlaceOfBirth.Name = "tb_PlaceOfBirth";
            this.tb_PlaceOfBirth.Size = new System.Drawing.Size(100, 20);
            this.tb_PlaceOfBirth.TabIndex = 24;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(340, 291);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.DateOfBirth.TabIndex = 23;
            // 
            // tb_LastName
            // 
            this.tb_LastName.Location = new System.Drawing.Point(234, 291);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(100, 20);
            this.tb_LastName.TabIndex = 22;
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Location = new System.Drawing.Point(128, 291);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(100, 20);
            this.tb_FirstName.TabIndex = 21;
            // 
            // tb_IdPerfomersInfo
            // 
            this.tb_IdPerfomersInfo.Location = new System.Drawing.Point(22, 291);
            this.tb_IdPerfomersInfo.Name = "tb_IdPerfomersInfo";
            this.tb_IdPerfomersInfo.Size = new System.Drawing.Size(100, 20);
            this.tb_IdPerfomersInfo.TabIndex = 20;
            // 
            // tb_Performer
            // 
            this.tb_Performer.Location = new System.Drawing.Point(128, 246);
            this.tb_Performer.Name = "tb_Performer";
            this.tb_Performer.Size = new System.Drawing.Size(100, 20);
            this.tb_Performer.TabIndex = 19;
            // 
            // tb_IdPerformer
            // 
            this.tb_IdPerformer.Location = new System.Drawing.Point(22, 246);
            this.tb_IdPerformer.Name = "tb_IdPerformer";
            this.tb_IdPerformer.Size = new System.Drawing.Size(100, 20);
            this.tb_IdPerformer.TabIndex = 18;
            // 
            // tb_Genre
            // 
            this.tb_Genre.Location = new System.Drawing.Point(128, 195);
            this.tb_Genre.Name = "tb_Genre";
            this.tb_Genre.Size = new System.Drawing.Size(100, 20);
            this.tb_Genre.TabIndex = 17;
            // 
            // tb_IdGenre
            // 
            this.tb_IdGenre.Location = new System.Drawing.Point(22, 195);
            this.tb_IdGenre.Name = "tb_IdGenre";
            this.tb_IdGenre.Size = new System.Drawing.Size(100, 20);
            this.tb_IdGenre.TabIndex = 16;
            // 
            // tb_NumberOfSales
            // 
            this.tb_NumberOfSales.Location = new System.Drawing.Point(446, 102);
            this.tb_NumberOfSales.Name = "tb_NumberOfSales";
            this.tb_NumberOfSales.Size = new System.Drawing.Size(100, 20);
            this.tb_NumberOfSales.TabIndex = 15;
            // 
            // tb_DateOfSale
            // 
            this.tb_DateOfSale.Location = new System.Drawing.Point(340, 102);
            this.tb_DateOfSale.Name = "tb_DateOfSale";
            this.tb_DateOfSale.Size = new System.Drawing.Size(100, 20);
            this.tb_DateOfSale.TabIndex = 14;
            // 
            // tb_YearOfRelease
            // 
            this.tb_YearOfRelease.Location = new System.Drawing.Point(234, 102);
            this.tb_YearOfRelease.Name = "tb_YearOfRelease";
            this.tb_YearOfRelease.Size = new System.Drawing.Size(100, 20);
            this.tb_YearOfRelease.TabIndex = 13;
            // 
            // tb_AlbumTitle
            // 
            this.tb_AlbumTitle.Location = new System.Drawing.Point(128, 102);
            this.tb_AlbumTitle.Name = "tb_AlbumTitle";
            this.tb_AlbumTitle.Size = new System.Drawing.Size(100, 20);
            this.tb_AlbumTitle.TabIndex = 12;
            // 
            // tb_IdRecord
            // 
            this.tb_IdRecord.Location = new System.Drawing.Point(22, 102);
            this.tb_IdRecord.Name = "tb_IdRecord";
            this.tb_IdRecord.Size = new System.Drawing.Size(100, 20);
            this.tb_IdRecord.TabIndex = 11;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(22, 53);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 10;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // tB_Quantity
            // 
            this.tB_Quantity.Location = new System.Drawing.Point(658, 27);
            this.tB_Quantity.Name = "tB_Quantity";
            this.tB_Quantity.Size = new System.Drawing.Size(100, 20);
            this.tB_Quantity.TabIndex = 6;
            // 
            // tB_PlayingTime
            // 
            this.tB_PlayingTime.Location = new System.Drawing.Point(552, 27);
            this.tB_PlayingTime.Name = "tB_PlayingTime";
            this.tB_PlayingTime.Size = new System.Drawing.Size(100, 20);
            this.tB_PlayingTime.TabIndex = 5;
            // 
            // tB_Media
            // 
            this.tB_Media.Location = new System.Drawing.Point(446, 27);
            this.tB_Media.Name = "tB_Media";
            this.tB_Media.Size = new System.Drawing.Size(100, 20);
            this.tB_Media.TabIndex = 4;
            // 
            // tB_RecordCompany
            // 
            this.tB_RecordCompany.Location = new System.Drawing.Point(340, 27);
            this.tB_RecordCompany.Name = "tB_RecordCompany";
            this.tB_RecordCompany.Size = new System.Drawing.Size(100, 20);
            this.tB_RecordCompany.TabIndex = 3;
            // 
            // tB_Year
            // 
            this.tB_Year.Location = new System.Drawing.Point(234, 27);
            this.tB_Year.Name = "tB_Year";
            this.tB_Year.Size = new System.Drawing.Size(100, 20);
            this.tB_Year.TabIndex = 2;
            // 
            // tB_Artist
            // 
            this.tB_Artist.Location = new System.Drawing.Point(128, 27);
            this.tB_Artist.Name = "tB_Artist";
            this.tB_Artist.Size = new System.Drawing.Size(100, 20);
            this.tB_Artist.TabIndex = 1;
            // 
            // tB_AlbumName
            // 
            this.tB_AlbumName.Location = new System.Drawing.Point(22, 27);
            this.tB_AlbumName.Name = "tB_AlbumName";
            this.tB_AlbumName.Size = new System.Drawing.Size(100, 20);
            this.tB_AlbumName.TabIndex = 0;
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
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
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
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
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
            // tb_Perfomers
            // 
            this.tb_Perfomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_Perfomers.Location = new System.Drawing.Point(3, 140);
            this.tb_Perfomers.Name = "tb_Perfomers";
            this.tb_Perfomers.Size = new System.Drawing.Size(186, 20);
            this.tb_Perfomers.TabIndex = 1;
            // 
            // tb_RecordCompanys
            // 
            this.tb_RecordCompanys.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_RecordCompanys.Location = new System.Drawing.Point(3, 238);
            this.tb_RecordCompanys.Name = "tb_RecordCompanys";
            this.tb_RecordCompanys.Size = new System.Drawing.Size(186, 20);
            this.tb_RecordCompanys.TabIndex = 2;
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
            // tb_Album
            // 
            this.tb_Album.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Album.Location = new System.Drawing.Point(3, 37);
            this.tb_Album.Name = "tb_Album";
            this.tb_Album.Size = new System.Drawing.Size(186, 20);
            this.tb_Album.TabIndex = 9;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 2;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl INSERT;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox tB_Quantity;
        private System.Windows.Forms.TextBox tB_PlayingTime;
        private System.Windows.Forms.TextBox tB_Media;
        private System.Windows.Forms.TextBox tB_RecordCompany;
        private System.Windows.Forms.TextBox tB_Year;
        private System.Windows.Forms.TextBox tB_Artist;
        private System.Windows.Forms.TextBox tB_AlbumName;
        private System.Windows.Forms.TextBox tb_Groups;
        private System.Windows.Forms.TextBox tb_Professions;
        private System.Windows.Forms.TextBox tb_YearsOfActivity;
        private System.Windows.Forms.TextBox tb_PlaceOfBirth;
        private System.Windows.Forms.TextBox DateOfBirth;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.TextBox tb_IdPerfomersInfo;
        private System.Windows.Forms.TextBox tb_Performer;
        private System.Windows.Forms.TextBox tb_IdPerformer;
        private System.Windows.Forms.TextBox tb_Genre;
        private System.Windows.Forms.TextBox tb_IdGenre;
        private System.Windows.Forms.TextBox tb_NumberOfSales;
        private System.Windows.Forms.TextBox tb_DateOfSale;
        private System.Windows.Forms.TextBox tb_YearOfRelease;
        private System.Windows.Forms.TextBox tb_AlbumTitle;
        private System.Windows.Forms.TextBox tb_IdRecord;
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
    }
}


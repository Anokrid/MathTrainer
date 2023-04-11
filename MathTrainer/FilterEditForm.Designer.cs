namespace MathTrainer
{
    partial class FilterEditForm
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
            MainForm.ChildWasCreated = false;
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterEditForm));
            this.textBoxFilterName = new System.Windows.Forms.TextBox();
            this.labelNum1 = new System.Windows.Forms.Label();
            this.comboBoxA1 = new System.Windows.Forms.ComboBox();
            this.comboBoxA2 = new System.Windows.Forms.ComboBox();
            this.comboBoxA3 = new System.Windows.Forms.ComboBox();
            this.comboBoxA4 = new System.Windows.Forms.ComboBox();
            this.comboBoxA5 = new System.Windows.Forms.ComboBox();
            this.comboBoxA6 = new System.Windows.Forms.ComboBox();
            this.comboBoxA7 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.comboBoxB7 = new System.Windows.Forms.ComboBox();
            this.comboBoxB6 = new System.Windows.Forms.ComboBox();
            this.comboBoxB5 = new System.Windows.Forms.ComboBox();
            this.comboBoxB4 = new System.Windows.Forms.ComboBox();
            this.comboBoxB3 = new System.Windows.Forms.ComboBox();
            this.comboBoxB2 = new System.Windows.Forms.ComboBox();
            this.comboBoxB1 = new System.Windows.Forms.ComboBox();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.labelS1 = new System.Windows.Forms.Label();
            this.numericUpDownS1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownS2 = new System.Windows.Forms.NumericUpDown();
            this.labelS2 = new System.Windows.Forms.Label();
            this.numericUpDownS3 = new System.Windows.Forms.NumericUpDown();
            this.labelS3 = new System.Windows.Forms.Label();
            this.numericUpDownS4 = new System.Windows.Forms.NumericUpDown();
            this.labelS4 = new System.Windows.Forms.Label();
            this.numericUpDownS5 = new System.Windows.Forms.NumericUpDown();
            this.labelS5 = new System.Windows.Forms.Label();
            this.textBoxDescrition = new System.Windows.Forms.TextBox();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.buttonClearText = new System.Windows.Forms.Button();
            this.buttonClearSumm = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS5)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFilterName
            // 
            this.textBoxFilterName.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilterName.Location = new System.Drawing.Point(239, 45);
            this.textBoxFilterName.Name = "textBoxFilterName";
            this.textBoxFilterName.Size = new System.Drawing.Size(294, 30);
            this.textBoxFilterName.TabIndex = 0;
            this.textBoxFilterName.Text = " Название фильтра ...";
            // 
            // labelNum1
            // 
            this.labelNum1.BackColor = System.Drawing.SystemColors.Info;
            this.labelNum1.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum1.Location = new System.Drawing.Point(12, 156);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(193, 32);
            this.labelNum1.TabIndex = 1;
            this.labelNum1.Text = "Первое число - a";
            this.labelNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxA1
            // 
            this.comboBoxA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxA1.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxA1.FormattingEnabled = true;
            this.comboBoxA1.Items.AddRange(new object[] {
            "R",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "2N",
            "!2N",
            "S1",
            "S2",
            "S3",
            "S4",
            "S5",
            "=",
            "<=",
            "=>",
            "=1",
            "=2",
            "=3",
            "=4",
            "=5",
            "=6",
            "=7"});
            this.comboBoxA1.Location = new System.Drawing.Point(641, 156);
            this.comboBoxA1.Name = "comboBoxA1";
            this.comboBoxA1.Size = new System.Drawing.Size(64, 31);
            this.comboBoxA1.TabIndex = 2;
            // 
            // comboBoxA2
            // 
            this.comboBoxA2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxA2.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxA2.FormattingEnabled = true;
            this.comboBoxA2.Items.AddRange(new object[] {
            "R",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "2N",
            "!2N",
            "S1",
            "S2",
            "S3",
            "S4",
            "S5",
            "=",
            "<=",
            "=>",
            "=1",
            "=2",
            "=3",
            "=4",
            "=5",
            "=6",
            "=7"});
            this.comboBoxA2.Location = new System.Drawing.Point(574, 156);
            this.comboBoxA2.Name = "comboBoxA2";
            this.comboBoxA2.Size = new System.Drawing.Size(64, 31);
            this.comboBoxA2.TabIndex = 3;
            // 
            // comboBoxA3
            // 
            this.comboBoxA3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxA3.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxA3.FormattingEnabled = true;
            this.comboBoxA3.Items.AddRange(new object[] {
            "R",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "2N",
            "!2N",
            "S1",
            "S2",
            "S3",
            "S4",
            "S5",
            "=",
            "<=",
            "=>",
            "=1",
            "=2",
            "=3",
            "=4",
            "=5",
            "=6",
            "=7"});
            this.comboBoxA3.Location = new System.Drawing.Point(507, 156);
            this.comboBoxA3.Name = "comboBoxA3";
            this.comboBoxA3.Size = new System.Drawing.Size(64, 31);
            this.comboBoxA3.TabIndex = 4;
            // 
            // comboBoxA4
            // 
            this.comboBoxA4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxA4.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxA4.FormattingEnabled = true;
            this.comboBoxA4.Items.AddRange(new object[] {
            "R",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "2N",
            "!2N",
            "S1",
            "S2",
            "S3",
            "S4",
            "S5",
            "=",
            "<=",
            "=>",
            "=1",
            "=2",
            "=3",
            "=4",
            "=5",
            "=6",
            "=7"});
            this.comboBoxA4.Location = new System.Drawing.Point(440, 156);
            this.comboBoxA4.Name = "comboBoxA4";
            this.comboBoxA4.Size = new System.Drawing.Size(64, 31);
            this.comboBoxA4.TabIndex = 5;
            // 
            // comboBoxA5
            // 
            this.comboBoxA5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxA5.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxA5.FormattingEnabled = true;
            this.comboBoxA5.Items.AddRange(new object[] {
            "R",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "2N",
            "!2N",
            "S1",
            "S2",
            "S3",
            "S4",
            "S5",
            "=",
            "<=",
            "=>",
            "=1",
            "=2",
            "=3",
            "=4",
            "=5",
            "=6",
            "=7"});
            this.comboBoxA5.Location = new System.Drawing.Point(373, 156);
            this.comboBoxA5.Name = "comboBoxA5";
            this.comboBoxA5.Size = new System.Drawing.Size(64, 31);
            this.comboBoxA5.TabIndex = 6;
            // 
            // comboBoxA6
            // 
            this.comboBoxA6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxA6.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxA6.FormattingEnabled = true;
            this.comboBoxA6.Items.AddRange(new object[] {
            "R",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "2N",
            "!2N",
            "S1",
            "S2",
            "S3",
            "S4",
            "S5",
            "=",
            "<=",
            "=>",
            "=1",
            "=2",
            "=3",
            "=4",
            "=5",
            "=6",
            "=7"});
            this.comboBoxA6.Location = new System.Drawing.Point(306, 156);
            this.comboBoxA6.Name = "comboBoxA6";
            this.comboBoxA6.Size = new System.Drawing.Size(64, 31);
            this.comboBoxA6.TabIndex = 7;
            // 
            // comboBoxA7
            // 
            this.comboBoxA7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxA7.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxA7.FormattingEnabled = true;
            this.comboBoxA7.Items.AddRange(new object[] {
            "R",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "2N",
            "!2N",
            "S1",
            "S2",
            "S3",
            "S4",
            "S5",
            "=",
            "<=",
            "=>",
            "=1",
            "=2",
            "=3",
            "=4",
            "=5",
            "=6",
            "=7"});
            this.comboBoxA7.Location = new System.Drawing.Point(239, 156);
            this.comboBoxA7.Name = "comboBoxA7";
            this.comboBoxA7.Size = new System.Drawing.Size(64, 31);
            this.comboBoxA7.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 48);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripSeparator4,
            this.toolStripButton4,
            this.toolStripSeparator5,
            this.toolStripButton5,
            this.toolStripSeparator6,
            this.toolStripButton6,
            this.toolStripSeparator7,
            this.toolStripButton7,
            this.toolStripSeparator8,
            this.toolStripButton8,
            this.toolStripSeparator9,
            this.toolStripButton9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(107, 24);
            this.toolStripLabel1.Text = "Обозначения:";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Случайная цифра";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "Конкретные числа от 0 до 9";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "Случайное чётное число";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "Случайное нечётное число";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton5.Text = "Позиции, помеченные S, будут давать одну из 5 конкретных сумм";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton6.Text = "Цифра на выбранном разряде у данного числа будет равна цифре, стоящей на том же р" +
    "азряде у второго числа";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton7.Text = "Цифра равна стоящей слева от неё";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton8.Text = "Цифра равна стоящей справа от неё";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton9.Text = "Цифра равна другой цифре указанной позиции этого числа (1 - единицы, 2 - десятки " +
    "и т.д.)";
            // 
            // comboBoxB7
            // 
            this.comboBoxB7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxB7.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxB7.FormattingEnabled = true;
            this.comboBoxB7.Items.AddRange(new object[] {
            "R",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "2N",
            "!2N",
            "S1",
            "S2",
            "S3",
            "S4",
            "S5",
            "=",
            "<=",
            "=>",
            "=1",
            "=2",
            "=3",
            "=4",
            "=5",
            "=6",
            "=7"});
            this.comboBoxB7.Location = new System.Drawing.Point(239, 199);
            this.comboBoxB7.Name = "comboBoxB7";
            this.comboBoxB7.Size = new System.Drawing.Size(64, 31);
            this.comboBoxB7.TabIndex = 18;
            // 
            // comboBoxB6
            // 
            this.comboBoxB6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxB6.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxB6.FormattingEnabled = true;
            this.comboBoxB6.Items.AddRange(new object[] {
            "R",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "2N",
            "!2N",
            "S1",
            "S2",
            "S3",
            "S4",
            "S5",
            "=",
            "<=",
            "=>",
            "=1",
            "=2",
            "=3",
            "=4",
            "=5",
            "=6",
            "=7"});
            this.comboBoxB6.Location = new System.Drawing.Point(306, 199);
            this.comboBoxB6.Name = "comboBoxB6";
            this.comboBoxB6.Size = new System.Drawing.Size(64, 31);
            this.comboBoxB6.TabIndex = 17;
            // 
            // comboBoxB5
            // 
            this.comboBoxB5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxB5.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxB5.FormattingEnabled = true;
            this.comboBoxB5.Items.AddRange(new object[] {
            "R",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "2N",
            "!2N",
            "S1",
            "S2",
            "S3",
            "S4",
            "S5",
            "=",
            "<=",
            "=>",
            "=1",
            "=2",
            "=3",
            "=4",
            "=5",
            "=6",
            "=7"});
            this.comboBoxB5.Location = new System.Drawing.Point(373, 199);
            this.comboBoxB5.Name = "comboBoxB5";
            this.comboBoxB5.Size = new System.Drawing.Size(64, 31);
            this.comboBoxB5.TabIndex = 16;
            // 
            // comboBoxB4
            // 
            this.comboBoxB4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxB4.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxB4.FormattingEnabled = true;
            this.comboBoxB4.Items.AddRange(new object[] {
            "R",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "2N",
            "!2N",
            "S1",
            "S2",
            "S3",
            "S4",
            "S5",
            "=",
            "<=",
            "=>",
            "=1",
            "=2",
            "=3",
            "=4",
            "=5",
            "=6",
            "=7"});
            this.comboBoxB4.Location = new System.Drawing.Point(440, 199);
            this.comboBoxB4.Name = "comboBoxB4";
            this.comboBoxB4.Size = new System.Drawing.Size(64, 31);
            this.comboBoxB4.TabIndex = 15;
            // 
            // comboBoxB3
            // 
            this.comboBoxB3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxB3.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxB3.FormattingEnabled = true;
            this.comboBoxB3.Items.AddRange(new object[] {
            "R",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "2N",
            "!2N",
            "S1",
            "S2",
            "S3",
            "S4",
            "S5",
            "=",
            "<=",
            "=>",
            "=1",
            "=2",
            "=3",
            "=4",
            "=5",
            "=6",
            "=7"});
            this.comboBoxB3.Location = new System.Drawing.Point(507, 199);
            this.comboBoxB3.Name = "comboBoxB3";
            this.comboBoxB3.Size = new System.Drawing.Size(64, 31);
            this.comboBoxB3.TabIndex = 14;
            // 
            // comboBoxB2
            // 
            this.comboBoxB2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxB2.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxB2.FormattingEnabled = true;
            this.comboBoxB2.Items.AddRange(new object[] {
            "R",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "2N",
            "!2N",
            "S1",
            "S2",
            "S3",
            "S4",
            "S5",
            "=",
            "<=",
            "=>",
            "=1",
            "=2",
            "=3",
            "=4",
            "=5",
            "=6",
            "=7"});
            this.comboBoxB2.Location = new System.Drawing.Point(574, 199);
            this.comboBoxB2.Name = "comboBoxB2";
            this.comboBoxB2.Size = new System.Drawing.Size(64, 31);
            this.comboBoxB2.TabIndex = 13;
            // 
            // comboBoxB1
            // 
            this.comboBoxB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxB1.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxB1.FormattingEnabled = true;
            this.comboBoxB1.Items.AddRange(new object[] {
            "R",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "2N",
            "!2N",
            "S1",
            "S2",
            "S3",
            "S4",
            "S5",
            "=",
            "<=",
            "=>",
            "=1",
            "=2",
            "=3",
            "=4",
            "=5",
            "=6",
            "=7"});
            this.comboBoxB1.Location = new System.Drawing.Point(641, 199);
            this.comboBoxB1.Name = "comboBoxB1";
            this.comboBoxB1.Size = new System.Drawing.Size(64, 31);
            this.comboBoxB1.TabIndex = 12;
            // 
            // labelNum2
            // 
            this.labelNum2.BackColor = System.Drawing.SystemColors.Info;
            this.labelNum2.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum2.Location = new System.Drawing.Point(12, 199);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(193, 32);
            this.labelNum2.TabIndex = 11;
            this.labelNum2.Text = "Второе число - b";
            this.labelNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelS1
            // 
            this.labelS1.BackColor = System.Drawing.SystemColors.Info;
            this.labelS1.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS1.Location = new System.Drawing.Point(13, 242);
            this.labelS1.Name = "labelS1";
            this.labelS1.Size = new System.Drawing.Size(124, 30);
            this.labelS1.TabIndex = 19;
            this.labelS1.Text = "Сумма S1";
            this.labelS1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownS1
            // 
            this.numericUpDownS1.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownS1.Location = new System.Drawing.Point(144, 242);
            this.numericUpDownS1.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownS1.Name = "numericUpDownS1";
            this.numericUpDownS1.Size = new System.Drawing.Size(61, 30);
            this.numericUpDownS1.TabIndex = 20;
            this.numericUpDownS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownS2
            // 
            this.numericUpDownS2.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownS2.Location = new System.Drawing.Point(144, 282);
            this.numericUpDownS2.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownS2.Name = "numericUpDownS2";
            this.numericUpDownS2.Size = new System.Drawing.Size(61, 30);
            this.numericUpDownS2.TabIndex = 22;
            this.numericUpDownS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelS2
            // 
            this.labelS2.BackColor = System.Drawing.SystemColors.Info;
            this.labelS2.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS2.Location = new System.Drawing.Point(13, 282);
            this.labelS2.Name = "labelS2";
            this.labelS2.Size = new System.Drawing.Size(124, 30);
            this.labelS2.TabIndex = 21;
            this.labelS2.Text = "Сумма S2";
            this.labelS2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownS3
            // 
            this.numericUpDownS3.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownS3.Location = new System.Drawing.Point(144, 321);
            this.numericUpDownS3.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownS3.Name = "numericUpDownS3";
            this.numericUpDownS3.Size = new System.Drawing.Size(61, 30);
            this.numericUpDownS3.TabIndex = 24;
            this.numericUpDownS3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelS3
            // 
            this.labelS3.BackColor = System.Drawing.SystemColors.Info;
            this.labelS3.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS3.Location = new System.Drawing.Point(12, 321);
            this.labelS3.Name = "labelS3";
            this.labelS3.Size = new System.Drawing.Size(124, 30);
            this.labelS3.TabIndex = 23;
            this.labelS3.Text = "Сумма S3";
            this.labelS3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownS4
            // 
            this.numericUpDownS4.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownS4.Location = new System.Drawing.Point(144, 361);
            this.numericUpDownS4.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownS4.Name = "numericUpDownS4";
            this.numericUpDownS4.Size = new System.Drawing.Size(61, 30);
            this.numericUpDownS4.TabIndex = 26;
            this.numericUpDownS4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelS4
            // 
            this.labelS4.BackColor = System.Drawing.SystemColors.Info;
            this.labelS4.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS4.Location = new System.Drawing.Point(13, 361);
            this.labelS4.Name = "labelS4";
            this.labelS4.Size = new System.Drawing.Size(124, 30);
            this.labelS4.TabIndex = 25;
            this.labelS4.Text = "Сумма S4";
            this.labelS4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownS5
            // 
            this.numericUpDownS5.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownS5.Location = new System.Drawing.Point(144, 402);
            this.numericUpDownS5.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownS5.Name = "numericUpDownS5";
            this.numericUpDownS5.Size = new System.Drawing.Size(61, 30);
            this.numericUpDownS5.TabIndex = 28;
            this.numericUpDownS5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelS5
            // 
            this.labelS5.BackColor = System.Drawing.SystemColors.Info;
            this.labelS5.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS5.Location = new System.Drawing.Point(13, 402);
            this.labelS5.Name = "labelS5";
            this.labelS5.Size = new System.Drawing.Size(124, 30);
            this.labelS5.TabIndex = 27;
            this.labelS5.Text = "Сумма S5";
            this.labelS5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDescrition
            // 
            this.textBoxDescrition.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxDescrition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescrition.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescrition.Location = new System.Drawing.Point(239, 242);
            this.textBoxDescrition.Multiline = true;
            this.textBoxDescrition.Name = "textBoxDescrition";
            this.textBoxDescrition.Size = new System.Drawing.Size(265, 191);
            this.textBoxDescrition.TabIndex = 29;
            this.textBoxDescrition.Text = "Описание фильтра ...";
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClearFilters.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFilters.Location = new System.Drawing.Point(511, 242);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(195, 30);
            this.buttonClearFilters.TabIndex = 30;
            this.buttonClearFilters.Text = " Сброс фильтров";
            this.buttonClearFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearFilters.UseVisualStyleBackColor = false;
            // 
            // buttonClearText
            // 
            this.buttonClearText.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClearText.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearText.Location = new System.Drawing.Point(511, 278);
            this.buttonClearText.Name = "buttonClearText";
            this.buttonClearText.Size = new System.Drawing.Size(195, 30);
            this.buttonClearText.TabIndex = 31;
            this.buttonClearText.Text = " Сброс текста";
            this.buttonClearText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearText.UseVisualStyleBackColor = false;
            // 
            // buttonClearSumm
            // 
            this.buttonClearSumm.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClearSumm.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearSumm.Location = new System.Drawing.Point(511, 314);
            this.buttonClearSumm.Name = "buttonClearSumm";
            this.buttonClearSumm.Size = new System.Drawing.Size(195, 30);
            this.buttonClearSumm.TabIndex = 32;
            this.buttonClearSumm.Text = " Сброс сумм";
            this.buttonClearSumm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearSumm.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSave.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(511, 403);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(195, 30);
            this.buttonSave.TabIndex = 33;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonYes
            // 
            this.buttonYes.BackColor = System.Drawing.SystemColors.Control;
            this.buttonYes.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYes.Location = new System.Drawing.Point(716, 242);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(70, 30);
            this.buttonYes.TabIndex = 34;
            this.buttonYes.Text = "Да";
            this.buttonYes.UseVisualStyleBackColor = false;
            this.buttonYes.Visible = false;
            // 
            // buttonNo
            // 
            this.buttonNo.BackColor = System.Drawing.SystemColors.Control;
            this.buttonNo.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNo.Location = new System.Drawing.Point(716, 278);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(70, 30);
            this.buttonNo.TabIndex = 35;
            this.buttonNo.Text = "Нет";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.Visible = false;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClearAll.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearAll.Location = new System.Drawing.Point(511, 350);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(195, 30);
            this.buttonClearAll.TabIndex = 36;
            this.buttonClearAll.Text = " Сбросить всё";
            this.buttonClearAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearAll.UseVisualStyleBackColor = false;
            // 
            // FilterEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClearSumm);
            this.Controls.Add(this.buttonClearText);
            this.Controls.Add(this.buttonClearFilters);
            this.Controls.Add(this.textBoxDescrition);
            this.Controls.Add(this.numericUpDownS5);
            this.Controls.Add(this.labelS5);
            this.Controls.Add(this.numericUpDownS4);
            this.Controls.Add(this.labelS4);
            this.Controls.Add(this.numericUpDownS3);
            this.Controls.Add(this.labelS3);
            this.Controls.Add(this.numericUpDownS2);
            this.Controls.Add(this.labelS2);
            this.Controls.Add(this.numericUpDownS1);
            this.Controls.Add(this.labelS1);
            this.Controls.Add(this.comboBoxB7);
            this.Controls.Add(this.comboBoxB6);
            this.Controls.Add(this.comboBoxB5);
            this.Controls.Add(this.comboBoxB4);
            this.Controls.Add(this.comboBoxB3);
            this.Controls.Add(this.comboBoxB2);
            this.Controls.Add(this.comboBoxB1);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxA7);
            this.Controls.Add(this.comboBoxA6);
            this.Controls.Add(this.comboBoxA5);
            this.Controls.Add(this.comboBoxA4);
            this.Controls.Add(this.comboBoxA3);
            this.Controls.Add(this.comboBoxA2);
            this.Controls.Add(this.comboBoxA1);
            this.Controls.Add(this.labelNum1);
            this.Controls.Add(this.textBoxFilterName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FilterEditForm";
            this.Text = "Добавление фильтра";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFilterName;
        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.ComboBox comboBoxA1;
        private System.Windows.Forms.ComboBox comboBoxA2;
        private System.Windows.Forms.ComboBox comboBoxA3;
        private System.Windows.Forms.ComboBox comboBoxA4;
        private System.Windows.Forms.ComboBox comboBoxA5;
        private System.Windows.Forms.ComboBox comboBoxA6;
        private System.Windows.Forms.ComboBox comboBoxA7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ComboBox comboBoxB7;
        private System.Windows.Forms.ComboBox comboBoxB6;
        private System.Windows.Forms.ComboBox comboBoxB5;
        private System.Windows.Forms.ComboBox comboBoxB4;
        private System.Windows.Forms.ComboBox comboBoxB3;
        private System.Windows.Forms.ComboBox comboBoxB2;
        private System.Windows.Forms.ComboBox comboBoxB1;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.Label labelS1;
        private System.Windows.Forms.NumericUpDown numericUpDownS1;
        private System.Windows.Forms.NumericUpDown numericUpDownS2;
        private System.Windows.Forms.Label labelS2;
        private System.Windows.Forms.NumericUpDown numericUpDownS3;
        private System.Windows.Forms.Label labelS3;
        private System.Windows.Forms.NumericUpDown numericUpDownS4;
        private System.Windows.Forms.Label labelS4;
        private System.Windows.Forms.NumericUpDown numericUpDownS5;
        private System.Windows.Forms.Label labelS5;
        private System.Windows.Forms.TextBox textBoxDescrition;
        private System.Windows.Forms.Button buttonClearFilters;
        private System.Windows.Forms.Button buttonClearText;
        private System.Windows.Forms.Button buttonClearSumm;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonClearAll;
    }
}
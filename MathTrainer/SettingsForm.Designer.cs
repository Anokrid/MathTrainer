namespace MathTrainer
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.labelNumOfExamples = new System.Windows.Forms.Label();
            this.labelFont = new System.Windows.Forms.Label();
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.comboBoxExamplesFont = new System.Windows.Forms.ComboBox();
            this.labelExamplesFont = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.labelExamplaseSize = new System.Windows.Forms.Label();
            this.numericUpDownMainFont = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExamplesFont = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExamples = new System.Windows.Forms.NumericUpDown();
            this.labelBackGround = new System.Windows.Forms.Label();
            this.comboBoxImages = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSizeImage = new System.Windows.Forms.Label();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.numericUpDownNotesFont = new System.Windows.Forms.NumericUpDown();
            this.labelNotesSize = new System.Windows.Forms.Label();
            this.comboBoxNotesFont = new System.Windows.Forms.ComboBox();
            this.labelNotesFont = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMainFont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExamplesFont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotesFont)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumOfExamples
            // 
            this.labelNumOfExamples.BackColor = System.Drawing.SystemColors.Info;
            this.labelNumOfExamples.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumOfExamples.Location = new System.Drawing.Point(12, 9);
            this.labelNumOfExamples.Name = "labelNumOfExamples";
            this.labelNumOfExamples.Size = new System.Drawing.Size(243, 59);
            this.labelNumOfExamples.TabIndex = 0;
            this.labelNumOfExamples.Text = "Число одновременно выводимых примеров";
            this.labelNumOfExamples.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFont
            // 
            this.labelFont.BackColor = System.Drawing.SystemColors.Info;
            this.labelFont.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFont.Location = new System.Drawing.Point(12, 91);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(244, 26);
            this.labelFont.TabIndex = 1;
            this.labelFont.Text = "Используемый шрифт:";
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFont.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Items.AddRange(new object[] {
            "Arial",
            "Calibri",
            "Century",
            "Courier New",
            "Georgia",
            "Lucida Sans",
            "Palatino Linotype",
            "TF2 Secondary",
            "Times New Roman"});
            this.comboBoxFont.Location = new System.Drawing.Point(12, 119);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(243, 31);
            this.comboBoxFont.TabIndex = 2;
            // 
            // comboBoxExamplesFont
            // 
            this.comboBoxExamplesFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExamplesFont.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxExamplesFont.FormattingEnabled = true;
            this.comboBoxExamplesFont.Items.AddRange(new object[] {
            "Arial",
            "Calibri",
            "Century",
            "Courier New",
            "Georgia",
            "Lucida Sans",
            "Palatino Linotype",
            "TF2 Secondary",
            "Times New Roman"});
            this.comboBoxExamplesFont.Location = new System.Drawing.Point(13, 193);
            this.comboBoxExamplesFont.Name = "comboBoxExamplesFont";
            this.comboBoxExamplesFont.Size = new System.Drawing.Size(243, 31);
            this.comboBoxExamplesFont.TabIndex = 4;
            // 
            // labelExamplesFont
            // 
            this.labelExamplesFont.BackColor = System.Drawing.SystemColors.Info;
            this.labelExamplesFont.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExamplesFont.Location = new System.Drawing.Point(13, 165);
            this.labelExamplesFont.Name = "labelExamplesFont";
            this.labelExamplesFont.Size = new System.Drawing.Size(244, 26);
            this.labelExamplesFont.TabIndex = 3;
            this.labelExamplesFont.Text = "Шрифт примеров:";
            // 
            // labelSize
            // 
            this.labelSize.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelSize.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(274, 91);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(107, 26);
            this.labelSize.TabIndex = 5;
            this.labelSize.Text = "Размер";
            this.labelSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonRestore
            // 
            this.buttonRestore.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRestore.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestore.Location = new System.Drawing.Point(12, 339);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(189, 98);
            this.buttonRestore.TabIndex = 6;
            this.buttonRestore.Text = "Восстановить значения по умолчанию";
            this.buttonRestore.UseVisualStyleBackColor = false;
            // 
            // labelExamplaseSize
            // 
            this.labelExamplaseSize.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelExamplaseSize.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExamplaseSize.Location = new System.Drawing.Point(274, 165);
            this.labelExamplaseSize.Name = "labelExamplaseSize";
            this.labelExamplaseSize.Size = new System.Drawing.Size(107, 26);
            this.labelExamplaseSize.TabIndex = 7;
            this.labelExamplaseSize.Text = "Размер";
            this.labelExamplaseSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownMainFont
            // 
            this.numericUpDownMainFont.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMainFont.Location = new System.Drawing.Point(274, 119);
            this.numericUpDownMainFont.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownMainFont.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownMainFont.Name = "numericUpDownMainFont";
            this.numericUpDownMainFont.Size = new System.Drawing.Size(107, 30);
            this.numericUpDownMainFont.TabIndex = 8;
            this.numericUpDownMainFont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMainFont.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numericUpDownExamplesFont
            // 
            this.numericUpDownExamplesFont.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownExamplesFont.Location = new System.Drawing.Point(274, 193);
            this.numericUpDownExamplesFont.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownExamplesFont.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownExamplesFont.Name = "numericUpDownExamplesFont";
            this.numericUpDownExamplesFont.Size = new System.Drawing.Size(107, 30);
            this.numericUpDownExamplesFont.TabIndex = 9;
            this.numericUpDownExamplesFont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownExamplesFont.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numericUpDownExamples
            // 
            this.numericUpDownExamples.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownExamples.Location = new System.Drawing.Point(274, 9);
            this.numericUpDownExamples.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownExamples.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownExamples.Name = "numericUpDownExamples";
            this.numericUpDownExamples.Size = new System.Drawing.Size(107, 30);
            this.numericUpDownExamples.TabIndex = 10;
            this.numericUpDownExamples.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownExamples.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelBackGround
            // 
            this.labelBackGround.BackColor = System.Drawing.SystemColors.Info;
            this.labelBackGround.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackGround.Location = new System.Drawing.Point(468, 9);
            this.labelBackGround.Name = "labelBackGround";
            this.labelBackGround.Size = new System.Drawing.Size(320, 30);
            this.labelBackGround.TabIndex = 11;
            this.labelBackGround.Text = "Задний фон основного окна";
            this.labelBackGround.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxImages
            // 
            this.comboBoxImages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxImages.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxImages.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxImages.FormattingEnabled = true;
            this.comboBoxImages.Items.AddRange(new object[] {
            "1) Стандартный",
            "2) Небо",
            "3) Дорога",
            "4) Техно",
            "5) Техно 2",
            "6) Ночное небо",
            "7) Совесть чиновника"});
            this.comboBoxImages.Location = new System.Drawing.Point(468, 42);
            this.comboBoxImages.Name = "comboBoxImages";
            this.comboBoxImages.Size = new System.Drawing.Size(320, 31);
            this.comboBoxImages.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(468, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 180);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // labelSizeImage
            // 
            this.labelSizeImage.BackColor = System.Drawing.SystemColors.Info;
            this.labelSizeImage.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSizeImage.Location = new System.Drawing.Point(468, 282);
            this.labelSizeImage.Name = "labelSizeImage";
            this.labelSizeImage.Size = new System.Drawing.Size(171, 60);
            this.labelSizeImage.TabIndex = 14;
            this.labelSizeImage.Text = "Растягивать изображение";
            this.labelSizeImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYes.Location = new System.Drawing.Point(649, 282);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(66, 27);
            this.radioButtonYes.TabIndex = 15;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Да";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNo.Location = new System.Drawing.Point(649, 315);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(66, 27);
            this.radioButtonNo.TabIndex = 16;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "Нет";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // numericUpDownNotesFont
            // 
            this.numericUpDownNotesFont.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNotesFont.Location = new System.Drawing.Point(274, 266);
            this.numericUpDownNotesFont.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownNotesFont.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownNotesFont.Name = "numericUpDownNotesFont";
            this.numericUpDownNotesFont.Size = new System.Drawing.Size(107, 30);
            this.numericUpDownNotesFont.TabIndex = 20;
            this.numericUpDownNotesFont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownNotesFont.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // labelNotesSize
            // 
            this.labelNotesSize.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelNotesSize.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotesSize.Location = new System.Drawing.Point(274, 238);
            this.labelNotesSize.Name = "labelNotesSize";
            this.labelNotesSize.Size = new System.Drawing.Size(107, 26);
            this.labelNotesSize.TabIndex = 19;
            this.labelNotesSize.Text = "Размер";
            this.labelNotesSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxNotesFont
            // 
            this.comboBoxNotesFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNotesFont.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNotesFont.FormattingEnabled = true;
            this.comboBoxNotesFont.Items.AddRange(new object[] {
            "Arial",
            "Calibri",
            "Century",
            "Courier New",
            "Georgia",
            "Lucida Sans",
            "Palatino Linotype",
            "TF2 Secondary",
            "Times New Roman"});
            this.comboBoxNotesFont.Location = new System.Drawing.Point(13, 266);
            this.comboBoxNotesFont.Name = "comboBoxNotesFont";
            this.comboBoxNotesFont.Size = new System.Drawing.Size(243, 31);
            this.comboBoxNotesFont.TabIndex = 18;
            // 
            // labelNotesFont
            // 
            this.labelNotesFont.BackColor = System.Drawing.SystemColors.Info;
            this.labelNotesFont.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotesFont.Location = new System.Drawing.Point(13, 238);
            this.labelNotesFont.Name = "labelNotesFont";
            this.labelNotesFont.Size = new System.Drawing.Size(244, 26);
            this.labelNotesFont.TabIndex = 17;
            this.labelNotesFont.Text = "Шрифт заметок:";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSave.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(207, 339);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSave.Size = new System.Drawing.Size(174, 98);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Сохранить настройки";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownNotesFont);
            this.Controls.Add(this.labelNotesSize);
            this.Controls.Add(this.comboBoxNotesFont);
            this.Controls.Add(this.labelNotesFont);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonYes);
            this.Controls.Add(this.labelSizeImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxImages);
            this.Controls.Add(this.labelBackGround);
            this.Controls.Add(this.numericUpDownExamples);
            this.Controls.Add(this.numericUpDownExamplesFont);
            this.Controls.Add(this.numericUpDownMainFont);
            this.Controls.Add(this.labelExamplaseSize);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.comboBoxExamplesFont);
            this.Controls.Add(this.labelExamplesFont);
            this.Controls.Add(this.comboBoxFont);
            this.Controls.Add(this.labelFont);
            this.Controls.Add(this.labelNumOfExamples);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMainFont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExamplesFont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotesFont)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumOfExamples;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.ComboBox comboBoxFont;
        private System.Windows.Forms.ComboBox comboBoxExamplesFont;
        private System.Windows.Forms.Label labelExamplesFont;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Label labelExamplaseSize;
        private System.Windows.Forms.NumericUpDown numericUpDownMainFont;
        private System.Windows.Forms.NumericUpDown numericUpDownExamplesFont;
        private System.Windows.Forms.NumericUpDown numericUpDownExamples;
        private System.Windows.Forms.Label labelBackGround;
        private System.Windows.Forms.ComboBox comboBoxImages;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSizeImage;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.NumericUpDown numericUpDownNotesFont;
        private System.Windows.Forms.Label labelNotesSize;
        private System.Windows.Forms.ComboBox comboBoxNotesFont;
        private System.Windows.Forms.Label labelNotesFont;
        private System.Windows.Forms.Button buttonSave;
    }
}
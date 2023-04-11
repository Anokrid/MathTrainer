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
            this.buttonEarly = new System.Windows.Forms.Button();
            this.labelExamplaseSize = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.labelBackGround = new System.Windows.Forms.Label();
            this.comboBoxImages = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSizeImage = new System.Windows.Forms.Label();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.numericUpDownNotesSize = new System.Windows.Forms.NumericUpDown();
            this.labelNotesSize = new System.Windows.Forms.Label();
            this.comboBoxNotesFont = new System.Windows.Forms.ComboBox();
            this.labelNotesFont = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotesSize)).BeginInit();
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
            // buttonEarly
            // 
            this.buttonEarly.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEarly.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEarly.Location = new System.Drawing.Point(12, 339);
            this.buttonEarly.Name = "buttonEarly";
            this.buttonEarly.Size = new System.Drawing.Size(243, 98);
            this.buttonEarly.TabIndex = 6;
            this.buttonEarly.Text = "Восстановить значения по-умолчанию";
            this.buttonEarly.UseVisualStyleBackColor = false;
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
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(274, 119);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(107, 30);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(274, 193);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(107, 30);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(274, 9);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(107, 30);
            this.numericUpDown3.TabIndex = 10;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown3.Value = new decimal(new int[] {
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
            // numericUpDownNotesSize
            // 
            this.numericUpDownNotesSize.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNotesSize.Location = new System.Drawing.Point(274, 266);
            this.numericUpDownNotesSize.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownNotesSize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownNotesSize.Name = "numericUpDownNotesSize";
            this.numericUpDownNotesSize.Size = new System.Drawing.Size(107, 30);
            this.numericUpDownNotesSize.TabIndex = 20;
            this.numericUpDownNotesSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownNotesSize.Value = new decimal(new int[] {
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownNotesSize);
            this.Controls.Add(this.labelNotesSize);
            this.Controls.Add(this.comboBoxNotesFont);
            this.Controls.Add(this.labelNotesFont);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonYes);
            this.Controls.Add(this.labelSizeImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxImages);
            this.Controls.Add(this.labelBackGround);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelExamplaseSize);
            this.Controls.Add(this.buttonEarly);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.comboBoxExamplesFont);
            this.Controls.Add(this.labelExamplesFont);
            this.Controls.Add(this.comboBoxFont);
            this.Controls.Add(this.labelFont);
            this.Controls.Add(this.labelNumOfExamples);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotesSize)).EndInit();
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
        private System.Windows.Forms.Button buttonEarly;
        private System.Windows.Forms.Label labelExamplaseSize;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label labelBackGround;
        private System.Windows.Forms.ComboBox comboBoxImages;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSizeImage;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.NumericUpDown numericUpDownNotesSize;
        private System.Windows.Forms.Label labelNotesSize;
        private System.Windows.Forms.ComboBox comboBoxNotesFont;
        private System.Windows.Forms.Label labelNotesFont;
    }
}
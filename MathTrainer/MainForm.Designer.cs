namespace MathTrainer
{
    partial class MainForm
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
            if (disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ButtonRandomize = new System.Windows.Forms.Button();
            this.ButtonAnswers = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHow = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOptions = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNotes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonVersion = new System.Windows.Forms.ToolStripButton();
            this.LabelM = new System.Windows.Forms.Label();
            this.LabelN = new System.Windows.Forms.Label();
            this.LabelFunction = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelNum1 = new System.Windows.Forms.Label();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.labelNum3 = new System.Windows.Forms.Label();
            this.labelNum4 = new System.Windows.Forms.Label();
            this.labelNum5 = new System.Windows.Forms.Label();
            this.labelNum6 = new System.Windows.Forms.Label();
            this.labelNum7 = new System.Windows.Forms.Label();
            this.labelNum8 = new System.Windows.Forms.Label();
            this.labelNum9 = new System.Windows.Forms.Label();
            this.labelNum10 = new System.Windows.Forms.Label();
            this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.checkBoxUseFiler = new System.Windows.Forms.CheckBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.buttonNewFilter = new System.Windows.Forms.Button();
            this.buttonDeleteFilter = new System.Windows.Forms.Button();
            this.buttonEditFilter = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelAboutFiltr = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRandomize
            // 
            this.ButtonRandomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRandomize.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRandomize.Location = new System.Drawing.Point(516, 40);
            this.ButtonRandomize.Name = "ButtonRandomize";
            this.ButtonRandomize.Size = new System.Drawing.Size(167, 69);
            this.ButtonRandomize.TabIndex = 0;
            this.ButtonRandomize.Text = "Сгенерировать примеры";
            this.ButtonRandomize.UseVisualStyleBackColor = true;
            // 
            // ButtonAnswers
            // 
            this.ButtonAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAnswers.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAnswers.Location = new System.Drawing.Point(689, 40);
            this.ButtonAnswers.Name = "ButtonAnswers";
            this.ButtonAnswers.Size = new System.Drawing.Size(121, 69);
            this.ButtonAnswers.TabIndex = 1;
            this.ButtonAnswers.Text = "Показать ответы";
            this.ButtonAnswers.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAbout,
            this.toolStripButtonHow,
            this.toolStripButtonOptions,
            this.toolStripButtonNotes,
            this.toolStripButtonVersion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(822, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Font = new System.Drawing.Font("TF2 Secondary", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAbout.Text = "О приложении";
            // 
            // toolStripButtonHow
            // 
            this.toolStripButtonHow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHow.Font = new System.Drawing.Font("TF2 Secondary", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonHow.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHow.Image")));
            this.toolStripButtonHow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHow.Name = "toolStripButtonHow";
            this.toolStripButtonHow.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonHow.Text = "Как работать?";
            // 
            // toolStripButtonOptions
            // 
            this.toolStripButtonOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOptions.Font = new System.Drawing.Font("TF2 Secondary", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonOptions.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOptions.Image")));
            this.toolStripButtonOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOptions.Name = "toolStripButtonOptions";
            this.toolStripButtonOptions.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonOptions.Text = "Настройки";
            // 
            // toolStripButtonNotes
            // 
            this.toolStripButtonNotes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNotes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNotes.Image")));
            this.toolStripButtonNotes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNotes.Name = "toolStripButtonNotes";
            this.toolStripButtonNotes.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonNotes.Text = "Заметки";
            // 
            // toolStripButtonVersion
            // 
            this.toolStripButtonVersion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonVersion.Font = new System.Drawing.Font("TF2 Secondary", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonVersion.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonVersion.Image")));
            this.toolStripButtonVersion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonVersion.Name = "toolStripButtonVersion";
            this.toolStripButtonVersion.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonVersion.Text = "Версия 1.0.2 b";
            // 
            // LabelM
            // 
            this.LabelM.BackColor = System.Drawing.SystemColors.Info;
            this.LabelM.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelM.Location = new System.Drawing.Point(13, 42);
            this.LabelM.Name = "LabelM";
            this.LabelM.Size = new System.Drawing.Size(127, 30);
            this.LabelM.TabIndex = 5;
            this.LabelM.Text = "Число 1 - m";
            this.LabelM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelN
            // 
            this.LabelN.BackColor = System.Drawing.SystemColors.Info;
            this.LabelN.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelN.Location = new System.Drawing.Point(13, 79);
            this.LabelN.Name = "LabelN";
            this.LabelN.Size = new System.Drawing.Size(127, 30);
            this.LabelN.TabIndex = 6;
            this.LabelN.Text = "Число 2 - n";
            this.LabelN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelFunction
            // 
            this.LabelFunction.BackColor = System.Drawing.SystemColors.Info;
            this.LabelFunction.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFunction.Location = new System.Drawing.Point(218, 41);
            this.LabelFunction.Name = "LabelFunction";
            this.LabelFunction.Size = new System.Drawing.Size(290, 30);
            this.LabelFunction.TabIndex = 7;
            this.LabelFunction.Text = "Функция (Вид примера)";
            this.LabelFunction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            " 1) Сложение:        a + b",
            " 2) Вычитание:      a - b",
            " 3) Умножение:     a * b",
            " 4) Деление:         a / b",
            " 5) Степень:          a^n",
            " 6) Корень:           a^(1/n)"});
            this.comboBox1.Location = new System.Drawing.Point(217, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 31);
            this.comboBox1.TabIndex = 8;
            // 
            // labelNum1
            // 
            this.labelNum1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum1.Location = new System.Drawing.Point(13, 141);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(492, 35);
            this.labelNum1.TabIndex = 9;
            this.labelNum1.Text = "Пример 1";
            this.labelNum1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNum2
            // 
            this.labelNum2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum2.Location = new System.Drawing.Point(14, 185);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(492, 35);
            this.labelNum2.TabIndex = 10;
            this.labelNum2.Text = "Пример 2";
            this.labelNum2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNum3
            // 
            this.labelNum3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum3.Location = new System.Drawing.Point(14, 230);
            this.labelNum3.Name = "labelNum3";
            this.labelNum3.Size = new System.Drawing.Size(492, 35);
            this.labelNum3.TabIndex = 11;
            this.labelNum3.Text = "Пример 3";
            this.labelNum3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNum4
            // 
            this.labelNum4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum4.Location = new System.Drawing.Point(14, 275);
            this.labelNum4.Name = "labelNum4";
            this.labelNum4.Size = new System.Drawing.Size(492, 35);
            this.labelNum4.TabIndex = 12;
            this.labelNum4.Text = "Пример 4";
            this.labelNum4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNum5
            // 
            this.labelNum5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum5.Location = new System.Drawing.Point(14, 320);
            this.labelNum5.Name = "labelNum5";
            this.labelNum5.Size = new System.Drawing.Size(492, 35);
            this.labelNum5.TabIndex = 13;
            this.labelNum5.Text = "Пример 5";
            this.labelNum5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNum6
            // 
            this.labelNum6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum6.Location = new System.Drawing.Point(13, 364);
            this.labelNum6.Name = "labelNum6";
            this.labelNum6.Size = new System.Drawing.Size(492, 35);
            this.labelNum6.TabIndex = 14;
            this.labelNum6.Text = "Пример 6";
            this.labelNum6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNum7
            // 
            this.labelNum7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum7.Location = new System.Drawing.Point(13, 409);
            this.labelNum7.Name = "labelNum7";
            this.labelNum7.Size = new System.Drawing.Size(492, 35);
            this.labelNum7.TabIndex = 15;
            this.labelNum7.Text = "Пример 7";
            this.labelNum7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNum8
            // 
            this.labelNum8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum8.Location = new System.Drawing.Point(14, 454);
            this.labelNum8.Name = "labelNum8";
            this.labelNum8.Size = new System.Drawing.Size(492, 35);
            this.labelNum8.TabIndex = 16;
            this.labelNum8.Text = "Пример 8";
            this.labelNum8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNum9
            // 
            this.labelNum9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum9.Location = new System.Drawing.Point(13, 500);
            this.labelNum9.Name = "labelNum9";
            this.labelNum9.Size = new System.Drawing.Size(492, 35);
            this.labelNum9.TabIndex = 17;
            this.labelNum9.Text = "Пример 9";
            this.labelNum9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNum10
            // 
            this.labelNum10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum10.Location = new System.Drawing.Point(14, 546);
            this.labelNum10.Name = "labelNum10";
            this.labelNum10.Size = new System.Drawing.Size(492, 35);
            this.labelNum10.TabIndex = 18;
            this.labelNum10.Text = "Пример 10";
            this.labelNum10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownM
            // 
            this.numericUpDownM.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownM.Location = new System.Drawing.Point(147, 41);
            this.numericUpDownM.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownM.Name = "numericUpDownM";
            this.numericUpDownM.Size = new System.Drawing.Size(63, 30);
            this.numericUpDownM.TabIndex = 19;
            this.numericUpDownM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownM.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownN.Location = new System.Drawing.Point(147, 79);
            this.numericUpDownN.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(63, 30);
            this.numericUpDownN.TabIndex = 20;
            this.numericUpDownN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownN.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // checkBoxUseFiler
            // 
            this.checkBoxUseFiler.BackColor = System.Drawing.SystemColors.Info;
            this.checkBoxUseFiler.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUseFiler.Location = new System.Drawing.Point(516, 140);
            this.checkBoxUseFiler.Name = "checkBoxUseFiler";
            this.checkBoxUseFiler.Size = new System.Drawing.Size(293, 35);
            this.checkBoxUseFiler.TabIndex = 25;
            this.checkBoxUseFiler.Text = "Использовать фильтры";
            this.checkBoxUseFiler.UseVisualStyleBackColor = false;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxFilter.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(515, 184);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(294, 169);
            this.comboBoxFilter.TabIndex = 26;
            this.comboBoxFilter.Visible = false;
            // 
            // buttonNewFilter
            // 
            this.buttonNewFilter.BackColor = System.Drawing.SystemColors.Info;
            this.buttonNewFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNewFilter.BackgroundImage")));
            this.buttonNewFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNewFilter.Location = new System.Drawing.Point(513, 361);
            this.buttonNewFilter.Name = "buttonNewFilter";
            this.buttonNewFilter.Size = new System.Drawing.Size(40, 40);
            this.buttonNewFilter.TabIndex = 27;
            this.buttonNewFilter.UseVisualStyleBackColor = false;
            this.buttonNewFilter.Visible = false;
            // 
            // buttonDeleteFilter
            // 
            this.buttonDeleteFilter.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDeleteFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeleteFilter.BackgroundImage")));
            this.buttonDeleteFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeleteFilter.Location = new System.Drawing.Point(564, 361);
            this.buttonDeleteFilter.Name = "buttonDeleteFilter";
            this.buttonDeleteFilter.Size = new System.Drawing.Size(40, 40);
            this.buttonDeleteFilter.TabIndex = 28;
            this.buttonDeleteFilter.UseVisualStyleBackColor = false;
            this.buttonDeleteFilter.Visible = false;
            // 
            // buttonEditFilter
            // 
            this.buttonEditFilter.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEditFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditFilter.BackgroundImage")));
            this.buttonEditFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEditFilter.Location = new System.Drawing.Point(615, 361);
            this.buttonEditFilter.Name = "buttonEditFilter";
            this.buttonEditFilter.Size = new System.Drawing.Size(40, 40);
            this.buttonEditFilter.TabIndex = 29;
            this.buttonEditFilter.UseVisualStyleBackColor = false;
            this.buttonEditFilter.Visible = false;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(663, 362);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(147, 39);
            this.buttonConfirm.TabIndex = 30;
            this.buttonConfirm.Text = "Подтвердить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Visible = false;
            // 
            // labelAboutFiltr
            // 
            this.labelAboutFiltr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAboutFiltr.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutFiltr.Location = new System.Drawing.Point(513, 409);
            this.labelAboutFiltr.Multiline = true;
            this.labelAboutFiltr.Name = "labelAboutFiltr";
            this.labelAboutFiltr.ReadOnly = true;
            this.labelAboutFiltr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.labelAboutFiltr.Size = new System.Drawing.Size(297, 177);
            this.labelAboutFiltr.TabIndex = 36;
            this.labelAboutFiltr.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 598);
            this.Controls.Add(this.labelAboutFiltr);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonEditFilter);
            this.Controls.Add(this.buttonDeleteFilter);
            this.Controls.Add(this.buttonNewFilter);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.checkBoxUseFiler);
            this.Controls.Add(this.numericUpDownN);
            this.Controls.Add(this.numericUpDownM);
            this.Controls.Add(this.labelNum10);
            this.Controls.Add(this.labelNum9);
            this.Controls.Add(this.labelNum8);
            this.Controls.Add(this.labelNum7);
            this.Controls.Add(this.labelNum6);
            this.Controls.Add(this.labelNum5);
            this.Controls.Add(this.labelNum4);
            this.Controls.Add(this.labelNum3);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.labelNum1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LabelFunction);
            this.Controls.Add(this.LabelN);
            this.Controls.Add(this.LabelM);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ButtonAnswers);
            this.Controls.Add(this.ButtonRandomize);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Генератор примеров";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonRandomize;
        private System.Windows.Forms.Button ButtonAnswers;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripButton toolStripButtonHow;
        private System.Windows.Forms.ToolStripButton toolStripButtonOptions;
        private System.Windows.Forms.ToolStripButton toolStripButtonVersion;
        private System.Windows.Forms.Label LabelM;
        private System.Windows.Forms.Label LabelN;
        private System.Windows.Forms.Label LabelFunction;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.Label labelNum3;
        private System.Windows.Forms.Label labelNum4;
        private System.Windows.Forms.Label labelNum5;
        private System.Windows.Forms.Label labelNum6;
        private System.Windows.Forms.Label labelNum7;
        private System.Windows.Forms.Label labelNum8;
        private System.Windows.Forms.Label labelNum9;
        private System.Windows.Forms.Label labelNum10;
        private System.Windows.Forms.NumericUpDown numericUpDownM;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.CheckBox checkBoxUseFiler;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button buttonNewFilter;
        private System.Windows.Forms.Button buttonDeleteFilter;
        private System.Windows.Forms.Button buttonEditFilter;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNotes;
        private System.Windows.Forms.TextBox labelAboutFiltr;
    }
}


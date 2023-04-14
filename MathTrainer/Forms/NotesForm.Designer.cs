namespace MathTrainer
{
    partial class NotesForm
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
            MainForm.NotesWasCreated = false;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesForm));
            this.labelNames = new System.Windows.Forms.Label();
            this.comboBoxNames = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new MathTrainer.RoundButton();
            this.buttonEdit = new MathTrainer.RoundButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelNote = new System.Windows.Forms.TextBox();
            this.buttonAdd = new MathTrainer.RoundButton();
            this.SuspendLayout();
            // 
            // labelNames
            // 
            this.labelNames.BackColor = System.Drawing.SystemColors.Info;
            this.labelNames.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNames.Location = new System.Drawing.Point(13, 13);
            this.labelNames.Name = "labelNames";
            this.labelNames.Size = new System.Drawing.Size(234, 35);
            this.labelNames.TabIndex = 0;
            this.labelNames.Text = "Перечень заметок";
            this.labelNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxNames
            // 
            this.comboBoxNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxNames.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNames.FormattingEnabled = true;
            this.comboBoxNames.Location = new System.Drawing.Point(13, 54);
            this.comboBoxNames.Name = "comboBoxNames";
            this.comboBoxNames.Size = new System.Drawing.Size(234, 377);
            this.comboBoxNames.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDelete.BackgroundImage")));
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.Location = new System.Drawing.Point(563, 11);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 80);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEdit.BackgroundImage")));
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit.Location = new System.Drawing.Point(662, 11);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(80, 80);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // labelNote
            // 
            this.labelNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNote.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNote.Font = new System.Drawing.Font("TF2 Secondary", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(263, 99);
            this.labelNote.Multiline = true;
            this.labelNote.Name = "labelNote";
            this.labelNote.ReadOnly = true;
            this.labelNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.labelNote.Size = new System.Drawing.Size(479, 332);
            this.labelNote.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdd.BackgroundImage")));
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.Location = new System.Drawing.Point(463, 11);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 80);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 453);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboBoxNames);
            this.Controls.Add(this.labelNames);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotesForm";
            this.Text = "Заметки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNames;
        private System.Windows.Forms.ComboBox comboBoxNames;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox labelNote;
        private RoundButton buttonAdd;
        private RoundButton buttonDelete;
        private RoundButton buttonEdit;
    }
}
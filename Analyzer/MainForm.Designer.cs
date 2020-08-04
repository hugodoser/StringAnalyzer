namespace Analyzer
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.richTextBoxIdentifiers = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTypes = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSizes = new System.Windows.Forms.RichTextBox();
            this.richTextBoxError = new System.Windows.Forms.RichTextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelAnalyze = new System.Windows.Forms.Label();
            this.labelIdentifiers = new System.Windows.Forms.Label();
            this.labelTypeOfIdentifier = new System.Windows.Forms.Label();
            this.labelValueOfMemory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput.Location = new System.Drawing.Point(109, 15);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(919, 61);
            this.textBoxInput.TabIndex = 0;
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnalyze.Location = new System.Drawing.Point(16, 84);
            this.buttonAnalyze.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(1013, 41);
            this.buttonAnalyze.TabIndex = 1;
            this.buttonAnalyze.Text = "ПРОВЕРКА";
            this.buttonAnalyze.UseVisualStyleBackColor = true;
            this.buttonAnalyze.Click += new System.EventHandler(this.buttonAnalyze_Click);
            // 
            // richTextBoxIdentifiers
            // 
            this.richTextBoxIdentifiers.Cursor = System.Windows.Forms.Cursors.Cross;
            this.richTextBoxIdentifiers.Location = new System.Drawing.Point(16, 225);
            this.richTextBoxIdentifiers.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxIdentifiers.Name = "richTextBoxIdentifiers";
            this.richTextBoxIdentifiers.ReadOnly = true;
            this.richTextBoxIdentifiers.Size = new System.Drawing.Size(319, 221);
            this.richTextBoxIdentifiers.TabIndex = 6;
            this.richTextBoxIdentifiers.TabStop = false;
            this.richTextBoxIdentifiers.Text = "";
            // 
            // richTextBoxTypes
            // 
            this.richTextBoxTypes.Cursor = System.Windows.Forms.Cursors.Cross;
            this.richTextBoxTypes.Location = new System.Drawing.Point(363, 225);
            this.richTextBoxTypes.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxTypes.Name = "richTextBoxTypes";
            this.richTextBoxTypes.ReadOnly = true;
            this.richTextBoxTypes.Size = new System.Drawing.Size(319, 221);
            this.richTextBoxTypes.TabIndex = 7;
            this.richTextBoxTypes.TabStop = false;
            this.richTextBoxTypes.Text = "";
            // 
            // richTextBoxSizes
            // 
            this.richTextBoxSizes.Cursor = System.Windows.Forms.Cursors.Cross;
            this.richTextBoxSizes.Location = new System.Drawing.Point(709, 225);
            this.richTextBoxSizes.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxSizes.Name = "richTextBoxSizes";
            this.richTextBoxSizes.ReadOnly = true;
            this.richTextBoxSizes.Size = new System.Drawing.Size(319, 221);
            this.richTextBoxSizes.TabIndex = 8;
            this.richTextBoxSizes.TabStop = false;
            this.richTextBoxSizes.Text = "";
            // 
            // richTextBoxError
            // 
            this.richTextBoxError.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxError.Location = new System.Drawing.Point(109, 132);
            this.richTextBoxError.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxError.Name = "richTextBoxError";
            this.richTextBoxError.ReadOnly = true;
            this.richTextBoxError.Size = new System.Drawing.Size(919, 61);
            this.richTextBoxError.TabIndex = 0;
            this.richTextBoxError.TabStop = false;
            this.richTextBoxError.Text = "";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(40, 36);
            this.labelInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(56, 17);
            this.labelInput.TabIndex = 9;
            this.labelInput.Text = "ВВОД: ";
            // 
            // labelAnalyze
            // 
            this.labelAnalyze.AutoSize = true;
            this.labelAnalyze.Location = new System.Drawing.Point(24, 158);
            this.labelAnalyze.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnalyze.Name = "labelAnalyze";
            this.labelAnalyze.Size = new System.Drawing.Size(73, 17);
            this.labelAnalyze.TabIndex = 10;
            this.labelAnalyze.Text = "АНАЛИЗ: ";
            // 
            // labelIdentifiers
            // 
            this.labelIdentifiers.AutoSize = true;
            this.labelIdentifiers.Location = new System.Drawing.Point(56, 206);
            this.labelIdentifiers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIdentifiers.Name = "labelIdentifiers";
            this.labelIdentifiers.Size = new System.Drawing.Size(240, 17);
            this.labelIdentifiers.TabIndex = 11;
            this.labelIdentifiers.Text = "ТАБЛИЦА ИДЕНТИФИКАТОРОВ : ";
            // 
            // labelTypeOfIdentifier
            // 
            this.labelTypeOfIdentifier.AutoSize = true;
            this.labelTypeOfIdentifier.Location = new System.Drawing.Point(421, 206);
            this.labelTypeOfIdentifier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTypeOfIdentifier.Name = "labelTypeOfIdentifier";
            this.labelTypeOfIdentifier.Size = new System.Drawing.Size(191, 17);
            this.labelTypeOfIdentifier.TabIndex = 12;
            this.labelTypeOfIdentifier.Text = "ТИП ИДЕНТИФИКАТОРА : ";
            // 
            // labelValueOfMemory
            // 
            this.labelValueOfMemory.AutoSize = true;
            this.labelValueOfMemory.Location = new System.Drawing.Point(735, 206);
            this.labelValueOfMemory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValueOfMemory.Name = "labelValueOfMemory";
            this.labelValueOfMemory.Size = new System.Drawing.Size(270, 17);
            this.labelValueOfMemory.TabIndex = 13;
            this.labelValueOfMemory.Text = "ОБЪЕМ ПАМЯТИ ПОД ПЕРЕМЕННУЮ :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 457);
            this.Controls.Add(this.labelValueOfMemory);
            this.Controls.Add(this.labelTypeOfIdentifier);
            this.Controls.Add(this.labelIdentifiers);
            this.Controls.Add(this.labelAnalyze);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.richTextBoxError);
            this.Controls.Add(this.richTextBoxSizes);
            this.Controls.Add(this.richTextBoxTypes);
            this.Controls.Add(this.richTextBoxIdentifiers);
            this.Controls.Add(this.buttonAnalyze);
            this.Controls.Add(this.textBoxInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "АНАЛИЗАТОР. ВАРИАНТ 11. ЕЛФИМОВ А.Г. 6303";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.RichTextBox richTextBoxIdentifiers;
        private System.Windows.Forms.RichTextBox richTextBoxTypes;
        private System.Windows.Forms.RichTextBox richTextBoxSizes;
        private System.Windows.Forms.RichTextBox richTextBoxError;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelAnalyze;
        private System.Windows.Forms.Label labelIdentifiers;
        private System.Windows.Forms.Label labelTypeOfIdentifier;
        private System.Windows.Forms.Label labelValueOfMemory;
    }
}


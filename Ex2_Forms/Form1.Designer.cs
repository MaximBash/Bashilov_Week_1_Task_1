namespace Ex2_Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-6, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите трехзначное число число:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(169, 6);
            this.NumberTextBox.MaxLength = 4;
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberTextBox.TabIndex = 4;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(12, 65);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Узнать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 100);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Button CalculateButton;
    }
}


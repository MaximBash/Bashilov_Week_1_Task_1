namespace Ex1_Forms
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
            this.label2 = new System.Windows.Forms.Label();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.PTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите длину окружности и нажмите Enter:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Радиус окружности равен:";
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(282, 70);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(0, 13);
            this.AreaLabel.TabIndex = 3;
            // 
            // PTextBox
            // 
            this.PTextBox.Location = new System.Drawing.Point(285, 24);
            this.PTextBox.Name = "PTextBox";
            this.PTextBox.Size = new System.Drawing.Size(100, 20);
            this.PTextBox.TabIndex = 4;
            this.PTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PTextBox_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 122);
            this.Controls.Add(this.PTextBox);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.TextBox PTextBox;
    }
}


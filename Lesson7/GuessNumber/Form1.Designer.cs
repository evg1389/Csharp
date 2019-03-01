namespace GuessNumber
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
            this.lbT1 = new System.Windows.Forms.Label();
            this.lbT2 = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.lbT3 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.butEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbT1
            // 
            this.lbT1.AutoSize = true;
            this.lbT1.Location = new System.Drawing.Point(10, 19);
            this.lbT1.Name = "lbT1";
            this.lbT1.Size = new System.Drawing.Size(148, 13);
            this.lbT1.TabIndex = 0;
            this.lbT1.Text = "Пк загодал число угодайте!";
            // 
            // lbT2
            // 
            this.lbT2.AutoSize = true;
            this.lbT2.Location = new System.Drawing.Point(164, 19);
            this.lbT2.Name = "lbT2";
            this.lbT2.Size = new System.Drawing.Size(98, 13);
            this.lbT2.TabIndex = 1;
            this.lbT2.Text = "Число от 0 до 100";
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(167, 61);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(79, 20);
            this.tbNum.TabIndex = 2;
            
            // 
            // lbT3
            // 
            this.lbT3.AutoSize = true;
            this.lbT3.Location = new System.Drawing.Point(10, 61);
            this.lbT3.Name = "lbT3";
            this.lbT3.Size = new System.Drawing.Size(119, 13);
            this.lbT3.TabIndex = 3;
            this.lbT3.Text = "Поле для ввода числа";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(164, 108);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(35, 13);
            this.lbCount.TabIndex = 4;
            this.lbCount.Text = "label4";
            // 
            // butEnter
            // 
            this.butEnter.Location = new System.Drawing.Point(275, 61);
            this.butEnter.Name = "butEnter";
            this.butEnter.Size = new System.Drawing.Size(66, 60);
            this.butEnter.TabIndex = 5;
            this.butEnter.Text = "Принять ответ";
            this.butEnter.UseVisualStyleBackColor = true;
            this.butEnter.Click += new System.EventHandler(this.butEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 136);
            this.Controls.Add(this.butEnter);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.lbT3);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.lbT2);
            this.Controls.Add(this.lbT1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbT1;
        private System.Windows.Forms.Label lbT2;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label lbT3;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Button butEnter;
    }
}


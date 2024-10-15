namespace WindowsFormsApp5
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
            this.btnGenerateArray = new System.Windows.Forms.Button();
            this.btnSortArray = new System.Windows.Forms.Button();
            this.chkUseCriticalSections = new System.Windows.Forms.CheckBox();
            this.txtGeneratedArray = new System.Windows.Forms.TextBox();
            this.txtSortedArray = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateArray
            // 
            this.btnGenerateArray.BackColor = System.Drawing.Color.Gold;
            this.btnGenerateArray.Location = new System.Drawing.Point(605, 235);
            this.btnGenerateArray.Name = "btnGenerateArray";
            this.btnGenerateArray.Size = new System.Drawing.Size(176, 45);
            this.btnGenerateArray.TabIndex = 0;
            this.btnGenerateArray.Text = "Инициализировать массив";
            this.btnGenerateArray.UseVisualStyleBackColor = false;
            this.btnGenerateArray.Click += new System.EventHandler(this.btnGenerateArray_Click_1);
            // 
            // btnSortArray
            // 
            this.btnSortArray.BackColor = System.Drawing.Color.Lime;
            this.btnSortArray.Location = new System.Drawing.Point(787, 235);
            this.btnSortArray.Name = "btnSortArray";
            this.btnSortArray.Size = new System.Drawing.Size(176, 45);
            this.btnSortArray.TabIndex = 1;
            this.btnSortArray.Text = "Выполнить сортировку";
            this.btnSortArray.UseVisualStyleBackColor = false;
            this.btnSortArray.Click += new System.EventHandler(this.btnSortArray_Click);
            // 
            // chkUseCriticalSections
            // 
            this.chkUseCriticalSections.AutoSize = true;
            this.chkUseCriticalSections.BackColor = System.Drawing.Color.Transparent;
            this.chkUseCriticalSections.Location = new System.Drawing.Point(22, 84);
            this.chkUseCriticalSections.Name = "chkUseCriticalSections";
            this.chkUseCriticalSections.Size = new System.Drawing.Size(205, 17);
            this.chkUseCriticalSections.TabIndex = 2;
            this.chkUseCriticalSections.Text = "Использовать критические секции";
            this.chkUseCriticalSections.UseVisualStyleBackColor = false;
            // 
            // txtGeneratedArray
            // 
            this.txtGeneratedArray.Location = new System.Drawing.Point(16, 22);
            this.txtGeneratedArray.Name = "txtGeneratedArray";
            this.txtGeneratedArray.Size = new System.Drawing.Size(529, 20);
            this.txtGeneratedArray.TabIndex = 4;
            this.txtGeneratedArray.Text = "Оригинальный массив";
            // 
            // txtSortedArray
            // 
            this.txtSortedArray.Location = new System.Drawing.Point(16, 59);
            this.txtSortedArray.Multiline = true;
            this.txtSortedArray.Name = "txtSortedArray";
            this.txtSortedArray.Size = new System.Drawing.Size(529, 159);
            this.txtSortedArray.TabIndex = 5;
            this.txtSortedArray.Text = "Отсортированные массивы";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.chkUseCriticalSections);
            this.panel1.Location = new System.Drawing.Point(605, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 185);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.txtSortedArray);
            this.panel2.Controls.Add(this.txtGeneratedArray);
            this.panel2.Location = new System.Drawing.Point(12, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 236);
            this.panel2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 322);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSortArray);
            this.Controls.Add(this.btnGenerateArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateArray;
        private System.Windows.Forms.Button btnSortArray;
        private System.Windows.Forms.CheckBox chkUseCriticalSections;
        private System.Windows.Forms.TextBox txtGeneratedArray;
        private System.Windows.Forms.TextBox txtSortedArray;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}


namespace l6
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
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.rtxtSecond = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtHours.Location = new System.Drawing.Point(180, 4);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(158, 25);
            this.txtHours.TabIndex = 0;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtMinutes.Location = new System.Drawing.Point(180, 38);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(158, 25);
            this.txtMinutes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введіть години";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU-ExtB", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введіть хвилини";
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("MingLiU-ExtB", 15F, System.Drawing.FontStyle.Bold);
            this.btnConvert.Location = new System.Drawing.Point(199, 242);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(139, 47);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Обрахувати";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // rtxtSecond
            // 
            this.rtxtSecond.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold);
            this.rtxtSecond.Location = new System.Drawing.Point(16, 69);
            this.rtxtSecond.Name = "rtxtSecond";
            this.rtxtSecond.Size = new System.Drawing.Size(322, 148);
            this.rtxtSecond.TabIndex = 6;
            this.rtxtSecond.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 307);
            this.Controls.Add(this.rtxtSecond);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtHours);
            this.Name = "Form1";
            this.Text = "Лабораторна шоста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RichTextBox rtxtSecond;
    }
}


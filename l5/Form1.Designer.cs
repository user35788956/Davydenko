namespace l5
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
            this.txtString = new System.Windows.Forms.TextBox();
            this.rtxtString = new System.Windows.Forms.RichTextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtString
            // 
            this.txtString.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtString.Location = new System.Drawing.Point(148, 6);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(214, 25);
            this.txtString.TabIndex = 0;
            // 
            // rtxtString
            // 
            this.rtxtString.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F);
            this.rtxtString.Location = new System.Drawing.Point(15, 37);
            this.rtxtString.Name = "rtxtString";
            this.rtxtString.Size = new System.Drawing.Size(347, 79);
            this.rtxtString.TabIndex = 1;
            this.rtxtString.Text = "";
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F);
            this.btnGo.Location = new System.Drawing.Point(15, 193);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(91, 29);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Виконати";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Початковий рядок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F);
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Стартова позиція для видалення";
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F);
            this.txtStart.Location = new System.Drawing.Point(245, 150);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(117, 25);
            this.txtStart.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F);
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Довжина для видалення";
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F);
            this.txtLength.Location = new System.Drawing.Point(195, 119);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(167, 25);
            this.txtLength.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 238);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.rtxtString);
            this.Controls.Add(this.txtString);
            this.Name = "Form1";
            this.Text = "Лабораторна п\'ята";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.RichTextBox rtxtString;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLength;
    }
}


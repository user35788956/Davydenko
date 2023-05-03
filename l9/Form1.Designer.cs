namespace l9
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
            this.graphicDraw = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.PTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graphicDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // graphicDraw
            // 
            this.graphicDraw.Location = new System.Drawing.Point(12, 12);
            this.graphicDraw.Name = "graphicDraw";
            this.graphicDraw.Size = new System.Drawing.Size(408, 284);
            this.graphicDraw.TabIndex = 0;
            this.graphicDraw.TabStop = false;
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDraw.Location = new System.Drawing.Point(272, 307);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(148, 35);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Намалювати";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // PTextBox
            // 
            this.PTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PTextBox.Location = new System.Drawing.Point(144, 309);
            this.PTextBox.Name = "PTextBox";
            this.PTextBox.Size = new System.Drawing.Size(100, 30);
            this.PTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Значення р";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PTextBox);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.graphicDraw);
            this.Name = "Form1";
            this.Text = "Лабораторна дев\'ята";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graphicDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox graphicDraw;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox PTextBox;
        private System.Windows.Forms.Label label1;
    }
}


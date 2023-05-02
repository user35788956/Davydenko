namespace l3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAmount = new TextBox();
            btnConvert = new Button();
            dollarsRadioButton = new RadioButton();
            eurosRadioButton = new RadioButton();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(12, 52);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(177, 32);
            txtAmount.TabIndex = 0;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvert.Location = new Point(12, 210);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(177, 40);
            btnConvert.TabIndex = 1;
            btnConvert.Text = "Конвертувати";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // dollarsRadioButton
            // 
            dollarsRadioButton.AutoSize = true;
            dollarsRadioButton.Location = new Point(6, 23);
            dollarsRadioButton.Name = "dollarsRadioButton";
            dollarsRadioButton.Size = new Size(78, 28);
            dollarsRadioButton.TabIndex = 3;
            dollarsRadioButton.TabStop = true;
            dollarsRadioButton.Text = "Долари";
            dollarsRadioButton.UseVisualStyleBackColor = true;
            // 
            // eurosRadioButton
            // 
            eurosRadioButton.AutoSize = true;
            eurosRadioButton.Location = new Point(6, 57);
            eurosRadioButton.Name = "eurosRadioButton";
            eurosRadioButton.Size = new Size(60, 28);
            eurosRadioButton.TabIndex = 4;
            eurosRadioButton.TabStop = true;
            eurosRadioButton.Text = "Євро";
            eurosRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(177, 24);
            label1.TabIndex = 5;
            label1.Text = "Введіть кількість грошей";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dollarsRadioButton);
            groupBox1.Controls.Add(eurosRadioButton);
            groupBox1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(177, 102);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Валюти";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(212, 272);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnConvert);
            Controls.Add(txtAmount);
            Name = "Form1";
            Text = "Лабораторна третя";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtAmount;
        private Button btnConvert;
        private RadioButton dollarsRadioButton;
        private RadioButton eurosRadioButton;
        private Label label1;
        private GroupBox groupBox1;
    }
}
namespace l4
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
            ritxtResult = new RichTextBox();
            txtN = new TextBox();
            txtC = new TextBox();
            rbtnTaskFirst = new RadioButton();
            rbtnTaskSecond = new RadioButton();
            btnCalc = new Button();
            txtV = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // ritxtResult
            // 
            ritxtResult.Location = new Point(12, 12);
            ritxtResult.Name = "ritxtResult";
            ritxtResult.Size = new Size(287, 208);
            ritxtResult.TabIndex = 0;
            ritxtResult.Text = "";
            // 
            // txtN
            // 
            txtN.Location = new Point(305, 33);
            txtN.Name = "txtN";
            txtN.Size = new Size(100, 23);
            txtN.TabIndex = 1;
            txtN.KeyPress += txtN_KeyPress;
            // 
            // txtC
            // 
            txtC.Location = new Point(305, 88);
            txtC.Name = "txtC";
            txtC.Size = new Size(100, 23);
            txtC.TabIndex = 2;
            txtC.KeyPress += txtC_KeyPress;
            // 
            // rbtnTaskFirst
            // 
            rbtnTaskFirst.AutoSize = true;
            rbtnTaskFirst.Location = new Point(12, 226);
            rbtnTaskFirst.Name = "rbtnTaskFirst";
            rbtnTaskFirst.Size = new Size(116, 19);
            rbtnTaskFirst.TabIndex = 3;
            rbtnTaskFirst.TabStop = true;
            rbtnTaskFirst.Text = "Перше завдання";
            rbtnTaskFirst.UseVisualStyleBackColor = true;
            rbtnTaskFirst.CheckedChanged += rbtnTaskFirst_CheckedChanged;
            // 
            // rbtnTaskSecond
            // 
            rbtnTaskSecond.AutoSize = true;
            rbtnTaskSecond.Location = new Point(128, 226);
            rbtnTaskSecond.Name = "rbtnTaskSecond";
            rbtnTaskSecond.Size = new Size(109, 19);
            rbtnTaskSecond.TabIndex = 4;
            rbtnTaskSecond.TabStop = true;
            rbtnTaskSecond.Text = "Друге завдання";
            rbtnTaskSecond.UseVisualStyleBackColor = true;
            rbtnTaskSecond.CheckedChanged += rbtnTaskSecond_CheckedChanged;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(12, 262);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "Виконати";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // txtV
            // 
            txtV.Location = new Point(305, 152);
            txtV.Name = "txtV";
            txtV.Size = new Size(100, 23);
            txtV.TabIndex = 6;
            txtV.KeyPress += txtV_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 15);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 70);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 124);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 298);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtV);
            Controls.Add(btnCalc);
            Controls.Add(rbtnTaskSecond);
            Controls.Add(rbtnTaskFirst);
            Controls.Add(txtC);
            Controls.Add(txtN);
            Controls.Add(ritxtResult);
            Name = "Form1";
            Text = "Лабораторна четверта";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox ritxtResult;
        private TextBox txtN;
        private TextBox txtC;
        private RadioButton rbtnTaskFirst;
        private RadioButton rbtnTaskSecond;
        private Button btnCalc;
        private TextBox txtV;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
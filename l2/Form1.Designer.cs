namespace l2
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
            rtxtList = new RichTextBox();
            btnAdd = new Button();
            btnDel = new Button();
            btnDelAll = new Button();
            btnFrom = new Button();
            txtString = new TextBox();
            btnEnd = new Button();
            SuspendLayout();
            // 
            // rtxtList
            // 
            rtxtList.Font = new Font("Thames", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rtxtList.Location = new Point(12, 61);
            rtxtList.Name = "rtxtList";
            rtxtList.Size = new Size(329, 150);
            rtxtList.TabIndex = 0;
            rtxtList.Text = "";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Window;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(12, 232);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 33);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = SystemColors.Window;
            btnDel.FlatAppearance.BorderSize = 0;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Location = new Point(133, 232);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(89, 33);
            btnDel.TabIndex = 2;
            btnDel.Text = "Видалити";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnDelAll
            // 
            btnDelAll.BackColor = SystemColors.Window;
            btnDelAll.FlatAppearance.BorderSize = 0;
            btnDelAll.FlatStyle = FlatStyle.Flat;
            btnDelAll.Location = new Point(252, 232);
            btnDelAll.Name = "btnDelAll";
            btnDelAll.Size = new Size(89, 33);
            btnDelAll.TabIndex = 3;
            btnDelAll.Text = "Видалити все";
            btnDelAll.UseVisualStyleBackColor = false;
            btnDelAll.Click += btnDelAll_Click;
            // 
            // btnFrom
            // 
            btnFrom.BackColor = SystemColors.Window;
            btnFrom.FlatAppearance.BorderSize = 0;
            btnFrom.FlatStyle = FlatStyle.Flat;
            btnFrom.Location = new Point(12, 282);
            btnFrom.Name = "btnFrom";
            btnFrom.Size = new Size(147, 33);
            btnFrom.TabIndex = 4;
            btnFrom.Text = "Видалити починаючи з";
            btnFrom.UseVisualStyleBackColor = false;
            btnFrom.Click += btnFrom_Click;
            // 
            // txtString
            // 
            txtString.Font = new Font("Thames", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtString.Location = new Point(12, 23);
            txtString.Name = "txtString";
            txtString.Size = new Size(329, 24);
            txtString.TabIndex = 5;
            txtString.Text = "введіть слово з яким будете проводити дії";
            txtString.Click += txtString_Click;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = SystemColors.Window;
            btnEnd.FlatAppearance.BorderSize = 0;
            btnEnd.FlatStyle = FlatStyle.Flat;
            btnEnd.Location = new Point(194, 282);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(147, 33);
            btnEnd.TabIndex = 6;
            btnEnd.Text = "Видалити останній";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(353, 327);
            Controls.Add(btnEnd);
            Controls.Add(txtString);
            Controls.Add(btnFrom);
            Controls.Add(btnDelAll);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(rtxtList);
            Name = "Form1";
            Text = "Лабораторна друга";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtxtList;
        private Button btnAdd;
        private Button btnDel;
        private Button btnDelAll;
        private Button btnFrom;
        private TextBox txtString;
        private Button btnEnd;
    }
}
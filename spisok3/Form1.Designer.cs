namespace spisok3
{
    partial class Spisok
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
            txtNumber = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            listBoxNumbers = new ListBox();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.BackColor = Color.Turquoise;
            txtNumber.Cursor = Cursors.Cross;
            txtNumber.Location = new Point(329, 44);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(119, 23);
            txtNumber.TabIndex = 0;
            txtNumber.TextChanged += txtNumber_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(354, 93);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "добавить числа";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(354, 154);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Удалить (дробная > 0.5)";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // listBoxNumbers
            // 
            listBoxNumbers.FormattingEnabled = true;
            listBoxNumbers.ItemHeight = 15;
            listBoxNumbers.Location = new Point(66, 44);
            listBoxNumbers.Name = "listBoxNumbers";
            listBoxNumbers.Size = new Size(196, 214);
            listBoxNumbers.TabIndex = 3;
            listBoxNumbers.SelectedIndexChanged += listBoxNumbers_SelectedIndexChanged;
            // 
            // Spisok
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxNumbers);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtNumber);
            Name = "Spisok";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber;
        private Button btnAdd;
        private Button btnRemove;
        private ListBox listBoxNumbers;
    }
}

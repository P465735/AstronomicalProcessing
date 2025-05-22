namespace AstronomicalProcessing
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
            listBox1 = new ListBox();
            searchButton = new Button();
            sortButton = new Button();
            searchBox = new TextBox();
            editBox = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(281, 334);
            listBox1.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(299, 70);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(100, 23);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            sortButton.Location = new Point(299, 99);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(100, 23);
            sortButton.TabIndex = 2;
            sortButton.Text = "Sort";
            sortButton.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(299, 41);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(100, 23);
            searchBox.TabIndex = 3;
            searchBox.Text = "Search";
            // 
            // editBox
            // 
            editBox.Location = new Point(299, 12);
            editBox.Name = "editBox";
            editBox.Size = new Size(100, 23);
            editBox.TabIndex = 4;
            editBox.Text = "Edit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 393);
            Controls.Add(editBox);
            Controls.Add(searchBox);
            Controls.Add(sortButton);
            Controls.Add(searchButton);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button searchButton;
        private Button sortButton;
        private TextBox searchBox;
        private TextBox editBox;
    }
}

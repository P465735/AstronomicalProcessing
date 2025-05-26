namespace AstronomicalProcessing
{
    partial class AstronomicalProcessing
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
            DataListBox = new ListBox();
            SearchButton = new Button();
            SearchBox = new TextBox();
            EditBox = new TextBox();
            SortButton = new Button();
            EditLabel = new Label();
            SearchLabel = new Label();
            SaveButton = new Button();
            LoadButton = new Button();
            SuspendLayout();
            // 
            // DataListBox
            // 
            DataListBox.FormattingEnabled = true;
            DataListBox.ItemHeight = 15;
            DataListBox.Location = new Point(12, 12);
            DataListBox.Name = "DataListBox";
            DataListBox.Size = new Size(281, 334);
            DataListBox.TabIndex = 0;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(299, 123);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(104, 23);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(299, 94);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(104, 23);
            SearchBox.TabIndex = 3;
            // 
            // EditBox
            // 
            EditBox.Location = new Point(299, 176);
            EditBox.Name = "EditBox";
            EditBox.Size = new Size(104, 23);
            EditBox.TabIndex = 4;
            // 
            // SortButton
            // 
            SortButton.Location = new Point(299, 41);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(104, 23);
            SortButton.TabIndex = 5;
            SortButton.Text = "Sort Data";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // EditLabel
            // 
            EditLabel.AutoSize = true;
            EditLabel.ForeColor = SystemColors.ControlText;
            EditLabel.Location = new Point(299, 158);
            EditLabel.Name = "EditLabel";
            EditLabel.Size = new Size(108, 15);
            EditLabel.TabIndex = 6;
            EditLabel.Text = "Edit Selected Value:";
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Location = new Point(299, 76);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(104, 15);
            SearchLabel.TabIndex = 7;
            SearchLabel.Text = "Enter Search Term:";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(299, 205);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(104, 23);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(299, 12);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(104, 23);
            LoadButton.TabIndex = 9;
            LoadButton.Text = "Load Data";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // AstronomicalProcessing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 357);
            Controls.Add(LoadButton);
            Controls.Add(SaveButton);
            Controls.Add(SearchLabel);
            Controls.Add(EditLabel);
            Controls.Add(SortButton);
            Controls.Add(EditBox);
            Controls.Add(SearchBox);
            Controls.Add(SearchButton);
            Controls.Add(DataListBox);
            Name = "AstronomicalProcessing";
            Text = "Astronomical Processing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox DataListBox;
        private Button SearchButton;
        private TextBox SearchBox;
        private TextBox EditBox;
        private Button SortButton;
        private Label EditLabel;
        private Label SearchLabel;
        private Button SaveButton;
        private Button LoadButton;
    }
}

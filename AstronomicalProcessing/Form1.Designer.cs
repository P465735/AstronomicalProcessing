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
            components = new System.ComponentModel.Container();
            DataListBox = new ListBox();
            BinarySearchButton = new Button();
            SearchBox = new TextBox();
            EditBox = new TextBox();
            SortButton = new Button();
            EditLabel = new Label();
            SearchLabel = new Label();
            SaveButton = new Button();
            LoadButton = new Button();
            MidExtremeButton = new Button();
            ModeButton = new Button();
            MeanButton = new Button();
            RangeButton = new Button();
            SequentialSearchButton = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // DataListBox
            // 
            DataListBox.FormattingEnabled = true;
            DataListBox.ItemHeight = 15;
            DataListBox.Location = new Point(12, 12);
            DataListBox.Name = "DataListBox";
            DataListBox.Size = new Size(281, 394);
            DataListBox.TabIndex = 0;
            toolTip1.SetToolTip(DataListBox, "Displays the currently loaded neutrino data");
            // 
            // BinarySearchButton
            // 
            BinarySearchButton.Location = new Point(299, 152);
            BinarySearchButton.Name = "BinarySearchButton";
            BinarySearchButton.Size = new Size(113, 23);
            BinarySearchButton.TabIndex = 1;
            BinarySearchButton.Text = "Binary Search";
            toolTip1.SetToolTip(BinarySearchButton, "Search the current data for the value in the search box using a binary search (data must be sorted first)");
            BinarySearchButton.UseVisualStyleBackColor = true;
            BinarySearchButton.Click += BinarySearchButton_Click;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(299, 94);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(113, 23);
            SearchBox.TabIndex = 3;
            // 
            // EditBox
            // 
            EditBox.Location = new Point(299, 205);
            EditBox.Name = "EditBox";
            EditBox.Size = new Size(113, 23);
            EditBox.TabIndex = 4;
            // 
            // SortButton
            // 
            SortButton.Location = new Point(299, 41);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(113, 23);
            SortButton.TabIndex = 5;
            SortButton.Text = "Sort Data";
            toolTip1.SetToolTip(SortButton, "Sort the current neutrino data from lowest to highest");
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // EditLabel
            // 
            EditLabel.AutoSize = true;
            EditLabel.ForeColor = SystemColors.ControlText;
            EditLabel.Location = new Point(299, 187);
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
            SaveButton.Location = new Point(299, 234);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(113, 23);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            toolTip1.SetToolTip(SaveButton, "Replace the currently selected neutrino value with the value in the edit box");
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(299, 12);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(113, 23);
            LoadButton.TabIndex = 9;
            LoadButton.Text = "Load Data";
            toolTip1.SetToolTip(LoadButton, "Load new neutrino data");
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // MidExtremeButton
            // 
            MidExtremeButton.Location = new Point(299, 296);
            MidExtremeButton.Name = "MidExtremeButton";
            MidExtremeButton.Size = new Size(113, 23);
            MidExtremeButton.TabIndex = 10;
            MidExtremeButton.Text = "Find Mid-Extreme";
            toolTip1.SetToolTip(MidExtremeButton, "Calculate and display the mid-extreme of the current data");
            MidExtremeButton.UseVisualStyleBackColor = true;
            MidExtremeButton.Click += MidExtremeButton_Click;
            // 
            // ModeButton
            // 
            ModeButton.Location = new Point(299, 325);
            ModeButton.Name = "ModeButton";
            ModeButton.Size = new Size(113, 23);
            ModeButton.TabIndex = 11;
            ModeButton.Text = "Find Mode";
            toolTip1.SetToolTip(ModeButton, "Calculate and display the mode of the current data");
            ModeButton.UseVisualStyleBackColor = true;
            ModeButton.Click += ModeButton_Click;
            // 
            // MeanButton
            // 
            MeanButton.Location = new Point(299, 354);
            MeanButton.Name = "MeanButton";
            MeanButton.Size = new Size(113, 23);
            MeanButton.TabIndex = 12;
            MeanButton.Text = "Find Mean";
            toolTip1.SetToolTip(MeanButton, "Calculate and display the mean of the current data");
            MeanButton.UseVisualStyleBackColor = true;
            MeanButton.Click += MeanButton_Click;
            // 
            // RangeButton
            // 
            RangeButton.Location = new Point(299, 383);
            RangeButton.Name = "RangeButton";
            RangeButton.Size = new Size(113, 23);
            RangeButton.TabIndex = 13;
            RangeButton.Text = "Find Range";
            toolTip1.SetToolTip(RangeButton, "Calculate and display the mean of the current data");
            RangeButton.UseVisualStyleBackColor = true;
            RangeButton.Click += RangeButton_Click;
            // 
            // SequentialSearchButton
            // 
            SequentialSearchButton.Location = new Point(299, 123);
            SequentialSearchButton.Name = "SequentialSearchButton";
            SequentialSearchButton.Size = new Size(113, 23);
            SequentialSearchButton.TabIndex = 14;
            SequentialSearchButton.Text = "Sequential Search";
            toolTip1.SetToolTip(SequentialSearchButton, "Search the current data for the value in the search box using a sequential search");
            SequentialSearchButton.UseVisualStyleBackColor = true;
            SequentialSearchButton.Click += SequentialSearchButton_Click;
            // 
            // AstronomicalProcessing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 417);
            Controls.Add(SequentialSearchButton);
            Controls.Add(RangeButton);
            Controls.Add(MeanButton);
            Controls.Add(ModeButton);
            Controls.Add(MidExtremeButton);
            Controls.Add(LoadButton);
            Controls.Add(SaveButton);
            Controls.Add(SearchLabel);
            Controls.Add(EditLabel);
            Controls.Add(SortButton);
            Controls.Add(EditBox);
            Controls.Add(SearchBox);
            Controls.Add(BinarySearchButton);
            Controls.Add(DataListBox);
            Name = "AstronomicalProcessing";
            Text = "Astronomical Processing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox DataListBox;
        private Button BinarySearchButton;
        private TextBox SearchBox;
        private TextBox EditBox;
        private Button SortButton;
        private Label EditLabel;
        private Label SearchLabel;
        private Button SaveButton;
        private Button LoadButton;
        private Button MidExtremeButton;
        private Button ModeButton;
        private Button MeanButton;
        private Button RangeButton;
        private Button SequentialSearchButton;
        private ToolTip toolTip1;
    }
}

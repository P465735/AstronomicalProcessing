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
            SaveButton = new Button();
            LoadButton = new Button();
            MidExtremeButton = new Button();
            ModeButton = new Button();
            MeanButton = new Button();
            RangeButton = new Button();
            SequentialSearchButton = new Button();
            toolTip1 = new ToolTip(components);
            MidExtremeBox = new TextBox();
            ModeBox = new TextBox();
            MeanBox = new TextBox();
            RangeBox = new TextBox();
            SuspendLayout();
            // 
            // DataListBox
            // 
            DataListBox.FormattingEnabled = true;
            DataListBox.ItemHeight = 15;
            DataListBox.Location = new Point(12, 12);
            DataListBox.Name = "DataListBox";
            DataListBox.Size = new Size(180, 259);
            DataListBox.TabIndex = 0;
            toolTip1.SetToolTip(DataListBox, "Displays the currently loaded neutrino data");
            // 
            // BinarySearchButton
            // 
            BinarySearchButton.Location = new Point(198, 114);
            BinarySearchButton.Name = "BinarySearchButton";
            BinarySearchButton.Size = new Size(120, 23);
            BinarySearchButton.TabIndex = 1;
            BinarySearchButton.Text = "Binary Search";
            toolTip1.SetToolTip(BinarySearchButton, "Search the current data for the value in the search box using a binary search (data must be sorted first)");
            BinarySearchButton.UseVisualStyleBackColor = true;
            BinarySearchButton.Click += BinarySearchButton_Click;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(198, 56);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Enter search term";
            SearchBox.Size = new Size(120, 23);
            SearchBox.TabIndex = 3;
            // 
            // EditBox
            // 
            EditBox.Location = new Point(324, 56);
            EditBox.Name = "EditBox";
            EditBox.PlaceholderText = "Edit selected value";
            EditBox.Size = new Size(120, 23);
            EditBox.TabIndex = 4;
            // 
            // SortButton
            // 
            SortButton.Location = new Point(324, 13);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(120, 23);
            SortButton.TabIndex = 5;
            SortButton.Text = "Sort Data";
            toolTip1.SetToolTip(SortButton, "Sort the current neutrino data from lowest to highest");
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(324, 85);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(120, 23);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            toolTip1.SetToolTip(SaveButton, "Replace the currently selected neutrino value with the value in the edit box");
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(198, 12);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(120, 23);
            LoadButton.TabIndex = 9;
            LoadButton.Text = "Load Data";
            toolTip1.SetToolTip(LoadButton, "Load new neutrino data");
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // MidExtremeButton
            // 
            MidExtremeButton.Location = new Point(198, 160);
            MidExtremeButton.Name = "MidExtremeButton";
            MidExtremeButton.Size = new Size(120, 23);
            MidExtremeButton.TabIndex = 10;
            MidExtremeButton.Text = "Find Mid-extreme";
            toolTip1.SetToolTip(MidExtremeButton, "Calculate and display the mid-extreme of the current data");
            MidExtremeButton.UseVisualStyleBackColor = true;
            MidExtremeButton.Click += MidExtremeButton_Click;
            // 
            // ModeButton
            // 
            ModeButton.Location = new Point(198, 189);
            ModeButton.Name = "ModeButton";
            ModeButton.Size = new Size(120, 23);
            ModeButton.TabIndex = 11;
            ModeButton.Text = "Find Mode";
            toolTip1.SetToolTip(ModeButton, "Calculate and display the mode of the current data");
            ModeButton.UseVisualStyleBackColor = true;
            ModeButton.Click += ModeButton_Click;
            // 
            // MeanButton
            // 
            MeanButton.Location = new Point(198, 218);
            MeanButton.Name = "MeanButton";
            MeanButton.Size = new Size(120, 23);
            MeanButton.TabIndex = 12;
            MeanButton.Text = "Find Mean";
            toolTip1.SetToolTip(MeanButton, "Calculate and display the mean of the current data");
            MeanButton.UseVisualStyleBackColor = true;
            MeanButton.Click += MeanButton_Click;
            // 
            // RangeButton
            // 
            RangeButton.Location = new Point(198, 248);
            RangeButton.Name = "RangeButton";
            RangeButton.Size = new Size(120, 23);
            RangeButton.TabIndex = 13;
            RangeButton.Text = "Find Range";
            toolTip1.SetToolTip(RangeButton, "Calculate and display the mean of the current data");
            RangeButton.UseVisualStyleBackColor = true;
            RangeButton.Click += RangeButton_Click;
            // 
            // SequentialSearchButton
            // 
            SequentialSearchButton.Location = new Point(198, 85);
            SequentialSearchButton.Name = "SequentialSearchButton";
            SequentialSearchButton.Size = new Size(120, 23);
            SequentialSearchButton.TabIndex = 14;
            SequentialSearchButton.Text = "Sequential Search";
            toolTip1.SetToolTip(SequentialSearchButton, "Search the current data for the value in the search box using a sequential search");
            SequentialSearchButton.UseVisualStyleBackColor = true;
            SequentialSearchButton.Click += SequentialSearchButton_Click;
            // 
            // MidExtremeBox
            // 
            MidExtremeBox.Location = new Point(324, 160);
            MidExtremeBox.Name = "MidExtremeBox";
            MidExtremeBox.ReadOnly = true;
            MidExtremeBox.Size = new Size(120, 23);
            MidExtremeBox.TabIndex = 15;
            toolTip1.SetToolTip(MidExtremeBox, "Displays the calculated mid-extreme of the data");
            // 
            // ModeBox
            // 
            ModeBox.Location = new Point(324, 189);
            ModeBox.Name = "ModeBox";
            ModeBox.ReadOnly = true;
            ModeBox.Size = new Size(120, 23);
            ModeBox.TabIndex = 16;
            toolTip1.SetToolTip(ModeBox, "Displays the calculated mode of the data");
            // 
            // MeanBox
            // 
            MeanBox.Location = new Point(324, 218);
            MeanBox.Name = "MeanBox";
            MeanBox.ReadOnly = true;
            MeanBox.Size = new Size(120, 23);
            MeanBox.TabIndex = 17;
            toolTip1.SetToolTip(MeanBox, "Displays the calculated mean of the data");
            // 
            // RangeBox
            // 
            RangeBox.Location = new Point(324, 247);
            RangeBox.Name = "RangeBox";
            RangeBox.ReadOnly = true;
            RangeBox.Size = new Size(120, 23);
            RangeBox.TabIndex = 18;
            toolTip1.SetToolTip(RangeBox, "Displays the calculated range of the data");
            // 
            // AstronomicalProcessing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 283);
            Controls.Add(RangeBox);
            Controls.Add(MeanBox);
            Controls.Add(ModeBox);
            Controls.Add(MidExtremeBox);
            Controls.Add(SequentialSearchButton);
            Controls.Add(RangeButton);
            Controls.Add(MeanButton);
            Controls.Add(ModeButton);
            Controls.Add(MidExtremeButton);
            Controls.Add(LoadButton);
            Controls.Add(SaveButton);
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
        private Button SaveButton;
        private Button LoadButton;
        private Button MidExtremeButton;
        private Button ModeButton;
        private Button MeanButton;
        private Button RangeButton;
        private Button SequentialSearchButton;
        private ToolTip toolTip1;
        private TextBox MidExtremeBox;
        private TextBox ModeBox;
        private TextBox MeanBox;
        private TextBox RangeBox;
    }
}

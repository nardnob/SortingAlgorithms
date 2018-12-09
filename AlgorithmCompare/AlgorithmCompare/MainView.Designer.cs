namespace AlgorithmCompare
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.txtUnsortedNums = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtItems = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtBeginRange = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtEndRange = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnGetList = new System.Windows.Forms.ToolStripButton();
            this.tsbtnClearLog = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnClearSortedList = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnVerifySort = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSortedNums = new System.Windows.Forms.TextBox();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnCombSort = new System.Windows.Forms.Button();
            this.btnStoogeSort = new System.Windows.Forms.Button();
            this.btnHeapSort = new System.Windows.Forms.Button();
            this.btnStupidSort = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUnsortedNums
            // 
            this.txtUnsortedNums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnsortedNums.Location = new System.Drawing.Point(12, 47);
            this.txtUnsortedNums.Multiline = true;
            this.txtUnsortedNums.Name = "txtUnsortedNums";
            this.txtUnsortedNums.ReadOnly = true;
            this.txtUnsortedNums.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUnsortedNums.Size = new System.Drawing.Size(1027, 126);
            this.txtUnsortedNums.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unsorted List";
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tstxtItems,
            this.toolStripLabel4,
            this.toolStripLabel2,
            this.tstxtBeginRange,
            this.toolStripLabel5,
            this.toolStripLabel3,
            this.tstxtEndRange,
            this.toolStripLabel6,
            this.tsbtnGetList,
            this.tsbtnClearLog,
            this.toolStripLabel8,
            this.tsbtnClearSortedList,
            this.toolStripLabel7,
            this.tsbtnVerifySort});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1051, 25);
            this.tsMain.TabIndex = 2;
            this.tsMain.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel1.Text = "Items:";
            // 
            // tstxtItems
            // 
            this.tstxtItems.MaxLength = 9;
            this.tstxtItems.Name = "tstxtItems";
            this.tstxtItems.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel4.Text = "  ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(76, 22);
            this.toolStripLabel2.Text = "Begin Range:";
            // 
            // tstxtBeginRange
            // 
            this.tstxtBeginRange.MaxLength = 9;
            this.tstxtBeginRange.Name = "tstxtBeginRange";
            this.tstxtBeginRange.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel5.Text = "  ";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(66, 22);
            this.toolStripLabel3.Text = "End Range:";
            // 
            // tstxtEndRange
            // 
            this.tstxtEndRange.MaxLength = 9;
            this.tstxtEndRange.Name = "tstxtEndRange";
            this.tstxtEndRange.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel6.Text = "  ";
            // 
            // tsbtnGetList
            // 
            this.tsbtnGetList.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnGetList.Image")));
            this.tsbtnGetList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGetList.Name = "tsbtnGetList";
            this.tsbtnGetList.Size = new System.Drawing.Size(66, 22);
            this.tsbtnGetList.Text = "Get List";
            this.tsbtnGetList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbtnGetList.Click += new System.EventHandler(this.tsbtnGetList_Click);
            // 
            // tsbtnClearLog
            // 
            this.tsbtnClearLog.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnClearLog.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClearLog.Image")));
            this.tsbtnClearLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClearLog.Name = "tsbtnClearLog";
            this.tsbtnClearLog.Size = new System.Drawing.Size(77, 22);
            this.tsbtnClearLog.Text = "Clear Log";
            this.tsbtnClearLog.Click += new System.EventHandler(this.tsbtnClearLog_Click);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel8.Text = "  ";
            // 
            // tsbtnClearSortedList
            // 
            this.tsbtnClearSortedList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnClearSortedList.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClearSortedList.Image")));
            this.tsbtnClearSortedList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClearSortedList.Name = "tsbtnClearSortedList";
            this.tsbtnClearSortedList.Size = new System.Drawing.Size(112, 22);
            this.tsbtnClearSortedList.Text = "Clear Sorted List";
            this.tsbtnClearSortedList.Click += new System.EventHandler(this.tsbtnClearSortedList_Click);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel7.Text = "  ";
            // 
            // tsbtnVerifySort
            // 
            this.tsbtnVerifySort.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnVerifySort.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnVerifySort.Image")));
            this.tsbtnVerifySort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnVerifySort.Name = "tsbtnVerifySort";
            this.tsbtnVerifySort.Size = new System.Drawing.Size(81, 22);
            this.tsbtnVerifySort.Text = "Verify Sort";
            this.tsbtnVerifySort.Click += new System.EventHandler(this.tsbtnVerifySort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sorted List";
            // 
            // txtSortedNums
            // 
            this.txtSortedNums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSortedNums.Location = new System.Drawing.Point(12, 205);
            this.txtSortedNums.Multiline = true;
            this.txtSortedNums.Name = "txtSortedNums";
            this.txtSortedNums.ReadOnly = true;
            this.txtSortedNums.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSortedNums.Size = new System.Drawing.Size(1027, 126);
            this.txtSortedNums.TabIndex = 3;
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(12, 353);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(126, 50);
            this.btnBubbleSort.TabIndex = 5;
            this.btnBubbleSort.Text = "Bubble Sort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Location = new System.Drawing.Point(144, 353);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(126, 50);
            this.btnMergeSort.TabIndex = 6;
            this.btnMergeSort.Text = "Top-Down Merge Sort";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(276, 353);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(126, 50);
            this.btnQuickSort.TabIndex = 7;
            this.btnQuickSort.Text = "Quick Sort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Location = new System.Drawing.Point(12, 409);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(126, 50);
            this.btnInsertionSort.TabIndex = 8;
            this.btnInsertionSort.Text = "Insertion Sort";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(144, 409);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(126, 50);
            this.btnSelectionSort.TabIndex = 9;
            this.btnSelectionSort.Text = "Selection Sort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnCombSort
            // 
            this.btnCombSort.Enabled = false;
            this.btnCombSort.Location = new System.Drawing.Point(12, 465);
            this.btnCombSort.Name = "btnCombSort";
            this.btnCombSort.Size = new System.Drawing.Size(126, 50);
            this.btnCombSort.TabIndex = 10;
            this.btnCombSort.Text = "Comb Sort";
            this.btnCombSort.UseVisualStyleBackColor = true;
            this.btnCombSort.Click += new System.EventHandler(this.btnCombSort_Click);
            // 
            // btnStoogeSort
            // 
            this.btnStoogeSort.Enabled = false;
            this.btnStoogeSort.Location = new System.Drawing.Point(144, 465);
            this.btnStoogeSort.Name = "btnStoogeSort";
            this.btnStoogeSort.Size = new System.Drawing.Size(126, 50);
            this.btnStoogeSort.TabIndex = 11;
            this.btnStoogeSort.Text = "Stooge Sort";
            this.btnStoogeSort.UseVisualStyleBackColor = true;
            this.btnStoogeSort.Click += new System.EventHandler(this.btnStoogeSort_Click);
            // 
            // btnHeapSort
            // 
            this.btnHeapSort.Enabled = false;
            this.btnHeapSort.Location = new System.Drawing.Point(276, 409);
            this.btnHeapSort.Name = "btnHeapSort";
            this.btnHeapSort.Size = new System.Drawing.Size(126, 50);
            this.btnHeapSort.TabIndex = 12;
            this.btnHeapSort.Text = "Heap Sort";
            this.btnHeapSort.UseVisualStyleBackColor = true;
            this.btnHeapSort.Click += new System.EventHandler(this.btnHeapSort_Click);
            // 
            // btnStupidSort
            // 
            this.btnStupidSort.Enabled = false;
            this.btnStupidSort.Location = new System.Drawing.Point(276, 465);
            this.btnStupidSort.Name = "btnStupidSort";
            this.btnStupidSort.Size = new System.Drawing.Size(126, 50);
            this.btnStupidSort.TabIndex = 13;
            this.btnStupidSort.Text = "Stupid Sort";
            this.btnStupidSort.UseVisualStyleBackColor = true;
            this.btnStupidSort.Click += new System.EventHandler(this.btnStupidSort_Click);
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(12, 521);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(126, 50);
            this.button10.TabIndex = 14;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(144, 521);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(126, 50);
            this.button11.TabIndex = 15;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.Location = new System.Drawing.Point(276, 521);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(126, 50);
            this.button12.TabIndex = 16;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // txtResults
            // 
            this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResults.Location = new System.Drawing.Point(408, 369);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(631, 202);
            this.txtResults.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Results Log";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 583);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnStupidSort);
            this.Controls.Add(this.btnHeapSort);
            this.Controls.Add(this.btnStoogeSort);
            this.Controls.Add(this.btnCombSort);
            this.Controls.Add(this.btnSelectionSort);
            this.Controls.Add(this.btnInsertionSort);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnMergeSort);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSortedNums);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnsortedNums);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(656, 621);
            this.Name = "MainView";
            this.Text = "Comparing Sorts";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnsortedNums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstxtItems;
        private System.Windows.Forms.ToolStripButton tsbtnGetList;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tstxtBeginRange;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox tstxtEndRange;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSortedNums;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnCombSort;
        private System.Windows.Forms.Button btnStoogeSort;
        private System.Windows.Forms.Button btnHeapSort;
        private System.Windows.Forms.Button btnStupidSort;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton tsbtnClearLog;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripButton tsbtnClearSortedList;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripButton tsbtnVerifySort;
    }
}


namespace HuyPham_20161207_CSI155FinalExam
{
    partial class Form1
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
            if (disposing && (components != null))
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
            this.lvDisplay = new System.Windows.Forms.ListView();
            this.colLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGrades = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabStudentListView = new System.Windows.Forms.TabPage();
            this.btnRestore = new System.Windows.Forms.Button();
            this.grpS9 = new System.Windows.Forms.GroupBox();
            this.btnS9RemoveWithCustomString = new System.Windows.Forms.Button();
            this.cboS9StudentID = new System.Windows.Forms.ComboBox();
            this.grpS8 = new System.Windows.Forms.GroupBox();
            this.btnS8SearchCustomString = new System.Windows.Forms.Button();
            this.cboS8StudentID = new System.Windows.Forms.ComboBox();
            this.btnS4SortWithIComparer = new System.Windows.Forms.Button();
            this.btnS3SortWithIComparable = new System.Windows.Forms.Button();
            this.tabQueueStack = new System.Windows.Forms.TabPage();
            this.grpS11 = new System.Windows.Forms.GroupBox();
            this.btnS11Restore = new System.Windows.Forms.Button();
            this.btnS11RemovePositives = new System.Windows.Forms.Button();
            this.listBoxS11Stack = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnS10Restore = new System.Windows.Forms.Button();
            this.btnS10RemoveNegatives = new System.Windows.Forms.Button();
            this.listBoxS10Queue = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.tabStudentListView.SuspendLayout();
            this.grpS9.SuspendLayout();
            this.grpS8.SuspendLayout();
            this.tabQueueStack.SuspendLayout();
            this.grpS11.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDisplay
            // 
            this.lvDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLName,
            this.colFName,
            this.colID,
            this.colGrades});
            this.lvDisplay.Font = new System.Drawing.Font("Arial", 12F);
            this.lvDisplay.FullRowSelect = true;
            this.lvDisplay.GridLines = true;
            this.lvDisplay.Location = new System.Drawing.Point(6, 6);
            this.lvDisplay.Name = "lvDisplay";
            this.lvDisplay.Size = new System.Drawing.Size(329, 292);
            this.lvDisplay.TabIndex = 0;
            this.lvDisplay.UseCompatibleStateImageBehavior = false;
            this.lvDisplay.View = System.Windows.Forms.View.Details;
            // 
            // colLName
            // 
            this.colLName.Text = "Last Name";
            this.colLName.Width = 100;
            // 
            // colFName
            // 
            this.colFName.Text = "First Name";
            this.colFName.Width = 100;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 50;
            // 
            // colGrades
            // 
            this.colGrades.Text = "Grade";
            this.colGrades.Width = 75;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabStudentListView);
            this.tabControl.Controls.Add(this.tabQueueStack);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(725, 330);
            this.tabControl.TabIndex = 1;
            // 
            // tabStudentListView
            // 
            this.tabStudentListView.Controls.Add(this.btnRestore);
            this.tabStudentListView.Controls.Add(this.grpS9);
            this.tabStudentListView.Controls.Add(this.grpS8);
            this.tabStudentListView.Controls.Add(this.btnS4SortWithIComparer);
            this.tabStudentListView.Controls.Add(this.btnS3SortWithIComparable);
            this.tabStudentListView.Controls.Add(this.lvDisplay);
            this.tabStudentListView.Location = new System.Drawing.Point(4, 22);
            this.tabStudentListView.Name = "tabStudentListView";
            this.tabStudentListView.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentListView.Size = new System.Drawing.Size(717, 304);
            this.tabStudentListView.TabIndex = 0;
            this.tabStudentListView.Text = "Student ListView";
            this.tabStudentListView.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Arial", 12F);
            this.btnRestore.Location = new System.Drawing.Point(341, 186);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(370, 112);
            this.btnRestore.TabIndex = 8;
            this.btnRestore.Text = "Restore All Students \r\nto List and Dictionary";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // grpS9
            // 
            this.grpS9.Controls.Add(this.btnS9RemoveWithCustomString);
            this.grpS9.Controls.Add(this.cboS9StudentID);
            this.grpS9.Location = new System.Drawing.Point(341, 134);
            this.grpS9.Name = "grpS9";
            this.grpS9.Size = new System.Drawing.Size(370, 46);
            this.grpS9.TabIndex = 7;
            this.grpS9.TabStop = false;
            this.grpS9.Text = "Solution #9: Remove Student by ID";
            // 
            // btnS9RemoveWithCustomString
            // 
            this.btnS9RemoveWithCustomString.Font = new System.Drawing.Font("Arial", 8F);
            this.btnS9RemoveWithCustomString.Location = new System.Drawing.Point(236, 19);
            this.btnS9RemoveWithCustomString.Name = "btnS9RemoveWithCustomString";
            this.btnS9RemoveWithCustomString.Size = new System.Drawing.Size(128, 21);
            this.btnS9RemoveWithCustomString.TabIndex = 6;
            this.btnS9RemoveWithCustomString.Text = "Remove Student By ID";
            this.btnS9RemoveWithCustomString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnS9RemoveWithCustomString.UseVisualStyleBackColor = true;
            this.btnS9RemoveWithCustomString.Click += new System.EventHandler(this.btnS9RemoveWithCustomString_Click);
            // 
            // cboS9StudentID
            // 
            this.cboS9StudentID.FormattingEnabled = true;
            this.cboS9StudentID.Location = new System.Drawing.Point(6, 19);
            this.cboS9StudentID.Name = "cboS9StudentID";
            this.cboS9StudentID.Size = new System.Drawing.Size(224, 21);
            this.cboS9StudentID.TabIndex = 4;
            // 
            // grpS8
            // 
            this.grpS8.Controls.Add(this.btnS8SearchCustomString);
            this.grpS8.Controls.Add(this.cboS8StudentID);
            this.grpS8.Location = new System.Drawing.Point(341, 82);
            this.grpS8.Name = "grpS8";
            this.grpS8.Size = new System.Drawing.Size(370, 46);
            this.grpS8.TabIndex = 5;
            this.grpS8.TabStop = false;
            this.grpS8.Text = "Solution #8: Find Student by ID";
            // 
            // btnS8SearchCustomString
            // 
            this.btnS8SearchCustomString.Font = new System.Drawing.Font("Arial", 8F);
            this.btnS8SearchCustomString.Location = new System.Drawing.Point(236, 19);
            this.btnS8SearchCustomString.Name = "btnS8SearchCustomString";
            this.btnS8SearchCustomString.Size = new System.Drawing.Size(128, 21);
            this.btnS8SearchCustomString.TabIndex = 6;
            this.btnS8SearchCustomString.Text = "Search Student By ID";
            this.btnS8SearchCustomString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnS8SearchCustomString.UseVisualStyleBackColor = true;
            this.btnS8SearchCustomString.Click += new System.EventHandler(this.btnS8SearchCustomString_Click);
            // 
            // cboS8StudentID
            // 
            this.cboS8StudentID.FormattingEnabled = true;
            this.cboS8StudentID.Location = new System.Drawing.Point(6, 19);
            this.cboS8StudentID.Name = "cboS8StudentID";
            this.cboS8StudentID.Size = new System.Drawing.Size(224, 21);
            this.cboS8StudentID.TabIndex = 4;
            // 
            // btnS4SortWithIComparer
            // 
            this.btnS4SortWithIComparer.Font = new System.Drawing.Font("Arial", 10F);
            this.btnS4SortWithIComparer.Location = new System.Drawing.Point(341, 44);
            this.btnS4SortWithIComparer.Name = "btnS4SortWithIComparer";
            this.btnS4SortWithIComparer.Size = new System.Drawing.Size(370, 32);
            this.btnS4SortWithIComparer.TabIndex = 2;
            this.btnS4SortWithIComparer.Text = "Solution #4: Sort Students by Last Name via IComparer\r\n";
            this.btnS4SortWithIComparer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnS4SortWithIComparer.UseVisualStyleBackColor = true;
            this.btnS4SortWithIComparer.Click += new System.EventHandler(this.btnS4SortWithIComparer_Click);
            // 
            // btnS3SortWithIComparable
            // 
            this.btnS3SortWithIComparable.Font = new System.Drawing.Font("Arial", 10F);
            this.btnS3SortWithIComparable.Location = new System.Drawing.Point(341, 6);
            this.btnS3SortWithIComparable.Name = "btnS3SortWithIComparable";
            this.btnS3SortWithIComparable.Size = new System.Drawing.Size(370, 32);
            this.btnS3SortWithIComparable.TabIndex = 1;
            this.btnS3SortWithIComparable.Text = "Solution #3: Sort Students by Grade via IComparable";
            this.btnS3SortWithIComparable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnS3SortWithIComparable.UseVisualStyleBackColor = true;
            this.btnS3SortWithIComparable.Click += new System.EventHandler(this.btnS3SortWithIComparable_Click);
            // 
            // tabQueueStack
            // 
            this.tabQueueStack.Controls.Add(this.grpS11);
            this.tabQueueStack.Controls.Add(this.groupBox1);
            this.tabQueueStack.Location = new System.Drawing.Point(4, 22);
            this.tabQueueStack.Name = "tabQueueStack";
            this.tabQueueStack.Padding = new System.Windows.Forms.Padding(3);
            this.tabQueueStack.Size = new System.Drawing.Size(717, 304);
            this.tabQueueStack.TabIndex = 1;
            this.tabQueueStack.Text = "Queues & Stacks";
            this.tabQueueStack.UseVisualStyleBackColor = true;
            // 
            // grpS11
            // 
            this.grpS11.Controls.Add(this.btnS11Restore);
            this.grpS11.Controls.Add(this.btnS11RemovePositives);
            this.grpS11.Controls.Add(this.listBoxS11Stack);
            this.grpS11.Location = new System.Drawing.Point(408, 6);
            this.grpS11.Name = "grpS11";
            this.grpS11.Size = new System.Drawing.Size(303, 292);
            this.grpS11.TabIndex = 5;
            this.grpS11.TabStop = false;
            this.grpS11.Text = "Solution #11: Stack of Integers";
            // 
            // btnS11Restore
            // 
            this.btnS11Restore.Font = new System.Drawing.Font("Arial", 12F);
            this.btnS11Restore.Location = new System.Drawing.Point(144, 78);
            this.btnS11Restore.Name = "btnS11Restore";
            this.btnS11Restore.Size = new System.Drawing.Size(153, 197);
            this.btnS11Restore.TabIndex = 4;
            this.btnS11Restore.Text = "Restore Stack \r\nto Original State";
            this.btnS11Restore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnS11Restore.UseVisualStyleBackColor = true;
            this.btnS11Restore.Click += new System.EventHandler(this.btnS11Restore_Click);
            // 
            // btnS11RemovePositives
            // 
            this.btnS11RemovePositives.Font = new System.Drawing.Font("Arial", 12F);
            this.btnS11RemovePositives.Location = new System.Drawing.Point(144, 20);
            this.btnS11RemovePositives.Name = "btnS11RemovePositives";
            this.btnS11RemovePositives.Size = new System.Drawing.Size(153, 52);
            this.btnS11RemovePositives.TabIndex = 3;
            this.btnS11RemovePositives.Text = "Remove Positives,\r\nRetain Order";
            this.btnS11RemovePositives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnS11RemovePositives.UseVisualStyleBackColor = true;
            this.btnS11RemovePositives.Click += new System.EventHandler(this.btnS11RemovePositives_Click);
            // 
            // listBoxS11Stack
            // 
            this.listBoxS11Stack.Font = new System.Drawing.Font("Arial", 12F);
            this.listBoxS11Stack.FormattingEnabled = true;
            this.listBoxS11Stack.ItemHeight = 18;
            this.listBoxS11Stack.Location = new System.Drawing.Point(6, 19);
            this.listBoxS11Stack.Name = "listBoxS11Stack";
            this.listBoxS11Stack.Size = new System.Drawing.Size(132, 256);
            this.listBoxS11Stack.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnS10Restore);
            this.groupBox1.Controls.Add(this.btnS10RemoveNegatives);
            this.groupBox1.Controls.Add(this.listBoxS10Queue);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 292);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solution #10: Queue of Integers";
            // 
            // btnS10Restore
            // 
            this.btnS10Restore.Font = new System.Drawing.Font("Arial", 12F);
            this.btnS10Restore.Location = new System.Drawing.Point(144, 77);
            this.btnS10Restore.Name = "btnS10Restore";
            this.btnS10Restore.Size = new System.Drawing.Size(153, 198);
            this.btnS10Restore.TabIndex = 4;
            this.btnS10Restore.Text = "Restore Queue \r\nto Original State";
            this.btnS10Restore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnS10Restore.UseVisualStyleBackColor = true;
            this.btnS10Restore.Click += new System.EventHandler(this.btnS10Restore_Click);
            // 
            // btnS10RemoveNegatives
            // 
            this.btnS10RemoveNegatives.Font = new System.Drawing.Font("Arial", 12F);
            this.btnS10RemoveNegatives.Location = new System.Drawing.Point(144, 19);
            this.btnS10RemoveNegatives.Name = "btnS10RemoveNegatives";
            this.btnS10RemoveNegatives.Size = new System.Drawing.Size(153, 52);
            this.btnS10RemoveNegatives.TabIndex = 3;
            this.btnS10RemoveNegatives.Text = "Remove Negatives,\r\nRetain Order";
            this.btnS10RemoveNegatives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnS10RemoveNegatives.UseVisualStyleBackColor = true;
            this.btnS10RemoveNegatives.Click += new System.EventHandler(this.btnS10RemoveNegatives_Click);
            // 
            // listBoxS10Queue
            // 
            this.listBoxS10Queue.Font = new System.Drawing.Font("Arial", 12F);
            this.listBoxS10Queue.FormattingEnabled = true;
            this.listBoxS10Queue.ItemHeight = 18;
            this.listBoxS10Queue.Location = new System.Drawing.Point(6, 19);
            this.listBoxS10Queue.Name = "listBoxS10Queue";
            this.listBoxS10Queue.Size = new System.Drawing.Size(132, 256);
            this.listBoxS10Queue.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 355);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "HuyPham_20161207_CSI155_FinalExam";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabStudentListView.ResumeLayout(false);
            this.grpS9.ResumeLayout(false);
            this.grpS8.ResumeLayout(false);
            this.tabQueueStack.ResumeLayout(false);
            this.grpS11.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDisplay;
        private System.Windows.Forms.ColumnHeader colLName;
        private System.Windows.Forms.ColumnHeader colFName;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colGrades;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabStudentListView;
        private System.Windows.Forms.TabPage tabQueueStack;
        private System.Windows.Forms.Button btnS3SortWithIComparable;
        private System.Windows.Forms.Button btnS4SortWithIComparer;
        private System.Windows.Forms.GroupBox grpS8;
        private System.Windows.Forms.ComboBox cboS8StudentID;
        private System.Windows.Forms.Button btnS8SearchCustomString;
        private System.Windows.Forms.GroupBox grpS9;
        private System.Windows.Forms.Button btnS9RemoveWithCustomString;
        private System.Windows.Forms.ComboBox cboS9StudentID;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxS10Queue;
        private System.Windows.Forms.GroupBox grpS11;
        private System.Windows.Forms.Button btnS11Restore;
        private System.Windows.Forms.Button btnS11RemovePositives;
        private System.Windows.Forms.ListBox listBoxS11Stack;
        private System.Windows.Forms.Button btnS10Restore;
        private System.Windows.Forms.Button btnS10RemoveNegatives;
    }
}


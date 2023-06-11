namespace WinFormsApp1 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            AddButton = new Button();
            label1 = new Label();
            AddHeight = new MaskedTextBox();
            label2 = new Label();
            label = new Label();
            AddWidth = new MaskedTextBox();
            label4 = new Label();
            DeleteId = new MaskedTextBox();
            label5 = new Label();
            DeleteCButton = new Button();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            BuyHeight = new MaskedTextBox();
            BuyWidth = new MaskedTextBox();
            BuyButton = new Button();
            boxBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            heightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            widthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LastTimePurchased = new DataGridViewTextBoxColumn();
            isDeletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            label8 = new Label();
            MaxDifference = new MaskedTextBox();
            SaveAndExit = new Button();
            ((System.ComponentModel.ISupportInitialize)boxBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(17, 170);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(156, 45);
            AddButton.TabIndex = 0;
            AddButton.Text = "Submit\r\n";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(49, 57);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Add A Box";
            // 
            // AddHeight
            // 
            AddHeight.Location = new Point(73, 88);
            AddHeight.Mask = "000.00";
            AddHeight.Name = "AddHeight";
            AddHeight.Size = new Size(100, 23);
            AddHeight.TabIndex = 2;
            AddHeight.KeyPress += AddSizes_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 96);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Height:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(21, 132);
            label.Name = "label";
            label.Size = new Size(42, 15);
            label.TabIndex = 4;
            label.Text = "Width:";
            // 
            // AddWidth
            // 
            AddWidth.Location = new Point(73, 124);
            AddWidth.Mask = "000.00";
            AddWidth.Name = "AddWidth";
            AddWidth.Size = new Size(100, 23);
            AddWidth.TabIndex = 5;
            AddWidth.KeyPress += AddSizes_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(49, 271);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 6;
            label4.Text = "Delete A Box";
            // 
            // DeleteId
            // 
            DeleteId.Location = new Point(73, 305);
            DeleteId.Mask = "00000";
            DeleteId.Name = "DeleteId";
            DeleteId.PromptChar = ' ';
            DeleteId.Size = new Size(100, 23);
            DeleteId.TabIndex = 7;
            DeleteId.ValidatingType = typeof(int);
            DeleteId.Validating += DeleteId_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 313);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 8;
            label5.Text = "ID:";
            // 
            // DeleteCButton
            // 
            DeleteCButton.Location = new Point(17, 344);
            DeleteCButton.Name = "DeleteCButton";
            DeleteCButton.Size = new Size(156, 44);
            DeleteCButton.TabIndex = 9;
            DeleteCButton.Text = "Submit";
            DeleteCButton.UseVisualStyleBackColor = true;
            DeleteCButton.Click += DeleteCButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(288, 62);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 10;
            label3.Text = "Buy  A Box";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(232, 132);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 11;
            label6.Text = "Gift Width:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(228, 96);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 12;
            label7.Text = "Gift Height:";
            // 
            // BuyHeight
            // 
            BuyHeight.Location = new Point(302, 88);
            BuyHeight.Mask = "000.00";
            BuyHeight.Name = "BuyHeight";
            BuyHeight.Size = new Size(100, 23);
            BuyHeight.TabIndex = 13;
            BuyHeight.KeyPress += AddSizes_KeyPress;
            BuyHeight.Leave += AddSizes_Leave;
            // 
            // BuyWidth
            // 
            BuyWidth.Location = new Point(302, 124);
            BuyWidth.Mask = "000.00";
            BuyWidth.Name = "BuyWidth";
            BuyWidth.Size = new Size(100, 23);
            BuyWidth.TabIndex = 14;
            BuyWidth.KeyPress += AddSizes_KeyPress;
            BuyWidth.Leave += AddSizes_Leave;
            // 
            // BuyButton
            // 
            BuyButton.Location = new Point(246, 188);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(156, 45);
            BuyButton.TabIndex = 15;
            BuyButton.Text = "Search";
            BuyButton.UseVisualStyleBackColor = true;
            BuyButton.Click += BuyButton_Click;
            // 
            // boxBindingSource
            // 
            boxBindingSource.AllowNew = false;
            boxBindingSource.DataSource = typeof(Box);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, heightDataGridViewTextBoxColumn, widthDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, LastTimePurchased, isDeletedDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = boxBindingSource;
            dataGridView1.Location = new Point(408, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(531, 274);
            dataGridView1.TabIndex = 16;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            heightDataGridViewTextBoxColumn.HeaderText = "Height";
            heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            heightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            widthDataGridViewTextBoxColumn.HeaderText = "Width";
            widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            widthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "Count";
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LastTimePurchased
            // 
            LastTimePurchased.DataPropertyName = "LastTimePurchased";
            LastTimePurchased.HeaderText = "LastTimePurchased";
            LastTimePurchased.Name = "LastTimePurchased";
            LastTimePurchased.ReadOnly = true;
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeleted";
            isDeletedDataGridViewCheckBoxColumn.HeaderText = "IsDeleted";
            isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            isDeletedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(206, 161);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 17;
            label8.Text = "Max Difference:";
            // 
            // MaxDifference
            // 
            MaxDifference.BackColor = Color.White;
            MaxDifference.Location = new Point(302, 158);
            MaxDifference.Mask = "00000";
            MaxDifference.Name = "MaxDifference";
            MaxDifference.Size = new Size(100, 23);
            MaxDifference.TabIndex = 18;
            MaxDifference.ValidatingType = typeof(int);
            MaxDifference.Validating += MaxDifference_Validating;
            // 
            // SaveAndExit
            // 
            SaveAndExit.Location = new Point(733, 418);
            SaveAndExit.Name = "SaveAndExit";
            SaveAndExit.Size = new Size(151, 63);
            SaveAndExit.TabIndex = 19;
            SaveAndExit.Text = "Save & Exit";
            SaveAndExit.UseVisualStyleBackColor = true;
            SaveAndExit.Click += SaveAndExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 549);
            Controls.Add(SaveAndExit);
            Controls.Add(MaxDifference);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(BuyButton);
            Controls.Add(BuyWidth);
            Controls.Add(BuyHeight);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(DeleteCButton);
            Controls.Add(label5);
            Controls.Add(DeleteId);
            Controls.Add(label4);
            Controls.Add(AddWidth);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(AddHeight);
            Controls.Add(label1);
            Controls.Add(AddButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)boxBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Label label1;
        private MaskedTextBox AddHeight;
        private Label label2;
        private Label label;
        private MaskedTextBox AddWidth;
        private Label label4;
        private MaskedTextBox DeleteId;
        private Label label5;
        private Button DeleteCButton;
        private Label label3;
        private Label label6;
        private Label label7;
        private MaskedTextBox BuyHeight;
        private MaskedTextBox BuyWidth;
        private Button BuyButton;
        private BindingSource boxBindingSource;
        private DataGridView dataGridView1;
        private Label label8;
        private MaskedTextBox MaxDifference;
        private DataGridViewTextBoxColumn lastTimePruchesedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn LastTimePurchased;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private Button SaveAndExit;
    }
}
namespace Operations_for_indexed_sequential_files
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
            txtID = new TextBox();
            txtName = new TextBox();
            txtPosition = new TextBox();
            txtSalary = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRegister = new Button();
            btnShowAll = new Button();
            btnSearch = new Button();
            Delete = new Button();
            rtbResult = new RichTextBox();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Font = new Font("Microsoft YaHei UI", 11F);
            txtID.Location = new Point(48, 85);
            txtID.Name = "txtID";
            txtID.Size = new Size(198, 26);
            txtID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft YaHei UI", 11F);
            txtName.Location = new Point(48, 146);
            txtName.Name = "txtName";
            txtName.Size = new Size(198, 26);
            txtName.TabIndex = 1;
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Microsoft YaHei UI", 11F);
            txtPosition.Location = new Point(48, 207);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(198, 26);
            txtPosition.TabIndex = 2;
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Microsoft YaHei UI", 11F);
            txtSalary.Location = new Point(48, 268);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(198, 26);
            txtSalary.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label1.Location = new Point(48, 60);
            label1.Name = "label1";
            label1.Size = new Size(33, 22);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label2.Location = new Point(48, 121);
            label2.Name = "label2";
            label2.Size = new Size(63, 22);
            label2.TabIndex = 5;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label3.Location = new Point(48, 182);
            label3.Name = "label3";
            label3.Size = new Size(83, 22);
            label3.TabIndex = 6;
            label3.Text = "Position:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label4.Location = new Point(47, 243);
            label4.Name = "label4";
            label4.Size = new Size(64, 22);
            label4.TabIndex = 7;
            label4.Text = "Salary:";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(42, 316);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(92, 33);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(154, 316);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(92, 33);
            btnShowAll.TabIndex = 9;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(154, 367);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 33);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(42, 367);
            Delete.Name = "Delete";
            Delete.Size = new Size(92, 33);
            Delete.TabIndex = 10;
            Delete.Text = "btnDelete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // rtbResult
            // 
            rtbResult.Location = new Point(313, 51);
            rtbResult.Name = "rtbResult";
            rtbResult.Size = new Size(447, 300);
            rtbResult.TabIndex = 12;
            rtbResult.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbResult);
            Controls.Add(btnSearch);
            Controls.Add(Delete);
            Controls.Add(btnShowAll);
            Controls.Add(btnRegister);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSalary);
            Controls.Add(txtPosition);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtPosition;
        private TextBox txtSalary;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRegister;
        private Button btnShowAll;
        private Button btnSearch;
        private Button Delete;
        private RichTextBox rtbResult;
    }
}

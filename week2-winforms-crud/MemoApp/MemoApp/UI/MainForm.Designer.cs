namespace MemoApp
{
    partial class MainForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            reloadBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            creatBtn = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            titleText = new TextBox();
            contentText = new TextBox();
            memoListView = new ListView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(memoListView, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(800, 529);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(reloadBtn, 3, 0);
            tableLayoutPanel2.Controls.Add(deleteBtn, 2, 0);
            tableLayoutPanel2.Controls.Add(updateBtn, 1, 0);
            tableLayoutPanel2.Controls.Add(creatBtn, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 451);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(794, 75);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // reloadBtn
            // 
            reloadBtn.Dock = DockStyle.Fill;
            reloadBtn.Location = new Point(597, 3);
            reloadBtn.Name = "reloadBtn";
            reloadBtn.Size = new Size(194, 69);
            reloadBtn.TabIndex = 3;
            reloadBtn.Text = "새로고침";
            reloadBtn.UseVisualStyleBackColor = true;
            reloadBtn.Click += reloadBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Dock = DockStyle.Fill;
            deleteBtn.Location = new Point(399, 3);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(192, 69);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "삭제";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Dock = DockStyle.Fill;
            updateBtn.Location = new Point(201, 3);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(192, 69);
            updateBtn.TabIndex = 1;
            updateBtn.Text = "수정";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // creatBtn
            // 
            creatBtn.Dock = DockStyle.Fill;
            creatBtn.Location = new Point(3, 3);
            creatBtn.Name = "creatBtn";
            creatBtn.Size = new Size(192, 69);
            creatBtn.TabIndex = 0;
            creatBtn.Text = "추가";
            creatBtn.UseVisualStyleBackColor = true;
            creatBtn.Click += creatBtn_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(titleText, 0, 0);
            tableLayoutPanel3.Controls.Add(contentText, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 108);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.Size = new Size(794, 337);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // titleText
            // 
            titleText.Dock = DockStyle.Fill;
            titleText.Location = new Point(3, 3);
            titleText.Name = "titleText";
            titleText.Size = new Size(788, 27);
            titleText.TabIndex = 0;
            // 
            // contentText
            // 
            contentText.Dock = DockStyle.Fill;
            contentText.Location = new Point(3, 70);
            contentText.Multiline = true;
            contentText.Name = "contentText";
            contentText.Size = new Size(788, 264);
            contentText.TabIndex = 1;
            // 
            // memoListView
            // 
            memoListView.Dock = DockStyle.Fill;
            memoListView.FullRowSelect = true;
            memoListView.Location = new Point(3, 3);
            memoListView.Name = "memoListView";
            memoListView.Size = new Size(794, 99);
            memoListView.TabIndex = 4;
            memoListView.UseCompatibleStateImageBehavior = false;
            memoListView.View = View.Details;
            memoListView.SelectedIndexChanged += memoListView_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 529);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "Memo";
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button reloadBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button creatBtn;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox titleText;
        private TextBox contentText;
        private ListView memoListView;
    }
}

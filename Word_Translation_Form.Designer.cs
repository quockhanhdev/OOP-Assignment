namespace Ver1._0
{
    partial class Word_Translation_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Word_Translation_Form));
            this.pnSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblLastWord = new System.Windows.Forms.Label();
            this.ltbLastWord = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.ltbIndex = new System.Windows.Forms.ListBox();
            this.cbbLanguage = new System.Windows.Forms.ComboBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTool = new System.Windows.Forms.Panel();
            this.lblCopy = new System.Windows.Forms.Label();
            this.lblPrev = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.pnMeaning = new System.Windows.Forms.Panel();
            this.pnSearch.SuspendLayout();
            this.pnTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSearch
            // 
            this.pnSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnSearch.Controls.Add(this.lblSearch);
            this.pnSearch.Controls.Add(this.lblLastWord);
            this.pnSearch.Controls.Add(this.ltbLastWord);
            this.pnSearch.Controls.Add(this.label2);
            this.pnSearch.Controls.Add(this.ltbIndex);
            this.pnSearch.Controls.Add(this.cbbLanguage);
            this.pnSearch.Controls.Add(this.tbKey);
            this.pnSearch.Controls.Add(this.label1);
            this.pnSearch.Location = new System.Drawing.Point(3, 0);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(223, 610);
            this.pnSearch.TabIndex = 0;
            this.pnSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnSearch_Paint);
            // 
            // lblSearch
            // 
            this.lblSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSearch.Image = ((System.Drawing.Image)(resources.GetObject("lblSearch.Image")));
            this.lblSearch.Location = new System.Drawing.Point(194, 40);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(22, 24);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblLastWord
            // 
            this.lblLastWord.AutoSize = true;
            this.lblLastWord.Location = new System.Drawing.Point(60, 386);
            this.lblLastWord.Name = "lblLastWord";
            this.lblLastWord.Size = new System.Drawing.Size(87, 20);
            this.lblLastWord.TabIndex = 6;
            this.lblLastWord.Text = "Last Word";
            this.lblLastWord.Click += new System.EventHandler(this.label3_Click);
            // 
            // ltbLastWord
            // 
            this.ltbLastWord.Location = new System.Drawing.Point(3, 409);
            this.ltbLastWord.Name = "ltbLastWord";
            this.ltbLastWord.Size = new System.Drawing.Size(209, 191);
            this.ltbLastWord.TabIndex = 5;
            this.ltbLastWord.UseCompatibleStateImageBehavior = false;
            this.ltbLastWord.SelectedIndexChanged += new System.EventHandler(this.ltbLastWord_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Index";
            // 
            // ltbIndex
            // 
            this.ltbIndex.FormattingEnabled = true;
            this.ltbIndex.ItemHeight = 20;
            this.ltbIndex.Location = new System.Drawing.Point(3, 90);
            this.ltbIndex.Name = "ltbIndex";
            this.ltbIndex.Size = new System.Drawing.Size(209, 284);
            this.ltbIndex.TabIndex = 3;
            this.ltbIndex.SelectedIndexChanged += new System.EventHandler(this.ltbIndex_SelectedIndexChanged);
            // 
            // cbbLanguage
            // 
            this.cbbLanguage.FormattingEnabled = true;
            this.cbbLanguage.Location = new System.Drawing.Point(64, 3);
            this.cbbLanguage.Name = "cbbLanguage";
            this.cbbLanguage.Size = new System.Drawing.Size(152, 28);
            this.cbbLanguage.TabIndex = 2;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(3, 37);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(185, 27);
            this.tbKey.TabIndex = 1;
            this.tbKey.TextChanged += new System.EventHandler(this.tbKey_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // pnTool
            // 
            this.pnTool.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnTool.Controls.Add(this.lblCopy);
            this.pnTool.Controls.Add(this.lblPrev);
            this.pnTool.Controls.Add(this.lblNext);
            this.pnTool.Location = new System.Drawing.Point(228, 1);
            this.pnTool.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnTool.Name = "pnTool";
            this.pnTool.Size = new System.Drawing.Size(542, 32);
            this.pnTool.TabIndex = 1;
            // 
            // lblCopy
            // 
            this.lblCopy.Image = ((System.Drawing.Image)(resources.GetObject("lblCopy.Image")));
            this.lblCopy.Location = new System.Drawing.Point(68, 3);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(35, 22);
            this.lblCopy.TabIndex = 10;
            // 
            // lblPrev
            // 
            this.lblPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrev.Image = ((System.Drawing.Image)(resources.GetObject("lblPrev.Image")));
            this.lblPrev.Location = new System.Drawing.Point(3, 4);
            this.lblPrev.Name = "lblPrev";
            this.lblPrev.Size = new System.Drawing.Size(35, 24);
            this.lblPrev.TabIndex = 9;
            // 
            // lblNext
            // 
            this.lblNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNext.Image = ((System.Drawing.Image)(resources.GetObject("lblNext.Image")));
            this.lblNext.Location = new System.Drawing.Point(34, 4);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(35, 24);
            this.lblNext.TabIndex = 8;
            // 
            // pnMeaning
            // 
            this.pnMeaning.BackColor = System.Drawing.Color.LightGray;
            this.pnMeaning.Location = new System.Drawing.Point(228, 34);
            this.pnMeaning.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnMeaning.Name = "pnMeaning";
            this.pnMeaning.Size = new System.Drawing.Size(542, 576);
            this.pnMeaning.TabIndex = 2;
            this.pnMeaning.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMeaning_Paint);
            // 
            // Word_Translation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(144)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(773, 614);
            this.ControlBox = false;
            this.Controls.Add(this.pnMeaning);
            this.Controls.Add(this.pnTool);
            this.Controls.Add(this.pnSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Word_Translation_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Word_Translation_Form";
            this.Load += new System.EventHandler(this.Word_Translation_Form_Load);
            this.ResizeEnd += new System.EventHandler(this.Word_Translation_Form_ResizeEnd);
            this.Resize += new System.EventHandler(this.Word_Translation_Form_Resize);
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnTool.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.Panel pnTool;
        private System.Windows.Forms.Panel pnMeaning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLanguage;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label lblLastWord;
        private System.Windows.Forms.ListView ltbLastWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ltbIndex;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblPrev;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblCopy;
    }
}
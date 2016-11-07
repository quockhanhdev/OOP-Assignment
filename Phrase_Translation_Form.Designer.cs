namespace Ver1._0
{
    partial class Phrase_Translation_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phrase_Translation_Form));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btTranslate = new System.Windows.Forms.Button();
            this.rtbSource = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbMeaning = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbGoogle = new System.Windows.Forms.PictureBox();
            this.lblSwitch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGoogle)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 18);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(239, 18);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(157, 28);
            this.comboBox2.TabIndex = 1;
            // 
            // btTranslate
            // 
            this.btTranslate.Location = new System.Drawing.Point(428, 14);
            this.btTranslate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btTranslate.Name = "btTranslate";
            this.btTranslate.Size = new System.Drawing.Size(125, 35);
            this.btTranslate.TabIndex = 2;
            this.btTranslate.Text = "Translate";
            this.btTranslate.UseVisualStyleBackColor = true;
            this.btTranslate.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbSource
            // 
            this.rtbSource.Location = new System.Drawing.Point(30, 88);
            this.rtbSource.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rtbSource.Name = "rtbSource";
            this.rtbSource.Size = new System.Drawing.Size(729, 218);
            this.rtbSource.TabIndex = 3;
            this.rtbSource.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 320);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Meaning: ";
            // 
            // rtbMeaning
            // 
            this.rtbMeaning.Location = new System.Drawing.Point(30, 345);
            this.rtbMeaning.Margin = new System.Windows.Forms.Padding(5);
            this.rtbMeaning.Name = "rtbMeaning";
            this.rtbMeaning.Size = new System.Drawing.Size(729, 238);
            this.rtbMeaning.TabIndex = 6;
            this.rtbMeaning.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Source:";
            // 
            // ptbGoogle
            // 
            this.ptbGoogle.BackColor = System.Drawing.Color.White;
            this.ptbGoogle.Location = new System.Drawing.Point(597, 12);
            this.ptbGoogle.Name = "ptbGoogle";
            this.ptbGoogle.Size = new System.Drawing.Size(144, 50);
            this.ptbGoogle.TabIndex = 9;
            this.ptbGoogle.TabStop = false;
            this.ptbGoogle.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblSwitch
            // 
            this.lblSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSwitch.Image = ((System.Drawing.Image)(resources.GetObject("lblSwitch.Image")));
            this.lblSwitch.Location = new System.Drawing.Point(181, 21);
            this.lblSwitch.Name = "lblSwitch";
            this.lblSwitch.Size = new System.Drawing.Size(50, 25);
            this.lblSwitch.TabIndex = 10;
            // 
            // Phrase_Translation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(144)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(773, 614);
            this.ControlBox = false;
            this.Controls.Add(this.lblSwitch);
            this.Controls.Add(this.ptbGoogle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbMeaning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbSource);
            this.Controls.Add(this.btTranslate);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Phrase_Translation_Form";
            this.Text = "Phrase_Translation_Form";
            this.Load += new System.EventHandler(this.Phrase_Translation_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbGoogle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btTranslate;
        private System.Windows.Forms.RichTextBox rtbSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbMeaning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptbGoogle;
        private System.Windows.Forms.Label lblSwitch;
    }
}
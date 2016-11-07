using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ver1._0
{
    public partial class Word_Translation_Form : Form
    {
        private const int MIN_WIDTH = 773;
        private const int MIN_HEIGHT = 550;

        public Word_Translation_Form()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        public void ResizeForm(int width, int height)
        {
            if(height < MIN_HEIGHT)
            {
                this.Height = MIN_HEIGHT;
            }
            else
            {
                this.Height = height;
            }

            if(width < MIN_WIDTH)
            {
                this.Width = MIN_WIDTH;
            }
            else
            {
                this.Width = width;
            }
        }

        private void Word_Translation_Form_Load(object sender, EventArgs e)
        {

        }

        private void pnMeaning_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ltbIndex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblPre_Click(object sender, EventArgs e)
        {

        }

        private void Word_Translation_Form_Resize(object sender, EventArgs e)
        {
            this.pnMeaning.Width = this.Width - 231;
            this.pnMeaning.Height = this.Height - 38;
            this.pnTool.Width = this.Width - 231;
            this.ltbIndex.Height = this.Height - 336;
            this.lblLastWord.Location = new Point(60, 102 + this.ltbIndex.Height);
            this.ltbLastWord.Location = new Point(3, 125 + this.ltbIndex.Height);
        }

        private void Word_Translation_Form_ResizeEnd(object sender, EventArgs e)
        {
            if(this.Height < MIN_HEIGHT)
            {
                this.Height = MIN_HEIGHT;
            }
            if(this.Width < MIN_WIDTH)
            {
                this.Width = MIN_WIDTH;
            }
        }

        private void ltbLastWord_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbKey_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

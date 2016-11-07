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
    public partial class MainForm : Form
    {
        private const string LOGO_LINK = @"D:\Assignment\OOP\Image\logo.jpg";
        private const int MIN_WIDTH = 795;
        private const int MIN_HEIGHT = 680;
        private Word_Translation_Form wordTrans;
        private Phrase_Translation_Form phraseTrans;

        public MainForm()
        {
            InitializeComponent();
            wordTrans = new Word_Translation_Form();
            phraseTrans = new Phrase_Translation_Form();
            SetMainLogo(LOGO_LINK);
            pnContent.Controls.Add(wordTrans);
            wordTrans.Show();
        }

        private void SetMainLogo(string link)
        {
            Bitmap logo = new Bitmap(new Bitmap(link), new Size(223, 88));
            ptbLogo.Image = logo;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if(this.Width < MIN_WIDTH)
            {
                this.Width = MIN_WIDTH;
            }
            if(this.Height < MIN_HEIGHT)
            {
                this.Height = MIN_HEIGHT;
            }
        }

        private void MainForm_SizeChanging(object sender, EventArgs e)
        {
            pnContent.Width = this.Width - 20;
            pnContent.Height = this.Height - 135;
            wordTrans.ResizeForm(pnContent.Width, pnContent.Height);
        }

        private void lblWordTrans_Click(object sender, EventArgs e)
        {
            this.pnContent.Controls.Clear();
            this.pnContent.Controls.Add(wordTrans);
            phraseTrans.Hide();
            wordTrans.Show();
            lblWordTrans.BackColor = Color.FromArgb(129, 144, 163);
            lblPhraseTrans.BackColor = Color.DodgerBlue;
        }

        private void lblPhraseTrans_Click(object sender, EventArgs e)
        {
            this.pnContent.Controls.Clear();
            this.pnContent.Controls.Add(phraseTrans);
            phraseTrans.Show();
            wordTrans.Hide();
            lblPhraseTrans.BackColor = Color.FromArgb(129, 144, 163);
            lblWordTrans.BackColor = Color.DodgerBlue;
        }
    }
}

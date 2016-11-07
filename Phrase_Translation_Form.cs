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
    public partial class Phrase_Translation_Form : Form
    {
        private const string LOGO_LINK = @"D:\Assignment\OOP\Image\google-logo.png";
        public Phrase_Translation_Form()
        {
            InitializeComponent();
            this.TopLevel = false;
            Bitmap logo = new Bitmap(new Bitmap(LOGO_LINK), 144, 50);
            ptbGoogle.Image = logo;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Phrase_Translation_Form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

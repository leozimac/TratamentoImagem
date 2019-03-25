using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuebraCaptcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            QuebraCaptcha quebraCaptcha = new QuebraCaptcha(@"C:\Users\Pichau\Pictures\", "captchaRN.png");

            captchaAntes.Image = quebraCaptcha.GetCaptchaAntes();

            quebraCaptcha.TratarImagem();

            captchaDepois.Image = quebraCaptcha.GetCaptchaDepois();
        }
    }
}

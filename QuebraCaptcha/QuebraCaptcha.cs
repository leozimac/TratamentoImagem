using System;
using System.Drawing;
using AForge.Imaging.Filters;

namespace QuebraCaptcha
{
    class QuebraCaptcha
    {
        private Bitmap captchaAntes;
        private Bitmap captchaDepois;
        private string enderecoImagem;
        private string nomeImagem;


        public Bitmap GetCaptchaAntes()
        {
            return captchaAntes;
        }

        public Bitmap GetCaptchaDepois()
        {
            return captchaDepois;
        }

        public QuebraCaptcha(string enderecoImagem, string nomeImagem)
        {
            this.enderecoImagem = enderecoImagem;
            this.nomeImagem = nomeImagem;

            if(!string.IsNullOrEmpty(this.enderecoImagem) && !string.IsNullOrEmpty(this.nomeImagem))
                PegarImagem();
        }
        
        private void PegarImagem()
        {
            Bitmap captchaBitmap;
            Image captcha = Image.FromFile($"{enderecoImagem}\\{nomeImagem}");


            if (captcha != null)
            {
                captchaBitmap = new Bitmap(captcha);

                captchaAntes = captchaBitmap;
            }
            else
                throw new Exception("ERRO! Nao encontrou a imagem");

        }

        public void TratarImagem()
        {
            var imagemParaTratamento = Grayscale.CommonAlgorithms.BT709.Apply(captchaAntes);
            Median medianFilter = new Median();

            try
            {
                captchaDepois = medianFilter.Apply(imagemParaTratamento);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro! {ex.Message}");
            }
        }

    }
}

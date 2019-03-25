namespace QuebraCaptcha
{
    partial class Form1
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
            this.captchaAntes = new System.Windows.Forms.PictureBox();
            this.captchaDepois = new System.Windows.Forms.PictureBox();
            this.btnProcessar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.captchaAntes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captchaDepois)).BeginInit();
            this.SuspendLayout();
            // 
            // captchaAntes
            // 
            this.captchaAntes.Location = new System.Drawing.Point(38, 67);
            this.captchaAntes.Name = "captchaAntes";
            this.captchaAntes.Size = new System.Drawing.Size(300, 115);
            this.captchaAntes.TabIndex = 0;
            this.captchaAntes.TabStop = false;
            // 
            // captchaDepois
            // 
            this.captchaDepois.Location = new System.Drawing.Point(403, 67);
            this.captchaDepois.Name = "captchaDepois";
            this.captchaDepois.Size = new System.Drawing.Size(309, 115);
            this.captchaDepois.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.captchaDepois.TabIndex = 1;
            this.captchaDepois.TabStop = false;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(294, 268);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(156, 35);
            this.btnProcessar.TabIndex = 2;
            this.btnProcessar.Text = "Processar Imagem";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.captchaDepois);
            this.Controls.Add(this.captchaAntes);
            this.Name = "Form1";
            this.Text = "Tratamento de Imagens";
            ((System.ComponentModel.ISupportInitialize)(this.captchaAntes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captchaDepois)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox captchaAntes;
        private System.Windows.Forms.PictureBox captchaDepois;
        private System.Windows.Forms.Button btnProcessar;
    }
}


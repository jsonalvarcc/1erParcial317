using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace preg9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Bitmap DetectarBordes(Bitmap imagenOriginal)
        {
            int ancho = imagenOriginal.Width;
            int alto = imagenOriginal.Height;

            Bitmap imagenBordes = new Bitmap(ancho, alto);

            //  kernels de Sobel
            int[,] kernelX = new int[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int[,] kernelY = new int[,] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };

            for (int y = 1; y < alto - 1; y++)
            {
                for (int x = 1; x < ancho - 1; x++)
                {
                    int sumaX = 0;
                    int sumaY = 0;

                    // Aplicar el filtro de Sobel
                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            Color colorPixel = imagenOriginal.GetPixel(x + kx, y + ky);
                            int valorGris = (int)(colorPixel.R * 0.299 + colorPixel.G * 0.587 + colorPixel.B * 0.114); // Convertir a escala de grises

                            sumaX += valorGris * kernelX[ky + 1, kx + 1];
                            sumaY += valorGris * kernelY[ky + 1, kx + 1];
                        }
                    }

                    //  magnitud del gradiente
                    int magnitud = (int)Math.Sqrt(sumaX * sumaX + sumaY * sumaY);
                    magnitud = Math.Min(255, magnitud); // Limitar el valor a 255

                   
                    int valorInvertido = 255 - magnitud;
                    imagenBordes.SetPixel(x, y, Color.FromArgb(valorInvertido, valorInvertido, valorInvertido));
                }
            }

            return imagenBordes;
        }
        private void button1_Click(object sender, EventArgs e)
        {

           
            using (OpenFileDialog cuadroDialogo = new OpenFileDialog())
            {
                cuadroDialogo.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";
                if (cuadroDialogo.ShowDialog() == DialogResult.OK)
                {
                    Bitmap imagenOriginal = new Bitmap(cuadroDialogo.FileName);
                    Bitmap imagenConBordes = DetectarBordes(imagenOriginal);

                
                    pictureBox1.Image = imagenOriginal;
                    pictureBox2.Image = imagenConBordes;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

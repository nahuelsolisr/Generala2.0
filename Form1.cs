using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Yahtzee
{
    public partial class Form1 : Form
    {
        string[] rutasDados = { "cara1.png", "cara2.png", "cara3.png", "cara4.png", "cara5.png", "cara6.png" };
        bool[] retenido = new bool[5];





        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Label[] labelsDados = { lbl_img1, lbl_img2, lbl_img3, lbl_img4, lbl_img5, lbl_img6 };

            // Iterar a través de los Labels y asignarles las imágenes
            for (int i = 0; i < labelsDados.Length; i++)
            {
                try
                {
                    // Crear una imagen pequeña desde la ruta
                    Image imagenOriginal = Image.FromFile(rutasDados[i]);
                    Image imagenReducida = new Bitmap(imagenOriginal, new Size(30, 30)); // Ajustar tamaño de la imagen

                    // Configurar el Label
                    labelsDados[i].Image = imagenReducida; // Asignar la imagen al Label
                    labelsDados[i].ImageAlign = ContentAlignment.MiddleLeft; // Alinear la imagen a la izquierda
                    labelsDados[i].TextAlign = ContentAlignment.MiddleRight; // Alinear el texto a la derecha

                }
                catch (Exception ex)
                {
                    // Manejo de errores en caso de problemas al cargar la imagen
                    MessageBox.Show($"Error al cargar la imagen para lbl_img{i + 1}: {ex.Message}");
                }
            }

 
            // Asignar el evento MouseHover a cada PictureBox
            for (int i = 0; i < 5; i++)
            {
                PictureBox pictureBox = this.Controls.Find($"picture_d{i + 1}", true).FirstOrDefault() as PictureBox;
                if (pictureBox != null)
                {
                    pictureBox.MouseHover += (s, args) => toolTip.SetToolTip(pictureBox, "Haz clic para retener el dado");
                }
            }



        }

        private void btn_lanzar_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();

            // Asignar una imagen aleatoria a cada PictureBox que no esté retenido
            for (int i = 0; i < 5; i++)
            {
                // Solo girar los dados que no estén retenidos
                if (!retenido[i])
                {
                    // Generar un índice aleatorio basado en el número de rutas disponibles
                    int indiceAleatorio = aleatorio.Next(rutasDados.Length);

                    // Obtener el PictureBox por nombre
                    PictureBox pictureBox = this.Controls.Find($"picture_d{i + 1}", true).FirstOrDefault() as PictureBox;

                    if (pictureBox == null)
                    {
                        // Si el PictureBox no existe, crear uno nuevo
                        pictureBox = new PictureBox
                        {
                            Name = $"picture_d{i + 1}",
                            Size = new System.Drawing.Size(90, 90),
                            Location = new System.Drawing.Point(10 + (i * 100), 10), // Espaciado horizontal
                            SizeMode = PictureBoxSizeMode.CenterImage
                        };

                        // Agregar el evento Click para alternar el estado retenido
                        pictureBox.Click += ToggleRetenido;

                        // Agregar el PictureBox al formulario
                        this.Controls.Add(pictureBox);
                    }

                    try
                    {
                        // Cargar y asignar la imagen desde la ruta aleatoria
                        pictureBox.Image = Image.FromFile(rutasDados[indiceAleatorio]);
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores si la imagen no se encuentra o hay un problema al cargarla
                        MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
                    }
                }
            }
        }

        private void ToggleRetenido(object sender, EventArgs e)
        {
            // Obtener el PictureBox que activó el evento
            PictureBox pictureBox = sender as PictureBox;

            if (pictureBox != null)
            {
                // Intentar obtener el número del dado desde el nombre del PictureBox
                int indice;
                if (int.TryParse(pictureBox.Name.Replace("picture_d", ""), out indice))
                {
                    // Ajustar el índice para que sea correcto dentro del arreglo (de 1 basado en nombre a 0 basado en índice)
                    indice -= 1;

                    // Alternar el estado retenido
                    retenido[indice] = !retenido[indice];

                    // Cambiar el borde del PictureBox para indicar visualmente el estado retenido
                    pictureBox.BorderStyle = retenido[indice] ? BorderStyle.Fixed3D : BorderStyle.None;

                    if (retenido[indice])
                    {
                        pictureBox.Location = new Point(pictureBox.Location.X, 28); // Baja el dado
                    }
                    else
                    {
                        pictureBox.Location = new Point(pictureBox.Location.X, 245); // Devuelve el dado a la posición original
                    }



                }
            }
        }
    }

}

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
    public partial class Game : Form


        public Game()
        {
            InitializeComponent();
        }

    

         int variablG=0;
    //

    
 
        string[] rutasDados = { "cara1.png", "cara2.png", "cara3.png", "cara4.png", "cara5.png", "cara6.png" };
     
        bool[] retenido = new bool[5];
        int jugadorActual = 1; // Comenzamos con Player 1
        int lanzamientosRestantes = 3; // Cada jugador tiene 3 lanzamientos por turno
        int[] valorDados = new int[5]; // valor de dado para agregarlo al form
       
//

      //
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_j1_1.Click += JugadaSeleccionada;
            lbl_j1_2.Click += JugadaSeleccionada;
            lbl_j1_3.Click += JugadaSeleccionada;
            lbl_j1_4.Click += JugadaSeleccionada;
            lbl_j1_5.Click += JugadaSeleccionada;
            lbl_j1_6.Click += JugadaSeleccionada;

            // Asignar eventos de clic a los Labels del Jugador 2
            lbl_j2_1.Click += JugadaSeleccionada;
            lbl_j2_2.Click += JugadaSeleccionada;
            lbl_j2_3.Click += JugadaSeleccionada;
            lbl_j2_4.Click += JugadaSeleccionada;
            lbl_j2_5.Click += JugadaSeleccionada;
            lbl_j2_6.Click += JugadaSeleccionada;


            Label[] labelsDados = { lbl_img1, lbl_img2, lbl_img3, lbl_img4, lbl_img5, lbl_img6 };

            //Cargo las imagenes en la izquierda de labels
            for (int i = 0; i < labelsDados.Length; i++)
            {
                try
                {
                    Image imagenOriginal = Image.FromFile(rutasDados[i]);
                    Image imagenReducida = new Bitmap(imagenOriginal, new Size(30, 30));
                    labelsDados[i].Image = imagenReducida;
                    labelsDados[i].ImageAlign = ContentAlignment.MiddleLeft;
                    labelsDados[i].TextAlign = ContentAlignment.MiddleRight;
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error al cargar la imagen para lbl_img{i + 1}: {ex.Message}");
                }
            }
        }

        private void btn_lanzar_Click(object sender, EventArgs e)
        {
            // Verificar si el jugador tiene lanzamientos restantes
            if (lanzamientosRestantes > 0)
            {
                Random aleatorio = new Random();
                int[] valoresDados = new int[5]; // Array para guardar los valores de los dados

                // Asignar una imagen aleatoria a cada PictureBox que no esté retenido
                for (int i = 0; i < 5; i++)
                {
                    if (!retenido[i]) // Solo girar los dados que no están retenidos
                    {
                        valoresDados[i] = aleatorio.Next(1, 7); // Generar valor entre 1 y 6

                        // Obtener el PictureBox por nombre
                        PictureBox pictureBox = this.Controls.Find($"picture_d{i + 1}", true).FirstOrDefault() as PictureBox;

                        if (pictureBox == null)
                        {
                            // Si el PictureBox no existe, crearlo
                            pictureBox = new PictureBox
                            {
                                Name = $"picture_d{i + 1}",
                                Size = new Size(90, 90),
                                Location = new Point(10 + (i * 100), 10), // Espaciado horizontal
                                SizeMode = PictureBoxSizeMode.CenterImage
                            };

                            pictureBox.Click += ToggleRetenido; // Alternar estado retenido con clic
                            this.Controls.Add(pictureBox);
                        }

                        try
                        {
                            // Asignar la imagen correspondiente al dado
                            pictureBox.Image = Image.FromFile(rutasDados[valoresDados[i] - 1]);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
                        }
                    }
                }

                lanzamientosRestantes--; // Reducir el número de lanzamientos restantes

                // Llamar al método `Numeros` para calcular y actualizar los labels del jugador con las jugadas posibles
                Numeros(valoresDados);
                Numeros(valorDados);
                

                // Verificar si ya no quedan lanzamientos
                if (lanzamientosRestantes == 0)
                {
                    MessageBox.Show($"Turno terminado para Jugador {jugadorActual}. ¡Selecciona tu jugada!");
                    HabilitarJugada(jugadorActual); // Habilitar las jugadas para el jugador actual
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una jugada antes de pasar al siguiente turno.");
            }
            MessageBox.Show($"el valor de los dados es: {valorDados[0]}");
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

        private void JugadaSeleccionada(object sender, EventArgs e)
        {
            Label labelSeleccionado = sender as Label; //sender es el objeto que activo el evento(el label que el usuario hizo click)

            if (labelSeleccionado != null && labelSeleccionado.Enabled)
            {
                labelSeleccionado.Enabled = false; // Deshabilitar jugada seleccionada
                MessageBox.Show($"Jugador {jugadorActual} ha seleccionado la jugada: {labelSeleccionado.Text}");

                // Pasar automáticamente al siguiente jugador
                jugadorActual = jugadorActual == 1 ? 2 : 1;
                lanzamientosRestantes = 3; // Reiniciar lanzamientos

                HabilitarJugada(jugadorActual); // Habilitar las jugadas para el siguiente jugador
                MessageBox.Show($"Es el turno del Jugador {jugadorActual}. ¡A lanzar!");
            }
        }

        private void HabilitarJugada(int jugador)
        {
            // Deshabilitar todos los labels
            Label[] labelsTodos = { lbl_j1_1, lbl_j1_2, lbl_j1_3, lbl_j1_4, lbl_j1_5, lbl_j1_6,
                            lbl_j1_escalera, lbl_j1_full, lbl_j1_poker, lbl_j1_generala,
                            lbl_j2_1, lbl_j2_2, lbl_j2_3, lbl_j2_4, lbl_j2_5, lbl_j2_6,
                            lbl_j2_escalera, lbl_j2_full, lbl_j2_poker, lbl_j2_generala };
            foreach (Label lbl in labelsTodos)
            {
                lbl.Enabled = false; // Deshabilitamos todos inicialmente
            }

            // Habilitar solo las jugadas del jugador actual
            if (jugador == 1)
            {
                Label[] labelsJugador1 = { lbl_j1_1, lbl_j1_2, lbl_j1_3, lbl_j1_4, lbl_j1_5, lbl_j1_6,
                                   lbl_j1_escalera, lbl_j1_full, lbl_j1_poker, lbl_j1_generala };
                foreach (Label lbl in labelsJugador1)
                {
                    lbl.Enabled = true;
                }
            }
            else if (jugador == 2)
            {
                Label[] labelsJugador2 = { lbl_j2_1, lbl_j2_2, lbl_j2_3, lbl_j2_4, lbl_j2_5, lbl_j2_6,
                                   lbl_j2_escalera, lbl_j2_full, lbl_j2_poker, lbl_j2_generala };
                foreach (Label lbl in labelsJugador2)
                {
                    lbl.Enabled = true;
                }
            }
        }


        //JUGADAS
        public void Numeros(int[] dados)
        {
            int[] conteoDados = new int[6]; // Contador para cada número del 1 al 6

            foreach (int valor in dados)
            {
                if (valor >= 1 && valor <= 6) conteoDados[valor - 1] += valor;
            }

            // Asignar los valores a los Labels del jugador actual
            if (jugadorActual == 1)
            {
                lbl_j1_1.Text = conteoDados[0] > 0 ? conteoDados[0].ToString() : "";
                lbl_j1_2.Text = conteoDados[1] > 0 ? conteoDados[1].ToString() : "";
                lbl_j1_3.Text = conteoDados[2] > 0 ? conteoDados[2].ToString() : "";
                lbl_j1_4.Text = conteoDados[3] > 0 ? conteoDados[3].ToString() : "";
                lbl_j1_5.Text = conteoDados[4] > 0 ? conteoDados[4].ToString() : "";
                lbl_j1_6.Text = conteoDados[5] > 0 ? conteoDados[5].ToString() : "";

                // Hacer visibles los Labels solo si tienen valores
                lbl_j1_1.Visible = conteoDados[0] > 0;
                lbl_j1_2.Visible = conteoDados[1] > 0;
                lbl_j1_3.Visible = conteoDados[2] > 0;
                lbl_j1_4.Visible = conteoDados[3] > 0;
                lbl_j1_5.Visible = conteoDados[4] > 0;
                lbl_j1_6.Visible = conteoDados[5] > 0;
            }
            else
            {
                lbl_j2_1.Text = conteoDados[0] > 0 ? conteoDados[0].ToString() : "";
                lbl_j2_2.Text = conteoDados[1] > 0 ? conteoDados[1].ToString() : "";
                lbl_j2_3.Text = conteoDados[2] > 0 ? conteoDados[2].ToString() : "";
                lbl_j2_4.Text = conteoDados[3] > 0 ? conteoDados[3].ToString() : "";
                lbl_j2_5.Text = conteoDados[4] > 0 ? conteoDados[4].ToString() : "";
                lbl_j2_6.Text = conteoDados[5] > 0 ? conteoDados[5].ToString() : "";

                // Hacer visibles los Labels solo si tienen valores
                lbl_j2_1.Visible = conteoDados[0] > 0;
                lbl_j2_2.Visible = conteoDados[1] > 0;
                lbl_j2_3.Visible = conteoDados[2] > 0;
                lbl_j2_4.Visible = conteoDados[3] > 0;
                lbl_j2_5.Visible = conteoDados[4] > 0;
                lbl_j2_6.Visible = conteoDados[5] > 0;
            }
        }

        private void lbl_j1_1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_j1_2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_j1_3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_j1_4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_j1_5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_j1_6_Click(object sender, EventArgs e)
        {

        }
    }
}

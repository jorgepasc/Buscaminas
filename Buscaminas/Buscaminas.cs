using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscaminas
{
    /// <summary>
    /// Buscaminas 1ª EVA - Jorge Pascual Cases DUA2-2018
    /// 
    /// En esta solución del buscaminas se utiliza un array de dos dimensiones (columnas y filas) para controlar los límites.
    /// Cuando se pulsa un botón sin mina se le cambia el estilo, y el color acorde a las minas que tiene cerca. 
    /// Con una función recursiva se comprueba si el estilo del boton que se quiere revisar está cambiado.    
    /// </summary>
    public partial class Buscaminas : Form
    {
        Button[,] botones;
        int numColumnas, numFilas, numMinas, numBanderas = 0, numBanderasCorrectas = 0, casillasDesbloqueadas = 0;
        string tamano = "8 X 10", dificultad = "Normal";

        private void mnuClick(object sender, EventArgs e)
        {
            if (sender.ToString().Equals("NORMAL") || sender.ToString().Equals("EXTREMA"))
            {
                dificultad = sender.ToString();
                generarTablero(tamano, dificultad);
            }
            else
            {
                tamano = sender.ToString();
                generarTablero(tamano, dificultad);
            }
        }

        public Buscaminas()
        {
            InitializeComponent();
        }

        private void Buscaminas_Load(object sender, EventArgs e)
        {
            generarTablero(tamano, dificultad);
            this.WindowState = FormWindowState.Maximized; //Maximiza la aplicacion automaticamente
        }

        private void btnTablero_click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            if (e.Button == MouseButtons.Left)//Comprueba si el boton del raton pulsado es el izquierdo o el derecho
            {
                if (btn.ForeColor != DefaultForeColor)//Si pulsa un boton con numero
                {
                    clickarNumero(btn);
                }

                if (btn.BackgroundImage != null && btn.BackgroundImage.Tag.Equals("flag"))//Si hace click izquierdo en una bandera no hace nada
                    return;

                else if (btn.FlatStyle == FlatStyle.Flat)//No deshabilitamos el boton, le cambiamos el estilo  y si vuelve a clickar en el no hace nada               
                    return;

                if (comprobarSiEsMina(btn))//Si pulsa una mina se acaba el juego
                    return;

                
                contarMinas(btn);
                comprobarSiQuedanBotones();
            }
            else if (e.Button == MouseButtons.Right)//Si se ha hecho click derecho se quitará o se pondrá bandera en esa casilla
            {
                Image img = Image.FromFile("flag.png");
                img.Tag = "flag";//Se crea la imagen como objeto para darle un tag y distinguirla de la imagen de mina
                if (btn.FlatStyle == FlatStyle.Flat)
                    return;
                if (btn.BackgroundImage != null && btn.BackgroundImage.Tag.Equals("flag"))//Si ya tiene una bandera la quitamos
                {
                    numBanderas--;//Restamos 1 al numero de banderas puestas                    
                    btn.BackgroundImage = null;
                    label1.Text = (int.Parse(label1.Text) + 1) + "";
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    if (btn.Tag.Equals("mina") && cbMostrar.Checked == true)//Y si es mina y se estan mostrando las minas le actualizamos la imagen
                    {
                        btn.BackgroundImage = Image.FromFile("mina.png");
                        btn.BackgroundImage.Tag = "mina";//Le ponemos tag para cambiar la bandera si le vuelves a dar click dcho
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        numBanderasCorrectas--;//Si quita la bandera que estaba en una mina restamos al contador de banderas correctas
                    }
                }
                else//Si no tiene bandera la ponemos
                {
                    numBanderas++;
                    label1.Text = (int.Parse(label1.Text) - 1) + "";
                    if (btn.Tag.Equals("mina"))//Puede poner la bandera en un sitio incorrecto, Asi que guardamos las correctas en una variable para ir comprobando si ha ganado
                        numBanderasCorrectas++;
                    btn.BackgroundImage = img;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                }
                if (numBanderasCorrectas == numMinas)//Si ya ha marcado todas las minas correctamente, la partida se acaba, el jugador ha ganado
                {
                    MessageBox.Show("Enhorabuena, Has ganado");
                    deshabilitarBotones();
                }
            }
        }

        /// <summary>
        /// Cada vez que se clicka un boton se comprueba si queda alguno que no sea mina por destapar, en caso contrario se habra ganado
        /// </summary>
        private void comprobarSiQuedanBotones()
        {
            int numCasillas = numColumnas * numFilas;
            if(casillasDesbloqueadas == numCasillas - numMinas)
            {
                MessageBox.Show("Enhorabuena, Has ganado");
                deshabilitarBotones();
            }
                
        }

        /// <summary>
        /// Cuando se gana o se pierde se deshabilitan todos los botones y se muestran las minas
        /// </summary>
        private void deshabilitarBotones()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.Enabled = false;
                    cbMostrar.Checked = true;//Al perder mostramos todas las minas
                }
            }
        }

        /// <summary>
        /// Se comprueba el numero de banderas y de banderas correctas que tiene ese numero alrededor, si estan bien puestas se hace la recursiva
        /// </summary>
        /// <param name="btn">El boton que se ha clickado</param>
        private void clickarNumero(Button btn)
        {
            int col = 0, fila = 0;
            int contaBanderas = 0, banderasCorrectas = 0;
            fila = int.Parse(btn.Name.Substring(0, 2));//Obtenemos los indices de la tabla correspondientes al boton de su nombre (le hemos escrito en el nombre su posicion al crearlo)
            col = int.Parse(btn.Name.Substring((btn.Name.IndexOf('-') + 1), 2));

            for (int f = fila - 1; f < fila + 2; f++)//Recorremos todos los  botones de alrededor del pulsado
            {
                for (int c = col - 1; c < col + 2; c++)
                {
                    if (sonValoresValidos(f, c))
                    {
                            if (botones[c, f].BackgroundImage != null && botones[c, f].BackgroundImage.Tag.Equals("flag"))
                            {
                                contaBanderas++;
                                if (botones[c, f].Tag.Equals("mina"))
                                {
                                    banderasCorrectas++;
                                }
                            }
                    }
                }                            
            }

            if (contaBanderas == int.Parse(btn.Text))//Si ha puesto las mismas banderas que numero de minas tiene alrededor...
            {
                if (banderasCorrectas != contaBanderas)//Si estan mal puestas pierde
                {
                    MessageBox.Show("Las banderas estaban mal colocadas. Perdiste");
                    deshabilitarBotones();
                }
                else//Si estan bien puestas se hace la recursiva
                {
                    btn.Tag += "bonus";//Le añadimos al tag un texto para identificarlo y que entre a la recursiva aun siendo un boton ya "revisado"
                    contarMinas(btn);
                }

            }
        }
        /// <summary>
        /// Comprueba si el boton clickado es bomba o no, en caso de serlo se pierde la partida
        /// </summary>
        /// <param name="btn">El boton clickado</param>
        /// <returns>True si el boton es mina, false si no lo es</returns>
        private bool comprobarSiEsMina(Button btn)
        {
            //Si pulsa una mina se pierde y se bloquean todos los botones
            if (btn.Tag.Equals("mina"))
            {
                btn.BackColor = Color.Red;
                MessageBox.Show("Perdiste, has pulsado una mina");
                deshabilitarBotones();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Cuenta el numero de minas que tiene el boton en las casillas de alrededor y si es 0 hace la recursiva llamando a la misma funcion con los botones de alrededor
        /// </summary>
        /// <param name="btn">El boton que se quiere gestionar</param>
        private void contarMinas(Button btn)
        {
            int col = 0, fila = 0;

            fila = int.Parse(btn.Name.Substring(0, 2));//Obtenemos las coordenadas del boton del name
            col = int.Parse(btn.Name.Substring((btn.Name.IndexOf('-') + 1), 2));

            int contaMinas = 0;
            if (sonValoresValidos(fila, col))
            {
                if (botones[col, fila].Tag.ToString().Contains("bonus") || botones[col, fila].FlatStyle != FlatStyle.Flat)//Si el boton tiene flatstyle flat ya esta revisado, asi que nos lo saltamos y evitamos bucles infinitos, excepto que sea el boton clickado con banderas alrededor(bonus)
                {                    
                    contaMinas = revisarAlrededor(fila, col);                    

                    if(botones[col, fila].FlatStyle != FlatStyle.Flat)
                        cambiarEstiloBoton(fila, col, contaMinas);

                    if (contaMinas == 0 || botones[col, fila].Tag.ToString().Contains("bonus"))//Si contaminas es 0 hacemos la recursiva(la forzamos con el tag en el caso del bonus)
                    {
                        int f = 0, c = 0;
                        for (f = fila - 1; f < fila + 2; f++)//Recorremos todos los  botones de alrededor del pulsado
                        {
                            for (c = col - 1; c < col + 2; c++)
                            {
                                if (sonValoresValidos(f, c) && botones[c, f].Tag.ToString().Equals(""))//Si existe el boton y no es mina cuenta las minas del nuevo boton
                                {
                                    contarMinas(botones[c, f]);
                                }
                            }
                        }
                    }
                    
                }
            }

        }

        /// <summary>
        /// Le ponemos estilo flat, color, y el texto con el numero de minas que tiene cerca
        /// </summary>
        /// <param name="fila">Coordenadas del boton</param>
        /// <param name="col">Coordenadas del boton</param>
        /// <param name="contaMinas">Numero de minas que tiene el boton alrededor</param>
        private void cambiarEstiloBoton(int fila, int col, int contaMinas)
        {
            botones[col, fila].FlatStyle = FlatStyle.Flat;
            botones[col, fila].Font = new Font("Arial", 12, FontStyle.Bold);
            casillasDesbloqueadas++;

            if (contaMinas == 0)
                botones[col, fila].Text = "";
            else
                botones[col, fila].Text = contaMinas.ToString();

            if (contaMinas == 1)
                botones[col, fila].ForeColor = Color.Blue;
            else if (contaMinas == 2)
                botones[col, fila].ForeColor = Color.ForestGreen;
            else if (contaMinas == 3)
                botones[col, fila].ForeColor = Color.Red;
            else if (contaMinas == 4)
                botones[col, fila].ForeColor = Color.DarkBlue;
            else if (contaMinas == 5)
                botones[col, fila].ForeColor = Color.IndianRed;
            else if (contaMinas == 5)
                botones[col, fila].ForeColor = Color.LightCyan;
        }

        /// <summary>
        /// Si la fila o columna se sale de los limites (es menor que 0 o mayor que el indice maximo) devuelve false
        /// </summary>
        /// <param name="fila"></param>
        /// <param name="col"></param>
        private bool sonValoresValidos(int fila, int col)
        {
            bool valido = true;

            if (fila < 0)
                valido = false;
            else if (fila >= numFilas)
                valido = false;
            else if (col < 0)
                valido = false;
            else if (col >= numColumnas)
                valido = false;

            return valido;

        }

        /// <summary>
        /// Recorre los botones de alrededor de las coordenadas dadas por parametros y cuenta minas
        /// </summary>
        /// <param name="filaOrig"></param>
        /// <param name="colOrig"></param>       
        /// <returns>Devuelve el numero de minas encontradas</returns>
        private int revisarAlrededor(int filaOrig, int colOrig)
        {
            int contaMinas = 0;
            int f = 0, c = 0;

            for (f = filaOrig - 1; f < filaOrig + 2; f++)//Recorremos todos los  botones de alrededor del pulsado
            {
                for (c = colOrig - 1; c < colOrig + 2; c++)
                {
                    if (sonValoresValidos(f, c))
                    {
                        if (botones[c, f].Tag.ToString().Equals("mina"))
                        {
                            contaMinas++;
                        }
                    }
                }
            }//for
            
            return contaMinas;
        }

        /// <summary>
        /// Generamos el tablero con el tamaño y dificultad que se ha escogido
        /// </summary>
        /// <param name="tamano">Tamaño escogido</param>
        /// <param name="dificultad">Dificultad escogida</param>
        private void generarTablero(string tamano, string dificultad)
        {
            if (botones != null)//Si ya habia un tablero creado lo resetea
            {
                borrarTablero(botones);
            }

            numBanderas = 0;//Cuando se genera el tablero ponemos a 0 las dos variables que cuentan las banderas
            numBanderasCorrectas = 0;
            numColumnas = int.Parse(tamano.Substring(0, tamano.IndexOf(' ')));//obtiene el numero que hay antes del ' ' Ej: 8 en  "8 X 10"
            numFilas = int.Parse(tamano.Substring(tamano.IndexOf('X') + 1));//obtiene el numero que hay detrás del 'X' Ej: 10 en  "8 X 10"                                                                            

            int ancho = 35;
            int alto = 35;
            int izquierda = 35;
            int altura = 35;

            botones = new Button[numColumnas, numFilas];

            for (int fila = 0; fila < numFilas; fila++)
            {
                for (int col = 0; col < numColumnas; col++)
                {
                    botones[col, fila] = new Button();
                    botones[col, fila].Width = ancho;
                    botones[col, fila].Height = alto;
                    botones[col, fila].Left = (col + 1) * izquierda;
                    botones[col, fila].Top = (fila + 1) * altura;
                    botones[col, fila].MouseDown += new MouseEventHandler(btnTablero_click);
                    botones[col, fila].Tag = "";//Inicializamos el tag con cadena vacía para evitar excepciones al comprobarlo
                    if (fila < 10)/*Guardamos las coordenadas en dos cifras del name separadas por un guion*/
                    {
                        if (col < 10)
                            botones[col, fila].Name = "0" + fila + "-" + "0" + col;
                        else
                            botones[col, fila].Name = "0" + fila + "-" + col;
                    }
                    else
                    {
                        if (col < 10)
                            botones[col, fila].Name = fila + "-" + "0" + col;
                        else
                            botones[col, fila].Name = fila + "-" + col;
                    }
                    Controls.Add(botones[col, fila]);
                }
            }
            botones = generarMinas(botones, (numColumnas * numFilas), dificultad);
        }

        /// <summary>
        /// Borra de la pantalla los botones
        /// </summary>
        /// <param name="botones">Matriz con los botones anteriores</param>
        public void borrarTablero(Button[,] botones)
        {

            for (int fila = 0; fila < numFilas; fila++)
            {
                for (int col = 0; col < numColumnas; col++)
                    Controls.Remove(botones[col, fila]);
            }
        }

        /// <summary>
        /// Genera aleatoriamente minas en algunas casillas
        /// </summary>
        /// <param name="botones">Matriz que contiene todos los botones</param>
        /// <param name="numCasillas">Filas * Columnas</param>
        /// <param name="dificultad">Dificultad en la que se esta jugando</param>
        /// <returns></returns>
        public Button[,] generarMinas(Button[,] botones, int numCasillas, string dificultad)
        {
            Random rnd = new Random();
            switch (numCasillas)//Dependiendo del numero de casillas ponemos mas o menos bombas
            {
                case 80:
                    if (dificultad.ToUpper().Equals("NORMAL"))
                        numMinas = 10;
                    else if (dificultad.ToUpper().Equals("EXTREMA"))
                        numMinas = 16;
                    break;
                case 240:
                    if (dificultad.ToUpper().Equals("NORMAL"))
                        numMinas = 35;
                    else if (dificultad.ToUpper().Equals("EXTREMA"))
                        numMinas = 48;
                    break;
                case 600:
                    if (dificultad.ToUpper().Equals("NORMAL"))
                        numMinas = 75;
                    else if (dificultad.ToUpper().Equals("EXTREMA"))
                        numMinas = 95;
                    break;
            }
            for (int i = 0; i < numMinas; i++)
            {
                int indiceCol, indiceFila;
                do
                {
                    indiceCol = rnd.Next(0, numColumnas);//Generamos un numero al azar entre 0 y el maximo de columnas
                    indiceFila = rnd.Next(0, numFilas);//Generamos un numero al azar entre 0 y el maximo de filas
                } while (botones[indiceCol, indiceFila].Tag.ToString().Equals("mina"));//Genera coords al azar hasta que el boton no sea mina
                botones[indiceCol, indiceFila].Tag = "mina";
                if (cbMostrar.Checked)//cada vez que se genere el tablero hay que comprobar si se quiere que se visualicen o no
                {
                    botones[indiceCol, indiceFila].BackgroundImage = Image.FromFile("mina.png");
                    botones[indiceCol, indiceFila].BackgroundImage.Tag = "mina";
                    botones[indiceCol, indiceFila].BackgroundImageLayout = ImageLayout.Stretch;
                }

            }
            label1.Text = numMinas + "";//Inicializamos el texto numero de minas restantes
            return botones;
        }

        /// <summary>
        /// Cada vez que se marca o desmarca el checkbox se ponen o se quitan las imagenes de las minas
        /// </summary>
        /// <param name="sender">Checkbox</param>
        /// <param name="e"></param>
        private void mostrarMinas(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)//Si quiere mostrar las minas, recorremos el tablero y cuando la casilla sea mina le ponemos la imagen
            {
                for (int fila = 0; fila < numFilas; fila++)
                {
                    for (int col = 0; col < numColumnas; col++)
                    {
                        if ("mina".Equals(botones[col, fila].Tag))//Para los botones que tienen mina comprueba si están coloreados o no
                        {
                            if (botones[col, fila].BackgroundImage == null)//Si ya tiene imagen es que tiene una bandera
                            {
                                botones[col, fila].BackgroundImage = Image.FromFile("mina.png");
                                botones[col, fila].BackgroundImage.Tag = "mina";//Le ponemos tag para cambiar la bandera si le vuelves a dar click dcho
                                botones[col, fila].BackgroundImageLayout = ImageLayout.Stretch;
                            }

                        }
                    }
                }
            }
            else
            {//Si quiere esconder las minas recorremos el tablero y si la casilla es mina y no tiene bandera borramos la imagen
                for (int fila = 0; fila < numFilas; fila++)
                {
                    for (int col = 0; col < numColumnas; col++)
                    {
                        if ("mina".Equals(botones[col, fila].Tag))//Para los botones que tienen mina comprueba si están con imagen o no
                        {
                            if (botones[col, fila].BackgroundImage != null && !botones[col, fila].BackgroundImage.Tag.Equals("flag"))//Le hemos puesto tag a la imagen para diferenciar entre bandera y mina
                            {
                                botones[col, fila].BackgroundImage = null;
                            }
                        }
                    }
                }
            }
        }
    }
}
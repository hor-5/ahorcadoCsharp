using MaterialSkin;
using MaterialSkin.Controls;

namespace Ahorcado
{
    public partial class FrmMain : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;
        
        private char[] aLetters;
        private char[] aToComplete;
        //List<char> usedLetters = new List<char>();
        String currentWord;
        int fails = 0;
        public FrmMain()
        {
            InitializeComponent();            
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue700, TextShade.WHITE);
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Length > 0)
            {
                lblNotificacion.Text = "Ingreso exitoso!";                
                lblNotificacion.BackColor = Color.Green;
                lblNotificacion.ForeColor = Color.White;
                lblNotificacion.Visible = true;                
                cardUser.Visible = false;
                lblTitulo.Text = "Bienvenido " + txtUsuario.Text;
                lblTitulo.Visible = true;
                cardGame.Visible = true;
                currentWord = setWord();                
            }
            else {
                lblNotificacion.Text = "Ingrese un nickname!";                
                lblNotificacion.BackColor = Color.Red;
                lblNotificacion.ForeColor = Color.White;                
                lblNotificacion.Visible = true;
                txtUsuario.Text = "";
            }
            lblNotificacion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }
        private string setWord() {
            string[] aWords = new string[5] { "elocuente", "rojo", "silbar", "tecnologia", "asincrono" };
            lblPalabra.Text = "";            
            Random random = new Random();
            int value = random.Next(aWords.Length);
            int aLength = aWords[value].Length;
            aToComplete = new char[aLength];
            for (int i = 0; i < aLength; i++) {
                lblPalabra.Text += " _ ";
                aToComplete[i] = '_';                
            }            
            return aWords[value];            
        }
        private Boolean checkWord(char letter) {

            Boolean result = false;
            aLetters = currentWord.ToCharArray();
            int cont = 0;
            string word = "";
            foreach (char character in aLetters) {
                if (character == letter)
                {                    
                    aToComplete[cont] = letter;                                       
                    result = true;
                    word += aToComplete[cont].ToString();
                }
                else {
                    if (aToComplete[cont] == '_')
                    {
                        word += " _ ";
                    }
                    else {
                        word += aToComplete[cont].ToString();
                    }
                }
                cont++;
            }
            
            lblPalabra.Text = word;

            return result;
        }
        private void btnRetry_Click(object sender, EventArgs e)
        {
            currentWord = setWord();
            txtLetra.Visible = true;
            btnJugar.Visible = true;
            fails = 0;

            string imagePath = Path.Combine(Application.StartupPath, "../../../img/inicial.PNG");
            imgAhorcado.Image = Image.FromFile(imagePath);
            imgAhorcado.Visible = false;
            lblJugadas.Visible = false;
            
        }
        private void showWrongLetter() {
            char letter = char.Parse(txtLetra.Text);

            lblJugadas.Text += "- " + txtLetra.Text + " ";
             //usedLetters.Add(letter);
                       

            lblJugadas.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {            
            if (txtLetra.Text.Trim().Length == 1)
            {
                char letter = char.Parse(txtLetra.Text.ToLower());
                if (checkWord(letter))
                {
                    lblNotificacion.Text = "La letra " + letter + " es parte de la palabra";
                    lblNotificacion.BackColor = Color.Blue;
                }
                else {                    
                    lblNotificacion.Text = "Buen intento, pero no!";
                    lblNotificacion.BackColor = Color.CadetBlue;
                    fails++;


                    switch (fails) {
                        case 1:
                            lblJugadas.Visible = true;
                            lblJugadas.Text = "Intentos: ";
                            imgAhorcado.Visible = true;
                            lblJugadas.ForeColor = Color.OrangeRed;
                            showWrongLetter();
                            break;
                        case 2:
                            string imagePath = Path.Combine(Application.StartupPath, "../../../img/2.png");
                            imgAhorcado.Image = Image.FromFile(imagePath);
                            showWrongLetter();
                            
                            break;
                        case 3:
                            imagePath = Path.Combine(Application.StartupPath, "../../../img/3.png");
                            imgAhorcado.Image = Image.FromFile(imagePath);
                            showWrongLetter();
                            break;
                        case 4:
                            imagePath = Path.Combine(Application.StartupPath, "../../../img/4.png");
                            imgAhorcado.Image = Image.FromFile(imagePath);
                            showWrongLetter();
                            break;
                        case 5:
                            imagePath = Path.Combine(Application.StartupPath, "../../../img/5.png");
                            imgAhorcado.Image = Image.FromFile(imagePath);
                            showWrongLetter();
                            break;
                        case 6:
                            imagePath = Path.Combine(Application.StartupPath, "../../../img/6.png");
                            imgAhorcado.Image = Image.FromFile(imagePath);
                            showWrongLetter();                            
                            lblNotificacion.Text = "GAME OVER :/";
                            lblNotificacion.BackColor = Color.Red;                            
                            txtLetra.Visible = false;
                            btnJugar.Visible = false;                            
                            break;
                    }
                }

                
                
            }
            else {
                lblNotificacion.Text = "Ingrese una letra!";
                lblNotificacion.BackColor = Color.OrangeRed;
            }

            txtLetra.Text = "";
            if (!aToComplete.Contains('_')) {
                lblNotificacion.Text = "Ganaste!!";
                lblNotificacion.BackColor = Color.Green;
                txtLetra.Visible = false;
            }
        }

    }
}
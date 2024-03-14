namespace track__bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trb_Tamano_Scroll(object sender, EventArgs e)
        {

            trb_Tamano.Minimum
                = 1;

            // Actualiza el tamaño de fuente del Label con el valor del TrackBar
            lbl_Texto.Font = new System.Drawing.Font(lbl_Texto.Font.FontFamily, trb_Tamano.Value);
            // Muestra el valor actual del TrackBar en el Label
            lbl_Tamano.Text = "Tamaño de fuente: " + trb_Tamano.Value.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

namespace winAppCompraInteractiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                picRopa1.Image = Image.FromFile("C:\\Users\\SOFTWARE.DESKTOP-1UFNM14\\Documents\\winAppCompraInteractiva\\winAppCompraInteractiva\\resources\\ropa\\camisa.jpg");

            }
            else
            {
                picRopa1.Image = null;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                picRopa2.Image = Image.FromFile("C:\\Users\\SOFTWARE.DESKTOP-1UFNM14\\Documents\\winAppCompraInteractiva\\winAppCompraInteractiva\\resources\\ropa\\pantalon.jpg");

            }
            else
            {
                picRopa2.Image = null;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                picRopa3.Image = Image.FromFile("C:\\Users\\SOFTWARE.DESKTOP-1UFNM14\\Documents\\winAppCompraInteractiva\\winAppCompraInteractiva\\resources\\ropa\\zapato.jpg");

            }
            else
            {
                picRopa3.Image = null;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                picTranporte.Image = Image.FromFile("C:\\Users\\SOFTWARE.DESKTOP-1UFNM14\\Documents\\winAppCompraInteractiva\\winAppCompraInteractiva\\resources\\transporte\\bus.jpg");

            }
            else
            {
                picTranporte.Image = Image.FromFile("C:\\Users\\SOFTWARE.DESKTOP-1UFNM14\\Documents\\winAppCompraInteractiva\\winAppCompraInteractiva\\resources\\transporte\\taxi.jpg");

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
    
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                picTranporte.Image = Image.FromFile("C:\\Users\\SOFTWARE.DESKTOP-1UFNM14\\Documents\\winAppCompraInteractiva\\winAppCompraInteractiva\\resources\\transporte\\bus.jpg");

            }
            else
            {
                picTranporte.Image = Image.FromFile("C:\\Users\\SOFTWARE.DESKTOP-1UFNM14\\Documents\\winAppCompraInteractiva\\winAppCompraInteractiva\\resources\\transporte\\taxi.jpg");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    picJugos.Image = Image.FromFile("C:\\Users\\SOFTWARE.DESKTOP-1UFNM14\\Documents\\winAppCompraInteractiva\\winAppCompraInteractiva\\resources\\jugos\\mora.jpg");
                    break;
                case 1:
                    picJugos.Image = Image.FromFile("C:\\Users\\SOFTWARE.DESKTOP-1UFNM14\\Documents\\winAppCompraInteractiva\\winAppCompraInteractiva\\resources\\jugos\\frutilla.png");

                    break;
                case 2:
                    picJugos.Image = Image.FromFile("C:\\Users\\SOFTWARE.DESKTOP-1UFNM14\\Documents\\winAppCompraInteractiva\\winAppCompraInteractiva\\resources\\jugos\\mango.jpg");

                    break;
                default:
                    break;
            }
        }
    }
}
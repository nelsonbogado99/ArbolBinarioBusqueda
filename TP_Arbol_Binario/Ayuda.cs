using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace TP_Arbol_Binario
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Users\Nelson\Desktop\Materias 2022\LP2\TP_Arbol_Binario\TP_Arbol_Binario\bin\Debug\net5.0-windows\sonido\haga-clic-en_4.wav");
            sonido.Play();
            Close();
        }
    }
}

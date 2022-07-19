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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnMultiplo2.Visible = false;
            btnMultiplo3.Visible = false;
            btnMultiplo5.Visible = false;
            panel3.Visible = false;
            a();
        }

        int Dato = 0;
        Boolean  rrr =false;
        public Graphics c;
        public Graphics[] af = new Graphics[10];
        bool aaa= false;
        int ccc = 0;
        Arbol_ABB Arbol = new Arbol_ABB();

        private void btnAltura_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Users\Nelson\Desktop\Materias 2022\LP2\TP_Arbol_Binario\TP_Arbol_Binario\bin\Debug\net5.0-windows\sonido\haga-clic-en_4.wav");
            sonido.Play();
            Arbol.ImprimirAltura();
            panel3.Visible = false;
        }

        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Users\Nelson\Desktop\Materias 2022\LP2\TP_Arbol_Binario\TP_Arbol_Binario\bin\Debug\net5.0-windows\sonido\haga-clic-en_4.wav");
            sonido.Play();
            if (Arbol.raiz != null)
            {
                panel3.Visible = true;
                txtPosOrden.Clear();
               // txtPosOrden.Focus();
                txtPreOrden.Clear();
               // txtPreOrden.Focus();
                txtInOrden.Clear();
               // txtInOrden.Focus();

                Arbol.inorden = "";
                Arbol.posorden = "";
                Arbol.preorden = "";

                Refresh();
               // Refresh();
               // Arbol.Recorrido();
                txtPosOrden.Text = Arbol.posorden;
                txtInOrden.Text = Arbol.inorden;
                txtPreOrden.Text = Arbol.preorden;
                aaa = true;
                MessageBox.Show("nelson"+c);
                //  Arbol.PArbol(c, this.Font, Brushes.Black, Brushes.White, Pens.Black, Brushes.White);
            }
            else
            {
                MessageBox.Show("El arbol esta vacio.");
            }
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Users\Nelson\Desktop\Materias 2022\LP2\TP_Arbol_Binario\TP_Arbol_Binario\bin\Debug\net5.0-windows\sonido\haga-clic-en_4.wav");
            sonido.Play();
            Arbol.Menor();
            panel3.Visible = false;
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Users\Nelson\Desktop\Materias 2022\LP2\TP_Arbol_Binario\TP_Arbol_Binario\bin\Debug\net5.0-windows\sonido\haga-clic-en_4.wav");
            sonido.Play();
            Arbol.Mayor();
            panel3.Visible = false;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Users\Nelson\Desktop\Materias 2022\LP2\TP_Arbol_Binario\TP_Arbol_Binario\bin\Debug\net5.0-windows\sonido\haga-clic-en_4.wav");
            sonido.Play();
            Arbol.Multiplos(6);
            panel3.Visible = false;
        }

        private void btnMultiples_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Users\Nelson\Desktop\Materias 2022\LP2\TP_Arbol_Binario\TP_Arbol_Binario\bin\Debug\net5.0-windows\sonido\haga-clic-en_4.wav");
            sonido.Play();
            btnMultiplo2.Visible = true;
            btnMultiplo3.Visible = true;
            btnMultiplo5.Visible = true;
        }

        private void btnMultiplo2_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Users\Nelson\Desktop\Materias 2022\LP2\TP_Arbol_Binario\TP_Arbol_Binario\bin\Debug\net5.0-windows\sonido\haga-clic-en_4.wav");
            sonido.Play();
            Arbol.Multiplos(2);
            panel3.Visible = false;
        }

        private void btnMultiplo3_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Users\Nelson\Desktop\Materias 2022\LP2\TP_Arbol_Binario\TP_Arbol_Binario\bin\Debug\net5.0-windows\sonido\haga-clic-en_4.wav");
            sonido.Play();
            panel3.Visible = false;
            Arbol.Multiplos(3);
        }

        private void btnMultiplo5_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Users\Nelson\Desktop\Materias 2022\LP2\TP_Arbol_Binario\TP_Arbol_Binario\bin\Debug\net5.0-windows\sonido\haga-clic-en_4.wav");
            sonido.Play();
            Arbol.Multiplos(5);
            panel3.Visible = false;
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            SoundPlayer sonido = new SoundPlayer(@"C:\Users\Nelson\Desktop\Materias 2022\LP2\TP_Arbol_Binario\TP_Arbol_Binario\bin\Debug\net5.0-windows\sonido\haga-clic-en_4.wav");
            sonido.Play();
            if (txtInfo.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                Dato = int.Parse(txtInfo.Text);
               

                Arbol.Nodo(Dato, 001);

                Arbol.AlturaArbol(Dato);
                txtInfo.Clear();
                //txtInfo.Focus();


               // Refresh();
                Refresh();
                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            SoundPlayer sonido = new SoundPlayer(@"C:\Users\Nelson\Desktop\Materias 2022\LP2\TP_Arbol_Binario\TP_Arbol_Binario\bin\Debug\net5.0-windows\sonido\haga-clic-en_4.wav");
            sonido.Play();
            if (txtInfo.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                Dato = int.Parse(txtInfo.Text);
               
                Arbol.EliminarNodo(Dato);
                

                txtInfo.Clear();


                Refresh();

               
            }

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            SoundPlayer sonido = new SoundPlayer(@"C:\Users\Nelson\Desktop\Materias 2022\LP2\TP_Arbol_Binario\TP_Arbol_Binario\bin\Debug\net5.0-windows\sonido\haga-clic-en_4.wav");
            sonido.Play();
            if (txtInfo.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                Dato = int.Parse(txtInfo.Text);
                Arbol.BuscarNodo(Dato);

                txtInfo.Clear();
               // txtInfo.Focus();


                Refresh();
               // Refresh();
               
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Users\Nelson\Desktop\Materias 2022\LP2\TP_Arbol_Binario\TP_Arbol_Binario\bin\Debug\net5.0-windows\sonido\haga-clic-en_4.wav");
            sonido.Play();
            Ayuda Ay = new Ayuda();
            Ay.Show();


        }

        //Font ca;

        private void Form1_Click(object sender, PaintEventArgs e)
        {
            c = e.Graphics;
            af[ccc] = e.Graphics;
           /// ca = this.Font;
          // MessageBox.Show("ho" + c.ToString());
            Arbol.Arbol(c, this.Font, Brushes.CadetBlue, Brushes.White, Pens.Black, Brushes.White);

            if (aaa == true)
            {
                MessageBox.Show("Nelsona");
                //Arbol.Arbol(c, this.Font, Brushes.Black, Brushes.White, Pens.Black, Brushes.White);
                Arbol.colorear(c,this.Font, Brushes.Black, Brushes.White, Pens.Black, Arbol.raiz, aaa);

            }
        }

        /*  private void Form1_Load(object sender, EventArgs e)
          {
              c = e.Graphics;
               MessageBox.Show("hola" + c.ToString());
          }*/
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nelson");
        }

        public void Form1_Load(object sender, PaintEventArgs e)
        {
            c = e.Graphics;
            af[ccc] = c;
            ccc++;
          //  MessageBox.Show("hola" +c);
            Arbol.Arbol(c, this.Font, Brushes.CadetBlue, Brushes.White, Pens.Black, Brushes.White);
            if (aaa == true)
            {
                MessageBox.Show("Nelsona");
                //Arbol.Arbol(c, this.Font, Brushes.Black, Brushes.White, Pens.Black, Brushes.White);
                Arbol.colorear(c, this.Font, Brushes.Black, Brushes.White, Pens.Black, Arbol.raiz, aaa);

            }


        }


        PaintEventArgs ac;
        private void a()
        {
            PaintEventArgs ac;
          //  c = ac.Graphics;
            MessageBox.Show("hol" + c);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("hola" + e);
            //Form1_Load(sender, e);
            // Arbol.PArbol(, this.Font, Brushes.CadetBlue, Brushes.White, Pens.Black, Brushes.White);
        }
    }
}

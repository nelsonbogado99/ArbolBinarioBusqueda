﻿using System;
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
            panel4.Visible = false;
            panel5.Visible = false;
            a();
        }

        int Dato = 0;
        Boolean  rrr =false;
        public Graphics c;
        public Graphics[] af = new Graphics[10];
        bool aaa= false;
        bool preorden = false;
        bool inorden = false;
        bool posorden = false;
        int ccc = 0;
        Arbol_ABB Arbol = new Arbol_ABB();

        private void btnAltura_Click(object sender, EventArgs e)
        {
           // SoundPlayer sonido = new SoundPlayer(@"C:\Users\Nelson\Desktop\Materias 2022\LP2\TP_Arbol_Binario\TP_Arbol_Binario\bin\Debug\net5.0-windows\sonido\haga-clic-en_4.wav");
           // sonido.Play();
            Arbol.ImprimirAltura();
            panel3.Visible = false;
        }

        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            
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
                Arbol.Preorden = "";

                Refresh();
      
                txtPosOrden.Text = Arbol.posorden;
                txtInOrden.Text = Arbol.inorden;
                txtPreOrden.Text = Arbol.Preorden;
              
                MessageBox.Show("nelson"+c);
            }
            else
            {
                MessageBox.Show("El arbol esta vacio.");
            }
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
           // SoundPlayer sonido = new SoundPlayer(@"C:\Users\Nelson\Desktop\Materias 2022\LP2\TP_Arbol_Binario\TP_Arbol_Binario\bin\Debug\net5.0-windows\sonido\haga-clic-en_4.wav");
            //sonido.Play();
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
           
            if (txtInfo.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                Dato = int.Parse(txtInfo.Text);
                Arbol.BuscarNodo(Dato);

                txtInfo.Clear();
            
                Refresh();
               
               
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            
            Ayuda Ay = new Ayuda();
            Ay.Show();


        }

        

        

        
   

        public void Form1_Load(object sender, PaintEventArgs e)
        {
            c = e.Graphics;

            
            Arbol.Arbol(c, this.Font, Brushes.CadetBlue, Brushes.White, Pens.Black, Brushes.White);
          

            if (preorden == true)
            {
                Arbol.colorear(c, this.Font, Brushes.OliveDrab, Brushes.White, Pens.Black, Arbol.raiz, inorden, posorden, preorden);
                
                panel3.Visible = true;
               // txtPreOrden.Clear();
                Arbol.Preorden = "";

               /* Refresh();*/

                
                txtPreOrden.Text = Arbol.Preorden;
                preorden = false;
                posorden = false;
                inorden = false;
            }
            else if (inorden ==  true)
            {
                Arbol.colorear(c, this.Font, Brushes.OliveDrab, Brushes.White, Pens.Black, Arbol.raiz, inorden, posorden, preorden);
                Arbol.Recorrido2();
                preorden = false;
                posorden = false;
                inorden = false;
            }
            else if (posorden == true)
            {
                Arbol.colorear(c, this.Font, Brushes.OliveDrab, Brushes.White, Pens.Black, Arbol.raiz, inorden, posorden, preorden);
                Arbol.Recorrido2();
                preorden = false;
                posorden = false;
                inorden = false;
            }


        }


       // PaintEventArgs ac;
        private void a()
        {
            PaintEventArgs ac;
          
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Arbol.Recorrido2();
            preorden = true;
            posorden = false;
            inorden = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arbol.Recorrido2();
            preorden = false;
            posorden = true;
            inorden = false;
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arbol.Recorrido2();
            preorden = false;
            posorden = false;
            inorden = true; 
        }


        bool ac = false;
        private void button4_Click(object sender, EventArgs e)
        {
            ac = false;
            Arbol.Recorrido(ac);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ac = true;
            Arbol.Recorrido(ac);
        }

        private void txtInOrden_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

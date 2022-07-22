using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace TP_Arbol_Binario
{
    class nodoArbol
    {

        private int info;  // para guardar los datos 
        public int altura = 1;
        private nodoArbol izq; // apuntador para el nodo izquierdo
        private nodoArbol der;// apuntador para el nodo derecho

        public int Info
        {
            get { return info; }
            set { info = value; }

        }

        public nodoArbol Izq
        {
            get { return izq; }
            set { izq = value; }
        }

        public nodoArbol Der
        {
            get { return der; }
            set { der = value; }

        }



        private const int Radio = 30;  //verifica el tamaño de cada nodo
        private const int DistanciaH = 80;  // para la distancia horizontal para los nodos
        private const int DistanciaV = 10; // para la distancia vertical para los nodos

        private int CoordenadaX;
        private int CoordenadaY;

        //metodo que busca la posicion en donde dibujar el nodo
        public void PosicionNodo(ref int xmin, int ymin)
        {
            int aux1, aux2;
            CoordenadaY = (int)(ymin + Radio / 2);

            if (Izq != null)
            {
                Izq.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }

            if ((Izq != null) && (Der != null))
            {
                xmin += DistanciaH;
            }

            if (Der != null)
            {
                Der.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }

            if (Izq != null && Der != null)
            {
                CoordenadaX = (int)((Izq.CoordenadaX + Der.CoordenadaX) / 2);
            }
            else if (Izq != null)
            {
                aux1 = Izq.CoordenadaX;
                Izq.CoordenadaX = CoordenadaX - 80;
                CoordenadaX = aux1;
            }
            else if (Der != null)
            {
                aux2 = Der.CoordenadaX;
                Der.CoordenadaX = CoordenadaX + 80;
                CoordenadaX = aux2;
            }
            else
            {
                CoordenadaX = (int)(xmin + Radio / 2);
                xmin += Radio;
            }
        }

        // metodo para dibujar las ramas del arbol
        public void Ramas(Graphics grafo, Pen lapiz)
        {
            if (Izq != null) // pone las ramas a todo los nodos izquierdos del arbol
            {
                grafo.DrawLine(lapiz, CoordenadaX, CoordenadaY, Izq.CoordenadaX, Izq.CoordenadaY);
                Izq.Ramas(grafo, lapiz);
            }

            if (Der != null) // pone las ramas a todo los nodos derechos del arbol
            {
                grafo.DrawLine(lapiz, CoordenadaX, CoordenadaY, Der.CoordenadaX, Der.CoordenadaY);
                Der.Ramas(grafo, lapiz);
            }
        }

        // metodo para dibujar el nodo
        public void Nodo(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen lapiz, Brush encuentro)
        {
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            // MessageBox.Show("ll" + encuentro);
            grafo.FillEllipse(encuentro, rect);
            grafo.FillEllipse(Relleno, rect);
            grafo.DrawEllipse(lapiz, rect); //se dibujar el nodo

            StringFormat forma = new StringFormat(); // se prepara para mostrar los datos 

            forma.Alignment = StringAlignment.Center;
            forma.LineAlignment = StringAlignment.Center;
            grafo.DrawString(info.ToString(), fuente, RellenoFuente, CoordenadaX, CoordenadaY, forma); // se muestra dentro del noto el dato que contendria ese nodo


            if (Izq != null)// se verifica si tiene hijos izquierdo
            {
                Izq.Nodo(grafo, fuente, Relleno, RellenoFuente, lapiz, encuentro);
            }

            if (Der != null) // se verifica si tiene hijos derecho
            {
                Der.Nodo(grafo, fuente, Relleno, RellenoFuente, lapiz, encuentro);
            }
        }

        public void PNodo(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen lapiz, Brush encuentro, string a)
        {

            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            MessageBox.Show("lk" + encuentro);
            if (a == info.ToString())
            {

                //grafo.FillEllipse(encuentro, rect);
                //MessageBox.Show("lk" + grafo.);
                //grafo.FillEllipse(Relleno, rect);
                // grafo.DrawEllipse(lapiz, rect); //se dibujar el nodo

                StringFormat forma = new StringFormat(); // se prepara para mostrar los datos 

                forma.Alignment = StringAlignment.Center;
                forma.LineAlignment = StringAlignment.Center;
                grafo.DrawString(info.ToString(), fuente, RellenoFuente, CoordenadaX, CoordenadaY, forma); // se muestra dentro del noto el dato que contendria ese nodo
                                                                                                           // grafo.DrawString(info.ToString(), CoordenadaX, CoordenadaY, forma);
            }
            if (Izq != null)// se verifica si tiene hijos izquierdo
            {
                Izq.PNodo(grafo, fuente, Relleno, RellenoFuente, lapiz, encuentro, a);
            }

            if (Der != null) // se verifica si tiene hijos derecho
            {
                Der.PNodo(grafo, fuente, Relleno, RellenoFuente, lapiz, encuentro, a);
            }
        }


        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen lapiz)
        {
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);

            
            grafo.FillEllipse(Relleno, rect);
            grafo.DrawEllipse(lapiz, rect);

            StringFormat forma = new StringFormat(); // se prepara para mostrar los datos 

            forma.Alignment = StringAlignment.Center;
            forma.LineAlignment = StringAlignment.Center;
            grafo.DrawString(info.ToString(), fuente, RellenoFuente, CoordenadaX, CoordenadaY, forma);
        }
    }
}

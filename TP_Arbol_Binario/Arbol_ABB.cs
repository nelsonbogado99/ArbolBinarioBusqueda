using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
//using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

namespace TP_Arbol_Binario
{
    class Arbol_ABB
    {

        public nodoArbol raiz; // definimos la raiz del arbol

        public Arbol_ABB()
        {
            raiz = null;

        }
        // c = e.Graphics;
         Graphics cac;
        public string inorden = ""; // variale de tipo string para guardar en ella el recorrido el arbol en in orden
        public string posorden = ""; // variale de tipo string para guardar en ella el recorrido el arbol en pos orden
        public string preorden = ""; // variale de tipo string para guardar en ella el recorrido el arbol en pre orden

        public int auxiliar = 1, contador = 0, ay = 0; // variables auxiliares que se usa para recorrer los diferentes arreglos
        int[] Altura = new int[800]; // este arreglo se usara para guardar en ella las alturas del arbol
        int[] Infor = new int[200]; // este arreglo se usa para guardar en ella los diferentes datos ingresados para el nodo
        int[] MayorMenor = new int[200]; // en este se guarda los valores de los nodos para saber que nodo es menor o mayor

        int suma = 0, con = 0; // se uti;iza paara sumar los diferentes nodos del arbol

        // Cuando se de clic al boton de Menor nodo se llama a este metodo 
        public void Menor()
        {
            if (raiz != null) // verifica que el arbol no este vacio
            {
                con = 0;
                BuscarMenor(raiz); // se llama a este metodo pasandole la raiz del arbol para buscar el nodo menor
                MessageBox.Show("El nodo menor es: " + MayorMenor[0]); // se imprime el nodo menor del arbol
            }
            else
            {
                MessageBox.Show("El arbol esta vacio."); // en caso de que no tenga ningun nodo se muestra este mensaje
            }
        }


        // cuando se apreta el boton Mayor nodo se llama a este metodo
        public void Mayor()
        {
            if (raiz != null) // verifica que no es ste vacio en arbol
            {
                con = 0;
                BuscarMayor(raiz); // llama al metodo para buscar el nodo mas grande que hay en el arbol
                MessageBox.Show("El nodo mayor es: " + MayorMenor[con - 1]); // se imprime el resultado del nodo mas grande
            }
            else
            {
                MessageBox.Show("El arbol esta vacio."); // en caso de que el arbol este vacio
            }
        }

        // Metodo para buscar el nodo menor del arbol
        public void BuscarMenor(nodoArbol Nuevo)
        {
            if (Nuevo != null)
            {

                BuscarMenor(Nuevo.Izq);// se recorre todo el arbol em in orden

                MayorMenor[con] = Nuevo.Info; // guarda los valores de los nodos en el arreglo haciendo su respectivo recorrido en la cual el nodo menor se encontrario en la posicion 0 del arreglo
                con++;
                BuscarMenor(Nuevo.Der);

            }
        }


        //Metodos para buscar el nodo mas grande que este en el arbol
        public void BuscarMayor(nodoArbol Nuevo)
        {
            if (Nuevo != null)
            {
                BuscarMayor(Nuevo.Izq); // se recorre todo el arbol em in orden
                MayorMenor[con] = Nuevo.Info;// guarda los valores de los nodos en el arreglo haciendo su respectivo recorrido en la cual el nodo mayor se encontrario en la posicion n del arreglo
                con++;
                BuscarMayor(Nuevo.Der);
            }

        }


        // Medodo llamado por el boton Insertar recibe la informacion que se quiere agregar mas su precedencia 001 proviene del boton Insertar 002 provine de otro llamado 
        public void Nodo(int info, int tipo)
        {
            if (raiz == null) // verifica si ya tiene un valor la riaz o no
            {
                raiz = new nodoArbol(); // crea raiz
                auxiliar = 2; // para la altura
                raiz.Info = info; // se le carga a la raiz la informacion recivida
            }
            else// en caso de que ya tengamos un raiz
            {
                auxiliar = 1; // para la altura
                Insertar(raiz, info, tipo); //se lllama al metodo insertar

            }


        }

        // llamado de los diferentees botos de multiplos y suma de nodos se recibe un numero para identificar a cual metodo corresponde
        public void Multiplos(int numero)
        {

            if (raiz != null) // si el arbol no esta vacio
            {
                suma = 0;
                if (numero == 2) // si el numero recibido es 2 entonces es para el multiplo de 2
                {
                    SumaMultiplos2(suma, raiz); // se llama al metodo de Suma Multiplos de 2
                    MessageBox.Show("La suma de los multiplos de 2 son: " + suma); // se muestra el resultado
                }
                else if (numero == 3)// si el numero recibido es 3 entonces es para el multiplo de 3
                {
                    SumaMultiplos3(suma, raiz);// se llama al metodo de Suma Multiplos de 3
                    MessageBox.Show("La suma de los multiplos de 3 son: " + suma);
                }
                else if (numero == 5) // si el numero recibido es 5 entonces es para el multiplo de 5
                {
                    SumaMultiplos5(suma, raiz);// se llama al metodo de Suma Multiplos de 5
                    MessageBox.Show("La suma de los multiplos de 5 son: " + suma);
                }
                else // si no es uno de los amteriores entonces es sumar todo los nodos del arbol
                {
                    SumaNodos(suma, raiz); // se llama al metodo y por medio de un recorrido se suma todo los valores de los nodos del arbol
                    MessageBox.Show("La suma de los Nodo es: " + suma);
                }
            }
            else // si el arbol esta vacio
            {
                MessageBox.Show("El arbol esta vacio.");
            }
        }


        // medoto paraa sumar los multiplos de 2
        public void SumaMultiplos2(int sum, nodoArbol Nuevo)
        {


            if (Nuevo != null) // se verifica que el arbol no este vacio
            {
                if (Nuevo.Info % 2 == 0) // si el esto es 0 de la division entre 2 entonces el numero si es un multipllo de 2
                {

                    suma = sum + Nuevo.Info; // se suma dicho numero que seea multplo de 2

                }

                SumaMultiplos2(suma, Nuevo.Izq);
                SumaMultiplos2(suma, Nuevo.Der);

            }



        }

        // medoto paraa sumar los multiplos de 3
        public void SumaMultiplos3(int sum, nodoArbol Nuevo)
        {
            if (Nuevo != null)
            {
                if (Nuevo.Info % 3 == 0) // si el esto es 0 de la division entre 3 entonces el numero si es un multipllo de 3
                {

                    suma = sum + Nuevo.Info; // se suma dicho numero que seea multplo de 3

                }

                SumaMultiplos3(suma, Nuevo.Izq);
                SumaMultiplos3(suma, Nuevo.Der);

            }
        }

        // medoto paraa sumar los multiplos de 5
        public void SumaMultiplos5(int sum, nodoArbol Nuevo)
        {
            if (Nuevo != null)
            {
                if (Nuevo.Info % 5 == 0) // si el esto es 0 de la division entre 5 entonces el numero si es un multipllo de 5
                {

                    suma = sum + Nuevo.Info; // se suma dicho numero que seea multplo de 5

                }

                SumaMultiplos5(suma, Nuevo.Izq);
                SumaMultiplos5(suma, Nuevo.Der);

            }
        }

        //Metodo para sumar todo los nodos
        public void SumaNodos(int sum, nodoArbol Nuevo)
        {

            if (Nuevo != null)
            {
                //utilizando el recorrido en pre orden sumamos todo los nodos del arbol
                suma = sum + Nuevo.Info;
                SumaNodos(suma, Nuevo.Izq);
                SumaNodos(suma, Nuevo.Der);

            }
        }


        // llamado por el boton Recorridos
        public void Recorrido(Graphics grafo)
        {
            Form1 ac = new Form1();
            if (raiz != null)
            {

                colorear(grafo, ac.Font, Brushes.CadetBlue, Brushes.White, Pens.Black, raiz, true);

                // RecorridoPreOrden(raiz,grafo);// llama a los diferentes metodos de recorrido
                //  RecorridoIndOrden(raiz);
                // RecorridoPosOrden(raiz);
                //  MessageBox.Show("reco" + this.Font);
            }
            else // en caso de que el arbol este vacio
            {
                MessageBox.Show("El arbol esta vacio.");
            }
        }
        

        // Metpdo que recive la informacion a ser buscada en el arbol
        public void BuscarNodo(int info)
        {
            if (raiz != null)
            {
                Busqueda(raiz, info); // Metodo para buscar dicha informacion
            }
            else
            {
                MessageBox.Show("El arbol esta vacio.");
            }
        }


        // Metodo que recive la infromacion a ser Eliminado del arbol
        public void EliminarNodo(int info)
        {

            Eliminar(raiz, info, raiz); // se llama al Metodo para eliminar dicha informacion


        }


        // Metodo para insertar un nodo en el arbol
        public void Insertar(nodoArbol Nuevo, int info, int tipo)
        {

            if (info < Nuevo.Info)
            {
                if (Nuevo.Izq == null)
                {
                    nodoArbol otro = new nodoArbol();
                    auxiliar++;

                    otro.Der = null;
                    otro.Izq = null;

                    otro.Info = info;
                    Nuevo.Izq = otro;
                }
                else
                {
                    Insertar(Nuevo.Izq, info, tipo);
                    auxiliar++;


                }
            }
            else if (info > Nuevo.Info)
            {
                if (Nuevo.Der == null)
                {
                    nodoArbol otro = new nodoArbol();
                    auxiliar++;


                    otro.Der = null;
                    otro.Izq = null;
                    otro.Info = info;
                    Nuevo.Der = otro;
                }
                else
                {
                    Insertar(Nuevo.Der, info, tipo);
                    auxiliar++;

                }
            }
            else if (tipo == 001)
            {
                MessageBox.Show("El nodo ya se encuentra en el arbol");
            }

        }

        //Metodo para guardar las alturas del arbol mas los datos que el usuario este agregadno
        public void AlturaArbol(int info)
        {

            Altura[contador] = auxiliar;
            Infor[contador] = info;
            contador++;

            auxiliar = 0;
        }


        // Metodo para imprimir la altura
        public void ImprimirAltura()
        {
            if (raiz != null)
            {
                // se lo que se estaba guardando en el metodo Altura arbol aca se hace ordenamiento burbuja para poer tener hacia un lado del arreglo el valor mas alto del arbol
                int aux, co = contador - 1;

                for (int i = 0; i < contador; i++)
                {
                    for (int j = co; j > 0; j--)
                    {
                        if (Altura[j - 1] > Altura[j])
                        {
                            aux = Altura[j - 1];
                            Altura[j - 1] = Altura[j];
                            Altura[j] = aux;
                        }

                    }

                }

                aux = Altura[contador - 1];
                aux--;
                MessageBox.Show("La Altura del arbol es: " + aux);// se imprime la altura
            }
            else
            {
                MessageBox.Show("El arbol esta vacio.");
            }


        }


        // metodo para buscar un nodo en el arbol
        public void Busqueda(nodoArbol Nuevo, int info)
        {
            if (info < Nuevo.Info)
            {
                if (Nuevo.Izq == null)
                {
                    MessageBox.Show("La informacion no se encuentra en el arbol");
                }
                else
                {
                    Busqueda(Nuevo.Izq, info);
                }
            }
            else if (info > Nuevo.Info)
            {
                if (Nuevo.Der == null)
                {
                    MessageBox.Show("La informacion no se encuentra en el arbol");
                }
                else
                {
                    Busqueda(Nuevo.Der, info);
                }
            }
            else
            {
                MessageBox.Show("La informacion esta en el arbol");

            }


        }

        // Metodo para eliminar un nodo del arbol
        public void Eliminar(nodoArbol Nuevo, int info, nodoArbol ac)
        {
            if (Nuevo != null)
            {
                if (info < Nuevo.Info)
                {
                    ac = Nuevo;
                    Eliminar(Nuevo.Izq, info, ac);
                }
                else
                {
                    if (info > Nuevo.Info)
                    {
                        ac = Nuevo;
                        Eliminar(Nuevo.Der, info, ac);
                    }
                    else
                    {
                        nodoArbol otro = new nodoArbol();
                        nodoArbol otr = new nodoArbol();
                        otro = Nuevo;
                        if (otro.Der == null)
                        {

                            if (raiz.Izq == null && raiz.Der == null)
                            {
                                raiz = null;

                            }

                            else if (raiz.Izq != null && raiz.Der == null)
                            {
                                //MessageBox.Show("e");
                                ay = contador;
                                NuevaAltura(Nuevo.Info); // Matodo para ir calculando la altura
                                raiz.Izq = Nuevo.Izq;

                            }


                            else if (Nuevo.Izq == null && Nuevo.Der == null)
                            {
                                // MessageBox.Show("t" + ac.Info);
                                otr = ac.Izq;
                                if (ac.Izq != null && otr.Info == otro.Info)
                                {
                                    // MessageBox.Show("es" + ac.Info);
                                    ay = contador;
                                    NuevaAltura(Nuevo.Info);// Matodo para ir calculando la altura
                                    ac.Izq = null;
                                    Nuevo = otro.Izq;
                                }
                                else
                                {
                                    ay = contador;
                                    NuevaAltura(Nuevo.Info);// Matodo para ir calculando la altura
                                    ac.Der = null;
                                    Nuevo = otro.Der;
                                }

                            }
                            else if (Nuevo.Izq != null && Nuevo.Der == null)
                            {
                                // MessageBox.Show("a" + ac.Info);
                                if (ac.Der != null)
                                {
                                    ay = contador;
                                    NuevaAltura(Nuevo.Info);// Matodo para ir calculando la altura
                                    //  MessageBox.Show("esta" + Nuevo.Info);
                                    otro = Nuevo.Izq;
                                    ac.Der = otro;
                                }
                                else
                                {
                                    ay = contador;
                                    NuevaAltura(Nuevo.Info);
                                    otro = Nuevo.Izq;
                                    ac.Izq = otro;
                                }
                            }
                            else
                            {
                                // MessageBox.Show("c" + ac.Info);
                                ay = contador;
                                NuevaAltura(Nuevo.Info);// Matodo para ir calculando la altura
                                ac.Izq = Nuevo.Izq;
                            }



                        }
                        else
                        {
                            if (otro.Izq == null)
                            {
                                // MessageBox.Show("else");

                                if (raiz.Izq == null && raiz.Der == null)
                                {
                                    raiz = null;

                                }

                                else if (raiz.Der != null && raiz.Izq == null)
                                {

                                    ay = contador;
                                    NuevaAltura(Nuevo.Info);// Matodo para ir calculando la altura
                                    raiz.Der = Nuevo.Der;

                                }
                                else if (Nuevo.Der != null && Nuevo.Izq == null)
                                {
                                    //  MessageBox.Show("el ");
                                    ay = contador;
                                    NuevaAltura(Nuevo.Info); // Matodo para ir calculando la altura
                                    otro = Nuevo.Der;
                                    ac.Izq = otro;
                                }
                            }
                            else
                            {
                                nodoArbol aux1 = new nodoArbol();
                                nodoArbol aux = new nodoArbol();
                                aux1 = null;
                                aux = Nuevo.Izq;
                                ay = contador;

                                NodoArbolE(aux.Info, Nuevo.Info);// Matodo para ir calculando la altura
                                bool Bandera = false;
                                while (aux.Der != null)
                                {
                                    aux1 = aux;
                                    aux = aux.Der;
                                    Bandera = true;

                                }

                                Nuevo.Info = aux.Info;
                                otro = aux;

                                if (Bandera == true)
                                {
                                    aux1.Der = aux.Izq;
                                }
                                else
                                {
                                    Nuevo.Izq = aux.Izq;
                                }
                            }
                        }
                    }
                }

            }
        }

        //Metodo para borrar un valor del nodo del arreglo que teniamos anteriormente
        public void NodoArbolE(int a, int b)
        {
            
            for (int i = 0; i < ay; i++)
            {
                Altura[i] = 0;
                if (Infor[i] == b)
                {

                    Infor[i] = a;

                }
                if (Infor[i] != 001)
                {
                    Nodo(Infor[i], 002);
                    AlturaArbol(Infor[i]);
                }
            }

        }

       //Metodo para borrar un valor del nodo del arreglo que teniamos anteriormente
        public void NuevaAltura(int bor)
        {

            //raiz = null;
            for (int i = 0; i < ay; i++)
            {
                Altura[i] = 0;

                if (Infor[i] != bor && Infor[i] != 001)
                {
                    // MessageBox.Show(" " + Infor[i]);
                    Nodo(Infor[i], 002);
                    AlturaArbol(Infor[i]);
                }
                else
                {
                    Infor[i] = 001;
                }


            }

        }

        //Metodo de recorrido en pre orden
       // public string a;
        public void RecorridoPreOrden(nodoArbol raiz, Graphics grafo)
        {
           
            if (raiz != null)
            {
                Form1 ac = new Form1();
                preorden += raiz.Info.ToString() + ", ";
                PArbol(grafo,ac.Font, Brushes.Black, Brushes.White, Pens.Black, Brushes.White, raiz.Info.ToString());
              
                Thread.Sleep(600);
              //  RecorridoPreOrden(raiz.Izq);
               // RecorridoPreOrden(raiz.Der);

            }
        }


        //Metodo de recorrido en pos orden
        public void RecorridoPosOrden(nodoArbol raiz)
        {
            if (raiz != null)
            {

                RecorridoPosOrden(raiz.Izq);
                RecorridoPosOrden(raiz.Der);
                posorden += raiz.Info.ToString() + ", ";

            }
        }

        //Metodo de recorrido en ind orden
        public void RecorridoIndOrden(nodoArbol raiz)
        {
            if (raiz != null)
            {

                RecorridoIndOrden(raiz.Izq);

                inorden += raiz.Info.ToString() + ", ";

                RecorridoIndOrden(raiz.Der);

            }
        }

        //METODO PARA DIBUJAR EL arbol
        public void Arbol(Graphics grafo, Font fuente, Brush relleno, Brush rellenoFuente, Pen lapiz, Brush encuentro)
        {
            int x = 400;
            int y = 75;

            if (raiz == null)
            {
                return;
            }

           raiz.PosicionNodo(ref x, y); // posicion de todos los nodoS
           raiz.Ramas(grafo, lapiz);   // dibuja las ramas entre nodos

            raiz.Nodo(grafo, fuente, relleno, rellenoFuente, lapiz, encuentro); // dibuja el nodo del arbol

        }
        
        
        public void PArbol(Graphics grafo, Font fuente, Brush relleno, Brush rellenoFuente, Pen lapiz, Brush encuentro, string a)
        {
            int x = 400;
            int y = 75;

            if (raiz == null)
            {
                return;
            }

            raiz.PosicionNodo(ref x, y); // posicion de todos los nodoS

           // cac = raiz.gra;

          raiz.PNodo(grafo, fuente, relleno, rellenoFuente, lapiz, encuentro, a); // dibuja el nodo del arbol
        //raiz.Nodo(ra, fuente, relleno, rellenoFuente, lapiz, encuentro); // dibuja el nodo del arbol

        }

        public int x1 = 400;
        public int y2 = 75;

        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, nodoArbol raiz, bool inOrden)
        {
            Brush entorno = Brushes.Red;
            if(inOrden == true)
            {
                if(raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, raiz.Izq, inOrden);
                    raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000);
                    raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, raiz.Der, inOrden);
                }
            }
        }





    }
}

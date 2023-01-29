using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MaresPad
{
    public partial class Buscar : Form
    {        
        public Buscar(RichTextBox richTexto,int opcion)
        {
            InitializeComponent();
            richTextoParaTodos = richTexto;
            nudNumeroDeLinea.Minimum = 1;
            nudNumeroDeLinea.Maximum = decimal.Parse(richTextoParaTodos.Lines.Length.ToString());
            opcionPestaña = opcion;         
        }

        static RichTextBox richTextoParaTodos;
        static int opcionPestaña;
        public Buscar()
        {
   
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btnIrA_Click(object sender, EventArgs e)
        {            
            int numero = int.Parse(nudNumeroDeLinea.Value.ToString());            
            richTextoParaTodos.Select(richTextoParaTodos.GetFirstCharIndexFromLine(numero-1),0);
            Close();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {            
            lstResultados.Items.Clear();
            string texto = txtBuscar.Text;
            Form1 formaPrincipal = new Form1(texto);
            /*RichTextBoxFinds tamaño = (RichTextBoxFinds)richTextoParaTodos.Text.Length;*/

            string textoRich=richTextoParaTodos.Text.Replace("\n", " ");
            textoRich = textoRich + " ";
            

            string[] palabras = new string[textoRich.Split(' ').Length];
            int[] posicionInicio = new int[textoRich.Split(' ').Length];
            int[] posicionFinal = new int[textoRich.Split(' ').Length];

            palabras=textoRich.Split(' ');

            int contadorLetras = 1;
            for (int letras = 0; letras<=palabras.Length-2; letras++)
            {
                posicionInicio[letras] = contadorLetras;
                contadorLetras += palabras[letras].Length;
                if (letras == 0)
                {
                    posicionFinal[letras] = palabras[letras].Length;
                    contadorLetras++;
                }
                else
                {
                    posicionFinal[letras] = posicionInicio[letras]+palabras[letras].Length-1;
                    contadorLetras++;
                }                
            }

            for (int busquedaPalabras = 0; busquedaPalabras<=palabras.Length-1; busquedaPalabras++)
            {
                if (palabras[busquedaPalabras]==texto)
                {                    
                    richTextoParaTodos.Select(posicionInicio[busquedaPalabras]-1, texto.Length);
                    lstResultados.Items.Add(palabras[busquedaPalabras]+" Inicio " + posicionInicio[busquedaPalabras].ToString()+ " Fin " +  posicionFinal[busquedaPalabras].ToString());
                    MessageBox.Show("Nueva Palabra Encontrada");
                }
            }
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            if (opcionPestaña == 1)//Buscar
            {
                tbpBuscar.Focus();
            }
            if (opcionPestaña == 2)//Reemplazar
            {
                tbpReemplazar.Focus();
            }
            if (opcionPestaña == 3)//Ir a
            {
                tbpIrA.Focus();
                tbpIrA.Select();
            }
        }
        //Creo el arreglo de resultados
        static int[] arregloResultados;
        static string [] palabras;
        static int[] posicionInicio;
        static int[] posicionFinal;
        static int palabraEncontradaContador = 0;

        private void btnBuscarReemplazar_Click(object sender, EventArgs e)
        {
            lstBuscarReemplazar.Items.Clear();             

            string texto = txtReemplazarBuscar.Text;
            RichTextBoxFinds tamaño = (RichTextBoxFinds)richTextoParaTodos.Text.Length;


            string textoRich= richTextoParaTodos.Text.Replace("\n", " ");
            textoRich = textoRich + " ";

            palabras = new string[textoRich.Split(' ').Length];
            posicionInicio = new int[textoRich.Split(' ').Length];
             posicionFinal= new int[textoRich.Split(' ').Length];

            palabras=textoRich.Split(' ');

            int contadorLetras = 1;
            for (int letras = 0; letras <= palabras.Length - 2; letras++)
            {
                posicionInicio[letras] = contadorLetras;
                contadorLetras += palabras[letras].Length;
                if (letras == 0)
                {
                    posicionFinal[letras] = palabras[letras].Length;
                    contadorLetras++;
                }
                else
                {
                    posicionFinal[letras] = posicionInicio[letras] + palabras[letras].Length - 1;
                    contadorLetras++;
                }
            }
            
       
            int palabrasEncontradas=0;

            //Este ciclo lo uso para saber cuantos espacios reservare en memoria
            for (int busquedaPalabras = 0; busquedaPalabras <= palabras.Length - 1; busquedaPalabras++)
            {
                if (palabras[busquedaPalabras] == texto)
                {
                    palabrasEncontradas++;
                }
            }

           //Le asigno el numero de espacios encontrados
           arregloResultados=new int[palabrasEncontradas];

           //Con este nuevo ciclo guardo en el arreglo de resultados el numero de resultado
           /*en total son 4 arreglos para hacer esto:
            1.- Palabras.- En este se guardan todas las palabras
            2.- PosicionInicio.- En este se guarda la posicion inicial donde se ubica la palabra
            3.- PosicionFin.- En este se guarda la posicion final donde se ubica la palabra
            4.- ArregloResultados.- En el se guardan los resultados*/

           palabrasEncontradas = 0;
           for (int busquedaPalabras = 0; busquedaPalabras <= palabras.Length - 1; busquedaPalabras++)
           {
               if (palabras[busquedaPalabras] == texto)
               {
                   arregloResultados[palabrasEncontradas] = busquedaPalabras;
                   lstBuscarReemplazar.Items.Add(palabras[busquedaPalabras] + " Inicio " + posicionInicio[busquedaPalabras].ToString() + " Fin " + posicionFinal[busquedaPalabras].ToString());
                   palabrasEncontradas++;
               }
           }

           if (palabraEncontradaContador == arregloResultados.Length)
           {
               palabraEncontradaContador = 0;
           }
           else
           {
               for (int casillero = 0; casillero <=palabraEncontradaContador; casillero++)
               {
                   richTextoParaTodos.Select(posicionInicio[arregloResultados[palabraEncontradaContador]] - 1, texto.Length);
                   MessageBox.Show("Nueva Palabra Encontrada");
               }
               palabraEncontradaContador++;
           }
        }

        private void btnReemplazar_Click(object sender, EventArgs e)
        {
            lstBuscarReemplazar.Items.Clear();
            string texto = txtReemplazarBuscar.Text;
            RichTextBoxFinds tamaño = (RichTextBoxFinds)richTextoParaTodos.Text.Length;


            string textoRich = richTextoParaTodos.Text + " ";

            string[] palabras = new string[textoRich.Split(' ').Length];
            int[] posicionInicio = new int[textoRich.Split(' ').Length];
            int[] posicionFinal = new int[textoRich.Split(' ').Length];

            palabras = textoRich.Split(' ');

            int contadorLetras = 1;
            for (int letras = 0; letras <= palabras.Length - 2; letras++)
            {
                posicionInicio[letras] = contadorLetras;
                contadorLetras += palabras[letras].Length;
                if (letras == 0)
                {
                    posicionFinal[letras] = palabras[letras].Length;
                    contadorLetras++;
                }
                else
                {
                    posicionFinal[letras] = posicionInicio[letras] + palabras[letras].Length - 1;
                    contadorLetras++;
                }
            }


            string palabraNueva=txtReemplazar.Text;
            for (int busquedaPalabras = 0; busquedaPalabras <= palabras.Length - 1; busquedaPalabras++)
            {
                if (palabras[busquedaPalabras] == texto)
                {
                    richTextoParaTodos.Select(posicionInicio[busquedaPalabras] - 1, texto.Length);                                    
                    richTextoParaTodos.Text=richTextoParaTodos.Text.Replace(texto, palabraNueva);
                    lstBuscarReemplazar.Items.Add(palabras[busquedaPalabras] + " Inicio " + posicionInicio[busquedaPalabras].ToString() + " Fin " + posicionFinal[busquedaPalabras].ToString()+ " y la cambie por " + palabraNueva);
                }
            }
        }

        private void btnReemplazarUno_Click(object sender, EventArgs e)
        {
            string texto = txtReemplazarBuscar.Text;
            string palabraNueva = txtReemplazar.Text;
            if (palabraEncontradaContador==1)
            {
                lstBuscarReemplazar.Items.Add(palabras[arregloResultados[palabraEncontradaContador - 1]] + " Inicio " + posicionInicio[arregloResultados[palabraEncontradaContador - 1]].ToString() + " Fin " + posicionFinal[arregloResultados[palabraEncontradaContador]].ToString() + " y la cambie por " + palabraNueva);
                palabraEncontradaContador = arregloResultados.Length;
            }

            
            richTextoParaTodos.Select(posicionInicio[arregloResultados[palabraEncontradaContador-1]], texto.Length);

            richTextoParaTodos.Text = richTextoParaTodos.Text.Insert(posicionInicio[arregloResultados[palabraEncontradaContador-1]]-1,palabraNueva);
            richTextoParaTodos.Text = richTextoParaTodos.Text.Remove(posicionInicio[arregloResultados[palabraEncontradaContador - 1]] + texto.Length-1, texto.Length);
            
            palabraEncontradaContador--;
        }
    }
}
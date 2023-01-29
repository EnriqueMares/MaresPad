using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Diagnostics;

namespace MaresPad
{   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variables Globales
        StreamReader sr;

        public Form1(string textoABuscar)
        {            
            InitializeComponent();
            textoBuscado=textoABuscar;
        }

        static string textoBuscado;
        private void Form1_Load(object sender, EventArgs e)
        {
            ActivarCosillas();
        }
        
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FileStream Archivo = new FileStream(tstRuta.Text, FileMode.Open, FileAccess.ReadWrite);
            //Archivo.Close();
            ComprobarGuardar();
            rctPantalla.Text = "";
            
        }
        
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivarCosillas();            

            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Archivo de text (*.txt)|*.txt|Todos los Archivos (*.*)|*.*";
            op.Title = "Abrir";            

            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Aqui se le pone el nombre a la Barra de Titulo
                    FileInfo informacion = new FileInfo(op.FileName);
                    string nombre = informacion.Name.Substring(0, informacion.Name.Length - 4);
                    //string nombre = "Luis";
                    Form1.ActiveForm.Text=nombre + " - MaresPad";


                    string NombreDeArchivo = op.FileName;
                    if (tstRuta.Text==op.FileName)
                    {
                        MessageBox.Show("Lo Sentimos, pero el Archivo que intenta abrir ya esta abierto","Error al Abrir el Archivo");
                    }
                    else
                    {
                     StreamReader sr = new StreamReader(NombreDeArchivo);
                     rctPantalla.Text = sr.ReadToEnd();
                     sr.Close();
                    }


                    /*Con este grupo de codigo, el archivo tambien se abre, pero no usa el StreamReader ni StreamWriter
                    rctPantalla.Text = "";
                    

                    FileStream Archivo = new FileStream(op.FileName, FileMode.Open, FileAccess.Read);
                    byte[] Contenido;
                    Contenido = new byte[Archivo.Length];
                    Archivo.Read(Contenido, 0, (int)Archivo.Length);

                    rctPantalla.Text = new ASCIIEncoding().GetString(Contenido);*/
                    
                    /*Con la siguiente linea te ahorras todo lo demas, pero solo puedes abrir *.rtf */
                    //rctPantalla.LoadFile(op.FileName, RichTextBoxStreamType.RichText);
                    tstRuta.Text=op.FileName;
                    guardarToolStripMenuItem.Enabled = true;
                    //Archivo.Close();
                }
                catch
                {
                 MessageBox.Show("Error al abrir el archivo", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }          
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {            
            AcercaDe acerca = new AcercaDe();
            acerca.ShowDialog();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowApply = true;
            fd.ShowDialog();            
            rctPantalla.Font= fd.Font;
        }
 
        private void colorDeLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            ColorDialog color = new ColorDialog();            
            color.ShowDialog();
            rctPantalla.ForeColor = color.Color;
        }


        private void Form1_Resize(object sender, EventArgs e)
        {            
            rctPantalla.Height=Form1.ActiveForm.Size.Height-50;
            rctPantalla.Width = Form1.ActiveForm.Size.Width-10;
            //tstRuta.TextBox.Width=Form1.ActiveForm.Size.Width;//ancho
        }

        
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GuardarComo
            guardarToolStripMenuItem.Enabled = true;

            //Llamada al metodo Guardar
            Guardar();

            /*De esta manera tambien se guarda pero no se usa ni el StreamWriter ni el StreamReader
            FileStream fs =(System.IO.FileStream)guardar.OpenFile();   
            byte[] info = new System.Text.UTF8Encoding(true).GetBytes(rctPantalla.Text);
            fs.Write(info, 0, info.Length);

            fs.Close();*/            
        }

        
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            //Guardar Normal            
            StreamWriter writer=new StreamWriter(tstRuta.Text);
            writer.Close();
            writer= File.CreateText(tstRuta.Text);
            writer.WriteLine(rctPantalla.Text);                     
            writer.Close();
            
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar busqueda = new Buscar(rctPantalla,1);
            busqueda.ShowDialog();
        }

        private void abrirLaCopiaDeWindowsDelMaresPadNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process proc = null;
            ProcessStartInfo procInfo = new ProcessStartInfo("Notepad.exe");

            //esta línea indica si se utilizar el Shell del sistema operativo para comenzar el proceso.
            //por defecto es verdadero
            procInfo.UseShellExecute = false;

            //Indica que se ejecute el proceso en una ventana nueva 
            procInfo.CreateNoWindow = true;

            //Comenzará el proceso y esperará indefinidamente para que el proceso salga.
            proc = Process.Start(procInfo);
            proc.WaitForInputIdle();
        }

        private void configurarPaginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageSetupDialog psd=new PageSetupDialog();
            psd.PageSettings = new System.Drawing.Printing.PageSettings();
            psd.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            psd.ShowNetwork=false;
            psd.ShowDialog();                                            
        }
        
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            //Guardar Temporal
            string ruta=@"\temporal.text";
            StreamWriter writer = new StreamWriter(ruta); 
            //writer = File.CreateText(ruta);
            writer.WriteLine(rctPantalla.Text);
            writer.Close();

            //Mandar a Imprimir
            sr= new StreamReader(ruta);
            PrintDocument pdoc = new PrintDocument();
            PrintDialog pd = new PrintDialog();            
            pdoc.DocumentName = tstRuta.Text;
            pdoc.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
            if (pd.ShowDialog() == DialogResult.OK)
            {
                pdoc.Print();
            }
            sr.Close();

            //Eliminar Temporal
            File.Delete(ruta);
        }

        private void vistaPreliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            PrintDocument p=new PrintDocument();
            p.DocumentName=tstRuta.Text;            


            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Name = "Vista Preliminar";            
            ppd.Document=p;


            //Propiedades que puedo mover
            ppd.PrintPreviewControl.Zoom = 1.0;
            ppd.WindowState = FormWindowState.Maximized;
            ppd.Document.DefaultPageSettings.Landscape = true;

            ppd.ShowDialog();
        }

    
        private void barraDeEstadoToolStripMenuItem_Click(object sender, EventArgs e)        
        {
            if (rctPantalla.WordWrap == true)
            {
                sstBarra2.Visible = false;
            }
            else
            {
                if (barraDeEstadoToolStripMenuItem.Checked==true)
                {
                    sstBarra2.Visible = true;
                }
            }



            if (sstBarra2.Visible == true)
            {
                sstBarra2.Visible = false;
                barraDeEstadoToolStripMenuItem.Checked = false;
            }
            else
            {
                barraDeEstadoToolStripMenuItem.Checked=true;
                tsstTexto.Text="Hola Si deseas no visualizar la barra de estado sigue la ruta Ver" + "\\" + "Barra de Estado";                
                sstBarra2.Visible = true;                
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rctPantalla.SelectedText.Length == 0)
            {
                //rctPantalla.Text;
            }
            else
            {                 
            }
            rctPantalla.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rctPantalla.Paste();
        }

        private void horaYFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rctPantalla.SelectedText.Length == 0)
            {
                //rctPantalla.Text;
            }
            else
            {
            }
            rctPantalla.Cut();
        }

        private void horaYFechaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DateTime fecha;
            fecha = DateTime.Now;
            rctPantalla.Text = rctPantalla.Text+fecha.ToString();             
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rctPantalla.CanUndo==true)
            {
                rctPantalla.Undo();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rctPantalla.SelectedText = "";
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rctPantalla.SelectAll();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            
            
        }

        private void irAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar busqueda = new Buscar(rctPantalla,3);   
            busqueda.ShowDialog();
        }

        private void saltoDeLineaAutomaticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rctPantalla.WordWrap == false)
            {               
                rctPantalla.WordWrap = true;
                saltoDeLineaAutomaticoToolStripMenuItem.Checked = true;
                sstBarra2.Visible = false;
                barraDeEstadoToolStripMenuItem.Enabled = false;
                barraDeEstadoToolStripMenuItem.Checked = false;
            }
            else
            {
                rctPantalla.WordWrap =false;
                saltoDeLineaAutomaticoToolStripMenuItem.Checked = false;
                barraDeEstadoToolStripMenuItem.Enabled = true;
                barraDeEstadoToolStripMenuItem.Checked = false;
            }
        }

        private void sstBarra2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        
        private void rctPantalla_TextChanged(object sender, EventArgs e)
        {
            ActivarCosillas();
       

            /*Esta de aqui abajo tambien funciona*/
            //tstbbLinea.Text = rctPantalla.GetLineFromCharIndex(Cursor.Position.Y).ToString();            
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void reemplazarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar busqueda = new Buscar(rctPantalla,2);
            busqueda.Show();
        }

        private void buscarSiguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string textoRich = rctPantalla.Text + " ";

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

            for (int busquedaPalabras = 0; busquedaPalabras <= palabras.Length - 1; busquedaPalabras++)
            {
                if (palabras[busquedaPalabras] == textoBuscado)
                {
                    rctPantalla.Select(posicionInicio[busquedaPalabras] - 1, textoBuscado.Length);
                    MessageBox.Show("Nueva Palabra Encontrada");
                }
            }
        }

        private void rctPantalla_SelectionChanged(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText() == false && rctPantalla.Text.Length == 0)
            {
                edicionToolStripMenuItem1.Visible = false;//Edicion
            }
            else
            {
                edicionToolStripMenuItem1.Visible = true;//Edicion
            }

            if (Clipboard.ContainsText() == false)
            {
                pegarToolStripMenuItem.Enabled = false;
            }
            else
            {
                pegarToolStripMenuItem.Enabled = true;
            }

            //Deshabilitar Opciones
            if (rctPantalla.SelectedText.Length != 0)
            {
                //Menu Edicion
                cortarToolStripMenuItem.Enabled = true;
                copiarToolStripMenuItem.Enabled = true;
                eliminarToolStripMenuItem.Enabled = true;
            }
            else
            {
                //Menu Edicion                
                cortarToolStripMenuItem.Enabled = false;
                copiarToolStripMenuItem.Enabled = false;
                eliminarToolStripMenuItem.Enabled = false;
            }

            //Saber Linea
            int linea=rctPantalla.GetLineFromCharIndex(rctPantalla.SelectionStart)+1;
            tstbbLinea.Text = linea.ToString();

            //Saber Columna
            int columna=rctPantalla.SelectionStart-rctPantalla.GetFirstCharIndexFromLine(linea-1);
            tdtbbColumna2.Text = columna.ToString();
            
        }

        //Metodos
        public void ActivarCosillas()
        {
            if (Clipboard.ContainsText() == false && rctPantalla.Text.Length == 0)
            {
                edicionToolStripMenuItem1.Visible = false;//Edicion
            }
            else
            {
                edicionToolStripMenuItem1.Visible = true;//Edicion
            }

            if (Clipboard.ContainsText() == false)
            {
                pegarToolStripMenuItem.Enabled = false;
            }
            else
            {
                pegarToolStripMenuItem.Enabled = true;
            }

            if (rctPantalla.Text.Length == 0)//Mientras NO SE ESCRIBA NADA
            {
                //Menu Edicion
                deshacerToolStripMenuItem.Enabled = false;
                cortarToolStripMenuItem.Enabled = false;
                copiarToolStripMenuItem.Enabled = false;
                eliminarToolStripMenuItem.Enabled = false;
                buscarToolStripMenuItem.Enabled = false;
                buscarSiguienteToolStripMenuItem.Enabled = false;
                reemplazarToolStripMenuItem.Enabled = false;
                irAToolStripMenuItem.Enabled = false;
                seleccionarTodoToolStripMenuItem.Enabled = false;

                //Menu Archivo
                nuevoToolStripMenuItem.Enabled = false;
                guardarToolStripMenuItem.Enabled = false;
                salirToolStripMenuItem.Enabled = false;//Guardar como
                imprimirToolStripMenuItem.Enabled = false;
                configurarPaginaToolStripMenuItem.Enabled = false;
                vistaPreliminarToolStripMenuItem.Enabled = false;
            }
            else
            {
                //Menu Edicion
                deshacerToolStripMenuItem.Enabled = true;
                cortarToolStripMenuItem.Enabled = true;
                copiarToolStripMenuItem.Enabled = true;
                eliminarToolStripMenuItem.Enabled = true;
                buscarToolStripMenuItem.Enabled = true;
                buscarSiguienteToolStripMenuItem.Enabled = true;
                reemplazarToolStripMenuItem.Enabled = true;
                irAToolStripMenuItem.Enabled = true;
                seleccionarTodoToolStripMenuItem.Enabled = true;


                //Menu Archivo
                nuevoToolStripMenuItem.Enabled = true;
                guardarToolStripMenuItem.Enabled = false;
                salirToolStripMenuItem.Enabled = true;//Guardar como
                imprimirToolStripMenuItem.Enabled = true;
                configurarPaginaToolStripMenuItem.Enabled = true;
                vistaPreliminarToolStripMenuItem.Enabled = true;
            }
        }


        public void Guardar()
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo de Texto (*.txt) |*.txt |Todos los Archivos (*.*)|*.*";
            guardar.Title = "Guardar como";
            guardar.DefaultExt = "txt";
            guardar.RestoreDirectory = true;
            guardar.ShowDialog();

            string NombreDeArchivo = guardar.FileName;
            StreamWriter sw = new StreamWriter(NombreDeArchivo);
            sw.Write(rctPantalla.Text);
            sw.Flush(); // Borra todos los búferes del sistema de escritura
            sw.Close();
            tstRuta.Text = guardar.FileName;
        }

        public void ComprobarGuardar()
        {
              if (rctPantalla.Text.Length!=0)
            {
                DialogResult respuesta = new DialogResult();
                respuesta = MessageBox.Show("El Texto en el Archivo Sin Titulo a cambiado" + "\r" + "¿Desea Guardar los Cambios?", "MaresPad", MessageBoxButtons.YesNoCancel);
                if (respuesta == DialogResult.Yes)
                {
                    Guardar();
                }                
            }
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
         Font printFont = new Font("Arial", 10);            
         float linesPerPage = 0;
         float yPos = 0;
         int count = 0;
         float leftMargin = ev.MarginBounds.Left;
         float topMargin = ev.MarginBounds.Top;
         string line = null;

          // Calculate the number of lines per page.
          linesPerPage = ev.MarginBounds.Height /
          printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
           while (count < linesPerPage && ((line = sr.ReadLine()) != null))
           {
            yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, printFont, Brushes.Black,
            leftMargin, yPos, new StringFormat());
            count++;
           }

          // If more lines exist, print another page.
          if (line != null)
            ev.HasMorePages = true;
          else
           ev.HasMorePages = false;
        }



        private void temasDeAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            
            Help.ShowHelp(this,@"\MaresPad\MaresPad.chm");//de esta forma la ruta es relativa
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ComprobarGuardar();
        }
    }
}
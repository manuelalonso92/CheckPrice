using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Timers;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;

namespace CheckPrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btUpdate.Enabled = false;
            timerF = new System.Windows.Forms.Timer();
            timerF.Tick += new EventHandler(countdown);
            timerF.Interval = 1000;
            crearCarpeta();
            TestConnection();
            label5.Text = ("Próxima Actualización: "+ DateTime.Now.ToString("dd/MM/yyyy 23:59 tt"));
            
        }







        /////   METODOS                                                                                             
        private void TestConnection()                                                                                                   
        {
            

            //INTERNET
            Ping myPing = new Ping();
            
            try
            {
                Image myimage;
                PingReply reply = myPing.Send("8.8.8.8", 1000);

                if (reply != null)
                {
                    
                    //Image myimage = new Bitmap(@"C:\Users\manu\source\repos\CheckPrice\ok.png");
                    myimage = new Bitmap(@"C:\Users\MANU\source\repos\CheckPrice\ok.png");
                    btInet.BackgroundImage = myimage;

                    //VPN
                    System.Timers.Timer t = new System.Timers.Timer(2000);
                    t.SynchronizingObject = this; // Set the timer event to run on the same thread as the current class, i.e. the UI
                    t.AutoReset = false; // Only execute the event once
                    t.Elapsed += new ElapsedEventHandler(t_ElapsedVPN); // Add an event handler to the timer
                    t.Enabled = true; // Starts the timer

                    void t_ElapsedVPN(object sender, ElapsedEventArgs e)
                    {
                        // The Timer class automatically runs this on the UI thread
                        //Image myimage = new Bitmap(@"C:\Users\manu\source\repos\CheckPrice\ok.png");
                        myimage = new Bitmap(@"C:\Users\MANU\source\repos\CheckPrice\ok.png");
                        btVPN.BackgroundImage = myimage;

                    }


                    //BASE DE DATOS
                    System.Timers.Timer t2 = new System.Timers.Timer(6000);
                    t2.SynchronizingObject = this; // Set the timer event to run on the same thread as the current class, i.e. the UI
                    t2.AutoReset = false; // Only execute the event once
                    t2.Elapsed += new ElapsedEventHandler(t2_ElapsedBD); // Add an event handler to the timer
                    t2.Enabled = true; // Starts the timer


                    void t2_ElapsedBD(object sender, ElapsedEventArgs e)
                    {
                        // The Timer class automatically runs this on the UI thread
                        //Image myimage = new Bitmap(@"C:\Users\manu\source\repos\CheckPrice\ok.png");
                        myimage = new Bitmap(@"C:\Users\MANU\source\repos\CheckPrice\ok.png");
                        btBD.BackgroundImage = myimage;
                        btUpdate.Enabled = true;
                        

                    }
                }

                timerF.Stop();
                lblTimer.Visible = false;

            }
            catch (Exception err)
            {
                btUpdate.Enabled = false;
                lblTimer.Visible = true;
                Image myimage = new Bitmap(@"C:\Users\MANU\source\repos\CheckPrice\not.png");
                btInet.BackgroundImage = myimage;
                btVPN.BackgroundImage = myimage;
                btBD.BackgroundImage = myimage;
                timerF.Start();


            }

        }

        //TIMER SI SE PIERDE LA CONEXION
        private int segundero = 10;
        private void countdown(object sender, EventArgs e)
        {

            lblTimer.Text = ("Sin Conexión a Internet. Reintentando en: 00:" + segundero.ToString());
            if (segundero == 0)
            {
                segundero = 10;
            }
            else 
            {
                segundero--;
            }
        }
      

       
        private void BarraCarga() 
        {
            ProgressBar pBar = new ProgressBar();
            Controls.Add(pBar);
            pBar.Visible = true;
            pBar.Name = "ProgresBar1";
            pBar.Minimum = 0;
            pBar.Maximum = 100;
            pBar.Value = 100;
            pBar.Width = 426;
            pBar.Height = 31;
            pBar.Location = new System.Drawing.Point(185, 263);
            
        }


        ///CONECTAR A LA DB

        private void ConexionDB() 
        {
            //string connetionString = @"Server = DESKTOP-0AEJ0VK; Database = TechToolsRcia; Integrated Security = True";
            string connetionString = @"Server=localhost\SQLEXPRESS;Database=TechToolsRcia;Trusted_Connection=True;";
            string sql = "DECLARE @Temp TABLE ( COD_ARTICULO VARCHAR(20), PRECIO_ANT FLOAT, PRECIO_NUE FLOAT); merge TechToolsCtes.dbo.GVA17 as target using TechToolsRcia.dbo.GVA17 as source on target.COD_ARTICU = source.COD_ARTICU and target.ID_GVA17 = source.ID_GVA17 when matched and target.PRECIO<> source.PRECIO then update set target.PRECIO = source.PRECIO OUTPUT(inserted.COD_ARTICU) AS[COD_ARTICULO], (deleted.PRECIO)AS[PRECIO_VIEJO], (INSERTED.PRECIO)AS[PRECIO_NUEVO] INTO @Temp;SELECT* FROM @Temp; ";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
                
                try 
                {
                    cnn.Open();
                    SqlDataReader queryReader = cmd.ExecuteReader();
                    string diaHora = DateTime.Now.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture);
                    //StreamWriter file = new StreamWriter(@"E:\\Carpetas\\Documentos\\InformesPrecios\\Informe"+diaHora+".txt");
                    StreamWriter file = new StreamWriter(@"C:\\Users\\Manu\\Documents\\InformesPrecios\\Informe" + diaHora + ".txt");
                    int contReg = 0;
                    string titulo = "*****INFORME DE ACTUALIZACION PRECIOS*****\n";
                    string columnName1 = "\n\nCOD_ARTICULO";
                    string columnName2 = "\tPRECIO_ANT";
                    string columnName3 = "\tPRECIO_NUE";
                    file.WriteLine(titulo + "Fecha: " + DateTime.Now.ToString() + columnName1 + " " + columnName2 + " " + columnName3);
                    while (queryReader.Read())
            {
                       
                        file.WriteLine(queryReader["COD_ARTICULO"].ToString() + " \t\t$" + queryReader["PRECIO_ANT"].ToString() + " \t\t$" + queryReader["PRECIO_NUE"].ToString());
                        contReg++;
                        
                    }

                    queryReader.Close();
                    cnn.Close();
                    file.Close();

                    if (contReg == 0)
                    {

                        //File.Delete(@"E:\\Carpetas\\Documentos\\InformesPrecios\\Informe" + diaHora + ".txt");
                        File.Delete(@"C:\\Users\\Manu\\Documents\\InformesPrecios\\Informe" + diaHora + ".txt");

                        //MessageBox.Show("No existen registros por actualizar!");
                        var result = AutoClosingMessageBox.Show(
                            text: "No existen registros por actualizar!",
                            caption: "Modulo Registros",
                            timeout: 5000,
                            buttons: MessageBoxButtons.OK,
                            defaultResult: DialogResult.OK);
                            
                    }
                    else 
                    {
                        //MessageBox.Show("Proceso Realizado Exitosamente!\n" + "Cantidad de Registros actualizados: " + contReg.ToString());
                        var result = AutoClosingMessageBox.Show(
                            text: "Proceso Realizado Exitosamente!\n" + "Cantidad de Registros actualizados: " + contReg.ToString(),
                            caption: "Módulo Registros",
                            timeout: 5000,
                            buttons: MessageBoxButtons.OK,
                            defaultResult: DialogResult.OK); 
                    }
                                      
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message + "\n" + ex.StackTrace);
                }

        }

        private void crearCarpeta() 
        {
            //string path = @"E:\\Carpetas\\Documentos\\InformesPrecios";
            string path = @"C:\\Users\\Manu\\Documents\\InformesPrecios";

            try
            {
                if (!Directory.Exists(path))
                {
                    //Process.Start("explorer.exe", "/open, E:\\Carpetas\\Documentos\\InformesPrecios");
                    //Process.Start("explorer.exe", "/open, C:\\Users\\Manu\\Documents\\InformesPrecios");

                    DirectoryInfo di = Directory.CreateDirectory(path);
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la carpeta!: "+ ex.ToString());
                return;
            }
            finally { }
        }










        ///////        EVENTOS
        private void btInformes_Click(object sender, EventArgs e)
        {
            try 
            {
                Process.Start("explorer.exe", "/open, C:\\Users\\Manu\\Documents\\InformesPrecios");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error el abrir la carpeta! "+ ex.ToString());
            }

        }

        private void btAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("******CheckPrice V1.0******\n" +
                "Tecnicatura Universitaria en Programación - Practica Supervisada\n" +
                "Empresa: TechTools SRL\n" + "Alumno: Alonso Manuel - Legajo 25417" );
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try 
            {
                BarraCarga();
                ConexionDB();
               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }


        }


        
        private void timer1_Tick(object sender, EventArgs e)
        {
            TestConnection();           

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

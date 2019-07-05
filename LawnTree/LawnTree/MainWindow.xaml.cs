using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LawnTree.Clases;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace LawnTree

{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary> 
      
    public partial class MainWindow : Window
    {
        private Visibility visible;
        

        // manejo de datos de la base de datos
        Conexion obj_conexion = new Conexion();


        public MainWindow()
        {
            InitializeComponent();
            Customer_Select.Items.Insert(0, "Select...");
            Customer_Select.SelectedIndex = 0;

            Job_tr.Visibility = Visibility.Hidden;
            Desc_tr.Visibility = Visibility.Hidden;
            Pri_tr.Visibility = Visibility.Hidden;

            Job_pr.Visibility = Visibility.Hidden;
            Desc_pr.Visibility = Visibility.Hidden;
            Pri_pr.Visibility = Visibility.Hidden;

            Job_sg.Visibility = Visibility.Hidden;
            Desc_sg.Visibility = Visibility.Hidden;
            Pri_sg.Visibility = Visibility.Hidden;

            Job_mu.Visibility = Visibility.Hidden;
            Desc_mu.Visibility = Visibility.Hidden;
            Pri_mu.Visibility = Visibility.Hidden;

            Job_ed.Visibility = Visibility.Hidden;
            Desc_ed.Visibility = Visibility.Hidden;
            Pri_ed.Visibility = Visibility.Hidden;

            Job_lr.Visibility = Visibility.Hidden;
            Desc_lr.Visibility = Visibility.Hidden;
            Pri_lr.Visibility = Visibility.Hidden;

            Job_ae.Visibility = Visibility.Hidden;
            Desc_ae.Visibility = Visibility.Hidden;
            Pri_ae.Visibility = Visibility.Hidden;

            Job_si.Visibility = Visibility.Hidden;
            Desc_si.Visibility = Visibility.Hidden;
            Pri_si.Visibility = Visibility.Hidden;

            Job_cc.Visibility = Visibility.Hidden;
            Desc_cc.Visibility = Visibility.Hidden;
            Pri_cc.Visibility = Visibility.Hidden;

            Job_lm.Visibility = Visibility.Hidden;
            mes_lm.Visibility = Visibility.Hidden;
            dias_lm.Visibility = Visibility.Hidden;
            Pri_lm.Visibility = Visibility.Hidden;
            Calen_lm.Visibility = Visibility.Hidden;

            Job_ot.Visibility = Visibility.Hidden;
            Desc_ot.Visibility = Visibility.Hidden;
            Pri_ot.Visibility = Visibility.Hidden;

        }

        //listBox Control de visibilidad 
        private void ListBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (List_tr.IsSelected)
            {
                Job_tr.Visibility = visible;
                Desc_tr.Visibility = visible;
                Pri_tr.Visibility = visible;
            }
            else
            {
                Job_tr.Visibility = Visibility.Hidden;
                Desc_tr.Visibility = Visibility.Hidden;
                Pri_tr.Visibility = Visibility.Hidden;
            }
            if (List_pr.IsSelected)
            {
                Job_pr.Visibility = visible;
                Desc_pr.Visibility = visible;
                Pri_pr.Visibility = visible;
            }
            else
            {
                Job_pr.Visibility = Visibility.Hidden;
                Desc_pr.Visibility = Visibility.Hidden;
                Pri_pr.Visibility = Visibility.Hidden;
            }
            if (List_sg.IsSelected)
            {
                Job_sg.Visibility = visible;
                Desc_sg.Visibility = visible;
                Pri_sg.Visibility = visible;
            }
            else
            {
                Job_sg.Visibility = Visibility.Hidden;
                Desc_sg.Visibility = Visibility.Hidden;
                Pri_sg.Visibility = Visibility.Hidden;
            }
            if (List_mu.IsSelected)
            {
                Job_mu.Visibility = visible;
                Desc_mu.Visibility = visible;
                Pri_mu.Visibility = visible;
            }
            else
            {
                Job_mu.Visibility = Visibility.Hidden;
                Desc_mu.Visibility = Visibility.Hidden;
                Pri_mu.Visibility = Visibility.Hidden;
            }
            if (List_ed.IsSelected)
            {
                Job_ed.Visibility = visible;
                Desc_ed.Visibility = visible;
                Pri_ed.Visibility = visible;
            }
            else
            {
                Job_ed.Visibility = Visibility.Hidden;
                Desc_ed.Visibility = Visibility.Hidden;
                Pri_ed.Visibility = Visibility.Hidden;
            }
            if (List_lr.IsSelected)
            {
                Job_lr.Visibility = visible;
                Desc_lr.Visibility = visible;
                Pri_lr.Visibility = visible;
            }
            else
            {
                Job_lr.Visibility = Visibility.Hidden;
                Desc_lr.Visibility = Visibility.Hidden;
                Pri_lr.Visibility = Visibility.Hidden;
            }
            if (List_ae.IsSelected)
            {
                Job_ae.Visibility = visible;
                Desc_ae.Visibility = visible;
                Pri_ae.Visibility = visible;
            }
            else
            {
                Job_ae.Visibility = Visibility.Hidden;
                Desc_ae.Visibility = Visibility.Hidden;
                Pri_ae.Visibility = Visibility.Hidden;
            }
            if (List_si.IsSelected)
            {
                Job_si.Visibility = visible;
                Desc_si.Visibility = visible;
                Pri_si.Visibility = visible;
            }
            else
            {
                Job_si.Visibility = Visibility.Hidden;
                Desc_si.Visibility = Visibility.Hidden;
                Pri_si.Visibility = Visibility.Hidden;
            }
            if (List_cc.IsSelected)
            {
                Job_cc.Visibility = visible;
                Desc_cc.Visibility = visible;
                Pri_cc.Visibility = visible;
            }
            else
            {
                Job_cc.Visibility = Visibility.Hidden;
                Desc_cc.Visibility = Visibility.Hidden;
                Pri_cc.Visibility = Visibility.Hidden;
            }
            if (List_lm.IsSelected)
            {
                Job_lm.Visibility = visible;
                mes_lm.Visibility = visible;
                dias_lm.Visibility = visible;
                Pri_lm.Visibility = visible;
                Calen_lm.Visibility = visible;
            }
            else
            {
                Job_lm.Visibility = Visibility.Hidden;
                mes_lm.Visibility = Visibility.Hidden;
                dias_lm.Visibility = Visibility.Hidden;
                Pri_lm.Visibility = Visibility.Hidden;
                Calen_lm.Visibility = Visibility.Hidden;
            }
            if (List_ot.IsSelected)
            {
                Job_ot.Visibility = visible;
                Desc_ot.Visibility = visible;
                Pri_ot.Visibility = visible;
            }
            else
            {
                Job_ot.Visibility = Visibility.Hidden;
                Desc_ot.Visibility = Visibility.Hidden;
                Pri_ot.Visibility = Visibility.Hidden;
            }
        }

        private void MenuItem_N_I(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex=0;
            Application.Current.MainWindow.Height = 420;
        }

        private void MenuItem_V_I(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void MenuItem_R_C(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void MenuItem_S_C(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = 3;
            obj_conexion.visualizar(dataGrid);
        }

        private void MenuItem_D_C(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void MenuItem_D(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = 5;
        }

        //Boton registrar
        
        private void Btnreg_reg_Click(object sender, RoutedEventArgs e)
        {
            obj_conexion.FirstName = Reg_fn.Text;
            obj_conexion.LastName = Reg_ln.Text;
            obj_conexion.Address_c = Reg_add.Text;
            obj_conexion.Phone = int.Parse(Reg_ph.Text);
            obj_conexion.Mail = Reg_ma.Text;
            obj_conexion.PriceFirm = int.Parse(Reg_pf.Text);

            obj_conexion.insertar();
        }
        //validar que solo entren numeros
        private void Reg_ph_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;

            else { 
                e.Handled = true;
                MessageBox.Show("Just enter numbers");
            }
        }
     
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }


        //boton generar Invoice-------------------------------------------------------------------------------------------
        //crea el archivo pdf y lo manda por correo
        private void Gen_Inv(object sender, RoutedEventArgs e)
        {
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc,
                                        new FileStream(@"C:\Users\Arkangel Iván\Desktop\aqui.pdf", FileMode.Create));



            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Ticket");
            doc.AddCreator("tu");

            // Abrimos el archivo
            doc.Open();
            FileStream fs = new FileStream("Ticket.pdf", FileMode.Create);

            //Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);


            // Escribimos el encabezamiento en el documento

            //doc.Add(Chunk.NEWLINE);salto de linea

            //se crea la tabla Nom:Adress
            PdfPTable tblNom_Adress = new PdfPTable(1);
            tblNom_Adress.WidthPercentage = 90;
            //crea la celda nombre
            PdfPCell clNom = new PdfPCell(new Phrase("Name: ", _standardFont));
            clNom.BorderWidth = 1;
            clNom.BorderWidthBottom = 0f;
            // se crea la celda Adress
            PdfPCell clAdress = new PdfPCell(new Phrase("Adress: ", _standardFont));
            clNom.BorderWidth = 1;
            clNom.BorderWidthBottom = 0f;
            //Se agrega la celda Adrees 
            tblNom_Adress.AddCell(clNom);
            tblNom_Adress.AddCell(clAdress);
            doc.Add(tblNom_Adress);
            

            // Creamos una tabla que contendrá el jobs, description y price
            // de nuestros visitante.
            PdfPTable tblPrueba = new PdfPTable(3);
            tblPrueba.WidthPercentage = 90;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clJobs = new PdfPCell(new Phrase("Job type", _standardFont));
            clJobs.BorderWidth = 1;
            clJobs.BorderWidthBottom = 0.75f;

    
            PdfPCell clDescription = new PdfPCell(new Phrase("Description", _standardFont));
            clDescription.BorderWidth = 1;
            clDescription.BorderWidthBottom = 0.75f;

            PdfPCell clPrice = new PdfPCell(new Phrase("Price", _standardFont));
            clPrice.BorderWidth = 1;
            clPrice.BorderWidthBottom = 0.75f;



            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clJobs);
            tblPrueba.AddCell(clDescription);
            tblPrueba.AddCell(clPrice);


            // Llenamos la tabla de JOBS con información
            clJobs = new PdfPCell(new Phrase("Tree Removal", _standardFont));
            clJobs.BorderWidth = 1;
            clDescription = new PdfPCell(new Phrase(Desc_tr.Text, _standardFont));
            clDescription.BorderWidth = 1;
            clPrice = new PdfPCell(new Phrase(Pri_tr.Text, _standardFont));
            clPrice.BorderWidth = 1;
            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clJobs);
            tblPrueba.AddCell(clDescription);
            tblPrueba.AddCell(clPrice);



            clJobs = new PdfPCell(new Phrase("Pruning", _standardFont));
            clJobs.BorderWidth = 1;
            clDescription = new PdfPCell(new Phrase(Desc_pr.Text, _standardFont));
            clDescription.BorderWidth = 1;
            clPrice = new PdfPCell(new Phrase(Pri_pr.Text, _standardFont));
            clPrice.BorderWidth = 1;
            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clJobs);
            tblPrueba.AddCell(clDescription);
            tblPrueba.AddCell(clPrice);


            clJobs = new PdfPCell(new Phrase("Stump Grinding", _standardFont));
            clJobs.BorderWidth = 1;
            clDescription = new PdfPCell(new Phrase(Desc_sg.Text, _standardFont));
            clDescription.BorderWidth = 1;
            clPrice = new PdfPCell(new Phrase(Pri_sg.Text, _standardFont));
            clPrice.BorderWidth = 1;
            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clJobs);
            tblPrueba.AddCell(clDescription);
            tblPrueba.AddCell(clPrice);


            clJobs = new PdfPCell(new Phrase("Mulching", _standardFont));
            clJobs.BorderWidth = 1;
            clDescription = new PdfPCell(new Phrase(Desc_mu.Text, _standardFont));
            clDescription.BorderWidth = 1;
            clPrice = new PdfPCell(new Phrase(Pri_mu.Text, _standardFont));
            clPrice.BorderWidth = 1;
            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clJobs);
            tblPrueba.AddCell(clDescription);
            tblPrueba.AddCell(clPrice);


            clJobs = new PdfPCell(new Phrase("Edging", _standardFont));
            clJobs.BorderWidth = 1;
            clDescription = new PdfPCell(new Phrase(Desc_ed.Text, _standardFont));
            clDescription.BorderWidth = 1;
            clPrice = new PdfPCell(new Phrase(Pri_ed.Text, _standardFont));
            clPrice.BorderWidth = 1;
            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clJobs);
            tblPrueba.AddCell(clDescription);
            tblPrueba.AddCell(clPrice);


            clJobs = new PdfPCell(new Phrase("Leaf Removal", _standardFont));
            clJobs.BorderWidth = 1;
            clDescription = new PdfPCell(new Phrase(Desc_lr.Text, _standardFont));
            clDescription.BorderWidth = 1;
            clPrice = new PdfPCell(new Phrase(Pri_lr.Text, _standardFont));
            clPrice.BorderWidth = 1;
            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clJobs);
            tblPrueba.AddCell(clDescription);
            tblPrueba.AddCell(clPrice);

            clJobs = new PdfPCell(new Phrase("Aeration", _standardFont));
            clJobs.BorderWidth = 1;
            clDescription = new PdfPCell(new Phrase(Desc_lr.Text, _standardFont));
            clDescription.BorderWidth = 1;
            clPrice = new PdfPCell(new Phrase(Pri_lr.Text, _standardFont));
            clPrice.BorderWidth = 1;
            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clJobs);
            tblPrueba.AddCell(clDescription);
            tblPrueba.AddCell(clPrice);

            clJobs = new PdfPCell(new Phrase("Sod Installation", _standardFont));
            clJobs.BorderWidth = 1;
            clDescription = new PdfPCell(new Phrase(Desc_si.Text, _standardFont));
            clDescription.BorderWidth = 1;
            clPrice = new PdfPCell(new Phrase(Pri_si.Text, _standardFont));
            clPrice.BorderWidth = 1;
            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clJobs);
            tblPrueba.AddCell(clDescription);
            tblPrueba.AddCell(clPrice);


            clJobs = new PdfPCell(new Phrase("Lost Cleaning", _standardFont));
            clJobs.BorderWidth = 1;
            clDescription = new PdfPCell(new Phrase(Desc_cc.Text, _standardFont));
            clDescription.BorderWidth = 1;
            clPrice = new PdfPCell(new Phrase(Pri_cc.Text, _standardFont));
            clPrice.BorderWidth = 1;
            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clJobs);
            tblPrueba.AddCell(clDescription);
            tblPrueba.AddCell(clPrice);

            

            doc.Add(tblPrueba);

            

            //TABLA DE LAWN
            PdfPTable tblLawn = new PdfPTable(4);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clJobs_L = new PdfPCell(new Phrase("Lawn Mower", _standardFont));
            clJobs.BorderWidth = 1;
            clJobs.BorderWidthBottom = 0.75f;


            PdfPCell clMes = new PdfPCell(new Phrase("    ", _standardFont));
            clMes.BorderWidth = 1;
            clMes.BorderWidthBottom = 0.75f;

            PdfPCell clDia = new PdfPCell(new Phrase("    ", _standardFont));
            clDia.BorderWidth = 1;
            clDia.BorderWidthBottom = 0.75f;

            PdfPCell clPrice_L = new PdfPCell(new Phrase("    ", _standardFont));
            clPrice.BorderWidth = 1;
            clMes.BorderWidthBottom = 0.75f;
            // Añadimos las celdas a la tabla
            tblLawn.AddCell(clJobs_L);
            tblLawn.AddCell(clMes);
            tblLawn.AddCell(clDia);
            tblLawn.AddCell(clPrice_L);

            doc.Add(tblLawn);

            clJobs = new PdfPCell(new Phrase("Others", _standardFont));
            clJobs.BorderWidth = 1;
            clDescription = new PdfPCell(new Phrase(Desc_ot.Text, _standardFont));
            clDescription.BorderWidth = 1;
            clPrice = new PdfPCell(new Phrase(Pri_ot.Text, _standardFont));
            clPrice.BorderWidth = 1;
            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clJobs);
            tblPrueba.AddCell(clDescription);
            tblPrueba.AddCell(clPrice);


            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Close();
            writer.Close();


        }
    }
}

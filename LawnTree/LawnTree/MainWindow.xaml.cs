using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LawnTree.Clases;
using System.Windows.Controls;

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
            Desc_lm.Visibility = Visibility.Hidden;
            Pri_lm.Visibility = Visibility.Hidden;
            Calen_lm.Visibility = Visibility.Hidden;

            Job_ot.Visibility = Visibility.Hidden;
            Desc_ot.Visibility = Visibility.Hidden;
            Pri_ot.Visibility = Visibility.Hidden;

        }

        //listBox Control
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
                Desc_lm.Visibility = visible;
                Pri_lm.Visibility = visible;
                Calen_lm.Visibility = visible;
            }
            else
            {
                Job_lm.Visibility = Visibility.Hidden;
                Desc_lm.Visibility = Visibility.Hidden;
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
    }
}

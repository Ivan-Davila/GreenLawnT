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

namespace LawnTree

{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Visibility visible, Hidden;
        int i = 1;

        public MainWindow()
        {
            InitializeComponent();
            Customer_Select.Items.Insert(0, "Select...");
            Customer_Select.SelectedIndex = 0;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) => tabControl.SelectedIndex = 2;


        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbBuscarPor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        
        private void Button2_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ListBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (List_tr.IsSelected)
            {
                Job_tr.Visibility = visible;
                Desc_tr.Visibility = visible;
                Pri_tr.Visibility = visible;
                i = 2;
            }
            else
            {
                Job_tr.Visibility = Visibility.Hidden;
                Desc_tr.Visibility = Visibility.Hidden;
                Pri_tr.Visibility = Visibility.Hidden;
                i = 1;

            }
        }

        private void MenuItem_N_I(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex=0;
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
        }

        private void MenuItem_D_C(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void MenuItem_D(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = 5;
        }


        private void Selected_Tree_Removal(object sender, RoutedEventArgs e)
        {
            
            
        }
        private void Selected_Pruning(object sender, RoutedEventArgs e)
        {
            Job_pr.Visibility = visible;
            Desc_pr.Visibility = visible;
            Pri_pr.Visibility = visible;

        }

        private void Selected_Stump_Grinding(object sender, RoutedEventArgs e)
        {
            Job_sg.Visibility = visible;
            Desc_sg.Visibility = visible;
            Pri_sg.Visibility = visible;
        }

        private void Selected_Mulching(object sender, RoutedEventArgs e)
        {
            Job_mu.Visibility = visible;
            Desc_mu.Visibility = visible;
            Pri_mu.Visibility = visible;
        }

        private void Selected_Edging(object sender, RoutedEventArgs e)
        {
            Job_ed.Visibility = visible;
            Desc_ed.Visibility = visible;
            Pri_ed.Visibility = visible;
        }

        private void Selected_Leaf_Removal(object sender, RoutedEventArgs e)
        {
            Job_lr.Visibility = visible;
            Desc_lr.Visibility = visible;
            Pri_lr.Visibility = visible;
        }

        private void Selected_Aeration(object sender, RoutedEventArgs e)
        {
            Job_ae.Visibility = visible;
            Desc_ae.Visibility = visible;
            Pri_ae.Visibility = visible;
        }

        private void Selected_Sod_installation(object sender, RoutedEventArgs e)
        {
            Job_si.Visibility = visible;
            Desc_si.Visibility = visible;
            Pri_si.Visibility = visible;
        }

        private void Selected_Cost_Cleaning(object sender, RoutedEventArgs e)
        {
            Job_cc.Visibility = visible;
            Desc_cc.Visibility = visible;
            Pri_cc.Visibility = visible;
        }

        private void Selected_Lawn_Mower(object sender, RoutedEventArgs e)
        {
            Job_lm.Visibility = visible;
            Desc_lm.Visibility = visible;
            Pri_lm.Visibility = visible;
            Calen_lm.Visibility = visible;
        }

        private void Selected_Others(object sender, RoutedEventArgs e)
        {
            Job_ot.Visibility = visible;
            Desc_ot.Visibility = visible;
            Pri_ot.Visibility = visible;
        }

        //Boton registrar
        Conexion obj_conexion = new Conexion();
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

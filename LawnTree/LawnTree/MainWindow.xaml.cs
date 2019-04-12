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

namespace LawnTree

{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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

        }

        private void Selected_Stump_Grinding(object sender, RoutedEventArgs e)
        {

        }

        private void Selected_Mulching(object sender, RoutedEventArgs e)
        {

        }

        private void Selected_Edging(object sender, RoutedEventArgs e)
        {

        }

        private void Selected_Leaf_Removal(object sender, RoutedEventArgs e)
        {

        }

        private void Selected_Aeration(object sender, RoutedEventArgs e)
        {

        }

        private void Selected_Sod_installation(object sender, RoutedEventArgs e)
        {

        }

        private void Selected_Cost_Cleaning(object sender, RoutedEventArgs e)
        {

        }

        private void Selected_Lawn_Mower(object sender, RoutedEventArgs e)
        {

        }

        private void Selected_Others(object sender, RoutedEventArgs e)
        {

        }

        private void sdfsfsfsf(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Customer_Select.Items.Insert(0, "Seleccionar");
            Customer_Select.SelectedIndex = 0;
        }
    }
}

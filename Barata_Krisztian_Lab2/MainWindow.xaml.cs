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



namespace Barata_Krisztian_Lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    
    {
        private int mRaisedGlazed = 0;
        private int mRaisedSugar = 0;
        private int mFilledLemon = 0;
        private int mFilledChocolate = 0;
        private int mFilledVanilla = 0;
        private double Total = 0;
        private DoughnutType selectedDoughnut;
        public MainWindow()

       
        {

            KeyValuePair<DoughnutType, double>[] PriceList = {
    new KeyValuePair<DoughnutType, double>(DoughnutType.Sugar, 2.5),
    new KeyValuePair<DoughnutType, double>(DoughnutType.Glazed,3),
    new KeyValuePair<DoughnutType, double>(DoughnutType.Chocolate,4.5),
    new KeyValuePair<DoughnutType, double>(DoughnutType.Vanilla,4),
    new KeyValuePair<DoughnutType, double>(DoughnutType.Lemon,3.5)
    };

            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtVanillaFilled_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_Price_Current_Sale_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void glazedMenuItem_Click(object sender, RoutedEventArgs e)
        {
            mRaisedGlazed++;
            txtGlazedRaised.Text = mRaisedGlazed.ToString();
        }

        private void sugarMenuItem_Click(object sender, RoutedEventArgs e)
        {
            mRaisedSugar++;
            txtSugarRaised.Text = mRaisedSugar.ToString();
        }

        private void lemonMenuItem_Click(object sender, RoutedEventArgs e)
        {
            mFilledLemon++;
            txtLemonFilled.Text = mFilledLemon.ToString();
        }

        private void chocolateMenuItem_Click(object sender, RoutedEventArgs e)
        {
            mFilledChocolate++;
            txtChocolateFilled.Text = mFilledChocolate.ToString();
        }

        private void vanillaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            mFilledVanilla++;
            txtVanillaFilled.Text = mFilledVanilla.ToString();
        }

        private void FilledItemsShow_Click(object sender, RoutedEventArgs e)
        {
            string mesaj;
            MenuItem SelectedItem = (MenuItem)e.OriginalSource;
            mesaj = SelectedItem.Header.ToString() + " doughnuts are being cooked!";
            this.Title = mesaj;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }




     
        
    }


    

}

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
using System.Windows.Shapes;

namespace BuyMoviez
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        MoviesContainer db = new MoviesContainer();
        public Window2()
        {
            InitializeComponent();
        }

     

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MainWindow sW = new MainWindow();
            sW.Show();
            this.Close();
        }

        private void D1Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from p in db.Actors
                        where p.MovieId < 5
                        select new
                        {
                            Movie = p.MovieId
                        };

            D1DvgDisplay.ItemsSource = query.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        { }

        private void D2Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from c in db.Movies
                        where c.Name == "Pineapple Express"
                        orderby c.MovieGenre

                        select new
                        {
                            c.MovieGenre,
                            c.Price
                        };

            D2DvgDisplay.ItemsSource = query.ToList().Distinct();


        }

        private void D3Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from o in db.Movies
                        select o.Price;

            D3DvgDisplay.ItemsSource = query.ToList();

        }
    }
}

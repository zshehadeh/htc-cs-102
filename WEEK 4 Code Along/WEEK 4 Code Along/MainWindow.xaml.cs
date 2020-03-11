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
using System.Collections.ObjectModel;

namespace WEEK_4_Code_Along
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ObservableCollection<Movie> movieList;
        
        
        public MainWindow()
        {
            InitializeComponent();
            movieList = new ObservableCollection<Movie>();
            lvMovies.ItemsSource = movieList;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            
            Movie movie = new Movie(titleInput.Text, Convert.ToInt32(releaseYearInput.Text), Convert.ToDouble(rottenInput.Text));

            int x = 0;

            foreach (Movie movie23 in movieList)
            {
                if(movie23.Title == movie.Title) 
                { 
                    MessageBox.Show("THERE IS A DUPLICATE!");
                    x++;
                }

            }

            if (x == 0) { movieList.Add(movie); }
            

            titleInput.Clear();
            releaseYearInput.Clear();
            rottenInput.Clear();

        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie movie in movieList)
            {
                movie.ShowDetails();
            }

        }

        private void lvMovies_MouseDoubleClick( object sender, MouseButtonEventArgs e)
        {
            Movie selectedMovie = lvMovies.SelectedItem as Movie;
            if (selectedMovie != null)
                {
                selectedMovie.ShowDetails();
                }


        }

    }
}

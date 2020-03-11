using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WEEK_4_Code_Along
{
    class Movie
    {
        public string Title { get; set;  }
        public int ReleaseYear { get; set; }

        public double RottenTomato { get; set; }




        public Movie(string myTitle, int myReleaseYear, double myRottenTomato)
        {
            Title = myTitle;
            ReleaseYear = myReleaseYear;
            RottenTomato = myRottenTomato;
        }

        public void ShowDetails()
        {
            string info = "Title: " + Title;
            info += "\nReleaseYear: " + ReleaseYear;
            info += "\nRottenTomato: " + RottenTomato;
            MessageBox.Show(info);
        }

    }
}

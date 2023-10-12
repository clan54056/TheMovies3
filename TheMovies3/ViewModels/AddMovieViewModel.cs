using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies3.ViewModels
{
    public class AddMovieViewModel : ViewModelBase
    {
        public MovieDetailsFormViewModel MovieDetailsFormViewModel { get; }

        public AddMovieViewModel()
        {
            MovieDetailsFormViewModel = new MovieDetailsFormViewModel();
        }
    }
}

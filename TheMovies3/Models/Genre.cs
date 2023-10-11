using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies3.Models
{
    public class Genre
    {
        public string GenreName { get; }

        public Genre(string genreName)
        {
            GenreName=genreName;
        }
    }
}

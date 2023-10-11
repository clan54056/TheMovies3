using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies3.Models
{
    public class Movie
    {
        public string Title { get; }
        public int Length { get; }

        public Movie(string title, int length, string genre)
        {
            Title = title;
            Length = length;
        }
    }
}

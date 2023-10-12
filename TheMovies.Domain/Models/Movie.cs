using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Domain.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        [ForeignKey(nameof(GenreId))]
        public int GenreId { get; set; }
        public List<Genre>? Genres { get; set; }

    }
}

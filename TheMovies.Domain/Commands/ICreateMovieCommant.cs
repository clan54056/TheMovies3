using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Domain.Models;

namespace TheMovies.Domain.Commands
{
    public interface ICreateMovieCommant
    {
        Task Execute(Movie movie);
    }
}

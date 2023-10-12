using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.EntityFrameWork
{
    public class MoviesDbContextFactory
    {
        
        private readonly DbContextOptions _options;

        public MoviesDbContextFactory(DbContextOptions options)
        {
            _options = options;
        }

        public MoviesDbContext Create()
        {

            return new MoviesDbContext(_options);
        }
    }
}

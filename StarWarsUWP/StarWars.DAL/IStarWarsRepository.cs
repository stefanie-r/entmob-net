﻿using StarWars.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.DAL
{
        public interface IStarWarsRepository
        {
            List<SWMovie> GetAllSWMovies();
            SWMovie GetMovieByUrl(string url);
        }
  
}

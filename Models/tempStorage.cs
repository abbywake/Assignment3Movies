﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3Movies.Models
{
//basically just doing what he did in the videos to make a list of inputs
    public static class tempStorage
    {
        private static List<movie> movieList = new List<movie>();

        public static IEnumerable<movie> Applications => movieList;

        public static void AddApplication(movie addmovies)
        {
            movieList.Add(addmovies);
        }
    }
}

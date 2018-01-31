﻿using SilverScreenReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverScreenReviews.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<User> Users { get; set; }
    }
}
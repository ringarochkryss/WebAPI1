﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ivar.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public DateTime Publish_Date { get; set; }
        public string Description { get; set; }
        }
}
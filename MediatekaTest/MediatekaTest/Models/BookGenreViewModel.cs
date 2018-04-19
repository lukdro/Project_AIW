using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatekaTest.Models
{
    public class BookGenreViewModel
    {
        public List<Book> books;
        public SelectList genres;
        public string bookGenre { get; set; }
    }
}

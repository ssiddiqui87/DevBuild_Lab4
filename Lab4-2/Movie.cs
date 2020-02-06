using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_2
{
    class Movie
    {
        private string title;
        private string category;

        public string Title { get => title; set => title = value; }
        public string Category { get => category; set => category = value; }

        public Movie(string title, string category)
        {
            this.title = title;
            this.category = category;
        }

        public override string ToString()
        {
            return $"{title}";
        }
    }
}

using BookMyShow.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Filters
{
    public class LanguageFilter : IFilter
    {
        public List<Show> Filter(List<Show> shows, string value)
        {
            throw new NotImplementedException();
        }
    }

    public class GenreFilter : IFilter
    {
        public List<Show> Filter(List<Show> shows, string value)
        {
            throw new NotImplementedException();
        }
    }

    
}

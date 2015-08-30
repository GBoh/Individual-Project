using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Individual_project.Models
{
    public class Repository
    {
        private DataContext _db = new DataContext();

        public List<Event> GetEvents()
        {
            return (from e in _db.Events select e).ToList();
        }
    }
}
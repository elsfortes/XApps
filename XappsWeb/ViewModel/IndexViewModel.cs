using XappsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XappsWeb.ViewModel
{
    public class IndexViewModel
    {
        public int Page { get; set; }
        public int Per_page { get; set; }
        public int Total { get; set; }
        public int Total_pages { get; set; }
        public IList<User> Users { get; set; }
        
    }
}
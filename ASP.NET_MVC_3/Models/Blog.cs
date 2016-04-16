using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_3.Models
{
    public class Blog
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string BlogAddress { get; set; }

        public string Description { get; set; }

    }
}
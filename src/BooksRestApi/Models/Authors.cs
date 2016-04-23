using System;
using System.Collections.Generic;

namespace BooksRestApi.Models
{
    public partial class Authors
    {
        public int id { get; set; }
        public short? birth_year { get; set; }
        public string country { get; set; }
        public DateTime created { get; set; }
        public string last_name { get; set; }
        public string name { get; set; }
        public DateTime updated { get; set; }
    }
}

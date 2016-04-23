using System;
using System.Collections.Generic;

namespace BooksRestApi.Models
{
    public partial class Collections
    {
        public int id { get; set; }
        public DateTime created { get; set; }
        public int editorial_id { get; set; }
        public string name { get; set; }
        public DateTime updated { get; set; }
    }
}

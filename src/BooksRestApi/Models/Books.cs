using System;
using System.Collections.Generic;

namespace BooksRestApi.Models
{
    public partial class Books
    {
        public int id { get; set; }
        public int author_id { get; set; }
        public int? collection_id { get; set; }
        public short? collection_index { get; set; }
        public string country { get; set; }
        public DateTime created { get; set; }
        public bool? ebook { get; set; }
        public short? edition_number { get; set; }
        public int? editorial_id { get; set; }
        public string isbn { get; set; }
        public string isbn10 { get; set; }
        public string language { get; set; }
        public string original_language { get; set; }
        public short pages { get; set; }
        public string title { get; set; }
        public bool? translated { get; set; }
        public string translator { get; set; }
        public DateTime updated { get; set; }
        public short? year { get; set; }
    }
}

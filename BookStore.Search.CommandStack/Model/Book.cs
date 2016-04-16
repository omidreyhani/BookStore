using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Search.CommandStack.Model
{
    public class Book 
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Imageurl { get; set; }
        [Key]
        public string Isbn13 { get; set; }
    }
}

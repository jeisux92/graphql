using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphql.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Url { get; set; }
        public Author Author { get; set; }
        public string[] Categories { get; set; }
        public Rating Rating { get; set; }
        public List<Comment> Comments { get; set; }
    }
}

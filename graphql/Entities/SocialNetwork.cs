using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphql.Entities
{
    public class SocialNetwork
    {
        public SNType Type { get; set; }
        public string NickName { get; set; }
        public string Url { get; set; }
        public Author Author { get; set; }
    }
    public enum SNType
    {
        INSTAGRAM, TWITTER
    }
}

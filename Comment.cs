using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enforcer5.Models.Perspective
{
    public class Comment
    {
        public string text { get; set; }
        public string type { get; set; }

        public Comment(string text, string type = "PLAIN_TEXT")
        {
            this.text = text;
            this.type = type;
        }

        public static implicit operator string(Comment v)
        {
            throw new NotImplementedException();
        }
    }
}

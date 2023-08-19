using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFacebook
{
    public class FBComment
    {
        public string Owner { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string ToString()
        {
            return $"{Owner} says: \n" +
                   $"\"{Comment}\"" +
                   $"\n\t\t\t\t {CreatedAt.ToString("yyyy-MM-dd hh:mm")}";
        }
        
    }
}

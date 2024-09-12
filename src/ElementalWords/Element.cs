using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementalWords
{
    public record Element(string Symbol, string Name)
    {

        public override string ToString()
        {
            return $"{Name} ({Symbol})"; 
        }

    }
}

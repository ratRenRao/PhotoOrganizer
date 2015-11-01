using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoOrganizer.PictureObjects
{
    class Tag
    {
        private int id { get; set; }
        private string name { get; set; }
    
        public Tag( int id, string name )
        {
            this.id = id;
            this.name = name;
        }
    }
}

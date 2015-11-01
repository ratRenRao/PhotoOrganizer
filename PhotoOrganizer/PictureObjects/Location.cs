using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waymex.Gps;
using SpatialReference;

namespace PhotoOrganizer.PictureObjects
{
    class Location
    {
        private int id { get; set; }
        private Coordinate coord { get; set; }
        
        public Location(int id, Coordinate coord)
        {
            this.id = id;
            this.coord = coord;
        }
    }
} 
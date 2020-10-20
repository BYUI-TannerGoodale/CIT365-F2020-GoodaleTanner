using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Goodale
{

    class Desk
    {
        // Define attributes of a desk
        public int width;
        public int depth;
        public int drawersNumber;
        public int surfaceMaterial;

        // Set constants for Max/Min Depth/Width
        public const int MAX_WIDTH = 96;
        public const int MAX_DEPTH = 48;
        public const int MIN_WIDTH = 24;
        public const int MIN_DEPTH = 12;
    }

    public enum SurfaceMaterial
    {
        Pine = 50,
        Laminate = 100,
        Veneer = 125,
        Oak = 200,
        Rosewood = 300
    };
}

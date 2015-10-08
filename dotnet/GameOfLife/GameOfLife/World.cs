using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public  class World
    {
        public int Length { get; set; }
        public int Width { get; set; }
        private  object[,] CellArray;

        public int count = 0;
        public int Count()
        {
            
            return 0;
        }
   

        public World()
        {
            this.Length = 12;
            this.Width = 12;
            this.CellArray = new object [Length, Width];

           
              
        }

    }
}

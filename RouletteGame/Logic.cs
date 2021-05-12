using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGame
{
    public class Logic
    {
        private int position;
        public void Load()
        {
            this.position = 1;
        }
        public void Spin()
        {
            this.position = new Random().Next(15001) % 6 + 1;
        }
        public bool Fire(int position)
        {
            return this.position == position;
        }
    }
}

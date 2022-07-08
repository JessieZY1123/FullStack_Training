using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_HW
{
    public class Ball
    {
        public Color color;
        public int Size { get; set; }
        public int trackTimes { get; set; }

        public Ball(Color color, int size, int trackTimes)
        {
            this.color = color;
            Size = size;
            this.trackTimes = trackTimes;
        }
        public Ball(Color color, int size)
        {
            this.color = color;
            Size = size;
            this.trackTimes = 0;
        }
        public void Pop() {
            Size = 0;
        }

        public void Throw() {
            if (Size != 0) {
                trackTimes ++ ;
            }
        }

        public int getTrackTimes() { 
            return trackTimes;
        }

    }
}

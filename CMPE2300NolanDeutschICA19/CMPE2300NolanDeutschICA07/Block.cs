using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace CMPE2300NolanDeutschICA07
{
    class Block : IComparable
    {
        //public automatic static properties
        public static CDrawer Canvas{ get; private set; }
        public static int Height { get; private set; }
        //private static field of Random, seed with 1
        private static Random _gen = new Random(1);
        //public automatic instance property int Width, hidden set
        public int Width { get; private set; }
        //public automatic instance property bool HighLight
        public bool HighLight { get; set; }
        //private instance field of Color
        private Color _blockColour;

        //static constructor
        static Block()
        {
            Height = 20;
            Canvas = new CDrawer();
            Canvas.BBColour = Color.White;
            Canvas.ContinuousUpdate = false;
        }
        //instance default constructor
        public Block()
        {
            Width = _gen.Next(1, 20) *10;
            HighLight = false;
            _blockColour = Color.FromArgb(_gen.Next(2, 8) * 32,
                _gen.Next(2, 8) * 16, _gen.Next(2, 8) * 16);
        }
        //Override Equals, return true if the width and color are the same for both Blocks
        public override bool Equals(object obj)
        {
            if (!(obj is Block))
                return false;
            Block temp = obj as Block;
            return (this.Width == temp.Width && this._blockColour == temp._blockColour);
        }
        public override int GetHashCode()
        {
            return 1;
        }
        //public method, accepts a Point and returns nothing
        public void ShowBlock(Point p)
        {
            if (HighLight)
                Canvas.AddRectangle(p.X, p.Y, Width,
                    Height, _blockColour, 2, Color.Yellow);
            else
                Canvas.AddRectangle(p.X, p.Y, Width,
                   Height, _blockColour, 1, Color.Black);
        }

/////////// IComparable Methods ///////////

        public int CompareTo(object obj)
        {
            if (obj == null || !(obj is Block))
                throw new ArgumentException("Object is not valid");
            Block temp = (Block)obj;
            return this._blockColour.ToArgb().CompareTo(temp._blockColour.ToArgb());

        }
        public static int CompareWidth(Block left, Block right)
        {
            if (left == null && right == null)
                return 0;
            else if (left == null)
                return -1;
            else if (right == null)
                return 1;

            return (left.Width - right.Width);
        }
        public static int CompareWidthCol(Block left, Block right)
        {
            int temp = CompareWidth(left, right);
            if (temp == 0)
            {
                return left._blockColour.ToArgb().CompareTo(right._blockColour.ToArgb());
            }
            return temp;
        }

        public static bool Brightness(Block b)
        {
            return (b._blockColour.GetBrightness() > 0.5);
        }
    }
}

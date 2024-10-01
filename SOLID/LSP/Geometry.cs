using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public interface IArea
    {
        int GetArea();
    }
    public class Geometry
    {
        //public Rectangle GetRectangle()
        //{
        //    //bir biçimde....
        //    return new Square();
        //}

        public IArea GetRectangle(int width, int? height = null)
        {
            if (height.HasValue)
            {
                return new Rectangle { Width = width, Height = height.Value };
            }
            return new Square { EdgeLength = width };
        }
    }

   

    public class Rectangle : IArea
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }


        public int GetArea() => Width * Height;

    }

    public class Square  : IArea//: Rectangle
    {
        //public override int Width { get => base.Width; set { base.Width = value; base.Height = value; } }
        //public override int Height { get => base.Height; set { base.Width = value; base.Height = value; } }

        public int EdgeLength { get; set; }
        public int GetArea() => EdgeLength * EdgeLength;

    }


}

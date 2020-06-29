using System;

namespace StructSamples
{
    public interface IStructOps
    {
        void ShowCoordinate();
    }

    public class StructOps
    {
        struct Coordinate
        {
            // Struct may contain constructor
            public Coordinate(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; }
            public int Y { get; }

            public void SumCoordinates()
            {
                Console.WriteLine($"{this.X + this.Y}");
            }
        }

        struct ThirdDimension: IStructOps /*StructOps : struct can't inherit struct*/
        {
            public int Z;
             
            public void ShowCoordinate()
            {
                Console.WriteLine($"{Z}");
            }
          
            Coordinate c;
            /*
             * You can't set value from one structure,
             * when inside anoter structure
             * c.X = 5; - exception
             */
        }

        void StructProcessing()
        {
            /* Before call any fields or struct methods.
             * you have to initialize struct variable
             * with constructor like this:  
             * Coordinate p = new Coordinate(10, 20);
             * Or with just delaration like this:
             * ThirdDimension td;
             */
            Coordinate p = new Coordinate(10, 20);
            p.SumCoordinates();
            ThirdDimension td;
            td.Z = 20;
        }
    }


}

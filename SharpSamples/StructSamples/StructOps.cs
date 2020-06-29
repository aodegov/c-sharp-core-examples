using System;

namespace StructSamples
{
    public interface IStructOps
    {
        void ShowCoordinates();
    }

    public class StructOps
    {
        struct Coordinate
        {
            public int X;
            public int Y;
        }

        struct ThirdDimension: IStructOps /*StructOps : struct can't inherit struct*/
        {
            public int Z;

            public void ShowCoordinates()
            {
                throw new NotImplementedException();
            }
        }
    }


}

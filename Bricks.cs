using System;
namespace HW1802
{
    public class Brick
    {
       public string color;
       public int weight;
       public static Brick[] CreateBriks()
        {
            Brick brik1 = new Brick
            {
                color = "red",
                weight = 5,
            };
            Brick brik2 = new Brick
            {
                color = "white",
                weight = 10,
            };

            Brick brik3 = new Brick
            {
                color = "yellow",
                weight = 55,
            };
            Brick brik4 = new Brick
            {
                color = "black",
                weight = 15,
            };
            Brick[] bricks = new Brick[]
            {
                brik1,brik2,brik3,brik4
            };

            return bricks;
        } 
    }

}


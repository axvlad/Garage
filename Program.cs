using System;

namespace HW1802
{
    class Program
    {
        public static void PrintGarage(Brick brik1, Brick brik2, SportCars car1, SportCars car2)
        {
            Console.WriteLine("Brik1:");
            Console.WriteLine(brik1.color);
            Console.WriteLine(brik1.weight);
            Console.WriteLine("----------");
            Console.WriteLine("brik2:");
            Console.WriteLine(brik2.color);
            Console.WriteLine(brik2.weight);
            Console.WriteLine("Cars:");
            Console.WriteLine("car1");
            Console.WriteLine(car1.name);
            Console.WriteLine(car1.country);
            Console.WriteLine(car1.maxspeed);
            Console.WriteLine("----------");
            Console.WriteLine("car2:");
            Console.WriteLine(car2.name);
            Console.WriteLine(car2.country);
            Console.WriteLine(car2.maxspeed);
        }
        public static void PrintGarages(Garge[] garages)
        {
            for (int i = 0; i < garages.Length; i++)
            {
                for (int j = 0; j < garages[i].Bricks.Length; j++)
                {
                    Console.WriteLine(garages[i].Bricks[j].color);
                    Console.WriteLine(garages[i].Bricks[j].weight);
                }
                Console.WriteLine(garages[i].SportCars.maxspeed);
                Console.WriteLine(garages[i].SportCars.name);
                //garages[i].Bricks
            }
            // То, что сделал цикл (без спорткаров)
            /* Console.WriteLine(garages[0].Bricks[0].color);
            Console.WriteLine(garages[0].Bricks[0].weight);
            Console.WriteLine(garages[0].Bricks[1].color);
            Console.WriteLine(garages[0].Bricks[1].weight);
            Console.WriteLine(garages[1].Bricks[0].color);
            Console.WriteLine(garages[1].Bricks[0].weight);
            Console.WriteLine(garages[1].Bricks[1].color);
            Console.WriteLine(garages[1].Bricks[1].weight);*/
        }

        public static Garge[] CreateGarage()
        {
            Brick[] bricks = Brick.CreateBriks();
            Garge garage = new Garge()
            {
                Bricks = new Brick[]
                {
                    bricks[0], bricks[1]
                },
                SportCars = new SportCars
                {
                    name = "car2",
                    maxspeed = 300,
                    country = "usa2",
                }
            };

            Garge garage2 = new Garge()
            {
                Bricks = new Brick[]
                {
                    bricks[2], bricks[3]
                },
                SportCars = new SportCars
                {
                    name = "car1",
                    maxspeed = 200,
                    country = "usa",
                }
            };
            Garge[] garages = new Garge[]
            {
                garage,garage2
            };

            return garages;
        }


        static void Main(string[] args)
        {
            // Переменные для гаража
            SportCars car1 = new SportCars
            {
                name = "lamborgini",
                country = "USA",
                maxspeed = 300,
            };

            SportCars car2 = new SportCars
            {
                name = "ferari",
                country = "Ukraine",
                maxspeed = 299,
            };

            //PrintGarage(brik1,brik2,car1,car2);
            //CreateGarage();
            Garge[] garages = CreateGarage(); 
            PrintGarages(garages);

        }
    }
}

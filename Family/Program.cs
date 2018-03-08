using System;

namespace Family
{
    class Program
    {
        static void Main(string[] args)
        {
            Mum mum = new Mum();
            Uncle uncle = new Uncle();
            Son son = new Son();

            mum.LikeFood();
            mum.RideBicycle();
            uncle.TakeOutRubbish();
            uncle.LikeFruit();
            son.LikeFood();
            son.RideBicycle();
            son.TakeOutRubbish();
            Console.ReadLine();
        }
    }
}

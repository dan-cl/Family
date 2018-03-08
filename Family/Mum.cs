using System;

namespace Family
{
    class Mum : IGrandpa
    {
        public virtual string Name { get; set; }

        public Mum()
        {
            Name = "Mum";
        }
        public void LikeFood()
        {
            Console.WriteLine(Name + " likes sandwiches");
        }
        public void RideBicycle()
        {
            Console.WriteLine(Name + " rides a bike");
        }

        public virtual void TakeOutRubbish()
        {
            throw new NotSupportedException();
        }

        public void LikeFruit()
        {
            throw new NotSupportedException();
        }
    }
}

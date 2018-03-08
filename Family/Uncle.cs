using System;

namespace Family
{
    class Uncle : IGrandpa
    {
        public virtual string Name { get; set; }

        public Uncle()
        {
            Name = "Uncle";
        }
        public void LikeFood()
        {
            throw new NotSupportedException();
        }
        public void RideBicycle()
        {
            throw new NotSupportedException();
        }

        public void TakeOutRubbish()
        {
            Console.WriteLine(Name + " takes out rubbish");
        }

        public void LikeFruit()
        {
            Console.WriteLine(Name + " likes apples");
        }
    }
}

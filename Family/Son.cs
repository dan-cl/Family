using System;

namespace Family
{
    class Son : Mum

    {
        public override string Name { get; set; }

        public Son()
        {
            Name = "Son";
        }
        public override void TakeOutRubbish()
        {
            Console.WriteLine(Name + " takes out rubbish");
        }

    }
}

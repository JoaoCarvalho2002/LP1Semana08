using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public class Unit
        {
            private int movement ;
            public int Health{get;set;}
        
            public Unit (int movement,int health) {
            this.movement = movement ;
            Health = health ;
            }
            public void Move(){

                Console.WriteLine("okkk");
            }
        }

        
    }
}

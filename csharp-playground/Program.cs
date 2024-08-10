using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Segitiga segitiga = new Segitiga();
            segitiga.alas = 4;
            segitiga.tinggi = 5;
            Console.WriteLine(segitiga.luasSegitiga());

            Pikachu pikachu = new Pikachu();
            pikachu.atk = 31;
            pikachu.def = 29;
            pikachu.hp = 300;
            pikachu.attack();
            pikachu.surf();

            Raichu raichu = new Raichu("Chu", 23);
            raichu.atk = 31;
            raichu.def = 29;
            raichu.hp = 300;
            raichu.attack();
            raichu.surf();
            raichu.gigaImpact();
            Console.ReadLine();
        }
    }

    class Segitiga
    {
        public int alas { get; set; }
        public int tinggi { get; set; }

        public double luasSegitiga()
        {
            return ((alas * tinggi) / 2);
        }
    }

    abstract class Enemy
    {
        public Enemy(string test)
        {

        }
        public string name { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public int hp { get; set; }

        public void attack() 
        {
            Console.WriteLine("HE ATTACC");
        }

        public void defense()
        {
            Console.WriteLine("HE PTROTECC");
        }
    }

    interface Electric
    {
        void thundershock();
    }

    interface Normal
    {
        void bodySlam();
    }

    class Pikachu: Enemy
    {
        public Pikachu(int def)
            :base("hello")
        {

        }
        public void surf()
        {
            Console.WriteLine("Surfing");
        }
    }

    class Raichu: Pikachu, Electric, Normal
    {
        public Raichu(string name, int atk)
            :base(23)
        {
            
        }

        public Raichu(string name, int atk, string alias)
            :base(32)
        {

        }

        new public void attack()
        {
            Console.WriteLine("ATTACK BRUTALL");
        }
        public void bodySlam()
        {
            throw new NotImplementedException();
        }

        public void gigaImpact()
        {
            Console.WriteLine("Giga Impact");
        }

        public void thundershock()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Superman clarkKent = new Superman("Clark Kent", 19, 999999);
            Spiderman petterParker = new Spiderman("Petter Parker", 18, 3.5);
            Flash berryAllen = new Flash("Berry Allen", 16, 100.9);

            ISuperHero[] superHeroes = new ISuperHero[3];
            superHeroes[0] = clarkKent;
            superHeroes[1] = petterParker;
            superHeroes[2] = berryAllen;

            foreach (ISuperHero hero in superHeroes)
            {
                ActivateHero(hero);
            }

        }

        static void ActivateHero(ISuperHero superHero)
        {
            superHero.ActivateSuperPowers();
        }

        static void IdentifyHero(ISuperHero hero)
        {
            if (hero is Superman)
            {
                Console.WriteLine("Its a bird?! Its a plane?!");
            }
            else if (hero is Spiderman)
            {
                Console.WriteLine("Does what a spider can!");
            }
            else if (hero is Flash)
            {
                Console.WriteLine("ZOOM!");
            }
            else
            {
                Console.WriteLine($"This is : {hero.GetType()}");
            }
        }

            static void GetMoreHeroData(ISuperHero hero)
            {
                Superman superman = hero as Superman;
                if (superman != null)
                {
                    Console.WriteLine(superman.Speed);
                }
                else
                {
                    Spiderman spiderMan = hero as Spiderman;
                    if (spiderMan != null)
                    {
                        Console.WriteLine(spiderMan.WebLeft);
                    }
                    else
                    {
                        Flash flash = hero as Flash;
                        if (flash != null)
                        {
                            Console.WriteLine(flash.Voltage);
                        }
                        else
                        {
                            Console.WriteLine("Hero not recognized!");
                        }
                    }
                }
            }

        static ISuperHero CreateHero(string hero)
        {
            switch (hero)
            {
                case "Flash":
                    return new Flash("Berry Allen", 16, 100.9);
                case "SuperMan":
                    return new Superman("Clark Kent", 19, 999999);
                case "SpiderMan":
                    return new Spiderman("Petter Parker", 18, 3.5);
                default:
                    return null;
            }
        }
    }
    }
            



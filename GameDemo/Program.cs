using GameFrameworkLibrary_MandatoryAssignment.Creatures;
using GameFrameworkLibrary_MandatoryAssignment.WeaponFactory.Factories;
using GameFrameworkLibrary_MandatoryAssignment.WeaponFactory;
using GameFrameworkLibrary_MandatoryAssignment.World;

using System;
using System.Configuration;
using GameFrameworkLibrary_MandatoryAssignment.Trace_logs;
using System.Xml;
using GameFrameworkLibrary_MandatoryAssignment.States;
using System.Diagnostics;
using GameDemo.MyOwnWeapons;
using GameFrameworkLibrary_MandatoryAssignment.Framework_Configurations;

namespace GameDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logging the configurations to the console");
            Console.WriteLine("===========================================");

            //Using the Framework Configurations Folder
            //Error File Not Found Exception- Could not find CustomTags file, so it just logs on the console for the time being

            WorldSection  group = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).SectionGroups["worldSection"] as WorldSection;
            foreach (ConfigurationSection section in group.Sections)
            {
                    Console.WriteLine();
                    Console.WriteLine("you are accessing ==>" + section.SectionInformation.Name.ToUpper());
                    Console.WriteLine();
                     if (section.GetType() == typeof(GameEnvironment))
                     {
                             GameEnvironment c = (GameEnvironment)section;
                             WorldObjectElementCollection collection = c.WorldWorldObject;

                             foreach (WorldObjectElements item in collection)
                             {
                                    Console.WriteLine(item.Name, item.DefencePoints, item.AttackPoints);
                                    Console.WriteLine("Your log file link", ConfigurationManager.AppSettings["logfile"]);
                                    Console.WriteLine();
                             }
                     }
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Creating new Creatures");
            Console.WriteLine("===========================================");

            Creature cr = new Creature();
            cr.Name = "Hero";
            cr.Hitpoints = 100;
            cr.State = new CreatureStateWeakened();
            Console.WriteLine($"This is the weakened state of : {cr}");

           
            Console.WriteLine();
            Console.WriteLine();

            cr.ReceiveHit(10);
            Creature creature = new Creature();
            creature.State = new CreatureStateWeakened();
            Tracing.log(TraceEventType.Error, "you are dead");
            
            cr.ChangeState(new CreatureStateWeakened());
           

            cr.ReceiveHit(10);

            Console.WriteLine(cr);

            IWeaponFactoryForAttackItems spear = new WeaponFactoryAttackItem();
          


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("World Singleton testing ");
            Console.WriteLine("===========================================");
          
            //Testing the world singleton design. The world can only be created once.

            try
            {
                Console.WriteLine(World.GetWorld);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            World.Create(50, 50);

            Console.WriteLine(World.GetWorld);


            try
            {
                World.Create(100, 100);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            World.Reset();

            try
            {
                Console.WriteLine(World.GetWorld);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine();
            Console.WriteLine();

            //Creating a new creature where we have given it a  capacity of weapons it can carry
            Console.WriteLine("New creature with weapons");
            Console.WriteLine("===========================================");


            var soldier = new Creature(2, 4);
         
            Console.WriteLine($"Soldier  has the following capacity of attack weapons {soldier.AttackWeapons.Capacity}");
            Console.WriteLine($"Soldier  has the following capacity of defense weapons {soldier.DefenceWeapons.Capacity}");
           
            var medic = new Creature(1, 5);
            Console.WriteLine($"Medic has the following number of attack weapons {medic.AttackWeapons.Capacity}");
            Console.WriteLine($"Medic has the following number of defense weapons {medic.DefenceWeapons.Capacity}");
            Console.WriteLine(medic.DefenceWeapons.Capacity);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("New Weapons");
            Console.WriteLine("===========================================");
            IWeaponFactoryForAttackItems factory = new WeaponFactoryAttackItem();
            var sword = factory.Create(WeaponTypeAttack.Melee);
            sword.Name = "Excalibur";
            var sword2 = factory.Create(WeaponTypeAttack.Melee);

            soldier.Loot(sword);
            Console.WriteLine($"The soldier creature has the following number of looted items in íts rucksack:  {soldier.Rucksack.Count}");


            Console.WriteLine(sword);
            Console.WriteLine(sword2);

            Console.WriteLine();
            Console.ReadLine();

            IWeaponFactoryForAttackItems myFactory = new OtherWeapons();
            var dagger = myFactory.Create(WeaponTypeAttack.Melee);
            Console.WriteLine(dagger.Name);

            Console.ReadKey();
        }
    }
}

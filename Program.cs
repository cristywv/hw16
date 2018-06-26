using System;
using System.Diagnostics;

namespace myStory
{
    class Program
    {
        static void Main(string[] args)
        {
     

            ProcessStartInfo allgirls = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            allgirls.Arguments = "https://i.ytimg.com/vi/uVPBZpok3jI/maxresdefault.jpg";
            ProcessStartInfo superheroattack = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            superheroattack.Arguments = "https://i1.wp.com/seoulbeats.com/wp-content/uploads/2011/07/070120_cl_seoulbeats.jpg";
            ProcessStartInfo shumanatta = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            shumanatta.Arguments = "http://farm7.static.flickr.com/6022/5958994218_e09341b048.jpg";
            ProcessStartInfo minzyfi = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            minzyfi.Arguments = "https://c1.staticflickr.com/7/6029/5958434373_e9861a41dc_b.jpg";
            ProcessStartInfo monster = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            monster.Arguments = "http://rhythmkan.com/wp-content/uploads/2011/07/21_hateyoumv_3.jpg";
            ProcessStartInfo ANTIfi = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            ANTIfi.Arguments = "https://ohdara.files.wordpress.com/2011/07/teaser-2ne1-hate-you-www-keepvid-com-0264.jpg?w=878";


            Console.WriteLine("In the land of Pandorella, the citizens live a draconian life.");
            Console.ReadKey();
            Console.WriteLine("Your lives are planned for you, following a strict schedule");
            Console.ReadKey();
            Console.WriteLine("2NE1 wanted to break those laws, and live their own lives.");
            Process.Start(allgirls);
            Console.ReadKey();
            Console.WriteLine("They no longer wanted to be taught what or who to love, but to live out their own dreams.");
            Console.ReadKey();
            Console.Write("There was someone standing in the way... the evil supervillain named [enter name]");
            string Vill = Console.ReadLine();
            Console.ReadKey();
            SuperVillain Villain = new SuperVillain(Vill, 100, 35, "dark aura manipulation");
            Console.WriteLine("Please name the superhero of 2NE1 [Enter name]");
            string HERO = Console.ReadLine();
            Console.ReadKey();
            SuperHero SHero = new SuperHero(HERO, 50, 35, "super strength");
            Console.ReadKey();
            Console.WriteLine("Please name the superhuman of 2NE1 [Enter name]");
            string huma = Console.ReadLine();
            Console.ReadKey();
            SuperHuman Shuman = new SuperHuman(huma, 50, 25);
            Console.WriteLine("{0} and {1} had two more friends that were going to help them defeat {2}", HERO, huma, Vill);
            Console.ReadKey();
            Console.Write("Minzy and [enter name] were the perfect additions to help defeat {0}  ", Vill);
            string AHero = Console.ReadLine();
            Console.ReadKey();
            AntiHero AThero = new AntiHero(AHero, 100, 20, "Healer");
            Console.WriteLine("{0} is very strong, but with the combined forces of 2NE1 that gives them the best chance to defeat this evil super villain and regain their freedom.", Vill);
            Console.ReadKey();
            Console.WriteLine("They journeyed West to seek the evil {0} and defeat him once and for all", Vill);
            Console.ReadKey();
            Console.WriteLine("After a difficult journey, they finally found {0} in his secret human form", Vill);
            Console.ReadKey();
            Console.WriteLine("{0} went into attack mode right away with her {1} at {2} strength", HERO, SHero._specialty, SHero._strength);
            Console.ReadKey();
            Process.Start(superheroattack);
            Console.ReadKey();
            int Vhp = Villain._hp;
            Vhp -= SHero._strength;
            Console.WriteLine("{0}'s health points diminished to {1}", Vill, Vhp);
            Console.ReadKey();
            Console.WriteLine("{0} attacked {1} next with her {2} attack.", huma, Vill, Shuman._strength);
            Console.ReadKey();
            Process.Start(shumanatta);
            Console.ReadKey();
            Vhp -= Shuman._strength;
            Console.WriteLine("{0}'s hp diminished to {1}", Vill, Vhp);
            Console.ReadKey();
            Process.Start(superheroattack);
            Console.ReadKey();
            Console.WriteLine("Minzy attacked {0} and he transformed into another scary form", Vill);
            Console.ReadKey();
            Process.Start(monster);
            Console.WriteLine("{0} took out her special gun and blasted {1} into the netherworld where he could no longer bother anyone in Pandorella", AHero, Vill);
            Console.ReadKey();
            Process.Start(ANTIfi);
            Console.ReadKey();
            Console.WriteLine("The citizens of Pandorella were extremely happy about their freedom and being able to live their life they way they chose to.");
            Console.ReadKey();
            Console.WriteLine("Pandorella turned into a beautiful place of PEACE, LOVE, UNITY and RESPECT.");
            Console.ReadKey();
        }
    }
}

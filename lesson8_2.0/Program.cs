using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {      
                if (Properties.Settings.Default.name != String.Empty)
                {
                    Console.WriteLine($"{Properties.Settings.Default.SayHi} {Properties.Settings.Default.name}, вам всего {Properties.Settings.Default.age}, а вы уже { Properties.Settings.Default.profession}");
                    Clear();
                }
                else
                {
                    Console.WriteLine(Properties.Settings.Default.SayHi);
                    Properties.Settings.Default.name = question("Как вас зовут?");
                    Properties.Settings.Default.age = Convert.ToInt32(question("Сколько вам лет?"));
                    Properties.Settings.Default.profession = question("Кем вы работаете?");
                    Properties.Settings.Default.Save();
                }
                Console.ReadLine();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static string question(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
        static void Clear()
        {
            Properties.Settings.Default.name = string.Empty;
            Properties.Settings.Default.age = 0;
            Properties.Settings.Default.profession = string.Empty;
            Properties.Settings.Default.Save();
        }

    }
}

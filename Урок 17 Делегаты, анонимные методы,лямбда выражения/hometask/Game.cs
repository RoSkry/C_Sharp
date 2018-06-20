using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hometask
{
    class Game
    {
        public int Popitok { get; set; } = 0;
        public bool Death_of_Game { get; set; } = false;
        public DateTime Start { get; set; } = DateTime.Now;
        public static System.Timers.Timer timer;
        public string[] action = new string[] { "Покормите", "Выгуляйте","Поиграйте","Вылечите","Улдожите спать"};
         public Game()
        {
            timer = new System.Timers.Timer { Interval = 3000};
            timer.Elapsed += Timer_Elapsed;
          
            timer.Start();
            while(Death_of_Game != true)
            {
               
            }
        }
      public void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            
            timer.Stop();
            Console.WriteLine("                    m\n$m                mm            m\n\"$mmmmm      m$\"    mmmmmmm$\"\n\"\"\"$m   m$    m$\"\"\"\"\"\"\nmmmmmmm$$$$$$$$$\"mmmm\nmmm$$$$$$$$$$$$$$$$$$ m$$$$m  \"    m  \"\n$$$$$$$$$$$$$$$$$$$$$$  $$$$$$\"$$$\nmmmmmmmmmmmmmmmmmmmmm  $$$$$$$$$$\n$$$$$$$$$$$$$$$$$$$$$  $$$$$$$\"\"\"  m\n\"$$$$$$$$$$$$$$$$$$$$$ $$$$$$  \"   \"\n     \"\"\"\"\"\"\"$$$$$$$$$$$m \"\"\"\"\n       mmmmmmmm\"  m$   \"$mmmmm\n     $$\"\"\"\"\"\"      \"$     \"\"\"\"\"\"$$\n   m$\"               \"m           \"\n                       \"\"\n"
           );
            Prosba();
            if(Death_of_Game==true)
            {
                timer.Close();
            }
            timer.Start();
        }
       public void Prosba()
        {     

         int a;
            Random rand = new Random();
            do
            {                    
                a = rand.Next(0, 5);
               
                if (MessageBox.Show($"{action[a]}", "Просьба", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    Popitok++;
                }
                else MessageBox.Show("ok");
                  
                if (Popitok == 3)
                {
                    Death_of_Game = true;
                    break;
                }

            } while (true);

        }

    }
}

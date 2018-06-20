using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elect
{
    class Program
    {
        static void Main(string[] args)
        {
            const int people = 200000;
            Election election = new Election();
            election.ElectionEvent += Electorate.Voiting;
            List<Candidate> candidates = new List<Candidate>()
            {
                new Candidate {Lastname="Default"},
                new Candidate {Lastname="Skripnik Rostislav",Congratulation="I am happy" },
                new Candidate {Lastname="Ivanov",Congratulation="It is great" },
                new Candidate {Lastname="Petrov",Congratulation="Congratulation on wining" },
                new Candidate {Lastname="Sidorov",Congratulation="I am sad, bastard" },
                 new Candidate {Lastname="None"},
            };
   do
            {
            List<Candidate> query = new List<Candidate>(); //список значeний голосов кто сколько набрал       
            int number = 0;       
                for (; number < 3; number++)
                {
                    for (int i = 0; i < people; i++)
                    {
                        candidates[election.OnElection()].VoiceCount++;
                    }
                    if (candidates[0].VoiceCount > people * 0.15)
                    {
                        for (int j = 0; j < candidates.Count; j++)
                        {
                            candidates[j].VoiceCount = 0;
                        }
                        continue;
                    }

                    var temp = candidates.Where(c => c.Lastname != "Default" && c.Lastname != "None");
                    query = temp.Where(c => c.VoiceCount == temp.Max(t => t.VoiceCount)).ToList();
                    if (query.Count == 1)
                    {
                        break;
                    }

                }
           
            if(number<3)
            {
                Console.WriteLine(query[0]);
            }
            else  Console.WriteLine("Анархия");
 } while (Console.ReadKey().KeyChar!='y');
            //if (number == 3) Console.WriteLine("Анархия");
            //else Console.WriteLine(query[0]);
        }
    }
}

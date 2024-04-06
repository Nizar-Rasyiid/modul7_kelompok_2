using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_1302220037_Nizar_Rasyiid_AFH
{
    internal class TeamMembers_1302223116
    {
        static String json = File.ReadAllText(@"./jurnal7_2_1302223116.json");
        static TeamMembers teamMembers = new TeamMembers();

        public static void readJson()
        {            
            teamMembers = JsonSerializer.Deserialize<TeamMembers>(json);
            Console.WriteLine("Team member list:");
            for (int i = 0; i < teamMembers.members.Count; i++)
            {
                Console.WriteLine("" + teamMembers.members.ElementAt(i).nim + " " + teamMembers.members.ElementAt(i).firstName + " " + teamMembers.members.ElementAt(i).lastName + " " + teamMembers.members.ElementAt(i).age + " " + teamMembers.members.ElementAt(i).gender);
            }            
        }
    }
}

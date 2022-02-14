using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16.Models
{
    public class League<T> 
    {
        private string Sport { get; set; }
        private List<T> Table { get; set; }

        public League(string sport)
        {
            Sport = sport;
            Table = new List<T>();
        }
        public string getSport()
        {
            return Sport;
        }

        public bool AddTeam(T team)
        {
            if ((team != null) && (!Table.Contains(team)))
            {
                Table.Add(team);
                Console.WriteLine($"Added {team} to the league table");
                return true;
            }
            Console.WriteLine("no team name specified, or team already in the list");
            return false;
        }

        public void PrintTable()
        {
            
            Console.WriteLine("Ranking table for the league " + getSport() + " League");
            int i = 0;
            foreach (T team in Table)
            {
                Console.WriteLine($"Team { i++}: {team}");
            }
        }

        /*// Create a generic class to implement a league table for a sport.
            // The class should allow teams to be added to the list, and store
            // a list of teams that belong to the league.
            //
            // Your class should have a method to print out the teams in order,
            // with the team at the top of the league printed first.
            //
            // Only teams of the same type should be added to any particular
            // instance of the league class - the program should fail to compile
            // if an attempt is made to add an incompatible team.
            */
    }
}

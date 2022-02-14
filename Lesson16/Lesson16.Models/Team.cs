using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16.Models
{
    public class Team
    {
        public int Played { get; set; }
        public int Won { get; set; }
        public int Lost { get; set; }
        public int Tied { get; set; }
        private string Name { get; set; }
        
        public Team(string name, int played, int won, int tied, int lost)
        {
            Name = name;
            Played = played;
            Won = won;
            Lost = lost;
            Tied = tied;
           
        }
        public string GetName()
        {
           return Name;
        }
     
        public int Ranking()
        {
           return (Won * 2) + Tied;
        }

        public override string ToString()
        {
            return $" {Name} : ({Ranking()})";
        }
    }
}

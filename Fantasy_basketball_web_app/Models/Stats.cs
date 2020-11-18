using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fantasy_basketball_web_app.Models
{
    public class Stats : IEquatable<Stats>
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Pts { get; set; }

        public bool Equals(Stats other)
        {
            if (other == null) return false;
            return (this.Name.Equals(other.Name));
        }
    }
}
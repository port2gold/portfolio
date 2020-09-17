using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class PortfolioModel 
    {

        /// <summary>
        /// Model of Portfolio
        /// with properties
        /// </summary>
        public int PortfolioId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<string> TechnologyUsed { get; set; }
        public string image { get; set; }
    }
}

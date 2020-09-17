using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class PortfolioRepositorycs : IPortfolioRepository
    {
        public readonly List<PortfolioModel> ctx;
        /// <summary>
        /// Portfolio Repository
        /// </summary>
        public PortfolioRepositorycs()
        {
            ctx = new List<PortfolioModel>
            {
                new PortfolioModel {PortfolioId =1,FirstName ="Abdulkabir", LastName ="Omotoso", TechnologyUsed = new List<string>{"C#", ".NET",".NET Core","ASP.NET","ASP.NET Core","HTML","CSS","JavaScript" } },
                new PortfolioModel {PortfolioId =2,FirstName ="Johnson", LastName ="Diesel", TechnologyUsed = new List<string>{"C#", ".NET",".NET Core","ASP.NET","ASP.NET Core","HTML","CSS","JavaScript" } }
            };
        }

        public PortfolioModel GetPortfolio(int id)
        {
            return ctx.FirstOrDefault(x => x.PortfolioId == id);
        }
        
    }
}

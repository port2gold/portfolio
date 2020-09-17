using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public interface IPortfolioRepository
    {
        /// <summary>
        /// Interface for Portfolio Repository
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PortfolioModel GetPortfolio(int id);
    }
}

using GoCompareShop.Models;
using BookManager.Services.Interfaces;

using Microsoft.Identity.Client;
using Microsoft.VisualBasic;
using NLog;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using GoCompareShop.Models;
using GoCompareShop.DAL;

namespace GoCompareShop.Services
{
    public class GoCompareShop : IGoCompareShop
    {
        IGoCompareShop _iGoCompareShop;
        private readonly ApplicationDBContext _dbContext;
        private static readonly NLog.Logger _logger = LogManager.GetCurrentClassLogger();
        public GoCompareShop()
        {

        }
        public GoCompareShop(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        
   
    }
}

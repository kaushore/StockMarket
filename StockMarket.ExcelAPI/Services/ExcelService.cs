using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.ExcelAPI.Repositories;

namespace StockMarket.ExcelAPI.Services
{
    public class ExcelService : IExcelService
    {
        private IExcelRepository repository;

        public ExcelService(IExcelRepository repository)
        {
            this.repository = repository;
        }
        
        public void ImportStock(string filePath)
        {
            repository.ImportStock(filePath);
        }

    }
}

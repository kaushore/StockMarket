using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.IO;
using StockMarket.ExcelAPI.Models;
using StockMarket.ExcelAPI.DBAccess;

namespace StockMarket.ExcelAPI.Repositories
{
    public class ExcelRepository : IExcelRepository
    {
        private ExcelDBContext context;

        public ExcelRepository(ExcelDBContext context)
        {
            this.context = context;
        }
        public void ImportStock(string filePath)
        {

            FileInfo file = new FileInfo(filePath);
            string fileName = file.Name;
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets["Sheet1"];
                int totalRows = workSheet.Dimension.Rows;

                List<StockPrice> stockPrices = new List<StockPrice>();

                for (int i = 2; i <= totalRows; i++)
                {
                    //string s = workSheet.Cells[i, 3].Value.ToString().Trim();
                    stockPrices.Add(new StockPrice
                    {
                        CompanyCode = workSheet.Cells[i, 1].Value.ToString().Trim(),
                        StockExchange = workSheet.Cells[i, 2].Value.ToString().Trim(),
                        CurrentPrice = double.Parse(workSheet.Cells[i, 3].Value.ToString().Trim()),
                        Date = DateTime.Parse(workSheet.Cells[i, 4].Value.ToString().Trim()),
                        Time = workSheet.Cells[i, 5].Value.ToString()
                    });
                }

                context.StockPrices.AddRange(stockPrices);
                context.SaveChanges();
            }

        }
    }
}

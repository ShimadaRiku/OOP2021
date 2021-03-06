using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3 {
    class SalesCalculator {
        private List<Sale> _sales;

        public SalesCalculator(string filePath) {
            _sales = ReadSales(filePath);
        }
        public static List<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }
        public Dictionary<string, int> GetPerStoreSales() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    //すでにコレクションに店舗が設定されている
                    dict[sale.ShopName] += sale.Amount;
                else
                    //コレクションへ店舗を登録
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }
        public Dictionary<string,int> GetPerCategorySales() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach(Sale sale in _sales) {
                if (dict.ContainsKey(sale.ProductCategory))
                    //すでにコレクションに店舗が設定されている
                    dict[sale.ProductCategory] += sale.Amount;
                else
                    //コレクションへ店舗を登録
                    dict[sale.ProductCategory] = sale.Amount;
            }
            return dict;
        }
    }
}


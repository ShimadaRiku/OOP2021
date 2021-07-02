using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var books = Books.GetBooks();

            Console.WriteLine("本の平均価格は" + books.Average(x => x.Price).ToString("#,0")+ "円");
            Console.WriteLine("本の総ページ数は" + books.Sum(s => s.Pages) + "ページ");
            Console.WriteLine("一番価格の高い本は" + books.Max(x => x.Price) + "円");
            Console.WriteLine("一番価格の安い本は" + books.Min(x => x.Price) + "円");
            //何冊あるか？
            Console.WriteLine("全部で" + books.Count() + "冊");

            //500円以上の本は何冊か？
            Console.WriteLine("500円以上の本は" + books.Count(x => x.Price >= 500) + "冊");
            //本のタイトルに「物語」が含まれている冊数
            Console.WriteLine("物語シリーズは全部で" + books.Count(x => x.Title.Contains ("物語") ).ToString() + "冊");

            //本のタイトルに「物語」が含まれている本の一覧
            var bookDate = books.Where(x => x.Title.Contains("物語"));
            foreach (var book in bookDate) {
                Console.WriteLine(book.Title);
            }
            //高額書籍ベスト３
            var bookprice = books.OrderByDescending(x => x.Price).Take(2);
            foreach (var book in bookprice) {
                Console.WriteLine($"タイトル」：{book.Title} 値段：{book.Price}円");
            }
            Console.WriteLine();

           // var titles = books.Select(x => x.Title)
        }
    }
}

using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);

        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> sales = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Student student = new Student{
                    Subject = items[0],
                    Name = items[1],
                    Score = int.Parse(items[2])
                };
                sales.Add(student); 
            }
            return sales;
        }
        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Student student in _score) {
                if (dict.ContainsKey(student.Name))
                    //すでにコレクションに店舗が設定されている
                    dict[student.Name] += student.Score;
                else
                    //コレクションへ店舗を登録
                    dict[student.Name] = student.Score;
            }
            return dict;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise3 {
    public partial class textBox : Form {
        public textBox() {
            InitializeComponent();
        }
        private void From1_Load(object sender, EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";

            //問題5.4
            inputStrData.Text = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
        }

        private void Button5_3_1_Click(object sender, EventArgs e) {
            

            Spacecount.Text = inputStrText.Text.Count(c => c == ' ').ToString();


        }

        private void Button5_3_2_Click(object sender, EventArgs e) {
            textBoxWordChange.Text = inputStrText.Text.Replace("big", "small");

        }

        private void Button5_3_3_Click(object sender, EventArgs e) {
            var word = inputStrText.Text.Split(' ');
            WordCount.Text = word.Length.ToString();

        }

        private void Button5_3_4_Click(object sender, EventArgs e) {
            var items = inputStrText.Text.Split(' ').Where(c => c.Length <= 4);
            foreach (var item in items) {
                four.Text += item + ' ';
            }

        }

        private void Button5_3_5_Click(object sender, EventArgs e) {
            var array = inputStrText.Text.Split(' ').ToArray();
            if(array.Length > 0) {
                var sb = new StringBuilder(array[0]);
                foreach(var word in array.Skip(1)) {
                    sb.Append(' ');
                    sb.Append(word);

                }
                copy.Text = sb.ToString();
            /*string[] items = inputStrText.Text.Split(' ');
            foreach(var item in items) {
                copy.Text += item + ' ';*/
            }
        }

        private void Button5_4_Click(object sender, EventArgs e) {
            //"Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886"
            foreach (var pair in inputStrData.Text.Split(';')) {
                var array = pair.Split('=');
                outStrDate.Text += ToJapanese(array[0] + ";" + array[1] + "\n");
            }
        }

        private string ToJapanese(string key) {
            switch (key) {

                case "Novelist":
                    return "作家　";

                case "BestWork":
                    return "代表作　";

                case "Born":
                    return "誕生年　";
            }
            throw new AggregateException("引数が正しくありません");
        }
    }
}

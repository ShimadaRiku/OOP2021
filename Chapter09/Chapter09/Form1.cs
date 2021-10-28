using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter09{
    public partial class ofdOpenFile : Form{
        public ofdOpenFile(){
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
           
                int count = 0;
                using (var reader = new StreamReader(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis")){
                    while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            if (line.Contains(tbKeyWord.Text))
                                count++;
                        }
                tbOutput.Text = "キーワード「" + tbKeyWord.Text + "」が含まれている行は、"
                    + count.ToString() + "行です。";
            }
        }

  

        private void tbReadAllLines_Click(object sender, EventArgs e){
            if(ofdOpenFile.ShowDialog() = DialogResult.OK){
            int count = 0;
            var lines = FileDialog.ReadLines(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"));
            foreach(var line in lines){
                count++;
            }
            tbOutput.Text = "キーワード「" + "」が含まれている行は、" + count.ToString() + "行です。";
        }
    }
}

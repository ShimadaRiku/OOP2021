using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    public class CarReport {
        internal static object MakeGroup;

        public DateTime Date { get; set; }
        public string Auther { get; set; }
        public Makergroup Maker { get; set; }
        public string CarName { get; set; }
        public string Report { get; set; }
        public Image Picture { get; set; }

        public CarReport(DateTime date, string auther,MakerGroup maker,string carname,string report,Image picture) {
                //this.Date = date;
                //this.Auther = auther;
    }

        internal class MakerGroup {
        }
    }

    public enum MakerGroup {
        トヨタ,
        日産,
        ホンダ,
        スバル,
        外国車,
        その他,

    }
    
}


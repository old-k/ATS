using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.datamodel {

    public class SpreadItem {
        public double qty;
        public double bid;
        public double ask;
    }

    public class TimeInterval {
        List<SpreadItem> items = new List<SpreadItem>();
        public string name; // name like Hr, Q1, Q2...HH1, HH2 - or introduce enum? 
    }

    public class HourData {
        List<SpreadItem> items = new List<SpreadItem>();
        DateTime date;
        SpreadItem lastItem;    // Statistic
        SpreadItem wavg;        // Statistic
    }
}

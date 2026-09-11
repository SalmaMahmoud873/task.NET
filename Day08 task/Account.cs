using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
    struct Account
    {
        private int AccID;
        private string ACCHolder;
        private double Balance;

        public int ACCIdProperty
        {
            get { return AccID; }
            set { AccID = value; }
        }
        public string ACCHolderProperty
        {
            get { return ACCHolder; }
            set {  ACCHolder = value; }
        }
        public double BalanceProperty
        {
            get { return Balance;  }
            set {  Balance = value; }
        }
    }
}

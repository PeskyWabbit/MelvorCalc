using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelvorCalc
{
    public class Crafting_Result
    {
        public List<double> batch_times;
        public List<int> batch_prices;
        public List<int> batch_xp;
        public List<int> batch_outputs;

        public Crafting_Result() 
        {
            this.batch_outputs = new List<int>();
            this.batch_times = new List<double>();
            this.batch_prices = new List<int>();
            this.batch_xp = new List<int>();
        }    

        public Crafting_Result(List<double> times, List<int> prices, List<int> xp, List<int> outputs)
        {
            this.batch_times = times;
            this.batch_prices = prices;
            this.batch_xp = xp;
            this.batch_outputs = outputs;
        }


    }
}

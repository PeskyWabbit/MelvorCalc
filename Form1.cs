using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelvorCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string format_number(double number)
        {
            string numstr = "";
            if (number > 1000000000)
            {
                numstr = (number / 1000000000).ToString();
                if (numstr.Length > 5)
                {
                    numstr = numstr.Substring(0, 5);
                }
                numstr += " B";
            }
            else if (number > 1000000)
            {
                numstr = (number / 1000000).ToString();
                if (numstr.Length > 5)
                {
                    numstr = numstr.Substring(0, 5);
                }
                numstr += " M";
            }
            else if (number > 1000)
            {
                numstr = (number / 1000).ToString();
                if (numstr.Length > 5)
                {
                    numstr = numstr.Substring(0, 5);
                }
                numstr += " K";
            }
            else
            {
                numstr = number.ToString();
            }
            return numstr;
        }

        public string format_time(double seconds)
        {
            string time_str = "";
            if (seconds > 86400)
            {
                time_str = (seconds / 86400).ToString();
                if (time_str.Length > 5)
                {
                    time_str = time_str.Substring(0,5);
                }
                time_str += " Days";
            }
            else if (seconds > 3600)
            {
                time_str = (seconds / 3600).ToString();
                if (time_str.Length > 5)
                {
                    time_str = time_str.Substring(0, 5);
                }
                time_str += " Hours";
            }
            else if (seconds > 60)
            {
                time_str = (seconds / 60).ToString();
                if (time_str.Length > 5)
                {
                    time_str = time_str.Substring(0, 5);
                }
                time_str += " Minutes";
            }
            else
            {
                time_str = seconds.ToString() + " Seconds";
            }
            return time_str;
        }

        public void output_crafting_result(Crafting_Result result)
        {
            double avg_time = result.batch_times.Average();
            double avg_production = result.batch_outputs.Average();
            double avg_price = result.batch_prices.Average();
            double avg_xp = result.batch_xp.Average();
            string output = "";

            if (cb_show_production_list.Checked)
            {
                output += "All simulation production amounts:\n" + string.Join(", ", result.batch_outputs) + "\n\n";
            }

            if (cb_show_price_list.Checked)
            {
                output += "All simulation sale prices:\n" + string.Join(", ", result.batch_prices) + "\n\n";
            }

            if (cb_show_xp_list.Checked)
            {
                output += "All simulation xp amounts:\n" + string.Join(", ", result.batch_xp) + "\n\n";
            }

            if (cb_show_time_list.Checked)
            {
                output += "All simulation completion times in seconds:\n" + string.Join(", ", result.batch_times) + "\n\n";
            }

            output += "Results:\nAverage Production: " + format_number(avg_production) + "\n";
            if (cb_minmax_production.Checked)
            {
                output += "\tMin: " + format_number(result.batch_outputs.Min()) + "\n";
                output += "\tMax: " + format_number(result.batch_outputs.Max()) + "\n";
            }
            if (cb_hourly_items.Checked && avg_time > 0)
            {
                output += "\titems/hour: " + format_number(avg_production / (avg_time / 3600)) + "\n";
            }

            if (avg_price > 0)
            {
                output += "\nAverage Sale Price: " + format_number(avg_price) + "\n";
                if (cb_minmax_price.Checked)
                {
                    output += "\tMin: " + format_number(result.batch_prices.Min()) + "\n";
                    output += "\tMax: " + format_number(result.batch_prices.Max()) + "\n";
                }
                if(cb_hourly_gp.Checked && avg_time > 0)
                {
                    output += "\tGP/hour: " + format_number(avg_price / (avg_time / 3600)) + "\n";
                }
            }
            
            if (avg_xp > 0)
            {
                output += "\nAverage XP: " + format_number(avg_xp) + "\n";
                if (cb_minmax_xp.Checked)
                {
                    output += "\tMin: " + format_number(result.batch_xp.Min()) + "\n";
                    output += "\tMax: " + format_number(result.batch_xp.Max()) + "\n";
                }
                if (cb_hourly_xp.Checked && avg_time > 0)
                {
                    output += "\tXP/hour: " + format_number(avg_xp / (avg_time / 3600)) + "\n";
                }
            }
            
            if (avg_time > 0)
            {
                output += "\nAverage Completion Time: " + format_time(avg_time) + "\n";
                if (cb_minmax_time.Checked)
                {
                    output += "\tMin: " + format_time(result.batch_times.Min()) + "\n";
                    output += "\tMax: " + format_time(result.batch_times.Max()) + "\n";
                }
            }
            

            tb_output.Text = output;
            return;
        }

        public void calculate_xp()
        {
            tb_output.Clear();
            double cur_xp;
            int target_lvl;
            int xp_per;
            double sec_per;

            try
            {
                cur_xp = Double.Parse(tb_current_xp.Text);
                target_lvl = Int32.Parse(tb_target_level.Text);
                xp_per = Int32.Parse(tb_xp_action.Text);
                sec_per = Double.Parse(tb_time_action.Text);
                if (target_lvl > 120 || target_lvl < 2)
                {
                    tb_output.Text = "Invalid target level. Must be between 2 and 120.";
                    return;
                }
            }
            catch
            {
                tb_output.Text = "One of your values is invalid. Check your inputs and try again.";
                return;
            }

            double target_xp = level_to_xp(target_lvl);
            if (target_xp <= cur_xp)
            {
                tb_output.Text = "You are already past your target level.";
                return;
            }

            double xp_rem = target_xp - cur_xp;
            double actions_rem = xp_rem / xp_per;
            double sec_rem = actions_rem * sec_per;

            string xp_rem_str = format_number(xp_rem);
            string time_rem_str = format_time(sec_rem);
            string actions_rem_str = format_number(actions_rem);
            string target_xp_str = format_number(target_xp);

            string output = "Results:\n";
            output += "\nTarget XP: " + target_xp_str + "\n";
            output += "\nRemaining XP to target: " + xp_rem_str + "\n";
            output += "\nRemaining actions to reach target level: " + actions_rem_str + "\n";
            output += "\nRemaining time to target level: " + time_rem_str + "\n";
            tb_output.Text = output;
            return;
        }

        public void simulate_crafting()
        {
            tb_output.Clear();
            var random_gen = new Random();
            int num_crafts;
            int recycle_chance;
            int double_chance;
            int base_output;
            float craft_time;
            int item_price;
            int xp_per;
            int num_simulations;
            try
            {
                num_crafts = Int32.Parse(tb_num_crafts.Text);
                recycle_chance = string.IsNullOrEmpty(tb_recycle_chance.Text) ? 0 : Int32.Parse(tb_recycle_chance.Text);
                double_chance = string.IsNullOrEmpty(tb_double_chance.Text) ? 0 : Int32.Parse(tb_double_chance.Text);
                base_output = string.IsNullOrEmpty(tb_base_output.Text) ? 1 : Int32.Parse(tb_base_output.Text);
                craft_time = string.IsNullOrEmpty(tb_time_craft.Text) ? 0 : float.Parse(tb_time_craft.Text);
                item_price = string.IsNullOrEmpty(tb_price.Text) ? 0 : Int32.Parse(tb_price.Text);
                xp_per = string.IsNullOrEmpty(tb_xp_craft.Text) ? 0 : Int32.Parse(tb_xp_craft.Text);
                num_simulations = string.IsNullOrEmpty(tb_num_sims.Text) ? 30 : Int32.Parse(tb_num_sims.Text);
                if (double_chance > 100 || recycle_chance > 80)
                {
                    tb_output.Text = "One of your % chance values is out of range.\nChance to preserve: Max 80%\nChance to double: Max 100%";
                    return;
                }
            }
            catch
            {
                tb_output.Text = "One of your input values is invalid. Please check them and try again...";
                return;
            }

            float seconds_spent = 0;
            int total_made = 0;
            int total_xp = 0;
            int i_num_crafts = 0;
            List<int> batch_outputs = new List<int>();
            List<double> batch_times = new List<double>();
            List<int> batch_prices = new List<int>();
            List<int> batch_xp = new List<int>();

            for (int i = 0; i < num_simulations; i++)
            {
                i_num_crafts = num_crafts;
                while (i_num_crafts > 0)
                {
                    int recycle_roll = random_gen.Next(1, 100);
                    int double_roll = random_gen.Next(1, 100);

                    total_made += base_output;

                    if (double_roll <= double_chance)
                    {
                        total_made += base_output;
                    }

                    if (recycle_roll > recycle_chance)
                    {
                        i_num_crafts -= 1;
                    }

                    seconds_spent += craft_time;
                    total_xp += xp_per;
                }

                batch_outputs.Add(total_made);
                batch_times.Add(seconds_spent);
                batch_xp.Add(total_xp);
                batch_prices.Add(item_price * total_made);
                total_made = 0;
                seconds_spent = 0;
                total_xp = 0;
            }

            Console.WriteLine(string.Join(", ", batch_times));
            Crafting_Result result = new Crafting_Result(batch_times, batch_prices, batch_xp, batch_outputs);
            output_crafting_result(result);
        }

        public double level_to_xp(int l)
        {
            double l_7 = (double)l / 7;
            double one_7 = (double)1 / 7;
            double numerator = Math.Pow(2, l_7) - Math.Pow(2, one_7);
            double denominator = Math.Pow(2, one_7) - 1;
            double xp = (Math.Pow(l, 2) - l + (600 * (numerator / denominator))) * 0.125;
            Console.WriteLine(xp.ToString());
            return xp;
        }

        private void btn_simulate_Click(object sender, EventArgs e)
        {
            Console.WriteLine(tabControl.SelectedTab);
            Console.WriteLine(tabControl.TabPages["xp_calc"]);
            Console.WriteLine(tabControl.SelectedTab == tabControl.TabPages["xp_calc"]);
            if(tabControl.SelectedTab == tabControl.TabPages["production_sim"])
            {
                simulate_crafting();
            }
            else if (tabControl.SelectedTab == tabControl.TabPages["xp_calc"])
            {
                Console.WriteLine("calculating level");
                calculate_xp();
            }
        }
    }
}

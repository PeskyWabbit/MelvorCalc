namespace MelvorCalc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_simulate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_output = new System.Windows.Forms.RichTextBox();
            this.xp_calc = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_current_xp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_target_level = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_xp_action = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_time_action = new System.Windows.Forms.TextBox();
            this.production_sim = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_num_crafts = new System.Windows.Forms.TextBox();
            this.tb_recycle_chance = new System.Windows.Forms.TextBox();
            this.tb_double_chance = new System.Windows.Forms.TextBox();
            this.tb_time_craft = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_xp_craft = new System.Windows.Forms.TextBox();
            this.tb_num_sims = new System.Windows.Forms.TextBox();
            this.tb_base_output = new System.Windows.Forms.TextBox();
            this.cb_show_production_list = new System.Windows.Forms.CheckBox();
            this.cb_show_price_list = new System.Windows.Forms.CheckBox();
            this.cb_show_xp_list = new System.Windows.Forms.CheckBox();
            this.cb_show_time_list = new System.Windows.Forms.CheckBox();
            this.cb_minmax_price = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_minmax_production = new System.Windows.Forms.CheckBox();
            this.cb_minmax_xp = new System.Windows.Forms.CheckBox();
            this.cb_minmax_time = new System.Windows.Forms.CheckBox();
            this.cb_hourly_gp = new System.Windows.Forms.CheckBox();
            this.cb_hourly_xp = new System.Windows.Forms.CheckBox();
            this.cb_hourly_items = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.xp_calc.SuspendLayout();
            this.production_sim.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_simulate
            // 
            this.btn_simulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_simulate.Location = new System.Drawing.Point(621, 66);
            this.btn_simulate.Name = "btn_simulate";
            this.btn_simulate.Size = new System.Drawing.Size(180, 48);
            this.btn_simulate.TabIndex = 2;
            this.btn_simulate.Text = "Simulate";
            this.btn_simulate.UseVisualStyleBackColor = true;
            this.btn_simulate.Click += new System.EventHandler(this.btn_simulate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(661, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "results printed below";
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(514, 151);
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(396, 340);
            this.tb_output.TabIndex = 5;
            this.tb_output.Text = "";
            // 
            // xp_calc
            // 
            this.xp_calc.Controls.Add(this.tb_time_action);
            this.xp_calc.Controls.Add(this.tb_xp_action);
            this.xp_calc.Controls.Add(this.tb_target_level);
            this.xp_calc.Controls.Add(this.tb_current_xp);
            this.xp_calc.Controls.Add(this.label14);
            this.xp_calc.Controls.Add(this.label13);
            this.xp_calc.Controls.Add(this.label12);
            this.xp_calc.Controls.Add(this.label11);
            this.xp_calc.Location = new System.Drawing.Point(4, 22);
            this.xp_calc.Name = "xp_calc";
            this.xp_calc.Padding = new System.Windows.Forms.Padding(3);
            this.xp_calc.Size = new System.Drawing.Size(488, 453);
            this.xp_calc.TabIndex = 1;
            this.xp_calc.Text = "Level Calc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Current XP";
            // 
            // tb_current_xp
            // 
            this.tb_current_xp.Location = new System.Drawing.Point(10, 24);
            this.tb_current_xp.Name = "tb_current_xp";
            this.tb_current_xp.Size = new System.Drawing.Size(100, 20);
            this.tb_current_xp.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Target level (2 - 120)";
            // 
            // tb_target_level
            // 
            this.tb_target_level.Location = new System.Drawing.Point(10, 69);
            this.tb_target_level.Name = "tb_target_level";
            this.tb_target_level.Size = new System.Drawing.Size(100, 20);
            this.tb_target_level.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "XP per action";
            // 
            // tb_xp_action
            // 
            this.tb_xp_action.Location = new System.Drawing.Point(10, 117);
            this.tb_xp_action.Name = "tb_xp_action";
            this.tb_xp_action.Size = new System.Drawing.Size(100, 20);
            this.tb_xp_action.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Seconds to complete action";
            // 
            // tb_time_action
            // 
            this.tb_time_action.Location = new System.Drawing.Point(10, 167);
            this.tb_time_action.Name = "tb_time_action";
            this.tb_time_action.Size = new System.Drawing.Size(100, 20);
            this.tb_time_action.TabIndex = 7;
            // 
            // production_sim
            // 
            this.production_sim.BackColor = System.Drawing.Color.Transparent;
            this.production_sim.Controls.Add(this.cb_hourly_items);
            this.production_sim.Controls.Add(this.cb_hourly_xp);
            this.production_sim.Controls.Add(this.cb_hourly_gp);
            this.production_sim.Controls.Add(this.cb_minmax_time);
            this.production_sim.Controls.Add(this.cb_minmax_xp);
            this.production_sim.Controls.Add(this.cb_minmax_production);
            this.production_sim.Controls.Add(this.label10);
            this.production_sim.Controls.Add(this.cb_minmax_price);
            this.production_sim.Controls.Add(this.cb_show_time_list);
            this.production_sim.Controls.Add(this.cb_show_xp_list);
            this.production_sim.Controls.Add(this.cb_show_price_list);
            this.production_sim.Controls.Add(this.cb_show_production_list);
            this.production_sim.Controls.Add(this.tb_base_output);
            this.production_sim.Controls.Add(this.tb_num_sims);
            this.production_sim.Controls.Add(this.tb_xp_craft);
            this.production_sim.Controls.Add(this.tb_price);
            this.production_sim.Controls.Add(this.tb_time_craft);
            this.production_sim.Controls.Add(this.tb_double_chance);
            this.production_sim.Controls.Add(this.tb_recycle_chance);
            this.production_sim.Controls.Add(this.tb_num_crafts);
            this.production_sim.Controls.Add(this.label7);
            this.production_sim.Controls.Add(this.label6);
            this.production_sim.Controls.Add(this.label5);
            this.production_sim.Controls.Add(this.label4);
            this.production_sim.Controls.Add(this.label3);
            this.production_sim.Controls.Add(this.label2);
            this.production_sim.Controls.Add(this.label1);
            this.production_sim.Controls.Add(this.label9);
            this.production_sim.Location = new System.Drawing.Point(4, 22);
            this.production_sim.Name = "production_sim";
            this.production_sim.Padding = new System.Windows.Forms.Padding(3);
            this.production_sim.Size = new System.Drawing.Size(488, 453);
            this.production_sim.TabIndex = 0;
            this.production_sim.Text = "Production Simulator";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 127);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.label9.Size = new System.Drawing.Size(100, 63);
            this.label9.TabIndex = 14;
            this.label9.Text = "Base output of craft";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, -11);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.label1.Size = new System.Drawing.Size(244, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of crafts able to perform, ignoring bonuses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.label2.Size = new System.Drawing.Size(191, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "% chance to preserve recipe resources";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.label3.Size = new System.Drawing.Size(226, 63);
            this.label3.TabIndex = 2;
            this.label3.Text = "% chance to double amount of produced items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 173);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.label4.Size = new System.Drawing.Size(210, 63);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time each craft takes in seconds (optional)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 219);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.label5.Size = new System.Drawing.Size(121, 63);
            this.label5.TabIndex = 4;
            this.label5.Text = "Item sale price (optional)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 265);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.label6.Size = new System.Drawing.Size(148, 63);
            this.label6.TabIndex = 5;
            this.label6.Text = "XP granted per craft (optional)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 311);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.label7.Size = new System.Drawing.Size(186, 63);
            this.label7.TabIndex = 6;
            this.label7.Text = "Number of simulations to run (optional)";
            // 
            // tb_num_crafts
            // 
            this.tb_num_crafts.Location = new System.Drawing.Point(9, 32);
            this.tb_num_crafts.Name = "tb_num_crafts";
            this.tb_num_crafts.Size = new System.Drawing.Size(92, 20);
            this.tb_num_crafts.TabIndex = 1;
            // 
            // tb_recycle_chance
            // 
            this.tb_recycle_chance.Location = new System.Drawing.Point(9, 78);
            this.tb_recycle_chance.Name = "tb_recycle_chance";
            this.tb_recycle_chance.Size = new System.Drawing.Size(92, 20);
            this.tb_recycle_chance.TabIndex = 2;
            // 
            // tb_double_chance
            // 
            this.tb_double_chance.Location = new System.Drawing.Point(9, 124);
            this.tb_double_chance.Name = "tb_double_chance";
            this.tb_double_chance.Size = new System.Drawing.Size(92, 20);
            this.tb_double_chance.TabIndex = 3;
            // 
            // tb_time_craft
            // 
            this.tb_time_craft.Location = new System.Drawing.Point(9, 216);
            this.tb_time_craft.Name = "tb_time_craft";
            this.tb_time_craft.Size = new System.Drawing.Size(92, 20);
            this.tb_time_craft.TabIndex = 5;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(9, 262);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(92, 20);
            this.tb_price.TabIndex = 6;
            // 
            // tb_xp_craft
            // 
            this.tb_xp_craft.Location = new System.Drawing.Point(9, 308);
            this.tb_xp_craft.Name = "tb_xp_craft";
            this.tb_xp_craft.Size = new System.Drawing.Size(92, 20);
            this.tb_xp_craft.TabIndex = 7;
            // 
            // tb_num_sims
            // 
            this.tb_num_sims.Location = new System.Drawing.Point(9, 354);
            this.tb_num_sims.Name = "tb_num_sims";
            this.tb_num_sims.Size = new System.Drawing.Size(92, 20);
            this.tb_num_sims.TabIndex = 8;
            // 
            // tb_base_output
            // 
            this.tb_base_output.Location = new System.Drawing.Point(9, 170);
            this.tb_base_output.Name = "tb_base_output";
            this.tb_base_output.Size = new System.Drawing.Size(92, 20);
            this.tb_base_output.TabIndex = 4;
            // 
            // cb_show_production_list
            // 
            this.cb_show_production_list.AutoSize = true;
            this.cb_show_production_list.Location = new System.Drawing.Point(272, 48);
            this.cb_show_production_list.Name = "cb_show_production_list";
            this.cb_show_production_list.Size = new System.Drawing.Size(194, 17);
            this.cb_show_production_list.TabIndex = 9;
            this.cb_show_production_list.Text = "Production amount of all simulations";
            this.cb_show_production_list.UseVisualStyleBackColor = true;
            // 
            // cb_show_price_list
            // 
            this.cb_show_price_list.AutoSize = true;
            this.cb_show_price_list.Location = new System.Drawing.Point(272, 71);
            this.cb_show_price_list.Name = "cb_show_price_list";
            this.cb_show_price_list.Size = new System.Drawing.Size(152, 17);
            this.cb_show_price_list.TabIndex = 10;
            this.cb_show_price_list.Text = "Sale price of all simulations";
            this.cb_show_price_list.UseVisualStyleBackColor = true;
            // 
            // cb_show_xp_list
            // 
            this.cb_show_xp_list.AutoSize = true;
            this.cb_show_xp_list.Location = new System.Drawing.Point(272, 94);
            this.cb_show_xp_list.Name = "cb_show_xp_list";
            this.cb_show_xp_list.Size = new System.Drawing.Size(119, 17);
            this.cb_show_xp_list.TabIndex = 11;
            this.cb_show_xp_list.Text = "XP of all simulations";
            this.cb_show_xp_list.UseVisualStyleBackColor = true;
            // 
            // cb_show_time_list
            // 
            this.cb_show_time_list.AutoSize = true;
            this.cb_show_time_list.Location = new System.Drawing.Point(272, 117);
            this.cb_show_time_list.Name = "cb_show_time_list";
            this.cb_show_time_list.Size = new System.Drawing.Size(179, 17);
            this.cb_show_time_list.TabIndex = 12;
            this.cb_show_time_list.Text = "Completion time of all simulations";
            this.cb_show_time_list.UseVisualStyleBackColor = true;
            // 
            // cb_minmax_price
            // 
            this.cb_minmax_price.AutoSize = true;
            this.cb_minmax_price.Location = new System.Drawing.Point(272, 163);
            this.cb_minmax_price.Name = "cb_minmax_price";
            this.cb_minmax_price.Size = new System.Drawing.Size(170, 17);
            this.cb_minmax_price.TabIndex = 14;
            this.cb_minmax_price.Text = "Min/Max simulation sale prices";
            this.cb_minmax_price.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.Location = new System.Drawing.Point(280, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Additional outputs to include";
            // 
            // cb_minmax_production
            // 
            this.cb_minmax_production.AutoSize = true;
            this.cb_minmax_production.Location = new System.Drawing.Point(272, 140);
            this.cb_minmax_production.Name = "cb_minmax_production";
            this.cb_minmax_production.Size = new System.Drawing.Size(213, 17);
            this.cb_minmax_production.TabIndex = 13;
            this.cb_minmax_production.Text = "Min/Max simulation production amounts";
            this.cb_minmax_production.UseVisualStyleBackColor = true;
            // 
            // cb_minmax_xp
            // 
            this.cb_minmax_xp.AutoSize = true;
            this.cb_minmax_xp.Location = new System.Drawing.Point(272, 186);
            this.cb_minmax_xp.Name = "cb_minmax_xp";
            this.cb_minmax_xp.Size = new System.Drawing.Size(174, 17);
            this.cb_minmax_xp.TabIndex = 15;
            this.cb_minmax_xp.Text = "Min/Max simulation xp amounts";
            this.cb_minmax_xp.UseVisualStyleBackColor = true;
            // 
            // cb_minmax_time
            // 
            this.cb_minmax_time.AutoSize = true;
            this.cb_minmax_time.Location = new System.Drawing.Point(272, 209);
            this.cb_minmax_time.Name = "cb_minmax_time";
            this.cb_minmax_time.Size = new System.Drawing.Size(198, 17);
            this.cb_minmax_time.TabIndex = 16;
            this.cb_minmax_time.Text = "Min/Max simulation completion times";
            this.cb_minmax_time.UseVisualStyleBackColor = true;
            // 
            // cb_hourly_gp
            // 
            this.cb_hourly_gp.AutoSize = true;
            this.cb_hourly_gp.Location = new System.Drawing.Point(272, 232);
            this.cb_hourly_gp.Name = "cb_hourly_gp";
            this.cb_hourly_gp.Size = new System.Drawing.Size(83, 17);
            this.cb_hourly_gp.TabIndex = 23;
            this.cb_hourly_gp.Text = "GP per hour";
            this.cb_hourly_gp.UseVisualStyleBackColor = true;
            // 
            // cb_hourly_xp
            // 
            this.cb_hourly_xp.AutoSize = true;
            this.cb_hourly_xp.Location = new System.Drawing.Point(272, 255);
            this.cb_hourly_xp.Name = "cb_hourly_xp";
            this.cb_hourly_xp.Size = new System.Drawing.Size(82, 17);
            this.cb_hourly_xp.TabIndex = 24;
            this.cb_hourly_xp.Text = "XP per hour";
            this.cb_hourly_xp.UseVisualStyleBackColor = true;
            // 
            // cb_hourly_items
            // 
            this.cb_hourly_items.AutoSize = true;
            this.cb_hourly_items.Location = new System.Drawing.Point(272, 278);
            this.cb_hourly_items.Name = "cb_hourly_items";
            this.cb_hourly_items.Size = new System.Drawing.Size(141, 17);
            this.cb_hourly_items.TabIndex = 25;
            this.cb_hourly_items.Text = "Items produced per hour";
            this.cb_hourly_items.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.production_sim);
            this.tabControl.Controls.Add(this.xp_calc);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(496, 479);
            this.tabControl.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(923, 507);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_simulate);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Melvor Calculator";
            this.xp_calc.ResumeLayout(false);
            this.xp_calc.PerformLayout();
            this.production_sim.ResumeLayout(false);
            this.production_sim.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_simulate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox tb_output;
        private System.Windows.Forms.TabPage xp_calc;
        private System.Windows.Forms.TextBox tb_time_action;
        private System.Windows.Forms.TextBox tb_xp_action;
        private System.Windows.Forms.TextBox tb_target_level;
        private System.Windows.Forms.TextBox tb_current_xp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage production_sim;
        private System.Windows.Forms.CheckBox cb_hourly_items;
        private System.Windows.Forms.CheckBox cb_hourly_xp;
        private System.Windows.Forms.CheckBox cb_hourly_gp;
        private System.Windows.Forms.CheckBox cb_minmax_time;
        private System.Windows.Forms.CheckBox cb_minmax_xp;
        private System.Windows.Forms.CheckBox cb_minmax_production;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cb_minmax_price;
        private System.Windows.Forms.CheckBox cb_show_time_list;
        private System.Windows.Forms.CheckBox cb_show_xp_list;
        private System.Windows.Forms.CheckBox cb_show_price_list;
        private System.Windows.Forms.CheckBox cb_show_production_list;
        private System.Windows.Forms.TextBox tb_base_output;
        private System.Windows.Forms.TextBox tb_num_sims;
        private System.Windows.Forms.TextBox tb_xp_craft;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_time_craft;
        private System.Windows.Forms.TextBox tb_double_chance;
        private System.Windows.Forms.TextBox tb_recycle_chance;
        private System.Windows.Forms.TextBox tb_num_crafts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl;
    }
}


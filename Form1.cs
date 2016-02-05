using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHive
{
    public partial class Form1 : Form
    {
        private Queen queen;

        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] {"Nectar collector", "Honey manufacturing"});
            workers[1] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[2] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });

            queen = new Queen(workers);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


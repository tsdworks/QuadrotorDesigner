using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuadrotorDesigner.Studio.Properties;

namespace QuadrotorDesigner.Studio.UserInterface
{
    public partial class FromLoad : Form
    {
        public FromLoad()
        {
            InitializeComponent();
        }

        private void FromLoad_Load(object sender, EventArgs e)
        {
            DisplayStartTimer();
        }

        private int CounterLoader = 0;

        private void timerLoader_Tick(object sender, EventArgs e)
        {
            CounterLoader++;

            if (CounterLoader == int.Parse(Resources.LoadSplashDelay))
            {
                timerLoader.Enabled = false;

                // hide load form
                Hide();

                // show workspace
                (new FormMain()).Show();
            }
        }
    }
}

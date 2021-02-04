using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadrotorDesigner.Studio.UserInterface
{
    public partial class FromLoad : Form
    {
        private void DisplaySetLabelLoadState(string textToSet)
        {
            labelLoadState.Invoke(new EventHandler(delegate
            {
                labelLoadState.Text = textToSet;
            }));
        }
        
        private void DisplayStartTimer()
        {
            timerLoader.Enabled = true;
        }
    }
}

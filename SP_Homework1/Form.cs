using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_Homework1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            listView.Enabled = false;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Process[] procList = Process.GetProcesses();
            listView.Enabled = true;
            foreach (Process proc in procList)
            {
                listView.Items.Add(
                    new ListViewItem(
                        new string[] {
                            $"{proc.ProcessName}", $"{proc.Id}", $"{proc.HandleCount}"
                        }));
            }
        }
    }
}

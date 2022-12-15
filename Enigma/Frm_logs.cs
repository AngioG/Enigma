using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    public partial class Frm_logs : Form
    {
        public Frm_logs()
        {
            InitializeComponent();
        }

        public void WriteSingleLog(string log)
        {
            list_logs.Items.Add(log);

            int visibleItems = list_logs.ClientSize.Height / list_logs.ItemHeight;
            list_logs.TopIndex = Math.Max(list_logs.Items.Count - visibleItems + 1, 0);
        }
        public void WriteLogs(IEnumerable<string> logs)
        {
            foreach (var log in logs)
                list_logs.Items.Add(log);
            int visibleItems = list_logs.ClientSize.Height / list_logs.ItemHeight;
            list_logs.TopIndex = Math.Max(list_logs.Items.Count - visibleItems + 1, 0);

        }

        public void DeleteLogs()
        {
            list_logs.Items.Clear();
        }

        private void Frm_logs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Enigma.ResetForm3();
        }
    }
}

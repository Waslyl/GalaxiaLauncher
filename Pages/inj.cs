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

namespace UIKitTutorials.Pages
{
    public partial class inj : Form
    {
        static Process FortniteClient = new Process();
        static String idkkk = AppDomain.CurrentDomain.BaseDirectory;
        public inj()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process edit = new Process();
            edit.StartInfo.FileName = $@"{idkkk}\\inj\\injector.exe";
            edit.StartInfo.Arguments = $@"-p {FortniteClient.Id} -i edit.dll ";
            edit.StartInfo.CreateNoWindow = true; edit.StartInfo.RedirectStandardOutput = false;
            edit.StartInfo.UseShellExecute = false;
            edit.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            edit.Start(); //inject edit on release
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process crash = new Process();
            crash.StartInfo.FileName = $@"{idkkk}\\inj\\injector.exe";
            crash.StartInfo.Arguments = $@"-p {FortniteClient.Id} -i anticrash.dll ";
            crash.StartInfo.CreateNoWindow = true; crash.StartInfo.RedirectStandardOutput = false;
            crash.StartInfo.UseShellExecute = false;
            crash.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            crash.Start(); //inject anti crash
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

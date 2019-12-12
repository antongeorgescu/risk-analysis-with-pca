using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace R_MessageBroker
{
    public class Program
    {
        public static Dashboard fdsb;
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            var fbst = new Bootstrap();
            //fdsb = new Dashboard();
            
            //var mcx = new MultiFormContext(fbst, fdsb);
            fbst.ShowDialog();

        }
    }
}

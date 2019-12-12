using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;

namespace R_MessageBroker
{
    public partial class ChartMagnifier : Form
    {
        public string chartKey = string.Empty;
        public ChartMagnifier(string itemKey)
        {
            InitializeComponent();
            chartKey = itemKey.Replace(" ","");
        }

        private void picChartMagnifier_SizeChanged(object sender, EventArgs e)
        {
            Width = (int)Math.Round(1.2*picChartMagnifier.Width,0);
            Height = (int)Math.Round(1.2*picChartMagnifier.Height);
        }

        private void picChartMagnifier_Click(object sender, EventArgs e)
        {
            if (chartKey == string.Empty)
                return;

            var chartInfo = new ChartInfo();
            // read info from text file based on chart key

            var appPath = Assembly.GetExecutingAssembly().Location;
            var appPathArray = appPath.Split('\\');
            Array.Resize<string>(ref appPathArray, appPathArray.Length - 1);
            var docFiles = $"{string.Join("\\", appPathArray)}\\Documentation\\";
            
            // find the key element in .json file
            var keyInfoText = File.ReadAllText($"{docFiles}ChartKeyToInfoMapper.json");
            var keyInfoList = JArray.Parse(keyInfoText);

            if (keyInfoList.FirstOrDefault(x => x["key"].Value<string>() == chartKey) == null)
            {
                MessageBox.Show($"No info available for chart key:{chartKey}",
                    "Information Unavailable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var infofile = keyInfoList.First(x => x["key"].Value<string>() == chartKey)["infofile"].Value<string>();
            var content = File.ReadAllText($"{docFiles}{infofile}");

            chartInfo.rbChartInfo.AppendText($"KEY:{chartKey}{ Environment.NewLine}");
            chartInfo.rbChartInfo.AppendText($"INFO:{ Environment.NewLine}");
            chartInfo.rbChartInfo.AppendText(content);
            
            chartInfo.ShowDialog();
        }
    }
}

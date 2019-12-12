using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDotNet;
using TextPDF;

namespace R_MessageBroker
{
    public partial class Dashboard : Form
    {

        SplashForm splash = null;
        ChartMagnifier chartMagnify = null;

        public Dashboard()
        {
            InitializeComponent();

            cbActions.Items.Add(new { key = "executeAll", value = "Run Full CA Analysis" });
            cbActions.Items.Add(new { key = "showData", value = "Display Contingency Data" });
            cbActions.ValueMember = "key";
            cbActions.DisplayMember = "value";

            splash = new SplashForm();
            lvPics.MultiSelect = false;
            
        }

        void CloseSplash(EventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                splash.Close();
            }));
        }

        private async void bnExecute_Click(object sender, EventArgs e)
        {
            var info = new List<string>();
            info.Add("Long job runing in the background...");
            var jobDefinition = string.Empty;
            switch (((dynamic)cbActions.SelectedItem).key)
            {
                case "executeAll":
                    jobDefinition = "Execute ALL tasks required by Correspondence Analysis applied to dataset...";
                    break;
                case "showData":
                    jobDefinition = "Display dataset subject to Correspondence Analysis...";
                    break;
            }

#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            Task.Factory.StartNew(() =>
            {
                info.Add(jobDefinition);
                info.Add("Please wait.");

                splash.RestartTimer();
                splash.InformationText = info;
                splash.ShowDialog();
            });
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            switch (((dynamic)cbActions.SelectedItem).key)
            {
                case "executeAll":
                    await ExecuteAllAsync();
                    break;
                case "showData":
                    ShowData();
                    break;
            }
            CloseSplash(e);
        }

        private void ShowData()
        {
            // read dataset from file
            var appPath = Assembly.GetExecutingAssembly().Location;
            var appPathArray = appPath.Split('\\');
            Array.Resize<string>(ref appPathArray, appPathArray.Length - 3);
            var rScriptPath = $"{string.Join("\\", appPathArray)}\\DelinquencyRiskServices";
            string filePath = $"{rScriptPath}\\{ConfigurationSettings.AppSettings["contingencyTableFilePath"]}";

            var content = File.ReadAllText(filePath);
            lvPics.Clear();
            tbResults.Clear();
            content = content.Replace(",", " , ");
            tbResults.AppendText(content);
        }

        private async Task ExecuteAllAsync()
        {
            //var programFilesDir = @"C:\Program Files";

            //// Set the folder in which RScript.exe and R.dll locate.
            //var envPath = Environment.GetEnvironmentVariable("PATH");
            ////var rBinPath = @"C:/Program Files/R/R-3.4.2/bin/i386";
            //var rBinPath = $"{programFilesDir}\\R-3.4.2\\bin\\i386";
            ////var rBinPath = @"C:/Program Files/R/R-3.4.2/bin/x64";
            //Environment.SetEnvironmentVariable("PATH", envPath + Path.PathSeparator + rBinPath);

            REngine engine;
            try
            {

                REngine.SetEnvironmentVariables();
                // There are several options to initialize the engine, but by default the following suffice:
                engine = REngine.GetInstance();
            }
            catch (Exception ex)
            {
                string info = $"You may not have R installed on your Windows machine or your installation is corrupt.{Environment.NewLine}";
                info += $"Please make sure you install or repair R first and then run this application.";
                MessageBox.Show(info, "Error Running R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var appPath = Assembly.GetExecutingAssembly().Location;
            var appPathArray = appPath.Split('\\');
            Array.Resize<string>(ref appPathArray, appPathArray.Length - 3);
            var rScriptPath = $"{string.Join("\\", appPathArray)}\\DelinquencyRiskServices";

            // delete all pre-existing png files
            var charts = Directory.EnumerateFiles($"{rScriptPath}\\plots");
            foreach (var chart in charts)
                File.Delete(chart);


            ProcessStartInfo start = new ProcessStartInfo
            {
                FileName = "Rscript.exe",
                //var currPath = Application.ExecutablePath;
                WorkingDirectory = $"{rScriptPath}",
                Arguments = ConfigurationSettings.AppSettings["rBaseAnalyticsScript"],
                //start.Arguments = "test_messaging.R";
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = false
            };
            Process process = Process.Start(start);

            string output = await process.StandardOutput.ReadToEndAsync();
            int lines = output.Length;

            lvPics.Clear();
            tbResults.Clear();

            PopulateChartList(output, rScriptPath);
            tbResults.AppendText(output);
        }

        private void PopulateChartList(string output, string scriptPath)
        {
            var cycle = 0;
            try
            {
                // identify the beginning of CHART FILES block
                var olines = output.Split('\n').ToList();
                var startChartsFileList = olines.FindIndex(x => x.Contains("CHART_FILES"));
                var chartCount = int.Parse(olines[startChartsFileList].Replace("\"", "").Split(',')[1]);
                var ocharts = olines.Skip(startChartsFileList + 1);
                //var ofiles = olines.Select(x => new Tuple<string, string>(item1: x.Split(',')[0], item2: x.Split(',')[1]));
                //var startChartsFileList = ofiles.FindIndex(x => x.Item1 == "CHART_FILES");
                //var chart_files = ofiles.Skip(startChartsFileList + 1);
                lvPics.Clear();
                var i = 2;
                foreach (var c in ocharts)
                {
                    if (c.Contains("R version"))
                        break;
                    if (c == "")
                    {
                        i++;
                        continue;
                    }

                    var ctemp = c.Replace("\"", "").Replace($"[{i}]", "");
                    var ckey = ctemp.Split(',')[0];
                    var cpath = $"{scriptPath}\\{ctemp.Split(',')[1].Replace("/", "\\")}";

                    var lv = new ListViewItem
                    {
                        Text = ChartInfoHelper.SelectImportantChart(ckey),
                        Tag = cpath,
                        ImageIndex = 0
                    };
                    lvPics.Items.Add(lv);
                    lv.ToolTipText = ChartInfoHelper.TooltipText(ckey.Trim(' '));
                    i++;
                    cycle = i;
                }
            }
            catch(Exception ex)
            {
                CloseSplash(null);
                MessageBox.Show($"Error at iteration = {cycle}:{ex.Message}",
                    "Error in Getting Charts",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                
            }
           
        }

        private void lvPics_Click(object sender, EventArgs e)
        {

        }

        private void lvPics_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.Item.Selected)
                return;

            if ((chartMagnify == null) || chartMagnify.IsDisposed)
                chartMagnify = new ChartMagnifier(e.Item.Text);
            else
                chartMagnify.chartKey = e.Item.Text.Replace(" ","");

            chartMagnify.picChartMagnifier.Refresh();
            chartMagnify.picChartMagnifier.ImageLocation = e.Item.Tag.ToString().TrimEnd(' ');
            chartMagnify.ShowDialog();
        }

        private void bnSaveCAAnalysis_Click(object sender, EventArgs e)
        {
            // Save content into temp.txt file
            var appPath = Assembly.GetExecutingAssembly().Location;
            var appPathArray = appPath.Split('\\');
            Array.Resize<string>(ref appPathArray, appPathArray.Length - 4);
            var rScriptPath = string.Join("\\", appPathArray);
            string filePath = $"{rScriptPath}\\datasets\\temp.txt";
            File.WriteAllText(filePath, tbResults.Text);
            
            // Create a new PdfWriter
            TextPDF.PdfWriter pdfWriter =
               new TextPDF.PdfWriter(842.0f, 1190.0f, 10.0f, 10.0f);
            
            if (filePath.Length > 0)
            {
                //Write to a PDF file
                pdfWriter.Write(filePath);
            }

            // copy temp file back to datasets directory
            var fileName = DateTime.Now.ToUniversalTime().Ticks.ToString();
            File.Copy(@"C:\temp\txtPdf.pdf", $"{rScriptPath}\\datasets\\{fileName}.pdf");
            File.Delete(@"C:\temp\txtPdf.pdf");
            var msg = $"Analysis saved in file {rScriptPath}\\datasets\\{fileName}.pdf{Environment.NewLine}";
            msg = msg + $"{Environment.NewLine}";
            msg = msg + $"Please make sure you back up all charts created in folder{Environment.NewLine}";
            msg = msg + $"{rScriptPath}\\plots{Environment.NewLine}";
            msg = msg + $"as they will be removed during the next session of analysis";
            MessageBox.Show(msg,
                "Correspondence Analysis Results Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}

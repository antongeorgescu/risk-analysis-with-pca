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

namespace R_MessageBroker
{
    public partial class Bootstrap : Form
    {

        
        public Bootstrap()
        {
            InitializeComponent();

            //var hlpFilePath = @"C:\User\ag4488\Documents\Visual Studio 2017\Projects\Hackathon-2019\HelpDocumentation\";
            //caHelpProvider.HelpNamespace = $"file://{hlpFilePath}DeepThoughtHelp.chm";
            caHelpProvider.SetHelpNavigator(this, HelpNavigator.TableOfContents); //Set the Keyword
            
            //caHelpProvider.SetShowHelp(bnHelp, true);
            caHelpProvider.SetHelpKeyword(this, "CA General Purpose"); // Topic in help file.

        }

        private void bnBaseAnalytics_Click(object sender, EventArgs e)
        {
            var frm = new Dashboard();
            frm.ShowDialog();
        }

        private void bnBasePrediction_Click(object sender, EventArgs e)
        {
            var frm = new Predictor();
            frm.ShowDialog();
        }

        private async void bnInstallRPkgs_Click(object sender, EventArgs e)
        {
            //var reng = REngine.GetInstance();

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
            catch(Exception ex)
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
                Arguments = ConfigurationSettings.AppSettings["rInstallPackagesScript"],
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = false
            };
            Process process = Process.Start(start);

            string output = await process.StandardOutput.ReadToEndAsync();
            MessageBox.Show($"Required packages installation:{Environment.NewLine}{output}",
                "Install R Packages",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }
    }
}

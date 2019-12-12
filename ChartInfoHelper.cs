using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_MessageBroker
{
    public static class ChartInfoHelper
    {
        public static string TooltipText(string chartkey)
        {
            var txtout = "";
            switch(chartkey)
            {
                case "baloon_plot":
                    txtout = "Tabular View: Magnitude of dependencies between categorial values (rows and columns.)";
                    break;
                case "scree_plot_avgline":
                    txtout = "View of observations and variables representation in the reduced dimensions space";
                    break;
                case "ca_rows_cos2_plot":
                    txtout = "Plotted View: Quality of Representation of Observations and Variables in Reduced Dimensions Space"; 
                    break;
                case "ca_rows_cos2_matrix":
                    txtout = "Tabular View: Quality of Representation of Observations and Variables in Reduced Dimensions Space";
                    break;
                case "ca_asymmetric_biplot":
                    txtout = "View of Observations and Variables Representation in Reduced Dimensions Space (Normalized)";
                    break;
                case "ca_cols_cos2_plot":
                    txtout = "Plotted View: Quality of Representation of Variables in Reduced Dimensions Space";
                    break;
                case "ca_row_asymmetric_biplot":
                case "ca_col_asymmetric_biplot":
                    txtout = "Multi-dimensional visualization of high-risk delinquency factors";
                    break;
                default:
                    txtout = $"Tooltip test for {chartkey}";
                    break;
            }
            return txtout;
        }

        internal static string SelectImportantChart(string chartkey)
        {
            var txtout = chartkey;
            switch (chartkey.Trim(' '))
            {
                case "baloon_plot":
                case "scree_plot_avgline":
                case "ca_rows_cos2_plot":
                case "ca_rows_cos2_matrix":
                case "ca_asymmetric_biplot":
                case "ca_cols_cos2_plot":
                    txtout = $"** {chartkey.Trim(' ')}";
                    break;
            
            }
            return txtout;
        }
    }
}

using PipelineCommanderForms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipelineCommanderForms
{
    public partial class SysInfoView : Form
    {
        PipelineCommands _commands = new PipelineCommands();
        public static string CurrLang = "";
        public static string Description = "";
        public static string IDCode = "";
        public static string LabelLang = "";
        public static string LangEdition = "";
        public static string LangList = "";
        public static string SN = "";
        public static string Manufacturer = "";
        public static string Model = "";
        public static string NName = "";
        public static string ReleaseDT = "";
        public static string BIOSVersion = "";
        public static string InstallDT = "";
        public static string Version = "";

        public SysInfoView()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (checkBoxSN.Checked)
            {
                SN = _commands.GetSerialNumber();
            }

            InfoResultView resultView = new InfoResultView();
            resultView.Show();
        }
    }
}

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
        public static UInt16 LabelLang = 0;
        public static string LangEdition = "";
        public static string[] LangList;
        public static string SN = "";
        public static string Manufacturer = "";
        public static string Model = "";
        public static string NName = "";
        public static DateTime ReleaseDT;
        public static string BIOSVersion = "";
        public static DateTime InstallDT;
        public static string Version = "";
        public static string Status = "";

        public SysInfoView()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            Checkbox_Checked_Parser();

            InfoResultView resultView = new InfoResultView();
            resultView.Show();
        }

        private void Checkbox_Checked_Parser()
        {
            if (checkBoxSN.Checked)
                SN = _commands.GetSerialNumber();
            else if (checkBoxBIOSVer.Checked)
                BIOSVersion = _commands.GetBIOSVersion();
            else if (checkBoxCurrentLanguage.Checked)
                CurrLang = _commands.GetCurrentLang();
            else if (checkBoxDescription.Checked)
                Description = _commands.GetDescription();
            else if (checkBoxIDCode.Checked)
                IDCode = _commands.GetIDCode();
            else if (checkBoxInstallDT.Checked)
                InstallDT = _commands.GetInstallDate();
            else if (checkBoxlabelLanguage.Checked)
                LabelLang = _commands.GetLabelLang();
            else if (checkBoxLangEdition.Checked)
                LangEdition = _commands.GetLangEdition();
            else if (checkBoxLangLists.Checked)
                LangList = _commands.GetLangList();
            else if (checkBoxManufacturer.Checked)
                Manufacturer = _commands.GetManufacturer();
            else if (checkBoxModel.Checked)
                Model = _commands.GetModel();
            else if (checkBoxName.Checked)
                NName = _commands.GetName();
            else if (checkBoxReleaseDT.Checked)
                ReleaseDT = _commands.GetReleaseDate();
            else if (checkBoxStatus.Checked)
                Status = _commands.GetStatus();
                

        }
    }
}

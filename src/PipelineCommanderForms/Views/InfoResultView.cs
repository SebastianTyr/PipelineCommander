using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipelineCommanderForms.Views
{
    public partial class InfoResultView : Form
    {
        public InfoResultView()
        {
            InitializeComponent();
            HiddenLables();
        }

        private void InfoResultView_Load(object sender, EventArgs e)
        {
            LoadLabels();
        }

        private void HiddenLables()
        {
            labelBIOSVer.Visible = false;
            labelCurrLang.Visible = false;
            labelDesc.Visible = false;
            labelIDCode.Visible = false;
            labelinstallDT.Visible = false;
            labelinstallLang.Visible = false;
            labelLangEdition.Visible = false;
            labelLangList.Visible = false;
            labelManuf.Visible = false;
            labelModel.Visible = false;
            labelName.Visible = false;
            labelReleaseDT.Visible = false;
            labelSN.Visible = false;
            labelStat.Visible = false;
        }

        private void LoadLabels()
        {
            labelSN.Text = SysInfoView.SN;
            labelSN.Visible = true;

            labelBIOSVer.Text = SysInfoView.BIOSVersion;
            labelBIOSVer.Visible = true;

            labelCurrLang.Text = SysInfoView.CurrLang;
            labelCurrLang.Visible = true;

            labelDesc.Text = SysInfoView.Description;
            labelDesc.Visible = true;

            labelIDCode.Text = SysInfoView.IDCode;
            labelIDCode.Visible = true;

            DateTime installDT = SysInfoView.InstallDT;
            labelinstallDT.Text = installDT.ToString();
            labelinstallDT.Visible = true;

            UInt16 installLang = SysInfoView.LabelLang;
            labelinstallLang.Text = installLang.ToString();
            labelinstallLang.Visible = true;

            labelLangEdition.Text = SysInfoView.LangEdition;
            labelLangEdition.Visible = true;

            string[] langlist = SysInfoView.LangList;
            labelLangList.Text = langlist.ToString();
            labelLangList.Visible = true;

            labelManuf.Text = SysInfoView.Manufacturer;
            labelManuf.Visible = true;

            labelModel.Text = SysInfoView.Model;
            labelModel.Visible = true;

            labelName.Text = SysInfoView.NName;
            labelName.Visible = true;

            DateTime releaseDT = SysInfoView.ReleaseDT;
            labelReleaseDT.Text = releaseDT.ToString();
            labelReleaseDT.Visible = true;

            labelStat.Text = SysInfoView.Status;
            labelStat.Visible = true;
        }
    }
}

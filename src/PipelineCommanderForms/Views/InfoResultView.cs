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
            labelVer.Visible = false;
        }
    }
}

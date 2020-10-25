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
        //private static SysInfoView sysInfoView = null;
        //private delegate void EnableDelegate(bool enable);
        public SysInfoView()
        {
            InitializeComponent();
            //sysInfoView = this;
        }

        //public static void EnableStaticSCheckbox(bool enable)
        //{
        //    if (sysInfoView != null)
        //        sysInfoView.EnableCheckbox(enable);

        //}

        //private void EnableCheckbox(bool enable)
        //{
        //    if (InvokeRequired)
        //    {
        //        this.Invoke(new EnableDelegate(EnableCheckbox), new object[] { enable });
        //    }

        //    checkBoxBIOSVer.Enabled = enable;
        //}
    }
}

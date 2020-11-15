using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PipelineCommanderForms.libs;

namespace PipelineCommanderForms.Views
{
    public partial class InfoResultView : Form
    {
        PipelineCommands _commands = new PipelineCommands();
        public InfoResultView()
        {
            InitializeComponent();
        }

        private void InfoResultView_Load(object sender, EventArgs e)
        {
            labelManufResult.Text = _commands.GetManufacturer();
            labelVerResult.Text = _commands.GetVersion();
            labelNameResult.Text = _commands.GetName();
            labelStatusResult.Text = _commands.GetStatus();
            labelSNResult.Text = _commands.GetSerialNumber();
        }
    }
}

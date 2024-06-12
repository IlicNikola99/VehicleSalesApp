using Common;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class UCAddPerson : UserControl
    {
        public UCAddPerson()
        {
            InitializeComponent();
            cmbCity.DisplayMember = "Name";
        }
    }
}

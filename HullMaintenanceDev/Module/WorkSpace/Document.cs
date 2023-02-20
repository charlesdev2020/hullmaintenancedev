using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HullMaintenanceDev.Module
{
    public partial class Document : DevExpress.XtraEditors.XtraUserControl
    {
        public Document()
        {
            InitializeComponent();
        }

        public Document(string customerName, bool isReadOnly)
            : base()
        {
            InitializeComponent();
        }
    }
}

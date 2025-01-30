using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cft.Code;
using cft.Gui;

namespace cft
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly PageManger pageManger;
        public Main()
        {
            InitializeComponent();
            pageManger = new PageManger(this);

        }

        private void barButtonItemAddCat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Load Category Page
           pageManger.LoadPage(cft.Gui.UserControlCat.Instance());
        }
    }
}

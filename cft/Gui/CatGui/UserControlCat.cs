using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cft.Gui
{
    public partial class UserControlCat : UserControl
    {
        private static UserControlCat _userControlCat;
        public UserControlCat()
        {
            InitializeComponent();
        }

        public static UserControlCat Instance()
        {
            return _userControlCat ?? (new UserControlCat());
        }



        private void UserControlCat_Load(object sender, EventArgs e)
        {

        }

        private void tablePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}

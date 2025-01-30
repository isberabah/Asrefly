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
    }
}

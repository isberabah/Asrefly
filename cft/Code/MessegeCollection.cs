using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cft.Properties;

namespace cft.Code
{
    public static class MessegeCollection
    {
        public static void ShowEmpltyDataMessege()
        {
            MessageBox.Show(Resources.EmptyMessageText, Resources.EmptyMessageCation, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

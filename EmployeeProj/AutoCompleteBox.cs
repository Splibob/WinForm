using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace EmployeeProj
{
    class AutoCompleteBox
    {
        private ListBox listBox;
        private bool _isAdded;
        private String[] values;
        private String formerValue = string.Empty;

  
        private void InitializeComponet()
        {
            listBox = new ListBox();
        }
    }
}

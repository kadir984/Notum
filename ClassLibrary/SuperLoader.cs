using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class SuperLoader
    {
 public static void ComboLoader(ComboBox cmb, IEnumerable list, string displayMember = "Name", string valueMember = "Id")
        {
            cmb.ItemsSource = list;
            cmb.DisplayMemberPath = displayMember;
            cmb.SelectedValuePath = valueMember;
            cmb.SelectedIndex = 0;
        }

        public static void DataGridLoader(DataGrid dg, IEnumerable lst)
        {
            dg.ItemsSource = null;
            dg.ItemsSource = lst;
        }
    }
}

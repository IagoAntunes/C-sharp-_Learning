using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincipalPomodoro
{
    public partial class UserListBox : UserControl
    {
        public UserListBox()
        {
            InitializeComponent();
        }
        int index;

        List<string> tr = new List<string>();


        private void btnTesti_Click(object sender, EventArgs e)
        {
            //tr.Add(txtTask.Text);
            clbTasks.Items.Add(txtTask.Text, true);
            //clbTasks.Items.AddRange(tr.ToArray());
            txtTask.Clear();
            txtTask.Focus();
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            clbTasks.Items.RemoveAt(clbTasks.SelectedIndex);

        }

        private void clbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //index = clbTasks.SelectedIndex;

        }
    }
}

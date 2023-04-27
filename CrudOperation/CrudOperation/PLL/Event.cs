using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudOperation.BLL;
namespace CrudOperation.PLL
{
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventBLL eventBLL = new EventBLL();
            dataGridView1.DataSource = eventBLL.GetEventDetails();
        }
    }
}

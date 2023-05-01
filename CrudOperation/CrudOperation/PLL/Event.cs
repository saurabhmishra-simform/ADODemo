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
    public partial class EventDate : Form
    {
        readonly EventBLL eventBLL = new EventBLL();
        public int result;
        public int eventId;
        public string eventName;
        public decimal eventPrice;
        public string eventDateTime;
        private void UpdateDataGridView()
        {
            dataGridView1.DataSource = eventBLL.GetEventDetails();
        }
        private void DefaultFormData()
        {
            EventId.Text = "0";
            EventName.Text = "";
            EventPrice.Text = "0";
        }
        public void ButtonCheck()
        {
            if (EventId.Text == "0")
            {
                EventId.Enabled = false;
                Update.Enabled = false;
                Delete.Enabled = false;
            }
            else
            {
                Update.Enabled = true;
                Delete.Enabled = true;
                Insert.Enabled = false;
            }
        }
        public EventDate()
        {
            InitializeComponent();
            DefaultFormData();
            UpdateDataGridView();
            ButtonCheck();
        }
        public void GetEventData()
        {
            eventId = Convert.ToInt32(EventId.Text);
            eventName = EventName.Text;
            eventPrice = Convert.ToDecimal(EventPrice.Text);
            eventDateTime = EventDateTime.Text;
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            GetEventData();
            result = eventBLL.InsertData(eventName,eventPrice,eventDateTime);
            if (result > 0)
            {
                MessageBox.Show("Event record inserted sucessfully!");
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Event record not inserted!");
            }
            DefaultFormData();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            GetEventData();
            result = eventBLL.DeleteData(eventId);
            if (result > 0)
            {
                MessageBox.Show("Event record deleted sucessfully!");
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Record not deleted because event id not found!");
            }
            DefaultFormData();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            GetEventData();
            result = eventBLL.UpdateData(eventId, eventName,eventPrice,eventDateTime);
            if (result > 0)
            {
                MessageBox.Show("Event record updated sucessfully!");
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Record not updated because event id not found!");
            }
            DefaultFormData();
        }
        private void Display_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
            DefaultFormData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EventId.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EventName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            EventPrice.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            EventDateTime.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ButtonCheck();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EventId.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EventName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            EventPrice.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            EventDateTime.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ButtonCheck();
        }
    }
}

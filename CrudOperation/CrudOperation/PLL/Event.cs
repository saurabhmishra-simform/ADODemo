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
using CrudOperation.DAL.Querys;

namespace CrudOperation.PLL
{
    public partial class EventDate : Form
    {
        EventDataHandle eventDataHandle = new EventDataHandle();
        readonly EventBLL eventBLL = new EventBLL();
        public int result;
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
                Insert.Enabled = true;
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
            try
            {
                eventDataHandle.eventId = Convert.ToInt32(EventId.Text);
                eventDataHandle.eventName = EventName.Text;
                eventDataHandle.eventPrice = Convert.ToDecimal(EventPrice.Text);
                eventDataHandle.eventDateTime = EventDateTime.Text;
            }
            catch
            {
                MessageBox.Show("Input in correct format");
            }
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            GetEventData();
            result = eventBLL.InsertData(eventDataHandle);
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
            result = eventBLL.DeleteData(eventDataHandle);
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
            ButtonCheck();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            GetEventData();
            result = eventBLL.UpdateData(eventDataHandle);
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
            ButtonCheck();
        }
        private void Display_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
            DefaultFormData();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EventId.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EventName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            EventPrice.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            EventDateTime.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ButtonCheck();
        }
    }
}

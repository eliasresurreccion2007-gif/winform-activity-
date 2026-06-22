using System.Xml.Linq;
using WinFormsApp2;

namespace Activity_4
{
    public partial class Data : Form
    {
        private int selectedRowIndex = -1;
        public Data()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 9;

            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Age";
            dataGridView1.Columns[2].Name = "Contact";
            dataGridView1.Columns[3].Name = "Time In";
            dataGridView1.Columns[4].Name = "Time Out";
            dataGridView1.Columns[5].Name = "Section";
            dataGridView1.Columns[6].Name = "Year";
            dataGridView1.Columns[7].Name = "Bus Number";
            dataGridView1.Columns[8].Name = "Course";


            SectionCB.Items.AddRange(new string[]
            { "1A", "1B", "1C", "1D", "1E", "1F"});
            YearCB.Items.AddRange(new string[]
            { "1st Year", "2nd Year", "3rd Year", "4th Year" });
            CourseCB.Items.AddRange(new string[]
            { "BSIT", "BSCS", "BSBA" });
            BusNumCB.Items.AddRange(new string[]
            { "  1", " 2", " 3", " 4", "5", "6", "7",
             "8", "9", "10", "11", "12", "13"});

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
                                    NameTB.Text,
                                    AgeTB.Text,
                                    YearCB.Text,
                                    CourseCB.Text,
                                    ContactTB.Text,
                                     BusNumCB.Text,
                                     SectionCB.Text,
                                     TimeInTB.Text,
                                     TimeOutTB.Text
                                                 );

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
                DataGridViewRow rows = dataGridView1.Rows[selectedRowIndex];

                NameTB.Text = rows.Cells[0].Value?.ToString();
                AgeTB.Text = rows.Cells[1].Value?.ToString();
                ContactTB.Text = rows.Cells[2].Value?.ToString();
                TimeInTB.Text = rows.Cells[3].Value?.ToString();
                TimeOutTB.Text = rows.Cells[4].Value?.ToString();
                SectionCB.Text = rows.Cells[5].Value?.ToString();
                YearCB.Text = rows.Cells[6].Value?.ToString();
                BusNumCB.Text = rows.Cells[7].Value?.ToString();
                CourseCB.Text = rows.Cells[8].Value?.ToString();
                selectedRowIndex = e.RowIndex;



                dataGridView1.ClearSelection();
                rows.Selected = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];

                row.Cells[0].Value = NameTB.Text;
                row.Cells[1].Value = AgeTB.Text;
                row.Cells[2].Value = ContactTB.Text;
                row.Cells[3].Value = TimeInTB.Text;
                row.Cells[4].Value = TimeOutTB.Text;
                row.Cells[5].Value = SectionCB.Text;
                row.Cells[6].Value = YearCB.Text;
                row.Cells[7].Value = BusNumCB.Text;
                row.Cells[8].Value = CourseCB.Text;

                MessageBox.Show("Record updated successfully!");

                ClearTextBoxes();
                selectedRowIndex = -1;
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(selectedRowIndex);
                MessageBox.Show("Record deleted successfully!");
                ClearTextBoxes();
                selectedRowIndex = -1;
            }
            else
            {

            }
        }



        private void ClearTextBoxes()
        {
            NameTB.Clear();
            AgeTB.Clear();
            ContactTB.Clear();
            TimeInTB.Clear();
            TimeOutTB.Clear();
            SectionCB.SelectedIndex = -1;
            YearCB.SelectedIndex = -1;
            BusNumCB.SelectedIndex = -1;
            CourseCB.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transition transition = new Transition();
            transition.Show();

            this.Hide();
        }
    }
}


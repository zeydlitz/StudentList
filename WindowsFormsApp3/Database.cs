using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class database : Form
    {
        private List<Student> kek;
        public database(List<Student> lol)
        {
            kek = lol;
            InitializeComponent();
        }

        private void database_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'test_dbDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.test_dbDataSet.student);
            // TODO: This line of code loads data into the 'test_dbDataSet.address' table. You can move, or remove it, as needed.
            this.addressTableAdapter.Fill(this.test_dbDataSet.address);

        }

        protected virtual void Input_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {



                for (int i = 0; i < selectedRowCount; i++)
                {


                    int index = int.Parse(dataGridView1.SelectedRows[i].Index.ToString());
                    DataGridViewRow row = dataGridView1.Rows[index];
                    Student st = new Student();
                    st.SURNAME = row.Cells[0].Value.ToString();
                    st.NAME = row.Cells[1].Value.ToString();
                    st.PASSPORT = row.Cells[3].Value.ToString();
                    st.DATE = DateTime.Parse(row.Cells[2].Value.ToString());
                    st.Univer = row.Cells[4].Value.ToString();
                    int k = int.Parse(row.Cells[5].Value.ToString());
                    int j = int.Parse(row.Cells[6].Value.ToString());
                    DataGridViewRow row1 = dataGridView2.Rows[k];
                    DataGridViewRow row2 = dataGridView2.Rows[j];
                    Adress_c one = new Adress_c();
                    Adress_c two = new Adress_c();
                    one.COUNTRY= row1.Cells[1].Value.ToString();
                    one.CITY= row1.Cells[2].Value.ToString();
                    one.STREET = row1.Cells[3].Value.ToString();
                    two.COUNTRY = row2.Cells[1].Value.ToString();
                    two.CITY = row2.Cells[2].Value.ToString();
                    two.STREET = row2.Cells[3].Value.ToString();
                    st.adr = one;
                    st.un_adr = two;
                    kek.Add(st);
                }

            }
        }
    }
}

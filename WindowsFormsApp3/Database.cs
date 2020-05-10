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
    public partial class Database : Form
    {
        private List<Student> kek;
        public Database(List<Student> lol)
        {
            kek = lol;
            InitializeComponent();
        }

        private void Database_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'test_dbDataSet1.ADDRESS' table. You can move, or remove it, as needed.
            this.aDDRESSTableAdapter1.Fill(this.test_dbDataSet1.ADDRESS);
            // TODO: This line of code loads data into the 'test_dbDataSet1.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter3.Fill(this.test_dbDataSet1.STUDENT);
            //// TODO: This line of code loads data into the '_BD_for_c_DataSet3.ADDRESS' table. You can move, or remove it, as needed.
            //this.aDDRESSTableAdapter.Fill(this._BD_for_c_DataSet3.ADDRESS);
            //// TODO: This line of code loads data into the '_BD_for_c_DataSet1.STUDENT' table. You can move, or remove it, as needed.
            //this.sTUDENTTableAdapter2.Fill(this._BD_for_c_DataSet1.STUDENT);


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
                    Adress_c one=new Adress_c();
                    Adress_c two = new Adress_c();
                    one.A1 = row1.Cells[1].Value.ToString();
                    one.A2 = row1.Cells[2].Value.ToString();
                    one.A3 = row1.Cells[3].Value.ToString();
                    two.A1 = row2.Cells[1].Value.ToString();
                    two.A2 = row2.Cells[2].Value.ToString();
                    two.A3 = row2.Cells[3].Value.ToString();
                    st.adr = one;
                    st.un_adr = two;
                    kek.Add(st);
                }

            }
        }

        private void sTUDENTBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

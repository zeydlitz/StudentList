﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using WindowsFormsApp3;
using Npgsql;
using NpgsqlTypes;

namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {
        private List<Student> StudentList;
        private string Filename;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Список студентов";
            this.StudentList = new List<Student>(5);
            saveToolStripMenuItem.Enabled = false;
            Filename = null;
        }

        private void Input_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            SwmX form = new SwmX(stud);
            form.ShowDialog();
            if (StudentList.Count < 20)
            {
                this.dataGridView1.Rows.Add(stud.SURNAME, stud.NAME, stud.DATE, stud.PASSPORT, stud.Univer);

                this.listBox1.Items.Add(stud.to_ListItem());
                this.StudentList.Add(stud);
            }
            else
            {
                MessageBox.Show("limit was reached ");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index;
            try
            { index = this.dataGridView1.CurrentCell.RowIndex; 
                if (index >= 0)
            {
                this.StudentList.RemoveAt(index);
                this.dataGridView1.Rows.RemoveAt(index);
            }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Row Doesnt exist");
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index;
            try
            {
                index= this.dataGridView1.CurrentCell.RowIndex;
                //if (index >= 0)
                SwmX form = new SwmX(this.StudentList[index]);
                form.ShowDialog();
                DataGridViewRow row = dataGridView1.Rows[index];
                row.Cells[0].Value = this.StudentList[index].SURNAME;
                row.Cells[1].Value = this.StudentList[index].NAME;
                row.Cells[2].Value = this.StudentList[index].DATE;
                row.Cells[4].Value = this.StudentList[index].PASSPORT;
                row.Cells[3].Value = this.StudentList[index].Univer;

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Row Doesnt exist");
                
            }
            
            
        
        }


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "xml files|*.xml";
            sfd.FileName = "Students list";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XDocument xdoc = new XDocument();
                XElement SL=new XElement("StudentsList");
                for (Int16 i = 0; i < this.StudentList.Count; i++)
                {
                    
                    XElement Student_el= new XElement("Student");
                    XAttribute NS=new XAttribute("Number",(i+1).ToString());
                    XElement Person_el=new XElement("Person");
                    XElement Surname=new XElement("Surname",this.StudentList[i].SURNAME);
                    XElement Name = new XElement("Name", this.StudentList[i].NAME);
                    XElement BD=new XElement("Birthdate",this.StudentList[i].DATE);
                    XElement Pass = new XElement("Pass", this.StudentList[i].PASSPORT);
                    XElement adr = new XElement("Addres");
                    if (this.StudentList[i].adr != null)
                    {
                        
                        XElement Country=new XElement("Country", this.StudentList[i].adr.COUNTRY);
                        XElement Loc = new XElement("Locality", this.StudentList[i].adr.CITY);
                        XElement Street = new XElement("Street", this.StudentList[i].adr.STREET);
                        adr.Add(Country);
                        adr.Add(Loc);
                        adr.Add(Street);

                    }
                    XElement University=new XElement("University");
                    XAttribute name_U=new XAttribute("University",this.StudentList[i].Univer);
                    University.Add(name_U);
                    XElement un_adr = new XElement("Unifercity_Addres");
                    if (this.StudentList[i].un_adr != null)
                    {
                        
                        XElement Country = new XElement("Country", this.StudentList[i].un_adr.COUNTRY);
                        XElement Loc = new XElement("Locality", this.StudentList[i].un_adr.CITY);
                        XElement Street = new XElement("Street", this.StudentList[i].un_adr.STREET);
                        un_adr.Add(Country);
                        un_adr.Add(Loc);
                        un_adr.Add(Street);
                    }
                    Student_el.Add(NS);
                    Person_el.Add(Surname);
                    Person_el.Add(Name);
                    Person_el.Add(Pass);
                    Person_el.Add(BD);
                    if (this.StudentList[i].adr != null) Person_el.Add(adr);
                    Student_el.Add(Person_el);
                    Student_el.Add(University);
                    if(this.StudentList[i].un_adr != null) Student_el.Add(un_adr);
                    SL.Add(Student_el);
                }
                xdoc.Add(SL);
                xdoc.Save(sfd.FileName);
            }

            this.Text = sfd.FileName;
            saveToolStripMenuItem.Enabled = true;

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (Filename != null)
            {
                sfd.FileName = Filename;
                sfd.FileNames[0] = Filename;
                XDocument xdoc = new XDocument();
                XElement SL = new XElement("StudentsList");
                for (Int16 i = 0; i < this.StudentList.Count; i++)
                {
                    XElement Student_el = new XElement("Student");
                    XAttribute NS = new XAttribute("Number", (i + 1).ToString());
                    XElement Person_el = new XElement("Person");
                    XElement Surname = new XElement("Surname", this.StudentList[i].SURNAME);
                    XElement Name = new XElement("Name", this.StudentList[i].NAME);
                    XElement BD = new XElement("Birthdate", this.StudentList[i].DATE);
                    XElement Pass = new XElement("Pass", this.StudentList[i].PASSPORT);
                    XElement adr = new XElement("Addres");
                    if (this.StudentList[i].adr != null)
                    {

                        XElement Country = new XElement("Country", this.StudentList[i].adr.COUNTRY);
                        XElement Loc = new XElement("Locality", this.StudentList[i].adr.CITY);
                        XElement Street = new XElement("Street", this.StudentList[i].adr.STREET);
                        adr.Add(Country);
                        adr.Add(Loc);
                        adr.Add(Street);

                    }

                    XElement University = new XElement("University");
                    XAttribute name_U = new XAttribute("University", this.StudentList[i].Univer);
                    University.Add(name_U);
                    XElement un_adr = new XElement("Unifercity_Addres");
                    if (this.StudentList[i].un_adr != null)
                    {

                        XElement Country = new XElement("Country", this.StudentList[i].un_adr.COUNTRY);
                        XElement Loc = new XElement("Locality", this.StudentList[i].un_adr.CITY);
                        XElement Street = new XElement("Street", this.StudentList[i].un_adr.STREET);
                        un_adr.Add(Country);
                        un_adr.Add(Loc);
                        un_adr.Add(Street);
                    }

                    Student_el.Add(NS);
                    Person_el.Add(Surname);
                    Person_el.Add(Name);
                    Person_el.Add(Pass);
                    Person_el.Add(BD);
                    if (this.StudentList[i].adr != null) Person_el.Add(adr);
                    Student_el.Add(Person_el);
                    Student_el.Add(University);
                    if (this.StudentList[i].un_adr != null) Student_el.Add(un_adr);
                    SL.Add(Student_el);
                }

                xdoc.Add(SL);
                xdoc.Save(sfd.FileName);
            }
        }
    
        

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"d:\";
            ofd.Filter = "xml files|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StudentList.Clear();
                //dataGridView1.DataSource = null;
                //dataGridView1.Rows.Clear();
                XDocument xdoc = XDocument.Load(ofd.FileName);
                foreach (XElement stud in xdoc.Element("StudentsList").Elements("Student"))
                {
                    Student st=new Student();
                    XElement Person = stud.Element("Person");
                    st.SURNAME = Person.Element("Surname").Value;
                    st.NAME= Person.Element("Name").Value;
                    st.DATE  = DateTime.Parse(Person.Element("Birthdate").Value);
                    st.PASSPORT = Person.Element("Pass").Value;
                    XElement un = stud.Element("University");
                    st.Univer = un.Attribute("University").Value;
                    if (Person.Element("Addres") != null)
                    {
                        XElement ad = Person.Element("Addres");
                        st.adr=new Adress_c(ad.Element("Country").Value, ad.Element("Locality").Value, ad.Element("Street").Value);
                    }
                    else st.adr=new Adress_c(" "," "," ");
                    
                    if (stud.Element("Unifercity_Addres") != null)
                    {
                        XElement ad = stud.Element("Unifercity_Addres");
                        st.un_adr = new Adress_c(ad.Element("Country").Value, ad.Element("Locality").Value, ad.Element("Street").Value);

                    }
                    else st.un_adr = new Adress_c(" ", " ", " ");
                    
                    Console.WriteLine();
                    this.StudentList.Add(st);
                    dataGridView1.Rows.Add(st.SURNAME, st.NAME, st.DATE, st.PASSPORT, st.Univer);
                    //this.listBox1.Items.Add(st.to_ListItem());
                }
            }
            
        }

        private void getDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int len = StudentList.Count;
            Dbx form = new Dbx(StudentList);
            form.ShowDialog();
            for (int i = len; i < StudentList.Count; i++)
            {
                this.dataGridView1.Rows.Add(StudentList[i].SURNAME,StudentList[i].NAME,StudentList[i].DATE,StudentList[i].PASSPORT,StudentList[i].Univer);
                this.listBox1.Items.Add(StudentList[i].to_ListItem());
            }
            
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string connectionString = @"server=127.0.0.1;database=test_db;port=5432;uid=postgres;pwd=258852";
            string sqlExpression = "pox";
            int index; 
            try
            {
                index= this.dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    var cmd3 = new NpgsqlCommand(@"INSERT INTO student(""surname"",""name"",""pass"",""univer"",""ad_id"",""bd"",""un_ad_id"") VALUES (@sur,@name,@pass,@univer,@ad_tiny,@birthday,@un_tiny);", connection);
                    cmd3.Parameters.AddWithValue("@sur", row.Cells[0].Value);//ID=ID of first table
                    cmd3.Parameters.AddWithValue("@name", row.Cells[1].Value);
                    cmd3.Parameters.AddWithValue("@pass", row.Cells[3].Value);//ID=ID of first table
                    cmd3.Parameters.AddWithValue("@univer", row.Cells[4].Value);
                    cmd3.Parameters.AddWithValue("@ad_tiny", 2);
                    cmd3.Parameters.AddWithValue("@birthday", row.Cells[2].Value);
                    cmd3.Parameters.AddWithValue("@un_tiny", 1);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show(
                        "Congratulations",
                        "Nice",
                        MessageBoxButtons.OK);
                    

                }
            
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Row Doesnt exist");

            }

            #region MyRegion

            //NpgsqlParameter nameParam = new NpgsqlParameter
            //{
            //    ParameterName = "sur",
            //    Value = row.Cells[0].Value
            //};
            // добавляем параметр
            //command.Parameters.AddWithValue(new NpgsqlParameter(ParameterName = "p_value", NpgsqlDbType = NpgsqlDbType.Composite, Value = value));
            // параметр для ввода возраста
            //NpgsqlParameter Sur = new NpgsqlParameter
            //{
            //    ParameterName = "name",
            //    Value = row.Cells[1].Value
            //};
            //command.Parameters.AddWithValue(new NpgsqlParameter("@name", row.Cells[1].Value));
            //NpgsqlParameter pass = new NpgsqlParameter
            //{
            //    ParameterName = "pass",
            //    Value = row.Cells[3].Value
            //};
            //command.Parameters.AddWithValue(new NpgsqlParameter("@pass", row.Cells[3].Value));
            //NpgsqlParameter univer = new NpgsqlParameter
            //{
            //    ParameterName = "univer",
            //    Value = row.Cells[4].Value
            //};
            //command.Parameters.AddWithValue(new NpgsqlParameter("@univer", row.Cells[4].Value));
            //string k=command.CommandType.ToString();

            //SqlParameter ad = new SqlParameter
            //{
            //    ParameterName = "@ad",
            //    Value = 1
            //};
            //command.Parameters.Add(ad);
            //SqlParameter ud = new SqlParameter
            //{
            //    ParameterName = "@univer",
            //    Value = 1
            //};
            //command.Parameters.Add(ud);
            //SqlDataAdapter adapter=new SqlDataAdapter();
            //adapter = new SqlDataAdapter(sql, connection);
            //commandBuilder = new SqlCommandBuilder(adapter);
            //adapter.InsertCommand = new SqlCommand("sp_CreateUser", connection);
            //adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            //adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, "Name"));
            //adapter.InsertCommand.Parameters.Add(new SqlParameter("@age", SqlDbType.Int, 0, "Age"));

            //SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            //parameter.Direction = ParameterDirection.Output;

            //adapter.Update(ds);


            #endregion
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }


    class SwmX : Swm
    {
        public SwmX(Student x) : base(x)
        {
            base.Text = "Студент";

        }

        public override void button1_Click(object sender, EventArgs e)
        {
            base.button1_Click(sender, e);
            if (this.errorcode == 0)
            {
                base.FormClosing -= this.Swm_FormClosing;
                this.Close();
            }
        }
    }

    class Dbx : database
    {
        public Dbx(List<Student> lol) : base(lol)
        {
            base.Text = "Database";

        }

        protected override void Input_Click(object sender, EventArgs e)
        {
            base.Input_Click(sender,e);
            this.Close();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementTask
{
    public partial class Form1 : Form
    {
        public static string connectionString = "Server=DESKTOP-S5SNUUO;Database=DB_STUDENT_MANAGEMENT;Trusted_Connection=True;";
        SqlConnection SqlConnection = new SqlConnection(connectionString);
        public Form1()
        {
            InitializeComponent();
            RefreshData();
            RefreshLectureData();
            RefreshNoteData();
        }
        public void RefreshData()
        {
            string query = "SELECT * FROM Table_Students";
            SqlCommand cmd = new SqlCommand(query, SqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].ReadOnly = true;
            }
        }

        public void RefreshDataForComboBox()
        {
            string query = "SELECT * FROM Table_Students";
            SqlCommand cmd = new SqlCommand(query, SqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            cmbDersID.DataSource = dataTable;
            cmbDersID.DisplayMember = "LessonName";
            cmbDersID.ValueMember = "LessonID";
        }

        public void RefreshLectureData()
        {
            string query = "SELECT * FROM Table_Lectures";
            SqlCommand sqlCommand = new SqlCommand(query, SqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                dataGridView2.Columns[i].ReadOnly = true;
            }
        }
        public void RefreshNoteData()
        {
            string query = "SELECT * FROM Table_Notes";
            SqlCommand sqlCommand = new SqlCommand(query, SqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;
            for (int i = 0; i < dataGridView3.Columns.Count; i++)
            {
                dataGridView3.Columns[i].ReadOnly = true;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Table_Students (FirstName,LastName,BirthDate,Gender) VALUES (@FirstName,@LastName,@BirthDate,@Gender)", SqlConnection);
            sqlCommand.Parameters.AddWithValue("@FirstName", text_firstName.Text);
            sqlCommand.Parameters.AddWithValue("@LastName", text_lastName.Text);
            sqlCommand.Parameters.AddWithValue("@BirthDate", dateTimePicker1.Value);
            sqlCommand.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());

            try
            {
                SqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                SqlConnection.Close();
                RefreshData();
                MessageBox.Show("Öğrenci ekleme işlemi başarılı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu!", ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                text_firstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                text_lastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[3].Value != null && dataGridView1.CurrentRow.Cells[3].Value != DBNull.Value)
                {
                    dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
                }
                cmbGender.SelectedItem = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE Table_Students SET FirstName = @FirstName, LastName = @LastName , BirthDate = @BirthDate , Gender = @Gender WHERE StudentID = @StudentID", SqlConnection);
                sqlCommand.Parameters.AddWithValue("@StudentID", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                sqlCommand.Parameters.AddWithValue("@FirstName", text_firstName.Text);
                sqlCommand.Parameters.AddWithValue("@LastName", text_lastName.Text);
                sqlCommand.Parameters.AddWithValue("@BirthDate", dateTimePicker1.Value);
                sqlCommand.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                try
                {
                    SqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SqlConnection.Close();
                    RefreshData();
                    MessageBox.Show("Öğrenci güncelleme işlemi başarılı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu!", ex.Message);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Table_Students WHERE StudentID=@StudentID", SqlConnection);
                sqlCommand.Parameters.AddWithValue("@StudentID", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                try
                {
                    SqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SqlConnection.Close();
                    RefreshData();
                    MessageBox.Show("Öğrenci silme işlemi başarılı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu!", ex.Message);
                }
            }
        }

        private void btnKaydetLecture_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Table_Lectures (LessonName,LessonCode) VALUES (@LessonName,@LessonCode)", SqlConnection);
            sqlCommand.Parameters.AddWithValue("@LessonName", text_lectureName.Text);
            sqlCommand.Parameters.AddWithValue("@LessonCode", text_lectureCode.Text);
            try
            {
                SqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                SqlConnection.Close();
                RefreshLectureData();
                MessageBox.Show("Ders başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu!", ex.Message);
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                text_lectureName.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                text_lectureCode.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            }
        }
        private void btnGuncelleLecture_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Table_Lectures SET LessonName=@LessonName, LessonCode=@LessonCode WHERE LessonID=@LessonID", SqlConnection);
                cmd.Parameters.AddWithValue("@LessonID", Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
                cmd.Parameters.AddWithValue("@LessonName", text_lectureName.Text);
                cmd.Parameters.AddWithValue("@LessonCode", text_lectureCode.Text);

                try
                {
                    SqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    SqlConnection.Close();
                    RefreshLectureData();
                    MessageBox.Show("Ders güncelleme işlemi başarılı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu!", ex.Message);
                }
            }
        }

        private void btnSilLecture_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Table_Lectures WHERE LessonID=@LessonID", SqlConnection);
                sqlCommand.Parameters.AddWithValue("@LessonID", Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));

                try
                {
                    SqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SqlConnection.Close();
                    RefreshLectureData();
                    MessageBox.Show("Ders silme işlemi başarılı.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu!", ex.Message);

                }
            }
        }

    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace REGISTERATION_FORM
{
    public partial class Form1 : Form
    {
        // SQL connection string
        private readonly string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=REGISTERATION FORM;Integrated Security=True;Encrypt=false;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewMYTABLE.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMYTABLE.MultiSelect = false;
        }

        // Clear fields
        private void ClearFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtDepartment.Clear();
        }

        // Create button
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtId.Text, out int id))
                {
                    MessageBox.Show("Invalid ID. Please enter a valid integer.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO MYTABLE (studentId, studentName, Section, Department, Permission) VALUES (@Id, @Name, @Email, @Phone, @Department)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record created successfully!");
                    LoadData();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Load data
        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM MYTABLE";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Bind the data to the DataGridView
                dataGridViewMYTABLE.DataSource = dt;

                // Optionally, hide the Id column (if not needed to be shown)
                // dataGridViewMYTABLE.Columns["Id"].Visible = false;
            }
        }

        // Read button
        private void btnRead_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // Update button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtId.Text, out int id))
                {
                    MessageBox.Show("Invalid ID. Please enter a valid integer.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE MYTABLE SET Name=@Name, Email=@Email, Phone=@Phone, Department=@Department WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record updated successfully!");
                    LoadData();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMYTABLE.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record from the table to delete.");
                return;
            }

            try
            {
                DataGridViewRow selectedRow = dataGridViewMYTABLE.SelectedRows[0];
                var idValue = selectedRow.Cells["studentId"].Value;

                if (idValue == null || !int.TryParse(idValue.ToString(), out int id))
                {
                    MessageBox.Show("Invalid ID selected.");
                    return;
                }

                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this record?",
                                                             "Confirm Delete",
                                                             MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM MYTABLE WHERE studentId=@Id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Id", id);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                            MessageBox.Show("Record deleted successfully!");
                        else
                            MessageBox.Show("Record not found.");

                        LoadData();
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Grid view
        private void dataGridViewMYTABLE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMYTABLE.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id"].Value?.ToString();
                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();
                txtDepartment.Text = row.Cells["Department"].Value?.ToString();
            }
        }

        private void btnUpdate_Clic(object sender, EventArgs e)
        {

        }
    }
}

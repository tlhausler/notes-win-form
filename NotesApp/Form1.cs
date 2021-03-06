using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class Form1 : Form
    {
        
        DataTable noteTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // instantiate Data Table and add columns
            // Set noteTable as data source for data grid view on form
            noteTable = new DataTable();
            noteTable.Columns.Add("Title", typeof(String));
            noteTable.Columns.Add("Notes", typeof(String));
            dgvNoteList.DataSource = noteTable;

            // formatting the data grid view
            dgvNoteList.Columns["Notes"].Visible = false;
            dgvNoteList.Columns["Title"].Width = 245;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // save note to data grid view and clear the title and note boxes
            noteTable.Rows.Add(txtBoxTitle.Text, txtBoxNote.Text);
            txtBoxTitle.Clear();
            txtBoxNote.Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // clear title and note text boxes for creating new note
            txtBoxTitle.Clear();
            txtBoxNote.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // retrieve data from table and place in title and note text fields
            int index = dgvNoteList.CurrentCell.RowIndex;

            if (index > -1)
            {
                txtBoxTitle.Text = noteTable.Rows[index].ItemArray[0].ToString();
                txtBoxNote.Text = noteTable.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // delete selected note from table by index
            int index = dgvNoteList.CurrentCell.RowIndex;

            noteTable.Rows[index].Delete();
        }
    }
}

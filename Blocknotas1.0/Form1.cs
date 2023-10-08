using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blocknotas1._0
{
    public partial class Form1 : Form
    {
        List<Note> _notes = new List<Note>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows != null) //to verify if one of the row was seleted 
            {
                //new varible to store the new element selected 
                var title = dataGridView1.SelectedCells[0].Value.ToString(); //we invoke the datagrid and the cell selected 
                var notes = GetNotesBytitle(title);

                tbtitle.Text = title;
                tbnotes.Text = notes;
            }
        }

        private void btndelete_Click(object sender, EventArgs e) //delete code 
        {
            if (dataGridView1.SelectedRows != null)
            {
                var title = dataGridView1.SelectedCells[0].Value.ToString();
                DeleteBytitle(title);
                

                PopulateNotes();
            }
        }

        private void DeleteBytitle(string title)//method to delete note 
        {
            Note notetoremove = null; //we inintialize a new variable 

            foreach (var note in _notes)
            {
                if (note.Title == title)
                    notetoremove = note;
            }

            if (notetoremove != null)
                _notes.Remove(notetoremove);

        }

        private string GetNotesBytitle(string title) //to read the note by title this is the new whn it save on data source 
        {
            var notes = string.Empty;
            
            foreach(var note in _notes)
            {
                if (note.Title == title)
                    notes = note.Notes;
            }

            return notes;
        }
        
        private void btnadd_Click(object sender, EventArgs e) //to new notes and we the method of the data source 
        {
            if(!string.IsNullOrEmpty(tbtitle.Text) &&
                !string.IsNullOrEmpty(tbnotes.Text))
            {
                var notes = new Note();
                notes.Title = tbtitle.Text;
                notes.Notes = tbnotes.Text;

                _notes.Add(notes);

                PopulateNotes();
                ClearForm();
            }
            
        }

        private void PopulateNotes() //Data source for the form 
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = _notes;
            dataGridView1.DataSource = bs;
        }

        private void ClearForm() //this method is to clear the form 
        {
            tbtitle.Text=string.Empty;
            tbnotes.Text = string.Empty;
            tbtitle.Focus();
        }

        private void btnnew_Click(object sender, EventArgs e) //new notes 
        {
            
            ClearForm();
        }

        
    }
}

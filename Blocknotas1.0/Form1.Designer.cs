namespace Blocknotas1._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1title = new System.Windows.Forms.Label();
            this.label2note = new System.Windows.Forms.Label();
            this.tbtitle = new System.Windows.Forms.TextBox();
            this.tbnotes = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1title
            // 
            this.label1title.AutoSize = true;
            this.label1title.Location = new System.Drawing.Point(54, 31);
            this.label1title.Name = "label1title";
            this.label1title.Size = new System.Drawing.Size(33, 16);
            this.label1title.TabIndex = 0;
            this.label1title.Text = "Title";
            // 
            // label2note
            // 
            this.label2note.AutoSize = true;
            this.label2note.Location = new System.Drawing.Point(54, 92);
            this.label2note.Name = "label2note";
            this.label2note.Size = new System.Drawing.Size(43, 16);
            this.label2note.TabIndex = 1;
            this.label2note.Text = "Notes";
            // 
            // tbtitle
            // 
            this.tbtitle.Location = new System.Drawing.Point(149, 31);
            this.tbtitle.Multiline = true;
            this.tbtitle.Name = "tbtitle";
            this.tbtitle.Size = new System.Drawing.Size(351, 27);
            this.tbtitle.TabIndex = 2;
            // 
            // tbnotes
            // 
            this.tbnotes.Location = new System.Drawing.Point(149, 92);
            this.tbnotes.Multiline = true;
            this.tbnotes.Name = "tbnotes";
            this.tbnotes.Size = new System.Drawing.Size(351, 367);
            this.tbnotes.TabIndex = 3;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(149, 465);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(120, 35);
            this.btnnew.TabIndex = 4;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(376, 465);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(124, 35);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(561, 465);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(127, 35);
            this.btnread.TabIndex = 6;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(769, 465);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(123, 35);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.noteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(561, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(331, 428);
            this.dataGridView1.TabIndex = 8;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 200;
            // 
            // noteBindingSource
            // 
            this.noteBindingSource.DataSource = typeof(Blocknotas1._0.Note);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 523);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.tbnotes);
            this.Controls.Add(this.tbtitle);
            this.Controls.Add(this.label2note);
            this.Controls.Add(this.label1title);
            this.Name = "Form1";
            this.Text = "Block Notes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1title;
        private System.Windows.Forms.Label label2note;
        private System.Windows.Forms.TextBox tbtitle;
        private System.Windows.Forms.TextBox tbnotes;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource noteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
    }
}


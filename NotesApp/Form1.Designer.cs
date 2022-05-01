
namespace NotesApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblNoteList = new System.Windows.Forms.Label();
            this.dgvNoteList = new System.Windows.Forms.DataGridView();
            this.panelMain = new System.Windows.Forms.Panel();
            this.txtBoxNote = new System.Windows.Forms.TextBox();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoteList)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(32, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(32, 152);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(32, 187);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(32, 320);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblNoteList
            // 
            this.lblNoteList.AutoSize = true;
            this.lblNoteList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoteList.Location = new System.Drawing.Point(563, 21);
            this.lblNoteList.Name = "lblNoteList";
            this.lblNoteList.Size = new System.Drawing.Size(107, 24);
            this.lblNoteList.TabIndex = 2;
            this.lblNoteList.Text = "Your Notes:";
            // 
            // dgvNoteList
            // 
            this.dgvNoteList.AllowUserToAddRows = false;
            this.dgvNoteList.AllowUserToDeleteRows = false;
            this.dgvNoteList.AllowUserToResizeColumns = false;
            this.dgvNoteList.AllowUserToResizeRows = false;
            this.dgvNoteList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoteList.Location = new System.Drawing.Point(563, 48);
            this.dgvNoteList.Name = "dgvNoteList";
            this.dgvNoteList.ReadOnly = true;
            this.dgvNoteList.RowHeadersVisible = false;
            this.dgvNoteList.RowHeadersWidth = 51;
            this.dgvNoteList.RowTemplate.Height = 29;
            this.dgvNoteList.Size = new System.Drawing.Size(250, 466);
            this.dgvNoteList.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.txtBoxNote);
            this.panelMain.Controls.Add(this.txtBoxTitle);
            this.panelMain.Controls.Add(this.lblNote);
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.dgvNoteList);
            this.panelMain.Controls.Add(this.lblNoteList);
            this.panelMain.Location = new System.Drawing.Point(154, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(841, 535);
            this.panelMain.TabIndex = 0;
            // 
            // txtBoxNote
            // 
            this.txtBoxNote.Location = new System.Drawing.Point(32, 103);
            this.txtBoxNote.Multiline = true;
            this.txtBoxNote.Name = "txtBoxNote";
            this.txtBoxNote.Size = new System.Drawing.Size(490, 411);
            this.txtBoxNote.TabIndex = 7;
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(32, 48);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(490, 27);
            this.txtBoxTitle.TabIndex = 6;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNote.Location = new System.Drawing.Point(32, 78);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(51, 24);
            this.lblNote.TabIndex = 5;
            this.lblNote.Text = "Note";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(32, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(47, 24);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 559);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoteList)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblNoteList;
        private System.Windows.Forms.DataGridView dgvNoteList;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txtBoxNote;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblTitle;
    }
}


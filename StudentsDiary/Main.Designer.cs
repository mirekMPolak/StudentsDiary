namespace StudentsDiary
{
    partial class Main
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvDiary = new System.Windows.Forms.DataGridView();
            this.cbGroupsFiltering = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbStudents = new System.Windows.Forms.GroupBox();
            this.gbGroups = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).BeginInit();
            this.gbStudents.SuspendLayout();
            this.gbGroups.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Location = new System.Drawing.Point(6, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Orange;
            this.btnEdit.Location = new System.Drawing.Point(107, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Coral;
            this.btnDelete.Location = new System.Drawing.Point(216, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.Location = new System.Drawing.Point(48, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(207, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Odśwież wybrane fiitrowanie grupowe";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvDiary
            // 
            this.dgvDiary.AllowUserToAddRows = false;
            this.dgvDiary.AllowUserToDeleteRows = false;
            this.dgvDiary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiary.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiary.Location = new System.Drawing.Point(12, 52);
            this.dgvDiary.Name = "dgvDiary";
            this.dgvDiary.ReadOnly = true;
            this.dgvDiary.RowHeadersVisible = false;
            this.dgvDiary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiary.Size = new System.Drawing.Size(1105, 571);
            this.dgvDiary.TabIndex = 4;
            // 
            // cbGroupsFiltering
            // 
            this.cbGroupsFiltering.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbGroupsFiltering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupsFiltering.Items.AddRange(new object[] {
            "0",
            "1",
            "10",
            "100",
            "2",
            "3",
            "4",
            "5",
            "55",
            "6",
            "7",
            "8",
            "9",
            "Biol-Chem",
            "Górna",
            "Humanistyczna",
            "Mat-Fiz",
            "Nadprogowa",
            "Nadprogramowa",
            "Nieprzypisany",
            "Podprogowa",
            "Programowa",
            "Systemowa",
            "Techniczna",
            "Wszyscy"});
            this.cbGroupsFiltering.Location = new System.Drawing.Point(407, 13);
            this.cbGroupsFiltering.Name = "cbGroupsFiltering";
            this.cbGroupsFiltering.Size = new System.Drawing.Size(121, 21);
            this.cbGroupsFiltering.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wybór uczniów w/g grup;";
            // 
            // gbStudents
            // 
            this.gbStudents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbStudents.Controls.Add(this.btnAdd);
            this.gbStudents.Controls.Add(this.btnEdit);
            this.gbStudents.Controls.Add(this.btnDelete);
            this.gbStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbStudents.Location = new System.Drawing.Point(36, 6);
            this.gbStudents.Name = "gbStudents";
            this.gbStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbStudents.Size = new System.Drawing.Size(370, 40);
            this.gbStudents.TabIndex = 8;
            this.gbStudents.TabStop = false;
            this.gbStudents.Text = "Uczniowie";
            // 
            // gbGroups
            // 
            this.gbGroups.Controls.Add(this.btnRefresh);
            this.gbGroups.Controls.Add(this.label1);
            this.gbGroups.Controls.Add(this.cbGroupsFiltering);
            this.gbGroups.Location = new System.Drawing.Point(568, 6);
            this.gbGroups.Name = "gbGroups";
            this.gbGroups.Size = new System.Drawing.Size(540, 40);
            this.gbGroups.TabIndex = 9;
            this.gbGroups.TabStop = false;
            this.gbGroups.Text = "Grupy";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1129, 635);
            this.Controls.Add(this.gbGroups);
            this.Controls.Add(this.gbStudents);
            this.Controls.Add(this.dgvDiary);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dziennik ucznia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).EndInit();
            this.gbStudents.ResumeLayout(false);
            this.gbGroups.ResumeLayout(false);
            this.gbGroups.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvDiary;
        private System.Windows.Forms.ComboBox cbGroupsFiltering;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbStudents;
        private System.Windows.Forms.GroupBox gbGroups;
    }
}


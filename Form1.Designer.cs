namespace DocumentManagementSystem
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
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.dgvDocument = new System.Windows.Forms.DataGridView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(105, 65);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(375, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // dgvDocument
            // 
            this.dgvDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocument.Location = new System.Drawing.Point(105, 159);
            this.dgvDocument.Name = "dgvDocument";
            this.dgvDocument.Size = new System.Drawing.Size(571, 102);
            this.dgvDocument.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpen.Location = new System.Drawing.Point(105, 109);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(601, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(37, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "INSERT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "SEARCH:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(105, 285);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(375, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.Text = ".";
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(506, 285);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(105, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 106);
            this.dataGridView1.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(37, 455);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total Records";
            // 
            // btnOpen1
            // 
            this.btnOpen1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpen1.Location = new System.Drawing.Point(601, 283);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(75, 23);
            this.btnOpen1.TabIndex = 13;
            this.btnOpen1.Text = "Open";
            this.btnOpen1.UseVisualStyleBackColor = false;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCopy.Location = new System.Drawing.Point(215, 109);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(226, 23);
            this.btnCopy.TabIndex = 14;
            this.btnCopy.Text = "Migrate Data";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete1.Location = new System.Drawing.Point(467, 109);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(75, 23);
            this.btnDelete1.TabIndex = 15;
            this.btnDelete1.Text = "Delete";
            this.btnDelete1.UseVisualStyleBackColor = false;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsert.Location = new System.Drawing.Point(506, 62);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnOpen1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.dgvDocument);
            this.Controls.Add(this.txtFilePath);
            this.Name = "Form1";
            this.Text = "Document Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.DataGridView dgvDocument;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnInsert;
    }
}


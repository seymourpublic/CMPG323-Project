﻿
namespace Project1
{
    partial class TextbooksSoldTxb
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
            this.textbooksDataGridView = new System.Windows.Forms.DataGridView();
            this.TextbookSoldTxb = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextbookSldTxb = new System.Windows.Forms.TextBox();
            this.TextbookNoTxb = new System.Windows.Forms.TextBox();
            this.StudNoTxb = new System.Windows.Forms.TextBox();
            this.DateTxb = new System.Windows.Forms.TextBox();
            this.textbookSoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textbookNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textbooksSoldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.circleDataSet = new Project1.CircleDataSet();
            this.textbooks_soldTableAdapter = new Project1.CircleDataSetTableAdapters.Textbooks_soldTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.textbooksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textbooksSoldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textbooksDataGridView
            // 
            this.textbooksDataGridView.AutoGenerateColumns = false;
            this.textbooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.textbooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textbookSoldDataGridViewTextBoxColumn,
            this.textbookNoDataGridViewTextBoxColumn,
            this.studentNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.textbooksDataGridView.DataSource = this.textbooksSoldBindingSource;
            this.textbooksDataGridView.Location = new System.Drawing.Point(31, 12);
            this.textbooksDataGridView.Name = "textbooksDataGridView";
            this.textbooksDataGridView.RowHeadersWidth = 51;
            this.textbooksDataGridView.RowTemplate.Height = 24;
            this.textbooksDataGridView.Size = new System.Drawing.Size(548, 261);
            this.textbooksDataGridView.TabIndex = 21;
            // 
            // TextbookSoldTxb
            // 
            this.TextbookSoldTxb.Location = new System.Drawing.Point(296, 307);
            this.TextbookSoldTxb.Name = "TextbookSoldTxb";
            this.TextbookSoldTxb.Size = new System.Drawing.Size(107, 66);
            this.TextbookSoldTxb.TabIndex = 30;
            this.TextbookSoldTxb.Text = "Insert Sold Book";
            this.TextbookSoldTxb.UseVisualStyleBackColor = true;
            this.TextbookSoldTxb.Click += new System.EventHandler(this.TextbookSoldTxb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Student No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Textbook No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Textbook Sold";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextbookSldTxb
            // 
            this.TextbookSldTxb.Location = new System.Drawing.Point(147, 286);
            this.TextbookSldTxb.Name = "TextbookSldTxb";
            this.TextbookSldTxb.Size = new System.Drawing.Size(100, 22);
            this.TextbookSldTxb.TabIndex = 25;
            this.TextbookSldTxb.TextChanged += new System.EventHandler(this.TextbookSldTxb_TextChanged);
            // 
            // TextbookNoTxb
            // 
            this.TextbookNoTxb.Location = new System.Drawing.Point(147, 329);
            this.TextbookNoTxb.Name = "TextbookNoTxb";
            this.TextbookNoTxb.Size = new System.Drawing.Size(100, 22);
            this.TextbookNoTxb.TabIndex = 24;
            // 
            // StudNoTxb
            // 
            this.StudNoTxb.Location = new System.Drawing.Point(147, 373);
            this.StudNoTxb.Name = "StudNoTxb";
            this.StudNoTxb.Size = new System.Drawing.Size(100, 22);
            this.StudNoTxb.TabIndex = 23;
            // 
            // DateTxb
            // 
            this.DateTxb.Location = new System.Drawing.Point(147, 412);
            this.DateTxb.Name = "DateTxb";
            this.DateTxb.Size = new System.Drawing.Size(100, 22);
            this.DateTxb.TabIndex = 22;
            // 
            // textbookSoldDataGridViewTextBoxColumn
            // 
            this.textbookSoldDataGridViewTextBoxColumn.DataPropertyName = "Textbook sold";
            this.textbookSoldDataGridViewTextBoxColumn.HeaderText = "Textbook sold";
            this.textbookSoldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.textbookSoldDataGridViewTextBoxColumn.Name = "textbookSoldDataGridViewTextBoxColumn";
            this.textbookSoldDataGridViewTextBoxColumn.Width = 125;
            // 
            // textbookNoDataGridViewTextBoxColumn
            // 
            this.textbookNoDataGridViewTextBoxColumn.DataPropertyName = "Textbook no";
            this.textbookNoDataGridViewTextBoxColumn.HeaderText = "Textbook no";
            this.textbookNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.textbookNoDataGridViewTextBoxColumn.Name = "textbookNoDataGridViewTextBoxColumn";
            this.textbookNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentNoDataGridViewTextBoxColumn
            // 
            this.studentNoDataGridViewTextBoxColumn.DataPropertyName = "Student no";
            this.studentNoDataGridViewTextBoxColumn.HeaderText = "Student no";
            this.studentNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNoDataGridViewTextBoxColumn.Name = "studentNoDataGridViewTextBoxColumn";
            this.studentNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // textbooksSoldBindingSource
            // 
            this.textbooksSoldBindingSource.DataMember = "Textbooks sold";
            this.textbooksSoldBindingSource.DataSource = this.circleDataSet;
            // 
            // circleDataSet
            // 
            this.circleDataSet.DataSetName = "CircleDataSet";
            this.circleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textbooks_soldTableAdapter
            // 
            this.textbooks_soldTableAdapter.ClearBeforeFill = true;
            // 
            // TextbooksSoldTxb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextbookSoldTxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextbookSldTxb);
            this.Controls.Add(this.TextbookNoTxb);
            this.Controls.Add(this.StudNoTxb);
            this.Controls.Add(this.DateTxb);
            this.Controls.Add(this.textbooksDataGridView);
            this.Name = "TextbooksSoldTxb";
            this.Text = "TextbooksSold";
            this.Load += new System.EventHandler(this.TextbooksSold_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textbooksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textbooksSoldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView textbooksDataGridView;
        private CircleDataSet circleDataSet;
        private System.Windows.Forms.BindingSource textbooksSoldBindingSource;
        private CircleDataSetTableAdapters.Textbooks_soldTableAdapter textbooks_soldTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn textbookSoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textbookNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button TextbookSoldTxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextbookSldTxb;
        private System.Windows.Forms.TextBox TextbookNoTxb;
        private System.Windows.Forms.TextBox StudNoTxb;
        private System.Windows.Forms.TextBox DateTxb;
    }
}
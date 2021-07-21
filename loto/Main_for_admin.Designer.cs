namespace loto
{
    partial class Main_for_admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ticketidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kombowinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allTicketsforadminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lotteryDataSet1 = new loto.lotteryDataSet1();
            this.allTickets_for_adminTableAdapter = new loto.lotteryDataSet1TableAdapters.AllTickets_for_adminTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.typeidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raffledateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alltypesforadminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lotteryDataSet2 = new loto.lotteryDataSet2();
            this.all_types_for_adminTableAdapter = new loto.lotteryDataSet2TableAdapters.all_types_for_adminTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label_for_delete_type = new System.Windows.Forms.Label();
            this.textBox_for_delete_type = new System.Windows.Forms.TextBox();
            this.button_for_delete_type = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allTicketsforadminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotteryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alltypesforadminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotteryDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketidDataGridViewTextBoxColumn,
            this.typeidDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.winDataGridViewTextBoxColumn,
            this.kombowinDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.allTicketsforadminBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(810, 189);
            this.dataGridView1.TabIndex = 1;
            // 
            // ticketidDataGridViewTextBoxColumn
            // 
            this.ticketidDataGridViewTextBoxColumn.DataPropertyName = "ticket_id";
            this.ticketidDataGridViewTextBoxColumn.HeaderText = "ticket_id";
            this.ticketidDataGridViewTextBoxColumn.Name = "ticketidDataGridViewTextBoxColumn";
            this.ticketidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeidDataGridViewTextBoxColumn
            // 
            this.typeidDataGridViewTextBoxColumn.DataPropertyName = "type_id";
            this.typeidDataGridViewTextBoxColumn.HeaderText = "type_id";
            this.typeidDataGridViewTextBoxColumn.Name = "typeidDataGridViewTextBoxColumn";
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // winDataGridViewTextBoxColumn
            // 
            this.winDataGridViewTextBoxColumn.DataPropertyName = "win";
            this.winDataGridViewTextBoxColumn.HeaderText = "win";
            this.winDataGridViewTextBoxColumn.Name = "winDataGridViewTextBoxColumn";
            // 
            // kombowinDataGridViewTextBoxColumn
            // 
            this.kombowinDataGridViewTextBoxColumn.DataPropertyName = "kombo_win";
            this.kombowinDataGridViewTextBoxColumn.HeaderText = "kombo_win";
            this.kombowinDataGridViewTextBoxColumn.Name = "kombowinDataGridViewTextBoxColumn";
            // 
            // allTicketsforadminBindingSource
            // 
            this.allTicketsforadminBindingSource.DataMember = "AllTickets_for_admin";
            this.allTicketsforadminBindingSource.DataSource = this.lotteryDataSet1;
            // 
            // lotteryDataSet1
            // 
            this.lotteryDataSet1.DataSetName = "lotteryDataSet1";
            this.lotteryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allTickets_for_adminTableAdapter
            // 
            this.allTickets_for_adminTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeidDataGridViewTextBoxColumn1,
            this.typenameDataGridViewTextBoxColumn,
            this.raffledateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.xpriceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.alltypesforadminBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(15, 242);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(810, 189);
            this.dataGridView2.TabIndex = 2;
            // 
            // typeidDataGridViewTextBoxColumn1
            // 
            this.typeidDataGridViewTextBoxColumn1.DataPropertyName = "type_id";
            this.typeidDataGridViewTextBoxColumn1.HeaderText = "type_id";
            this.typeidDataGridViewTextBoxColumn1.Name = "typeidDataGridViewTextBoxColumn1";
            this.typeidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // typenameDataGridViewTextBoxColumn
            // 
            this.typenameDataGridViewTextBoxColumn.DataPropertyName = "type_name";
            this.typenameDataGridViewTextBoxColumn.HeaderText = "type_name";
            this.typenameDataGridViewTextBoxColumn.Name = "typenameDataGridViewTextBoxColumn";
            // 
            // raffledateDataGridViewTextBoxColumn
            // 
            this.raffledateDataGridViewTextBoxColumn.DataPropertyName = "raffle_date";
            this.raffledateDataGridViewTextBoxColumn.HeaderText = "raffle_date";
            this.raffledateDataGridViewTextBoxColumn.Name = "raffledateDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // xpriceDataGridViewTextBoxColumn
            // 
            this.xpriceDataGridViewTextBoxColumn.DataPropertyName = "x_price";
            this.xpriceDataGridViewTextBoxColumn.HeaderText = "x_price";
            this.xpriceDataGridViewTextBoxColumn.Name = "xpriceDataGridViewTextBoxColumn";
            // 
            // alltypesforadminBindingSource
            // 
            this.alltypesforadminBindingSource.DataMember = "all_types_for_admin";
            this.alltypesforadminBindingSource.DataSource = this.lotteryDataSet2;
            // 
            // lotteryDataSet2
            // 
            this.lotteryDataSet2.DataSetName = "lotteryDataSet2";
            this.lotteryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // all_types_for_adminTableAdapter
            // 
            this.all_types_for_adminTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(831, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 189);
            this.button1.TabIndex = 3;
            this.button1.Text = "добавить билеты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(831, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 189);
            this.button2.TabIndex = 4;
            this.button2.Text = "добавить типы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 437);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(477, 90);
            this.button3.TabIndex = 5;
            this.button3.Text = "обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_for_delete_type
            // 
            this.label_for_delete_type.AutoSize = true;
            this.label_for_delete_type.Location = new System.Drawing.Point(499, 438);
            this.label_for_delete_type.Name = "label_for_delete_type";
            this.label_for_delete_type.Size = new System.Drawing.Size(223, 17);
            this.label_for_delete_type.TabIndex = 6;
            this.label_for_delete_type.Text = "Id типа который хотите удалить:";
            // 
            // textBox_for_delete_type
            // 
            this.textBox_for_delete_type.Location = new System.Drawing.Point(728, 438);
            this.textBox_for_delete_type.Name = "textBox_for_delete_type";
            this.textBox_for_delete_type.Size = new System.Drawing.Size(97, 22);
            this.textBox_for_delete_type.TabIndex = 7;
            // 
            // button_for_delete_type
            // 
            this.button_for_delete_type.Location = new System.Drawing.Point(728, 465);
            this.button_for_delete_type.Name = "button_for_delete_type";
            this.button_for_delete_type.Size = new System.Drawing.Size(97, 35);
            this.button_for_delete_type.TabIndex = 8;
            this.button_for_delete_type.Text = "удалить";
            this.button_for_delete_type.UseVisualStyleBackColor = true;
            this.button_for_delete_type.Click += new System.EventHandler(this.button_for_delete_type_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "обратите внимание, что ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "неразыгранные типы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "не удалятся";
            // 
            // Main_for_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 539);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_for_delete_type);
            this.Controls.Add(this.textBox_for_delete_type);
            this.Controls.Add(this.label_for_delete_type);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Main_for_admin";
            this.Text = "Main_for_admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_for_admin_FormClosed);
            this.Load += new System.EventHandler(this.Main_for_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allTicketsforadminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotteryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alltypesforadminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotteryDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private lotteryDataSet1 lotteryDataSet1;
        private System.Windows.Forms.BindingSource allTicketsforadminBindingSource;
        private lotteryDataSet1TableAdapters.AllTickets_for_adminTableAdapter allTickets_for_adminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kombowinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private lotteryDataSet2 lotteryDataSet2;
        private System.Windows.Forms.BindingSource alltypesforadminBindingSource;
        private lotteryDataSet2TableAdapters.all_types_for_adminTableAdapter all_types_for_adminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raffledateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_for_delete_type;
        private System.Windows.Forms.TextBox textBox_for_delete_type;
        private System.Windows.Forms.Button button_for_delete_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
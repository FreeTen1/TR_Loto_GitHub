namespace loto
{
    partial class Main_for_user
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
            this.label_user_login = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_cash = new System.Windows.Forms.Label();
            this.button_for_cash = new System.Windows.Forms.Button();
            this.button_for_buy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ticketsforbuyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lotteryDataSet5 = new loto.lotteryDataSet5();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_for_buy = new System.Windows.Forms.TextBox();
            this.tickets_for_buyTableAdapter = new loto.lotteryDataSet5TableAdapters.tickets_for_buyTableAdapter();
            this.textBox_for_cash = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lotteryDataSet3 = new loto.lotteryDataSet3();
            this.ticketsforbuyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tickets_for_buyTableAdapter1 = new loto.lotteryDataSet3TableAdapters.tickets_for_buyTableAdapter();
            this.номерБилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.акцияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРозыгрышаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.множительВыигрышаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsforbuyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotteryDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotteryDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsforbuyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пользователь:";
            // 
            // label_user_login
            // 
            this.label_user_login.AutoSize = true;
            this.label_user_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_user_login.Location = new System.Drawing.Point(154, 9);
            this.label_user_login.Name = "label_user_login";
            this.label_user_login.Size = new System.Drawing.Size(130, 20);
            this.label_user_login.TabIndex = 1;
            this.label_user_login.Text = "label_user_login";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(786, 230);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Список ваших билетов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ваш счёт:";
            // 
            // label_cash
            // 
            this.label_cash.AutoSize = true;
            this.label_cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cash.Location = new System.Drawing.Point(112, 29);
            this.label_cash.Name = "label_cash";
            this.label_cash.Size = new System.Drawing.Size(45, 20);
            this.label_cash.TabIndex = 5;
            this.label_cash.Text = "cash";
            // 
            // button_for_cash
            // 
            this.button_for_cash.Location = new System.Drawing.Point(253, 49);
            this.button_for_cash.Name = "button_for_cash";
            this.button_for_cash.Size = new System.Drawing.Size(141, 22);
            this.button_for_cash.TabIndex = 6;
            this.button_for_cash.Text = "Пополнить счёт";
            this.button_for_cash.UseVisualStyleBackColor = true;
            this.button_for_cash.Click += new System.EventHandler(this.button_for_cash_Click);
            // 
            // button_for_buy
            // 
            this.button_for_buy.Location = new System.Drawing.Point(338, 637);
            this.button_for_buy.Name = "button_for_buy";
            this.button_for_buy.Size = new System.Drawing.Size(100, 44);
            this.button_for_buy.TabIndex = 9;
            this.button_for_buy.Text = "купить";
            this.button_for_buy.UseVisualStyleBackColor = true;
            this.button_for_buy.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Список доступных билетов";
            // 
            // ticketsforbuyBindingSource
            // 
            this.ticketsforbuyBindingSource.DataMember = "tickets_for_buy";
            this.ticketsforbuyBindingSource.DataSource = this.lotteryDataSet5;
            // 
            // lotteryDataSet5
            // 
            this.lotteryDataSet5.DataSetName = "lotteryDataSet5";
            this.lotteryDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 609);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(319, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Введите номер билета который хотите купить:";
            // 
            // textBox_for_buy
            // 
            this.textBox_for_buy.Location = new System.Drawing.Point(338, 609);
            this.textBox_for_buy.Name = "textBox_for_buy";
            this.textBox_for_buy.Size = new System.Drawing.Size(100, 22);
            this.textBox_for_buy.TabIndex = 12;
            // 
            // tickets_for_buyTableAdapter
            // 
            this.tickets_for_buyTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_for_cash
            // 
            this.textBox_for_cash.Location = new System.Drawing.Point(147, 49);
            this.textBox_for_cash.Name = "textBox_for_cash";
            this.textBox_for_cash.Size = new System.Drawing.Size(100, 22);
            this.textBox_for_cash.TabIndex = 13;
            this.textBox_for_cash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "введите сумму:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерБилетаDataGridViewTextBoxColumn,
            this.акцияDataGridViewTextBoxColumn,
            this.датаРозыгрышаDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.множительВыигрышаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.ticketsforbuyBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(16, 376);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(786, 227);
            this.dataGridView2.TabIndex = 15;
            // 
            // lotteryDataSet3
            // 
            this.lotteryDataSet3.DataSetName = "lotteryDataSet3";
            this.lotteryDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsforbuyBindingSource1
            // 
            this.ticketsforbuyBindingSource1.DataMember = "tickets_for_buy";
            this.ticketsforbuyBindingSource1.DataSource = this.lotteryDataSet3;
            // 
            // tickets_for_buyTableAdapter1
            // 
            this.tickets_for_buyTableAdapter1.ClearBeforeFill = true;
            // 
            // номерБилетаDataGridViewTextBoxColumn
            // 
            this.номерБилетаDataGridViewTextBoxColumn.DataPropertyName = "Номер билета";
            this.номерБилетаDataGridViewTextBoxColumn.HeaderText = "Номер билета";
            this.номерБилетаDataGridViewTextBoxColumn.Name = "номерБилетаDataGridViewTextBoxColumn";
            // 
            // акцияDataGridViewTextBoxColumn
            // 
            this.акцияDataGridViewTextBoxColumn.DataPropertyName = "Акция";
            this.акцияDataGridViewTextBoxColumn.HeaderText = "Акция";
            this.акцияDataGridViewTextBoxColumn.Name = "акцияDataGridViewTextBoxColumn";
            // 
            // датаРозыгрышаDataGridViewTextBoxColumn
            // 
            this.датаРозыгрышаDataGridViewTextBoxColumn.DataPropertyName = "Дата розыгрыша";
            this.датаРозыгрышаDataGridViewTextBoxColumn.HeaderText = "Дата розыгрыша";
            this.датаРозыгрышаDataGridViewTextBoxColumn.Name = "датаРозыгрышаDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // множительВыигрышаDataGridViewTextBoxColumn
            // 
            this.множительВыигрышаDataGridViewTextBoxColumn.DataPropertyName = "Множитель выигрыша";
            this.множительВыигрышаDataGridViewTextBoxColumn.HeaderText = "Множитель выигрыша";
            this.множительВыигрышаDataGridViewTextBoxColumn.Name = "множительВыигрышаDataGridViewTextBoxColumn";
            // 
            // Main_for_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 696);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_for_cash);
            this.Controls.Add(this.textBox_for_buy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_for_buy);
            this.Controls.Add(this.button_for_cash);
            this.Controls.Add(this.label_cash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_user_login);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_for_user";
            this.ShowIcon = false;
            this.Text = "Лото";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_for_user_FormClosed);
            this.Load += new System.EventHandler(this.Main_for_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsforbuyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotteryDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotteryDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsforbuyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_user_login;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_cash;
        private System.Windows.Forms.Button button_for_cash;
        private System.Windows.Forms.Button button_for_buy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_for_buy;
        private lotteryDataSet5 lotteryDataSet5;
        private System.Windows.Forms.BindingSource ticketsforbuyBindingSource;
        private lotteryDataSet5TableAdapters.tickets_for_buyTableAdapter tickets_for_buyTableAdapter;
        private System.Windows.Forms.TextBox textBox_for_cash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private lotteryDataSet3 lotteryDataSet3;
        private System.Windows.Forms.BindingSource ticketsforbuyBindingSource1;
        private lotteryDataSet3TableAdapters.tickets_for_buyTableAdapter tickets_for_buyTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерБилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn акцияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРозыгрышаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn множительВыигрышаDataGridViewTextBoxColumn;
    }
}
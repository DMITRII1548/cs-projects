namespace test_Database
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.price_field = new System.Windows.Forms.TextBox();
            this.postavka_field = new System.Windows.Forms.TextBox();
            this.count_field = new System.Windows.Forms.TextBox();
            this.type_of_field = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.new_record_btn = new System.Windows.Forms.Button();
            this.search_field = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.delete_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Controls.Add(this.search_field);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 42);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 234);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.price_field);
            this.panel2.Controls.Add(this.postavka_field);
            this.panel2.Controls.Add(this.count_field);
            this.panel2.Controls.Add(this.type_of_field);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 187);
            this.panel2.TabIndex = 2;
            // 
            // price_field
            // 
            this.price_field.Location = new System.Drawing.Point(74, 135);
            this.price_field.Name = "price_field";
            this.price_field.Size = new System.Drawing.Size(100, 20);
            this.price_field.TabIndex = 7;
            // 
            // postavka_field
            // 
            this.postavka_field.Location = new System.Drawing.Point(75, 94);
            this.postavka_field.Name = "postavka_field";
            this.postavka_field.Size = new System.Drawing.Size(100, 20);
            this.postavka_field.TabIndex = 6;
            // 
            // count_field
            // 
            this.count_field.Location = new System.Drawing.Point(75, 53);
            this.count_field.Name = "count_field";
            this.count_field.Size = new System.Drawing.Size(100, 20);
            this.count_field.TabIndex = 5;
            // 
            // type_of_field
            // 
            this.type_of_field.Location = new System.Drawing.Point(74, 12);
            this.type_of_field.Name = "type_of_field";
            this.type_of_field.Size = new System.Drawing.Size(100, 20);
            this.type_of_field.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Поставщик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип товара";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.save_btn);
            this.panel3.Controls.Add(this.delete_btn);
            this.panel3.Controls.Add(this.new_record_btn);
            this.panel3.Location = new System.Drawing.Point(227, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 187);
            this.panel3.TabIndex = 3;
            // 
            // new_record_btn
            // 
            this.new_record_btn.Location = new System.Drawing.Point(16, 15);
            this.new_record_btn.Name = "new_record_btn";
            this.new_record_btn.Size = new System.Drawing.Size(170, 34);
            this.new_record_btn.TabIndex = 0;
            this.new_record_btn.Text = "Новая запись";
            this.new_record_btn.UseVisualStyleBackColor = true;
            this.new_record_btn.Click += new System.EventHandler(this.new_record_btn_Click);
            // 
            // search_field
            // 
            this.search_field.Location = new System.Drawing.Point(12, 12);
            this.search_field.Name = "search_field";
            this.search_field.Size = new System.Drawing.Size(100, 20);
            this.search_field.TabIndex = 0;
            this.search_field.TextChanged += new System.EventHandler(this.search_field_TextChanged);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(118, 11);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Найти";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(16, 64);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(170, 34);
            this.delete_btn.TabIndex = 1;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(16, 117);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(170, 34);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price_field;
        private System.Windows.Forms.TextBox postavka_field;
        private System.Windows.Forms.TextBox count_field;
        private System.Windows.Forms.TextBox type_of_field;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button new_record_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_field;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button save_btn;
    }
}
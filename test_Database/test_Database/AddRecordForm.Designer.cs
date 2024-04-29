namespace test_Database
{
    partial class AddRecordForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.type_of_field = new System.Windows.Forms.TextBox();
            this.count_field = new System.Windows.Forms.TextBox();
            this.postavka_field = new System.Windows.Forms.TextBox();
            this.price_field = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.cancel_btn);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.price_field);
            this.panel1.Controls.Add(this.postavka_field);
            this.panel1.Controls.Add(this.count_field);
            this.panel1.Controls.Add(this.type_of_field);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 297);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить запись";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Поставщик";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Поставщик";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Цена";
            // 
            // type_of_field
            // 
            this.type_of_field.Location = new System.Drawing.Point(87, 69);
            this.type_of_field.Name = "type_of_field";
            this.type_of_field.Size = new System.Drawing.Size(100, 20);
            this.type_of_field.TabIndex = 5;
            // 
            // count_field
            // 
            this.count_field.Location = new System.Drawing.Point(87, 108);
            this.count_field.Name = "count_field";
            this.count_field.Size = new System.Drawing.Size(100, 20);
            this.count_field.TabIndex = 6;
            // 
            // postavka_field
            // 
            this.postavka_field.Location = new System.Drawing.Point(87, 150);
            this.postavka_field.Name = "postavka_field";
            this.postavka_field.Size = new System.Drawing.Size(100, 20);
            this.postavka_field.TabIndex = 7;
            // 
            // price_field
            // 
            this.price_field.Location = new System.Drawing.Point(87, 191);
            this.price_field.Name = "price_field";
            this.price_field.Size = new System.Drawing.Size(100, 20);
            this.price_field.TabIndex = 8;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(20, 257);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(101, 257);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 10;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // AddRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 323);
            this.Controls.Add(this.panel1);
            this.Name = "AddRecordForm";
            this.Text = "AddRecordForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox price_field;
        private System.Windows.Forms.TextBox postavka_field;
        private System.Windows.Forms.TextBox count_field;
        private System.Windows.Forms.TextBox type_of_field;
    }
}
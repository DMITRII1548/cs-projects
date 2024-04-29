namespace Session2_xx
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.sort_by_time_combo_box = new System.Windows.Forms.ComboBox();
            this.apply_btn = new System.Windows.Forms.Button();
            this.g = new System.Windows.Forms.Label();
            this.date_field = new System.Windows.Forms.DateTimePicker();
            this.flight_number_filed = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.to_combo_box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.from_combo_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edit_btn = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flight_number_filed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage flight schedules";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.sort_by_time_combo_box);
            this.panel1.Controls.Add(this.apply_btn);
            this.panel1.Controls.Add(this.g);
            this.panel1.Controls.Add(this.date_field);
            this.panel1.Controls.Add(this.flight_number_filed);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.to_combo_box);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.from_combo_box);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(5, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 177);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Soft by time";
            // 
            // sort_by_time_combo_box
            // 
            this.sort_by_time_combo_box.FormattingEnabled = true;
            this.sort_by_time_combo_box.Location = new System.Drawing.Point(354, 126);
            this.sort_by_time_combo_box.Name = "sort_by_time_combo_box";
            this.sort_by_time_combo_box.Size = new System.Drawing.Size(121, 21);
            this.sort_by_time_combo_box.TabIndex = 12;
            // 
            // apply_btn
            // 
            this.apply_btn.Location = new System.Drawing.Point(495, 125);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(75, 23);
            this.apply_btn.TabIndex = 11;
            this.apply_btn.Text = "Apply";
            this.apply_btn.UseVisualStyleBackColor = true;
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Location = new System.Drawing.Point(24, 130);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(30, 13);
            this.g.TabIndex = 10;
            this.g.Text = "Date";
            // 
            // date_field
            // 
            this.date_field.Location = new System.Drawing.Point(60, 124);
            this.date_field.Name = "date_field";
            this.date_field.Size = new System.Drawing.Size(200, 20);
            this.date_field.TabIndex = 9;
            this.date_field.Value = new System.DateTime(1997, 1, 1, 0, 0, 0, 0);
            // 
            // flight_number_filed
            // 
            this.flight_number_filed.Location = new System.Drawing.Point(495, 62);
            this.flight_number_filed.Name = "flight_number_filed";
            this.flight_number_filed.Size = new System.Drawing.Size(120, 20);
            this.flight_number_filed.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Flight Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // to_combo_box
            // 
            this.to_combo_box.FormattingEnabled = true;
            this.to_combo_box.Location = new System.Drawing.Point(251, 61);
            this.to_combo_box.Name = "to_combo_box";
            this.to_combo_box.Size = new System.Drawing.Size(121, 21);
            this.to_combo_box.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "From";
            // 
            // from_combo_box
            // 
            this.from_combo_box.FormattingEnabled = true;
            this.from_combo_box.Location = new System.Drawing.Point(57, 61);
            this.from_combo_box.Name = "from_combo_box";
            this.from_combo_box.Size = new System.Drawing.Size(121, 21);
            this.from_combo_box.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filter by";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 243);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(789, 335);
            this.dataGridView2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.refresh_btn);
            this.panel2.Controls.Add(this.edit_btn);
            this.panel2.Controls.Add(this.cancel);
            this.panel2.Location = new System.Drawing.Point(5, 591);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 40);
            this.panel2.TabIndex = 3;
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(107, 8);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 1;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Red;
            this.cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancel.Location = new System.Drawing.Point(15, 8);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Cancel flight";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Image = ((System.Drawing.Image)(resources.GetObject("refresh_btn.Image")));
            this.refresh_btn.Location = new System.Drawing.Point(188, 5);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(33, 32);
            this.refresh_btn.TabIndex = 2;
            this.refresh_btn.TabStop = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flight_number_filed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refresh_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox from_combo_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox to_combo_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown flight_number_filed;
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.Label g;
        private System.Windows.Forms.DateTimePicker date_field;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sort_by_time_combo_box;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.PictureBox refresh_btn;
    }
}


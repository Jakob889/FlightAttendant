namespace FlightAttendant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datePicker_arr = new System.Windows.Forms.DateTimePicker();
            this.datePicker_dep = new System.Windows.Forms.DateTimePicker();
            this.Dropdown_Destination = new System.Windows.Forms.ComboBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "Table";
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(995, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataSource = typeof(System.Data.DataTable);
            // 
            // datePicker_arr
            // 
            this.datePicker_arr.AccessibleName = "Departing";
            this.datePicker_arr.Location = new System.Drawing.Point(501, 164);
            this.datePicker_arr.Name = "datePicker_arr";
            this.datePicker_arr.Size = new System.Drawing.Size(257, 22);
            this.datePicker_arr.TabIndex = 2;
            // 
            // datePicker_dep
            // 
            this.datePicker_dep.AccessibleName = "Returning";
            this.datePicker_dep.Location = new System.Drawing.Point(794, 164);
            this.datePicker_dep.Name = "datePicker_dep";
            this.datePicker_dep.Size = new System.Drawing.Size(262, 22);
            this.datePicker_dep.TabIndex = 3;
            // 
            // Dropdown_Destination
            // 
            this.Dropdown_Destination.AccessibleName = "From";
            this.Dropdown_Destination.FormattingEnabled = true;
            this.Dropdown_Destination.Location = new System.Drawing.Point(61, 162);
            this.Dropdown_Destination.Name = "Dropdown_Destination";
            this.Dropdown_Destination.Size = new System.Drawing.Size(232, 24);
            this.Dropdown_Destination.TabIndex = 5;
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.Location = new System.Drawing.Point(869, 242);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(187, 50);
            this.button_Search.TabIndex = 6;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.ButtonSearch);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hotel + Flight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(497, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Checkin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(790, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Checkout";
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataSource = typeof(FlightAttendant.FlightServiceReferenceEmirates.Flight);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(59, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Test Daten zwischen 1. und 31. März";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 747);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.Dropdown_Destination);
            this.Controls.Add(this.datePicker_dep);
            this.Controls.Add(this.datePicker_arr);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "FlightAttendent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private System.Windows.Forms.DateTimePicker datePicker_arr;
        private System.Windows.Forms.DateTimePicker datePicker_dep;
        private System.Windows.Forms.ComboBox Dropdown_Destination;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private System.Windows.Forms.Label label2;
    }
}


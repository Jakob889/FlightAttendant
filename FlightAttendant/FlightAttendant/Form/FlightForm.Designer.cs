namespace FlightAttendant
{
    partial class FlightForm
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
            this.dataGridView_flights = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_flights)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_flights
            // 
            this.dataGridView_flights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_flights.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_flights.Name = "dataGridView_flights";
            this.dataGridView_flights.RowHeadersWidth = 51;
            this.dataGridView_flights.RowTemplate.Height = 24;
            this.dataGridView_flights.Size = new System.Drawing.Size(1053, 333);
            this.dataGridView_flights.TabIndex = 0;
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 351);
            this.Controls.Add(this.dataGridView_flights);
            this.Name = "FlightForm";
            this.Text = "Flights";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_flights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_flights;
    }
}
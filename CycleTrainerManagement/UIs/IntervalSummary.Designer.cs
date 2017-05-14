namespace CycleTrainerManagement.UIs
{
    partial class IntervalSummaryForm
    {
        /// <IntervalSummary>
        /// Required designer variable.
        /// </IntervalSummary>
        private System.ComponentModel.IContainer components = null;

        /// <IntervalSummary>
        /// Clean up any resources being used.
        /// </IntervalSummary>
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

        /// <IntervalSummary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </IntervalSummary>
        private void InitializeComponent()
        {
            this.dataGridViewIntervalSummary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIntervalSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIntervalSummary
            // 
            this.dataGridViewIntervalSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewIntervalSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIntervalSummary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewIntervalSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIntervalSummary.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewIntervalSummary.Name = "dataGridViewIntervalSummary";
            this.dataGridViewIntervalSummary.Size = new System.Drawing.Size(814, 404);
            this.dataGridViewIntervalSummary.TabIndex = 0;
            // 
            // IntervalSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 428);
            this.Controls.Add(this.dataGridViewIntervalSummary);
            this.Name = "IntervalSummaryForm";
            this.Text = "IntervalSummaryForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IntervalSummaryForm_FormClosed);
            this.Load += new System.EventHandler(this.IntervalSummaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIntervalSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIntervalSummary;
    }
}
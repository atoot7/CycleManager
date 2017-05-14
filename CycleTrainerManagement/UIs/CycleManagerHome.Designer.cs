namespace CycleTrainerManagement
{
    partial class FrmCycleManagerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCycleManagerHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripStart = new System.Windows.Forms.ToolStripMenuItem();
            this.dataListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphMenuToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedMetrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripStart,
            this.dataListToolStripMenuItem,
            this.graphMenuToolStrip,
            this.summaryToolStripMenuItem,
            this.advancedMetrixToolStripMenuItem,
            this.calenderToolStripMenuItem,
            this.intervalsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuStripStart
            // 
            this.menuStripStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripStart.Name = "menuStripStart";
            this.menuStripStart.Size = new System.Drawing.Size(54, 23);
            this.menuStripStart.Text = "Start";
            this.menuStripStart.Click += new System.EventHandler(this.menuStripStart_Click);
            // 
            // dataListToolStripMenuItem
            // 
            this.dataListToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dataListToolStripMenuItem.Name = "dataListToolStripMenuItem";
            this.dataListToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.dataListToolStripMenuItem.Text = "Data List";
            this.dataListToolStripMenuItem.Click += new System.EventHandler(this.dataListToolStripMenuItem_Click);
            // 
            // graphMenuToolStrip
            // 
            this.graphMenuToolStrip.Font = new System.Drawing.Font("Tahoma", 12F);
            this.graphMenuToolStrip.Name = "graphMenuToolStrip";
            this.graphMenuToolStrip.Size = new System.Drawing.Size(64, 23);
            this.graphMenuToolStrip.Text = "Graph";
            this.graphMenuToolStrip.Click += new System.EventHandler(this.graphMenuToolStrip_Click);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // advancedMetrixToolStripMenuItem
            // 
            this.advancedMetrixToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.advancedMetrixToolStripMenuItem.Name = "advancedMetrixToolStripMenuItem";
            this.advancedMetrixToolStripMenuItem.Size = new System.Drawing.Size(131, 23);
            this.advancedMetrixToolStripMenuItem.Text = "TSS Calculation";
            this.advancedMetrixToolStripMenuItem.Click += new System.EventHandler(this.advancedMetrixToolStripMenuItem_Click);
            // 
            // calenderToolStripMenuItem
            // 
            this.calenderToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.calenderToolStripMenuItem.Name = "calenderToolStripMenuItem";
            this.calenderToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.calenderToolStripMenuItem.Text = "Calender";
            this.calenderToolStripMenuItem.Click += new System.EventHandler(this.calenderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // intervalsToolStripMenuItem
            // 
            this.intervalsToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.intervalsToolStripMenuItem.Name = "intervalsToolStripMenuItem";
            this.intervalsToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.intervalsToolStripMenuItem.Text = "Intervals";
            this.intervalsToolStripMenuItem.Click += new System.EventHandler(this.intervalsToolStripMenuItem_Click);
            // 
            // FrmCycleManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 486);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmCycleManagerHome";
            this.Text = "Cycle Manager Trainer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCycleManagerHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripStart;
        private System.Windows.Forms.ToolStripMenuItem graphMenuToolStrip;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedMetrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intervalsToolStripMenuItem;
    }
}


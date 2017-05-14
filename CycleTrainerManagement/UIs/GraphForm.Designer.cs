namespace CycleTrainerManagement.UIs
{
    partial class GraphForm
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
            this.zedGraphCycleHeartRate = new ZedGraph.ZedGraphControl();
            this.checkBoxHr = new System.Windows.Forms.CheckBox();
            this.checkBoxSpeed = new System.Windows.Forms.CheckBox();
            this.checkBoxCadence = new System.Windows.Forms.CheckBox();
            this.checkBoxAltitude = new System.Windows.Forms.CheckBox();
            this.checkBoxPower = new System.Windows.Forms.CheckBox();
            this.checkBoxBalace = new System.Windows.Forms.CheckBox();
            this.zedGraphControlSpeed = new ZedGraph.ZedGraphControl();
            this.zedGraphControlAltitude = new ZedGraph.ZedGraphControl();
            this.zedGraphControlCadence = new ZedGraph.ZedGraphControl();
            this.zedGraphControlPower = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // zedGraphCycleHeartRate
            // 
            this.zedGraphCycleHeartRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphCycleHeartRate.Location = new System.Drawing.Point(12, 45);
            this.zedGraphCycleHeartRate.Name = "zedGraphCycleHeartRate";
            this.zedGraphCycleHeartRate.ScrollGrace = 0D;
            this.zedGraphCycleHeartRate.ScrollMaxX = 0D;
            this.zedGraphCycleHeartRate.ScrollMaxY = 0D;
            this.zedGraphCycleHeartRate.ScrollMaxY2 = 0D;
            this.zedGraphCycleHeartRate.ScrollMinX = 0D;
            this.zedGraphCycleHeartRate.ScrollMinY = 0D;
            this.zedGraphCycleHeartRate.ScrollMinY2 = 0D;
            this.zedGraphCycleHeartRate.Size = new System.Drawing.Size(668, 231);
            this.zedGraphCycleHeartRate.TabIndex = 0;
            // 
            // checkBoxHr
            // 
            this.checkBoxHr.AutoSize = true;
            this.checkBoxHr.Checked = true;
            this.checkBoxHr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHr.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHr.Location = new System.Drawing.Point(14, 13);
            this.checkBoxHr.Name = "checkBoxHr";
            this.checkBoxHr.Size = new System.Drawing.Size(102, 26);
            this.checkBoxHr.TabIndex = 2;
            this.checkBoxHr.Text = "Heart Rate";
            this.checkBoxHr.UseVisualStyleBackColor = true;
            this.checkBoxHr.CheckedChanged += new System.EventHandler(this.checkBoxHr_CheckedChanged);
            // 
            // checkBoxSpeed
            // 
            this.checkBoxSpeed.AutoSize = true;
            this.checkBoxSpeed.Checked = true;
            this.checkBoxSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSpeed.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSpeed.Location = new System.Drawing.Point(140, 13);
            this.checkBoxSpeed.Name = "checkBoxSpeed";
            this.checkBoxSpeed.Size = new System.Drawing.Size(68, 26);
            this.checkBoxSpeed.TabIndex = 3;
            this.checkBoxSpeed.Text = "Speed";
            this.checkBoxSpeed.UseVisualStyleBackColor = true;
            this.checkBoxSpeed.CheckedChanged += new System.EventHandler(this.checkBoxSpeed_CheckedChanged);
            // 
            // checkBoxCadence
            // 
            this.checkBoxCadence.AutoSize = true;
            this.checkBoxCadence.Checked = true;
            this.checkBoxCadence.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCadence.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCadence.Location = new System.Drawing.Point(226, 13);
            this.checkBoxCadence.Name = "checkBoxCadence";
            this.checkBoxCadence.Size = new System.Drawing.Size(83, 26);
            this.checkBoxCadence.TabIndex = 4;
            this.checkBoxCadence.Text = "Cadence";
            this.checkBoxCadence.UseVisualStyleBackColor = true;
            this.checkBoxCadence.CheckedChanged += new System.EventHandler(this.checkBoxCadence_CheckedChanged);
            // 
            // checkBoxAltitude
            // 
            this.checkBoxAltitude.AutoSize = true;
            this.checkBoxAltitude.Checked = true;
            this.checkBoxAltitude.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAltitude.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAltitude.Location = new System.Drawing.Point(330, 13);
            this.checkBoxAltitude.Name = "checkBoxAltitude";
            this.checkBoxAltitude.Size = new System.Drawing.Size(83, 26);
            this.checkBoxAltitude.TabIndex = 5;
            this.checkBoxAltitude.Text = "Altitude";
            this.checkBoxAltitude.UseVisualStyleBackColor = true;
            this.checkBoxAltitude.CheckedChanged += new System.EventHandler(this.checkBoxAltitude_CheckedChanged);
            // 
            // checkBoxPower
            // 
            this.checkBoxPower.AutoSize = true;
            this.checkBoxPower.Checked = true;
            this.checkBoxPower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPower.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPower.Location = new System.Drawing.Point(434, 13);
            this.checkBoxPower.Name = "checkBoxPower";
            this.checkBoxPower.Size = new System.Drawing.Size(71, 26);
            this.checkBoxPower.TabIndex = 6;
            this.checkBoxPower.Text = "Power";
            this.checkBoxPower.UseVisualStyleBackColor = true;
            this.checkBoxPower.CheckedChanged += new System.EventHandler(this.checkBoxPower_CheckedChanged);
            // 
            // checkBoxBalace
            // 
            this.checkBoxBalace.AutoSize = true;
            this.checkBoxBalace.Checked = true;
            this.checkBoxBalace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBalace.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBalace.Location = new System.Drawing.Point(524, 13);
            this.checkBoxBalace.Name = "checkBoxBalace";
            this.checkBoxBalace.Size = new System.Drawing.Size(121, 26);
            this.checkBoxBalace.TabIndex = 7;
            this.checkBoxBalace.Text = "Padal Balance";
            this.checkBoxBalace.UseVisualStyleBackColor = true;
            this.checkBoxBalace.Visible = false;
            this.checkBoxBalace.CheckedChanged += new System.EventHandler(this.checkBoxBalace_CheckedChanged);
            // 
            // zedGraphControlSpeed
            // 
            this.zedGraphControlSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControlSpeed.Location = new System.Drawing.Point(686, 45);
            this.zedGraphControlSpeed.Name = "zedGraphControlSpeed";
            this.zedGraphControlSpeed.ScrollGrace = 0D;
            this.zedGraphControlSpeed.ScrollMaxX = 0D;
            this.zedGraphControlSpeed.ScrollMaxY = 0D;
            this.zedGraphControlSpeed.ScrollMaxY2 = 0D;
            this.zedGraphControlSpeed.ScrollMinX = 0D;
            this.zedGraphControlSpeed.ScrollMinY = 0D;
            this.zedGraphControlSpeed.ScrollMinY2 = 0D;
            this.zedGraphControlSpeed.Size = new System.Drawing.Size(610, 231);
            this.zedGraphControlSpeed.TabIndex = 8;
            // 
            // zedGraphControlAltitude
            // 
            this.zedGraphControlAltitude.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControlAltitude.Location = new System.Drawing.Point(686, 282);
            this.zedGraphControlAltitude.Name = "zedGraphControlAltitude";
            this.zedGraphControlAltitude.ScrollGrace = 0D;
            this.zedGraphControlAltitude.ScrollMaxX = 0D;
            this.zedGraphControlAltitude.ScrollMaxY = 0D;
            this.zedGraphControlAltitude.ScrollMaxY2 = 0D;
            this.zedGraphControlAltitude.ScrollMinX = 0D;
            this.zedGraphControlAltitude.ScrollMinY = 0D;
            this.zedGraphControlAltitude.ScrollMinY2 = 0D;
            this.zedGraphControlAltitude.Size = new System.Drawing.Size(610, 249);
            this.zedGraphControlAltitude.TabIndex = 10;
            // 
            // zedGraphControlCadence
            // 
            this.zedGraphControlCadence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControlCadence.Location = new System.Drawing.Point(12, 282);
            this.zedGraphControlCadence.Name = "zedGraphControlCadence";
            this.zedGraphControlCadence.ScrollGrace = 0D;
            this.zedGraphControlCadence.ScrollMaxX = 0D;
            this.zedGraphControlCadence.ScrollMaxY = 0D;
            this.zedGraphControlCadence.ScrollMaxY2 = 0D;
            this.zedGraphControlCadence.ScrollMinX = 0D;
            this.zedGraphControlCadence.ScrollMinY = 0D;
            this.zedGraphControlCadence.ScrollMinY2 = 0D;
            this.zedGraphControlCadence.Size = new System.Drawing.Size(668, 249);
            this.zedGraphControlCadence.TabIndex = 9;
            // 
            // zedGraphControlPower
            // 
            this.zedGraphControlPower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControlPower.Location = new System.Drawing.Point(14, 537);
            this.zedGraphControlPower.Name = "zedGraphControlPower";
            this.zedGraphControlPower.ScrollGrace = 0D;
            this.zedGraphControlPower.ScrollMaxX = 0D;
            this.zedGraphControlPower.ScrollMaxY = 0D;
            this.zedGraphControlPower.ScrollMaxY2 = 0D;
            this.zedGraphControlPower.ScrollMinX = 0D;
            this.zedGraphControlPower.ScrollMinY = 0D;
            this.zedGraphControlPower.ScrollMinY2 = 0D;
            this.zedGraphControlPower.Size = new System.Drawing.Size(1282, 192);
            this.zedGraphControlPower.TabIndex = 11;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 741);
            this.Controls.Add(this.zedGraphControlPower);
            this.Controls.Add(this.zedGraphControlAltitude);
            this.Controls.Add(this.zedGraphControlCadence);
            this.Controls.Add(this.zedGraphControlSpeed);
            this.Controls.Add(this.checkBoxBalace);
            this.Controls.Add(this.checkBoxPower);
            this.Controls.Add(this.checkBoxAltitude);
            this.Controls.Add(this.checkBoxCadence);
            this.Controls.Add(this.checkBoxSpeed);
            this.Controls.Add(this.checkBoxHr);
            this.Controls.Add(this.zedGraphCycleHeartRate);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GraphForm_FormClosed);
            this.Load += new System.EventHandler(this.GraphForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphCycleHeartRate;
        private System.Windows.Forms.CheckBox checkBoxHr;
        private System.Windows.Forms.CheckBox checkBoxSpeed;
        private System.Windows.Forms.CheckBox checkBoxCadence;
        private System.Windows.Forms.CheckBox checkBoxAltitude;
        private System.Windows.Forms.CheckBox checkBoxPower;
        private System.Windows.Forms.CheckBox checkBoxBalace;
        private ZedGraph.ZedGraphControl zedGraphControlSpeed;
        private ZedGraph.ZedGraphControl zedGraphControlAltitude;
        private ZedGraph.ZedGraphControl zedGraphControlCadence;
        private ZedGraph.ZedGraphControl zedGraphControlPower;
    }
}
namespace JustinTime
{
    partial class frmMain
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.txtTaskInput = new System.Windows.Forms.TextBox();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.stsBar = new System.Windows.Forms.StatusStrip();
            this.stsLblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsLblStats = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstView = new System.Windows.Forms.ListView();
            this.colTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBIsWorking = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.pnlMainMenu.SuspendLayout();
            this.stsBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // txtTaskInput
            // 
            this.txtTaskInput.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtTaskInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskInput.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTaskInput.ForeColor = System.Drawing.Color.Black;
            this.txtTaskInput.Location = new System.Drawing.Point(81, 8);
            this.txtTaskInput.Name = "txtTaskInput";
            this.txtTaskInput.Size = new System.Drawing.Size(359, 26);
            this.txtTaskInput.TabIndex = 0;
            this.txtTaskInput.Text = "What is your next task?";
            this.txtTaskInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTaskInput.Click += new System.EventHandler(this.txtTaskInput_Click);
            this.txtTaskInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTaskInput_KeyUp);
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMainMenu.Controls.Add(this.btnSave);
            this.pnlMainMenu.Controls.Add(this.btnLoad);
            this.pnlMainMenu.Controls.Add(this.btnStop);
            this.pnlMainMenu.Controls.Add(this.btnStart);
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(75, 363);
            this.pnlMainMenu.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Location = new System.Drawing.Point(12, 120);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLoad.Location = new System.Drawing.Point(12, 80);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(50, 40);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnStop.Location = new System.Drawing.Point(12, 40);
            this.btnStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(50, 40);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnStart.Location = new System.Drawing.Point(12, 0);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(50, 40);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // stsBar
            // 
            this.stsBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsLblInfo,
            this.stsSeparator,
            this.stsLblStats});
            this.stsBar.Location = new System.Drawing.Point(0, 282);
            this.stsBar.Name = "stsBar";
            this.stsBar.Size = new System.Drawing.Size(528, 22);
            this.stsBar.TabIndex = 2;
            // 
            // stsLblInfo
            // 
            this.stsLblInfo.Name = "stsLblInfo";
            this.stsLblInfo.Size = new System.Drawing.Size(178, 17);
            this.stsLblInfo.Text = "Welcome in the 4th dimension...";
            // 
            // stsSeparator
            // 
            this.stsSeparator.Name = "stsSeparator";
            this.stsSeparator.Size = new System.Drawing.Size(10, 17);
            this.stsSeparator.Text = "|";
            // 
            // stsLblStats
            // 
            this.stsLblStats.Name = "stsLblStats";
            this.stsLblStats.Size = new System.Drawing.Size(193, 17);
            this.stsLblStats.Text = "WorkTasks = 0 | NonWorkTasks = 0";
            // 
            // lstView
            // 
            this.lstView.BackColor = System.Drawing.Color.DimGray;
            this.lstView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTask,
            this.colStart,
            this.colEnd,
            this.colDuration});
            this.lstView.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lstView.GridLines = true;
            this.lstView.Location = new System.Drawing.Point(81, 40);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(442, 230);
            this.lstView.TabIndex = 3;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            this.lstView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstView_ColumnClick);
            // 
            // colTask
            // 
            this.colTask.Text = "Task";
            this.colTask.Width = 200;
            // 
            // colStart
            // 
            this.colStart.Text = "Start";
            this.colStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStart.Width = 80;
            // 
            // colEnd
            // 
            this.colEnd.Text = "End";
            this.colEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEnd.Width = 80;
            // 
            // colDuration
            // 
            this.colDuration.Text = "Duration";
            this.colDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDuration.Width = 80;
            // 
            // chBIsWorking
            // 
            this.chBIsWorking.AutoSize = true;
            this.chBIsWorking.Checked = true;
            this.chBIsWorking.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBIsWorking.ForeColor = System.Drawing.Color.NavajoWhite;
            this.chBIsWorking.Location = new System.Drawing.Point(447, 14);
            this.chBIsWorking.Name = "chBIsWorking";
            this.chBIsWorking.Size = new System.Drawing.Size(76, 17);
            this.chBIsWorking.TabIndex = 6;
            this.chBIsWorking.Text = "WorkTask";
            this.chBIsWorking.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(528, 304);
            this.Controls.Add(this.chBIsWorking);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.stsBar);
            this.Controls.Add(this.pnlMainMenu);
            this.Controls.Add(this.txtTaskInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "JustinTime";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.pnlMainMenu.ResumeLayout(false);
            this.stsBar.ResumeLayout(false);
            this.stsBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtTaskInput;
        private System.Windows.Forms.StatusStrip stsBar;
        private System.Windows.Forms.ToolStripStatusLabel stsLblInfo;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.ColumnHeader colTask;
        private System.Windows.Forms.ColumnHeader colStart;
        private System.Windows.Forms.ColumnHeader colEnd;
        private System.Windows.Forms.ColumnHeader colDuration;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chBIsWorking;
        private System.Windows.Forms.ToolStripStatusLabel stsLblStats;
        private System.Windows.Forms.ToolStripStatusLabel stsSeparator;
    }
}


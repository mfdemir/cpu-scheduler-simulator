namespace CPU_Scheduler_Simulator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.processesDataGrid = new System.Windows.Forms.DataGridView();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IBT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RBT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.stepsDataGrid = new System.Windows.Forms.DataGridView();
            this.buttonStep = new System.Windows.Forms.Button();
            this.labelDuration = new System.Windows.Forms.Label();
            this.graph = new ZedGraph.ZedGraphControl();
            this.buttonSimulate = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxProcessCount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMaxArrivalTime = new System.Windows.Forms.TextBox();
            this.textBoxMaxBurstTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.schedulersDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this._delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this._type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scheduler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.processesDataGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // processesDataGrid
            // 
            this.processesDataGrid.AllowUserToAddRows = false;
            this.processesDataGrid.AllowUserToDeleteRows = false;
            this.processesDataGrid.AllowUserToResizeColumns = false;
            this.processesDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.processesDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.processesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.processesDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.processesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P,
            this.IBT,
            this.RBT,
            this.AT});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.processesDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.processesDataGrid.Location = new System.Drawing.Point(146, 181);
            this.processesDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.processesDataGrid.MultiSelect = false;
            this.processesDataGrid.Name = "processesDataGrid";
            this.processesDataGrid.ReadOnly = true;
            this.processesDataGrid.RowHeadersVisible = false;
            this.processesDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.processesDataGrid.RowTemplate.Height = 24;
            this.processesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.processesDataGrid.Size = new System.Drawing.Size(166, 499);
            this.processesDataGrid.TabIndex = 2;
            // 
            // P
            // 
            this.P.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.P.HeaderText = "P";
            this.P.Name = "P";
            this.P.ReadOnly = true;
            this.P.ToolTipText = "Process";
            // 
            // IBT
            // 
            this.IBT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IBT.HeaderText = "IBT";
            this.IBT.Name = "IBT";
            this.IBT.ReadOnly = true;
            this.IBT.ToolTipText = "Initial Burst Time";
            // 
            // RBT
            // 
            this.RBT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RBT.HeaderText = "RBT";
            this.RBT.Name = "RBT";
            this.RBT.ReadOnly = true;
            this.RBT.ToolTipText = "Remaining Burst Time";
            // 
            // AT
            // 
            this.AT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AT.HeaderText = "AT";
            this.AT.Name = "AT";
            this.AT.ReadOnly = true;
            this.AT.ToolTipText = "Arrival Time";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 688);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1507, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(1500, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // stepsDataGrid
            // 
            this.stepsDataGrid.AllowUserToAddRows = false;
            this.stepsDataGrid.AllowUserToDeleteRows = false;
            this.stepsDataGrid.AllowUserToResizeColumns = false;
            this.stepsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.stepsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.stepsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stepsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.stepsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stepsDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.stepsDataGrid.Location = new System.Drawing.Point(0, 25);
            this.stepsDataGrid.Name = "stepsDataGrid";
            this.stepsDataGrid.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stepsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.stepsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.stepsDataGrid.RowTemplate.ReadOnly = true;
            this.stepsDataGrid.Size = new System.Drawing.Size(1501, 154);
            this.stepsDataGrid.TabIndex = 5;
            // 
            // buttonStep
            // 
            this.buttonStep.Enabled = false;
            this.buttonStep.Location = new System.Drawing.Point(8, 19);
            this.buttonStep.Name = "buttonStep";
            this.buttonStep.Size = new System.Drawing.Size(129, 23);
            this.buttonStep.TabIndex = 6;
            this.buttonStep.Text = "Simulate One Step";
            this.buttonStep.UseVisualStyleBackColor = true;
            this.buttonStep.Click += new System.EventHandler(this.buttonStep_Click);
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(5, 28);
            this.labelDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(98, 13);
            this.labelDuration.TabIndex = 4;
            this.labelDuration.Text = "Set Process Count:";
            // 
            // graph
            // 
            this.graph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graph.EditButtons = System.Windows.Forms.MouseButtons.None;
            this.graph.EditModifierKeys = System.Windows.Forms.Keys.None;
            this.graph.IsAntiAlias = true;
            this.graph.IsEnableHPan = false;
            this.graph.IsEnableHZoom = false;
            this.graph.IsEnableVPan = false;
            this.graph.IsEnableVZoom = false;
            this.graph.IsPrintFillPage = false;
            this.graph.IsPrintKeepAspectRatio = false;
            this.graph.IsPrintScaleAll = false;
            this.graph.IsShowCopyMessage = false;
            this.graph.IsShowPointValues = true;
            this.graph.IsZoomOnMouseCenter = true;
            this.graph.LinkButtons = System.Windows.Forms.MouseButtons.None;
            this.graph.Location = new System.Drawing.Point(317, 181);
            this.graph.Name = "graph";
            this.graph.ScrollGrace = 0D;
            this.graph.ScrollMaxX = 0D;
            this.graph.ScrollMaxY = 0D;
            this.graph.ScrollMaxY2 = 0D;
            this.graph.ScrollMinX = 0D;
            this.graph.ScrollMinY = 0D;
            this.graph.ScrollMinY2 = 0D;
            this.graph.Size = new System.Drawing.Size(1184, 501);
            this.graph.TabIndex = 7;
            // 
            // buttonSimulate
            // 
            this.buttonSimulate.Enabled = false;
            this.buttonSimulate.Location = new System.Drawing.Point(8, 48);
            this.buttonSimulate.Name = "buttonSimulate";
            this.buttonSimulate.Size = new System.Drawing.Size(129, 30);
            this.buttonSimulate.TabIndex = 8;
            this.buttonSimulate.Text = "SimulateTill The End";
            this.buttonSimulate.UseVisualStyleBackColor = true;
            this.buttonSimulate.Click += new System.EventHandler(this.buttonSimulate_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(6, 105);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(129, 32);
            this.buttonGenerate.TabIndex = 9;
            this.buttonGenerate.Text = "Generate Proccesses";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxProcessCount
            // 
            this.textBoxProcessCount.Location = new System.Drawing.Point(107, 25);
            this.textBoxProcessCount.Name = "textBoxProcessCount";
            this.textBoxProcessCount.Size = new System.Drawing.Size(28, 20);
            this.textBoxProcessCount.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.buttonGenerate);
            this.groupBox1.Controls.Add(this.textBoxMaxArrivalTime);
            this.groupBox1.Controls.Add(this.textBoxMaxBurstTime);
            this.groupBox1.Controls.Add(this.textBoxProcessCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelDuration);
            this.groupBox1.Location = new System.Drawing.Point(0, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 227);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate";
            // 
            // textBoxMaxArrivalTime
            // 
            this.textBoxMaxArrivalTime.Location = new System.Drawing.Point(107, 77);
            this.textBoxMaxArrivalTime.Name = "textBoxMaxArrivalTime";
            this.textBoxMaxArrivalTime.Size = new System.Drawing.Size(28, 20);
            this.textBoxMaxArrivalTime.TabIndex = 11;
            // 
            // textBoxMaxBurstTime
            // 
            this.textBoxMaxBurstTime.Location = new System.Drawing.Point(107, 51);
            this.textBoxMaxBurstTime.Name = "textBoxMaxBurstTime";
            this.textBoxMaxBurstTime.Size = new System.Drawing.Size(28, 20);
            this.textBoxMaxBurstTime.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max Arrival Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Max Burst Time:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.schedulersDataGrid);
            this.groupBox2.Controls.Add(this.buttonStep);
            this.groupBox2.Controls.Add(this.buttonSimulate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 354);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simulation";
            // 
            // schedulersDataGrid
            // 
            this.schedulersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.schedulersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedulersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._delete,
            this._type,
            this._color,
            this.Scheduler});
            this.schedulersDataGrid.Location = new System.Drawing.Point(0, 97);
            this.schedulersDataGrid.Name = "schedulersDataGrid";
            this.schedulersDataGrid.RowHeadersVisible = false;
            this.schedulersDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.schedulersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.schedulersDataGrid.Size = new System.Drawing.Size(141, 255);
            this.schedulersDataGrid.TabIndex = 9;
            this.schedulersDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schedulersDataGrid_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Schedulers:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Step Simulation :";
            // 
            // _delete
            // 
            this._delete.FillWeight = 25F;
            this._delete.HeaderText = "";
            this._delete.Name = "_delete";
            // 
            // _type
            // 
            this._type.HeaderText = "Type";
            this._type.Name = "_type";
            this._type.ReadOnly = true;
            this._type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _color
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            this._color.DefaultCellStyle = dataGridViewCellStyle6;
            this._color.FillWeight = 25F;
            this._color.HeaderText = "Color";
            this._color.Name = "_color";
            this._color.ReadOnly = true;
            // 
            // Scheduler
            // 
            this.Scheduler.HeaderText = "Scheduler";
            this.Scheduler.Name = "Scheduler";
            this.Scheduler.ReadOnly = true;
            this.Scheduler.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1507, 710);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.stepsDataGrid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.processesDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "CPU Scheduler Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processesDataGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView processesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn IBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn RBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn AT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView stepsDataGrid;
        private System.Windows.Forms.Button buttonStep;
        private System.Windows.Forms.Label labelDuration;
        private ZedGraph.ZedGraphControl graph;
        private System.Windows.Forms.Button buttonSimulate;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxProcessCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxMaxArrivalTime;
        private System.Windows.Forms.TextBox textBoxMaxBurstTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView schedulersDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewButtonColumn _delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn _type;
        private System.Windows.Forms.DataGridViewTextBoxColumn _color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scheduler;
    }
}


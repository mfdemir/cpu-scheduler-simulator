namespace CPU_Scheduler_Simulator
{
    partial class AddMLFQForm
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
            this.comboBoxQ1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxQ2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxQ3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxQ1
            // 
            this.comboBoxQ1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQ1.FormattingEnabled = true;
            this.comboBoxQ1.Items.AddRange(new object[] {
            "Round Robbin",
            "First Come First Serve"});
            this.comboBoxQ1.Location = new System.Drawing.Point(12, 25);
            this.comboBoxQ1.Name = "comboBoxQ1";
            this.comboBoxQ1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQ1.TabIndex = 0;
            this.comboBoxQ1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Queue 1:";
            // 
            // comboBoxQ2
            // 
            this.comboBoxQ2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQ2.FormattingEnabled = true;
            this.comboBoxQ2.Items.AddRange(new object[] {
            "Round Robbin",
            "First Come First Serve"});
            this.comboBoxQ2.Location = new System.Drawing.Point(12, 65);
            this.comboBoxQ2.Name = "comboBoxQ2";
            this.comboBoxQ2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQ2.TabIndex = 0;
            this.comboBoxQ2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Queue 2:";
            // 
            // comboBoxQ3
            // 
            this.comboBoxQ3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQ3.FormattingEnabled = true;
            this.comboBoxQ3.Items.AddRange(new object[] {
            "Round Robbin",
            "First Come First Serve"});
            this.comboBoxQ3.Location = new System.Drawing.Point(12, 105);
            this.comboBoxQ3.Name = "comboBoxQ3";
            this.comboBoxQ3.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQ3.TabIndex = 0;
            this.comboBoxQ3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Queue 3:";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 133);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(121, 36);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddMLFQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 181);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxQ3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxQ2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxQ1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddMLFQForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Select Queues";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxQ1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxQ2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxQ3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOk;
    }
}
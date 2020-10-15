namespace Tháp_Hà_Nội
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nudDiskCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.lblNumberOfMoves = new System.Windows.Forms.Label();
            this.pnlStimulation = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiskCount)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDiskCount
            // 
            this.nudDiskCount.Location = new System.Drawing.Point(393, 70);
            this.nudDiskCount.Margin = new System.Windows.Forms.Padding(4);
            this.nudDiskCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDiskCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiskCount.Name = "nudDiskCount";
            this.nudDiskCount.Size = new System.Drawing.Size(69, 22);
            this.nudDiskCount.TabIndex = 0;
            this.nudDiskCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiskCount.ValueChanged += new System.EventHandler(this.nudDiskCount_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of disks";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(481, 66);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(4);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(133, 28);
            this.btnSolve.TabIndex = 2;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // lblNumberOfMoves
            // 
            this.lblNumberOfMoves.AutoSize = true;
            this.lblNumberOfMoves.Location = new System.Drawing.Point(616, 99);
            this.lblNumberOfMoves.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfMoves.Name = "lblNumberOfMoves";
            this.lblNumberOfMoves.Size = new System.Drawing.Size(16, 17);
            this.lblNumberOfMoves.TabIndex = 6;
            this.lblNumberOfMoves.Text = "0";
            // 
            // pnlStimulation
            // 
            this.pnlStimulation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlStimulation.Location = new System.Drawing.Point(20, 124);
            this.pnlStimulation.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStimulation.Name = "pnlStimulation";
            this.pnlStimulation.Size = new System.Drawing.Size(1067, 657);
            this.pnlStimulation.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Best of possible moves:";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(638, 66);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(133, 28);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(418, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "THÁP HÀ NỘI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1106, 790);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlStimulation);
            this.Controls.Add(this.lblNumberOfMoves);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudDiskCount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tháp Hà Nội";
            ((System.ComponentModel.ISupportInitialize)(this.nudDiskCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDiskCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label lblNumberOfMoves;
        private System.Windows.Forms.Panel pnlStimulation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label3;
    }
}


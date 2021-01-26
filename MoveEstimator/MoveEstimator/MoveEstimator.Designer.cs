namespace MoveEstimator
{
    partial class MoveEstimator
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
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMiles = new System.Windows.Forms.Label();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(79, 78);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(87, 13);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "Number of Hours";
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(83, 139);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(83, 13);
            this.lblMiles.TabIndex = 1;
            this.lblMiles.Text = "Number of Miles";
            // 
            // btnEstimate
            // 
            this.btnEstimate.Location = new System.Drawing.Point(159, 201);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(75, 23);
            this.btnEstimate.TabIndex = 2;
            this.btnEstimate.Text = "Estimate";
            this.btnEstimate.UseVisualStyleBackColor = true;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(192, 71);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 20);
            this.txtHours.TabIndex = 3;
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(192, 132);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 307);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(377, 45);
            this.lblResult.TabIndex = 5;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MoveEstimator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(393, 384);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.lblHours);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "MoveEstimator";
            this.Text = "Move Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Label lblResult;
    }
}


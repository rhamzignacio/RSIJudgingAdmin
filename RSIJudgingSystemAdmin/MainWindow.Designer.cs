namespace RSIJudgingSystemAdmin
{
    partial class MainWindow
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
            this.btnTop10Scores = new System.Windows.Forms.Button();
            this.btnTop5Scores = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTop10Scores
            // 
            this.btnTop10Scores.Location = new System.Drawing.Point(12, 12);
            this.btnTop10Scores.Name = "btnTop10Scores";
            this.btnTop10Scores.Size = new System.Drawing.Size(165, 23);
            this.btnTop10Scores.TabIndex = 0;
            this.btnTop10Scores.Text = "Top 10 Scores";
            this.btnTop10Scores.UseVisualStyleBackColor = true;
            this.btnTop10Scores.Click += new System.EventHandler(this.btnTop10Scores_Click);
            // 
            // btnTop5Scores
            // 
            this.btnTop5Scores.Location = new System.Drawing.Point(12, 70);
            this.btnTop5Scores.Name = "btnTop5Scores";
            this.btnTop5Scores.Size = new System.Drawing.Size(165, 23);
            this.btnTop5Scores.TabIndex = 1;
            this.btnTop5Scores.Text = "Ranking Scores";
            this.btnTop5Scores.UseVisualStyleBackColor = true;
            this.btnTop5Scores.Click += new System.EventHandler(this.btnTop5Scores_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Top 5 Scores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 103);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTop5Scores);
            this.Controls.Add(this.btnTop10Scores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "Admin 1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTop10Scores;
        private System.Windows.Forms.Button btnTop5Scores;
        private System.Windows.Forms.Button button1;
    }
}
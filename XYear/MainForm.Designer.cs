namespace DaysToNewYear
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

        private void InitializeComponent()
        {
            lblToday = new Label();
            lblNewYear = new Label();
            lblDays = new Label();
            btnRefresh = new Button();
            SuspendLayout();
            // 
            // lblToday
            // 
            lblToday.AutoSize = true;
            lblToday.Font = new Font("Segoe UI", 12F);
            lblToday.Location = new Point(24, 22);
            lblToday.Name = "lblToday";
            lblToday.Size = new Size(72, 21);
            lblToday.TabIndex = 0;
            lblToday.Text = "Сегодня:";
            // 
            // lblNewYear
            // 
            lblNewYear.AutoSize = true;
            lblNewYear.Font = new Font("Segoe UI", 12F);
            lblNewYear.Location = new Point(24, 56);
            lblNewYear.Name = "lblNewYear";
            lblNewYear.Size = new Size(89, 21);
            lblNewYear.TabIndex = 1;
            lblNewYear.Text = "Новый год:";
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblDays.Location = new Point(24, 100);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(145, 37);
            lblDays.TabIndex = 2;
            lblDays.Text = "Осталось:";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 10F);
            btnRefresh.Location = new Point(24, 160);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 34);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Обновить";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 220);
            Controls.Add(btnRefresh);
            Controls.Add(lblDays);
            Controls.Add(lblNewYear);
            Controls.Add(lblToday);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XYear";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblNewYear;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Button btnRefresh;
    }
}
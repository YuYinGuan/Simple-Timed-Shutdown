namespace TimerProject
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.SecondCounter = new System.Windows.Forms.Timer(this.components);
            this.TimeView = new System.Windows.Forms.Label();
            this.Text1 = new System.Windows.Forms.TextBox();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Begin Timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecondCounter
            // 
            this.SecondCounter.Enabled = true;
            this.SecondCounter.Interval = 1000;
            this.SecondCounter.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeView
            // 
            this.TimeView.Location = new System.Drawing.Point(12, 9);
            this.TimeView.Name = "TimeView";
            this.TimeView.Size = new System.Drawing.Size(216, 35);
            this.TimeView.TabIndex = 1;
            this.TimeView.Text = "label1";
            this.TimeView.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TimeView.Click += new System.EventHandler(this.TimeView_Click);
            // 
            // Text1
            // 
            this.Text1.AcceptsReturn = true;
            this.Text1.Location = new System.Drawing.Point(15, 73);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(44, 20);
            this.Text1.TabIndex = 2;
            this.Text1.TextChanged += new System.EventHandler(this.Text1_TextChanged);
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.Location = new System.Drawing.Point(65, 76);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(44, 13);
            this.MinuteLabel.TabIndex = 3;
            this.MinuteLabel.Text = "Minutes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 105);
            this.Controls.Add(this.MinuteLabel);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.TimeView);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Timed Shutdown";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer SecondCounter;
        private System.Windows.Forms.Label TimeView;
        private System.Windows.Forms.TextBox Text1;
        private System.Windows.Forms.Label MinuteLabel;
    }
}


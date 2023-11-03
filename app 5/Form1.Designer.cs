namespace app_5
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
            this.start = new System.Windows.Forms.Button();
            this.tid = new System.Windows.Forms.Label();
            this.starttrykk = new System.Windows.Forms.Button();
            this.sekunder = new System.Windows.Forms.Label();
            this.trykk = new System.Windows.Forms.Label();
            this.clicks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Image = global::app_5.Properties.Resources.stop_talking_shit;
            this.start.Location = new System.Drawing.Point(-109, -99);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(743, 551);
            this.start.TabIndex = 0;
            this.start.Text = "trykk for start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // tid
            // 
            this.tid.AutoSize = true;
            this.tid.Location = new System.Drawing.Point(692, 46);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(19, 13);
            this.tid.TabIndex = 1;
            this.tid.Text = "10";
            // 
            // starttrykk
            // 
            this.starttrykk.Location = new System.Drawing.Point(661, 146);
            this.starttrykk.Name = "starttrykk";
            this.starttrykk.Size = new System.Drawing.Size(111, 66);
            this.starttrykk.TabIndex = 2;
            this.starttrykk.Text = "trykk for start";
            this.starttrykk.UseVisualStyleBackColor = true;
            this.starttrykk.Click += new System.EventHandler(this.starttrykk_Click);
            // 
            // sekunder
            // 
            this.sekunder.AutoSize = true;
            this.sekunder.Location = new System.Drawing.Point(678, 33);
            this.sekunder.Name = "sekunder";
            this.sekunder.Size = new System.Drawing.Size(51, 13);
            this.sekunder.TabIndex = 3;
            this.sekunder.Text = "sekunder";
            // 
            // trykk
            // 
            this.trykk.AutoSize = true;
            this.trykk.Location = new System.Drawing.Point(678, 351);
            this.trykk.Name = "trykk";
            this.trykk.Size = new System.Drawing.Size(62, 13);
            this.trykk.TabIndex = 4;
            this.trykk.Text = "antall clicks";
            // 
            // clicks
            // 
            this.clicks.AutoSize = true;
            this.clicks.Location = new System.Drawing.Point(695, 368);
            this.clicks.Name = "clicks";
            this.clicks.Size = new System.Drawing.Size(13, 13);
            this.clicks.TabIndex = 5;
            this.clicks.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clicks);
            this.Controls.Add(this.trykk);
            this.Controls.Add(this.sekunder);
            this.Controls.Add(this.starttrykk);
            this.Controls.Add(this.tid);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label tid;
        private System.Windows.Forms.Button starttrykk;
        private System.Windows.Forms.Label sekunder;
        private System.Windows.Forms.Label trykk;
        private System.Windows.Forms.Label clicks;
    }
}


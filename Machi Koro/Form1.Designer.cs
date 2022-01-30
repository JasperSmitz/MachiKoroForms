
namespace Machi_Koro
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.p1_Stats = new System.Windows.Forms.TextBox();
            this.p2_Stats = new System.Windows.Forms.TextBox();
            this.p3_Stats = new System.Windows.Forms.TextBox();
            this.p4_Stats = new System.Windows.Forms.TextBox();
            this.p1_Hand = new System.Windows.Forms.TextBox();
            this.p2_Hand = new System.Windows.Forms.TextBox();
            this.p3_Hand = new System.Windows.Forms.TextBox();
            this.p4_Hand = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(27, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "🛒";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button2.Location = new System.Drawing.Point(511, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = " 🎲 ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button3.Location = new System.Drawing.Point(644, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = " 🎲  🎲 ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 398);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(342, 398);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(58, 20);
            this.textBox2.TabIndex = 4;
            // 
            // p1_Stats
            // 
            this.p1_Stats.AccessibleName = "Player 1 Stats";
            this.p1_Stats.Location = new System.Drawing.Point(27, 13);
            this.p1_Stats.Name = "p1_Stats";
            this.p1_Stats.ReadOnly = true;
            this.p1_Stats.Size = new System.Drawing.Size(100, 20);
            this.p1_Stats.TabIndex = 5;
            // 
            // p2_Stats
            // 
            this.p2_Stats.AccessibleName = "Player 2 Stats";
            this.p2_Stats.Location = new System.Drawing.Point(233, 12);
            this.p2_Stats.Name = "p2_Stats";
            this.p2_Stats.ReadOnly = true;
            this.p2_Stats.Size = new System.Drawing.Size(100, 20);
            this.p2_Stats.TabIndex = 6;
            // 
            // p3_Stats
            // 
            this.p3_Stats.AccessibleName = "Player 3 Stats";
            this.p3_Stats.Location = new System.Drawing.Point(439, 13);
            this.p3_Stats.Name = "p3_Stats";
            this.p3_Stats.ReadOnly = true;
            this.p3_Stats.Size = new System.Drawing.Size(100, 20);
            this.p3_Stats.TabIndex = 7;
            // 
            // p4_Stats
            // 
            this.p4_Stats.AccessibleName = "Player 4 Stats";
            this.p4_Stats.Location = new System.Drawing.Point(621, 13);
            this.p4_Stats.Name = "p4_Stats";
            this.p4_Stats.ReadOnly = true;
            this.p4_Stats.Size = new System.Drawing.Size(100, 20);
            this.p4_Stats.TabIndex = 8;
            // 
            // p1_Hand
            // 
            this.p1_Hand.AccessibleName = "Player 1 Hand";
            this.p1_Hand.Location = new System.Drawing.Point(27, 50);
            this.p1_Hand.Multiline = true;
            this.p1_Hand.Name = "p1_Hand";
            this.p1_Hand.ReadOnly = true;
            this.p1_Hand.Size = new System.Drawing.Size(100, 292);
            this.p1_Hand.TabIndex = 9;
            // 
            // p2_Hand
            // 
            this.p2_Hand.AccessibleName = "Player 2 Hand";
            this.p2_Hand.Location = new System.Drawing.Point(233, 50);
            this.p2_Hand.Multiline = true;
            this.p2_Hand.Name = "p2_Hand";
            this.p2_Hand.ReadOnly = true;
            this.p2_Hand.Size = new System.Drawing.Size(100, 292);
            this.p2_Hand.TabIndex = 10;
            // 
            // p3_Hand
            // 
            this.p3_Hand.AccessibleName = "Player 3 Hand";
            this.p3_Hand.Location = new System.Drawing.Point(439, 50);
            this.p3_Hand.Multiline = true;
            this.p3_Hand.Name = "p3_Hand";
            this.p3_Hand.ReadOnly = true;
            this.p3_Hand.Size = new System.Drawing.Size(100, 292);
            this.p3_Hand.TabIndex = 11;
            // 
            // p4_Hand
            // 
            this.p4_Hand.AccessibleName = "Player 4 Hand";
            this.p4_Hand.Location = new System.Drawing.Point(621, 50);
            this.p4_Hand.Multiline = true;
            this.p4_Hand.Name = "p4_Hand";
            this.p4_Hand.ReadOnly = true;
            this.p4_Hand.Size = new System.Drawing.Size(100, 292);
            this.p4_Hand.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p4_Hand);
            this.Controls.Add(this.p3_Hand);
            this.Controls.Add(this.p2_Hand);
            this.Controls.Add(this.p1_Hand);
            this.Controls.Add(this.p4_Stats);
            this.Controls.Add(this.p3_Stats);
            this.Controls.Add(this.p2_Stats);
            this.Controls.Add(this.p1_Stats);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox p1_Stats;
        private System.Windows.Forms.TextBox p2_Stats;
        private System.Windows.Forms.TextBox p3_Stats;
        private System.Windows.Forms.TextBox p4_Stats;
        private System.Windows.Forms.TextBox p1_Hand;
        private System.Windows.Forms.TextBox p2_Hand;
        private System.Windows.Forms.TextBox p3_Hand;
        private System.Windows.Forms.TextBox p4_Hand;
    }
}


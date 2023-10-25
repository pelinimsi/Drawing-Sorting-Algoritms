namespace _230_Sorting_Algorithms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Submit = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.speed_bar = new System.Windows.Forms.TrackBar();
            this.speed_label = new System.Windows.Forms.Label();
            this.speed_label_speed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.speed_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            resources.GetString("listBox1.Items"),
            resources.GetString("listBox1.Items1"),
            resources.GetString("listBox1.Items2"),
            resources.GetString("listBox1.Items3"),
            resources.GetString("listBox1.Items4"),
            resources.GetString("listBox1.Items5"),
            resources.GetString("listBox1.Items6"),
            resources.GetString("listBox1.Items7"),
            resources.GetString("listBox1.Items8"),
            resources.GetString("listBox1.Items9"),
            resources.GetString("listBox1.Items10"),
            resources.GetString("listBox1.Items11"),
            resources.GetString("listBox1.Items12"),
            resources.GetString("listBox1.Items13"),
            resources.GetString("listBox1.Items14"),
            resources.GetString("listBox1.Items15")});
            this.listBox1.Name = "listBox1";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Submit.BackgroundImage = global::_230_Sorting_Algorithms.Properties.Resources.wallpapersden2;
            this.Submit.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.Submit.FlatAppearance.BorderSize = 10;
            resources.ApplyResources(this.Submit, "Submit");
            this.Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Submit.Name = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click_1);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Gray;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.listBox2, "listBox2");
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            resources.GetString("listBox2.Items"),
            resources.GetString("listBox2.Items1"),
            resources.GetString("listBox2.Items2"),
            resources.GetString("listBox2.Items3"),
            resources.GetString("listBox2.Items4"),
            resources.GetString("listBox2.Items5"),
            resources.GetString("listBox2.Items6"),
            resources.GetString("listBox2.Items7"),
            resources.GetString("listBox2.Items8"),
            resources.GetString("listBox2.Items9"),
            resources.GetString("listBox2.Items10"),
            resources.GetString("listBox2.Items11"),
            resources.GetString("listBox2.Items12"),
            resources.GetString("listBox2.Items13"),
            resources.GetString("listBox2.Items14"),
            resources.GetString("listBox2.Items15")});
            this.listBox2.Name = "listBox2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImage = global::_230_Sorting_Algorithms.Properties.Resources.wallpapersden2;
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 6;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.BackColor = System.Drawing.Color.Cyan;
            this.refresh_button.BackgroundImage = global::_230_Sorting_Algorithms.Properties.Resources.wallpapersden_com_neon_gradient_minimalist_wxl;
            resources.ApplyResources(this.refresh_button, "refresh_button");
            this.refresh_button.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.refresh_button.FlatAppearance.BorderSize = 6;
            this.refresh_button.ForeColor = System.Drawing.Color.Cyan;
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.UseVisualStyleBackColor = false;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // speed_bar
            // 
            this.speed_bar.BackColor = System.Drawing.Color.Gray;
            this.speed_bar.Cursor = System.Windows.Forms.Cursors.SizeNS;
            resources.ApplyResources(this.speed_bar, "speed_bar");
            this.speed_bar.Maximum = 100;
            this.speed_bar.Minimum = 1;
            this.speed_bar.Name = "speed_bar";
            this.speed_bar.TickFrequency = 10;
            this.speed_bar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.speed_bar.Value = 10;
            this.speed_bar.Scroll += new System.EventHandler(this.speed_bar_Scroll);
            // 
            // speed_label
            // 
            resources.ApplyResources(this.speed_label, "speed_label");
            this.speed_label.Name = "speed_label";
            // 
            // speed_label_speed
            // 
            resources.ApplyResources(this.speed_label_speed, "speed_label_speed");
            this.speed_label_speed.Name = "speed_label_speed";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::_230_Sorting_Algorithms.Properties.Resources.photo_1563089145_599997674d42;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.speed_label_speed);
            this.Controls.Add(this.speed_bar);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.speed_label);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.speed_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private ListBox listBox1;
        private Button Submit;
        private ListBox listBox2;
        private Button refresh_button;
        private TrackBar speed_bar;
        private Label speed_label;
        private Label speed_label_speed;
        public Button button1;
    }
}
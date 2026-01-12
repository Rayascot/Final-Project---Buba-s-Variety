namespace Final_Project___Buba_s_Variety
{
    partial class chaosForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chaosForm));
            button1 = new Button();
            chaosclicking = new Label();
            bonkClick6 = new Label();
            bonkClick3 = new Label();
            bonkClick5 = new Label();
            bonkClick2 = new Label();
            bonkClick4 = new Label();
            bonkClick1 = new Label();
            bonktick = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.Enabled = false;
            button1.Location = new Point(976, 11);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(10, 26);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            // 
            // chaosclicking
            // 
            chaosclicking.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chaosclicking.Location = new Point(207, 91);
            chaosclicking.Margin = new Padding(4, 0, 4, 0);
            chaosclicking.Name = "chaosclicking";
            chaosclicking.Size = new Size(359, 122);
            chaosclicking.TabIndex = 1;
            chaosclicking.Text = "Click the Bonks when they show up!\r\nMust click 10 bonks to escape\r\nTime is ticking!";
            chaosclicking.TextAlign = ContentAlignment.TopCenter;
            chaosclicking.Click += label1_Click;
            // 
            // bonkClick6
            // 
            bonkClick6.AutoSize = true;
            bonkClick6.Location = new Point(225, 41);
            bonkClick6.Margin = new Padding(4, 0, 4, 0);
            bonkClick6.Name = "bonkClick6";
            bonkClick6.Size = new Size(50, 18);
            bonkClick6.TabIndex = 2;
            bonkClick6.Text = "BONK";
            bonkClick6.Visible = false;
            bonkClick6.Click += bonkClick6_Click;
            // 
            // bonkClick3
            // 
            bonkClick3.AutoSize = true;
            bonkClick3.Location = new Point(448, 301);
            bonkClick3.Margin = new Padding(4, 0, 4, 0);
            bonkClick3.Name = "bonkClick3";
            bonkClick3.Size = new Size(50, 18);
            bonkClick3.TabIndex = 3;
            bonkClick3.Text = "BONK";
            bonkClick3.Visible = false;
            bonkClick3.Click += bonkClick3_Click;
            // 
            // bonkClick5
            // 
            bonkClick5.AutoSize = true;
            bonkClick5.Location = new Point(516, 41);
            bonkClick5.Margin = new Padding(4, 0, 4, 0);
            bonkClick5.Name = "bonkClick5";
            bonkClick5.Size = new Size(50, 18);
            bonkClick5.TabIndex = 4;
            bonkClick5.Text = "BONK";
            bonkClick5.Visible = false;
            bonkClick5.Click += bonkClick5_Click;
            // 
            // bonkClick2
            // 
            bonkClick2.AutoSize = true;
            bonkClick2.Location = new Point(171, 301);
            bonkClick2.Margin = new Padding(4, 0, 4, 0);
            bonkClick2.Name = "bonkClick2";
            bonkClick2.Size = new Size(50, 18);
            bonkClick2.TabIndex = 5;
            bonkClick2.Text = "BONK";
            bonkClick2.Visible = false;
            bonkClick2.Click += bonkClick2_Click;
            // 
            // bonkClick4
            // 
            bonkClick4.AutoSize = true;
            bonkClick4.Location = new Point(608, 165);
            bonkClick4.Margin = new Padding(4, 0, 4, 0);
            bonkClick4.Name = "bonkClick4";
            bonkClick4.Size = new Size(50, 18);
            bonkClick4.TabIndex = 6;
            bonkClick4.Text = "BONK";
            bonkClick4.Visible = false;
            bonkClick4.Click += bonkClick4_Click;
            // 
            // bonkClick1
            // 
            bonkClick1.AutoSize = true;
            bonkClick1.Location = new Point(89, 148);
            bonkClick1.Margin = new Padding(4, 0, 4, 0);
            bonkClick1.Name = "bonkClick1";
            bonkClick1.Size = new Size(50, 18);
            bonkClick1.TabIndex = 7;
            bonkClick1.Text = "BONK";
            bonkClick1.Visible = false;
            bonkClick1.Click += bonkClick1_Click;
            // 
            // bonktick
            // 
            bonktick.Interval = 5000;
            bonktick.Tick += bonktick_Tick;
            // 
            // chaosForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(787, 405);
            Controls.Add(bonkClick1);
            Controls.Add(bonkClick4);
            Controls.Add(bonkClick2);
            Controls.Add(bonkClick5);
            Controls.Add(bonkClick3);
            Controls.Add(bonkClick6);
            Controls.Add(chaosclicking);
            Controls.Add(button1);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "chaosForm";
            Text = "Chaos!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label chaosclicking;
        private Label bonkClick6;
        private Label bonkClick3;
        private Label bonkClick5;
        private Label bonkClick2;
        private Label bonkClick4;
        private Label bonkClick1;
        private System.Windows.Forms.Timer bonktick;
    }
}
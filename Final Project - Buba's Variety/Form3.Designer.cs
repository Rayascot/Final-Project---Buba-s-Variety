namespace Final_Project___Buba_s_Variety
{
    partial class Form3
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
            calcuButton = new Button();
            label1 = new Label();
            numbersOutput = new Label();
            firstSetButton = new Button();
            set1Textbox = new TextBox();
            set2Textbox = new TextBox();
            secondsSetButton = new Button();
            multiplyButton = new Button();
            addButton = new Button();
            subButton = new Button();
            productOutput = new Label();
            SuspendLayout();
            // 
            // calcuButton
            // 
            calcuButton.Location = new Point(398, 403);
            calcuButton.Margin = new Padding(4, 4, 4, 4);
            calcuButton.Name = "calcuButton";
            calcuButton.Size = new Size(118, 36);
            calcuButton.TabIndex = 0;
            calcuButton.Text = "Calculate";
            calcuButton.UseVisualStyleBackColor = true;
            calcuButton.Click += calcuButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(427, 25);
            label1.TabIndex = 1;
            label1.Text = "Super duper Calculator for all your Calculating needs";
            // 
            // numbersOutput
            // 
            numbersOutput.BackColor = Color.FromArgb(224, 224, 224);
            numbersOutput.BorderStyle = BorderStyle.Fixed3D;
            numbersOutput.Location = new Point(89, 72);
            numbersOutput.Name = "numbersOutput";
            numbersOutput.Size = new Size(427, 109);
            numbersOutput.TabIndex = 2;
            numbersOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // firstSetButton
            // 
            firstSetButton.Location = new Point(103, 286);
            firstSetButton.Name = "firstSetButton";
            firstSetButton.Size = new Size(94, 29);
            firstSetButton.TabIndex = 3;
            firstSetButton.Text = "Set";
            firstSetButton.UseVisualStyleBackColor = true;
            firstSetButton.Click += firstSetButton_Click;
            // 
            // set1Textbox
            // 
            set1Textbox.Location = new Point(89, 249);
            set1Textbox.Name = "set1Textbox";
            set1Textbox.Size = new Size(125, 31);
            set1Textbox.TabIndex = 4;
            // 
            // set2Textbox
            // 
            set2Textbox.Location = new Point(391, 249);
            set2Textbox.Name = "set2Textbox";
            set2Textbox.Size = new Size(125, 31);
            set2Textbox.TabIndex = 5;
            // 
            // secondsSetButton
            // 
            secondsSetButton.Location = new Point(407, 286);
            secondsSetButton.Name = "secondsSetButton";
            secondsSetButton.Size = new Size(94, 29);
            secondsSetButton.TabIndex = 6;
            secondsSetButton.Text = "Set";
            secondsSetButton.UseVisualStyleBackColor = true;
            secondsSetButton.Click += secondsSetButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Location = new Point(254, 214);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(94, 29);
            multiplyButton.TabIndex = 7;
            multiplyButton.Text = "Multiply";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(254, 249);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // subButton
            // 
            subButton.Location = new Point(254, 284);
            subButton.Name = "subButton";
            subButton.Size = new Size(94, 29);
            subButton.TabIndex = 9;
            subButton.Text = "Subtract";
            subButton.UseVisualStyleBackColor = true;
            subButton.Click += subButton_Click;
            // 
            // productOutput
            // 
            productOutput.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productOutput.Location = new Point(89, 368);
            productOutput.Name = "productOutput";
            productOutput.Size = new Size(259, 86);
            productOutput.TabIndex = 10;
            productOutput.Text = "Products =";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(602, 463);
            Controls.Add(productOutput);
            Controls.Add(subButton);
            Controls.Add(addButton);
            Controls.Add(multiplyButton);
            Controls.Add(secondsSetButton);
            Controls.Add(set2Textbox);
            Controls.Add(set1Textbox);
            Controls.Add(firstSetButton);
            Controls.Add(numbersOutput);
            Controls.Add(label1);
            Controls.Add(calcuButton);
            Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkOrange;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calcuButton;
        private Label label1;
        private Label numbersOutput;
        private Button firstSetButton;
        private TextBox set1Textbox;
        private TextBox set2Textbox;
        private Button secondsSetButton;
        private Button multiplyButton;
        private Button addButton;
        private Button subButton;
        private Label productOutput;
    }
}
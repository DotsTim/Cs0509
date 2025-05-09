namespace Cs0509
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
            buttonProperty = new Button();
            button1 = new Button();
            humen = new Label();
            DOWN = new Button();
            RIGHT = new Button();
            LEFT = new Button();
            UP = new Button();
            Dash = new Button();
            SuspendLayout();
            // 
            // buttonProperty
            // 
            buttonProperty.BackColor = SystemColors.Desktop;
            buttonProperty.Font = new Font("メイリオ", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            buttonProperty.ForeColor = SystemColors.HighlightText;
            buttonProperty.Location = new Point(0, 12);
            buttonProperty.Name = "buttonProperty";
            buttonProperty.Size = new Size(83, 29);
            buttonProperty.TabIndex = 0;
            buttonProperty.Text = "ボタン";
            buttonProperty.UseVisualStyleBackColor = false;
            buttonProperty.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 47);
            button1.Name = "button1";
            button1.Size = new Size(69, 71);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // humen
            // 
            humen.AutoSize = true;
            humen.BackColor = SystemColors.InactiveBorder;
            humen.ForeColor = Color.Red;
            humen.Location = new Point(300, 122);
            humen.Name = "humen";
            humen.Size = new Size(44, 15);
            humen.TabIndex = 2;
            humen.Text = "human";
            humen.Click += label1_Click;
            // 
            // DOWN
            // 
            DOWN.Location = new Point(647, 352);
            DOWN.Name = "DOWN";
            DOWN.Size = new Size(63, 58);
            DOWN.TabIndex = 3;
            DOWN.Text = "DOWN";
            DOWN.UseVisualStyleBackColor = true;
            DOWN.Click += DOWN_Click;
            // 
            // RIGHT
            // 
            RIGHT.Location = new Point(710, 286);
            RIGHT.Name = "RIGHT";
            RIGHT.Size = new Size(78, 60);
            RIGHT.TabIndex = 4;
            RIGHT.Text = "RIGHT";
            RIGHT.UseVisualStyleBackColor = true;
            RIGHT.Click += RIGHT_Click;
            // 
            // LEFT
            // 
            LEFT.Location = new Point(563, 286);
            LEFT.Name = "LEFT";
            LEFT.Size = new Size(78, 60);
            LEFT.TabIndex = 5;
            LEFT.Text = "LEFT";
            LEFT.UseVisualStyleBackColor = true;
            LEFT.Click += LEFT_Click;
            // 
            // UP
            // 
            UP.Location = new Point(647, 232);
            UP.Name = "UP";
            UP.Size = new Size(63, 50);
            UP.TabIndex = 6;
            UP.Text = "UP";
            UP.UseVisualStyleBackColor = true;
            UP.Click += button5_Click;
            // 
            // Dash
            // 
            Dash.Location = new Point(374, 349);
            Dash.Name = "Dash";
            Dash.Size = new Size(178, 65);
            Dash.TabIndex = 7;
            Dash.Text = "Dush";
            Dash.UseVisualStyleBackColor = true;
            Dash.Click += Dash_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 450);
            Controls.Add(Dash);
            Controls.Add(UP);
            Controls.Add(LEFT);
            Controls.Add(RIGHT);
            Controls.Add(DOWN);
            Controls.Add(humen);
            Controls.Add(button1);
            Controls.Add(buttonProperty);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonProperty;
        private Button button1;
        private Label humen;
        private Button DOWN;
        private Button RIGHT;
        private Button LEFT;
        private Button UP;
        private Button Dash;
    }
}

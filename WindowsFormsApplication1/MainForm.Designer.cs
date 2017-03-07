namespace WindowsFormsApplication1
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ebutton = new System.Windows.Forms.Button();
            this.TwoPlayerButton = new System.Windows.Forms.Button();
            this.OnePlayerButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.ebutton);
            this.panel1.Controls.Add(this.TwoPlayerButton);
            this.panel1.Controls.Add(this.OnePlayerButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Pristina", 15.75F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(500, 600);
            this.panel1.MinimumSize = new System.Drawing.Size(500, 600);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 600);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ebutton
            // 
            this.ebutton.BackColor = System.Drawing.Color.Maroon;
            this.ebutton.Font = new System.Drawing.Font("Pristina", 18F);
            this.ebutton.Image = global::WindowsFormsApplication1.Properties.Resources.cooltext129597091562233;
            this.ebutton.Location = new System.Drawing.Point(368, 511);
            this.ebutton.Name = "ebutton";
            this.ebutton.Size = new System.Drawing.Size(106, 54);
            this.ebutton.TabIndex = 15;
            this.ebutton.UseVisualStyleBackColor = false;
            this.ebutton.Click += new System.EventHandler(this.ebutton_Click);
            // 
            // TwoPlayerButton
            // 
            this.TwoPlayerButton.BackColor = System.Drawing.Color.Maroon;
            this.TwoPlayerButton.Font = new System.Drawing.Font("Pristina", 28F);
            this.TwoPlayerButton.ForeColor = System.Drawing.Color.Black;
            this.TwoPlayerButton.Image = global::WindowsFormsApplication1.Properties.Resources.cooltext129591200040855;
            this.TwoPlayerButton.Location = new System.Drawing.Point(183, 313);
            this.TwoPlayerButton.Name = "TwoPlayerButton";
            this.TwoPlayerButton.Size = new System.Drawing.Size(257, 69);
            this.TwoPlayerButton.TabIndex = 13;
            this.TwoPlayerButton.UseVisualStyleBackColor = false;
            this.TwoPlayerButton.Click += new System.EventHandler(this.TwoPlayerButton_Click);
            // 
            // OnePlayerButton
            // 
            this.OnePlayerButton.BackColor = System.Drawing.Color.Maroon;
            this.OnePlayerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OnePlayerButton.Font = new System.Drawing.Font("Pristina", 28F);
            this.OnePlayerButton.ForeColor = System.Drawing.Color.Blue;
            this.OnePlayerButton.Image = global::WindowsFormsApplication1.Properties.Resources.cooltext1295896835363293;
            this.OnePlayerButton.Location = new System.Drawing.Point(85, 217);
            this.OnePlayerButton.Name = "OnePlayerButton";
            this.OnePlayerButton.Size = new System.Drawing.Size(257, 68);
            this.OnePlayerButton.TabIndex = 12;
            this.OnePlayerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.OnePlayerButton.UseVisualStyleBackColor = false;
            this.OnePlayerButton.Click += new System.EventHandler(this.OnePlayerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 595);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TwoPlayerButton;
        private System.Windows.Forms.Button OnePlayerButton;
        private System.Windows.Forms.Button ebutton;
    }
}
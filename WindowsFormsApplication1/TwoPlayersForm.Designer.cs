namespace WindowsFormsApplication1
{
    partial class TwoPlayersForm
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
            this.b_button = new System.Windows.Forms.Button();
            this.ebutton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.PlayerOtextBox = new System.Windows.Forms.TextBox();
            this.PlayerXtextBox = new System.Windows.Forms.TextBox();
            this.PlayerOlabel = new System.Windows.Forms.Label();
            this.PlayerXlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._2Player1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.b_button);
            this.panel1.Controls.Add(this.ebutton);
            this.panel1.Controls.Add(this.PlayButton);
            this.panel1.Controls.Add(this.PlayerOtextBox);
            this.panel1.Controls.Add(this.PlayerXtextBox);
            this.panel1.Controls.Add(this.PlayerOlabel);
            this.panel1.Controls.Add(this.PlayerXlabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Pristina", 11.25F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(500, 599);
            this.panel1.MinimumSize = new System.Drawing.Size(500, 599);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 599);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // b_button
            // 
            this.b_button.BackColor = System.Drawing.Color.Maroon;
            this.b_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_button.Image = global::WindowsFormsApplication1.Properties.Resources.cooltext1295972243875071;
            this.b_button.Location = new System.Drawing.Point(52, 519);
            this.b_button.Name = "b_button";
            this.b_button.Size = new System.Drawing.Size(116, 55);
            this.b_button.TabIndex = 17;
            this.b_button.UseVisualStyleBackColor = false;
            this.b_button.Click += new System.EventHandler(this.b_button_Click);
            // 
            // ebutton
            // 
            this.ebutton.BackColor = System.Drawing.Color.Maroon;
            this.ebutton.Font = new System.Drawing.Font("Pristina", 18F);
            this.ebutton.Image = global::WindowsFormsApplication1.Properties.Resources.cooltext1295970915622332;
            this.ebutton.Location = new System.Drawing.Point(358, 519);
            this.ebutton.Name = "ebutton";
            this.ebutton.Size = new System.Drawing.Size(113, 55);
            this.ebutton.TabIndex = 16;
            this.ebutton.UseVisualStyleBackColor = false;
            this.ebutton.Click += new System.EventHandler(this.ebutton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Maroon;
            this.PlayButton.Font = new System.Drawing.Font("Pristina", 28F);
            this.PlayButton.ForeColor = System.Drawing.Color.Blue;
            this.PlayButton.Image = global::WindowsFormsApplication1.Properties.Resources.cooltext1296013654904071;
            this.PlayButton.Location = new System.Drawing.Point(137, 373);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(238, 90);
            this.PlayButton.TabIndex = 12;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PlayerOtextBox
            // 
            this.PlayerOtextBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.PlayerOtextBox.Font = new System.Drawing.Font("Pristina", 22F);
            this.PlayerOtextBox.Location = new System.Drawing.Point(189, 269);
            this.PlayerOtextBox.Multiline = true;
            this.PlayerOtextBox.Name = "PlayerOtextBox";
            this.PlayerOtextBox.Size = new System.Drawing.Size(269, 44);
            this.PlayerOtextBox.TabIndex = 10;
            this.PlayerOtextBox.TextChanged += new System.EventHandler(this.PlayerOtextBox_TextChanged);
            // 
            // PlayerXtextBox
            // 
            this.PlayerXtextBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.PlayerXtextBox.Font = new System.Drawing.Font("Pristina", 22F);
            this.PlayerXtextBox.Location = new System.Drawing.Point(189, 211);
            this.PlayerXtextBox.Multiline = true;
            this.PlayerXtextBox.Name = "PlayerXtextBox";
            this.PlayerXtextBox.Size = new System.Drawing.Size(269, 44);
            this.PlayerXtextBox.TabIndex = 9;
            this.PlayerXtextBox.TextChanged += new System.EventHandler(this.PlayerXtextBox_TextChanged);
            // 
            // PlayerOlabel
            // 
            this.PlayerOlabel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.PlayerOlabel.Font = new System.Drawing.Font("Pristina", 22F);
            this.PlayerOlabel.Location = new System.Drawing.Point(45, 269);
            this.PlayerOlabel.Name = "PlayerOlabel";
            this.PlayerOlabel.Size = new System.Drawing.Size(123, 44);
            this.PlayerOlabel.TabIndex = 8;
            this.PlayerOlabel.Text = "Player O : ";
            this.PlayerOlabel.Click += new System.EventHandler(this.PlayerOlabel_Click);
            // 
            // PlayerXlabel
            // 
            this.PlayerXlabel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.PlayerXlabel.Font = new System.Drawing.Font("Pristina", 22F);
            this.PlayerXlabel.Location = new System.Drawing.Point(45, 214);
            this.PlayerXlabel.Name = "PlayerXlabel";
            this.PlayerXlabel.Size = new System.Drawing.Size(129, 44);
            this.PlayerXlabel.TabIndex = 5;
            this.PlayerXlabel.Text = "Player X : ";
            // 
            // TwoPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 599);
            this.Controls.Add(this.panel1);
            this.Name = "TwoPlayersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Two Palyers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PlayerXlabel;
        private System.Windows.Forms.Label PlayerOlabel;
        private System.Windows.Forms.TextBox PlayerOtextBox;
        private System.Windows.Forms.TextBox PlayerXtextBox;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button ebutton;
        private System.Windows.Forms.Button b_button;
    }
}
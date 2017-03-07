namespace WindowsFormsApplication1
{
    partial class OnePlayerForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.b_button = new System.Windows.Forms.Button();
            this.ebutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerXtextBox = new System.Windows.Forms.TextBox();
            this.PlayerXlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.PlayerXtextBox);
            this.panel1.Controls.Add(this.PlayerXlabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(500, 600);
            this.panel1.MinimumSize = new System.Drawing.Size(500, 600);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 600);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.onePlayer;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.b_button);
            this.panel2.Controls.Add(this.ebutton);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MaximumSize = new System.Drawing.Size(500, 600);
            this.panel2.MinimumSize = new System.Drawing.Size(500, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 600);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // b_button
            // 
            this.b_button.BackColor = System.Drawing.Color.Maroon;
            this.b_button.Image = global::WindowsFormsApplication1.Properties.Resources.cooltext129597224387507;
            this.b_button.Location = new System.Drawing.Point(49, 518);
            this.b_button.Name = "b_button";
            this.b_button.Size = new System.Drawing.Size(110, 54);
            this.b_button.TabIndex = 17;
            this.b_button.UseVisualStyleBackColor = false;
            this.b_button.Click += new System.EventHandler(this.b_button_Click);
            // 
            // ebutton
            // 
            this.ebutton.BackColor = System.Drawing.Color.Maroon;
            this.ebutton.Font = new System.Drawing.Font("Pristina", 18F);
            this.ebutton.Image = global::WindowsFormsApplication1.Properties.Resources.cooltext1295970915622331;
            this.ebutton.Location = new System.Drawing.Point(351, 518);
            this.ebutton.Name = "ebutton";
            this.ebutton.Size = new System.Drawing.Size(106, 54);
            this.ebutton.TabIndex = 16;
            this.ebutton.UseVisualStyleBackColor = false;
            this.ebutton.Click += new System.EventHandler(this.ebutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Pristina", 28F);
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.cooltext1296013654904071;
            this.button1.Location = new System.Drawing.Point(133, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 85);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox1.Font = new System.Drawing.Font("Pristina", 22F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(188, 262);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 44);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Font = new System.Drawing.Font("Pristina", 22F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 44);
            this.label2.TabIndex = 8;
            this.label2.Text = "Player X : ";
            // 
            // PlayerXtextBox
            // 
            this.PlayerXtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PlayerXtextBox.Font = new System.Drawing.Font("Pristina", 22F);
            this.PlayerXtextBox.Location = new System.Drawing.Point(197, 148);
            this.PlayerXtextBox.Multiline = true;
            this.PlayerXtextBox.Name = "PlayerXtextBox";
            this.PlayerXtextBox.Size = new System.Drawing.Size(269, 44);
            this.PlayerXtextBox.TabIndex = 10;
            this.PlayerXtextBox.Click += new System.EventHandler(this.PlayerXtextBox_Click);
            this.PlayerXtextBox.TextChanged += new System.EventHandler(this.PlayerXtextBox_TextChanged);
            // 
            // PlayerXlabel
            // 
            this.PlayerXlabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PlayerXlabel.Font = new System.Drawing.Font("Pristina", 22F);
            this.PlayerXlabel.Location = new System.Drawing.Point(42, 148);
            this.PlayerXlabel.Name = "PlayerXlabel";
            this.PlayerXlabel.Size = new System.Drawing.Size(129, 44);
            this.PlayerXlabel.TabIndex = 8;
            this.PlayerXlabel.Text = "Player X : ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Pristina", 42F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(66, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 89);
            this.label1.TabIndex = 7;
            this.label1.Text = "ONE  PLAYER";
            // 
            // OnePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 599);
            this.Controls.Add(this.panel1);
            this.Name = "OnePlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Player";
            this.TextChanged += new System.EventHandler(this.OnePlayerForm_TextChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PlayerXlabel;
        
        private System.Windows.Forms.TextBox PlayerXtextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ebutton;
        private System.Windows.Forms.Button b_button;
    }
}
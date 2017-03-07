namespace WindowsFormsApplication1
{
    partial class GameForm
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
            this.newGameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ebutton = new System.Windows.Forms.Button();
            this.abutton = new System.Windows.Forms.Button();
            this.rbutton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(500, 600);
            this.panel1.MinimumSize = new System.Drawing.Size(500, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 599);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.newGameButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ebutton);
            this.panel2.Controls.Add(this.abutton);
            this.panel2.Controls.Add(this.rbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 499);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 100);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // newGameButton
            // 
            this.newGameButton.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._11;
            this.newGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newGameButton.Font = new System.Drawing.Font("Pristina", 18F);
            this.newGameButton.Location = new System.Drawing.Point(3, 52);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(155, 43);
            this.newGameButton.TabIndex = 4;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(164, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 3;
            // 
            // ebutton
            // 
            this.ebutton.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._11;
            this.ebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ebutton.Font = new System.Drawing.Font("Pristina", 18F);
            this.ebutton.Location = new System.Drawing.Point(391, 52);
            this.ebutton.Name = "ebutton";
            this.ebutton.Size = new System.Drawing.Size(106, 43);
            this.ebutton.TabIndex = 2;
            this.ebutton.Text = "Exit";
            this.ebutton.UseVisualStyleBackColor = true;
            this.ebutton.Click += new System.EventHandler(this.ebutton_Click);
            // 
            // abutton
            // 
            this.abutton.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._11;
            this.abutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.abutton.Font = new System.Drawing.Font("Pristina", 18F);
            this.abutton.Location = new System.Drawing.Point(3, 3);
            this.abutton.Name = "abutton";
            this.abutton.Size = new System.Drawing.Size(155, 43);
            this.abutton.TabIndex = 1;
            this.abutton.Text = "Game Statictics";
            this.abutton.UseVisualStyleBackColor = true;
            this.abutton.Click += new System.EventHandler(this.abutton_Click);
            // 
            // rbutton
            // 
            this.rbutton.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._11;
            this.rbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbutton.Font = new System.Drawing.Font("Pristina", 18F);
            this.rbutton.Location = new System.Drawing.Point(391, 3);
            this.rbutton.Name = "rbutton";
            this.rbutton.Size = new System.Drawing.Size(106, 43);
            this.rbutton.TabIndex = 0;
            this.rbutton.Text = "Restart";
            this.rbutton.UseVisualStyleBackColor = true;
            this.rbutton.Click += new System.EventHandler(this.rbutton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 599);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ebutton;
        private System.Windows.Forms.Button abutton;
        private System.Windows.Forms.Button rbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newGameButton;
    }
}


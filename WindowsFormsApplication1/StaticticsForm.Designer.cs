namespace WindowsFormsApplication1
{
    partial class StaticticsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._11;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.b_button);
            this.panel1.Controls.Add(this.ebutton);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(502, 595);
            this.panel1.MinimumSize = new System.Drawing.Size(502, 595);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 595);
            this.panel1.TabIndex = 0;
            // 
            // b_button
            // 
            this.b_button.BackColor = System.Drawing.Color.Maroon;
            this.b_button.Image = global::WindowsFormsApplication1.Properties.Resources.cooltext129597224387507;
            this.b_button.Location = new System.Drawing.Point(37, 514);
            this.b_button.Name = "b_button";
            this.b_button.Size = new System.Drawing.Size(110, 54);
            this.b_button.TabIndex = 19;
            this.b_button.UseVisualStyleBackColor = false;
            this.b_button.Click += new System.EventHandler(this.b_button_Click);
            // 
            // ebutton
            // 
            this.ebutton.BackColor = System.Drawing.Color.Maroon;
            this.ebutton.Font = new System.Drawing.Font("Pristina", 18F);
            this.ebutton.Image = global::WindowsFormsApplication1.Properties.Resources.cooltext1295970915622331;
            this.ebutton.Location = new System.Drawing.Point(361, 514);
            this.ebutton.Name = "ebutton";
            this.ebutton.Size = new System.Drawing.Size(106, 54);
            this.ebutton.TabIndex = 18;
            this.ebutton.UseVisualStyleBackColor = false;
            this.ebutton.Click += new System.EventHandler(this.ebutton_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 439);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StaticticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 595);
            this.Controls.Add(this.panel1);
            this.Name = "StaticticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Statictics";
            this.Load += new System.EventHandler(this.StaticticsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ebutton;
        private System.Windows.Forms.Button b_button;
    }
}
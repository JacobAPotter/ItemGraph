namespace ItemGraph
{
    partial class ItemGraph
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.planetBox = new System.Windows.Forms.ListBox();
            this.lakeBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.locationBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vehicleBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.speciesBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lureBox = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.CheckedListBox();
            this.attractantBox = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.baitBox = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveBtn.Location = new System.Drawing.Point(2240, 1077);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(205, 75);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Planet";
            // 
            // planetBox
            // 
            this.planetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planetBox.FormattingEnabled = true;
            this.planetBox.ItemHeight = 25;
            this.planetBox.Location = new System.Drawing.Point(23, 63);
            this.planetBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.planetBox.Name = "planetBox";
            this.planetBox.Size = new System.Drawing.Size(177, 229);
            this.planetBox.TabIndex = 3;
            // 
            // lakeBox
            // 
            this.lakeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lakeBox.FormattingEnabled = true;
            this.lakeBox.ItemHeight = 25;
            this.lakeBox.Location = new System.Drawing.Point(259, 63);
            this.lakeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lakeBox.Name = "lakeBox";
            this.lakeBox.Size = new System.Drawing.Size(177, 229);
            this.lakeBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(253, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lake";
            // 
            // locationBox
            // 
            this.locationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationBox.FormattingEnabled = true;
            this.locationBox.ItemHeight = 25;
            this.locationBox.Location = new System.Drawing.Point(507, 63);
            this.locationBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(177, 229);
            this.locationBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(501, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Location";
            // 
            // vehicleBox
            // 
            this.vehicleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleBox.FormattingEnabled = true;
            this.vehicleBox.Items.AddRange(new object[] {
            "Small",
            "Large",
            "Giant",
            "Dive",
            "Submarine"});
            this.vehicleBox.Location = new System.Drawing.Point(756, 63);
            this.vehicleBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vehicleBox.Name = "vehicleBox";
            this.vehicleBox.Size = new System.Drawing.Size(180, 154);
            this.vehicleBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(751, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vehicles";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(999, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Species";
            // 
            // speciesBox
            // 
            this.speciesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speciesBox.FormattingEnabled = true;
            this.speciesBox.Location = new System.Drawing.Point(1004, 68);
            this.speciesBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.speciesBox.MultiColumn = true;
            this.speciesBox.Name = "speciesBox";
            this.speciesBox.Size = new System.Drawing.Size(1045, 529);
            this.speciesBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Lure";
            // 
            // lureBox
            // 
            this.lureBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lureBox.FormattingEnabled = true;
            this.lureBox.Items.AddRange(new object[] {
            "Twin-Tail",
            "Craw Bug",
            "Fur Skirt",
            "Plastic Skirt",
            "Short Fish",
            "Hard Bait",
            "Craw",
            "Spoon",
            "Popper",
            "Paddle",
            "Dove Tail",
            "Fish Bones",
            "Large Paddle",
            "Large Hard Bait",
            "Large Plastic Skirt",
            "Swim Bait",
            "Human",
            "Giant Hard Bait",
            "Giant Spoon",
            "Giant Craw"});
            this.lureBox.Location = new System.Drawing.Point(19, 342);
            this.lureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lureBox.MultiColumn = true;
            this.lureBox.Name = "lureBox";
            this.lureBox.Size = new System.Drawing.Size(563, 179);
            this.lureBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 525);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Color";
            // 
            // colorBox
            // 
            this.colorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Location = new System.Drawing.Point(19, 557);
            this.colorBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorBox.MultiColumn = true;
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(563, 179);
            this.colorBox.TabIndex = 18;
            // 
            // attractantBox
            // 
            this.attractantBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attractantBox.FormattingEnabled = true;
            this.attractantBox.Items.AddRange(new object[] {
            "Garlic",
            "Chicken Liver",
            "Fish Guts",
            "Roe",
            "Human Blood",
            "Moon Dust",
            "Voice Of Siren"});
            this.attractantBox.Location = new System.Drawing.Point(25, 769);
            this.attractantBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.attractantBox.MultiColumn = true;
            this.attractantBox.Name = "attractantBox";
            this.attractantBox.Size = new System.Drawing.Size(563, 179);
            this.attractantBox.TabIndex = 20;
            this.attractantBox.SelectedIndexChanged += new System.EventHandler(this.attractantBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 740);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Attractant";
            // 
            // baitBox
            // 
            this.baitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baitBox.FormattingEnabled = true;
            this.baitBox.Items.AddRange(new object[] {
            "Worm",
            "Trout Eggs",
            "Elkian Snail",
            "Marshmallow",
            "Stink Bait",
            "Tuna Meat",
            "Carp Meat",
            "Salmon Head",
            "Fish Chunks",
            "Neon Worm",
            "Brine Worm",
            "Wasp Nest",
            "Sailor Hat",
            "Human Bones",
            "Skull of Chimera",
            "Harboerers Astrolabe",
            "Eye of Ghorphillia"});
            this.baitBox.Location = new System.Drawing.Point(662, 769);
            this.baitBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.baitBox.MultiColumn = true;
            this.baitBox.Name = "baitBox";
            this.baitBox.Size = new System.Drawing.Size(563, 179);
            this.baitBox.TabIndex = 22;
            this.baitBox.SelectedIndexChanged += new System.EventHandler(this.baitBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(657, 740);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Bait";
            // 
            // ItemGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.baitBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.attractantBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lureBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.speciesBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vehicleBox);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lakeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.planetBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ItemGraph";
            this.Text = "ItemGraph";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemGraph_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox planetBox;
        private System.Windows.Forms.ListBox lakeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox locationBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox vehicleBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox speciesBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox lureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox colorBox;
        private System.Windows.Forms.CheckedListBox attractantBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox baitBox;
        private System.Windows.Forms.Label label9;
    }
}


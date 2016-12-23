namespace OrcRaces
{
    partial class RaceTrack
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
            this.riderOrc = new System.Windows.Forms.PictureBox();
            this.fighterOrc = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.choosePigRider = new System.Windows.Forms.RadioButton();
            this.chooseUglyOrc = new System.Windows.Forms.RadioButton();
            this.chooseMomOrc = new System.Windows.Forms.RadioButton();
            this.mommyOrc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.riderOrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fighterOrc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mommyOrc)).BeginInit();
            this.SuspendLayout();
            // 
            // riderOrc
            // 
            this.riderOrc.ErrorImage = global::OrcRaces.Properties.Resources.Demo_Goblin_Pig_Rider_Walking;
            this.riderOrc.Image = global::OrcRaces.Properties.Resources.Demo_Goblin_Pig_Rider_Walking;
            this.riderOrc.InitialImage = global::OrcRaces.Properties.Resources.Demo_Goblin_Pig_Rider_Walking;
            this.riderOrc.Location = new System.Drawing.Point(12, 361);
            this.riderOrc.Name = "riderOrc";
            this.riderOrc.Size = new System.Drawing.Size(150, 150);
            this.riderOrc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.riderOrc.TabIndex = 2;
            this.riderOrc.TabStop = false;
            // 
            // fighterOrc
            // 
            this.fighterOrc.ErrorImage = global::OrcRaces.Properties.Resources.orc2_Orc_Fighter_Walking;
            this.fighterOrc.Image = global::OrcRaces.Properties.Resources.orc2_Orc_Fighter_Walking;
            this.fighterOrc.InitialImage = global::OrcRaces.Properties.Resources.orc2_Orc_Fighter_Walking;
            this.fighterOrc.Location = new System.Drawing.Point(12, 188);
            this.fighterOrc.Name = "fighterOrc";
            this.fighterOrc.Size = new System.Drawing.Size(150, 150);
            this.fighterOrc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fighterOrc.TabIndex = 1;
            this.fighterOrc.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRun);
            this.groupBox1.Controls.Add(this.choosePigRider);
            this.groupBox1.Controls.Add(this.chooseUglyOrc);
            this.groupBox1.Controls.Add(this.chooseMomOrc);
            this.groupBox1.Location = new System.Drawing.Point(13, 530);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 159);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Спорим: кто победит?";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(726, 39);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(280, 89);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "Погнали!";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // choosePigRider
            // 
            this.choosePigRider.AutoSize = true;
            this.choosePigRider.Location = new System.Drawing.Point(423, 65);
            this.choosePigRider.Name = "choosePigRider";
            this.choosePigRider.Size = new System.Drawing.Size(186, 29);
            this.choosePigRider.TabIndex = 2;
            this.choosePigRider.TabStop = true;
            this.choosePigRider.Text = "Свиновсадник";
            this.choosePigRider.UseVisualStyleBackColor = true;
            // 
            // chooseUglyOrc
            // 
            this.chooseUglyOrc.AutoSize = true;
            this.chooseUglyOrc.Location = new System.Drawing.Point(214, 66);
            this.chooseUglyOrc.Name = "chooseUglyOrc";
            this.chooseUglyOrc.Size = new System.Drawing.Size(189, 29);
            this.chooseUglyOrc.TabIndex = 1;
            this.chooseUglyOrc.TabStop = true;
            this.chooseUglyOrc.Text = "Страшный орк";
            this.chooseUglyOrc.UseVisualStyleBackColor = true;
            // 
            // chooseMomOrc
            // 
            this.chooseMomOrc.AutoSize = true;
            this.chooseMomOrc.Location = new System.Drawing.Point(26, 66);
            this.chooseMomOrc.Name = "chooseMomOrc";
            this.chooseMomOrc.Size = new System.Drawing.Size(168, 29);
            this.chooseMomOrc.TabIndex = 0;
            this.chooseMomOrc.TabStop = true;
            this.chooseMomOrc.Text = "Маманя Орк";
            this.chooseMomOrc.UseVisualStyleBackColor = true;
            // 
            // mommyOrc
            // 
            this.mommyOrc.Image = global::OrcRaces.Properties.Resources.Orc_Mommy_Boss_Walking;
            this.mommyOrc.InitialImage = global::OrcRaces.Properties.Resources.Orc_Mommy_Boss_Walking;
            this.mommyOrc.Location = new System.Drawing.Point(13, 13);
            this.mommyOrc.Name = "mommyOrc";
            this.mommyOrc.Size = new System.Drawing.Size(150, 150);
            this.mommyOrc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mommyOrc.TabIndex = 4;
            this.mommyOrc.TabStop = false;
            // 
            // RaceTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 701);
            this.Controls.Add(this.mommyOrc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.riderOrc);
            this.Controls.Add(this.fighterOrc);
            this.Name = "RaceTrack";
            this.Text = "Забег Орков!";
            this.Load += new System.EventHandler(this.RaceTrack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.riderOrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fighterOrc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mommyOrc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.RadioButton choosePigRider;
        private System.Windows.Forms.RadioButton chooseUglyOrc;
        private System.Windows.Forms.RadioButton chooseMomOrc;
        public System.Windows.Forms.PictureBox fighterOrc;
        public System.Windows.Forms.PictureBox riderOrc;
        public System.Windows.Forms.PictureBox mommyOrc;
    }
}


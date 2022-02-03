namespace yasyagame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.sky = new System.Windows.Forms.PictureBox();
            this.DanaBot = new System.Windows.Forms.PictureBox();
            this.DanaTop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.yasya = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanaBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanaTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yasya)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Lime;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 409);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(77, 22);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: 0";
            // 
            // sky
            // 
            this.sky.Image = global::yasyagame.Properties.Resources.ham;
            this.sky.Location = new System.Drawing.Point(330, 15);
            this.sky.Name = "sky";
            this.sky.Size = new System.Drawing.Size(109, 63);
            this.sky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sky.TabIndex = 5;
            this.sky.TabStop = false;
            // 
            // DanaBot
            // 
            this.DanaBot.Image = global::yasyagame.Properties.Resources.danaup;
            this.DanaBot.Location = new System.Drawing.Point(417, 266);
            this.DanaBot.Name = "DanaBot";
            this.DanaBot.Size = new System.Drawing.Size(107, 119);
            this.DanaBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DanaBot.TabIndex = 4;
            this.DanaBot.TabStop = false;
            // 
            // DanaTop
            // 
            this.DanaTop.Image = global::yasyagame.Properties.Resources.danadown;
            this.DanaTop.Location = new System.Drawing.Point(642, 15);
            this.DanaTop.Name = "DanaTop";
            this.DanaTop.Size = new System.Drawing.Size(131, 119);
            this.DanaTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DanaTop.TabIndex = 3;
            this.DanaTop.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::yasyagame.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-3, 373);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(805, 79);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // yasya
            // 
            this.yasya.Image = global::yasyagame.Properties.Resources.yasya;
            this.yasya.Location = new System.Drawing.Point(45, 118);
            this.yasya.Name = "yasya";
            this.yasya.Size = new System.Drawing.Size(67, 70);
            this.yasya.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yasya.TabIndex = 0;
            this.yasya.TabStop = false;
            this.yasya.Click += new System.EventHandler(this.yasya_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sky);
            this.Controls.Add(this.DanaBot);
            this.Controls.Add(this.DanaTop);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.yasya);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YasyaGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.sky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanaBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanaTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yasya)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox yasya;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox DanaTop;
        private System.Windows.Forms.PictureBox DanaBot;
        private System.Windows.Forms.PictureBox sky;
    }
}


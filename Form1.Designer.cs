
namespace pacman
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pacmanpic = new System.Windows.Forms.PictureBox();
            this.eb1 = new System.Windows.Forms.PictureBox();
            this.eb3 = new System.Windows.Forms.PictureBox();
            this.eb2 = new System.Windows.Forms.PictureBox();
            this.eb4 = new System.Windows.Forms.PictureBox();
            this.lscore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pacmanpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eb4)).BeginInit();
            this.SuspendLayout();
            // 
            // pacmanpic
            // 
            this.pacmanpic.Image = global::pacman.Properties.Resources.rightp;
            this.pacmanpic.Location = new System.Drawing.Point(22, 156);
            this.pacmanpic.Name = "pacmanpic";
            this.pacmanpic.Size = new System.Drawing.Size(36, 35);
            this.pacmanpic.TabIndex = 0;
            this.pacmanpic.TabStop = false;
            // 
            // eb1
            // 
            this.eb1.Image = global::pacman.Properties.Resources.ball;
            this.eb1.Location = new System.Drawing.Point(207, 100);
            this.eb1.Name = "eb1";
            this.eb1.Size = new System.Drawing.Size(16, 15);
            this.eb1.TabIndex = 5;
            this.eb1.TabStop = false;
            // 
            // eb3
            // 
            this.eb3.Image = global::pacman.Properties.Resources.ball;
            this.eb3.Location = new System.Drawing.Point(244, 176);
            this.eb3.Name = "eb3";
            this.eb3.Size = new System.Drawing.Size(16, 15);
            this.eb3.TabIndex = 6;
            this.eb3.TabStop = false;
            // 
            // eb2
            // 
            this.eb2.Image = global::pacman.Properties.Resources.ball;
            this.eb2.Location = new System.Drawing.Point(319, 224);
            this.eb2.Name = "eb2";
            this.eb2.Size = new System.Drawing.Size(16, 15);
            this.eb2.TabIndex = 7;
            this.eb2.TabStop = false;
            // 
            // eb4
            // 
            this.eb4.Image = global::pacman.Properties.Resources.ball;
            this.eb4.Location = new System.Drawing.Point(365, 100);
            this.eb4.Name = "eb4";
            this.eb4.Size = new System.Drawing.Size(16, 15);
            this.eb4.TabIndex = 8;
            this.eb4.TabStop = false;
            // 
            // lscore
            // 
            this.lscore.AutoSize = true;
            this.lscore.Location = new System.Drawing.Point(710, 24);
            this.lscore.Name = "lscore";
            this.lscore.Size = new System.Drawing.Size(13, 13);
            this.lscore.TabIndex = 10;
            this.lscore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lscore);
            this.Controls.Add(this.eb4);
            this.Controls.Add(this.eb2);
            this.Controls.Add(this.eb3);
            this.Controls.Add(this.eb1);
            this.Controls.Add(this.pacmanpic);
            this.Name = "Form1";
            this.Text = "PacmanDemo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pacmanpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eb4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pacmanpic;
        private System.Windows.Forms.PictureBox eb1;
        private System.Windows.Forms.PictureBox eb3;
        private System.Windows.Forms.PictureBox eb2;
        private System.Windows.Forms.PictureBox eb4;
        private System.Windows.Forms.Label lscore;
    }
}


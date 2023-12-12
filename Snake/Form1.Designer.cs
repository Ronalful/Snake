namespace Snake
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_count = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.radioButton_slow = new System.Windows.Forms.RadioButton();
            this.radioButton_medium = new System.Windows.Forms.RadioButton();
            this.radioButton_fast = new System.Windows.Forms.RadioButton();
            this.label_end = new System.Windows.Forms.Label();
            this.radioButton_turbo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 618);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.SystemColors.Control;
            this.button_start.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_start.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_start.FlatAppearance.BorderSize = 0;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("MS Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.ForeColor = System.Drawing.Color.Red;
            this.button_start.Location = new System.Drawing.Point(459, 628);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(178, 61);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("MS Gothic", 28.2F);
            this.label_count.ForeColor = System.Drawing.Color.Green;
            this.label_count.Location = new System.Drawing.Point(101, 639);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(44, 47);
            this.label_count.TabIndex = 2;
            this.label_count.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(14, 623);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // radioButton_slow
            // 
            this.radioButton_slow.AutoSize = true;
            this.radioButton_slow.Checked = true;
            this.radioButton_slow.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_slow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButton_slow.Location = new System.Drawing.Point(186, 621);
            this.radioButton_slow.Name = "radioButton_slow";
            this.radioButton_slow.Size = new System.Drawing.Size(69, 28);
            this.radioButton_slow.TabIndex = 4;
            this.radioButton_slow.TabStop = true;
            this.radioButton_slow.Text = "Slow";
            this.radioButton_slow.UseVisualStyleBackColor = true;
            // 
            // radioButton_medium
            // 
            this.radioButton_medium.AutoSize = true;
            this.radioButton_medium.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.radioButton_medium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButton_medium.Location = new System.Drawing.Point(186, 649);
            this.radioButton_medium.Name = "radioButton_medium";
            this.radioButton_medium.Size = new System.Drawing.Size(92, 28);
            this.radioButton_medium.TabIndex = 5;
            this.radioButton_medium.Text = "Medium";
            this.radioButton_medium.UseVisualStyleBackColor = true;
            // 
            // radioButton_fast
            // 
            this.radioButton_fast.AutoSize = true;
            this.radioButton_fast.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.radioButton_fast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButton_fast.Location = new System.Drawing.Point(186, 676);
            this.radioButton_fast.Name = "radioButton_fast";
            this.radioButton_fast.Size = new System.Drawing.Size(64, 28);
            this.radioButton_fast.TabIndex = 6;
            this.radioButton_fast.Text = "Fast";
            this.radioButton_fast.UseVisualStyleBackColor = true;
            // 
            // label_end
            // 
            this.label_end.AutoSize = true;
            this.label_end.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_end.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_end.Font = new System.Drawing.Font("MS Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_end.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_end.Location = new System.Drawing.Point(22, 215);
            this.label_end.Name = "label_end";
            this.label_end.Size = new System.Drawing.Size(592, 122);
            this.label_end.TabIndex = 7;
            this.label_end.Text = "GAME OVER";
            this.label_end.Visible = false;
            // 
            // radioButton_turbo
            // 
            this.radioButton_turbo.AutoSize = true;
            this.radioButton_turbo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.radioButton_turbo.ForeColor = System.Drawing.Color.Maroon;
            this.radioButton_turbo.Location = new System.Drawing.Point(283, 676);
            this.radioButton_turbo.Name = "radioButton_turbo";
            this.radioButton_turbo.Size = new System.Drawing.Size(77, 28);
            this.radioButton_turbo.TabIndex = 8;
            this.radioButton_turbo.Text = "Turbo";
            this.radioButton_turbo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(667, 701);
            this.Controls.Add(this.radioButton_turbo);
            this.Controls.Add(this.label_end);
            this.Controls.Add(this.radioButton_fast);
            this.Controls.Add(this.radioButton_medium);
            this.Controls.Add(this.radioButton_slow);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.RadioButton radioButton_slow;
        private System.Windows.Forms.RadioButton radioButton_medium;
        private System.Windows.Forms.RadioButton radioButton_fast;
        private System.Windows.Forms.Label label_end;
        private System.Windows.Forms.RadioButton radioButton_turbo;
    }
}


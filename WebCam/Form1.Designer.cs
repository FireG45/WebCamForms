namespace WebCam
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
            this.start_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.capture_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stop_button = new System.Windows.Forms.Button();
            this.interval_field = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.frames_field = new System.Windows.Forms.NumericUpDown();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.interval2_field = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval_field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frames_field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval2_field)).BeginInit();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(1323, 12);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(144, 23);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(677, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(640, 480);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // capture_button
            // 
            this.capture_button.Location = new System.Drawing.Point(1323, 70);
            this.capture_button.Name = "capture_button";
            this.capture_button.Size = new System.Drawing.Size(144, 23);
            this.capture_button.TabIndex = 3;
            this.capture_button.Text = "Сapture";
            this.capture_button.UseVisualStyleBackColor = true;
            this.capture_button.Click += new System.EventHandler(this.capture_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(1323, 99);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(144, 23);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(1323, 41);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(144, 23);
            this.stop_button.TabIndex = 5;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // interval_field
            // 
            this.interval_field.Location = new System.Drawing.Point(1396, 128);
            this.interval_field.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.interval_field.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.interval_field.Name = "interval_field";
            this.interval_field.Size = new System.Drawing.Size(71, 20);
            this.interval_field.TabIndex = 6;
            this.interval_field.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1329, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Delay in ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1334, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Frames";
            // 
            // frames_field
            // 
            this.frames_field.Location = new System.Drawing.Point(1399, 207);
            this.frames_field.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.frames_field.Name = "frames_field";
            this.frames_field.Size = new System.Drawing.Size(71, 20);
            this.frames_field.TabIndex = 8;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1326, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Delay2 in ms";
            // 
            // interval2_field
            // 
            this.interval2_field.Location = new System.Drawing.Point(1399, 228);
            this.interval2_field.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.interval2_field.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.interval2_field.Name = "interval2_field";
            this.interval2_field.Size = new System.Drawing.Size(71, 20);
            this.interval2_field.TabIndex = 10;
            this.interval2_field.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.interval2_field);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frames_field);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interval_field);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.capture_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.start_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "WebCum";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval_field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frames_field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval2_field)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button capture_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.NumericUpDown interval_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown frames_field;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown interval2_field;
    }
}


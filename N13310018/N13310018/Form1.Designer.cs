namespace N13310018
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ClickMe = new System.Windows.Forms.Button();
            this.btn_ChangeLabel = new System.Windows.Forms.Button();
            this.lab_ChangLabel = new System.Windows.Forms.Label();
            this.lab_Counter = new System.Windows.Forms.Label();
            this.btn_Counter = new System.Windows.Forms.Button();
            this.btnBigger = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightPink;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "N13310018-芫";
            // 
            // btn_ClickMe
            // 
            this.btn_ClickMe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ClickMe.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ClickMe.ForeColor = System.Drawing.Color.Gold;
            this.btn_ClickMe.Location = new System.Drawing.Point(608, 386);
            this.btn_ClickMe.Name = "btn_ClickMe";
            this.btn_ClickMe.Size = new System.Drawing.Size(180, 52);
            this.btn_ClickMe.TabIndex = 1;
            this.btn_ClickMe.Text = "按我一下";
            this.btn_ClickMe.UseVisualStyleBackColor = false;
            this.btn_ClickMe.Click += new System.EventHandler(this.btn_ClickMe_Click);
            // 
            // btn_ChangeLabel
            // 
            this.btn_ChangeLabel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ChangeLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ChangeLabel.Location = new System.Drawing.Point(59, 133);
            this.btn_ChangeLabel.Name = "btn_ChangeLabel";
            this.btn_ChangeLabel.Size = new System.Drawing.Size(127, 47);
            this.btn_ChangeLabel.TabIndex = 2;
            this.btn_ChangeLabel.Text = "按我切換標籤";
            this.btn_ChangeLabel.UseVisualStyleBackColor = false;
            this.btn_ChangeLabel.Click += new System.EventHandler(this.btn_ChangeLabel_Click);
            // 
            // lab_ChangLabel
            // 
            this.lab_ChangLabel.AutoSize = true;
            this.lab_ChangLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lab_ChangLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_ChangLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.lab_ChangLabel.Location = new System.Drawing.Point(244, 150);
            this.lab_ChangLabel.Name = "lab_ChangLabel";
            this.lab_ChangLabel.Size = new System.Drawing.Size(74, 27);
            this.lab_ChangLabel.TabIndex = 3;
            this.lab_ChangLabel.Text = "label2";
            // 
            // lab_Counter
            // 
            this.lab_Counter.AutoSize = true;
            this.lab_Counter.BackColor = System.Drawing.Color.SaddleBrown;
            this.lab_Counter.Font = new System.Drawing.Font("Vivaldi", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Counter.ForeColor = System.Drawing.Color.Gold;
            this.lab_Counter.Location = new System.Drawing.Point(262, 262);
            this.lab_Counter.Name = "lab_Counter";
            this.lab_Counter.Size = new System.Drawing.Size(27, 32);
            this.lab_Counter.TabIndex = 5;
            this.lab_Counter.Text = "0";
            // 
            // btn_Counter
            // 
            this.btn_Counter.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Counter.Font = new System.Drawing.Font("新細明體", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Counter.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Counter.Location = new System.Drawing.Point(59, 225);
            this.btn_Counter.Name = "btn_Counter";
            this.btn_Counter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Counter.Size = new System.Drawing.Size(127, 64);
            this.btn_Counter.TabIndex = 4;
            this.btn_Counter.Text = "按我加1";
            this.btn_Counter.UseVisualStyleBackColor = false;
            this.btn_Counter.Click += new System.EventHandler(this.btn_Counter_Click);
            // 
            // btnBigger
            // 
            this.btnBigger.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBigger.Location = new System.Drawing.Point(59, 336);
            this.btnBigger.Name = "btnBigger";
            this.btnBigger.Size = new System.Drawing.Size(175, 72);
            this.btnBigger.TabIndex = 6;
            this.btnBigger.Text = "按我放大";
            this.btnBigger.UseVisualStyleBackColor = true;
            this.btnBigger.Click += new System.EventHandler(this.btnBigger_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(450, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 33);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(608, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "按我複製至串Label";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(446, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBigger);
            this.Controls.Add(this.lab_Counter);
            this.Controls.Add(this.btn_Counter);
            this.Controls.Add(this.lab_ChangLabel);
            this.Controls.Add(this.btn_ChangeLabel);
            this.Controls.Add(this.btn_ClickMe);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ClickMe;
        private System.Windows.Forms.Button btn_ChangeLabel;
        private System.Windows.Forms.Label lab_ChangLabel;
        private System.Windows.Forms.Label lab_Counter;
        private System.Windows.Forms.Button btn_Counter;
        private System.Windows.Forms.Button btnBigger;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}


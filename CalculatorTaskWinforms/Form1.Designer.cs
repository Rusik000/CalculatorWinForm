namespace CalculatorTaskWinforms
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
            this.deletebtn = new System.Windows.Forms.Button();
            this.dividebtn = new System.Windows.Forms.Button();
            this.plusbtn = new System.Windows.Forms.Button();
            this.ResultTxt = new System.Windows.Forms.TextBox();
            this.resultlbl = new System.Windows.Forms.Label();
            this.sevenbtn = new System.Windows.Forms.Button();
            this.eightbtn = new System.Windows.Forms.Button();
            this.ninebtn = new System.Windows.Forms.Button();
            this.fourbtn = new System.Windows.Forms.Button();
            this.fivebtn = new System.Windows.Forms.Button();
            this.sixbtn = new System.Windows.Forms.Button();
            this.onebtn = new System.Windows.Forms.Button();
            this.twobtn = new System.Windows.Forms.Button();
            this.threebtn = new System.Windows.Forms.Button();
            this.zerobtn = new System.Windows.Forms.Button();
            this.pointbtn = new System.Windows.Forms.Button();
            this.equalbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.Blue;
            this.deletebtn.Location = new System.Drawing.Point(272, 70);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(85, 57);
            this.deletebtn.TabIndex = 12;
            this.deletebtn.Text = "C";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // dividebtn
            // 
            this.dividebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividebtn.ForeColor = System.Drawing.Color.Blue;
            this.dividebtn.Location = new System.Drawing.Point(272, 124);
            this.dividebtn.Name = "dividebtn";
            this.dividebtn.Size = new System.Drawing.Size(85, 50);
            this.dividebtn.TabIndex = 13;
            this.dividebtn.Text = "/";
            this.dividebtn.UseVisualStyleBackColor = true;
            this.dividebtn.Click += new System.EventHandler(this.operator_click);
            // 
            // plusbtn
            // 
            this.plusbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusbtn.ForeColor = System.Drawing.Color.Blue;
            this.plusbtn.Location = new System.Drawing.Point(272, 226);
            this.plusbtn.Name = "plusbtn";
            this.plusbtn.Size = new System.Drawing.Size(85, 58);
            this.plusbtn.TabIndex = 15;
            this.plusbtn.Text = "+";
            this.plusbtn.UseVisualStyleBackColor = true;
            this.plusbtn.Click += new System.EventHandler(this.operator_click);
            // 
            // ResultTxt
            // 
            this.ResultTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTxt.ForeColor = System.Drawing.Color.Black;
            this.ResultTxt.Location = new System.Drawing.Point(71, 12);
            this.ResultTxt.Multiline = true;
            this.ResultTxt.Name = "ResultTxt";
            this.ResultTxt.Size = new System.Drawing.Size(286, 44);
            this.ResultTxt.TabIndex = 16;
            this.ResultTxt.Text = "0";
            this.ResultTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resultlbl
            // 
            this.resultlbl.AutoSize = true;
            this.resultlbl.BackColor = System.Drawing.Color.White;
            this.resultlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultlbl.ForeColor = System.Drawing.Color.Red;
            this.resultlbl.Location = new System.Drawing.Point(71, 12);
            this.resultlbl.Name = "resultlbl";
            this.resultlbl.Size = new System.Drawing.Size(2, 26);
            this.resultlbl.TabIndex = 18;
            // 
            // sevenbtn
            // 
            this.sevenbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenbtn.ForeColor = System.Drawing.Color.Blue;
            this.sevenbtn.Location = new System.Drawing.Point(71, 70);
            this.sevenbtn.Name = "sevenbtn";
            this.sevenbtn.Size = new System.Drawing.Size(69, 57);
            this.sevenbtn.TabIndex = 0;
            this.sevenbtn.Text = "7";
            this.sevenbtn.UseVisualStyleBackColor = true;
            this.sevenbtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // eightbtn
            // 
            this.eightbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightbtn.ForeColor = System.Drawing.Color.Blue;
            this.eightbtn.Location = new System.Drawing.Point(136, 70);
            this.eightbtn.Name = "eightbtn";
            this.eightbtn.Size = new System.Drawing.Size(72, 57);
            this.eightbtn.TabIndex = 1;
            this.eightbtn.Text = "8";
            this.eightbtn.UseVisualStyleBackColor = true;
            this.eightbtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // ninebtn
            // 
            this.ninebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ninebtn.ForeColor = System.Drawing.Color.Blue;
            this.ninebtn.Location = new System.Drawing.Point(204, 70);
            this.ninebtn.Name = "ninebtn";
            this.ninebtn.Size = new System.Drawing.Size(74, 57);
            this.ninebtn.TabIndex = 2;
            this.ninebtn.Text = "9";
            this.ninebtn.UseVisualStyleBackColor = true;
            this.ninebtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // fourbtn
            // 
            this.fourbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourbtn.ForeColor = System.Drawing.Color.Blue;
            this.fourbtn.Location = new System.Drawing.Point(71, 124);
            this.fourbtn.Name = "fourbtn";
            this.fourbtn.Size = new System.Drawing.Size(69, 56);
            this.fourbtn.TabIndex = 3;
            this.fourbtn.Text = "4";
            this.fourbtn.UseVisualStyleBackColor = true;
            this.fourbtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // fivebtn
            // 
            this.fivebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fivebtn.ForeColor = System.Drawing.Color.Blue;
            this.fivebtn.Location = new System.Drawing.Point(136, 124);
            this.fivebtn.Name = "fivebtn";
            this.fivebtn.Size = new System.Drawing.Size(72, 56);
            this.fivebtn.TabIndex = 4;
            this.fivebtn.Text = "5";
            this.fivebtn.UseVisualStyleBackColor = true;
            this.fivebtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // sixbtn
            // 
            this.sixbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixbtn.ForeColor = System.Drawing.Color.Blue;
            this.sixbtn.Location = new System.Drawing.Point(204, 124);
            this.sixbtn.Name = "sixbtn";
            this.sixbtn.Size = new System.Drawing.Size(74, 56);
            this.sixbtn.TabIndex = 5;
            this.sixbtn.Text = "6";
            this.sixbtn.UseVisualStyleBackColor = true;
            this.sixbtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // onebtn
            // 
            this.onebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onebtn.ForeColor = System.Drawing.Color.Blue;
            this.onebtn.Location = new System.Drawing.Point(71, 177);
            this.onebtn.Name = "onebtn";
            this.onebtn.Size = new System.Drawing.Size(69, 53);
            this.onebtn.TabIndex = 6;
            this.onebtn.Text = "1";
            this.onebtn.UseVisualStyleBackColor = true;
            this.onebtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // twobtn
            // 
            this.twobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twobtn.ForeColor = System.Drawing.Color.Blue;
            this.twobtn.Location = new System.Drawing.Point(136, 177);
            this.twobtn.Name = "twobtn";
            this.twobtn.Size = new System.Drawing.Size(72, 53);
            this.twobtn.TabIndex = 7;
            this.twobtn.Text = "2";
            this.twobtn.UseVisualStyleBackColor = true;
            this.twobtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // threebtn
            // 
            this.threebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threebtn.ForeColor = System.Drawing.Color.Blue;
            this.threebtn.Location = new System.Drawing.Point(204, 177);
            this.threebtn.Name = "threebtn";
            this.threebtn.Size = new System.Drawing.Size(74, 53);
            this.threebtn.TabIndex = 8;
            this.threebtn.Text = "3";
            this.threebtn.UseVisualStyleBackColor = true;
            this.threebtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // zerobtn
            // 
            this.zerobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zerobtn.ForeColor = System.Drawing.Color.Blue;
            this.zerobtn.Location = new System.Drawing.Point(71, 226);
            this.zerobtn.Name = "zerobtn";
            this.zerobtn.Size = new System.Drawing.Size(69, 58);
            this.zerobtn.TabIndex = 9;
            this.zerobtn.Text = "0";
            this.zerobtn.UseVisualStyleBackColor = true;
            this.zerobtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // pointbtn
            // 
            this.pointbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointbtn.ForeColor = System.Drawing.Color.Blue;
            this.pointbtn.Location = new System.Drawing.Point(136, 226);
            this.pointbtn.Name = "pointbtn";
            this.pointbtn.Size = new System.Drawing.Size(72, 58);
            this.pointbtn.TabIndex = 10;
            this.pointbtn.Text = ".";
            this.pointbtn.UseVisualStyleBackColor = true;
            this.pointbtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // equalbtn
            // 
            this.equalbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalbtn.ForeColor = System.Drawing.Color.Red;
            this.equalbtn.Location = new System.Drawing.Point(204, 226);
            this.equalbtn.Name = "equalbtn";
            this.equalbtn.Size = new System.Drawing.Size(74, 58);
            this.equalbtn.TabIndex = 11;
            this.equalbtn.Text = "=";
            this.equalbtn.UseVisualStyleBackColor = true;
            this.equalbtn.Click += new System.EventHandler(this.equalbtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(272, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 39);
            this.button1.TabIndex = 19;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.operator_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(272, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 32);
            this.button2.TabIndex = 20;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.operator_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(465, 400);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultlbl);
            this.Controls.Add(this.ResultTxt);
            this.Controls.Add(this.plusbtn);
            this.Controls.Add(this.dividebtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.equalbtn);
            this.Controls.Add(this.pointbtn);
            this.Controls.Add(this.zerobtn);
            this.Controls.Add(this.threebtn);
            this.Controls.Add(this.twobtn);
            this.Controls.Add(this.onebtn);
            this.Controls.Add(this.sixbtn);
            this.Controls.Add(this.fivebtn);
            this.Controls.Add(this.fourbtn);
            this.Controls.Add(this.ninebtn);
            this.Controls.Add(this.eightbtn);
            this.Controls.Add(this.sevenbtn);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button dividebtn;
        private System.Windows.Forms.Button plusbtn;
        private System.Windows.Forms.TextBox ResultTxt;
        private System.Windows.Forms.Label resultlbl;
        private System.Windows.Forms.Button sevenbtn;
        private System.Windows.Forms.Button eightbtn;
        private System.Windows.Forms.Button ninebtn;
        private System.Windows.Forms.Button fourbtn;
        private System.Windows.Forms.Button fivebtn;
        private System.Windows.Forms.Button sixbtn;
        private System.Windows.Forms.Button onebtn;
        private System.Windows.Forms.Button twobtn;
        private System.Windows.Forms.Button threebtn;
        private System.Windows.Forms.Button zerobtn;
        private System.Windows.Forms.Button pointbtn;
        private System.Windows.Forms.Button equalbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


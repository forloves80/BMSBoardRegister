
namespace BMSBoardRegister
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_hide = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_serialport = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_registered = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_get_n_check = new System.Windows.Forms.Button();
            this.textBox_bmsid = new System.Windows.Forms.TextBox();
            this.comboBox_boardversion = new System.Windows.Forms.ComboBox();
            this.comboBox_etc = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_hide);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_pw);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Webapp Connection";
            // 
            // checkBox_hide
            // 
            this.checkBox_hide.AutoSize = true;
            this.checkBox_hide.Location = new System.Drawing.Point(237, 50);
            this.checkBox_hide.Name = "checkBox_hide";
            this.checkBox_hide.Size = new System.Drawing.Size(49, 16);
            this.checkBox_hide.TabIndex = 4;
            this.checkBox_hide.Text = "Hide";
            this.checkBox_hide.UseVisualStyleBackColor = true;
            this.checkBox_hide.CheckedChanged += new System.EventHandler(this.checkBox_hide_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // textBox_pw
            // 
            this.textBox_pw.Location = new System.Drawing.Point(75, 47);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.Size = new System.Drawing.Size(156, 21);
            this.textBox_pw.TabIndex = 1;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(75, 20);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(156, 21);
            this.textBox_id.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox_serialport);
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BMS Connection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Serial Port";
            // 
            // comboBox_serialport
            // 
            this.comboBox_serialport.FormattingEnabled = true;
            this.comboBox_serialport.Location = new System.Drawing.Point(75, 20);
            this.comboBox_serialport.Name = "comboBox_serialport";
            this.comboBox_serialport.Size = new System.Drawing.Size(156, 20);
            this.comboBox_serialport.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.comboBox_etc);
            this.groupBox3.Controls.Add(this.comboBox_boardversion);
            this.groupBox3.Controls.Add(this.textBox_bmsid);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox_registered);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button_get_n_check);
            this.groupBox3.Location = new System.Drawing.Point(12, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 189);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Board Infomation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "특이사항";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "Board Version";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "BMS ID";
            // 
            // textBox_registered
            // 
            this.textBox_registered.Location = new System.Drawing.Point(100, 49);
            this.textBox_registered.Name = "textBox_registered";
            this.textBox_registered.ReadOnly = true;
            this.textBox_registered.Size = new System.Drawing.Size(177, 21);
            this.textBox_registered.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Registered";
            // 
            // button_get_n_check
            // 
            this.button_get_n_check.Location = new System.Drawing.Point(9, 20);
            this.button_get_n_check.Name = "button_get_n_check";
            this.button_get_n_check.Size = new System.Drawing.Size(268, 23);
            this.button_get_n_check.TabIndex = 0;
            this.button_get_n_check.Text = "Getting && Check";
            this.button_get_n_check.UseVisualStyleBackColor = true;
            // 
            // textBox_bmsid
            // 
            this.textBox_bmsid.Location = new System.Drawing.Point(100, 76);
            this.textBox_bmsid.Name = "textBox_bmsid";
            this.textBox_bmsid.ReadOnly = true;
            this.textBox_bmsid.Size = new System.Drawing.Size(177, 21);
            this.textBox_bmsid.TabIndex = 11;
            // 
            // comboBox_boardversion
            // 
            this.comboBox_boardversion.FormattingEnabled = true;
            this.comboBox_boardversion.Location = new System.Drawing.Point(100, 103);
            this.comboBox_boardversion.Name = "comboBox_boardversion";
            this.comboBox_boardversion.Size = new System.Drawing.Size(177, 20);
            this.comboBox_boardversion.TabIndex = 2;
            // 
            // comboBox_etc
            // 
            this.comboBox_etc.FormattingEnabled = true;
            this.comboBox_etc.Location = new System.Drawing.Point(100, 129);
            this.comboBox_etc.Name = "comboBox_etc";
            this.comboBox_etc.Size = new System.Drawing.Size(177, 20);
            this.comboBox_etc.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save to Webapp";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 361);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BMS Board Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_hide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_serialport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_registered;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_get_n_check;
        private System.Windows.Forms.ComboBox comboBox_etc;
        private System.Windows.Forms.ComboBox comboBox_boardversion;
        private System.Windows.Forms.TextBox textBox_bmsid;
        private System.Windows.Forms.Button button1;
    }
}


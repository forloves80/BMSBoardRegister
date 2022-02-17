
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
            this.button_openSerial = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_serialport = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_save = new System.Windows.Forms.Button();
            this.comboBox_etc = new System.Windows.Forms.ComboBox();
            this.comboBox_boardversion = new System.Windows.Forms.ComboBox();
            this.textBox_bmsid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_registered = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_get_n_check = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.button_clearlog = new System.Windows.Forms.Button();
            this.checkBox_stoplog = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.button_openSerial);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox_serialport);
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BMS Connection";
            // 
            // button_openSerial
            // 
            this.button_openSerial.Location = new System.Drawing.Point(216, 18);
            this.button_openSerial.Name = "button_openSerial";
            this.button_openSerial.Size = new System.Drawing.Size(65, 23);
            this.button_openSerial.TabIndex = 2;
            this.button_openSerial.Text = "Open";
            this.button_openSerial.UseVisualStyleBackColor = true;
            this.button_openSerial.Click += new System.EventHandler(this.button_openSerial_Click);
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
            this.comboBox_serialport.Size = new System.Drawing.Size(135, 20);
            this.comboBox_serialport.TabIndex = 0;
            this.comboBox_serialport.DropDown += new System.EventHandler(this.comboBox_serialport_DropDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_save);
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
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(9, 155);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(268, 23);
            this.button_save.TabIndex = 13;
            this.button_save.Text = "Save to Webapp";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // comboBox_etc
            // 
            this.comboBox_etc.FormattingEnabled = true;
            this.comboBox_etc.Location = new System.Drawing.Point(100, 129);
            this.comboBox_etc.Name = "comboBox_etc";
            this.comboBox_etc.Size = new System.Drawing.Size(177, 20);
            this.comboBox_etc.TabIndex = 12;
            // 
            // comboBox_boardversion
            // 
            this.comboBox_boardversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_boardversion.FormattingEnabled = true;
            this.comboBox_boardversion.Location = new System.Drawing.Point(100, 103);
            this.comboBox_boardversion.Name = "comboBox_boardversion";
            this.comboBox_boardversion.Size = new System.Drawing.Size(177, 20);
            this.comboBox_boardversion.TabIndex = 2;
            // 
            // textBox_bmsid
            // 
            this.textBox_bmsid.Location = new System.Drawing.Point(100, 76);
            this.textBox_bmsid.Name = "textBox_bmsid";
            this.textBox_bmsid.ReadOnly = true;
            this.textBox_bmsid.Size = new System.Drawing.Size(177, 21);
            this.textBox_bmsid.TabIndex = 11;
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
            this.button_get_n_check.Click += new System.EventHandler(this.button_get_n_check_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_log);
            this.groupBox4.Controls.Add(this.button_clearlog);
            this.groupBox4.Controls.Add(this.checkBox_stoplog);
            this.groupBox4.Location = new System.Drawing.Point(305, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(465, 337);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serial Log";
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(6, 42);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_log.Size = new System.Drawing.Size(453, 284);
            this.textBox_log.TabIndex = 2;
            this.textBox_log.WordWrap = false;
            // 
            // button_clearlog
            // 
            this.button_clearlog.Location = new System.Drawing.Point(384, 16);
            this.button_clearlog.Name = "button_clearlog";
            this.button_clearlog.Size = new System.Drawing.Size(75, 23);
            this.button_clearlog.TabIndex = 1;
            this.button_clearlog.Text = "Clear Logs";
            this.button_clearlog.UseVisualStyleBackColor = true;
            this.button_clearlog.Click += new System.EventHandler(this.button_clearlog_Click);
            // 
            // checkBox_stoplog
            // 
            this.checkBox_stoplog.AutoSize = true;
            this.checkBox_stoplog.Location = new System.Drawing.Point(6, 20);
            this.checkBox_stoplog.Name = "checkBox_stoplog";
            this.checkBox_stoplog.Size = new System.Drawing.Size(98, 16);
            this.checkBox_stoplog.TabIndex = 0;
            this.checkBox_stoplog.Text = "Stop Logging";
            this.checkBox_stoplog.UseVisualStyleBackColor = true;
            this.checkBox_stoplog.CheckedChanged += new System.EventHandler(this.checkBox_stoplog_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 355);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BMS Board Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ForeColorChanged += new System.EventHandler(this.Form1_ForeColorChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_openSerial;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Button button_clearlog;
        private System.Windows.Forms.CheckBox checkBox_stoplog;
    }
}


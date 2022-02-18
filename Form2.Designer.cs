
namespace BMSBoardRegister
{
    partial class Form2
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
            this.progressBar_running = new System.Windows.Forms.ProgressBar();
            this.label_state = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar_running
            // 
            this.progressBar_running.Location = new System.Drawing.Point(12, 24);
            this.progressBar_running.Name = "progressBar_running";
            this.progressBar_running.Size = new System.Drawing.Size(301, 23);
            this.progressBar_running.TabIndex = 0;
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Location = new System.Drawing.Point(12, 9);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(63, 12);
            this.label_state.TabIndex = 1;
            this.label_state.Text = "label state";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(238, 24);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Visible = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 57);
            this.ControlBox = false;
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_state);
            this.Controls.Add(this.progressBar_running);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Processing";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar_running;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Button button_close;
    }
}
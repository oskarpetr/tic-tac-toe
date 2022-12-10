namespace TicTacToe.Forms {
    partial class WinForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this._panel = new System.Windows.Forms.Panel();
            this._buttonNext = new System.Windows.Forms.Button();
            this._buttonHome = new System.Windows.Forms.Button();
            this._labelSubtitle = new System.Windows.Forms.Label();
            this._labelTitle = new System.Windows.Forms.Label();
            this._panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.AutoSize = true;
            this._panel.BackColor = System.Drawing.Color.Transparent;
            this._panel.Controls.Add(this._buttonNext);
            this._panel.Controls.Add(this._buttonHome);
            this._panel.Controls.Add(this._labelSubtitle);
            this._panel.Controls.Add(this._labelTitle);
            this._panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panel.Location = new System.Drawing.Point(0, 0);
            this._panel.Name = "_panel";
            this._panel.Padding = new System.Windows.Forms.Padding(50, 30, 50, 30);
            this._panel.Size = new System.Drawing.Size(462, 193);
            this._panel.TabIndex = 7;
            // 
            // _buttonNext
            // 
            this._buttonNext.Location = new System.Drawing.Point(160, 143);
            this._buttonNext.Name = "_buttonNext";
            this._buttonNext.Size = new System.Drawing.Size(282, 29);
            this._buttonNext.TabIndex = 7;
            this._buttonNext.Text = "Continue to next level";
            this._buttonNext.UseVisualStyleBackColor = true;
            this._buttonNext.Click += new System.EventHandler(this._buttonNext_Click);
            // 
            // _buttonHome
            // 
            this._buttonHome.Location = new System.Drawing.Point(50, 143);
            this._buttonHome.Name = "_buttonHome";
            this._buttonHome.Size = new System.Drawing.Size(104, 29);
            this._buttonHome.TabIndex = 6;
            this._buttonHome.Text = "Home";
            this._buttonHome.UseVisualStyleBackColor = true;
            this._buttonHome.Click += new System.EventHandler(this._buttonHome_Click);
            // 
            // _labelSubtitle
            // 
            this._labelSubtitle.AutoSize = true;
            this._labelSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this._labelSubtitle.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._labelSubtitle.Location = new System.Drawing.Point(50, 78);
            this._labelSubtitle.Name = "_labelSubtitle";
            this._labelSubtitle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this._labelSubtitle.Size = new System.Drawing.Size(55, 26);
            this._labelSubtitle.TabIndex = 5;
            this._labelSubtitle.Text = "Score";
            // 
            // _labelTitle
            // 
            this._labelTitle.AutoSize = true;
            this._labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this._labelTitle.Font = new System.Drawing.Font("SF Pro Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._labelTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this._labelTitle.Location = new System.Drawing.Point(50, 30);
            this._labelTitle.Name = "_labelTitle";
            this._labelTitle.Size = new System.Drawing.Size(152, 48);
            this._labelTitle.TabIndex = 4;
            this._labelTitle.Text = "Winner";
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(462, 193);
            this.Controls.Add(this._panel);
            this.Name = "WinForm";
            this.Text = "Winner";
            this._panel.ResumeLayout(false);
            this._panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel _panel;
        private Button _buttonNext;
        private Button _buttonHome;
        private Label _labelSubtitle;
        private Label _labelTitle;
    }
}
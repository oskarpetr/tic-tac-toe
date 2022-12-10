namespace TicTacToe.Forms {
    partial class RegisterForm {
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
            this._inputPassword = new TicTacToe.Controls.Input();
            this._labelPassword = new System.Windows.Forms.Label();
            this._inputName = new TicTacToe.Controls.Input();
            this._labelName = new System.Windows.Forms.Label();
            this._labelSubtitle = new System.Windows.Forms.Label();
            this._labelTitle = new System.Windows.Forms.Label();
            this._buttonRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _inputPassword
            // 
            this._inputPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this._inputPassword.Location = new System.Drawing.Point(50, 265);
            this._inputPassword.Name = "_inputPassword";
            this._inputPassword.Size = new System.Drawing.Size(300, 35);
            this._inputPassword.TabIndex = 29;
            // 
            // _labelPassword
            // 
            this._labelPassword.AutoSize = true;
            this._labelPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this._labelPassword.Font = new System.Drawing.Font("SF Pro Rounded", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._labelPassword.ForeColor = System.Drawing.Color.Black;
            this._labelPassword.Location = new System.Drawing.Point(50, 217);
            this._labelPassword.Name = "_labelPassword";
            this._labelPassword.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this._labelPassword.Size = new System.Drawing.Size(115, 48);
            this._labelPassword.TabIndex = 28;
            this._labelPassword.Text = "Password";
            // 
            // _inputName
            // 
            this._inputName.Dock = System.Windows.Forms.DockStyle.Top;
            this._inputName.Location = new System.Drawing.Point(50, 182);
            this._inputName.Name = "_inputName";
            this._inputName.Size = new System.Drawing.Size(300, 35);
            this._inputName.TabIndex = 27;
            // 
            // _labelName
            // 
            this._labelName.AutoSize = true;
            this._labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this._labelName.Font = new System.Drawing.Font("SF Pro Rounded", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._labelName.ForeColor = System.Drawing.Color.Black;
            this._labelName.Location = new System.Drawing.Point(50, 104);
            this._labelName.Name = "_labelName";
            this._labelName.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this._labelName.Size = new System.Drawing.Size(74, 78);
            this._labelName.TabIndex = 26;
            this._labelName.Text = "Name";
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
            this._labelSubtitle.Size = new System.Drawing.Size(189, 26);
            this._labelSubtitle.TabIndex = 25;
            this._labelSubtitle.Text = "Register a new account.";
            // 
            // _labelTitle
            // 
            this._labelTitle.AutoSize = true;
            this._labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this._labelTitle.Font = new System.Drawing.Font("SF Pro Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._labelTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this._labelTitle.Location = new System.Drawing.Point(50, 30);
            this._labelTitle.Name = "_labelTitle";
            this._labelTitle.Size = new System.Drawing.Size(174, 48);
            this._labelTitle.TabIndex = 24;
            this._labelTitle.Text = "Register";
            // 
            // _buttonRegister
            // 
            this._buttonRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._buttonRegister.Location = new System.Drawing.Point(50, 349);
            this._buttonRegister.Name = "_buttonRegister";
            this._buttonRegister.Size = new System.Drawing.Size(300, 29);
            this._buttonRegister.TabIndex = 23;
            this._buttonRegister.Text = "Register";
            this._buttonRegister.UseVisualStyleBackColor = true;
            this._buttonRegister.Click += new System.EventHandler(this._buttonRegister_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 408);
            this.Controls.Add(this._inputPassword);
            this.Controls.Add(this._labelPassword);
            this.Controls.Add(this._inputName);
            this.Controls.Add(this._labelName);
            this.Controls.Add(this._labelSubtitle);
            this.Controls.Add(this._labelTitle);
            this.Controls.Add(this._buttonRegister);
            this.Name = "RegisterForm";
            this.Padding = new System.Windows.Forms.Padding(50, 30, 50, 30);
            this.Text = "RegisterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.Input _inputPassword;
        private Label _labelPassword;
        private Controls.Input _inputName;
        private Label _labelName;
        private Label _labelSubtitle;
        private Label _labelTitle;
        private Button _buttonRegister;
    }
}
namespace TicTacToe.Controls {
    partial class Input {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this._panelInput = new System.Windows.Forms.Panel();
            this._input = new System.Windows.Forms.TextBox();
            this._panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelInput
            // 
            this._panelInput.AutoSize = true;
            this._panelInput.BackColor = System.Drawing.SystemColors.ControlLight;
            this._panelInput.Controls.Add(this._input);
            this._panelInput.ForeColor = System.Drawing.Color.Azure;
            this._panelInput.Location = new System.Drawing.Point(0, 5);
            this._panelInput.Name = "_panelInput";
            this._panelInput.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this._panelInput.Size = new System.Drawing.Size(300, 30);
            this._panelInput.TabIndex = 13;
            // 
            // _input
            // 
            this._input.BackColor = System.Drawing.SystemColors.ControlLight;
            this._input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._input.Dock = System.Windows.Forms.DockStyle.Fill;
            this._input.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._input.Location = new System.Drawing.Point(15, 5);
            this._input.Name = "_input";
            this._input.Size = new System.Drawing.Size(270, 22);
            this._input.TabIndex = 10;
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._panelInput);
            this.Name = "Input";
            this.Size = new System.Drawing.Size(300, 35);
            this._panelInput.ResumeLayout(false);
            this._panelInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel _panelInput;
        private TextBox _input;
    }
}

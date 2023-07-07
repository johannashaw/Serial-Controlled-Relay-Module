namespace Device_Setup
{
    partial class Form_ArduinoRelaySetup
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
            this.tb_ToSend = new System.Windows.Forms.TextBox();
            this.butt_Send = new System.Windows.Forms.Button();
            this.lb_inc = new System.Windows.Forms.Label();
            this.nud_relayNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_relayNum)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_ToSend
            // 
            this.tb_ToSend.Location = new System.Drawing.Point(18, 18);
            this.tb_ToSend.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tb_ToSend.Name = "tb_ToSend";
            this.tb_ToSend.Size = new System.Drawing.Size(134, 26);
            this.tb_ToSend.TabIndex = 0;
            this.tb_ToSend.Text = "R";
            this.tb_ToSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // butt_Send
            // 
            this.butt_Send.Location = new System.Drawing.Point(266, 18);
            this.butt_Send.Name = "butt_Send";
            this.butt_Send.Size = new System.Drawing.Size(88, 26);
            this.butt_Send.TabIndex = 1;
            this.butt_Send.Text = "Send";
            this.butt_Send.UseVisualStyleBackColor = true;
            // 
            // lb_inc
            // 
            this.lb_inc.AutoSize = true;
            this.lb_inc.Location = new System.Drawing.Point(209, 21);
            this.lb_inc.Name = "lb_inc";
            this.lb_inc.Size = new System.Drawing.Size(18, 20);
            this.lb_inc.TabIndex = 2;
            this.lb_inc.Text = "+";
            // 
            // nud_relayNum
            // 
            this.nud_relayNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_relayNum.Location = new System.Drawing.Point(160, 19);
            this.nud_relayNum.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nud_relayNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_relayNum.Name = "nud_relayNum";
            this.nud_relayNum.Size = new System.Drawing.Size(43, 26);
            this.nud_relayNum.TabIndex = 3;
            this.nud_relayNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form_ArduinoRelaySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 420);
            this.Controls.Add(this.nud_relayNum);
            this.Controls.Add(this.lb_inc);
            this.Controls.Add(this.butt_Send);
            this.Controls.Add(this.tb_ToSend);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form_ArduinoRelaySetup";
            this.Text = "Arduino Relay Setup";
            this.TransparencyKey = System.Drawing.Color.Lime;
            ((System.ComponentModel.ISupportInitialize)(this.nud_relayNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ToSend;
        private System.Windows.Forms.Button butt_Send;
        private System.Windows.Forms.Label lb_inc;
        private System.Windows.Forms.NumericUpDown nud_relayNum;
    }
}


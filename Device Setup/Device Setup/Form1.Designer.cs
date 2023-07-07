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
            this.tb_in = new System.Windows.Forms.TextBox();
            this.tb_out = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dd_Ports = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.DGV_Relays = new System.Windows.Forms.DataGridView();
            this.tb_test = new System.Windows.Forms.TextBox();
            this.butt_Refresh = new System.Windows.Forms.Button();
            this.butt_Reset = new System.Windows.Forms.Button();
            this.lb_ErrorOut = new System.Windows.Forms.Label();
            this.gb_NerdStuff = new System.Windows.Forms.GroupBox();
            this.gb_Edit = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Relay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Relays)).BeginInit();
            this.gb_NerdStuff.SuspendLayout();
            this.gb_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_ToSend
            // 
            this.tb_ToSend.Location = new System.Drawing.Point(80, 30);
            this.tb_ToSend.Margin = new System.Windows.Forms.Padding(5);
            this.tb_ToSend.Name = "tb_ToSend";
            this.tb_ToSend.Size = new System.Drawing.Size(134, 26);
            this.tb_ToSend.TabIndex = 0;
            this.tb_ToSend.Text = "R";
            this.tb_ToSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // butt_Send
            // 
            this.butt_Send.Location = new System.Drawing.Point(173, 117);
            this.butt_Send.Name = "butt_Send";
            this.butt_Send.Size = new System.Drawing.Size(88, 36);
            this.butt_Send.TabIndex = 1;
            this.butt_Send.Text = "Send";
            this.butt_Send.UseVisualStyleBackColor = true;
            this.butt_Send.Click += new System.EventHandler(this.butt_Send_Click);
            // 
            // lb_inc
            // 
            this.lb_inc.AutoSize = true;
            this.lb_inc.Location = new System.Drawing.Point(6, 33);
            this.lb_inc.Name = "lb_inc";
            this.lb_inc.Size = new System.Drawing.Size(55, 20);
            this.lb_inc.TabIndex = 2;
            this.lb_inc.Text = "Name:";
            // 
            // tb_in
            // 
            this.tb_in.Location = new System.Drawing.Point(31, 211);
            this.tb_in.Multiline = true;
            this.tb_in.Name = "tb_in";
            this.tb_in.Size = new System.Drawing.Size(151, 232);
            this.tb_in.TabIndex = 4;
            // 
            // tb_out
            // 
            this.tb_out.Location = new System.Drawing.Point(245, 211);
            this.tb_out.Multiline = true;
            this.tb_out.Name = "tb_out";
            this.tb_out.Size = new System.Drawing.Size(181, 221);
            this.tb_out.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Received:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sent:";
            // 
            // dd_Ports
            // 
            this.dd_Ports.FormattingEnabled = true;
            this.dd_Ports.Items.AddRange(new object[] {
            "1"});
            this.dd_Ports.Location = new System.Drawing.Point(183, 12);
            this.dd_Ports.Name = "dd_Ports";
            this.dd_Ports.Size = new System.Drawing.Size(121, 28);
            this.dd_Ports.TabIndex = 8;
            this.dd_Ports.SelectedIndexChanged += new System.EventHandler(this.dd_Ports_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select the Serial Port:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 141);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(119, 24);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // DGV_Relays
            // 
            this.DGV_Relays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Relays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Relay,
            this.Name,
            this.Delay,
            this.toEdit});
            this.DGV_Relays.Location = new System.Drawing.Point(30, 232);
            this.DGV_Relays.Name = "DGV_Relays";
            this.DGV_Relays.RowHeadersVisible = false;
            this.DGV_Relays.Size = new System.Drawing.Size(401, 337);
            this.DGV_Relays.TabIndex = 11;
            // 
            // tb_test
            // 
            this.tb_test.Location = new System.Drawing.Point(67, 127);
            this.tb_test.Name = "tb_test";
            this.tb_test.Size = new System.Drawing.Size(100, 26);
            this.tb_test.TabIndex = 12;
            // 
            // butt_Refresh
            // 
            this.butt_Refresh.Location = new System.Drawing.Point(306, 117);
            this.butt_Refresh.Name = "butt_Refresh";
            this.butt_Refresh.Size = new System.Drawing.Size(96, 36);
            this.butt_Refresh.TabIndex = 13;
            this.butt_Refresh.Text = "Refresh";
            this.butt_Refresh.UseVisualStyleBackColor = true;
            this.butt_Refresh.Click += new System.EventHandler(this.SendCharButton_Click);
            // 
            // butt_Reset
            // 
            this.butt_Reset.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.butt_Reset.Location = new System.Drawing.Point(306, 62);
            this.butt_Reset.Name = "butt_Reset";
            this.butt_Reset.Size = new System.Drawing.Size(96, 36);
            this.butt_Reset.TabIndex = 14;
            this.butt_Reset.Text = "Reset";
            this.butt_Reset.UseVisualStyleBackColor = true;
            this.butt_Reset.Click += new System.EventHandler(this.SendCharButton_Click);
            // 
            // lb_ErrorOut
            // 
            this.lb_ErrorOut.AutoSize = true;
            this.lb_ErrorOut.Location = new System.Drawing.Point(380, 20);
            this.lb_ErrorOut.Name = "lb_ErrorOut";
            this.lb_ErrorOut.Size = new System.Drawing.Size(51, 20);
            this.lb_ErrorOut.TabIndex = 15;
            this.lb_ErrorOut.Text = "label4";
            // 
            // gb_NerdStuff
            // 
            this.gb_NerdStuff.Controls.Add(this.tb_out);
            this.gb_NerdStuff.Controls.Add(this.butt_Send);
            this.gb_NerdStuff.Controls.Add(this.butt_Reset);
            this.gb_NerdStuff.Controls.Add(this.tb_in);
            this.gb_NerdStuff.Controls.Add(this.butt_Refresh);
            this.gb_NerdStuff.Controls.Add(this.label1);
            this.gb_NerdStuff.Controls.Add(this.tb_test);
            this.gb_NerdStuff.Controls.Add(this.label2);
            this.gb_NerdStuff.Enabled = false;
            this.gb_NerdStuff.Location = new System.Drawing.Point(614, 170);
            this.gb_NerdStuff.Name = "gb_NerdStuff";
            this.gb_NerdStuff.Size = new System.Drawing.Size(592, 566);
            this.gb_NerdStuff.TabIndex = 16;
            this.gb_NerdStuff.TabStop = false;
            this.gb_NerdStuff.Text = "Nerd Stuff";
            // 
            // gb_Edit
            // 
            this.gb_Edit.Controls.Add(this.trackBar1);
            this.gb_Edit.Controls.Add(this.label4);
            this.gb_Edit.Controls.Add(this.tb_ToSend);
            this.gb_Edit.Controls.Add(this.lb_inc);
            this.gb_Edit.Enabled = false;
            this.gb_Edit.Location = new System.Drawing.Point(614, 15);
            this.gb_Edit.Name = "gb_Edit";
            this.gb_Edit.Size = new System.Drawing.Size(402, 126);
            this.gb_Edit.TabIndex = 15;
            this.gb_Edit.TabStop = false;
            this.gb_Edit.Text = "Edit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Delay:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(80, 75);
            this.trackBar1.Maximum = 223;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(316, 45);
            this.trackBar1.TabIndex = 17;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Relay
            // 
            this.Relay.Frozen = true;
            this.Relay.HeaderText = "Relay #";
            this.Relay.Name = "Relay";
            this.Relay.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.Frozen = true;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Delay
            // 
            this.Delay.Frozen = true;
            this.Delay.HeaderText = "Delay[s]";
            this.Delay.Name = "Delay";
            this.Delay.ReadOnly = true;
            // 
            // toEdit
            // 
            this.toEdit.Frozen = true;
            this.toEdit.HeaderText = "Edit";
            this.toEdit.Name = "toEdit";
            this.toEdit.ReadOnly = true;
            // 
            // Form_ArduinoRelaySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 748);
            this.Controls.Add(this.gb_Edit);
            this.Controls.Add(this.gb_NerdStuff);
            this.Controls.Add(this.lb_ErrorOut);
            this.Controls.Add(this.DGV_Relays);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dd_Ports);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_ArduinoRelaySetup";
            this.Text = "Arduino Relay Setup";
            this.TransparencyKey = System.Drawing.Color.Lime;
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Relays)).EndInit();
            this.gb_NerdStuff.ResumeLayout(false);
            this.gb_NerdStuff.PerformLayout();
            this.gb_Edit.ResumeLayout(false);
            this.gb_Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ToSend;
        private System.Windows.Forms.Button butt_Send;
        private System.Windows.Forms.Label lb_inc;
        private System.Windows.Forms.TextBox tb_in;
        private System.Windows.Forms.TextBox tb_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dd_Ports;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView DGV_Relays;
        private System.Windows.Forms.TextBox tb_test;
        private System.Windows.Forms.Button butt_Refresh;
        private System.Windows.Forms.Button butt_Reset;
        private System.Windows.Forms.Label lb_ErrorOut;
        private System.Windows.Forms.GroupBox gb_NerdStuff;
        private System.Windows.Forms.GroupBox gb_Edit;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Relay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay;
        private System.Windows.Forms.DataGridViewTextBoxColumn toEdit;
    }
}


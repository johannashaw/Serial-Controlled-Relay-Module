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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_ToSend = new System.Windows.Forms.TextBox();
            this.butt_Send = new System.Windows.Forms.Button();
            this.lb_inc = new System.Windows.Forms.Label();
            this.tb_in = new System.Windows.Forms.TextBox();
            this.tb_out = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dd_Ports = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_test = new System.Windows.Forms.TextBox();
            this.butt_Refresh = new System.Windows.Forms.Button();
            this.butt_Reset = new System.Windows.Forms.Button();
            this.lb_ErrorOut = new System.Windows.Forms.Label();
            this.gb_NerdStuff = new System.Windows.Forms.GroupBox();
            this.gb_Edit = new System.Windows.Forms.GroupBox();
            this.butt_Save = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_Relays = new System.Windows.Forms.DataGridView();
            this.col_Relay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_MainUI = new System.Windows.Forms.GroupBox();
            this.butt_TestOff = new System.Windows.Forms.Button();
            this.butt_edit = new System.Windows.Forms.Button();
            this.butt_TestAdd = new System.Windows.Forms.Button();
            this.cb_NerdStuff = new System.Windows.Forms.CheckBox();
            this.gb_NerdStuff.SuspendLayout();
            this.gb_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Relays)).BeginInit();
            this.gb_MainUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_ToSend
            // 
            this.tb_ToSend.Location = new System.Drawing.Point(69, 30);
            this.tb_ToSend.Margin = new System.Windows.Forms.Padding(5);
            this.tb_ToSend.Name = "tb_ToSend";
            this.tb_ToSend.Size = new System.Drawing.Size(208, 26);
            this.tb_ToSend.TabIndex = 0;
            this.tb_ToSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // butt_Send
            // 
            this.butt_Send.Location = new System.Drawing.Point(120, 28);
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
            this.tb_in.Location = new System.Drawing.Point(14, 99);
            this.tb_in.Multiline = true;
            this.tb_in.Name = "tb_in";
            this.tb_in.Size = new System.Drawing.Size(194, 220);
            this.tb_in.TabIndex = 4;
            // 
            // tb_out
            // 
            this.tb_out.Location = new System.Drawing.Point(14, 354);
            this.tb_out.Multiline = true;
            this.tb_out.Name = "tb_out";
            this.tb_out.Size = new System.Drawing.Size(194, 220);
            this.tb_out.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Received:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sent:";
            // 
            // dd_Ports
            // 
            this.dd_Ports.FormattingEnabled = true;
            this.dd_Ports.Location = new System.Drawing.Point(183, 12);
            this.dd_Ports.Name = "dd_Ports";
            this.dd_Ports.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dd_Ports.Size = new System.Drawing.Size(95, 28);
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
            // tb_test
            // 
            this.tb_test.Location = new System.Drawing.Point(14, 33);
            this.tb_test.Name = "tb_test";
            this.tb_test.Size = new System.Drawing.Size(100, 26);
            this.tb_test.TabIndex = 12;
            // 
            // butt_Refresh
            // 
            this.butt_Refresh.Location = new System.Drawing.Point(120, 596);
            this.butt_Refresh.Name = "butt_Refresh";
            this.butt_Refresh.Size = new System.Drawing.Size(88, 36);
            this.butt_Refresh.TabIndex = 13;
            this.butt_Refresh.Text = "Refresh";
            this.butt_Refresh.UseVisualStyleBackColor = true;
            this.butt_Refresh.Click += new System.EventHandler(this.SendCharButton_Click);
            // 
            // butt_Reset
            // 
            this.butt_Reset.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.butt_Reset.Location = new System.Drawing.Point(14, 596);
            this.butt_Reset.Name = "butt_Reset";
            this.butt_Reset.Size = new System.Drawing.Size(88, 36);
            this.butt_Reset.TabIndex = 14;
            this.butt_Reset.Text = "Reset";
            this.butt_Reset.UseVisualStyleBackColor = true;
            this.butt_Reset.Click += new System.EventHandler(this.SendCharButton_Click);
            // 
            // lb_ErrorOut
            // 
            this.lb_ErrorOut.AutoSize = true;
            this.lb_ErrorOut.ForeColor = System.Drawing.Color.Maroon;
            this.lb_ErrorOut.Location = new System.Drawing.Point(19, 51);
            this.lb_ErrorOut.MaximumSize = new System.Drawing.Size(400, 0);
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
            this.gb_NerdStuff.Location = new System.Drawing.Point(465, 15);
            this.gb_NerdStuff.Name = "gb_NerdStuff";
            this.gb_NerdStuff.Size = new System.Drawing.Size(232, 651);
            this.gb_NerdStuff.TabIndex = 16;
            this.gb_NerdStuff.TabStop = false;
            this.gb_NerdStuff.Text = "Nerd Stuff";
            // 
            // gb_Edit
            // 
            this.gb_Edit.Controls.Add(this.butt_Save);
            this.gb_Edit.Controls.Add(this.trackBar1);
            this.gb_Edit.Controls.Add(this.label4);
            this.gb_Edit.Controls.Add(this.tb_ToSend);
            this.gb_Edit.Controls.Add(this.lb_inc);
            this.gb_Edit.Enabled = false;
            this.gb_Edit.Location = new System.Drawing.Point(23, 463);
            this.gb_Edit.Name = "gb_Edit";
            this.gb_Edit.Size = new System.Drawing.Size(426, 203);
            this.gb_Edit.TabIndex = 15;
            this.gb_Edit.TabStop = false;
            this.gb_Edit.Text = "Edit";
            // 
            // butt_Save
            // 
            this.butt_Save.Location = new System.Drawing.Point(285, 25);
            this.butt_Save.Name = "butt_Save";
            this.butt_Save.Size = new System.Drawing.Size(135, 35);
            this.butt_Save.TabIndex = 21;
            this.butt_Save.Text = "Save to Device";
            this.butt_Save.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(80, 82);
            this.trackBar1.Maximum = 223;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(316, 45);
            this.trackBar1.TabIndex = 17;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
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
            // DGV_Relays
            // 
            this.DGV_Relays.AllowUserToAddRows = false;
            this.DGV_Relays.AllowUserToDeleteRows = false;
            this.DGV_Relays.AllowUserToResizeColumns = false;
            this.DGV_Relays.AllowUserToResizeRows = false;
            this.DGV_Relays.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Relays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Relays.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_Relays.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Relays.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Relays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Relays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Relay,
            this.col_name,
            this.col_Delay});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Relays.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Relays.EnableHeadersVisualStyles = false;
            this.DGV_Relays.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_Relays.Location = new System.Drawing.Point(34, 39);
            this.DGV_Relays.MultiSelect = false;
            this.DGV_Relays.Name = "DGV_Relays";
            this.DGV_Relays.ReadOnly = true;
            this.DGV_Relays.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Relays.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Relays.RowHeadersVisible = false;
            this.DGV_Relays.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            this.DGV_Relays.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Relays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Relays.ShowCellErrors = false;
            this.DGV_Relays.ShowEditingIcon = false;
            this.DGV_Relays.Size = new System.Drawing.Size(362, 246);
            this.DGV_Relays.TabIndex = 17;
            this.DGV_Relays.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Relays_CellMouseDoubleClick);
            // 
            // col_Relay
            // 
            this.col_Relay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_Relay.Frozen = true;
            this.col_Relay.HeaderText = "Relay";
            this.col_Relay.Name = "col_Relay";
            this.col_Relay.ReadOnly = true;
            this.col_Relay.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_Relay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.col_Relay.Width = 79;
            // 
            // col_name
            // 
            this.col_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_name.Frozen = true;
            this.col_name.HeaderText = "Name";
            this.col_name.MinimumWidth = 100;
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            this.col_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_Delay
            // 
            this.col_Delay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_Delay.Frozen = true;
            this.col_Delay.HeaderText = "Delay [s]";
            this.col_Delay.Name = "col_Delay";
            this.col_Delay.ReadOnly = true;
            this.col_Delay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_Delay.Width = 80;
            // 
            // gb_MainUI
            // 
            this.gb_MainUI.Controls.Add(this.butt_TestOff);
            this.gb_MainUI.Controls.Add(this.butt_edit);
            this.gb_MainUI.Controls.Add(this.DGV_Relays);
            this.gb_MainUI.Controls.Add(this.butt_TestAdd);
            this.gb_MainUI.Enabled = false;
            this.gb_MainUI.Location = new System.Drawing.Point(23, 113);
            this.gb_MainUI.Name = "gb_MainUI";
            this.gb_MainUI.Size = new System.Drawing.Size(426, 344);
            this.gb_MainUI.TabIndex = 18;
            this.gb_MainUI.TabStop = false;
            this.gb_MainUI.Text = "List o\' Relays";
            // 
            // butt_TestOff
            // 
            this.butt_TestOff.Location = new System.Drawing.Point(324, 291);
            this.butt_TestOff.Name = "butt_TestOff";
            this.butt_TestOff.Size = new System.Drawing.Size(96, 35);
            this.butt_TestOff.TabIndex = 20;
            this.butt_TestOff.Text = "Test Off";
            this.butt_TestOff.UseVisualStyleBackColor = true;
            this.butt_TestOff.Click += new System.EventHandler(this.butt_off_Click);
            // 
            // butt_edit
            // 
            this.butt_edit.Location = new System.Drawing.Point(10, 291);
            this.butt_edit.Name = "butt_edit";
            this.butt_edit.Size = new System.Drawing.Size(96, 35);
            this.butt_edit.TabIndex = 18;
            this.butt_edit.Text = "Edit";
            this.butt_edit.UseVisualStyleBackColor = true;
            this.butt_edit.Click += new System.EventHandler(this.butt_edit_Click);
            // 
            // butt_TestAdd
            // 
            this.butt_TestAdd.Location = new System.Drawing.Point(222, 291);
            this.butt_TestAdd.Name = "butt_TestAdd";
            this.butt_TestAdd.Size = new System.Drawing.Size(96, 35);
            this.butt_TestAdd.TabIndex = 19;
            this.butt_TestAdd.Text = "Test Add";
            this.butt_TestAdd.UseVisualStyleBackColor = true;
            this.butt_TestAdd.Click += new System.EventHandler(this.butt_add_Click);
            // 
            // cb_NerdStuff
            // 
            this.cb_NerdStuff.AutoSize = true;
            this.cb_NerdStuff.Location = new System.Drawing.Point(310, 14);
            this.cb_NerdStuff.Name = "cb_NerdStuff";
            this.cb_NerdStuff.Size = new System.Drawing.Size(139, 24);
            this.cb_NerdStuff.TabIndex = 19;
            this.cb_NerdStuff.Text = "View Nerd Stuff";
            this.cb_NerdStuff.UseVisualStyleBackColor = true;
            this.cb_NerdStuff.CheckedChanged += new System.EventHandler(this.cb_NerdStuff_CheckedChanged);
            // 
            // Form_ArduinoRelaySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 681);
            this.Controls.Add(this.cb_NerdStuff);
            this.Controls.Add(this.gb_MainUI);
            this.Controls.Add(this.gb_Edit);
            this.Controls.Add(this.gb_NerdStuff);
            this.Controls.Add(this.lb_ErrorOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dd_Ports);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_ArduinoRelaySetup";
            this.Text = "Arduino Relay Setup";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.gb_NerdStuff.ResumeLayout(false);
            this.gb_NerdStuff.PerformLayout();
            this.gb_Edit.ResumeLayout(false);
            this.gb_Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Relays)).EndInit();
            this.gb_MainUI.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox tb_test;
        private System.Windows.Forms.Button butt_Refresh;
        private System.Windows.Forms.Button butt_Reset;
        private System.Windows.Forms.Label lb_ErrorOut;
        private System.Windows.Forms.GroupBox gb_NerdStuff;
        private System.Windows.Forms.GroupBox gb_Edit;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV_Relays;
        private System.Windows.Forms.GroupBox gb_MainUI;
        private System.Windows.Forms.CheckBox cb_NerdStuff;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Relay;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Delay;
        private System.Windows.Forms.Button butt_edit;
        private System.Windows.Forms.Button butt_TestOff;
        private System.Windows.Forms.Button butt_TestAdd;
        private System.Windows.Forms.Button butt_Save;
    }
}


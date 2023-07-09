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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.butt_Send = new System.Windows.Forms.Button();
            this.lb_inc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dd_Ports = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_test = new System.Windows.Forms.TextBox();
            this.butt_Refresh = new System.Windows.Forms.Button();
            this.butt_Reset = new System.Windows.Forms.Button();
            this.lb_ErrorOut = new System.Windows.Forms.Label();
            this.gb_NerdStuff = new System.Windows.Forms.GroupBox();
            this.lb_out = new System.Windows.Forms.ListBox();
            this.lb_in = new System.Windows.Forms.ListBox();
            this.gb_Edit = new System.Windows.Forms.GroupBox();
            this.butt_cancel = new System.Windows.Forms.Button();
            this.lb_EditError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_delay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.butt_Save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.trb_delay = new System.Windows.Forms.TrackBar();
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
            ((System.ComponentModel.ISupportInitialize)(this.trb_delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Relays)).BeginInit();
            this.gb_MainUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.Location = new System.Drawing.Point(69, 100);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(5);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_Name.Size = new System.Drawing.Size(310, 26);
            this.tb_Name.TabIndex = 0;
            // 
            // butt_Send
            // 
            this.butt_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butt_Send.Location = new System.Drawing.Point(123, 28);
            this.butt_Send.Name = "butt_Send";
            this.butt_Send.Size = new System.Drawing.Size(95, 35);
            this.butt_Send.TabIndex = 1;
            this.butt_Send.Text = "Send";
            this.butt_Send.UseVisualStyleBackColor = true;
            this.butt_Send.Click += new System.EventHandler(this.butt_Send_Click);
            // 
            // lb_inc
            // 
            this.lb_inc.AutoSize = true;
            this.lb_inc.Location = new System.Drawing.Point(6, 103);
            this.lb_inc.Name = "lb_inc";
            this.lb_inc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_inc.Size = new System.Drawing.Size(55, 20);
            this.lb_inc.TabIndex = 2;
            this.lb_inc.Text = "Name:";
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
            this.dd_Ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dd_Ports.FormattingEnabled = true;
            this.dd_Ports.Location = new System.Drawing.Point(153, 12);
            this.dd_Ports.Name = "dd_Ports";
            this.dd_Ports.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dd_Ports.Size = new System.Drawing.Size(78, 28);
            this.dd_Ports.TabIndex = 8;
            this.dd_Ports.SelectedIndexChanged += new System.EventHandler(this.dd_Ports_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Serial Port:";
            // 
            // tb_test
            // 
            this.tb_test.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_test.Location = new System.Drawing.Point(14, 33);
            this.tb_test.Name = "tb_test";
            this.tb_test.Size = new System.Drawing.Size(103, 26);
            this.tb_test.TabIndex = 12;
            // 
            // butt_Refresh
            // 
            this.butt_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butt_Refresh.Location = new System.Drawing.Point(120, 596);
            this.butt_Refresh.Name = "butt_Refresh";
            this.butt_Refresh.Size = new System.Drawing.Size(95, 35);
            this.butt_Refresh.TabIndex = 13;
            this.butt_Refresh.Text = "Refresh";
            this.butt_Refresh.UseVisualStyleBackColor = true;
            this.butt_Refresh.Click += new System.EventHandler(this.SendCharButton_Click);
            // 
            // butt_Reset
            // 
            this.butt_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butt_Reset.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.butt_Reset.Location = new System.Drawing.Point(14, 596);
            this.butt_Reset.Name = "butt_Reset";
            this.butt_Reset.Size = new System.Drawing.Size(95, 35);
            this.butt_Reset.TabIndex = 14;
            this.butt_Reset.Text = "Reset";
            this.butt_Reset.UseVisualStyleBackColor = true;
            this.butt_Reset.Click += new System.EventHandler(this.SendCharButton_Click);
            // 
            // lb_ErrorOut
            // 
            this.lb_ErrorOut.AutoSize = true;
            this.lb_ErrorOut.ForeColor = System.Drawing.Color.Maroon;
            this.lb_ErrorOut.Location = new System.Drawing.Point(18, 43);
            this.lb_ErrorOut.MaximumSize = new System.Drawing.Size(441, 67);
            this.lb_ErrorOut.Name = "lb_ErrorOut";
            this.lb_ErrorOut.Size = new System.Drawing.Size(0, 20);
            this.lb_ErrorOut.TabIndex = 15;
            // 
            // gb_NerdStuff
            // 
            this.gb_NerdStuff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_NerdStuff.Controls.Add(this.lb_out);
            this.gb_NerdStuff.Controls.Add(this.lb_in);
            this.gb_NerdStuff.Controls.Add(this.butt_Send);
            this.gb_NerdStuff.Controls.Add(this.butt_Reset);
            this.gb_NerdStuff.Controls.Add(this.butt_Refresh);
            this.gb_NerdStuff.Controls.Add(this.label1);
            this.gb_NerdStuff.Controls.Add(this.tb_test);
            this.gb_NerdStuff.Controls.Add(this.label2);
            this.gb_NerdStuff.Enabled = false;
            this.gb_NerdStuff.Location = new System.Drawing.Point(406, 12);
            this.gb_NerdStuff.MinimumSize = new System.Drawing.Size(235, 0);
            this.gb_NerdStuff.Name = "gb_NerdStuff";
            this.gb_NerdStuff.Size = new System.Drawing.Size(235, 637);
            this.gb_NerdStuff.TabIndex = 16;
            this.gb_NerdStuff.TabStop = false;
            this.gb_NerdStuff.Text = "Nerd Stuff";
            this.gb_NerdStuff.Visible = false;
            // 
            // lb_out
            // 
            this.lb_out.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_out.FormattingEnabled = true;
            this.lb_out.ItemHeight = 20;
            this.lb_out.Location = new System.Drawing.Point(14, 354);
            this.lb_out.Name = "lb_out";
            this.lb_out.Size = new System.Drawing.Size(197, 224);
            this.lb_out.TabIndex = 16;
            // 
            // lb_in
            // 
            this.lb_in.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_in.FormattingEnabled = true;
            this.lb_in.ItemHeight = 20;
            this.lb_in.Location = new System.Drawing.Point(14, 99);
            this.lb_in.Name = "lb_in";
            this.lb_in.Size = new System.Drawing.Size(197, 224);
            this.lb_in.TabIndex = 15;
            // 
            // gb_Edit
            // 
            this.gb_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_Edit.Controls.Add(this.butt_cancel);
            this.gb_Edit.Controls.Add(this.lb_EditError);
            this.gb_Edit.Controls.Add(this.label5);
            this.gb_Edit.Controls.Add(this.txb_delay);
            this.gb_Edit.Controls.Add(this.label6);
            this.gb_Edit.Controls.Add(this.butt_Save);
            this.gb_Edit.Controls.Add(this.label7);
            this.gb_Edit.Controls.Add(this.trb_delay);
            this.gb_Edit.Controls.Add(this.label4);
            this.gb_Edit.Controls.Add(this.tb_Name);
            this.gb_Edit.Controls.Add(this.lb_inc);
            this.gb_Edit.Enabled = false;
            this.gb_Edit.Location = new System.Drawing.Point(12, 429);
            this.gb_Edit.Name = "gb_Edit";
            this.gb_Edit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gb_Edit.Size = new System.Drawing.Size(388, 220);
            this.gb_Edit.TabIndex = 15;
            this.gb_Edit.TabStop = false;
            this.gb_Edit.Text = "Edit";
            // 
            // butt_cancel
            // 
            this.butt_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butt_cancel.Location = new System.Drawing.Point(284, 179);
            this.butt_cancel.Name = "butt_cancel";
            this.butt_cancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.butt_cancel.Size = new System.Drawing.Size(95, 35);
            this.butt_cancel.TabIndex = 23;
            this.butt_cancel.Text = "Cancel";
            this.butt_cancel.UseVisualStyleBackColor = true;
            this.butt_cancel.Click += new System.EventHandler(this.butt_cancel_Click);
            // 
            // lb_EditError
            // 
            this.lb_EditError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_EditError.ForeColor = System.Drawing.Color.Maroon;
            this.lb_EditError.Location = new System.Drawing.Point(6, 131);
            this.lb_EditError.Name = "lb_EditError";
            this.lb_EditError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_EditError.Size = new System.Drawing.Size(373, 45);
            this.lb_EditError.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 73);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "s";
            // 
            // txb_delay
            // 
            this.txb_delay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txb_delay.Location = new System.Drawing.Point(183, 70);
            this.txb_delay.Name = "txb_delay";
            this.txb_delay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_delay.Size = new System.Drawing.Size(47, 26);
            this.txb_delay.TabIndex = 15;
            this.txb_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txb_delay.TextChanged += new System.EventHandler(this.txb_delay_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 73);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "25.5 s";
            // 
            // butt_Save
            // 
            this.butt_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butt_Save.Location = new System.Drawing.Point(183, 179);
            this.butt_Save.Name = "butt_Save";
            this.butt_Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.butt_Save.Size = new System.Drawing.Size(95, 35);
            this.butt_Save.TabIndex = 21;
            this.butt_Save.Text = "Save";
            this.butt_Save.UseVisualStyleBackColor = true;
            this.butt_Save.Click += new System.EventHandler(this.butt_Save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 73);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "0 s";
            // 
            // trb_delay
            // 
            this.trb_delay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trb_delay.Location = new System.Drawing.Point(52, 25);
            this.trb_delay.Maximum = 255;
            this.trb_delay.Name = "trb_delay";
            this.trb_delay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trb_delay.Size = new System.Drawing.Size(330, 45);
            this.trb_delay.TabIndex = 17;
            this.trb_delay.TickFrequency = 10;
            this.trb_delay.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            this.DGV_Relays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DGV_Relays.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Relays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Relays.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_Relays.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Relays.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_Relays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Relays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Relay,
            this.col_name,
            this.col_Delay});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Relays.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGV_Relays.EnableHeadersVisualStyles = false;
            this.DGV_Relays.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_Relays.Location = new System.Drawing.Point(10, 39);
            this.DGV_Relays.MultiSelect = false;
            this.DGV_Relays.Name = "DGV_Relays";
            this.DGV_Relays.ReadOnly = true;
            this.DGV_Relays.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Relays.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGV_Relays.RowHeadersVisible = false;
            this.DGV_Relays.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            this.DGV_Relays.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGV_Relays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Relays.ShowCellErrors = false;
            this.DGV_Relays.ShowEditingIcon = false;
            this.DGV_Relays.Size = new System.Drawing.Size(351, 209);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_name.DefaultCellStyle = dataGridViewCellStyle7;
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
            this.gb_MainUI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_MainUI.Controls.Add(this.butt_TestOff);
            this.gb_MainUI.Controls.Add(this.butt_edit);
            this.gb_MainUI.Controls.Add(this.DGV_Relays);
            this.gb_MainUI.Controls.Add(this.butt_TestAdd);
            this.gb_MainUI.Enabled = false;
            this.gb_MainUI.Location = new System.Drawing.Point(12, 113);
            this.gb_MainUI.Name = "gb_MainUI";
            this.gb_MainUI.Size = new System.Drawing.Size(388, 307);
            this.gb_MainUI.TabIndex = 18;
            this.gb_MainUI.TabStop = false;
            this.gb_MainUI.Text = "List o\' Relays";
            // 
            // butt_TestOff
            // 
            this.butt_TestOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butt_TestOff.Location = new System.Drawing.Point(265, 254);
            this.butt_TestOff.Name = "butt_TestOff";
            this.butt_TestOff.Size = new System.Drawing.Size(95, 35);
            this.butt_TestOff.TabIndex = 20;
            this.butt_TestOff.Text = "Test Off";
            this.butt_TestOff.UseVisualStyleBackColor = true;
            this.butt_TestOff.Click += new System.EventHandler(this.butt_off_Click);
            // 
            // butt_edit
            // 
            this.butt_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butt_edit.Location = new System.Drawing.Point(10, 254);
            this.butt_edit.Name = "butt_edit";
            this.butt_edit.Size = new System.Drawing.Size(95, 35);
            this.butt_edit.TabIndex = 18;
            this.butt_edit.Text = "Edit";
            this.butt_edit.UseVisualStyleBackColor = true;
            this.butt_edit.Click += new System.EventHandler(this.butt_edit_Click);
            // 
            // butt_TestAdd
            // 
            this.butt_TestAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butt_TestAdd.Location = new System.Drawing.Point(163, 254);
            this.butt_TestAdd.Name = "butt_TestAdd";
            this.butt_TestAdd.Size = new System.Drawing.Size(95, 35);
            this.butt_TestAdd.TabIndex = 19;
            this.butt_TestAdd.Text = "Test Add";
            this.butt_TestAdd.UseVisualStyleBackColor = true;
            this.butt_TestAdd.Click += new System.EventHandler(this.butt_add_Click);
            // 
            // cb_NerdStuff
            // 
            this.cb_NerdStuff.AutoSize = true;
            this.cb_NerdStuff.Location = new System.Drawing.Point(252, 14);
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
            this.ClientSize = new System.Drawing.Size(412, 661);
            this.Controls.Add(this.cb_NerdStuff);
            this.Controls.Add(this.gb_MainUI);
            this.Controls.Add(this.gb_Edit);
            this.Controls.Add(this.gb_NerdStuff);
            this.Controls.Add(this.lb_ErrorOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dd_Ports);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(428, 700);
            this.Name = "Form_ArduinoRelaySetup";
            this.Text = "Arduino Relay Setup";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.gb_NerdStuff.ResumeLayout(false);
            this.gb_NerdStuff.PerformLayout();
            this.gb_Edit.ResumeLayout(false);
            this.gb_Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Relays)).EndInit();
            this.gb_MainUI.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button butt_Send;
        private System.Windows.Forms.Label lb_inc;
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
        private System.Windows.Forms.TrackBar trb_delay;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_delay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_EditError;
        private System.Windows.Forms.ListBox lb_in;
        private System.Windows.Forms.ListBox lb_out;
        private System.Windows.Forms.Button butt_cancel;
    }
}


using TTMulti.Controls;

namespace TTMulti.Forms
{
    partial class OptionsDlg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsDlg));
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.checkUpdateBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.controlsPicker = new TTMulti.Controls.ControlsPicker();
            this.addBindingBtn = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.allGroupModeGroupBox = new System.Windows.Forms.GroupBox();
            this.allGroupModeCycleToggleChk = new System.Windows.Forms.CheckBox();
            this.allGroupModeLabel = new System.Windows.Forms.Label();
            this.allGroupModeHotkeyPicker = new TTMulti.Controls.KeyPicker();
            this.label12 = new System.Windows.Forms.Label();
            this.mirrorModeGroupBox = new System.Windows.Forms.GroupBox();
            this.mirrorModeCycleToggleChk = new System.Windows.Forms.CheckBox();
            this.mirrorModeLabel = new System.Windows.Forms.Label();
            this.mirrorModeHotkeyPicker = new TTMulti.Controls.KeyPicker();
            this.label10 = new System.Windows.Forms.Label();
            this.groupModeGroupBox = new System.Windows.Forms.GroupBox();
            this.groupModeCycleToggleChk = new System.Windows.Forms.CheckBox();
            this.groupModeLabel = new System.Windows.Forms.Label();
            this.groupModeHotkeyPicker = new TTMulti.Controls.KeyPicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.keyPicker1 = new TTMulti.Controls.KeyPicker();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.keyPicker2 = new TTMulti.Controls.KeyPicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.keyPicker5 = new TTMulti.Controls.KeyPicker();
            this.label7 = new System.Windows.Forms.Label();
            this.mouseChk = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.allGroupModeGroupBox.SuspendLayout();
            this.mirrorModeGroupBox.SuspendLayout();
            this.groupModeGroupBox.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(443, 395);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(80, 22);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(532, 395);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(80, 22);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aboutBtn.Location = new System.Drawing.Point(12, 395);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(80, 22);
            this.aboutBtn.TabIndex = 12;
            this.aboutBtn.Text = "About...";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // checkUpdateBtn
            // 
            this.checkUpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkUpdateBtn.Location = new System.Drawing.Point(98, 395);
            this.checkUpdateBtn.Name = "checkUpdateBtn";
            this.checkUpdateBtn.Size = new System.Drawing.Size(111, 22);
            this.checkUpdateBtn.TabIndex = 13;
            this.checkUpdateBtn.Text = "Check for Updates";
            this.checkUpdateBtn.UseVisualStyleBackColor = true;
            this.checkUpdateBtn.Click += new System.EventHandler(this.checkUpdateBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 378);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tableLayoutPanel3);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage6.Size = new System.Drawing.Size(592, 352);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Multi-Mode Key Bindings";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(588, 348);
            this.tableLayoutPanel3.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(3, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(582, 59);
            this.label6.TabIndex = 24;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(582, 30);
            this.label3.TabIndex = 21;
            this.label3.Text = "These are the keys that the multicontroller will send to Toontown while in multi-" +
    "mode. Make sure the Toontown keys match your key bindings in your game options.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.controlsPicker, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addBindingBtn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 253);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // controlsPicker
            // 
            this.controlsPicker.AutoScroll = true;
            this.controlsPicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.controlsPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsPicker.Location = new System.Drawing.Point(2, 2);
            this.controlsPicker.Margin = new System.Windows.Forms.Padding(2);
            this.controlsPicker.Name = "controlsPicker";
            this.controlsPicker.Size = new System.Drawing.Size(578, 220);
            this.controlsPicker.TabIndex = 20;
            // 
            // addBindingBtn
            // 
            this.addBindingBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBindingBtn.Location = new System.Drawing.Point(3, 227);
            this.addBindingBtn.Name = "addBindingBtn";
            this.addBindingBtn.Size = new System.Drawing.Size(576, 23);
            this.addBindingBtn.TabIndex = 22;
            this.addBindingBtn.Text = "+ Add Custom Key Binding";
            this.toolTip1.SetToolTip(this.addBindingBtn, "Add a custom binding for any extra controls you want in multi-mode");
            this.addBindingBtn.UseVisualStyleBackColor = true;
            this.addBindingBtn.Click += new System.EventHandler(this.addBindingBtn_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.allGroupModeGroupBox);
            this.tabPage1.Controls.Add(this.mirrorModeGroupBox);
            this.tabPage1.Controls.Add(this.groupModeGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(592, 352);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "Modes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // allGroupModeGroupBox
            // 
            this.allGroupModeGroupBox.Controls.Add(this.allGroupModeCycleToggleChk);
            this.allGroupModeGroupBox.Controls.Add(this.allGroupModeLabel);
            this.allGroupModeGroupBox.Controls.Add(this.allGroupModeHotkeyPicker);
            this.allGroupModeGroupBox.Controls.Add(this.label12);
            this.allGroupModeGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.allGroupModeGroupBox.Location = new System.Drawing.Point(2, 114);
            this.allGroupModeGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.allGroupModeGroupBox.Name = "allGroupModeGroupBox";
            this.allGroupModeGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.allGroupModeGroupBox.Size = new System.Drawing.Size(588, 56);
            this.allGroupModeGroupBox.TabIndex = 7;
            this.allGroupModeGroupBox.TabStop = false;
            this.allGroupModeGroupBox.Text = "All Groups Mode";
            // 
            // allGroupModeCycleToggleChk
            // 
            this.allGroupModeCycleToggleChk.AutoSize = true;
            this.allGroupModeCycleToggleChk.Checked = global::TTMulti.Properties.Settings.Default.allGroupModeCycleWithModeHotkey;
            this.allGroupModeCycleToggleChk.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TTMulti.Properties.Settings.Default, "allGroupModeCycleWithModeHotkey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.allGroupModeCycleToggleChk.Location = new System.Drawing.Point(386, 34);
            this.allGroupModeCycleToggleChk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.allGroupModeCycleToggleChk.Name = "allGroupModeCycleToggleChk";
            this.allGroupModeCycleToggleChk.Size = new System.Drawing.Size(192, 17);
            this.allGroupModeCycleToggleChk.TabIndex = 8;
            this.allGroupModeCycleToggleChk.Text = "Toggle with Mode/Activate Hotkey";
            this.allGroupModeCycleToggleChk.UseVisualStyleBackColor = true;
            // 
            // allGroupModeLabel
            // 
            this.allGroupModeLabel.Location = new System.Drawing.Point(6, 18);
            this.allGroupModeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allGroupModeLabel.Name = "allGroupModeLabel";
            this.allGroupModeLabel.Size = new System.Drawing.Size(373, 32);
            this.allGroupModeLabel.TabIndex = 5;
            this.allGroupModeLabel.Text = "Make every left toon move at once, and every right toon move at once in all group" +
    "s at once.";
            // 
            // allGroupModeHotkeyPicker
            // 
            this.allGroupModeHotkeyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.allGroupModeHotkeyPicker.ChosenKey = System.Windows.Forms.Keys.None;
            this.allGroupModeHotkeyPicker.ChosenKeyCode = global::TTMulti.Properties.Settings.Default.controlAllGroupsKeyCode;
            this.allGroupModeHotkeyPicker.DataBindings.Add(new System.Windows.Forms.Binding("ChosenKeyCode", global::TTMulti.Properties.Settings.Default, "controlAllGroupsKeyCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.allGroupModeHotkeyPicker.Location = new System.Drawing.Point(433, 11);
            this.allGroupModeHotkeyPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allGroupModeHotkeyPicker.MinimumSize = new System.Drawing.Size(40, 20);
            this.allGroupModeHotkeyPicker.Name = "allGroupModeHotkeyPicker";
            this.allGroupModeHotkeyPicker.Size = new System.Drawing.Size(150, 20);
            this.allGroupModeHotkeyPicker.TabIndex = 1;
            this.allGroupModeHotkeyPicker.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(382, 13);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Hotkey:";
            // 
            // mirrorModeGroupBox
            // 
            this.mirrorModeGroupBox.Controls.Add(this.mirrorModeCycleToggleChk);
            this.mirrorModeGroupBox.Controls.Add(this.mirrorModeLabel);
            this.mirrorModeGroupBox.Controls.Add(this.mirrorModeHotkeyPicker);
            this.mirrorModeGroupBox.Controls.Add(this.label10);
            this.mirrorModeGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.mirrorModeGroupBox.Location = new System.Drawing.Point(2, 58);
            this.mirrorModeGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mirrorModeGroupBox.Name = "mirrorModeGroupBox";
            this.mirrorModeGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mirrorModeGroupBox.Size = new System.Drawing.Size(588, 56);
            this.mirrorModeGroupBox.TabIndex = 6;
            this.mirrorModeGroupBox.TabStop = false;
            this.mirrorModeGroupBox.Text = "Mirror Mode";
            // 
            // mirrorModeCycleToggleChk
            // 
            this.mirrorModeCycleToggleChk.AutoSize = true;
            this.mirrorModeCycleToggleChk.Checked = global::TTMulti.Properties.Settings.Default.mirrorModeCycleWithModeHotkey;
            this.mirrorModeCycleToggleChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mirrorModeCycleToggleChk.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TTMulti.Properties.Settings.Default, "mirrorModeCycleWithModeHotkey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mirrorModeCycleToggleChk.Location = new System.Drawing.Point(386, 34);
            this.mirrorModeCycleToggleChk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mirrorModeCycleToggleChk.Name = "mirrorModeCycleToggleChk";
            this.mirrorModeCycleToggleChk.Size = new System.Drawing.Size(192, 17);
            this.mirrorModeCycleToggleChk.TabIndex = 7;
            this.mirrorModeCycleToggleChk.Text = "Toggle with Mode/Activate Hotkey";
            this.mirrorModeCycleToggleChk.UseVisualStyleBackColor = true;
            // 
            // mirrorModeLabel
            // 
            this.mirrorModeLabel.Location = new System.Drawing.Point(6, 18);
            this.mirrorModeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mirrorModeLabel.Name = "mirrorModeLabel";
            this.mirrorModeLabel.Size = new System.Drawing.Size(373, 32);
            this.mirrorModeLabel.TabIndex = 5;
            this.mirrorModeLabel.Text = "Mirror input to all toons in all groups.";
            // 
            // mirrorModeHotkeyPicker
            // 
            this.mirrorModeHotkeyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mirrorModeHotkeyPicker.ChosenKey = System.Windows.Forms.Keys.None;
            this.mirrorModeHotkeyPicker.ChosenKeyCode = global::TTMulti.Properties.Settings.Default.mirrorModeKeyCode;
            this.mirrorModeHotkeyPicker.DataBindings.Add(new System.Windows.Forms.Binding("ChosenKeyCode", global::TTMulti.Properties.Settings.Default, "mirrorModeKeyCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mirrorModeHotkeyPicker.Location = new System.Drawing.Point(433, 11);
            this.mirrorModeHotkeyPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mirrorModeHotkeyPicker.MinimumSize = new System.Drawing.Size(40, 20);
            this.mirrorModeHotkeyPicker.Name = "mirrorModeHotkeyPicker";
            this.mirrorModeHotkeyPicker.Size = new System.Drawing.Size(150, 20);
            this.mirrorModeHotkeyPicker.TabIndex = 1;
            this.mirrorModeHotkeyPicker.TabStop = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(382, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Hotkey:";
            // 
            // groupModeGroupBox
            // 
            this.groupModeGroupBox.Controls.Add(this.groupModeCycleToggleChk);
            this.groupModeGroupBox.Controls.Add(this.groupModeLabel);
            this.groupModeGroupBox.Controls.Add(this.groupModeHotkeyPicker);
            this.groupModeGroupBox.Controls.Add(this.label8);
            this.groupModeGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupModeGroupBox.Location = new System.Drawing.Point(2, 2);
            this.groupModeGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupModeGroupBox.Name = "groupModeGroupBox";
            this.groupModeGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupModeGroupBox.Size = new System.Drawing.Size(588, 56);
            this.groupModeGroupBox.TabIndex = 3;
            this.groupModeGroupBox.TabStop = false;
            this.groupModeGroupBox.Text = "Multi-Mode/Group Mode (Default Mode)";
            // 
            // groupModeCycleToggleChk
            // 
            this.groupModeCycleToggleChk.AutoSize = true;
            this.groupModeCycleToggleChk.Checked = global::TTMulti.Properties.Settings.Default.groupModeCycleWithModeHotkey;
            this.groupModeCycleToggleChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.groupModeCycleToggleChk.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TTMulti.Properties.Settings.Default, "groupModeCycleWithModeHotkey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupModeCycleToggleChk.Location = new System.Drawing.Point(386, 34);
            this.groupModeCycleToggleChk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupModeCycleToggleChk.Name = "groupModeCycleToggleChk";
            this.groupModeCycleToggleChk.Size = new System.Drawing.Size(192, 17);
            this.groupModeCycleToggleChk.TabIndex = 6;
            this.groupModeCycleToggleChk.Text = "Toggle with Mode/Activate Hotkey";
            this.groupModeCycleToggleChk.UseVisualStyleBackColor = true;
            // 
            // groupModeLabel
            // 
            this.groupModeLabel.Location = new System.Drawing.Point(6, 18);
            this.groupModeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupModeLabel.Name = "groupModeLabel";
            this.groupModeLabel.Size = new System.Drawing.Size(373, 32);
            this.groupModeLabel.TabIndex = 5;
            this.groupModeLabel.Text = "Control all pairs of left and right toons in a group.\r\nThe number keys are reserv" +
    "ed for switching groups.";
            // 
            // groupModeHotkeyPicker
            // 
            this.groupModeHotkeyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupModeHotkeyPicker.ChosenKey = System.Windows.Forms.Keys.None;
            this.groupModeHotkeyPicker.ChosenKeyCode = global::TTMulti.Properties.Settings.Default.groupModeKeyCode;
            this.groupModeHotkeyPicker.DataBindings.Add(new System.Windows.Forms.Binding("ChosenKeyCode", global::TTMulti.Properties.Settings.Default, "groupModeKeyCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupModeHotkeyPicker.Location = new System.Drawing.Point(433, 11);
            this.groupModeHotkeyPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupModeHotkeyPicker.MinimumSize = new System.Drawing.Size(40, 20);
            this.groupModeHotkeyPicker.Name = "groupModeHotkeyPicker";
            this.groupModeHotkeyPicker.Size = new System.Drawing.Size(150, 20);
            this.groupModeHotkeyPicker.TabIndex = 1;
            this.groupModeHotkeyPicker.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Hotkey:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(592, 352);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hotkeys";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(586, 346);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.keyPicker1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 75);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode/Activate Hotkey:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(569, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "This key is used to change from multi-mode to mirror-mode and back. It also activ" +
    "ates the multicontroller when you have a Toontown window active. ";
            // 
            // keyPicker1
            // 
            this.keyPicker1.ChosenKey = System.Windows.Forms.Keys.Oemtilde;
            this.keyPicker1.ChosenKeyCode = global::TTMulti.Properties.Settings.Default.modeKeyCode;
            this.keyPicker1.DataBindings.Add(new System.Windows.Forms.Binding("ChosenKeyCode", global::TTMulti.Properties.Settings.Default, "modeKeyCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.keyPicker1.Location = new System.Drawing.Point(7, 48);
            this.keyPicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keyPicker1.MinimumSize = new System.Drawing.Size(40, 20);
            this.keyPicker1.Name = "keyPicker1";
            this.keyPicker1.Size = new System.Drawing.Size(150, 20);
            this.keyPicker1.TabIndex = 12;
            this.keyPicker1.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.checkBox4);
            this.tabPage5.Controls.Add(this.keyPicker2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage5.Size = new System.Drawing.Size(592, 352);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Keep-Alive";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Keep-Alive Key:";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = global::TTMulti.Properties.Settings.Default.disableKeepAlive;
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TTMulti.Properties.Settings.Default, "disableKeepAlive", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox4.Location = new System.Drawing.Point(6, 6);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(115, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Disable Keep-Alive";
            this.toolTip1.SetToolTip(this.checkBox4, "If checked, your toons will no longer be kept awake automatically.");
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // keyPicker2
            // 
            this.keyPicker2.ChosenKey = System.Windows.Forms.Keys.Home;
            this.keyPicker2.ChosenKeyCode = global::TTMulti.Properties.Settings.Default.keepAliveKeyCode;
            this.keyPicker2.DataBindings.Add(new System.Windows.Forms.Binding("ChosenKeyCode", global::TTMulti.Properties.Settings.Default, "keepAliveKeyCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.keyPicker2.Location = new System.Drawing.Point(99, 29);
            this.keyPicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keyPicker2.MinimumSize = new System.Drawing.Size(40, 20);
            this.keyPicker2.Name = "keyPicker2";
            this.keyPicker2.Size = new System.Drawing.Size(150, 20);
            this.keyPicker2.TabIndex = 13;
            this.toolTip1.SetToolTip(this.keyPicker2, "This is the key that will be pressed periodically to keep your toons awake.");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(592, 352);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Other";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.keyPicker5);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.mouseChk);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 79);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(586, 78);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mirror Mouse Clicks";
            // 
            // keyPicker5
            // 
            this.keyPicker5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.keyPicker5.ChosenKey = System.Windows.Forms.Keys.None;
            this.keyPicker5.ChosenKeyCode = global::TTMulti.Properties.Settings.Default.replicateMouseKeyCode;
            this.keyPicker5.DataBindings.Add(new System.Windows.Forms.Binding("ChosenKeyCode", global::TTMulti.Properties.Settings.Default, "replicateMouseKeyCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.keyPicker5.Location = new System.Drawing.Point(432, 18);
            this.keyPicker5.MinimumSize = new System.Drawing.Size(38, 20);
            this.keyPicker5.Name = "keyPicker5";
            this.keyPicker5.Size = new System.Drawing.Size(149, 20);
            this.keyPicker5.TabIndex = 1;
            this.keyPicker5.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hotkey:";
            // 
            // mouseChk
            // 
            this.mouseChk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mouseChk.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mouseChk.Checked = global::TTMulti.Properties.Settings.Default.replicateMouse;
            this.mouseChk.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TTMulti.Properties.Settings.Default, "replicateMouse", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mouseChk.Location = new System.Drawing.Point(6, 16);
            this.mouseChk.Margin = new System.Windows.Forms.Padding(2);
            this.mouseChk.Name = "mouseChk";
            this.mouseChk.Size = new System.Drawing.Size(439, 59);
            this.mouseChk.TabIndex = 0;
            this.mouseChk.Text = resources.GetString("mouseChk.Text");
            this.mouseChk.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mouseChk.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox3);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(3, 41);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(586, 38);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Compact Interface";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = global::TTMulti.Properties.Settings.Default.compactUI;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TTMulti.Properties.Settings.Default, "compactUI", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox3.Location = new System.Drawing.Point(6, 18);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(266, 17);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Make the size of the multicontroller window smaller.";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(586, 38);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Keep On Top When Inactive";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::TTMulti.Properties.Settings.Default.onTopWhenInactive;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TTMulti.Properties.Settings.Default, "onTopWhenInactive", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Location = new System.Drawing.Point(6, 18);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(431, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "The multicontroller window will always stay visible over everything else on your " +
    "screen.";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // OptionsDlg
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(625, 430);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.checkUpdateBtn);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsDlg_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.allGroupModeGroupBox.ResumeLayout(false);
            this.allGroupModeGroupBox.PerformLayout();
            this.mirrorModeGroupBox.ResumeLayout(false);
            this.mirrorModeGroupBox.PerformLayout();
            this.groupModeGroupBox.ResumeLayout(false);
            this.groupModeGroupBox.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button checkUpdateBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private TTMulti.Controls.KeyPicker keyPicker1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label2;
        private Controls.KeyPicker keyPicker2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label3;
        private Controls.ControlsPicker controlsPicker;
        private System.Windows.Forms.Button addBindingBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox mouseChk;
        private System.Windows.Forms.Label label7;
        private KeyPicker keyPicker5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupModeGroupBox;
        private KeyPicker groupModeHotkeyPicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label groupModeLabel;
        private System.Windows.Forms.GroupBox mirrorModeGroupBox;
        private System.Windows.Forms.Label mirrorModeLabel;
        private KeyPicker mirrorModeHotkeyPicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox allGroupModeGroupBox;
        private System.Windows.Forms.Label allGroupModeLabel;
        private KeyPicker allGroupModeHotkeyPicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox groupModeCycleToggleChk;
        private System.Windows.Forms.CheckBox mirrorModeCycleToggleChk;
        private System.Windows.Forms.CheckBox allGroupModeCycleToggleChk;
    }
}
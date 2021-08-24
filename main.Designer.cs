namespace BluetoothLEnergy
{
    partial class fmMain
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
            this.btDiscover = new System.Windows.Forms.Button();
            this.lvDevices = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvServices = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCharacteristics = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEvents = new System.Windows.Forms.ListView();
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btConnect = new System.Windows.Forms.Button();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btGetServices = new System.Windows.Forms.Button();
            this.btGetCharacteristics = new System.Windows.Forms.Button();
            this.btGetCharValue = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btValuePanel = new System.Windows.Forms.RichTextBox();
            this.cbSerialName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBaund = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbHandshake = new System.Windows.Forms.ComboBox();
            this.SerialScreen = new System.Windows.Forms.RichTextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btCloseSerial = new System.Windows.Forms.Button();
            this.yaktsevbut = new System.Windows.Forms.RadioButton();
            this.mnzlbut = new System.Windows.Forms.RadioButton();
            this.anlyktbut = new System.Windows.Forms.RadioButton();
            this.orttktbut = new System.Windows.Forms.RadioButton();
            this.lpgbnzbut = new System.Windows.Forms.RadioButton();
            this.alnyolbut = new System.Windows.Forms.RadioButton();
            this.rpmbut = new System.Windows.Forms.RadioButton();
            this.anlh�zbut = new System.Windows.Forms.RadioButton();
            this.btreadRegular = new System.Windows.Forms.CheckBox();
            this.btSaveCSV = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btDiscover
            // 
            this.btDiscover.Location = new System.Drawing.Point(16, 15);
            this.btDiscover.Margin = new System.Windows.Forms.Padding(4);
            this.btDiscover.Name = "btDiscover";
            this.btDiscover.Size = new System.Drawing.Size(100, 28);
            this.btDiscover.TabIndex = 0;
            this.btDiscover.Text = "Scan";
            this.btDiscover.UseVisualStyleBackColor = true;
            this.btDiscover.Click += new System.EventHandler(this.btDiscover_Click);
            // 
            // lvDevices
            // 
            this.lvDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvDevices.FullRowSelect = true;
            this.lvDevices.GridLines = true;
            this.lvDevices.HideSelection = false;
            this.lvDevices.Location = new System.Drawing.Point(16, 50);
            this.lvDevices.Margin = new System.Windows.Forms.Padding(4);
            this.lvDevices.MultiSelect = false;
            this.lvDevices.Name = "lvDevices";
            this.lvDevices.Size = new System.Drawing.Size(416, 75);
            this.lvDevices.TabIndex = 1;
            this.lvDevices.UseCompatibleStateImageBehavior = false;
            this.lvDevices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adress";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Device type";
            this.columnHeader3.Width = 150;
            // 
            // lvServices
            // 
            this.lvServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lvServices.FullRowSelect = true;
            this.lvServices.GridLines = true;
            this.lvServices.HideSelection = false;
            this.lvServices.Location = new System.Drawing.Point(16, 172);
            this.lvServices.Margin = new System.Windows.Forms.Padding(4);
            this.lvServices.MultiSelect = false;
            this.lvServices.Name = "lvServices";
            this.lvServices.Size = new System.Drawing.Size(416, 102);
            this.lvServices.TabIndex = 4;
            this.lvServices.UseCompatibleStateImageBehavior = false;
            this.lvServices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "UUID";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = " Is short UUID";
            this.columnHeader5.Width = 100;
            // 
            // lvCharacteristics
            // 
            this.lvCharacteristics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.lvCharacteristics.FullRowSelect = true;
            this.lvCharacteristics.GridLines = true;
            this.lvCharacteristics.HideSelection = false;
            this.lvCharacteristics.Location = new System.Drawing.Point(16, 318);
            this.lvCharacteristics.Margin = new System.Windows.Forms.Padding(4);
            this.lvCharacteristics.MultiSelect = false;
            this.lvCharacteristics.Name = "lvCharacteristics";
            this.lvCharacteristics.Size = new System.Drawing.Size(416, 89);
            this.lvCharacteristics.TabIndex = 5;
            this.lvCharacteristics.UseCompatibleStateImageBehavior = false;
            this.lvCharacteristics.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "UUID";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Is short UUID";
            this.columnHeader8.Width = 80;
            // 
            // lvEvents
            // 
            this.lvEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader30,
            this.columnHeader31});
            this.lvEvents.FullRowSelect = true;
            this.lvEvents.GridLines = true;
            this.lvEvents.HideSelection = false;
            this.lvEvents.Location = new System.Drawing.Point(16, 439);
            this.lvEvents.Margin = new System.Windows.Forms.Padding(4);
            this.lvEvents.MultiSelect = false;
            this.lvEvents.Name = "lvEvents";
            this.lvEvents.Size = new System.Drawing.Size(416, 130);
            this.lvEvents.TabIndex = 8;
            this.lvEvents.UseCompatibleStateImageBehavior = false;
            this.lvEvents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Adress";
            this.columnHeader28.Width = 100;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Event";
            this.columnHeader29.Width = 150;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "Param";
            this.columnHeader30.Width = 150;
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "Value";
            this.columnHeader31.Width = 150;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(124, 15);
            this.btConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(100, 28);
            this.btConnect.TabIndex = 9;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btDisconnect
            // 
            this.btDisconnect.Location = new System.Drawing.Point(232, 15);
            this.btDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(120, 28);
            this.btDisconnect.TabIndex = 10;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // btGetServices
            // 
            this.btGetServices.Location = new System.Drawing.Point(16, 136);
            this.btGetServices.Margin = new System.Windows.Forms.Padding(4);
            this.btGetServices.Name = "btGetServices";
            this.btGetServices.Size = new System.Drawing.Size(157, 28);
            this.btGetServices.TabIndex = 13;
            this.btGetServices.Text = "Get Services";
            this.btGetServices.UseVisualStyleBackColor = true;
            this.btGetServices.Click += new System.EventHandler(this.btGetServices_Click);
            // 
            // btGetCharacteristics
            // 
            this.btGetCharacteristics.Location = new System.Drawing.Point(16, 282);
            this.btGetCharacteristics.Margin = new System.Windows.Forms.Padding(4);
            this.btGetCharacteristics.Name = "btGetCharacteristics";
            this.btGetCharacteristics.Size = new System.Drawing.Size(157, 28);
            this.btGetCharacteristics.TabIndex = 15;
            this.btGetCharacteristics.Text = "Get Characteristic";
            this.btGetCharacteristics.UseVisualStyleBackColor = true;
            this.btGetCharacteristics.Click += new System.EventHandler(this.btGetCharacteristics_Click);
            // 
            // btGetCharValue
            // 
            this.btGetCharValue.Location = new System.Drawing.Point(634, 18);
            this.btGetCharValue.Margin = new System.Windows.Forms.Padding(4);
            this.btGetCharValue.Name = "btGetCharValue";
            this.btGetCharValue.Size = new System.Drawing.Size(100, 28);
            this.btGetCharValue.TabIndex = 16;
            this.btGetCharValue.Text = "Read";
            this.btGetCharValue.UseVisualStyleBackColor = true;
            this.btGetCharValue.Click += new System.EventHandler(this.btGetCharValue_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(1063, 593);
            this.btClear.Margin = new System.Windows.Forms.Padding(4);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(100, 28);
            this.btClear.TabIndex = 26;
            this.btClear.Text = "Clean";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Devices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Services";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Characteristic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "State";
            // 
            // btValuePanel
            // 
            this.btValuePanel.Location = new System.Drawing.Point(530, 50);
            this.btValuePanel.Name = "btValuePanel";
            this.btValuePanel.ReadOnly = true;
            this.btValuePanel.Size = new System.Drawing.Size(322, 224);
            this.btValuePanel.TabIndex = 31;
            this.btValuePanel.Text = "";
            // 
            // cbSerialName
            // 
            this.cbSerialName.FormattingEnabled = true;
            this.cbSerialName.Location = new System.Drawing.Point(1042, 344);
            this.cbSerialName.Name = "cbSerialName";
            this.cbSerialName.Size = new System.Drawing.Size(121, 24);
            this.cbSerialName.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Serial Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(946, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(946, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Baund:";
            // 
            // cbBaund
            // 
            this.cbBaund.FormattingEnabled = true;
            this.cbBaund.Location = new System.Drawing.Point(1042, 387);
            this.cbBaund.Name = "cbBaund";
            this.cbBaund.Size = new System.Drawing.Size(121, 24);
            this.cbBaund.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(946, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Data Size:";
            // 
            // cbData
            // 
            this.cbData.FormattingEnabled = true;
            this.cbData.Location = new System.Drawing.Point(1042, 428);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(121, 24);
            this.cbData.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(946, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Parity:";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(1042, 474);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 24);
            this.cbParity.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(946, 528);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "Handshake:";
            // 
            // cbHandshake
            // 
            this.cbHandshake.FormattingEnabled = true;
            this.cbHandshake.Location = new System.Drawing.Point(1042, 521);
            this.cbHandshake.Name = "cbHandshake";
            this.cbHandshake.Size = new System.Drawing.Size(121, 24);
            this.cbHandshake.TabIndex = 41;
            // 
            // SerialScreen
            // 
            this.SerialScreen.Location = new System.Drawing.Point(530, 344);
            this.SerialScreen.Name = "SerialScreen";
            this.SerialScreen.ReadOnly = true;
            this.SerialScreen.Size = new System.Drawing.Size(322, 204);
            this.SerialScreen.TabIndex = 43;
            this.SerialScreen.Text = "";
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(696, 554);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 44;
            this.btOpen.Text = "Start";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btCloseSerial
            // 
            this.btCloseSerial.Location = new System.Drawing.Point(777, 554);
            this.btCloseSerial.Name = "btCloseSerial";
            this.btCloseSerial.Size = new System.Drawing.Size(75, 23);
            this.btCloseSerial.TabIndex = 45;
            this.btCloseSerial.Text = "Stop";
            this.btCloseSerial.UseVisualStyleBackColor = true;
            this.btCloseSerial.Click += new System.EventHandler(this.btCloseSerial_Click);
            // 
            // yaktsevbut
            // 
            this.yaktsevbut.AutoSize = true;
            this.yaktsevbut.Location = new System.Drawing.Point(897, 55);
            this.yaktsevbut.Name = "yaktsevbut";
            this.yaktsevbut.Size = new System.Drawing.Size(116, 21);
            this.yaktsevbut.TabIndex = 46;
            this.yaktsevbut.TabStop = true;
            this.yaktsevbut.Text = "Yak�t Seviyesi";
            this.yaktsevbut.UseVisualStyleBackColor = true;
            // 
            // mnzlbut
            // 
            this.mnzlbut.AutoSize = true;
            this.mnzlbut.Location = new System.Drawing.Point(897, 82);
            this.mnzlbut.Name = "mnzlbut";
            this.mnzlbut.Size = new System.Drawing.Size(116, 21);
            this.mnzlbut.TabIndex = 47;
            this.mnzlbut.TabStop = true;
            this.mnzlbut.Text = "Arac�n Menzili";
            this.mnzlbut.UseVisualStyleBackColor = true;
            // 
            // anlyktbut
            // 
            this.anlyktbut.AutoSize = true;
            this.anlyktbut.Location = new System.Drawing.Point(897, 136);
            this.anlyktbut.Name = "anlyktbut";
            this.anlyktbut.Size = new System.Drawing.Size(151, 21);
            this.anlyktbut.TabIndex = 48;
            this.anlyktbut.TabStop = true;
            this.anlyktbut.Text = "Anl�k Yak�t T�ketimi";
            this.anlyktbut.UseVisualStyleBackColor = true;
            // 
            // orttktbut
            // 
            this.orttktbut.AutoSize = true;
            this.orttktbut.Location = new System.Drawing.Point(897, 109);
            this.orttktbut.Name = "orttktbut";
            this.orttktbut.Size = new System.Drawing.Size(179, 21);
            this.orttktbut.TabIndex = 49;
            this.orttktbut.TabStop = true;
            this.orttktbut.Text = "Ortalama Yak�t T�ketimi";
            this.orttktbut.UseVisualStyleBackColor = true;
            // 
            // lpgbnzbut
            // 
            this.lpgbnzbut.AutoSize = true;
            this.lpgbnzbut.Location = new System.Drawing.Point(897, 244);
            this.lpgbnzbut.Name = "lpgbnzbut";
            this.lpgbnzbut.Size = new System.Drawing.Size(206, 21);
            this.lpgbnzbut.TabIndex = 50;
            this.lpgbnzbut.TabStop = true;
            this.lpgbnzbut.Text = "LPG-BENZ�N Ge�i� Durumu";
            this.lpgbnzbut.UseVisualStyleBackColor = true;
            // 
            // alnyolbut
            // 
            this.alnyolbut.AutoSize = true;
            this.alnyolbut.Location = new System.Drawing.Point(897, 217);
            this.alnyolbut.Name = "alnyolbut";
            this.alnyolbut.Size = new System.Drawing.Size(92, 21);
            this.alnyolbut.TabIndex = 51;
            this.alnyolbut.TabStop = true;
            this.alnyolbut.Text = "Al�nan Yol";
            this.alnyolbut.UseVisualStyleBackColor = true;
            // 
            // rpmbut
            // 
            this.rpmbut.AutoSize = true;
            this.rpmbut.Location = new System.Drawing.Point(897, 190);
            this.rpmbut.Name = "rpmbut";
            this.rpmbut.Size = new System.Drawing.Size(102, 21);
            this.rpmbut.TabIndex = 52;
            this.rpmbut.TabStop = true;
            this.rpmbut.Text = "Motor Devri";
            this.rpmbut.UseVisualStyleBackColor = true;
            // 
            // anlh�zbut
            // 
            this.anlh�zbut.AutoSize = true;
            this.anlh�zbut.Location = new System.Drawing.Point(897, 163);
            this.anlh�zbut.Name = "anlh�zbut";
            this.anlh�zbut.Size = new System.Drawing.Size(83, 21);
            this.anlh�zbut.TabIndex = 53;
            this.anlh�zbut.TabStop = true;
            this.anlh�zbut.Text = "Anl�k H�z";
            this.anlh�zbut.UseVisualStyleBackColor = true;
            // 
            // btreadRegular
            // 
            this.btreadRegular.AutoSize = true;
            this.btreadRegular.Location = new System.Drawing.Point(895, 23);
            this.btreadRegular.Name = "btreadRegular";
            this.btreadRegular.Size = new System.Drawing.Size(118, 21);
            this.btreadRegular.TabIndex = 55;
            this.btreadRegular.Text = "Read Regular";
            this.btreadRegular.UseVisualStyleBackColor = true;
            // 
            // btSaveCSV
            // 
            this.btSaveCSV.AutoSize = true;
            this.btSaveCSV.Location = new System.Drawing.Point(950, 556);
            this.btSaveCSV.Name = "btSaveCSV";
            this.btSaveCSV.Size = new System.Drawing.Size(93, 21);
            this.btSaveCSV.TabIndex = 56;
            this.btSaveCSV.Text = "Save CSV";
            this.btSaveCSV.UseVisualStyleBackColor = true;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 647);
            this.Controls.Add(this.btSaveCSV);
            this.Controls.Add(this.btreadRegular);
            this.Controls.Add(this.anlh�zbut);
            this.Controls.Add(this.rpmbut);
            this.Controls.Add(this.alnyolbut);
            this.Controls.Add(this.lpgbnzbut);
            this.Controls.Add(this.orttktbut);
            this.Controls.Add(this.anlyktbut);
            this.Controls.Add(this.mnzlbut);
            this.Controls.Add(this.yaktsevbut);
            this.Controls.Add(this.btCloseSerial);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.SerialScreen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbHandshake);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbBaund);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSerialName);
            this.Controls.Add(this.btValuePanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btGetCharValue);
            this.Controls.Add(this.btGetCharacteristics);
            this.Controls.Add(this.btGetServices);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.lvEvents);
            this.Controls.Add(this.lvCharacteristics);
            this.Controls.Add(this.lvServices);
            this.Controls.Add(this.lvDevices);
            this.Controls.Add(this.btDiscover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BluetoothLEnergy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmMain_FormClosed);
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDiscover;
        private System.Windows.Forms.ListView lvDevices;
        private System.Windows.Forms.ListView lvServices;
        private System.Windows.Forms.ListView lvCharacteristics;
        private System.Windows.Forms.ListView lvEvents;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Button btGetServices;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btGetCharacteristics;
        private System.Windows.Forms.Button btGetCharValue;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox btValuePanel;
        private System.Windows.Forms.ComboBox cbSerialName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBaund;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbHandshake;
        private System.Windows.Forms.RichTextBox SerialScreen;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btCloseSerial;
        private System.Windows.Forms.RadioButton yaktsevbut;
        private System.Windows.Forms.RadioButton mnzlbut;
        private System.Windows.Forms.RadioButton anlyktbut;
        private System.Windows.Forms.RadioButton orttktbut;
        private System.Windows.Forms.RadioButton lpgbnzbut;
        private System.Windows.Forms.RadioButton alnyolbut;
        private System.Windows.Forms.RadioButton rpmbut;
        private System.Windows.Forms.RadioButton anlh�zbut;
        private System.Windows.Forms.CheckBox btreadRegular;
        private System.Windows.Forms.CheckBox btSaveCSV;
    }
}


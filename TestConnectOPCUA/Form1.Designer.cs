namespace TestConnectOPCUA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connectServerCtrl1 = new Opc.Ua.Client.Controls.ConnectServerCtrl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tb_CurrentFloor = new System.Windows.Forms.TextBox();
            this.lb_floor1 = new System.Windows.Forms.Label();
            this.lb_floor2 = new System.Windows.Forms.Label();
            this.lb_floor3 = new System.Windows.Forms.Label();
            this.pb_trend = new System.Windows.Forms.PictureBox();
            this.lb_floor6 = new System.Windows.Forms.Label();
            this.lb_floor5 = new System.Windows.Forms.Label();
            this.lb_floor4 = new System.Windows.Forms.Label();
            this.lb_floor9 = new System.Windows.Forms.Label();
            this.lb_floor8 = new System.Windows.Forms.Label();
            this.lb_floor7 = new System.Windows.Forms.Label();
            this.tb_CntFloor = new System.Windows.Forms.TextBox();
            this.lb_CurrentFloor = new System.Windows.Forms.Label();
            this.lb_CountFloor = new System.Windows.Forms.Label();
            this.lb_trend = new System.Windows.Forms.Label();
            this.tb_numberLB = new System.Windows.Forms.TextBox();
            this.lb_IdBloka = new System.Windows.Forms.Label();
            this.lb_floor10 = new System.Windows.Forms.Label();
            this.bnt_disconnect = new System.Windows.Forms.Button();
            this.cb_User1 = new System.Windows.Forms.CheckBox();
            this.cb_User2 = new System.Windows.Forms.CheckBox();
            this.cb_User3 = new System.Windows.Forms.CheckBox();
            this.cb_User4 = new System.Windows.Forms.CheckBox();
            this.gb_Users = new System.Windows.Forms.GroupBox();
            this.gb_Sensors = new System.Windows.Forms.GroupBox();
            this.cb_ABL = new System.Windows.Forms.CheckBox();
            this.cb_MP = new System.Windows.Forms.CheckBox();
            this.cb_VIZOV = new System.Windows.Forms.CheckBox();
            this.cb_ROD = new System.Windows.Forms.CheckBox();
            this.cb_RZD = new System.Windows.Forms.CheckBox();
            this.cb_RD = new System.Windows.Forms.CheckBox();
            this.cb_UKSP = new System.Windows.Forms.CheckBox();
            this.cb_RKD = new System.Windows.Forms.CheckBox();
            this.cb_DSH = new System.Windows.Forms.CheckBox();
            this.cb_DK2 = new System.Windows.Forms.CheckBox();
            this.cb_STOP2 = new System.Windows.Forms.CheckBox();
            this.cb_DK1 = new System.Windows.Forms.CheckBox();
            this.cb_VP = new System.Windows.Forms.CheckBox();
            this.cb_STOP1 = new System.Windows.Forms.CheckBox();
            this.gb_Events = new System.Windows.Forms.GroupBox();
            this.pb_IntoHole = new System.Windows.Forms.PictureBox();
            this.pb_NoVoltage = new System.Windows.Forms.PictureBox();
            this.pb_Security = new System.Windows.Forms.PictureBox();
            this.pb_ClaimStop = new System.Windows.Forms.PictureBox();
            this.pb_OpenDoor = new System.Windows.Forms.PictureBox();
            this.pb_NoNet = new System.Windows.Forms.PictureBox();
            this.pb_MP = new System.Windows.Forms.PictureBox();
            this.pb_PowerR = new System.Windows.Forms.PictureBox();
            this.pb_fire = new System.Windows.Forms.PictureBox();
            this.pb_VIZOV = new System.Windows.Forms.PictureBox();
            this.rb_floor1 = new System.Windows.Forms.RadioButton();
            this.rb_floor2 = new System.Windows.Forms.RadioButton();
            this.rb_floor3 = new System.Windows.Forms.RadioButton();
            this.rb_floor4 = new System.Windows.Forms.RadioButton();
            this.rb_floor5 = new System.Windows.Forms.RadioButton();
            this.rb_floor6 = new System.Windows.Forms.RadioButton();
            this.rb_floor10 = new System.Windows.Forms.RadioButton();
            this.rb_floor9 = new System.Windows.Forms.RadioButton();
            this.rb_floor8 = new System.Windows.Forms.RadioButton();
            this.rb_floor7 = new System.Windows.Forms.RadioButton();
            this.pb_lift = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_trend)).BeginInit();
            this.gb_Users.SuspendLayout();
            this.gb_Sensors.SuspendLayout();
            this.gb_Events.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_IntoHole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NoVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Security)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ClaimStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_OpenDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NoNet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PowerR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_VIZOV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lift)).BeginInit();
            this.SuspendLayout();
            // 
            // connectServerCtrl1
            // 
            this.connectServerCtrl1.Configuration = null;
            this.connectServerCtrl1.DisableDomainCheck = false;
            this.connectServerCtrl1.Location = new System.Drawing.Point(9, 41);
            this.connectServerCtrl1.MaximumSize = new System.Drawing.Size(2048, 23);
            this.connectServerCtrl1.MinimumSize = new System.Drawing.Size(500, 23);
            this.connectServerCtrl1.Name = "connectServerCtrl1";
            this.connectServerCtrl1.PreferredLocales = null;
            this.connectServerCtrl1.ServerUrl = "";
            this.connectServerCtrl1.SessionName = "anytext";
            this.connectServerCtrl1.Size = new System.Drawing.Size(500, 23);
            this.connectServerCtrl1.StatusStrip = this.statusStrip1;
            this.connectServerCtrl1.TabIndex = 0;
            this.connectServerCtrl1.UserIdentity = null;
            this.connectServerCtrl1.UseSecurity = true;
            this.connectServerCtrl1.ConnectComplete += new System.EventHandler(this.connectServerCtrl1_ConnectComplete);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tb_CurrentFloor
            // 
            this.tb_CurrentFloor.Location = new System.Drawing.Point(117, 147);
            this.tb_CurrentFloor.Name = "tb_CurrentFloor";
            this.tb_CurrentFloor.Size = new System.Drawing.Size(100, 20);
            this.tb_CurrentFloor.TabIndex = 4;
            // 
            // lb_floor1
            // 
            this.lb_floor1.BackColor = System.Drawing.Color.White;
            this.lb_floor1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_floor1.Location = new System.Drawing.Point(580, 390);
            this.lb_floor1.Name = "lb_floor1";
            this.lb_floor1.Size = new System.Drawing.Size(25, 25);
            this.lb_floor1.TabIndex = 6;
            this.lb_floor1.Text = "1";
            this.lb_floor1.Visible = false;
            // 
            // lb_floor2
            // 
            this.lb_floor2.AutoSize = true;
            this.lb_floor2.BackColor = System.Drawing.Color.Transparent;
            this.lb_floor2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.lb_floor2.Location = new System.Drawing.Point(580, 350);
            this.lb_floor2.Name = "lb_floor2";
            this.lb_floor2.Size = new System.Drawing.Size(25, 25);
            this.lb_floor2.TabIndex = 7;
            this.lb_floor2.Text = "2";
            this.lb_floor2.Visible = false;
            // 
            // lb_floor3
            // 
            this.lb_floor3.AutoSize = true;
            this.lb_floor3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.lb_floor3.Location = new System.Drawing.Point(580, 310);
            this.lb_floor3.Name = "lb_floor3";
            this.lb_floor3.Size = new System.Drawing.Size(25, 25);
            this.lb_floor3.TabIndex = 8;
            this.lb_floor3.Text = "3";
            this.lb_floor3.Visible = false;
            // 
            // pb_trend
            // 
            this.pb_trend.ErrorImage = null;
            this.pb_trend.InitialImage = null;
            this.pb_trend.Location = new System.Drawing.Point(117, 224);
            this.pb_trend.Name = "pb_trend";
            this.pb_trend.Size = new System.Drawing.Size(30, 30);
            this.pb_trend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_trend.TabIndex = 9;
            this.pb_trend.TabStop = false;
            // 
            // lb_floor6
            // 
            this.lb_floor6.AutoSize = true;
            this.lb_floor6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.lb_floor6.Location = new System.Drawing.Point(580, 190);
            this.lb_floor6.Name = "lb_floor6";
            this.lb_floor6.Size = new System.Drawing.Size(25, 25);
            this.lb_floor6.TabIndex = 12;
            this.lb_floor6.Text = "6";
            this.lb_floor6.Visible = false;
            // 
            // lb_floor5
            // 
            this.lb_floor5.AutoSize = true;
            this.lb_floor5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.lb_floor5.Location = new System.Drawing.Point(580, 230);
            this.lb_floor5.Name = "lb_floor5";
            this.lb_floor5.Size = new System.Drawing.Size(25, 25);
            this.lb_floor5.TabIndex = 11;
            this.lb_floor5.Text = "5";
            this.lb_floor5.Visible = false;
            // 
            // lb_floor4
            // 
            this.lb_floor4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_floor4.Location = new System.Drawing.Point(580, 270);
            this.lb_floor4.Name = "lb_floor4";
            this.lb_floor4.Size = new System.Drawing.Size(25, 25);
            this.lb_floor4.TabIndex = 10;
            this.lb_floor4.Text = "4";
            this.lb_floor4.Visible = false;
            // 
            // lb_floor9
            // 
            this.lb_floor9.AutoSize = true;
            this.lb_floor9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.lb_floor9.Location = new System.Drawing.Point(580, 70);
            this.lb_floor9.Name = "lb_floor9";
            this.lb_floor9.Size = new System.Drawing.Size(25, 25);
            this.lb_floor9.TabIndex = 15;
            this.lb_floor9.Text = "9";
            this.lb_floor9.Visible = false;
            // 
            // lb_floor8
            // 
            this.lb_floor8.AutoSize = true;
            this.lb_floor8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.lb_floor8.Location = new System.Drawing.Point(580, 110);
            this.lb_floor8.Name = "lb_floor8";
            this.lb_floor8.Size = new System.Drawing.Size(25, 25);
            this.lb_floor8.TabIndex = 14;
            this.lb_floor8.Text = "8";
            this.lb_floor8.Visible = false;
            // 
            // lb_floor7
            // 
            this.lb_floor7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_floor7.Location = new System.Drawing.Point(580, 150);
            this.lb_floor7.Name = "lb_floor7";
            this.lb_floor7.Size = new System.Drawing.Size(25, 25);
            this.lb_floor7.TabIndex = 13;
            this.lb_floor7.Text = "7";
            this.lb_floor7.Visible = false;
            // 
            // tb_CntFloor
            // 
            this.tb_CntFloor.Location = new System.Drawing.Point(117, 187);
            this.tb_CntFloor.Name = "tb_CntFloor";
            this.tb_CntFloor.Size = new System.Drawing.Size(100, 20);
            this.tb_CntFloor.TabIndex = 27;
            // 
            // lb_CurrentFloor
            // 
            this.lb_CurrentFloor.AutoSize = true;
            this.lb_CurrentFloor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_CurrentFloor.Location = new System.Drawing.Point(7, 147);
            this.lb_CurrentFloor.Name = "lb_CurrentFloor";
            this.lb_CurrentFloor.Size = new System.Drawing.Size(104, 16);
            this.lb_CurrentFloor.TabIndex = 28;
            this.lb_CurrentFloor.Text = "Текущий этаж";
            this.lb_CurrentFloor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CountFloor
            // 
            this.lb_CountFloor.AutoSize = true;
            this.lb_CountFloor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_CountFloor.Location = new System.Drawing.Point(7, 181);
            this.lb_CountFloor.Name = "lb_CountFloor";
            this.lb_CountFloor.Size = new System.Drawing.Size(104, 32);
            this.lb_CountFloor.TabIndex = 29;
            this.lb_CountFloor.Text = "Общее кол-во\r\n этажей";
            this.lb_CountFloor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_trend
            // 
            this.lb_trend.AutoSize = true;
            this.lb_trend.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_trend.Location = new System.Drawing.Point(9, 230);
            this.lb_trend.Name = "lb_trend";
            this.lb_trend.Size = new System.Drawing.Size(97, 16);
            this.lb_trend.TabIndex = 30;
            this.lb_trend.Text = "Направление";
            this.lb_trend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_numberLB
            // 
            this.tb_numberLB.Location = new System.Drawing.Point(172, 68);
            this.tb_numberLB.Name = "tb_numberLB";
            this.tb_numberLB.Size = new System.Drawing.Size(100, 20);
            this.tb_numberLB.TabIndex = 34;
            // 
            // lb_IdBloka
            // 
            this.lb_IdBloka.AutoSize = true;
            this.lb_IdBloka.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_IdBloka.Location = new System.Drawing.Point(9, 70);
            this.lb_IdBloka.Name = "lb_IdBloka";
            this.lb_IdBloka.Size = new System.Drawing.Size(157, 16);
            this.lb_IdBloka.TabIndex = 35;
            this.lb_IdBloka.Text = "Идентификатор блока";
            this.lb_IdBloka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_floor10
            // 
            this.lb_floor10.AutoSize = true;
            this.lb_floor10.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.lb_floor10.Location = new System.Drawing.Point(580, 30);
            this.lb_floor10.Name = "lb_floor10";
            this.lb_floor10.Size = new System.Drawing.Size(38, 25);
            this.lb_floor10.TabIndex = 37;
            this.lb_floor10.Text = "10";
            this.lb_floor10.Visible = false;
            // 
            // bnt_disconnect
            // 
            this.bnt_disconnect.Location = new System.Drawing.Point(433, 75);
            this.bnt_disconnect.Name = "bnt_disconnect";
            this.bnt_disconnect.Size = new System.Drawing.Size(76, 23);
            this.bnt_disconnect.TabIndex = 39;
            this.bnt_disconnect.Text = "Disconnect";
            this.bnt_disconnect.UseVisualStyleBackColor = true;
            this.bnt_disconnect.Click += new System.EventHandler(this.bnt_disconnect_Click);
            // 
            // cb_User1
            // 
            this.cb_User1.AutoCheck = false;
            this.cb_User1.AutoSize = true;
            this.cb_User1.Location = new System.Drawing.Point(6, 20);
            this.cb_User1.Name = "cb_User1";
            this.cb_User1.Size = new System.Drawing.Size(60, 20);
            this.cb_User1.TabIndex = 41;
            this.cb_User1.Text = "User1";
            this.cb_User1.UseVisualStyleBackColor = true;
            // 
            // cb_User2
            // 
            this.cb_User2.AutoCheck = false;
            this.cb_User2.AutoSize = true;
            this.cb_User2.Location = new System.Drawing.Point(6, 40);
            this.cb_User2.Name = "cb_User2";
            this.cb_User2.Size = new System.Drawing.Size(60, 20);
            this.cb_User2.TabIndex = 42;
            this.cb_User2.Text = "User2";
            this.cb_User2.UseVisualStyleBackColor = true;
            // 
            // cb_User3
            // 
            this.cb_User3.AutoCheck = false;
            this.cb_User3.AutoSize = true;
            this.cb_User3.Location = new System.Drawing.Point(105, 20);
            this.cb_User3.Name = "cb_User3";
            this.cb_User3.Size = new System.Drawing.Size(60, 20);
            this.cb_User3.TabIndex = 43;
            this.cb_User3.Text = "User3";
            this.cb_User3.UseVisualStyleBackColor = true;
            // 
            // cb_User4
            // 
            this.cb_User4.AutoCheck = false;
            this.cb_User4.AutoSize = true;
            this.cb_User4.Location = new System.Drawing.Point(105, 40);
            this.cb_User4.Name = "cb_User4";
            this.cb_User4.Size = new System.Drawing.Size(60, 20);
            this.cb_User4.TabIndex = 44;
            this.cb_User4.Text = "User4";
            this.cb_User4.UseVisualStyleBackColor = true;
            // 
            // gb_Users
            // 
            this.gb_Users.Controls.Add(this.cb_User3);
            this.gb_Users.Controls.Add(this.cb_User4);
            this.gb_Users.Controls.Add(this.cb_User1);
            this.gb_Users.Controls.Add(this.cb_User2);
            this.gb_Users.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_Users.Location = new System.Drawing.Point(797, 196);
            this.gb_Users.Name = "gb_Users";
            this.gb_Users.Size = new System.Drawing.Size(171, 65);
            this.gb_Users.TabIndex = 45;
            this.gb_Users.TabStop = false;
            this.gb_Users.Text = "Дополнительные входы";
            // 
            // gb_Sensors
            // 
            this.gb_Sensors.Controls.Add(this.cb_ABL);
            this.gb_Sensors.Controls.Add(this.cb_MP);
            this.gb_Sensors.Controls.Add(this.cb_VIZOV);
            this.gb_Sensors.Controls.Add(this.cb_ROD);
            this.gb_Sensors.Controls.Add(this.cb_RZD);
            this.gb_Sensors.Controls.Add(this.cb_RD);
            this.gb_Sensors.Controls.Add(this.cb_UKSP);
            this.gb_Sensors.Controls.Add(this.cb_RKD);
            this.gb_Sensors.Controls.Add(this.cb_DSH);
            this.gb_Sensors.Controls.Add(this.cb_DK2);
            this.gb_Sensors.Controls.Add(this.cb_STOP2);
            this.gb_Sensors.Controls.Add(this.cb_DK1);
            this.gb_Sensors.Controls.Add(this.cb_VP);
            this.gb_Sensors.Controls.Add(this.cb_STOP1);
            this.gb_Sensors.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_Sensors.Location = new System.Drawing.Point(809, 27);
            this.gb_Sensors.Name = "gb_Sensors";
            this.gb_Sensors.Size = new System.Drawing.Size(140, 163);
            this.gb_Sensors.TabIndex = 46;
            this.gb_Sensors.TabStop = false;
            this.gb_Sensors.Text = "Датчики ЛБ:";
            // 
            // cb_ABL
            // 
            this.cb_ABL.AutoCheck = false;
            this.cb_ABL.AutoSize = true;
            this.cb_ABL.Location = new System.Drawing.Point(72, 120);
            this.cb_ABL.Name = "cb_ABL";
            this.cb_ABL.Size = new System.Drawing.Size(52, 20);
            this.cb_ABL.TabIndex = 53;
            this.cb_ABL.Text = "АБЛ";
            this.cb_ABL.UseVisualStyleBackColor = true;
            // 
            // cb_MP
            // 
            this.cb_MP.AutoCheck = false;
            this.cb_MP.AutoSize = true;
            this.cb_MP.Location = new System.Drawing.Point(72, 140);
            this.cb_MP.Name = "cb_MP";
            this.cb_MP.Size = new System.Drawing.Size(45, 20);
            this.cb_MP.TabIndex = 54;
            this.cb_MP.Text = "МП";
            this.cb_MP.UseVisualStyleBackColor = true;
            // 
            // cb_VIZOV
            // 
            this.cb_VIZOV.AutoCheck = false;
            this.cb_VIZOV.AutoSize = true;
            this.cb_VIZOV.Location = new System.Drawing.Point(72, 100);
            this.cb_VIZOV.Name = "cb_VIZOV";
            this.cb_VIZOV.Size = new System.Drawing.Size(67, 20);
            this.cb_VIZOV.TabIndex = 52;
            this.cb_VIZOV.Text = "ВЫЗОВ";
            this.cb_VIZOV.UseVisualStyleBackColor = true;
            // 
            // cb_ROD
            // 
            this.cb_ROD.AutoCheck = false;
            this.cb_ROD.AutoSize = true;
            this.cb_ROD.Location = new System.Drawing.Point(72, 60);
            this.cb_ROD.Name = "cb_ROD";
            this.cb_ROD.Size = new System.Drawing.Size(52, 20);
            this.cb_ROD.TabIndex = 50;
            this.cb_ROD.Text = "РОД";
            this.cb_ROD.UseVisualStyleBackColor = true;
            // 
            // cb_RZD
            // 
            this.cb_RZD.AutoCheck = false;
            this.cb_RZD.AutoSize = true;
            this.cb_RZD.Location = new System.Drawing.Point(72, 80);
            this.cb_RZD.Name = "cb_RZD";
            this.cb_RZD.Size = new System.Drawing.Size(50, 20);
            this.cb_RZD.TabIndex = 51;
            this.cb_RZD.Text = "РЗД";
            this.cb_RZD.UseVisualStyleBackColor = true;
            // 
            // cb_RD
            // 
            this.cb_RD.AutoCheck = false;
            this.cb_RD.AutoSize = true;
            this.cb_RD.Location = new System.Drawing.Point(72, 20);
            this.cb_RD.Name = "cb_RD";
            this.cb_RD.Size = new System.Drawing.Size(43, 20);
            this.cb_RD.TabIndex = 48;
            this.cb_RD.Text = "РД";
            this.cb_RD.UseVisualStyleBackColor = true;
            // 
            // cb_UKSP
            // 
            this.cb_UKSP.AutoCheck = false;
            this.cb_UKSP.AutoSize = true;
            this.cb_UKSP.Location = new System.Drawing.Point(72, 40);
            this.cb_UKSP.Name = "cb_UKSP";
            this.cb_UKSP.Size = new System.Drawing.Size(57, 20);
            this.cb_UKSP.TabIndex = 49;
            this.cb_UKSP.Text = "УКСП";
            this.cb_UKSP.UseVisualStyleBackColor = true;
            // 
            // cb_RKD
            // 
            this.cb_RKD.AutoCheck = false;
            this.cb_RKD.AutoSize = true;
            this.cb_RKD.Location = new System.Drawing.Point(6, 120);
            this.cb_RKD.Name = "cb_RKD";
            this.cb_RKD.Size = new System.Drawing.Size(50, 20);
            this.cb_RKD.TabIndex = 46;
            this.cb_RKD.Text = "РКД";
            this.cb_RKD.UseVisualStyleBackColor = true;
            // 
            // cb_DSH
            // 
            this.cb_DSH.AutoCheck = false;
            this.cb_DSH.AutoSize = true;
            this.cb_DSH.Location = new System.Drawing.Point(6, 140);
            this.cb_DSH.Name = "cb_DSH";
            this.cb_DSH.Size = new System.Drawing.Size(48, 20);
            this.cb_DSH.TabIndex = 47;
            this.cb_DSH.Text = "ДШ";
            this.cb_DSH.UseVisualStyleBackColor = true;
            // 
            // cb_DK2
            // 
            this.cb_DK2.AutoCheck = false;
            this.cb_DK2.AutoSize = true;
            this.cb_DK2.Location = new System.Drawing.Point(6, 100);
            this.cb_DK2.Name = "cb_DK2";
            this.cb_DK2.Size = new System.Drawing.Size(50, 20);
            this.cb_DK2.TabIndex = 45;
            this.cb_DK2.Text = "ДК2";
            this.cb_DK2.UseVisualStyleBackColor = true;
            // 
            // cb_STOP2
            // 
            this.cb_STOP2.AutoCheck = false;
            this.cb_STOP2.AutoSize = true;
            this.cb_STOP2.Location = new System.Drawing.Point(6, 60);
            this.cb_STOP2.Name = "cb_STOP2";
            this.cb_STOP2.Size = new System.Drawing.Size(67, 20);
            this.cb_STOP2.TabIndex = 43;
            this.cb_STOP2.Text = "СТОП2";
            this.cb_STOP2.UseVisualStyleBackColor = true;
            // 
            // cb_DK1
            // 
            this.cb_DK1.AutoCheck = false;
            this.cb_DK1.AutoSize = true;
            this.cb_DK1.Location = new System.Drawing.Point(6, 80);
            this.cb_DK1.Name = "cb_DK1";
            this.cb_DK1.Size = new System.Drawing.Size(50, 20);
            this.cb_DK1.TabIndex = 44;
            this.cb_DK1.Text = "ДК1";
            this.cb_DK1.UseVisualStyleBackColor = true;
            // 
            // cb_VP
            // 
            this.cb_VP.AutoCheck = false;
            this.cb_VP.AutoSize = true;
            this.cb_VP.Location = new System.Drawing.Point(6, 20);
            this.cb_VP.Name = "cb_VP";
            this.cb_VP.Size = new System.Drawing.Size(42, 20);
            this.cb_VP.TabIndex = 41;
            this.cb_VP.Text = "ВП";
            this.cb_VP.UseVisualStyleBackColor = true;
            // 
            // cb_STOP1
            // 
            this.cb_STOP1.AutoCheck = false;
            this.cb_STOP1.AutoSize = true;
            this.cb_STOP1.Location = new System.Drawing.Point(6, 40);
            this.cb_STOP1.Name = "cb_STOP1";
            this.cb_STOP1.Size = new System.Drawing.Size(67, 20);
            this.cb_STOP1.TabIndex = 42;
            this.cb_STOP1.Text = "СТОП1";
            this.cb_STOP1.UseVisualStyleBackColor = true;
            // 
            // gb_Events
            // 
            this.gb_Events.Controls.Add(this.pb_IntoHole);
            this.gb_Events.Controls.Add(this.pb_NoVoltage);
            this.gb_Events.Controls.Add(this.pb_Security);
            this.gb_Events.Controls.Add(this.pb_ClaimStop);
            this.gb_Events.Controls.Add(this.pb_OpenDoor);
            this.gb_Events.Controls.Add(this.pb_NoNet);
            this.gb_Events.Controls.Add(this.pb_MP);
            this.gb_Events.Controls.Add(this.pb_PowerR);
            this.gb_Events.Controls.Add(this.pb_fire);
            this.gb_Events.Controls.Add(this.pb_VIZOV);
            this.gb_Events.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.gb_Events.Location = new System.Drawing.Point(12, 295);
            this.gb_Events.Name = "gb_Events";
            this.gb_Events.Size = new System.Drawing.Size(270, 122);
            this.gb_Events.TabIndex = 47;
            this.gb_Events.TabStop = false;
            this.gb_Events.Text = "События";
            // 
            // pb_IntoHole
            // 
            this.pb_IntoHole.Image = global::TestConnectOPCUA.Properties.Resources.schaht_r;
            this.pb_IntoHole.Location = new System.Drawing.Point(228, 75);
            this.pb_IntoHole.Name = "pb_IntoHole";
            this.pb_IntoHole.Size = new System.Drawing.Size(32, 32);
            this.pb_IntoHole.TabIndex = 12;
            this.pb_IntoHole.TabStop = false;
            this.pb_IntoHole.Visible = false;
            // 
            // pb_NoVoltage
            // 
            this.pb_NoVoltage.Image = global::TestConnectOPCUA.Properties.Resources.off_r;
            this.pb_NoVoltage.Location = new System.Drawing.Point(174, 75);
            this.pb_NoVoltage.Name = "pb_NoVoltage";
            this.pb_NoVoltage.Size = new System.Drawing.Size(32, 32);
            this.pb_NoVoltage.TabIndex = 10;
            this.pb_NoVoltage.TabStop = false;
            this.pb_NoVoltage.Visible = false;
            // 
            // pb_Security
            // 
            this.pb_Security.Image = global::TestConnectOPCUA.Properties.Resources.errlb_r;
            this.pb_Security.Location = new System.Drawing.Point(118, 75);
            this.pb_Security.Name = "pb_Security";
            this.pb_Security.Size = new System.Drawing.Size(32, 32);
            this.pb_Security.TabIndex = 9;
            this.pb_Security.TabStop = false;
            this.pb_Security.Visible = false;
            // 
            // pb_ClaimStop
            // 
            this.pb_ClaimStop.Image = global::TestConnectOPCUA.Properties.Resources.keystp_r;
            this.pb_ClaimStop.Location = new System.Drawing.Point(62, 20);
            this.pb_ClaimStop.Name = "pb_ClaimStop";
            this.pb_ClaimStop.Size = new System.Drawing.Size(32, 32);
            this.pb_ClaimStop.TabIndex = 8;
            this.pb_ClaimStop.TabStop = false;
            this.pb_ClaimStop.Visible = false;
            // 
            // pb_OpenDoor
            // 
            this.pb_OpenDoor.Image = global::TestConnectOPCUA.Properties.Resources.open_r;
            this.pb_OpenDoor.Location = new System.Drawing.Point(62, 75);
            this.pb_OpenDoor.Name = "pb_OpenDoor";
            this.pb_OpenDoor.Size = new System.Drawing.Size(32, 32);
            this.pb_OpenDoor.TabIndex = 7;
            this.pb_OpenDoor.TabStop = false;
            this.pb_OpenDoor.Visible = false;
            // 
            // pb_NoNet
            // 
            this.pb_NoNet.Image = global::TestConnectOPCUA.Properties.Resources.NoNet_r;
            this.pb_NoNet.Location = new System.Drawing.Point(230, 20);
            this.pb_NoNet.Name = "pb_NoNet";
            this.pb_NoNet.Size = new System.Drawing.Size(32, 32);
            this.pb_NoNet.TabIndex = 5;
            this.pb_NoNet.TabStop = false;
            this.pb_NoNet.Visible = false;
            // 
            // pb_MP
            // 
            this.pb_MP.Image = global::TestConnectOPCUA.Properties.Resources.mp_r;
            this.pb_MP.Location = new System.Drawing.Point(6, 75);
            this.pb_MP.Name = "pb_MP";
            this.pb_MP.Size = new System.Drawing.Size(32, 32);
            this.pb_MP.TabIndex = 4;
            this.pb_MP.TabStop = false;
            this.pb_MP.Visible = false;
            // 
            // pb_PowerR
            // 
            this.pb_PowerR.Image = global::TestConnectOPCUA.Properties.Resources.power_r;
            this.pb_PowerR.Location = new System.Drawing.Point(174, 19);
            this.pb_PowerR.Name = "pb_PowerR";
            this.pb_PowerR.Size = new System.Drawing.Size(32, 32);
            this.pb_PowerR.TabIndex = 3;
            this.pb_PowerR.TabStop = false;
            this.pb_PowerR.Visible = false;
            // 
            // pb_fire
            // 
            this.pb_fire.Image = global::TestConnectOPCUA.Properties.Resources.fire_r;
            this.pb_fire.Location = new System.Drawing.Point(118, 19);
            this.pb_fire.Name = "pb_fire";
            this.pb_fire.Size = new System.Drawing.Size(32, 32);
            this.pb_fire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_fire.TabIndex = 2;
            this.pb_fire.TabStop = false;
            this.pb_fire.Visible = false;
            // 
            // pb_VIZOV
            // 
            this.pb_VIZOV.ErrorImage = null;
            this.pb_VIZOV.Image = global::TestConnectOPCUA.Properties.Resources.Ask_r;
            this.pb_VIZOV.Location = new System.Drawing.Point(6, 19);
            this.pb_VIZOV.Name = "pb_VIZOV";
            this.pb_VIZOV.Size = new System.Drawing.Size(32, 32);
            this.pb_VIZOV.TabIndex = 0;
            this.pb_VIZOV.TabStop = false;
            this.pb_VIZOV.Visible = false;
            // 
            // rb_floor1
            // 
            this.rb_floor1.AutoSize = true;
            this.rb_floor1.BackColor = System.Drawing.Color.White;
            this.rb_floor1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_floor1.Location = new System.Drawing.Point(560, 395);
            this.rb_floor1.Name = "rb_floor1";
            this.rb_floor1.Size = new System.Drawing.Size(14, 13);
            this.rb_floor1.TabIndex = 52;
            this.rb_floor1.TabStop = true;
            this.rb_floor1.UseVisualStyleBackColor = false;
            this.rb_floor1.Visible = false;
            // 
            // rb_floor2
            // 
            this.rb_floor2.AutoSize = true;
            this.rb_floor2.BackColor = System.Drawing.Color.White;
            this.rb_floor2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_floor2.Location = new System.Drawing.Point(560, 355);
            this.rb_floor2.Name = "rb_floor2";
            this.rb_floor2.Size = new System.Drawing.Size(14, 13);
            this.rb_floor2.TabIndex = 53;
            this.rb_floor2.TabStop = true;
            this.rb_floor2.UseVisualStyleBackColor = false;
            this.rb_floor2.Visible = false;
            // 
            // rb_floor3
            // 
            this.rb_floor3.AutoSize = true;
            this.rb_floor3.BackColor = System.Drawing.Color.White;
            this.rb_floor3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_floor3.Location = new System.Drawing.Point(560, 315);
            this.rb_floor3.Name = "rb_floor3";
            this.rb_floor3.Size = new System.Drawing.Size(14, 13);
            this.rb_floor3.TabIndex = 54;
            this.rb_floor3.TabStop = true;
            this.rb_floor3.UseVisualStyleBackColor = false;
            this.rb_floor3.Visible = false;
            // 
            // rb_floor4
            // 
            this.rb_floor4.AutoSize = true;
            this.rb_floor4.BackColor = System.Drawing.Color.White;
            this.rb_floor4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_floor4.Location = new System.Drawing.Point(560, 275);
            this.rb_floor4.Name = "rb_floor4";
            this.rb_floor4.Size = new System.Drawing.Size(14, 13);
            this.rb_floor4.TabIndex = 55;
            this.rb_floor4.TabStop = true;
            this.rb_floor4.UseVisualStyleBackColor = false;
            this.rb_floor4.Visible = false;
            // 
            // rb_floor5
            // 
            this.rb_floor5.AutoSize = true;
            this.rb_floor5.BackColor = System.Drawing.Color.White;
            this.rb_floor5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_floor5.Location = new System.Drawing.Point(560, 235);
            this.rb_floor5.Name = "rb_floor5";
            this.rb_floor5.Size = new System.Drawing.Size(14, 13);
            this.rb_floor5.TabIndex = 56;
            this.rb_floor5.TabStop = true;
            this.rb_floor5.UseVisualStyleBackColor = false;
            this.rb_floor5.Visible = false;
            // 
            // rb_floor6
            // 
            this.rb_floor6.AutoSize = true;
            this.rb_floor6.BackColor = System.Drawing.Color.White;
            this.rb_floor6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_floor6.Location = new System.Drawing.Point(560, 195);
            this.rb_floor6.Name = "rb_floor6";
            this.rb_floor6.Size = new System.Drawing.Size(14, 13);
            this.rb_floor6.TabIndex = 57;
            this.rb_floor6.TabStop = true;
            this.rb_floor6.UseVisualStyleBackColor = false;
            this.rb_floor6.Visible = false;
            // 
            // rb_floor10
            // 
            this.rb_floor10.AutoSize = true;
            this.rb_floor10.BackColor = System.Drawing.Color.White;
            this.rb_floor10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_floor10.Location = new System.Drawing.Point(560, 35);
            this.rb_floor10.Name = "rb_floor10";
            this.rb_floor10.Size = new System.Drawing.Size(14, 13);
            this.rb_floor10.TabIndex = 61;
            this.rb_floor10.TabStop = true;
            this.rb_floor10.UseVisualStyleBackColor = false;
            this.rb_floor10.Visible = false;
            // 
            // rb_floor9
            // 
            this.rb_floor9.AutoSize = true;
            this.rb_floor9.BackColor = System.Drawing.Color.White;
            this.rb_floor9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_floor9.Location = new System.Drawing.Point(560, 75);
            this.rb_floor9.Name = "rb_floor9";
            this.rb_floor9.Size = new System.Drawing.Size(14, 13);
            this.rb_floor9.TabIndex = 60;
            this.rb_floor9.TabStop = true;
            this.rb_floor9.UseVisualStyleBackColor = false;
            this.rb_floor9.Visible = false;
            // 
            // rb_floor8
            // 
            this.rb_floor8.AutoSize = true;
            this.rb_floor8.BackColor = System.Drawing.Color.White;
            this.rb_floor8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_floor8.Location = new System.Drawing.Point(560, 115);
            this.rb_floor8.Name = "rb_floor8";
            this.rb_floor8.Size = new System.Drawing.Size(14, 13);
            this.rb_floor8.TabIndex = 59;
            this.rb_floor8.TabStop = true;
            this.rb_floor8.UseVisualStyleBackColor = false;
            this.rb_floor8.Visible = false;
            // 
            // rb_floor7
            // 
            this.rb_floor7.AutoSize = true;
            this.rb_floor7.BackColor = System.Drawing.Color.White;
            this.rb_floor7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_floor7.Location = new System.Drawing.Point(560, 155);
            this.rb_floor7.Name = "rb_floor7";
            this.rb_floor7.Size = new System.Drawing.Size(14, 13);
            this.rb_floor7.TabIndex = 58;
            this.rb_floor7.TabStop = true;
            this.rb_floor7.UseVisualStyleBackColor = false;
            this.rb_floor7.Visible = false;
            // 
            // pb_lift
            // 
            this.pb_lift.Image = ((System.Drawing.Image)(resources.GetObject("pb_lift.Image")));
            this.pb_lift.Location = new System.Drawing.Point(620, 390);
            this.pb_lift.Name = "pb_lift";
            this.pb_lift.Size = new System.Drawing.Size(35, 35);
            this.pb_lift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_lift.TabIndex = 5;
            this.pb_lift.TabStop = false;
            this.pb_lift.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.rb_floor10);
            this.Controls.Add(this.rb_floor9);
            this.Controls.Add(this.rb_floor8);
            this.Controls.Add(this.rb_floor7);
            this.Controls.Add(this.rb_floor6);
            this.Controls.Add(this.rb_floor5);
            this.Controls.Add(this.rb_floor4);
            this.Controls.Add(this.rb_floor3);
            this.Controls.Add(this.rb_floor2);
            this.Controls.Add(this.rb_floor1);
            this.Controls.Add(this.gb_Events);
            this.Controls.Add(this.gb_Sensors);
            this.Controls.Add(this.gb_Users);
            this.Controls.Add(this.bnt_disconnect);
            this.Controls.Add(this.lb_floor10);
            this.Controls.Add(this.lb_IdBloka);
            this.Controls.Add(this.tb_numberLB);
            this.Controls.Add(this.lb_trend);
            this.Controls.Add(this.lb_CountFloor);
            this.Controls.Add(this.lb_CurrentFloor);
            this.Controls.Add(this.tb_CntFloor);
            this.Controls.Add(this.lb_floor9);
            this.Controls.Add(this.lb_floor8);
            this.Controls.Add(this.lb_floor7);
            this.Controls.Add(this.lb_floor6);
            this.Controls.Add(this.lb_floor5);
            this.Controls.Add(this.lb_floor4);
            this.Controls.Add(this.pb_trend);
            this.Controls.Add(this.lb_floor3);
            this.Controls.Add(this.lb_floor2);
            this.Controls.Add(this.lb_floor1);
            this.Controls.Add(this.pb_lift);
            this.Controls.Add(this.tb_CurrentFloor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.connectServerCtrl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_trend)).EndInit();
            this.gb_Users.ResumeLayout(false);
            this.gb_Users.PerformLayout();
            this.gb_Sensors.ResumeLayout(false);
            this.gb_Sensors.PerformLayout();
            this.gb_Events.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_IntoHole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NoVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Security)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ClaimStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_OpenDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NoNet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PowerR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_VIZOV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Opc.Ua.Client.Controls.ConnectServerCtrl connectServerCtrl1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox tb_CurrentFloor;
        private System.Windows.Forms.PictureBox pb_lift;
        private System.Windows.Forms.Label lb_floor1;
        private System.Windows.Forms.Label lb_floor2;
        private System.Windows.Forms.Label lb_floor3;
        private System.Windows.Forms.PictureBox pb_trend;
        private System.Windows.Forms.Label lb_floor6;
        private System.Windows.Forms.Label lb_floor5;
        private System.Windows.Forms.Label lb_floor4;
        private System.Windows.Forms.Label lb_floor9;
        private System.Windows.Forms.Label lb_floor8;
        private System.Windows.Forms.Label lb_floor7;
        private System.Windows.Forms.TextBox tb_CntFloor;
        private System.Windows.Forms.Label lb_CurrentFloor;
        private System.Windows.Forms.Label lb_CountFloor;
        private System.Windows.Forms.Label lb_trend;
        private System.Windows.Forms.TextBox tb_numberLB;
        private System.Windows.Forms.Label lb_IdBloka;
        private System.Windows.Forms.Label lb_floor10;
        private System.Windows.Forms.Button bnt_disconnect;
        private System.Windows.Forms.CheckBox cb_User1;
        private System.Windows.Forms.CheckBox cb_User2;
        private System.Windows.Forms.CheckBox cb_User3;
        private System.Windows.Forms.CheckBox cb_User4;
        private System.Windows.Forms.GroupBox gb_Users;
        private System.Windows.Forms.GroupBox gb_Sensors;
        private System.Windows.Forms.CheckBox cb_ABL;
        private System.Windows.Forms.CheckBox cb_MP;
        private System.Windows.Forms.CheckBox cb_VIZOV;
        private System.Windows.Forms.CheckBox cb_ROD;
        private System.Windows.Forms.CheckBox cb_RZD;
        private System.Windows.Forms.CheckBox cb_RD;
        private System.Windows.Forms.CheckBox cb_UKSP;
        private System.Windows.Forms.CheckBox cb_RKD;
        private System.Windows.Forms.CheckBox cb_DSH;
        private System.Windows.Forms.CheckBox cb_DK2;
        private System.Windows.Forms.CheckBox cb_STOP2;
        private System.Windows.Forms.CheckBox cb_DK1;
        private System.Windows.Forms.CheckBox cb_VP;
        private System.Windows.Forms.CheckBox cb_STOP1;
        private System.Windows.Forms.GroupBox gb_Events;
        private System.Windows.Forms.PictureBox pb_NoVoltage;
        private System.Windows.Forms.PictureBox pb_Security;
        private System.Windows.Forms.PictureBox pb_ClaimStop;
        private System.Windows.Forms.PictureBox pb_OpenDoor;
        private System.Windows.Forms.PictureBox pb_NoNet;
        private System.Windows.Forms.PictureBox pb_MP;
        private System.Windows.Forms.PictureBox pb_PowerR;
        private System.Windows.Forms.PictureBox pb_fire;
        private System.Windows.Forms.PictureBox pb_VIZOV;
        private System.Windows.Forms.PictureBox pb_IntoHole;
        private System.Windows.Forms.RadioButton rb_floor1;
        private System.Windows.Forms.RadioButton rb_floor2;
        private System.Windows.Forms.RadioButton rb_floor3;
        private System.Windows.Forms.RadioButton rb_floor4;
        private System.Windows.Forms.RadioButton rb_floor5;
        private System.Windows.Forms.RadioButton rb_floor6;
        private System.Windows.Forms.RadioButton rb_floor10;
        private System.Windows.Forms.RadioButton rb_floor9;
        private System.Windows.Forms.RadioButton rb_floor8;
        private System.Windows.Forms.RadioButton rb_floor7;
    }
}


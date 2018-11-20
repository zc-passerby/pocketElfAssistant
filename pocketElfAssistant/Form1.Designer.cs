namespace pocketElfAssistant
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.MiBrowse = new System.Windows.Forms.ToolStripMenuItem();
            this.MiRelogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MiFastFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.MiUndress = new System.Windows.Forms.ToolStripMenuItem();
            this.MiDress = new System.Windows.Forms.ToolStripMenuItem();
            this.MiAccountManage = new System.Windows.Forms.ToolStripMenuItem();
            this.MiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MiCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.MiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MiSoftUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.MiSoftInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TcMain = new System.Windows.Forms.TabControl();
            this.TpAccount = new System.Windows.Forms.TabPage();
            this.TpBasicFunc = new System.Windows.Forms.TabPage();
            this.TpFight = new System.Windows.Forms.TabPage();
            this.TpSpecialFunc = new System.Windows.Forms.TabPage();
            this.TpSoftDeclare = new System.Windows.Forms.TabPage();
            this.GbAccount = new System.Windows.Forms.GroupBox();
            this.GbUserInfo = new System.Windows.Forms.GroupBox();
            this.CbAccount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbAccount = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.CbTargetServer = new System.Windows.Forms.ComboBox();
            this.LlabelBrowse = new System.Windows.Forms.LinkLabel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnTestSpeed = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LlabelRefresh = new System.Windows.Forms.LinkLabel();
            this.BtnCopyUserInfo = new System.Windows.Forms.Button();
            this.LableUserName = new System.Windows.Forms.Label();
            this.LableMajorPet = new System.Windows.Forms.Label();
            this.LableCrystal = new System.Windows.Forms.Label();
            this.LableGoldCoin = new System.Windows.Forms.Label();
            this.LableBottom = new System.Windows.Forms.Label();
            this.CbMajorPetSkill = new System.Windows.Forms.ComboBox();
            this.MenuStripMain.SuspendLayout();
            this.TcMain.SuspendLayout();
            this.TpAccount.SuspendLayout();
            this.GbAccount.SuspendLayout();
            this.GbUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripMain
            // 
            this.MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiBrowse,
            this.MiRelogin,
            this.MiFastFunc,
            this.MiSettings,
            this.MiCourse,
            this.MiAbout});
            this.MenuStripMain.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMain.Name = "MenuStripMain";
            this.MenuStripMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MenuStripMain.Size = new System.Drawing.Size(674, 25);
            this.MenuStripMain.TabIndex = 0;
            this.MenuStripMain.Text = "菜单";
            // 
            // MiBrowse
            // 
            this.MiBrowse.Name = "MiBrowse";
            this.MiBrowse.Size = new System.Drawing.Size(44, 21);
            this.MiBrowse.Text = "界面";
            // 
            // MiRelogin
            // 
            this.MiRelogin.Name = "MiRelogin";
            this.MiRelogin.Size = new System.Drawing.Size(44, 21);
            this.MiRelogin.Text = "重登";
            // 
            // MiFastFunc
            // 
            this.MiFastFunc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiUndress,
            this.MiDress,
            this.MiAccountManage});
            this.MiFastFunc.Name = "MiFastFunc";
            this.MiFastFunc.Size = new System.Drawing.Size(44, 21);
            this.MiFastFunc.Text = "快捷";
            // 
            // MiUndress
            // 
            this.MiUndress.Name = "MiUndress";
            this.MiUndress.Size = new System.Drawing.Size(180, 22);
            this.MiUndress.Text = "一键脱装";
            // 
            // MiDress
            // 
            this.MiDress.Name = "MiDress";
            this.MiDress.Size = new System.Drawing.Size(180, 22);
            this.MiDress.Text = "一键穿装";
            // 
            // MiAccountManage
            // 
            this.MiAccountManage.Name = "MiAccountManage";
            this.MiAccountManage.Size = new System.Drawing.Size(180, 22);
            this.MiAccountManage.Text = "帐号管理";
            // 
            // MiSettings
            // 
            this.MiSettings.Name = "MiSettings";
            this.MiSettings.Size = new System.Drawing.Size(44, 21);
            this.MiSettings.Text = "设置";
            // 
            // MiCourse
            // 
            this.MiCourse.Name = "MiCourse";
            this.MiCourse.Size = new System.Drawing.Size(44, 21);
            this.MiCourse.Text = "教程";
            // 
            // MiAbout
            // 
            this.MiAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiSoftUpdate,
            this.MiSoftInfo});
            this.MiAbout.Name = "MiAbout";
            this.MiAbout.Size = new System.Drawing.Size(44, 21);
            this.MiAbout.Text = "关于";
            // 
            // MiSoftUpdate
            // 
            this.MiSoftUpdate.Name = "MiSoftUpdate";
            this.MiSoftUpdate.Size = new System.Drawing.Size(180, 22);
            this.MiSoftUpdate.Text = "软件更新";
            // 
            // MiSoftInfo
            // 
            this.MiSoftInfo.Name = "MiSoftInfo";
            this.MiSoftInfo.Size = new System.Drawing.Size(180, 22);
            this.MiSoftInfo.Text = "软件说明";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 400);
            this.textBox1.TabIndex = 1;
            // 
            // TcMain
            // 
            this.TcMain.Controls.Add(this.TpAccount);
            this.TcMain.Controls.Add(this.TpBasicFunc);
            this.TcMain.Controls.Add(this.TpFight);
            this.TcMain.Controls.Add(this.TpSpecialFunc);
            this.TcMain.Controls.Add(this.TpSoftDeclare);
            this.TcMain.Location = new System.Drawing.Point(311, 28);
            this.TcMain.Name = "TcMain";
            this.TcMain.SelectedIndex = 0;
            this.TcMain.Size = new System.Drawing.Size(351, 400);
            this.TcMain.TabIndex = 2;
            // 
            // TpAccount
            // 
            this.TpAccount.Controls.Add(this.GbUserInfo);
            this.TpAccount.Controls.Add(this.GbAccount);
            this.TpAccount.Location = new System.Drawing.Point(4, 22);
            this.TpAccount.Name = "TpAccount";
            this.TpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.TpAccount.Size = new System.Drawing.Size(343, 374);
            this.TpAccount.TabIndex = 0;
            this.TpAccount.Text = "帐号";
            this.TpAccount.UseVisualStyleBackColor = true;
            // 
            // TpBasicFunc
            // 
            this.TpBasicFunc.Location = new System.Drawing.Point(4, 22);
            this.TpBasicFunc.Name = "TpBasicFunc";
            this.TpBasicFunc.Padding = new System.Windows.Forms.Padding(3);
            this.TpBasicFunc.Size = new System.Drawing.Size(343, 374);
            this.TpBasicFunc.TabIndex = 1;
            this.TpBasicFunc.Text = "基本功能";
            this.TpBasicFunc.UseVisualStyleBackColor = true;
            // 
            // TpFight
            // 
            this.TpFight.Location = new System.Drawing.Point(4, 22);
            this.TpFight.Name = "TpFight";
            this.TpFight.Size = new System.Drawing.Size(343, 374);
            this.TpFight.TabIndex = 2;
            this.TpFight.Text = "战斗";
            this.TpFight.UseVisualStyleBackColor = true;
            // 
            // TpSpecialFunc
            // 
            this.TpSpecialFunc.Location = new System.Drawing.Point(4, 22);
            this.TpSpecialFunc.Name = "TpSpecialFunc";
            this.TpSpecialFunc.Size = new System.Drawing.Size(343, 374);
            this.TpSpecialFunc.TabIndex = 3;
            this.TpSpecialFunc.Text = "特殊功能";
            this.TpSpecialFunc.UseVisualStyleBackColor = true;
            // 
            // TpSoftDeclare
            // 
            this.TpSoftDeclare.Location = new System.Drawing.Point(4, 22);
            this.TpSoftDeclare.Name = "TpSoftDeclare";
            this.TpSoftDeclare.Size = new System.Drawing.Size(343, 374);
            this.TpSoftDeclare.TabIndex = 4;
            this.TpSoftDeclare.Text = "软件声明";
            this.TpSoftDeclare.UseVisualStyleBackColor = true;
            // 
            // GbAccount
            // 
            this.GbAccount.Controls.Add(this.BtnTestSpeed);
            this.GbAccount.Controls.Add(this.BtnLogin);
            this.GbAccount.Controls.Add(this.LlabelBrowse);
            this.GbAccount.Controls.Add(this.CbTargetServer);
            this.GbAccount.Controls.Add(this.TbPassword);
            this.GbAccount.Controls.Add(this.TbAccount);
            this.GbAccount.Controls.Add(this.label3);
            this.GbAccount.Controls.Add(this.label2);
            this.GbAccount.Controls.Add(this.label1);
            this.GbAccount.Controls.Add(this.CbAccount);
            this.GbAccount.Location = new System.Drawing.Point(41, 6);
            this.GbAccount.Name = "GbAccount";
            this.GbAccount.Size = new System.Drawing.Size(241, 182);
            this.GbAccount.TabIndex = 0;
            this.GbAccount.TabStop = false;
            this.GbAccount.Text = "帐号";
            // 
            // GbUserInfo
            // 
            this.GbUserInfo.Controls.Add(this.CbMajorPetSkill);
            this.GbUserInfo.Controls.Add(this.LableGoldCoin);
            this.GbUserInfo.Controls.Add(this.LableCrystal);
            this.GbUserInfo.Controls.Add(this.LableMajorPet);
            this.GbUserInfo.Controls.Add(this.LableUserName);
            this.GbUserInfo.Controls.Add(this.BtnCopyUserInfo);
            this.GbUserInfo.Controls.Add(this.LlabelRefresh);
            this.GbUserInfo.Controls.Add(this.label8);
            this.GbUserInfo.Controls.Add(this.label7);
            this.GbUserInfo.Controls.Add(this.label6);
            this.GbUserInfo.Controls.Add(this.label5);
            this.GbUserInfo.Controls.Add(this.label4);
            this.GbUserInfo.Location = new System.Drawing.Point(41, 196);
            this.GbUserInfo.Name = "GbUserInfo";
            this.GbUserInfo.Size = new System.Drawing.Size(241, 172);
            this.GbUserInfo.TabIndex = 1;
            this.GbUserInfo.TabStop = false;
            this.GbUserInfo.Text = "玩家信息";
            // 
            // CbAccount
            // 
            this.CbAccount.FormattingEnabled = true;
            this.CbAccount.Location = new System.Drawing.Point(15, 24);
            this.CbAccount.Name = "CbAccount";
            this.CbAccount.Size = new System.Drawing.Size(187, 20);
            this.CbAccount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "帐号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "区服：";
            // 
            // TbAccount
            // 
            this.TbAccount.Location = new System.Drawing.Point(60, 61);
            this.TbAccount.Name = "TbAccount";
            this.TbAccount.Size = new System.Drawing.Size(132, 21);
            this.TbAccount.TabIndex = 4;
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(60, 87);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(132, 21);
            this.TbPassword.TabIndex = 5;
            // 
            // CbTargetServer
            // 
            this.CbTargetServer.FormattingEnabled = true;
            this.CbTargetServer.Location = new System.Drawing.Point(60, 115);
            this.CbTargetServer.Name = "CbTargetServer";
            this.CbTargetServer.Size = new System.Drawing.Size(132, 20);
            this.CbTargetServer.TabIndex = 6;
            // 
            // LlabelBrowse
            // 
            this.LlabelBrowse.AutoSize = true;
            this.LlabelBrowse.Location = new System.Drawing.Point(194, 118);
            this.LlabelBrowse.Name = "LlabelBrowse";
            this.LlabelBrowse.Size = new System.Drawing.Size(41, 12);
            this.LlabelBrowse.TabIndex = 7;
            this.LlabelBrowse.TabStop = true;
            this.LlabelBrowse.Text = "浏览器";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(47, 143);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 8;
            this.BtnLogin.Text = "登录";
            this.BtnLogin.UseVisualStyleBackColor = true;
            // 
            // BtnTestSpeed
            // 
            this.BtnTestSpeed.Location = new System.Drawing.Point(128, 143);
            this.BtnTestSpeed.Name = "BtnTestSpeed";
            this.BtnTestSpeed.Size = new System.Drawing.Size(75, 23);
            this.BtnTestSpeed.TabIndex = 9;
            this.BtnTestSpeed.Text = "测试网速";
            this.BtnTestSpeed.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "用户名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "主宠：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "水晶：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "金币：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "使用技能：";
            // 
            // LlabelRefresh
            // 
            this.LlabelRefresh.AutoSize = true;
            this.LlabelRefresh.Location = new System.Drawing.Point(194, 17);
            this.LlabelRefresh.Name = "LlabelRefresh";
            this.LlabelRefresh.Size = new System.Drawing.Size(29, 12);
            this.LlabelRefresh.TabIndex = 15;
            this.LlabelRefresh.TabStop = true;
            this.LlabelRefresh.Text = "刷新";
            // 
            // BtnCopyUserInfo
            // 
            this.BtnCopyUserInfo.Location = new System.Drawing.Point(181, 33);
            this.BtnCopyUserInfo.Name = "BtnCopyUserInfo";
            this.BtnCopyUserInfo.Size = new System.Drawing.Size(50, 20);
            this.BtnCopyUserInfo.TabIndex = 16;
            this.BtnCopyUserInfo.Text = "复制";
            this.BtnCopyUserInfo.UseVisualStyleBackColor = true;
            // 
            // LableUserName
            // 
            this.LableUserName.AutoSize = true;
            this.LableUserName.Location = new System.Drawing.Point(80, 35);
            this.LableUserName.Name = "LableUserName";
            this.LableUserName.Size = new System.Drawing.Size(0, 12);
            this.LableUserName.TabIndex = 17;
            // 
            // LableMajorPet
            // 
            this.LableMajorPet.AutoSize = true;
            this.LableMajorPet.Location = new System.Drawing.Point(68, 59);
            this.LableMajorPet.Name = "LableMajorPet";
            this.LableMajorPet.Size = new System.Drawing.Size(0, 12);
            this.LableMajorPet.TabIndex = 18;
            // 
            // LableCrystal
            // 
            this.LableCrystal.AutoSize = true;
            this.LableCrystal.Location = new System.Drawing.Point(68, 83);
            this.LableCrystal.Name = "LableCrystal";
            this.LableCrystal.Size = new System.Drawing.Size(0, 12);
            this.LableCrystal.TabIndex = 19;
            // 
            // LableGoldCoin
            // 
            this.LableGoldCoin.AutoSize = true;
            this.LableGoldCoin.Location = new System.Drawing.Point(68, 108);
            this.LableGoldCoin.Name = "LableGoldCoin";
            this.LableGoldCoin.Size = new System.Drawing.Size(0, 12);
            this.LableGoldCoin.TabIndex = 20;
            // 
            // LableBottom
            // 
            this.LableBottom.AutoSize = true;
            this.LableBottom.Location = new System.Drawing.Point(12, 433);
            this.LableBottom.Name = "LableBottom";
            this.LableBottom.Size = new System.Drawing.Size(23, 12);
            this.LableBottom.TabIndex = 3;
            this.LableBottom.Text = "无!";
            // 
            // CbMajorPetSkill
            // 
            this.CbMajorPetSkill.FormattingEnabled = true;
            this.CbMajorPetSkill.Location = new System.Drawing.Point(94, 130);
            this.CbMajorPetSkill.Name = "CbMajorPetSkill";
            this.CbMajorPetSkill.Size = new System.Drawing.Size(98, 20);
            this.CbMajorPetSkill.TabIndex = 21;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 454);
            this.Controls.Add(this.LableBottom);
            this.Controls.Add(this.TcMain);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MenuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStripMain;
            this.Name = "MainWindow";
            this.Text = "超哥辅助";
            this.MenuStripMain.ResumeLayout(false);
            this.MenuStripMain.PerformLayout();
            this.TcMain.ResumeLayout(false);
            this.TpAccount.ResumeLayout(false);
            this.GbAccount.ResumeLayout(false);
            this.GbAccount.PerformLayout();
            this.GbUserInfo.ResumeLayout(false);
            this.GbUserInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem MiBrowse;
        private System.Windows.Forms.ToolStripMenuItem MiRelogin;
        private System.Windows.Forms.ToolStripMenuItem MiFastFunc;
        private System.Windows.Forms.ToolStripMenuItem MiUndress;
        private System.Windows.Forms.ToolStripMenuItem MiDress;
        private System.Windows.Forms.ToolStripMenuItem MiAccountManage;
        private System.Windows.Forms.ToolStripMenuItem MiSettings;
        private System.Windows.Forms.ToolStripMenuItem MiCourse;
        private System.Windows.Forms.ToolStripMenuItem MiAbout;
        private System.Windows.Forms.ToolStripMenuItem MiSoftUpdate;
        private System.Windows.Forms.ToolStripMenuItem MiSoftInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl TcMain;
        private System.Windows.Forms.TabPage TpAccount;
        private System.Windows.Forms.TabPage TpBasicFunc;
        private System.Windows.Forms.TabPage TpFight;
        private System.Windows.Forms.TabPage TpSpecialFunc;
        private System.Windows.Forms.TabPage TpSoftDeclare;
        private System.Windows.Forms.GroupBox GbAccount;
        private System.Windows.Forms.GroupBox GbUserInfo;
        private System.Windows.Forms.ComboBox CbAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TbAccount;
        private System.Windows.Forms.ComboBox CbTargetServer;
        private System.Windows.Forms.Button BtnTestSpeed;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.LinkLabel LlabelBrowse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel LlabelRefresh;
        private System.Windows.Forms.Button BtnCopyUserInfo;
        private System.Windows.Forms.Label LableGoldCoin;
        private System.Windows.Forms.Label LableCrystal;
        private System.Windows.Forms.Label LableMajorPet;
        private System.Windows.Forms.Label LableUserName;
        private System.Windows.Forms.Label LableBottom;
        private System.Windows.Forms.ComboBox CbMajorPetSkill;
    }
}


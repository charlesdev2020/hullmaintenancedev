namespace HullMaintenanceDev
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ui_ribbon = new HullMaintenanceDev.AdvancedRibbonControl();
            this.ui_statusMessage = new DevExpress.XtraBars.BarStaticItem();
            this.ui_statusProgressBar = new DevExpress.XtraBars.BarEditItem();
            this.ui_progressBar = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.ui_barSetting = new DevExpress.XtraBars.BarButtonItem();
            this.ui_popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ui_barUser = new DevExpress.XtraBars.BarButtonItem();
            this.ui_barLogin = new DevExpress.XtraBars.BarButtonItem();
            this.ui_barOption = new DevExpress.XtraBars.BarButtonItem();
            this.ui_barConfiguration = new DevExpress.XtraBars.BarButtonItem();
            this.ui_barColumnSetting = new DevExpress.XtraBars.BarButtonItem();
            this.ui_barStyle = new DevExpress.XtraBars.BarSubItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ui_ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ui_panelMain = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ui_ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_progressBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_panelMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ui_ribbon
            // 
            this.ui_ribbon.ApplicationButtonText = null;
            this.ui_ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Teal;
            this.ui_ribbon.ExpandCollapseItem.Id = 0;
            this.ui_ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ui_ribbon.ExpandCollapseItem,
            this.ui_statusMessage,
            this.ui_statusProgressBar,
            this.ui_barSetting,
            this.ui_barUser,
            this.ui_barLogin,
            this.ui_barOption,
            this.ui_barConfiguration,
            this.ui_barColumnSetting,
            this.ui_barStyle});
            this.ui_ribbon.Location = new System.Drawing.Point(0, 0);
            this.ui_ribbon.MaxItemId = 14;
            this.ui_ribbon.Name = "ui_ribbon";
            this.ui_ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ui_ribbon.QuickToolbarItemLinks.Add(this.ui_barSetting);
            this.ui_ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ui_progressBar});
            this.ui_ribbon.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Center;
            this.ui_ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ui_ribbon.ShowToolbarCustomizeItem = false;
            this.ui_ribbon.Size = new System.Drawing.Size(1642, 34);
            this.ui_ribbon.StatusBar = this.ui_ribbonStatusBar;
            this.ui_ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // ui_statusMessage
            // 
            this.ui_statusMessage.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.ui_statusMessage.Id = 2;
            this.ui_statusMessage.Name = "ui_statusMessage";
            this.ui_statusMessage.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ui_statusProgressBar
            // 
            this.ui_statusProgressBar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.ui_statusProgressBar.Edit = this.ui_progressBar;
            this.ui_statusProgressBar.EditWidth = 100;
            this.ui_statusProgressBar.Id = 3;
            this.ui_statusProgressBar.Name = "ui_statusProgressBar";
            // 
            // ui_progressBar
            // 
            this.ui_progressBar.Name = "ui_progressBar";
            this.ui_progressBar.ShowTitle = true;
            // 
            // ui_barSetting
            // 
            this.ui_barSetting.ActAsDropDown = true;
            this.ui_barSetting.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.ui_barSetting.Caption = "Setting";
            this.ui_barSetting.DropDownControl = this.ui_popupMenu;
            this.ui_barSetting.Hint = "Setting";
            this.ui_barSetting.Id = 4;
            this.ui_barSetting.Name = "ui_barSetting";
            // 
            // ui_popupMenu
            // 
            this.ui_popupMenu.ItemLinks.Add(this.ui_barUser);
            this.ui_popupMenu.ItemLinks.Add(this.ui_barLogin, true);
            this.ui_popupMenu.ItemLinks.Add(this.ui_barOption, true);
            this.ui_popupMenu.ItemLinks.Add(this.ui_barConfiguration);
            this.ui_popupMenu.ItemLinks.Add(this.ui_barColumnSetting, true);
            this.ui_popupMenu.ItemLinks.Add(this.ui_barStyle, true);
            this.ui_popupMenu.Name = "ui_popupMenu";
            this.ui_popupMenu.Ribbon = this.ui_ribbon;
            // 
            // ui_barUser
            // 
            this.ui_barUser.Caption = "User";
            this.ui_barUser.Hint = "User";
            this.ui_barUser.Id = 12;
            this.ui_barUser.Name = "ui_barUser";
            // 
            // ui_barLogin
            // 
            this.ui_barLogin.Caption = "Login";
            this.ui_barLogin.Hint = "Login";
            this.ui_barLogin.Id = 11;
            this.ui_barLogin.Name = "ui_barLogin";
            // 
            // ui_barOption
            // 
            this.ui_barOption.Caption = "Option";
            this.ui_barOption.Hint = "Option";
            this.ui_barOption.Id = 7;
            this.ui_barOption.Name = "ui_barOption";
            // 
            // ui_barConfiguration
            // 
            this.ui_barConfiguration.Caption = "Configuration";
            this.ui_barConfiguration.Hint = "Configuration";
            this.ui_barConfiguration.Id = 8;
            this.ui_barConfiguration.Name = "ui_barConfiguration";
            // 
            // ui_barColumnSetting
            // 
            this.ui_barColumnSetting.Caption = "Column Setting";
            this.ui_barColumnSetting.Hint = "Column Setting";
            this.ui_barColumnSetting.Id = 9;
            this.ui_barColumnSetting.Name = "ui_barColumnSetting";
            // 
            // ui_barStyle
            // 
            this.ui_barStyle.Caption = "Style";
            this.ui_barStyle.Hint = "Style";
            this.ui_barStyle.Id = 13;
            this.ui_barStyle.Name = "ui_barStyle";
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "ribbonPage";
            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.Text = "ribbonPageGroup";
            // 
            // ui_ribbonStatusBar
            // 
            this.ui_ribbonStatusBar.ItemLinks.Add(this.ui_statusMessage, true);
            this.ui_ribbonStatusBar.ItemLinks.Add(this.ui_statusProgressBar);
            this.ui_ribbonStatusBar.Location = new System.Drawing.Point(0, 951);
            this.ui_ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_ribbonStatusBar.Name = "ui_ribbonStatusBar";
            this.ui_ribbonStatusBar.Ribbon = this.ui_ribbon;
            this.ui_ribbonStatusBar.Size = new System.Drawing.Size(1642, 40);
            // 
            // ui_panelMain
            // 
            this.ui_panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_panelMain.Location = new System.Drawing.Point(0, 41);
            this.ui_panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.ui_panelMain.Name = "ui_panelMain";
            this.ui_panelMain.Size = new System.Drawing.Size(1642, 903);
            this.ui_panelMain.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 991);
            this.Controls.Add(this.ui_panelMain);
            this.Controls.Add(this.ui_ribbonStatusBar);
            this.Controls.Add(this.ui_ribbon);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Ribbon = this.ui_ribbon;
            this.StatusBar = this.ui_ribbonStatusBar;
            this.Text = "Hull Maintenance";
            this.Load += new System.EventHandler(this.OnLoadMainForm);
            ((System.ComponentModel.ISupportInitialize)(this.ui_ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_progressBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_panelMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private DevExpress.LookAndFeel.UserLookAndFeel ui_defaultLookAndFeel;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ui_ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem ui_statusMessage;
        private DevExpress.XtraBars.BarEditItem ui_statusProgressBar;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar ui_progressBar;
        private DevExpress.XtraEditors.PanelControl ui_panelMain;
        private DevExpress.XtraBars.BarButtonItem ui_barSetting;
        private AdvancedRibbonControl ui_ribbon;
        private DevExpress.XtraBars.PopupMenu ui_popupMenu;
        private DevExpress.XtraBars.BarButtonItem ui_barOption;
        private DevExpress.XtraBars.BarButtonItem ui_barLogin;
        private DevExpress.XtraBars.BarButtonItem ui_barConfiguration;
        private DevExpress.XtraBars.BarButtonItem ui_barColumnSetting;
        private DevExpress.XtraBars.BarButtonItem ui_barUser;
        private DevExpress.XtraBars.BarSubItem ui_barStyle;
    }
}


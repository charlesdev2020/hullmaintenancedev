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
            this.ui_ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ui_ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ui_ribbon
            // 
            this.ui_ribbon.ExpandCollapseItem.Id = 0;
            this.ui_ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ui_ribbon.ExpandCollapseItem});
            this.ui_ribbon.Location = new System.Drawing.Point(0, 0);
            this.ui_ribbon.MaxItemId = 1;
            this.ui_ribbon.Name = "ui_ribbon";
            this.ui_ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ui_ribbon.Size = new System.Drawing.Size(800, 147);
            // 
            // ribbonPage1
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "ribbonPage";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.Text = "ribbonPageGroup";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.ui_ribbon);
            this.Name = "MainForm";
            this.Ribbon = this.ui_ribbon;
            this.Text = "Hull Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.ui_ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ui_ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
    }
}


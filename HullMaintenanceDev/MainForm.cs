using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using HullMaintenanceDev.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HullMaintenanceDev
{
    public partial class MainForm : RibbonForm
    {
        #region 멤버
        private static MainForm m_MainApp = null; // 메인 App
        #endregion

        #region 속성
        public static MainForm MainApp
        {
            get { return m_MainApp; }
            set { m_MainApp = value; }
        } // 메인 App

        public int ProgressMaximum
        {
            get { return ui_progressBar.Maximum; }
            set { ui_progressBar.Maximum = value; }
        } // Progress 최대값
        public int ProgressMinimum
        {
            get { return ui_progressBar.Minimum; }
            set
            {
                ui_progressBar.Minimum = value;
                ui_statusProgressBar.EditValue = value;
            }
        } // Progress 최소값
        public int ProgressStep
        {
            get { return ui_progressBar.Step; }
            set { ui_progressBar.Step = value; }
        } // Progress Step

        public WorkSpace WorkSpaceControl { get; set; }
        #endregion

        public MainForm()
        {
            InitializeComponent();

            m_MainApp = this;
        }

        /// <summary>
        /// Progressbar 활성화
        /// </summary>
        public void StartProgressbar()
        {
            ui_statusProgressBar.Visibility = BarItemVisibility.Always;
        }

        /// <summary>
        /// Progressbar 활성화
        /// </summary>
        /// <param name="maximum">최대값</param>
        /// <param name="minimum">최소값</param>
        /// <param name="step">Step</param>
        public void StartProgressbar(int maximum, int minimum, int step)
        {
            this.ProgressMaximum = maximum;
            this.ProgressMinimum = minimum;
            this.ProgressStep = step;

            StartProgressbar();
        }

        /// <summary>
        /// Progressbar 비활성화
        /// </summary>
        public void EndProgressbar()
        {
            ui_statusProgressBar.Visibility = BarItemVisibility.Never;
        }

        /// <summary>
        /// Progress Step 진행
        /// </summary>
        public void PerformStep()
        {
            int step = Convert.ToInt32(ui_statusProgressBar.EditValue);

            if (step < this.ProgressMaximum)
            {
                ui_statusProgressBar.EditValue = step + this.ProgressStep;
                ui_statusProgressBar.Refresh();
            }
        }

        private void OnLoadMainForm(object sender, EventArgs e)
        {
            EndProgressbar();

            this.WorkSpaceControl = new WorkSpace();

            SkinHelper.InitSkinPopupMenu(ui_barStyle);
        }

        private void OnShownMainForm(object sender, EventArgs e)
        {
            if (ui_panelMain.Controls.Contains(this.WorkSpaceControl) == false)
            {
                this.WorkSpaceControl.Dock = DockStyle.Fill;
                ui_panelMain.Controls.Add(this.WorkSpaceControl);
                this.WorkSpaceControl.BringToFront();
            }
        }
    }

    [System.ComponentModel.DesignerCategory("")]
    public class AdvancedRibbonControl : RibbonControl
    {
        public AdvancedRibbonControl()
        {
            Toolbar.ShowCustomizeItem = false;
        }

        protected override RibbonViewInfo CreateViewInfo()
        {
            return new AdvancedRibbonViewInfo(this);
        }
    }

    public class AdvancedRibbonViewInfo : RibbonViewInfo
    {
        public AdvancedRibbonViewInfo(RibbonControl ribbon)
            : base(ribbon)
        {

        }

        protected override int CalcMinHeight()
        {
            int captionHeight = Caption.CalcCaptionHeight();

            if (Form != null)
            {
                if (Form.IsMdiChild && FormMaximized)
                {
                    captionHeight -= 10;
                }
            }
            return captionHeight;
        }
    }
}

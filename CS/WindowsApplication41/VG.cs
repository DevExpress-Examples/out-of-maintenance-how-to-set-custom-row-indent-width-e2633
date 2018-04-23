using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.ViewInfo;

namespace WindowsApplication12
{
    public class CVGridControl : VGridControl
    {
        public CVGridControl()
            : base()
        {
            _indentWidth = -1;
        }

        protected override BaseViewInfo CreateViewInfo(bool isPrinting)
        {
            switch (LayoutStyle)
            {
                case LayoutViewStyle.BandsView:
                    return new CBandsViewInfo(this, isPrinting);
                case LayoutViewStyle.SingleRecordView:
                    return new CSingleRecordViewInfo(this, isPrinting);
                case LayoutViewStyle.MultiRecordView:
                    return new CMultiRecordViewInfo(this, isPrinting);
            }
            return null;
        }

        private int _indentWidth;
        [DefaultValue(-1)]
        public int IndentWidth
        {
            get { return _indentWidth; }
            set { _indentWidth = value; this.LayoutChanged(); }
        }

    }

    public class CSingleRecordViewInfo : SingleRecordViewInfo
    {
        public CSingleRecordViewInfo(VGridControlBase grid, bool isPrinting) : base(grid, isPrinting) { }
        protected override int GetRowIndentWidth()
        {
            if (this.Grid is CVGridControl)
            {
                CVGridControl grid = (CVGridControl)this.Grid;
                if (grid.IndentWidth >= 0) return grid.IndentWidth;
            }
            return base.GetRowIndentWidth();
        }
    }
    public class CMultiRecordViewInfo : MultiRecordViewInfo
    {
        public CMultiRecordViewInfo(VGridControlBase grid, bool isPrinting) : base(grid, isPrinting ) { }
        protected override int GetRowIndentWidth()
        {
            if (this.Grid is CVGridControl)
            {
                CVGridControl grid = (CVGridControl)this.Grid;
                if (grid.IndentWidth >= 0) return grid.IndentWidth;
            }
            return base.GetRowIndentWidth();
        }
    }
    public class CBandsViewInfo : BandsViewInfo
    {
        public CBandsViewInfo(VGridControlBase grid, bool isPrinting) : base(grid, isPrinting) { }
        protected override int GetRowIndentWidth()
        {
            if (this.Grid is CVGridControl)
            {
                CVGridControl grid = (CVGridControl)this.Grid;
                if (grid.IndentWidth >= 0) return grid.IndentWidth;
            }
            return base.GetRowIndentWidth();
        }
    }
}

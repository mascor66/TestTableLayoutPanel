using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UserControls
{
    [Serializable]
    public partial class SplitTableLayoutPanel: TableLayoutPanel
    {
        private bool m_CanSplitRows = false;
        public bool CanSplitRows {
            get {
                return m_CanSplitRows;
            }
            set {
                m_CanSplitRows = value;
                if (true == m_CanSplitRows)
                {
                    normalizeRowStyles();
                }
            }
        }
        private bool m_CanSplitCols = false;
        public bool CanSplitCols
        {
            get{
                return m_CanSplitCols;
            }
            set
            {
                m_CanSplitCols = value;
                if (true == m_CanSplitCols)
                {
                    normalizeColStyles();
                }
            }
        }
        public int SplitterSize { get; set; }

        private List<System.Drawing.PointF> m_BoundRows = new List<System.Drawing.PointF>();
        public List<System.Drawing.PointF> BoundRows
        {
            get { return m_BoundRows; }
        }

        private List<System.Drawing.PointF> m_BoundCols = new List<System.Drawing.PointF>();
        public List<System.Drawing.PointF> BoundCols
        {
            get { return m_BoundCols; }
        }

        int sizingRow = -1;
        int currentRow = -1;
        Point mdown = Point.Empty;
        int oldHeight = -1;
        bool isNormalRow = false;
        List<RectangleF> tlpRows = new List<RectangleF>();
        int[] rowHeights = new int[0];

        int sizingCol = -1;
        int currentCol = -1;
        int oldWidth = -1;
        bool isNormalCol = false;
        List<RectangleF> tlpCols = new List<RectangleF>();
        int[] colWidths = new int[0];

        public SplitTableLayoutPanel(): base()
        {
            //InitializeComponent(); //IMC error
            this.MouseDown += SplitTablePanel_MouseDown;
            this.MouseMove += SplitTablePanel_MouseMove;
            this.MouseUp += SplitTablePanel_MouseUp;
            this.MouseLeave += SplitTablePanel_MouseLeave;
            this.Resize += SplitTablePanel_Resize;
            SplitterSize = 6;
        }

        void SplitTablePanel_Resize(object sender, EventArgs e)
        {
            getRowMSRectangles(SplitterSize);
            getColMSRectangles(SplitterSize);
        }

        void SplitTablePanel_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        void SplitTablePanel_MouseUp(object sender, MouseEventArgs e)
        {
            getRowMSRectangles(SplitterSize);
            getColMSRectangles(SplitterSize);
        }

        void SplitTablePanel_MouseMove(object sender, MouseEventArgs e)
        {
            bool r = rowIsMove(sender, e);
            bool c = colIsMove(sender, e);

            if (r && !c)
                Cursor = Cursors.SizeNS;
            else if (!r && c)
                Cursor = Cursors.SizeWE;
            else if (r && c)
                Cursor = Cursors.SizeAll;
            else
                Cursor = Cursors.Default;
        }

        bool rowIsMove(object sender, MouseEventArgs e)
        {
            if (!CanSplitRows)
            {
                return false;
            }
            bool isMove = false;
            if (!isNormalRow) {
                normalizeRowStyles();
            }
            if (tlpRows.Count <= 0) {
                getRowMSRectangles(SplitterSize);
            }
            if (rowHeights.Length <= 0) {
                rowHeights = GetRowHeights();
            }

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if ((sizingRow < 0) || (sizingRow >= rowHeights.Length)) return false;
                int newHeight = oldHeight + e.Y - mdown.Y;
                sizeRow(sizingRow, newHeight);
                isMove = true;
            }
            else
            {
                currentRow = -1;
                for (int i = 0; i < tlpRows.Count; i++)
                    if (tlpRows[i].Contains(e.Location))
                    {
                        currentRow = i;
                        isMove = true;
                        break;
                    }
            }
            return isMove;
        }

        bool colIsMove(object sender, MouseEventArgs e)
        {
            if (!CanSplitCols)
            {
                return false;
            }
            bool isMove = false;
            if (!isNormalCol) normalizeColStyles();
            if (tlpCols.Count <= 0) getColMSRectangles(SplitterSize);
            if (colWidths.Length <= 0) colWidths = GetColumnWidths();

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if ((sizingCol < 0) || (sizingCol >= colWidths.Length )) return false;
                int newWidth = oldWidth + e.X - mdown.X;
                sizeCol(sizingCol, newWidth);
                isMove = true;
            }
            else
            {
                currentCol = -1;
                for (int i = 0; i < tlpCols.Count; i++)
                    if (tlpCols[i].Contains(e.Location))
                    {
                        currentCol = i;
                        isMove = true;
                        break;
                    }
            }
            return isMove;
        }

        void SplitTablePanel_MouseDown(object sender, MouseEventArgs e)
        {
            mdown = Point.Empty;
            rowDown();
            colDown();
            mdown = e.Location;
        }

        void rowDown()
        {
            sizingRow = -1;
            if ((currentRow < 0) || (sizingRow >= rowHeights.Length)) return;
            if (CanSplitRows)
            {
                sizingRow = currentRow;
            }
            oldHeight = rowHeights[sizingRow];
        }

        void colDown()
        {
            sizingCol = -1;
            if ((currentCol < 0) || (sizingCol >= colWidths.Length)) return;
            if (CanSplitCols)
            {
                sizingCol = currentCol;
            }
            oldWidth = colWidths[sizingCol];
        }

        void getRowMSRectangles(float size)
        {   // get a list of mouse sensitive rectangles
            float sz = size / 2f;
            float y = 0f;
            int w = ClientSize.Width;
            int[] rw = GetRowHeights();

            tlpRows.Clear();
            for (int i = 0; i < rw.Length - 1; i++)
            {
                y += rw[i];
                tlpRows.Add(new RectangleF(0, y - sz, w, size));
            }

        }

        void getColMSRectangles(float size)
        {   // get a list of mouse sensitive rectangles
            float sz = size / 2f;
            float x = 0f;
            int h = ClientSize.Height;
            int[] rw = GetColumnWidths();

            tlpCols.Clear();
            for (int i = 0; i < rw.Length - 1; i++)
            {
                x += rw[i];
                tlpCols.Add(new RectangleF(x - sz, 0, size, h));
            }

        }

        void sizeRow(int row, int newHeight)
        {   // change the height of one row
            if (newHeight == 0) return;
            if (sizingRow < 0) return;
            //check if new dimension is in bound begin
            if (m_BoundRows.Count > 0)
            {
                if (row >= m_BoundRows.Count) return;
                if ((-1 == m_BoundRows[row].X) || (-1 == m_BoundRows[row].Y)) return;
                if ((newHeight < m_BoundRows[row].X) || (newHeight > m_BoundRows[row].Y))
                    return;
            }
            //check if new dimension is in bound end
            SuspendLayout();
            rowHeights = GetRowHeights();
            if (sizingRow >= rowHeights.Length) return;

            if (newHeight > 0)
                RowStyles[sizingRow] = new RowStyle(SizeType.Absolute, newHeight);
            ResumeLayout();
            rowHeights = GetRowHeights();
            getRowMSRectangles(SplitterSize);
        }

        void sizeCol(int col, int newWidth)
        {   // change the height of one row
            if (newWidth == 0) return;
            if (sizingCol < 0) return;
            //check if new dimension is in bound begin
            if (m_BoundCols.Count > 0)
            {
                if (col >= m_BoundCols.Count) return;
                if ((-1 == m_BoundCols[col].X) || (-1 == m_BoundCols[col].Y)) return;
                if ((newWidth < m_BoundCols[col].X) || (newWidth > m_BoundCols[col].Y))
                    return;
            }
            //check if new dimension is in bound end
            SuspendLayout();
            colWidths = GetColumnWidths();
            if (sizingCol >= colWidths.Length) return;

            if (newWidth > 0)
                ColumnStyles[sizingCol] = new ColumnStyle(SizeType.Absolute, newWidth);
            ResumeLayout();
            colWidths = GetColumnWidths();
            getColMSRectangles(SplitterSize);
        }

        void normalizeRowStyles()
        {   // set all rows to absolute and the last one to percent=100!
            rowHeights = GetRowHeights();
            if (rowHeights.Length <= 0)
            {
                isNormalRow = true;
                return;
            }
            RowStyles.Clear();
            for (int i = 0; i < RowCount - 1; i++)
            {
                RowStyle cs = new RowStyle(SizeType.Absolute, rowHeights[i]);
                RowStyles.Add(cs);
            }
            RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            isNormalRow = true;
        }

        void normalizeColStyles()
        {   // set all rows to absolute and the last one to percent=100!
            colWidths = GetColumnWidths();
            if (colWidths.Length <= 0)
            {
                isNormalCol = true;
                return;
            }
            ColumnStyles.Clear();
            for (int i = 0; i < ColumnCount - 1; i++)
            {
                ColumnStyle cs = new ColumnStyle(SizeType.Absolute, colWidths[i]);
                ColumnStyles.Add(cs);
            }
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            isNormalCol = true;
        }
    }
}

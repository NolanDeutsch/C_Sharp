using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CMPE2300NolanDeutschICA07
{
    public partial class frmMain : Form
    {
        private delegate void delVoidInt(int i);
        private delegate int delIntVoid();
        
        Thread show;
        Thread sum;
        Thread remove;
        List<Block> blocksList;
        public frmMain()
        {
            InitializeComponent();
            blocksList = new List<Block>();
        }
        private void frmMain_Shown(object sender, EventArgs e)
        {
            Thread show = new Thread(new ThreadStart(ShowBlocks));
            show.IsBackground = true;
            show.Start();

            Thread sum = new Thread(new ParameterizedThreadStart(SumBlocks));
            sum.IsBackground = true;
            sum.Start(100);

            Thread remove = new Thread(new ThreadStart(RemoveBlocks));
            remove.IsBackground = true;
            remove.Start();

        }

        public void ShowBlocks()
        {
            int xLoc = 0;
            int yLoc = 0;
            do
            {
                xLoc = 0;
                yLoc = 0;
                if (blocksList.Count > 0)
                    lock (blocksList)
                    {
                        Block.Canvas.Clear();
                        foreach (Block element in blocksList)
                        {
                            if (xLoc + element.Width < Block.Canvas.ScaledWidth)
                            {
                                element.ShowBlock(new Point(xLoc, yLoc));
                                xLoc += element.Width;
                            }
                            else
                            {
                                xLoc = 0;
                                yLoc += Block.Height;
                                element.ShowBlock(new Point(xLoc, yLoc));
                            }
                        }
                        Block.Canvas.Render();
                    }
                Thread.Sleep(20);
            } while (true);
        }

        public void SumBlocks(object sleep)
        {
            int s = (int)sleep;
            int blockWidths = 0;
            do
            {
                if (blocksList.Count > 0)
                    lock (blocksList)
                    {
                        blockWidths = 0;
                        foreach (Block element in blocksList)
                        {
                            blockWidths += element.Width;
                        }
                    }
                try
                {
                    Invoke(new delVoidInt(TextUpdate), blockWidths);
                }
                catch { }
                Thread.Sleep(s);
            } while (true);
        }
        public void TextUpdate(int width)
        {
            this.Text = width.ToString();
        }
        
        public void RemoveBlocks()
        {
            int width;
            Block temp;
            do
            {
                try
                {
                    width = (int)Invoke(new delIntVoid(tbWidthValue));
                }
                catch
                {
                    width = 0;
                }
                temp = null;
                if(blocksList.Count > 0)
                    lock (blocksList)
                    {
                        Block.Canvas.Clear();
                        for (int index = 0; index < blocksList.Count; index++)
                            if (blocksList[index].Width < width)
                            {
                                temp = blocksList[index];
                                index = blocksList.Count + 1;
                            }
                        blocksList.Remove(temp);
                    }
                Thread.Sleep(1000);
            } while (true);
        }

        public int tbWidthValue()
        {
            return tbMaxBlock.Value;
        }

        /// -----------------------------------------------------------------------
        ///         Form Click Events
        /// -----------------------------------------------------------------------
        #region buttons
        private void btnPop_Click(object sender, EventArgs e)
        {
            blocksList.Clear();
            int widths = 0;
            Block temp;

            while(widths < (Block.Canvas.ScaledWidth * Block.Canvas.ScaledHeight * 0.8)/ Block.Height)
            {
                temp = new Block();
                if(!blocksList.Contains(temp))
                {
                    blocksList.Add(temp);
                    widths += temp.Width;
                }
            }
            TBMinMax();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            blocksList.Sort();
        }

        private void btnWidth_Click(object sender, EventArgs e)
        {
            blocksList.Sort(Block.CompareWidth);
        }

        private void btnWD_Click(object sender, EventArgs e)
        {
            blocksList.Sort((left, right) => -1 * Block.CompareWidth(left, right));
        }

        private void btnWC_Click(object sender, EventArgs e)
        {
            blocksList.Sort(Block.CompareWidthCol);
        }

        private void btnBright_Click(object sender, EventArgs e)
        {
            int temp = 0;
            temp = blocksList.RemoveAll(Block.Brightness);
            this.Text = temp.ToString() + " blocks were removed.";
            TBMinMax();
        }

        private void btnLonger_Click(object sender, EventArgs e)
        {
            int temp = 0;
            temp = blocksList.RemoveAll(obj => obj == null ? false : obj.Width > tbMain.Value);
            this.Text = temp.ToString() + " blocks were removed.";
            TBMinMax();
        }

        private void tbMain_Scroll(object sender, EventArgs e)
        {
            btnLonger.Text = "Longer than " + tbMain.Value;
        }
        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            blocksList.ForEach(obj => obj.HighLight = false);
            blocksList.FindAll(obj => (Math.Abs(e.X - obj.Width) <= 10)).ForEach(x => x.HighLight = true);
        }
        public void TBMinMax()
        {
            tbMain.Minimum = blocksList.Min(obj => obj.Width);
            tbMain.Maximum = blocksList.Max(obj => obj.Width);
            tbMain.Value = (tbMain.Maximum - tbMain.Minimum) / 2 + tbMain.Minimum;
            btnLonger.Text = "Longer than " + tbMain.Value;
        }
        #endregion
    }
}

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
using GDIDrawer;

namespace CMPE2300NolanDeutschICA18
{
    public partial class Form1 : Form
    {
        private delegate void delVoidPoint(Point p);
        private delegate void delVoidPointColor(Point p, Color c);
        private delegate int delIntVoid();
        List<Thread> threads;
        CDrawer canvas;
        bool scaleChange;

        public Form1()
        {
            InitializeComponent();
            threads = new List<Thread>();
            canvas = new CDrawer();
            canvas.ContinuousUpdate = false;
            canvas.BBColour = Color.Black;
            scaleChange = false;
        }

        private void Wanderer(Object p)
        {

            ThreadSafeRandom gen = new ThreadSafeRandom();
            Point location = (Point)p;
            Point temp = new Point(1, 1);
            Color c = RandColor.GetColor();
            int limit = (int)Invoke(new delIntVoid(passStep)); 
            for (int i = 0; i < limit; i++)
            {
                do
                {
                    temp = new Point(gen.Next(-1, 2), gen.Next(-1, 2));
                } while (!(location.X / canvas.Scale + temp.X >= 0 && location.X / canvas.Scale + temp.X < canvas.ScaledWidth
                && location.Y / canvas.Scale + temp.Y >= 0 && location.Y / canvas.Scale + temp.Y < canvas.ScaledHeight));

                location.X += temp.X;
                location.Y += temp.Y;

                try
                {
                    Invoke(new delVoidPointColor(SetPixel), location, c);
                }
                catch{ }
                Thread.Sleep(1);
            }
        }

        public void SetPixel(Point p, Color c)
        {
            canvas.SetBBScaledPixel(p.X / canvas.Scale, p.Y / canvas.Scale, c);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Point p = new Point();
            if(canvas.GetLastMouseLeftClick(out p) && !scaleChange)
            {
                Thread t = new Thread(new ParameterizedThreadStart(Wanderer));
                t.IsBackground = true;
                t.Start(p);
                threads.Add(t);
            }
            threads.RemoveAll(x => !x.IsAlive);
            if (threads.Count == 0)
                scaleChange = false;
            canvas.Render();
        }

        private void tbScale_Scroll(object sender, EventArgs e)
        {
            canvas.Scale = tbScale.Value;
            lblScale.Text = tbScale.Value.ToString();
            scaleChange = true;
        }
        private int passStep()
        {
            return tbNumSteps.Value;
        }
        private void tbNumSteps_Scroll(object sender, EventArgs e)
        {
            lblNumSteps.Text = tbNumSteps.Value.ToString();
        }

       
    }
}

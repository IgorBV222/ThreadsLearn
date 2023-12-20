using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadsLearn
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ChildThread = new Thread(AddProgress);
            ChildThread.IsBackground = true;
            ChildThread.Start();
        }
        public Thread ChildThread;
        public void  AddProgress()
        {
            
            for (int i = 0; i < 100 ; i++) 
            {
                for(int j = 0; j < 400000000 ; j++) { }

                //lock (this)
                //{
                    Invoke((MethodInvoker)delegate
                    {
                        pgb.Value = i;
                        lblPrc.Text = i.ToString();
                    }
                        );
                //}
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChildThread.Abort();
        }

        [Obsolete]
        public void Suspend(string name)
        { 
            if (name == this.Text) { ChildThread.Suspend(); }
        
        }
        [Obsolete]
        public void Resume(string name)
        {
            if (name == this.Text) 
            {
                var flag = !((ChildThread.ThreadState == ThreadState.Running)
                    || (ChildThread.ThreadState == ThreadState.Background));
                if ( flag) ChildThread.Resume(); 
            }

        }
    }
}

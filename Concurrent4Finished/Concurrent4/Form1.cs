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

namespace Concurrent4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            makebuffer();
        }

        /// <summary>
        /// Variabler, for the factories, the threads that will run the factory methods and a santa thread and a buffer
        /// </summary>
        ToyFactory Factory1;
        ToyFactory Factory2;

        Santa santa;

        Thread fac1;
        Thread fac2;
        Thread santaThread;
        Buffer b;
        
        /// <summary>
        /// Method to initilize the buffer with parameter pBar which is the progress bar
        /// </summary>
        private void makebuffer()
        {
           b = new Buffer(pBar); 
        }
        
        /// <summary>
        /// Method to create object santa object and start a new thread with santas mehtod addtomyslay
        /// </summary>
        private void makeSanta()
        {
            santa = new Santa(b, listBox1, lblFull);
            santaThread = new Thread(new ThreadStart(santa.addToMySled));
            santaThread.Start();
            button1.Enabled = false;
            
        }

        /// <summary>
        /// Method to start the factory1 on buttonclick, create object of toyfactory and initialize thread with making toys method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartFac1_Click(object sender, EventArgs e)
        {
            Factory1 = new ToyFactory(b);
            fac1 = new Thread(new ThreadStart(Factory1.startMakingToys));
            fac1.Start();
            btnStartFac1.Enabled = false;
        }

        /// <summary>
        ///Method to start the factory2 on buttonclick, create object of toyfactory and initialize thread with making toys method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartFac2_Click(object sender, EventArgs e)
        {
            Factory2 = new ToyFactory(b);
            fac2 = new Thread(new ThreadStart(Factory2.startMakingToys));
            fac2.Start();
            btnStartFac2.Enabled = false;
        }

        /// <summary>
        /// Call makeSanta method on buttonClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            makeSanta();
        }

    }
}

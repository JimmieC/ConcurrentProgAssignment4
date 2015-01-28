using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Concurrent4
{
    /// <summary>
    /// Class buffern which is used by santa and toy factory and main
    /// </summary>
    class Buffer
    {
        /// <summary>
        /// Variabler, en queue med toys, progressbar och delegate
        /// </summary>
        private Queue<Toy> buffer;
        ProgressBar pbar;

        private delegate void DisplayDelagate(string s);

        /// <summary>
        /// Constructor initilizes the queue and pbar
        /// </summary>
        /// <param name="pbar"></param>
        public Buffer(ProgressBar pbar)
        {
            buffer = new Queue<Toy>();
            this.pbar = pbar;

        }
        /// <summary>
        /// Object myLock for the monitor
        /// </summary>
        object mylock = new object();

        /// <summary>
        /// Method to add a toy to the buffer queue, parameter is a toy sent from toyfactory, update the progresss bar
        /// </summary>
        /// <param name="aToy">A toy</param>
        /// <returns> returns true if succeful add of toy or false</returns>
        public bool AddtoBuffer(Toy aToy)
        {
            lock (mylock)
            {

                if (buffer.Count < 15)
                {
                    buffer.Enqueue(aToy);
                    pbar.Invoke(new DisplayDelagate(updatePbar), new object[] { "" + Environment.NewLine });
                    Monitor.Pulse(mylock);
                    return true;

                }
                Monitor.Pulse(mylock);
                return false;
            }

        }

        /// <summary>
        /// Method to take away a toy from the buffere queue, if the buffer is empty then it waits the thread
        /// </summary>
        /// <returns>The first toy in the buffer queue</returns>
        public Toy takefromBuffer()
        {
            lock(mylock)
            {
                if (buffer.Count == 0)
                {
                    Monitor.Wait(mylock);
                }

                Toy firstToyinQueue;
                firstToyinQueue = buffer.Peek();
                buffer.Dequeue();
                pbar.Invoke(new DisplayDelagate(updatePbar), new object[] { "" + Environment.NewLine });
                Monitor.Pulse(mylock);
                return firstToyinQueue;
            }
           
        }

        /// <summary>
        /// Method to update the progress bar
        /// </summary>
        /// <param name="s"></param>
        public void updatePbar(string s)
        {
            pbar.Value = (buffer.Count * 100) / 15;
        }

    }
}

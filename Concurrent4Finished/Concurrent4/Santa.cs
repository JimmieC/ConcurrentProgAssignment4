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
    /// Class santa which is used by main
    /// </summary>
    class Santa
    {
        /// <summary>
        /// Variables, the current weight volume of santas sleigh, its max and lbl, listbox for the delagate.
        /// </summary>
        Buffer b;
        private List<Toy> SantasSack;

        double currentWeight;
        double currentVolume;

        int maxWeight = 300;
        int maxVolume = 5000;
        ListBox listBox1;
       
        Label lblFull;

        private delegate void DisplayDelagate(string s);

        /// <summary>
        /// Constructor for Santa, initializes label, the listbox and buffer, Also the list which whill hold toys
        /// </summary>
        /// <param name="b">buffer</param>
        /// <param name="lstbox">listbox from main</param>
        /// <param name="lblFull">label from main</param>
        public Santa(Buffer b, ListBox lstbox, Label lblFull)
        {
            this.b = b;
            SantasSack = new List<Toy>();
            listBox1 = lstbox;
            
            this.lblFull = lblFull;
        }

        /// <summary>
        /// Method to get a toy from the buffer and add it to the santa sleigh. Checks if the sleigh is not at its max wieight
        /// and checks if adding another item will exceed the max. Invoke delagate to fill the listbox in main with items added to the sleigh
        /// if the slegh is full then break the while loop
        /// </summary>
        public void addToMySled()
        {
            bool done = true;
            while(done)
            {
                if (currentWeight != maxWeight || currentVolume != maxVolume)
                {
                    Toy toyFromBuffer = (b.takefromBuffer());
                    if ((currentWeight += toyFromBuffer.Weight) <= maxWeight && (currentVolume += toyFromBuffer.Volume) <= maxVolume)
                    {
                        currentWeight += toyFromBuffer.Weight;
                        currentVolume += toyFromBuffer.Volume;
                        SantasSack.Add(toyFromBuffer);
                        listBox1.Invoke(new DisplayDelagate(fillListbox), new object[] { toyFromBuffer.Name + Environment.NewLine });
                    }
                    else
                    {

                        lblFull.Invoke(new DisplayDelagate(isfulltime), new object[] { "" + Environment.NewLine });
                        done = false;
                    }
                }

                Thread.Sleep(500);
            }
           
           
        }

        /// <summary>
        /// Method to change the label in main "Full"
        /// </summary>
        /// <param name="s"></param>
        public void isfulltime(string s)
        {
            lblFull.ForeColor = System.Drawing.Color.Red;
            lblFull.BackColor = System.Drawing.Color.Black;
        }

        /// <summary>
        /// Method to add item to the listbox in main
        /// </summary>
        /// <param name="input"></param>
        public void fillListbox(string input)
        {
            listBox1.Items.Add(input);
        }

       
   



    }
}

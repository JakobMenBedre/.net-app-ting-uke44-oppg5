using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;



namespace app_5
{
    public partial class Form1 : Form
        
    {
        int y = 0;
        public Form1()
        {
            InitializeComponent();
        }
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer(); //henter timer sine greier
        private int x = 10; //x er 10 :)
        private void start_Click(object sender, EventArgs e)
        {
            if (x != 0)
            {
                y++;
                clicks.Text=y.ToString(); //om x ikke er 0 så gjør den y=y+1 og så bytter clicks.Text til den y sin verdi.
            }
                
        }

        private void starttrykk_Click(object sender, EventArgs e)
        {
            myTimer.Interval = 1000; //lager en timer med en interval hvert 1000 millisekunder (1 sekund) 
            myTimer.Tick += UpdateTime; //får UpdateTime til å handle tidstakeren
            myTimer.Start(); //starter tidstakeren
        }
        private void UpdateTime(object sender, EventArgs e)
        {
            
            x--;
            tid.Text = x.ToString();//kjører x=x-1 (som er 10 i starten og vil da bli mindre og mindre) og deretter setter verdien i tid.Text 
            if (x == 0)
            {
                myTimer.Stop(); //når x enderlig er lik 0 så stopper den tidstakeren
            }
        }
    }
}

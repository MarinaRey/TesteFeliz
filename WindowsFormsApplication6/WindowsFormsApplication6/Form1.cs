using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midi;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Note nota = new Note('A');
            OutputDevice outputDevice = OutputDevice.InstalledDevices[0];
            outputDevice.Open();
            outputDevice.SendNoteOn(Channel.Channel1, nota.PitchInOctave(4), 80);  // Middle C, velocity 80
            outputDevice.SendPitchBend(Channel.Channel1, 7000);  // 8192 is centered, so 7000 is bent down
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GameCharacterWinForms.Models;

namespace GameCharacterWinForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //barHealthWarrior.SetState(2);
            //barStaminaWarrior.SetState(1);
            //barHealthMage.SetState(2);
            //barManaMage.SetState(1);

        }

        private void btnToBattle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
    //public static class ModifyProgressBarColor
    //{
    //    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
    //    static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
    //    public static void SetState(this ProgressBar pBar, int state)
    //    {
    //        SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
    //    }
    //}
}

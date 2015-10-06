using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quittung;

namespace Quittung
{
    public partial class FormQuittung : Form, IQuittungView
    {
        public FormQuittung()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quittung q = new Quittung((float)23.23, "Lino", "Test",DateTime.Today);
            q.speichern();
           
        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            if(oenFileDialog1.ShowDialog() == DialogResult.OK)
        }

        void IQuittungView.
    }
}

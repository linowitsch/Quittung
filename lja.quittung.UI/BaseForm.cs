using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lja.quittung.View;

namespace lja.quittung.UI
{
    public partial class BaseForm : Form, IView
    {
        public event EventHandler Close;

        public BaseForm()
        {
            InitializeComponent();
        }        
    }
}

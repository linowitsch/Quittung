using System.Windows.Forms;
using lja.quittung.View;

namespace lja.quittung.UI
{
    public partial class BaseForm : Form, IView
    {
        public BaseForm()
        {
            InitializeComponent();
        }
    }
}

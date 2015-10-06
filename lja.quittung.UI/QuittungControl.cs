using System;
using System.Windows.Forms;
using lja.quittung.View;
using lja.quittung.Business;
using lja.quittung.ViewModel;

namespace lja.quittung.UI
{
    public partial class QuittungControl : Form, IQuittungView
    {
        public event EventHandler OpenDialogChooser;

        public QuittungControl()
        {
            InitializeComponent();
            var controller = new QuittungController(this);
            controller.SubscribeEvents();
        }

        QuittungViewModel IQuittungView.Quittung { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            var handler = OpenDialogChooser;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }

        string IQuittungView.ShowFileDialog()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                return openFileDialog1.FileName;
            return null;
        }

        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

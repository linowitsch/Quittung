using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lja.quittung.ViewModel;

namespace lja.quittung.View
{
    public interface IQuittungView : IView
    {
        event EventHandler OpenDialogChooser;

        string ShowFileDialog();

        QuittungViewModel Quittung { get; set; }
    }
}

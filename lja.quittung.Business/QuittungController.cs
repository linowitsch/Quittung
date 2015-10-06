using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lja.quittung.View;

namespace lja.quittung.Business
{
    public class QuittungController : BaseController<IQuittungView>
    {
        #region Constructors

        public QuittungController(IQuittungView view) : base(view)
        {            
        }

        #endregion Constructors

        

        #region Methods

        public override void SubscribeEvents()
        {
            View.OpenDialogChooser += ViewOpenDialogChooser;
        }

        public override void UnsubscribeEvents()
        {
            View.OpenDialogChooser -= ViewOpenDialogChooser;
        }

        void ViewOpenDialogChooser(object sender, EventArgs e)
        {
            View.ShowFileDialog();
        }

        #endregion Methods
    }
}

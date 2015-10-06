using System;
using lja.quittung.View;

namespace lja.quittung.Business
{
    public class QuittungController : BaseController<IQuittungView>
    {
        public QuittungController(IQuittungView view) : base(view) {}

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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBob.Web
{
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refresh();
        }

        protected void rowSelected(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);

            GridViewRow row = ordersGridView.Rows[index];
            var idValue = row.Cells[0].Text;

            var orderId = Guid.Parse(idValue);

            Domain.OrderManager.CompleteOrder(orderId);

            refresh();

        }

        private void refresh()
        {
            var orders = Domain.OrderManager.GetOders();
            ordersGridView.DataSource = orders.ToList();
            ordersGridView.DataBind();
        }

    }
}
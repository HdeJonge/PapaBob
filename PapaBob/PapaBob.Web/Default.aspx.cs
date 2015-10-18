using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBob.Web
{
    public partial class Default : System.Web.UI.Page
    {
        string result = "";

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            try
            {

                var newOrder = getOrderInput();

                if(formCompleted(newOrder))
                {
                    Domain.OrderManager.AddOrder(newOrder);
                    Response.Redirect("Succes.aspx");

                }
                else resultLabel.Text = result;
                
            }
            catch (Exception ex)
            {
                resultLabel.Text = ex.Message ;
            }


        }

        private DTO.OrderDTO getOrderInput()
        {
            var newOrder = new DTO.OrderDTO();

            newOrder.OrderId = Guid.NewGuid();
            newOrder.Completed = false;
            newOrder.Size = getSize();
            newOrder.Crust = getCrust();
            newOrder.Sausage = sausageCheckbox.Checked;
            newOrder.Pepperoni = pepperoniCheckbox.Checked;
            newOrder.Onions = onionsCheckbox.Checked;
            newOrder.GreenPeppers = greenPeppersCheckbox.Checked;
            newOrder.Name = nameTextBox.Text;
            newOrder.Address = addressTextBox.Text;
            newOrder.Zip = zipTextBox.Text;
            newOrder.Phone = phoneTextBox.Text;
            newOrder.Payment = getPayment();
            newOrder.TotalCost = Domain.OrderManager.ChecktTotal(newOrder);

            return newOrder;

        }

        private bool formCompleted(DTO.OrderDTO newOrder)
        {

           // string result = "";


            if(newOrder.Name == "") 
            {
                result = "Please add Name";
                return false;
            }

            else if (newOrder.Address == "")
            {
                result = "Please add Address";
                return false;
            }
            else if (newOrder.Phone == "")
            {
                result = "Please add Phone number";
                return false;
            }
            else if (newOrder.Zip == "") 
            { 
                result = "Please add Zip";
                return false;
            }
            else return true;

        }
        private DTO.Enums.CrustType getCrust()
        {
            DTO.Enums.CrustType crust;

            if (!Enum.TryParse(crustDropDownList.SelectedValue, out crust))
            {
                throw new Exception("Please select a pizza crust");
            }
            return crust;
        }

        private DTO.Enums.SizeType getSize()
        {
            DTO.Enums.SizeType size;
            if (!Enum.TryParse(sizeDropDownList.SelectedValue, out size))
            {
                throw new Exception("Please select a pizza size");
            }
            return size;
        }

        private DTO.Enums.PaymentType getPayment()
        {
            //DTO.Enums.PaymentType payment;

            if (creditRadioButton.Checked) return DTO.Enums.PaymentType.credit;
            else return DTO.Enums.PaymentType.cash;
            //else throw new Exception("Please select a paymenttype");

            //return payment;
        }

        protected void getTotal(object sender, EventArgs e)
        {
            if(crustDropDownList.SelectedIndex == 0) return;
            if(sizeDropDownList.SelectedIndex == 0) return;
            var order = getOrderInput();

            decimal totalPrice = Domain.OrderManager.ChecktTotal(order);


            totalCostLabel.Text = string.Format("{0}", totalPrice.ToString("C"));
        }



    }
}
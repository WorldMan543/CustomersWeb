using ConsumerWeb.ConsumerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumerWeb
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IEnumerable<Models.Consumer> сonsumersGrid_GetData()
        {
            var client = new ConsumerServiceClient();
            var consumer = client.GetAll();
            return consumer.Select(x => new Models.Consumer()
            {
                ConsumerId = x.ConsumerId,
                DateOfBirth = x.DateOfBirth,
                Email = x.Email,
                FirstName = x.FirstName,
                LastName = x.LastName
            });
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void сonsumersGrid_DeleteItem(int consumerId)
        {
            var client = new ConsumerServiceClient();
         //   client.Delete(consumerId);
            //ModelState.AddModelError("",
            //  String.Format("Item with id {0} no longer exists in the database.", consumerId));
        }
    }
}
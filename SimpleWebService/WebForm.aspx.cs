using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleWebService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitClick(object sender, EventArgs e)
        {
            localhost.WebService zoo = new localhost.WebService();

            int minLength = int.Parse(LengthInput.Text.ToString());

            //Why is this string and not list as specified in the WebService?
            string[] selectedAnimals = zoo.SelectStringsLargerThan(minLength);

            AnimalsOutput.Text = "The animals with names longer than " + minLength.ToString() + " are : ";

        }
    }
}
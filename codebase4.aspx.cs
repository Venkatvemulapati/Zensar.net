using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication16
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "select", "Iphone", "samsung", "redmi" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~Content/pictures/Images" + str + ".jfif";



        }

        
       
        protected void button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.Items.FindByText("redmi").Selected == true)
            {
                TextBox1.Text = "Price: 15000";
            }
            else if (DropDownList1.Items.FindByText("samsung").Selected == true)
            {
                TextBox1.Text = "Price: 20000";
            }
            else if (DropDownList1.Items.FindByText("iphone").Selected == true)
            {
                TextBox1.Text = "Price:30000";
            }

        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=localhost;Initial Catalog=Nimap;User ID=nimap;Password=nimap@2021";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products", cnn);
            SqlDataReader rdr = cmd.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            cnn.Close();

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string product = TextBox1.Text;
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=localhost;Initial Catalog=Nimap;User ID=nimap;Password=nimap@2021";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            String sql = "Insert into Products(product_name) values('" + product + "')";

            SqlCommand objCommand = new SqlCommand(sql, cnn);
            objCommand.ExecuteNonQuery();

            cnn.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Student : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Bind();
    }
    protected void AddStudent(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection("user id=sa;password=123;database=AnilDb;server=Aneel-PC");
        cn.Open();
        SqlCommand cmd = new SqlCommand("insert into Student values("+txtId.Text+",'"+txtname.Text+"','"+txtmail.Text+"')",cn);
        int i=cmd.ExecuteNonQuery();
        cn.Close();
        ButtonInfo.Visible = true;
        if (i > 0)
        {
            ButtonInfo.Text = "Ok, Inserted";
        }
        else
        {
            ButtonInfo.Text = "Not, Inserted";
        }
        Bind();
    }
    protected void UpdateStudent(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection("user id=sa;password=123;database=AnilDb;server=Aneel-PC");
        cn.Open();
        SqlCommand cmd = new SqlCommand("update Student set Mail='" + txtmail.Text + "' where StudentId=" + txtId.Text + "", cn);
        int i = cmd.ExecuteNonQuery();
        cn.Close();
        ButtonInfo.Visible = true;
        if (i > 0)
        {
            ButtonInfo.Text = "Ok, Updated";
        }
        else
        {
            ButtonInfo.Text = "Not, Updated";
        }
        Bind();
    }
    protected void DeleteStudent(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection("user id=sa;password=123;database=AnilDb;server=Aneel-PC");
        cn.Open();
        SqlCommand cmd = new SqlCommand("delete Student where StudentId="+txtId.Text+"", cn);
        int i = cmd.ExecuteNonQuery();
        cn.Close();
        ButtonInfo.Visible = true;
        if (i > 0)
        {
            ButtonInfo.Text = "Ok, Deleted";
        }
        else
        {
            ButtonInfo.Text = "Not, Deleted";
        }
        Bind();
    }
    public void Bind()
    {
        SqlConnection cn = new SqlConnection("user id=sa;password=123;database=AnilDb;server=Aneel-PC");
        SqlDataAdapter da = new SqlDataAdapter("select * from Student order by StudentId desc", cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
}

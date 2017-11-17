using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace AngularDemo
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["ER_ConstConnectionString"].ConnectionString;
            DataClasses1DataContext db = new DataClasses1DataContext(conn);

            IQueryable<customclientpool> pool = from record in db.customclientpools where record.corpid == 2 select record;

            foreach(var a in pool)
            {
                Response.Write("a");
            }
        }
    }
}
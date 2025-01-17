﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test0806
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(this.txtBaseNumber.Text) && !string.IsNullOrWhiteSpace(this.txtColNumber.Text))
            {
                this.Session["baseNum"] = this.txtBaseNumber.Text;
                this.Session["colNum"] = this.txtColNumber.Text;

                int baseNum;
                int coefiNum;

                // check try pase
                if (!int.TryParse(this.txtBaseNumber.Text, out baseNum))
                {
                    this.plcIntMsg.Visible = true;
                    return;
                }
                if (!int.TryParse(this.txtColNumber.Text, out coefiNum))
                {
                    this.plcIntMsg.Visible = true;
                    return;
                }

                // by pass if is testing
                DBFunction.DBHelper.CreateData(baseNum, coefiNum);
                Response.Redirect("OutputTable.aspx");
            }
            else
            {
                this.plcMsg.Visible = true;
            }
        }
    }
}
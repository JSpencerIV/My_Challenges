﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_RadioButtons
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           if (pencilRadioButton.Checked)
                resultLabel.Text = "You selected Pencil.";
                resultImage.ImageUrl = "pencil.png";
           else if (penRadioButton.Checked)
                resultLabel.Text = "You selected Pen.";
                resultImage.ImageUrl = "pen.png";
           else if (phoneRadioButton.Checked)
                resultLabel.Text = "You selected Phone.";
                resultImage.ImageUrl = "phone.png";
           else if (tabletRadioButton.Checked)
                resultLabel.Text = "You selected Tablet.";
                resultImage.ImageUrl = "tablet.png";
            else
                resultLabel.Text = "Please select a option";   
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2._1
{
    public partial class Picklist : Form
    {
        public Picklist()
        {
            InitializeComponent();
            this.cboPickList.Items.AddRange(new object[]
            {
                "Apple",        //0
                "Orange",       //1
                "Watermelon",   //2
            });
        }

        //Shows the selection on the lblUtility
        private void cboPickList_Hover(object sender, Custom.HoverEventArgs e) //cboUtility
        {
            // if you want to display the combobox index and field detail then use this
            //lblUtility.Text = "Item : " + e.itemIndex.ToString() + " = " + ((Custom.PickListComboBox)sender).Items[e.itemIndex];

            //Conditional description
            if (e.itemIndex == 0)
            {
                lblPickListValue.Text = "Item is apple " + Environment.NewLine + "and it keeps the doctor away";
            }

            if (e.itemIndex == 1)
            {
                lblPickListValue.Text = "An orange a day keeps the flue away";
            }

            if (e.itemIndex == 2)
            {
                lblPickListValue.Text = "Watermelons should fit under a t-shirt";
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

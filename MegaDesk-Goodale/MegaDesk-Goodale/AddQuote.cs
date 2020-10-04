using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Goodale
{
    public partial class AddQuote : Form
    {
        DateTime quoteDate = DateTime.Now;
        public AddQuote()
        {
            InitializeComponent();

            // Set dateQuote type to string and post on form 
            string quoteDateString = quoteDate.ToString("dd MMMM yyyy");
            QuoteDate.Text = quoteDateString;

            // Populate the surface material combo box with the enum from the Desk class
            List<SurfaceMaterial> surfaceMaterials = Enum.GetValues(typeof(SurfaceMaterial)).Cast<SurfaceMaterial>().ToList();
            SurfaceMaterial.DataSource = surfaceMaterials;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }


        // Desk Width Validation Code

        private void DeskWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void DeskWidth_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if(!Width_Validation(DeskWidth.Text, out errMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                DeskWidth.Select(0, DeskWidth.Text.Length);

                // Set the errorProvider up
                this.errorProvider.SetError(DeskWidth, errMsg);
            }
        }

        private void DeskWidth_Validated(object sender, System.EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider.SetError(DeskWidth, "");
        }

        private bool Width_Validation(string width, out string errMsg)
        {
            try
            {
                int temp;
                if(int.TryParse(width, out temp))
                {
                    if(temp < Desk.MIN_WIDTH || temp > Desk.MAX_WIDTH)
                    {
                        errMsg = $"Input must be whole number between {Desk.MIN_WIDTH} and {Desk.MAX_WIDTH}";
                        return false;
                    }
                    errMsg = "";
                    return true;
                }
                errMsg = $"Input must be whole number between {Desk.MIN_WIDTH} and {Desk.MAX_WIDTH}";
                return false;
            } 
            catch
            {
                errMsg = $"Unexpected error, please enter a whole number between {Desk.MIN_WIDTH} and {Desk.MAX_WIDTH}";
                return false;
            }
        }


        // Desk depth validation code

        private void DeskDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        // Check if the string is a valid number in range
        private bool Depth_Validation(string depth, out string errMsg)
        {
            try
            {
                int temp;
                if (int.TryParse(depth, out temp))
                {
                    if (temp < Desk.MIN_DEPTH || temp > Desk.MAX_DEPTH)
                    {
                        errMsg = $"Input must be whole number between {Desk.MIN_DEPTH} and {Desk.MAX_DEPTH}";
                        return false;
                    }
                    errMsg = "";
                    return true;
                }
                errMsg = $"Input must be whole number between {Desk.MIN_DEPTH} and {Desk.MAX_DEPTH}";
                return false;
            }
            catch
            {
                errMsg = $"Unexpected error, please enter a whole number between {Desk.MIN_DEPTH} and {Desk.MAX_DEPTH}";
                return false;
            }
        }

        private void DeskDepth_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (!Depth_Validation(DeskDepth.Text, out errMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                DeskWidth.Select(0, DeskDepth.Text.Length);

                // Set the errorProvider up
                this.errorProvider.SetError(DeskDepth, errMsg);
            }
        }

        private void DeskDepth_Validated(object sender, System.EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider.SetError(DeskDepth, "");
        }

        private void SubmitOrder_Click(object sender, EventArgs e)
        {
            DeskQuote newQuote = new DeskQuote(CustName.Text, quoteDate, int.Parse(DeskWidth.Text), int.Parse(DeskDepth.Text), DrawersNum.SelectedIndex, (int)SurfaceMaterial.SelectedItem, RushShipping.SelectedIndex);
            //Console.WriteLine((int)SurfaceMaterial.SelectedItem);
        }


    }
}

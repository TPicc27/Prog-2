// Grading ID: C9022
// Program 2
// CIS 200-01-4168
// November 1, 2016
// The Letter Form accessed from insert letter will let user send a letter.
// Can send letter using the names of address.  Give a name for the origin address
// and the destination address. Also give the fixed cost of how much the letter is.
// The letter can then be enter into the main form list box or cancel the information
// hitting the cancel button.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class LetterForm : Form
    {
        private List<Address> addressList;// List of addresses store for user.
        
        // Precondition: None
        // Postcondition: The Letter GUI is intializied.
        public LetterForm(List<Address> addresses)
        {
            InitializeComponent();

            addressList = addresses;
            
        }


        // Loading List of names for the origin address combo box and the destination address combo box.
        private void LetterForm_Load(object sender, EventArgs e)
        {

            foreach (Address a in addressList) // Loop to look through the list of addresses.
            {
                originComboBox.Items.Add(a.Name); // Names from list of addresses is added to OriginAddressComboBox.
                destinationComboBox.Items.Add(a.Name); // Names from list of addresses is added to DestinationAddressComboBox.
            }
        } 

        internal int Origin
        {
            // Preconditon: None
            // Postconditon: The OriginComboBox is returned with names from the list of addresses.
            get
            {
                return originComboBox.SelectedIndex; // get index of names from addresses.
            }
        }

        internal int Destination
        {
            // Precondition: None
            // Postcondition: The DestinationComboBox is returned with names from the list of addresses.
            get
            {
                return destinationComboBox.SelectedIndex;
            }
        }

        internal String FixedCost
        {
            // Precondition: None
            // Postcondition: The Fixed Cost Text Box is returned.
            get
            {
                return costTextBox.Text;
            }

            // Precondition: None
            // Postcondition: The Cost Text Box is set to a specific value.
            set
            {
                costTextBox.Text = value;
            }
        }

        // Precondition: Focus changes to Origin Combo Box.
        // Postcondition: The item is selected then the focus changes. If no
        //                item is selected an error message is given and focus
        //                remains.
        private void originComboBox_Validating(object sender, CancelEventArgs e)
        {
            if( originComboBox.SelectedIndex < 0) // if no item is selected
            {
                e.Cancel = true; // stop focus from changing

                originErrorProvider.SetError(originComboBox, "Please select a name!"); // Error Message is given.

                originComboBox.SelectAll(); // Select all items from Origin Combo Box.
            }
        }

        // Preconditon: Origin Combo Box Validating has succeeded.
        // Postcondition: The error message is cleared and the focus changes.
        private void originComboBox_Validated(object sender, EventArgs e)
        {
            originErrorProvider.SetError(originComboBox, ""); // Clear Error Message.
        }

        // Precondition: Focus changes to the Destination Combo Box.
        // Postcondition: If an item is selected than the focus changes, if 
        //                no item is selected than the focus remains and error message
        //                is given.
        private void destinationComboBox_Validating(object sender, CancelEventArgs e)
        {
            if(destinationComboBox.SelectedIndex < 0) // if no item is selected
            {
                e.Cancel = true; // stop focus from changing

                destErrorProvider.SetError(destinationComboBox, "Please select a name!"); // Error Message is given.

                destinationComboBox.SelectAll(); // Selected all from Destination Combo Box.
            }
        }

        // Precondition: Destination Combo Box Validating has succeeded.
        // Postcondition: Error message is cleared and focus changes.
        private void destinationComboBox_Validated(object sender, EventArgs e)
        {
            destErrorProvider.SetError(destinationComboBox, ""); // Clear Error Message.
        }


        // Precondition: User clicks the enter button.
        // Postcondition: The entire form is validated, Letter Form is dismissed from enter result.
        private void enterButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren()) // is all results are validated.
            {
                this.DialogResult = DialogResult.OK; // ok result.
            }
        }

        // Precondition: User clicks the cancel button.
        // Postcondition: If clicked than information is dismissed with cancel result.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // cancel result.
            this.Close();
        }

        // Precondition: Focus changes to Cost Text Box.
        // Postcondition: If cost is valid and greater than zero than focus changes.
        //                If cost is not valid or less than zero than focus remains
        //                and error message is given.
        private void costTextBox_Validating(object sender, CancelEventArgs e)
        {
            decimal cost; // value enter into cost text box.

            if (!decimal.TryParse(costTextBox.Text, out cost)) // not a valid decimal 
            {
                e.Cancel = true; // stop focus from changing

                costErrorProvider.SetError(costTextBox, "Please enter in a cost!"); // Error message given.

                costTextBox.SelectAll(); // Selected all in Cost Text Box.
            }
            else
            {
                if(cost < 0) // if cost is less than zero
                {
                    e.Cancel = true; // stop focus from changing

                    costErrorProvider.SetError(costTextBox, "Please enter in a positive value!"); // Error Message is given.

                    costTextBox.SelectAll(); // Selected all in Cost Text Box.
                }
            }


        }

        // Precondition: Cost Text Box Validating has succeeded.
        // Postcondition: Clear error message and change focus.
        private void costTextBox_Validated(object sender, EventArgs e)
        {
            costErrorProvider.SetError(costTextBox, ""); // Clear error message.
        }
    }
}

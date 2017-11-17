// Grading ID: C9022
// Program 2
// CIS 200-01-4168
// November 1, 2016
//  Address Form is used for the user to add information to the list of already added Addresses.
// The user will enter their name, address and second address if needeed, a city, the state,
// and their zip code. If they dont enter the correct information into any of the text boxes or 
// combo boxes a error message will display.  When finished with form they will click enter
// and the form will be added to the list box on the main form. 

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
    public partial class AddressForm : Form
    {
        List<string> stateList = new List<string>(); // List of addresses store from the user


        // Precondition: None
        // Postcondition: The Address GUI is initialized
        
        public AddressForm()
        {
            InitializeComponent();

            stateList.Add("AL");
            stateList.Add("AK");
            stateList.Add("AZ");
            stateList.Add("AR");
            stateList.Add("CA");
            stateList.Add("CO");
            stateList.Add("CT");
            stateList.Add("DE");
            stateList.Add("FL");
            stateList.Add("GA");
            stateList.Add("HI");
            stateList.Add("ID");
            stateList.Add("IL");
            stateList.Add("IN");
            stateList.Add("IA");
            stateList.Add("KS");
            stateList.Add("KY");
            stateList.Add("LA");
            stateList.Add("ME");
            stateList.Add("MD");
            stateList.Add("MA");
            stateList.Add("MI");
            stateList.Add("MN");
            stateList.Add("MS");
            stateList.Add("MO");
            stateList.Add("MT");
            stateList.Add("NE");
            stateList.Add("NV");
            stateList.Add("NH");
            stateList.Add("NJ");
            stateList.Add("NM");
            stateList.Add("NY");
            stateList.Add("ND");
            stateList.Add("OH");
            stateList.Add("OK");
            stateList.Add("OR");
            stateList.Add("PA");
            stateList.Add("RI");
            stateList.Add("SC");
            stateList.Add("SD");
            stateList.Add("TN");
            stateList.Add("TX");
            stateList.Add("UT");
            stateList.Add("VT");
            stateList.Add("VA");
            stateList.Add("WA");
            stateList.Add("WV");
            stateList.Add("WI");
            stateList.Add("WY");
        }

        // Can used by other classes with the namespace: name.
        internal String name
        {
            //Precondition: None
            //Postcondition: Name Text Box is returned.
            get
            {
                return nameTextBox.Text;
            }

            //Precondition: None
            //Postcondition: Name Text Box is set to a specified value.
            set
            {
                nameTextBox.Text = value;
            }
        }
        
        // Can be used by other classes with namespace: address1.
        internal String address1
        {
            // Precondition: None
            // Postcondition: Address 1 Text Box is returned.
            get
            {
                return address1TextBox.Text;
            }

            // Precondition: None
            // Postcondition: Address 1 Text Box is set to a specified value.
            set
            {
                address1TextBox.Text = value;
            }
        }

        // Can be used by other classes with namespace: address2.
        internal String address2
        {
            // Precondition: None
            // Postcondition: Address 2 Text Box is returned.
            get
            {
                return address2TextBox.Text;
            }

            // Precondition: None
            // Postcondition: Address 2 Text Box is set to a specified value.
            set
            {
                address2TextBox.Text = value;
            }
        }

        // Can be used by other classes with namespace: city.
        internal String city
        {
            // Precondition: None
            // Postcondition: City Text Box is returned.
            get
            {
                return cityTextBox.Text; 
            }

            // Precondition: None.
            // Postcondition: City Text Box is set to a specified value.
            set
            {
                cityTextBox.Text = value;
            }
        }

        // Loading list of states into the State Combo Box.
        private void AddressForm_Load(object sender, EventArgs e)
        {
            foreach (string value in stateList) // Use loop to look through the collection of states
                stateComboBox.Items.Add(value); // Only uses states in State Combo Box.
        }

        // Can be used in other classes with namespace: state.
        internal int state
        {
            // Precondition: None
            // Postcondition: State Combo Box is returned with selected states from Address List.
            get
            {
                return stateComboBox.SelectedIndex; // get index of states from address list.

            }
        }

        // Can be used by other classes with namespace: zip.
        internal String zip
        {
            // Precondition: None
            // Postcondition: Zip Text Box is returned.
            get
            {
                return zipTextBox.Text;
            }

            // Precondition: None
            // Postcondition: Zip Text Box is set to a specified value.
            set
            {
                zipTextBox.Text = value;
            }
        }

        // Precondition: Change focus of the Name Text Box.
        // Postcondition: If Name Text Box has valid text then the focus will change. If not
        //                then the focus will remain in Name Text Box and given a error symbol.
        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nameTextBox.Text == "") // If no text is given
            {
                e.Cancel = true; // stop focus changing process

                nameErrorProvider.SetError(nameTextBox, "Please enter a name!"); // Error Given

                nameTextBox.SelectAll(); // Select all text from Name Text Box.
            }
        }

        // Precondition: Name Text Box Validating succeed.
        // Postcondition: Error Message from Name Text Box is cleared and 
        //                focus changes.
        private void nameTextBox_Validated(object sender, EventArgs e)
        {
            nameErrorProvider.SetError(nameTextBox, ""); // Clear error message.
        }

        // Precondition: Focus changed to Address 1 Text Box.
        // Postcondition: If the text in Address 1 Text Box is valid then the focus will change.
        //                If the text is invalid then error message is given and error message is given.
        private void address1TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (address1TextBox.Text == "") // if text is invalid
            {
                e.Cancel = true; // stop focus from changing

                addressErrorProvider.SetError(address1TextBox, "Please enter a address!"); // error message given.

                address1TextBox.SelectAll(); // Select all text from Address 1 Text Box.

            }
        }

        // Precondition: Address 1 Text Box Validation succeed.
        // Postcondition: Error Message is cleared from Address1 Text Box and focus changes.
        private void address1TextBox_Validated(object sender, EventArgs e)
        {
            addressErrorProvider.SetError(address1TextBox, ""); // Error message is cleared.
        }

        // Precondition: Focus changes to City Text Box.
        // Postcondition: If text in City Text Box is valid then focus will change.
        //                If text is invalid than focus remains and error message is given.
        private void cityTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(cityTextBox.Text == "") // if text is invalid.
            {
                e.Cancel = true; // stop focus from changing

                cityErrorProvider.SetError(cityTextBox, "Please enter a city name!"); // Error message given.

                cityTextBox.SelectAll(); // Select all text from City Text Box.
            }
        }

        // Precondition: City Text Box Validation succeed.
        // Postcondition: Error Message is cleared from City Text Box and focus changes.
        private void cityTextBox_Validated(object sender, EventArgs e)
        {
            cityErrorProvider.SetError(cityTextBox, ""); // clear error message.
        }
        
        // Precondition: Focus changes to State Combo Box.
        // Postcondition: If a item is selected in State Combo Box than the focus changes.
        //                If a there is no item selected than a error message is given and 
        //                the focus remains.
        private void stateComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (stateComboBox.SelectedIndex < 0) // If index is less than 0
            {
                e.Cancel = true; // stop focus from changing

                stateErrorProvider.SetError(stateComboBox, "Please select a State!"); // Error message given.

                stateComboBox.SelectAll(); // Select all text from State Combo Box.
            }
        }

        // Precondition: State Combo Box Valdating has succeeded.
        // Postcondition: Error message is cleared and the focus changes.
        private void stateComboBox_Validated(object sender, EventArgs e)
        {
            stateErrorProvider.SetError(stateComboBox, ""); // Clear Error Message.
        }

        // Precondition: Focus changes to Zip Text Box.
        // Postcondition: If the integer in Zip Text Box is valid than the focus changes.
        //                If the text is invalid or less than 0 the focus remains.
        private void zipTextBox_Validating(object sender, CancelEventArgs e)
        {
            int number; // value entered into Zip Text Box

            if (!int.TryParse(zipTextBox.Text, out number)) // if not an interger
            {
                e.Cancel = true; // stop focus from changing

                zipErrorProvider.SetError(zipTextBox, "Please enter a zip code!"); // Error Message given.

                zipTextBox.SelectAll(); // Select all text from Zip Text Box.
            }
            else
            {
                if (number < 0) // Number less than zerp
                {
                    e.Cancel = true; // stop focus from changing

                    zipErrorProvider.SetError(zipTextBox, "Please enter a non-negative zip code"); // Error Message given.
                }
            }


        }

        // Precondition: Zip Text Box Validating has succeeded.
        // Postcondition: The Error message is cleared and the focus changes.
        private void zipTextBox_Validated(object sender, EventArgs e)
        {
            zipErrorProvider.SetError(zipTextBox, ""); // Clear Error Message.
        }

        // Precondition: User clicks on the Enter button
        // Postcondition: If the entire form is validated, Address Form dismissed with enter result.
        private void enterButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren()) // All validations are complete.
            {
                this.DialogResult = DialogResult.OK; // ok result
            }
        }

        // Precondition: User clicks on Cancel button
        // Postcondition: If clicked than information is dismissed with cancel result. 
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Cancel result.
            this.Close(); // Close Form
        }
    }
}

// Grading ID: C9022
// Program 2
// CIS 200-01-4168
// November 1, 2016
// Program 2 Form has a menu strip with file, insert, and report.
// File menu has a about item that has a dialog box talking about you I am.
// Exit item can exit out of the application. The Insert menu has a create address item
// that gives a modal dialog box that lets you create a new address to be add to the list
// The create letter item lets you create a letter from two already create address and
// you must enter a fixed cost. The Report menu has two items Insert Addresses and Insert Parcels.
// Insert Addresses inserts the entire list of addresses into the text box.
// The Insert Parcels inserts the entire list of parcels into the text box. 
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
    public partial class Prog2Form : Form
    {
        private UserParcelView upv; 
        
        
        // Precondition: None
        // Postcondition: Addresses are put into the value upv.
        public Prog2Form()
        {
            InitializeComponent();

            upv = new UserParcelView();
            

            upv.AddAddress("John Smith", "123 Any St.", "Apt. 45",
                "Louisville", "KY", 40202); // Test Address 1
            upv.AddAddress("Jane Doe", "987 Main St.", "",
                "Beverly Hills", "CA", 90210); // Test Address 2
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            upv.AddAddress("Larry Brown", "744 Blueberry Road", "Apt.34",
                "Atlanta", "GA", 30022); // Test Address 5
            upv.AddAddress("Bruce Wayne", "488 Batman Street", "",
                "Gotham", "NY", 00322); // Test Address 6
            upv.AddAddress("George Washington", "353 Apple Ave.", "",
                "Richmond", "VA", 20113); // Test Address 7
            upv.AddAddress("Rocky Balboa", "695 Liberty Road", "Apt. 5",
                "Philadelphia", "PA", 60554); // Test Address 8

            upv.AddLetter(upv.AddressAt(1), upv.AddressAt(3), 1.50M); // Test Letter 1
            upv.AddLetter(upv.AddressAt(2), upv.AddressAt(5), 1.25M); // Test Letter 2
            upv.AddLetter(upv.AddressAt(4), upv.AddressAt(1), 1.75M); // Test Letter 3

            upv.AddGroundPackage (upv.AddressAt(6), upv.AddressAt(3), 25.4, 47.5, 23.3, 59.6); // Test Ground Package 1
            upv.AddGroundPackage(upv.AddressAt(4), upv.AddressAt(7), 45.78, 33.4, 45, 60);  // Test Ground Package 2
            upv.AddGroundPackage(upv.AddressAt(7), upv.AddressAt(2), 18.3, 21.4, 56, 78);  // Test Ground Package 3

            upv.AddNextDayAirPackage(upv.AddressAt(1), upv.AddressAt(6), 28.2, 27.4, 34, 68.4, 4.56M); // Test Next Day Air Package 1
            upv.AddNextDayAirPackage(upv.AddressAt(5), upv.AddressAt(7), 32.3, 25.3, 13.4, 87.4, 3.34M); // Test Next Day Air Package 2
            upv.AddNextDayAirPackage(upv.AddressAt(2), upv.AddressAt(3), 19.7, 34.6, 29.6, 65.3, 2.85M); // Test Next Day Air Package 3

            upv.AddTwoDayAirPackage(upv.AddressAt(7), upv.AddressAt(2), 48.3, 35.5, 45.3, 79.5,
                TwoDayAirPackage.Delivery.Saver); // Test Two Day Air Package 1
            upv.AddTwoDayAirPackage(upv.AddressAt(5), upv.AddressAt(4), 29.2, 37.4, 28.4, 78.3,
                TwoDayAirPackage.Delivery.Saver);  // Test Two Day Air Package 2
            upv.AddTwoDayAirPackage(upv.AddressAt(7), upv.AddressAt(6), 12.4, 24.3, 32.2, 65.8,
                TwoDayAirPackage.Delivery.Early);  // Test Two Day Air Package 3 


        }

        // Precondition: About button is clicked
        // Postcondition: A dialog box is displayed showing information about me.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Program 2 \n By: GradingID: C9022 \n CIS 200-01-4168 \n Fall 2016");
        }

        // Precondition: Exit button is clicked.
        // Postcondition: The applicaition is closed.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition: Address button is clicked.
        // Postcondition: A dialog box is displayed and 
        //               user enters a new address and it placed in the list.
        private void createAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(AddressForm addform = new AddressForm()) // dialog box form.
            {
                if(addform.ShowDialog() == DialogResult.OK) // only update if user says enter
                {
                    textBox1.Text = (addform.name); // retrieve value from dialog boxes
                    textBox1.Text = (addform.address1);
                    textBox1.Text = (addform.address2);
                    textBox1.Text = (addform.city);
                    textBox1.Text = (addform.state.ToString());
                    textBox1.Text = (addform.zip);

                }
                
            }
            
        }

        // Precondition: Letter button is clicked
        // Postcondition: The dialog box is displayed and user enters 
        //                a new letter form and the information is retrieved from the Letter form.
        private void createLetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(LetterForm letform = new LetterForm(upv.AddressList)) // dialog box form
            {
                if (letform.ShowDialog() == DialogResult.OK) // only update if user says enter
                {
                    textBox1.Text = (letform.Origin.ToString()); // retrieve value from dialog boxes.
                    textBox1.Text = (letform.Destination.ToString());
                    textBox1.Text = (letform.FixedCost);

                }

            }

            
        }
        
        // Precondition: The Insert Addresses is clicked
        // Postcondition: All the information from Address list is placed in the List Box
        //               on the Program 2 Form.
        private void insertAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); 


            foreach(Address address in upv.AddressList) // loop through the collection upv addresses
            {
                result.Append(address); // append addresses
                result.Append(System.Environment.NewLine); // create new line
                result.Append(System.Environment.NewLine); // create new line
            }

            textBox1.Text = result.ToString(); // insert addresses into Text Box

        }

        // Precondition: User clicks on Insert Parcels
        // Postcondition: All the information from all the Parcels: Letter, Ground Package,
        //                Air Package, and Two Day Air Package is inserted into the Text Box.
        private void insertParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();


            foreach(Parcel parcel in upv.ParcelList) // loop through the collection of upv parcels
            {
                result.Append(parcel); // append parcels
                result.Append(System.Environment.NewLine); // new line
                result.Append(System.Environment.NewLine); // new line
            }

            textBox1.Text = result.ToString(); // insert parcels into Text Box
        }
    }
}

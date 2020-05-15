using Astellas_Pharma.Entities;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
// Importing Libraries
using Astellas_Pharma.Utilities;
using Astellas_Pharma.Processes;
using System.Security.Cryptography.X509Certificates;

namespace Astellas_Pharma
{
    public partial class FrmRegister : Form
    {
        Database db = new Database();
        protected Thread thread;
        User newUser = new User();

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }     

        //Objective – Store all selected specialisms from checkedListSpecialisms in an
        //array called specialismList.
       

        //Objective: Load all specialisms stored in table Specialisms into the
        //checkedListSpecialism

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            string sqlQuery = "select specialism from specialisms;";
            DataTable dt = db.Read(sqlQuery);
            foreach (DataRow dr in dt.Rows)
            {
                ChkLstSpecialisms.Items.Add(dr.ItemArray[0].ToString());
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            //Place all selected Specialism into an Array - specialismList
            int noOfSpecialism = ChkLstSpecialisms.CheckedItems.Count;
            string[] specialismList = new string[noOfSpecialism];
            int i = 0;
            foreach (var item in ChkLstSpecialisms.CheckedItems)
            {
                if (i < noOfSpecialism)
                {
                    specialismList[i] = item.ToString();
                }
                i++;
               
            }

            //Objective – Store all the data from GUI about the user into a User Object via the
            // Object Properties

            if(TxtbxFisrtname.Text == "" || txtbxSurname.Text == "" || TxtbxUsername.Text == "" || TxtbxPassword.Text == "" || TxtbxConPassword.Text == "")
            {
                MessageBox.Show("Please Fill In all Required Feilds");
            }
           else
            {
                string sqlQuery = "select username from users WHERE username = '"+ TxtbxUsername.Text + "'; ";
                DataTable dt = db.Read(sqlQuery);
                int totalRows = dt.Rows.Count;
                if (totalRows > 0)
                {
                    MessageBox.Show("username " + TxtbxUsername.Text + " already exists");
                    dt.Clear();
                }
                else
                {
                    //Verifying that both passwords are same
                    if (TxtbxPassword.Text.Trim() != TxtbxConPassword.Text.Trim())
                    {
                        MessageBox.Show("Confirm password is not matched with password..?");
                        return;
                    }
                    else
                    {
                        //int noOfSpecialism = ChkLstSpecialisms.CheckedItems.Count;
                        //string[] specialismList = new string[noOfSpecialism];
                        //int i = 0;
                        //if (i = noOfSpecialism)
                       // {
                           // MessageBox.Show("Please Input Your Specialism(s)");
                       // }
                       // else
                       // {
                            newUser.Firstname = TxtbxFisrtname.Text.Trim().ToLower();
                            newUser.Surname = txtbxSurname.Text.Trim().ToLower();
                            newUser.Username = TxtbxUsername.Text.Trim().ToLower();
                            newUser.Password = Encrypter.Encrypt(TxtbxPassword.Text);
                            newUser.SpecialismList = specialismList;

                            // Objective: Create a Registration Object in the btnRegister_click
                            Registration registration = new Registration();
                            registration.Register(newUser);

                            this.Close();
                            thread = new Thread(openFrmLogin);
                            thread.SetApartmentState(ApartmentState.STA);
                            thread.Start();
                       // }
                    }
                    
                }

            }
           
           

            
        }

        private void openFrmLogin()
        {
            Application.Run(new FrmLogin());
        }
    }
    
}

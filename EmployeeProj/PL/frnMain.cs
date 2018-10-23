using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeProj.DB;
using System.Configuration;
using EmployeeProj.DAL;
using System.Data.SqlClient;

namespace EmployeeProj
{
    public partial class frnMain : Form
    {

        #region Business Logic

        public static void OpenConnection(AdoHelper adoHelper, string Connection)
        {
            adoHelper.OpenConnection(Connection);
        }

        public static void SearchSkillsName()
        {

        }
        #endregion
        public frnMain()
        {
            InitializeComponent();

        }

        private void frnMain_Load(object sender, EventArgs e)
        {
            InitiClass.StarUP();
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeesConStr"].ConnectionString);

            #region Show All Employees

            DataTable EmployeeHierar = BL.GetClass.Employees.GetAllEmployees();

            foreach (DataRow currentEmployee in EmployeeHierar.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell firstName = new DataGridViewTextBoxCell();
                firstName.Value = currentEmployee["FirstName"];
                row.Cells.Add(firstName);

                DataGridViewTextBoxCell lastName = new DataGridViewTextBoxCell();
                lastName.Value = currentEmployee["LastName"];
                row.Cells.Add(lastName);

                DataGridViewTextBoxCell alias = new DataGridViewTextBoxCell();
                alias.Value = currentEmployee["Alias"];
                row.Cells.Add(alias);

                DataGridViewTextBoxCell eMail = new DataGridViewTextBoxCell();
                eMail.Value = currentEmployee["Email"];
                row.Cells.Add(eMail);

                DataGridViewTextBoxCell employeeID = new DataGridViewTextBoxCell();
                employeeID.Value = currentEmployee["EmployeeID"];
                row.Cells.Add(employeeID);

                grvEmployees.Rows.Add(row);
            }


            #endregion
            #region Connected Connection

            AdoHelper adoHelper = new AdoHelper();
            string conStr = ConfigurationManager.ConnectionStrings["EmployeesConStr"].ConnectionString;

            OpenConnection(adoHelper, conStr);


            #endregion
            #region 
            #endregion


        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                txtSearch.ForeColor = Color.DarkGray;
                txtSearch.Text = "Add Keryword sparated by a space. Press <Enter> to search";
            }
          
        }

        private void txtSearch_Leave(object sender, ControlEventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                txtSearch.ForeColor = Color.DarkGray;
                txtSearch.Text = "Add Keryword sparated by a space. Press <Enter> to search";
            }
        }

        private void grvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Clear all rows in DataGridView GrvEmployees

            #region Show All Skills
            
            int employeeID = 0;

            if (grvEmployees.SelectedCells.Count > 0)
            {
                // Get Row Index of select employee 
                int selectedrowindex = grvEmployees.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = grvEmployees.Rows[selectedrowindex];
                string str = selectedRow.Cells["EmployeeID"].Value.ToString();

                try
                {
                    employeeID = int.Parse(str);

                }
                catch (Exception se)
                {
                    Console.WriteLine(se.Message);

                }

                DataTable SkillsHierar = BL.GetClass.Skills.GetSkillByEmployeeID(employeeID);
                foreach (DataRow currentSkill in SkillsHierar.Rows)
                {

                    DataGridViewRow row = new DataGridViewRow();

                    DataGridViewTextBoxCell skillName = new DataGridViewTextBoxCell();
                    skillName.Value = currentSkill["SkillName"];
                    row.Cells.Add(skillName);

                    DataGridViewTextBoxCell briefDesc = new DataGridViewTextBoxCell();
                    briefDesc.Value = currentSkill["BriefDescription"];
                    row.Cells.Add(briefDesc);

                    DataGridViewTextBoxCell skillID = new DataGridViewTextBoxCell();
                    skillID.Value = currentSkill["SkillID"];
                    row.Cells.Add(skillID);

                    DataGridViewTextBoxCell skillsEmployeeID = new DataGridViewTextBoxCell();
                    skillsEmployeeID.Value = currentSkill["EmployeeID"];
                    row.Cells.Add(skillsEmployeeID);

                    grvEmployeesSkills.Rows.Add(row);

                }
            }
            
            #endregion
            UpdateSkillAndReferenceTextBox(txtboxSkillAndReference, grvEmployeesSkills, employeeID);

        
            }

        private void grvEmployeesSkills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            #region Show Entire Description and Refrence
            try
            {
                if (grvEmployeesSkills.SelectedCells.Count > 0)
                {
                    int selectedrowindex = grvEmployeesSkills.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = grvEmployeesSkills.Rows[selectedrowindex];

                    if (grvEmployeesSkills.SelectedCells.Count > 0)
                    {
                        int employeeID = 0;
                        selectedrowindex = grvEmployeesSkills.SelectedCells[0].RowIndex;
                        selectedRow = grvEmployeesSkills.Rows[selectedrowindex];
                        string str = selectedRow.Cells["SkillEmployeesID"].Value.ToString();

                        try
                        {
                            employeeID = int.Parse(str);
                        }
                        catch (Exception se)
                        {
                            Console.WriteLine(se.Message);

                        }

                        UpdateSkillAndReferenceTextBox(txtboxSkillAndReference, grvEmployeesSkills, employeeID);
                    }
                }
            }
            catch (Exception se)
            {

                Console.WriteLine(se.Message); ;
            }

            #endregion
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Could not benn able to create a search engine
            MessageBox.Show("Search function not available");

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.ForeColor = Color.Black;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AdoHelper adoHelper = new AdoHelper();
            adoHelper.CloseConnection();
            this.Close();
        }

        #region Submit

        private void btnSubmitEmployee_Click(object sender, EventArgs e)
        {
            string newEmployeeFirstName = txtNewFirstName.Text;
            string newEmployeeLastName = txtNewLastName.Text;
            string newEmployeeAlias = txtNewAlias.Text;
            string newEmployeeEmail = txtNewEmail.Text;
            #region Check If TextBoxs above are empty

            if (string.IsNullOrEmpty(newEmployeeFirstName) == true || string.IsNullOrEmpty(newEmployeeLastName) == true || string.IsNullOrEmpty(newEmployeeAlias) == true || string.IsNullOrEmpty(newEmployeeEmail) == true)
            {
                MessageBox.Show("All employee's info fields are needed for to creation of a new employe \nCannot save new employee");
            }
            else
            {
                if (string.IsNullOrEmpty(newEmployeeFirstName) == true)
                {
                    MessageBox.Show("First Name is Needed To Create Employee");
                }
                if (string.IsNullOrEmpty(newEmployeeLastName) == true)
                {
                    MessageBox.Show("Last Name is Needed To Create Employee");
                }
                if (string.IsNullOrEmpty(newEmployeeAlias) == true)
                {
                    MessageBox.Show("Alias is Needed To Create Employee");
                }
                if (string.IsNullOrEmpty(newEmployeeEmail) == true)
                {
                    MessageBox.Show("Email is Needed To Create Employee");
                }
                else
                {
                    AdoHelper.InsertNewEmployee(newEmployeeFirstName, newEmployeeLastName, newEmployeeAlias, newEmployeeEmail);
                    txtNewFirstName.Text = string.Empty;
                    txtNewLastName.Text = string.Empty;
                    txtNewAlias.Text = string.Empty;
                    txtNewEmail.Text = string.Empty;

                }
            }

            #endregion
            UpdateEmployeeGridView(grvEmployees);
        }

        private void btnSubmitSkill_Click(object sender, EventArgs e)
        {
            string newSkillName = txtNewSkillName.Text;
            string newBriefDesc = txtNewBriefDesc.Text;
            int selectedrowindex = grvEmployees.SelectedCells[0].RowIndex;
            int employeeIDSkill = 0;
            DataGridViewRow selectedRow = grvEmployees.Rows[selectedrowindex];
            string strID = selectedRow.Cells["EmployeeID"].Value.ToString();

            try
            {
                employeeIDSkill = int.Parse(strID);
            }
            catch (Exception se)
            {
                Console.WriteLine(se.Message);
            }

            #region Check If TextBoxs above are empty

            if (string.IsNullOrEmpty(newSkillName) == true || string.IsNullOrEmpty(newBriefDesc) == true)
            {
                MessageBox.Show("All employee's info fields are needed for to creation of a new employe \n\tCannot save new employee");
            }
            else
            {
                if (string.IsNullOrEmpty(newSkillName) == true)
                {
                    MessageBox.Show("First Name is Needed To Create Employee");
                }
                if (string.IsNullOrEmpty(newBriefDesc) == true)
                {
                    MessageBox.Show("Last Name is Needed To Create Employee");
                }
                else
                {
                    AdoHelper.InsertNewSkill(newSkillName, newBriefDesc, employeeIDSkill);
                    txtNewSkillName.Text = string.Empty;
                    txtNewBriefDesc.Text = string.Empty;
                }
            }


            #endregion
            UpdateEmployeeGridView(grvEmployees);
        }

        private void btnURLSubmit_Click(object sender, EventArgs e)
        {
            string url = txtNewURL.Text;
            int selectedrowindex = grvEmployeesSkills.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = grvEmployeesSkills.Rows[selectedrowindex];
            string txtSkillName = selectedRow.Cells["SkillName"].Value.ToString();
            if (grvEmployeesSkills.SelectedCells.Count > 0)
            {
                int skillInfoID = 0;
                selectedrowindex = grvEmployeesSkills.SelectedCells[0].RowIndex;
                selectedRow = grvEmployeesSkills.Rows[selectedrowindex];
                string str = selectedRow.Cells["SkillID"].Value.ToString();

                try
                {
                    skillInfoID = int.Parse(str);

                }
                catch (Exception se)
                {
                    Console.WriteLine(se.Message);

                }

                if (string.IsNullOrEmpty(url) == true)
                {
                    MessageBox.Show("URL is needed for skill info \n\tCannot save Skill info");
                }
                else
                {
                    try
                    {
                        AdoHelper.InsertNewSkillInfo(url, skillInfoID);
                    }
                    catch (SqlException se)
                    {

                        Console.WriteLine(se.Message);
                    }

                    txtNewSkillName.Text = string.Empty;
                    txtNewBriefDesc.Text = string.Empty;
                    txtNewURL.Clear();
                    UpdateEmployeeGridView(grvEmployees);
                }
            }

        }

        private void btnSubmitRef_Click(object sender, EventArgs e)
        {
            string refFirstNAme = txtRefFirstName.Text;
            string refLastNAme = txtRefLastName.Text;
            string refPosition = txtRefPosition.Text;
            string refEmail = txtRefEmail.Text;
            int selectedrowindex = grvEmployees.SelectedCells[0].RowIndex;
            int employeeID = 0;
            DataGridViewRow selectedRow = grvEmployees.Rows[selectedrowindex];
            string strID = selectedRow.Cells["EmployeeID"].Value.ToString();

            try
            {
                employeeID = int.Parse(strID);
            }
            catch (Exception se)
            {
                Console.WriteLine(se.Message);
            }

            #region Check If TextBoxs above are empty

            if (string.IsNullOrEmpty(refFirstNAme) == true || string.IsNullOrEmpty(refLastNAme) == true || string.IsNullOrEmpty(refPosition) == true || string.IsNullOrEmpty(refEmail) == true)
            {
                MessageBox.Show("All employee's info fields are needed for to creation of a new employe \n\tCannot save new employee");
            }
            else
            {
                if (string.IsNullOrEmpty(refFirstNAme) == true)
                {
                    MessageBox.Show("First Name is Needed To Create Reference");
                }
                if (string.IsNullOrEmpty(refLastNAme) == true)
                {
                    MessageBox.Show("Last Name is Needed To Create Reference");
                }
                if (string.IsNullOrEmpty(refPosition) == true)
                {
                    MessageBox.Show("Position is Needed To Create Reference");
                }
                if (string.IsNullOrEmpty(refEmail) == true)
                {
                    MessageBox.Show("Email is Needed To Create Reference");
                }
                else
                {
                    AdoHelper.InsertNewRefernce(refFirstNAme, refLastNAme, refPosition, refEmail, employeeID);
                    txtRefFirstName.Text = string.Empty;
                    txtRefLastName.Text = string.Empty;
                    txtRefPosition.Text = string.Empty;
                    txtRefEmail.Text = string.Empty;
                }
            }


            #endregion


        }


        #endregion

        #region Update 

        public static void UpdateSkillAndReferenceTextBox(TextBox txtboxSkillAndReference, DataGridView grvEmployeesSkills, int employeeID)
        {
            txtboxSkillAndReference.Clear();
            try
            {

                if (grvEmployeesSkills.SelectedCells.Count > 0)
                {
                    // Get Skill of Employee's ID
                    int selectedrowindex = grvEmployeesSkills.SelectedCells[0].RowIndex;
                    
                    DataGridViewRow selectedRow = grvEmployeesSkills.Rows[selectedrowindex];
                    string txtSkillName = selectedRow.Cells["SkillName"].Value.ToString();
                    string briefDesc = selectedRow.Cells["BriefDescription"].Value.ToString();
                    string skillAndReference = string.Empty;
                    if (grvEmployeesSkills.SelectedCells.Count > 0)
                    {
                        int skillInfoID = 0;
                        selectedrowindex = grvEmployeesSkills.SelectedCells[0].RowIndex;
                        selectedRow = grvEmployeesSkills.Rows[selectedrowindex];
                        string str = selectedRow.Cells["SkillID"].Value.ToString();

                        try
                        {
                            skillInfoID = int.Parse(str);

                        }
                        catch (Exception se)
                        {
                            Console.WriteLine(se.Message);

                        }
                        var newLine = Environment.NewLine;
                        txtboxSkillAndReference.Clear();

                        // Get all the References of the selected employee
                        DataTable ReferHierar = BL.GetClass.Refer.GetAllEmployeeReferences(employeeID);
                        List<string> reference = new List<string>();
                        string empRefer = string.Empty;
                        for (int currentRow = 0; currentRow < ReferHierar.Rows.Count; currentRow++)
                        {
                            for (int currentColumn = 0; currentColumn < ReferHierar.Columns.Count; currentColumn++)
                            {
                                reference.Add(ReferHierar.Rows[currentRow][ReferHierar.Columns[currentColumn]].ToString());
                            }
                        }
                        for (int i = 0; i < reference.Count; i++)
                        {
                            empRefer = "\t" + reference[1] + " " + reference[2] + " " + "Position: " + reference[3] + " " + "Email: " + reference[5];
                        }

                        // Get all the skillinfo Of the select skill
                        DataTable SkillInfoHierar = BL.GetClass.SkillsInfo.GetAllSkilllInfo(skillInfoID);
                        List<string> skillInfolist = new List<string>();
                        string skillInfoStr = string.Empty;
                        if (skillInfolist.Count == 0)
                      {

                        }
                        else { }
                        for (int currentRow = 0; currentRow < SkillInfoHierar.Rows.Count; currentRow++)
                        {
                            for (int currentColumn = 0; currentColumn < SkillInfoHierar.Columns.Count; currentColumn++)
                            {
                                skillInfolist.Add(SkillInfoHierar.Rows[currentRow][SkillInfoHierar.Columns[currentColumn]].ToString());
                            }
                        }
                        for (int i = 0; i < skillInfolist.Count; i++)
                        {
                            skillInfoStr = "\t" + skillInfolist[1];
                        }

                        #region Check if one employee has all the information

                        if (string.IsNullOrEmpty(skillInfoStr) == true && string.IsNullOrEmpty(empRefer) == true)
                        {
                            skillAndReference = "Skill Name: " + txtSkillName +
                                                   newLine + newLine + briefDesc;
                        }
                        else if (string.IsNullOrEmpty(empRefer) == true)
                        {
                            skillAndReference = "Skill Name: " + txtSkillName +
                                                    newLine + newLine + briefDesc + newLine +
                                                    newLine + "Skill Information: " +
                                                    newLine + skillInfoStr;
                        }
                        else if (string.IsNullOrEmpty(skillInfoStr) == true)
                        {
                            skillAndReference = "Skill Name: " + txtSkillName +
                                                    newLine + newLine + briefDesc + newLine +
                                                    newLine + "References: " +
                                                       newLine + empRefer;
                        }
                        else
                        {
                            skillAndReference = "Skill Name: " + txtSkillName +
                                                       newLine + newLine + briefDesc + newLine +
                                                       newLine + "Skill Information: " +
                                                       newLine + skillInfoStr + newLine +
                                                       newLine + "References: " +
                                                       newLine + empRefer;

                        }

                        #endregion

                        txtboxSkillAndReference.Text = skillAndReference;
                    }
                }
            }
            catch (Exception se)
            {

                Console.WriteLine(se.Message); ;
            }


        }

        public static void UpdateEmployeeGridView(DataGridView grvEmployees)
        {
            grvEmployees.Rows.Clear();
            // Create new table of Employees
            DataTable EmployeeHierar = BL.GetClass.Employees.GetAllEmployees();

            foreach (DataRow currentEmployee in EmployeeHierar.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell firstName = new DataGridViewTextBoxCell();
                firstName.Value = currentEmployee["FirstName"];
                row.Cells.Add(firstName);

                DataGridViewTextBoxCell lastName = new DataGridViewTextBoxCell();
                lastName.Value = currentEmployee["LastName"];
                row.Cells.Add(lastName);

                DataGridViewTextBoxCell alias = new DataGridViewTextBoxCell();
                alias.Value = currentEmployee["Alias"];
                row.Cells.Add(alias);

                DataGridViewTextBoxCell eMail = new DataGridViewTextBoxCell();
                eMail.Value = currentEmployee["Email"];
                row.Cells.Add(eMail);

                DataGridViewTextBoxCell employeeID = new DataGridViewTextBoxCell();
                employeeID.Value = currentEmployee["EmployeeID"];
                row.Cells.Add(employeeID);

                grvEmployees.Rows.Add(row);
            }

        }

        public static void UpdateEmployeeGridView(DataGridView grvEmployees, DataTable EmployeeHierar)
        {
            grvEmployees.Rows.Clear();
            // Uses existing EmployeeTable to get data
            foreach (DataRow currentEmployee in EmployeeHierar.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell firstName = new DataGridViewTextBoxCell();
                firstName.Value = currentEmployee["FirstName"];
                row.Cells.Add(firstName);

                DataGridViewTextBoxCell lastName = new DataGridViewTextBoxCell();
                lastName.Value = currentEmployee["LastName"];
                row.Cells.Add(lastName);

                DataGridViewTextBoxCell alias = new DataGridViewTextBoxCell();
                alias.Value = currentEmployee["Alias"];
                row.Cells.Add(alias);

                DataGridViewTextBoxCell eMail = new DataGridViewTextBoxCell();
                eMail.Value = currentEmployee["Email"];
                row.Cells.Add(eMail);

                DataGridViewTextBoxCell employeeID = new DataGridViewTextBoxCell();
                employeeID.Value = currentEmployee["EmployeeID"];
                row.Cells.Add(employeeID);

                grvEmployees.Rows.Add(row);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            UpdateEmployeeGridView(grvEmployees);
        }
        #endregion




    

        }

    }
    



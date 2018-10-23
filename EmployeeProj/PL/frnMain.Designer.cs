namespace EmployeeProj
{
    partial class frnMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grvEmployees = new System.Windows.Forms.DataGridView();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvEmployeesSkills = new System.Windows.Forms.DataGridView();
            this.skillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.briefDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillEmployeesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEmployees = new System.Windows.Forms.GroupBox();
            this.grbSkills = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbNewEmployeeOrSkill = new System.Windows.Forms.TabPage();
            this.grbNewSkill = new System.Windows.Forms.GroupBox();
            this.txtNewSkillName = new System.Windows.Forms.TextBox();
            this.txtNewBriefDesc = new System.Windows.Forms.TextBox();
            this.btnSubmitSkill = new System.Windows.Forms.Button();
            this.lblSkillName = new System.Windows.Forms.Label();
            this.lblBriefDescription = new System.Windows.Forms.Label();
            this.grbNewEmployee = new System.Windows.Forms.GroupBox();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.txtNewAlias = new System.Windows.Forms.TextBox();
            this.txtNewLastName = new System.Windows.Forms.TextBox();
            this.txtNewFirstName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.lblNewLastName = new System.Windows.Forms.Label();
            this.lblNewFirstName = new System.Windows.Forms.Label();
            this.btnSubmitEmployee = new System.Windows.Forms.Button();
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.grbAddReference = new System.Windows.Forms.GroupBox();
            this.btnSubmitRef = new System.Windows.Forms.Button();
            this.txtRefEmail = new System.Windows.Forms.TextBox();
            this.txtRefPosition = new System.Windows.Forms.TextBox();
            this.lblRefEmail = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtRefLastName = new System.Windows.Forms.TextBox();
            this.txtRefFirstName = new System.Windows.Forms.TextBox();
            this.lblRefLastName = new System.Windows.Forms.Label();
            this.lblRefFirstName = new System.Windows.Forms.Label();
            this.grbAddInfo = new System.Windows.Forms.GroupBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtNewURL = new System.Windows.Forms.TextBox();
            this.btnURLSubmit = new System.Windows.Forms.Button();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtboxSkillAndReference = new System.Windows.Forms.TextBox();
            this.lblSkillOrRef = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployeesSkills)).BeginInit();
            this.grbEmployees.SuspendLayout();
            this.grbSkills.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbNewEmployeeOrSkill.SuspendLayout();
            this.grbNewSkill.SuspendLayout();
            this.grbNewEmployee.SuspendLayout();
            this.tpAdd.SuspendLayout();
            this.grbAddReference.SuspendLayout();
            this.grbAddInfo.SuspendLayout();
            this.grbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvEmployees
            // 
            this.grvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grvEmployees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstName,
            this.lastName,
            this.alias,
            this.eMail,
            this.employeeID});
            this.grvEmployees.Location = new System.Drawing.Point(4, 27);
            this.grvEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.grvEmployees.Name = "grvEmployees";
            this.grvEmployees.RowTemplate.Height = 24;
            this.grvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvEmployees.Size = new System.Drawing.Size(464, 311);
            this.grvEmployees.TabIndex = 0;
            this.grvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvEmployees_CellContentClick);
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            this.firstName.Width = 131;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            this.lastName.Width = 129;
            // 
            // alias
            // 
            this.alias.HeaderText = "Alias";
            this.alias.Name = "alias";
            this.alias.ReadOnly = true;
            this.alias.Width = 80;
            // 
            // eMail
            // 
            this.eMail.HeaderText = "Email";
            this.eMail.Name = "eMail";
            this.eMail.ReadOnly = true;
            this.eMail.Width = 85;
            // 
            // employeeID
            // 
            this.employeeID.HeaderText = "Employee ID";
            this.employeeID.Name = "employeeID";
            this.employeeID.ReadOnly = true;
            this.employeeID.Visible = false;
            this.employeeID.Width = 144;
            // 
            // grvEmployeesSkills
            // 
            this.grvEmployeesSkills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grvEmployeesSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEmployeesSkills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skillName,
            this.briefDescription,
            this.skillID,
            this.skillEmployeesID});
            this.grvEmployeesSkills.Location = new System.Drawing.Point(4, 25);
            this.grvEmployeesSkills.Margin = new System.Windows.Forms.Padding(4);
            this.grvEmployeesSkills.Name = "grvEmployeesSkills";
            this.grvEmployeesSkills.RowTemplate.Height = 24;
            this.grvEmployeesSkills.Size = new System.Drawing.Size(464, 298);
            this.grvEmployeesSkills.TabIndex = 1;
            this.grvEmployeesSkills.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvEmployeesSkills_CellContentClick);
            // 
            // skillName
            // 
            this.skillName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.skillName.HeaderText = "Skill Name";
            this.skillName.Name = "skillName";
            this.skillName.ReadOnly = true;
            this.skillName.Width = 118;
            // 
            // briefDescription
            // 
            this.briefDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.briefDescription.HeaderText = "Brief Description";
            this.briefDescription.Name = "briefDescription";
            this.briefDescription.ReadOnly = true;
            this.briefDescription.Width = 166;
            // 
            // skillID
            // 
            this.skillID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.skillID.HeaderText = "Skill ID";
            this.skillID.Name = "skillID";
            this.skillID.ReadOnly = true;
            this.skillID.Visible = false;
            // 
            // skillEmployeesID
            // 
            this.skillEmployeesID.HeaderText = "Employee ID";
            this.skillEmployeesID.Name = "skillEmployeesID";
            this.skillEmployeesID.ReadOnly = true;
            this.skillEmployeesID.Visible = false;
            // 
            // grbEmployees
            // 
            this.grbEmployees.Controls.Add(this.grvEmployees);
            this.grbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grbEmployees.Location = new System.Drawing.Point(11, 15);
            this.grbEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.grbEmployees.Name = "grbEmployees";
            this.grbEmployees.Padding = new System.Windows.Forms.Padding(4);
            this.grbEmployees.Size = new System.Drawing.Size(476, 346);
            this.grbEmployees.TabIndex = 10;
            this.grbEmployees.TabStop = false;
            this.grbEmployees.Text = "Employees (Click to select existing employee)";
            // 
            // grbSkills
            // 
            this.grbSkills.Controls.Add(this.grvEmployeesSkills);
            this.grbSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grbSkills.Location = new System.Drawing.Point(11, 368);
            this.grbSkills.Margin = new System.Windows.Forms.Padding(2);
            this.grbSkills.Name = "grbSkills";
            this.grbSkills.Padding = new System.Windows.Forms.Padding(2);
            this.grbSkills.Size = new System.Drawing.Size(476, 327);
            this.grbSkills.TabIndex = 11;
            this.grbSkills.TabStop = false;
            this.grbSkills.Text = "Skils (Click to get all skill information)";
            this.grbSkills.UseCompatibleTextRendering = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbNewEmployeeOrSkill);
            this.tabControl1.Controls.Add(this.tpAdd);
            this.tabControl1.Location = new System.Drawing.Point(497, 412);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(603, 283);
            this.tabControl1.TabIndex = 12;
            // 
            // tbNewEmployeeOrSkill
            // 
            this.tbNewEmployeeOrSkill.AutoScroll = true;
            this.tbNewEmployeeOrSkill.BackColor = System.Drawing.Color.DarkGray;
            this.tbNewEmployeeOrSkill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbNewEmployeeOrSkill.Controls.Add(this.grbNewSkill);
            this.tbNewEmployeeOrSkill.Controls.Add(this.grbNewEmployee);
            this.tbNewEmployeeOrSkill.Location = new System.Drawing.Point(4, 29);
            this.tbNewEmployeeOrSkill.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewEmployeeOrSkill.Name = "tbNewEmployeeOrSkill";
            this.tbNewEmployeeOrSkill.Padding = new System.Windows.Forms.Padding(2);
            this.tbNewEmployeeOrSkill.Size = new System.Drawing.Size(595, 250);
            this.tbNewEmployeeOrSkill.TabIndex = 1;
            this.tbNewEmployeeOrSkill.Text = "New Employee/Skill";
            // 
            // grbNewSkill
            // 
            this.grbNewSkill.Controls.Add(this.txtNewSkillName);
            this.grbNewSkill.Controls.Add(this.txtNewBriefDesc);
            this.grbNewSkill.Controls.Add(this.btnSubmitSkill);
            this.grbNewSkill.Controls.Add(this.lblSkillName);
            this.grbNewSkill.Controls.Add(this.lblBriefDescription);
            this.grbNewSkill.Location = new System.Drawing.Point(19, 277);
            this.grbNewSkill.Margin = new System.Windows.Forms.Padding(2);
            this.grbNewSkill.Name = "grbNewSkill";
            this.grbNewSkill.Padding = new System.Windows.Forms.Padding(2);
            this.grbNewSkill.Size = new System.Drawing.Size(349, 211);
            this.grbNewSkill.TabIndex = 14;
            this.grbNewSkill.TabStop = false;
            this.grbNewSkill.Text = "New Skill";
            // 
            // txtNewSkillName
            // 
            this.txtNewSkillName.Location = new System.Drawing.Point(18, 56);
            this.txtNewSkillName.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewSkillName.Name = "txtNewSkillName";
            this.txtNewSkillName.Size = new System.Drawing.Size(318, 26);
            this.txtNewSkillName.TabIndex = 12;
            // 
            // txtNewBriefDesc
            // 
            this.txtNewBriefDesc.Location = new System.Drawing.Point(18, 115);
            this.txtNewBriefDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewBriefDesc.Multiline = true;
            this.txtNewBriefDesc.Name = "txtNewBriefDesc";
            this.txtNewBriefDesc.Size = new System.Drawing.Size(318, 52);
            this.txtNewBriefDesc.TabIndex = 13;
            // 
            // btnSubmitSkill
            // 
            this.btnSubmitSkill.Location = new System.Drawing.Point(204, 171);
            this.btnSubmitSkill.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitSkill.Name = "btnSubmitSkill";
            this.btnSubmitSkill.Size = new System.Drawing.Size(132, 27);
            this.btnSubmitSkill.TabIndex = 1;
            this.btnSubmitSkill.Text = "Submit Skill";
            this.btnSubmitSkill.UseVisualStyleBackColor = true;
            this.btnSubmitSkill.Click += new System.EventHandler(this.btnSubmitSkill_Click);
            // 
            // lblSkillName
            // 
            this.lblSkillName.AutoSize = true;
            this.lblSkillName.Location = new System.Drawing.Point(15, 34);
            this.lblSkillName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSkillName.Name = "lblSkillName";
            this.lblSkillName.Size = new System.Drawing.Size(276, 20);
            this.lblSkillName.TabIndex = 5;
            this.lblSkillName.Text = "Short Name Of Skill Or Technology:";
            // 
            // lblBriefDescription
            // 
            this.lblBriefDescription.AutoSize = true;
            this.lblBriefDescription.Location = new System.Drawing.Point(15, 93);
            this.lblBriefDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBriefDescription.Name = "lblBriefDescription";
            this.lblBriefDescription.Size = new System.Drawing.Size(200, 20);
            this.lblBriefDescription.TabIndex = 6;
            this.lblBriefDescription.Text = "Brief Description Of Skill:";
            // 
            // grbNewEmployee
            // 
            this.grbNewEmployee.Controls.Add(this.txtNewEmail);
            this.grbNewEmployee.Controls.Add(this.txtNewAlias);
            this.grbNewEmployee.Controls.Add(this.txtNewLastName);
            this.grbNewEmployee.Controls.Add(this.txtNewFirstName);
            this.grbNewEmployee.Controls.Add(this.lblEmail);
            this.grbNewEmployee.Controls.Add(this.lblAlias);
            this.grbNewEmployee.Controls.Add(this.lblNewLastName);
            this.grbNewEmployee.Controls.Add(this.lblNewFirstName);
            this.grbNewEmployee.Controls.Add(this.btnSubmitEmployee);
            this.grbNewEmployee.Location = new System.Drawing.Point(19, 17);
            this.grbNewEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.grbNewEmployee.Name = "grbNewEmployee";
            this.grbNewEmployee.Padding = new System.Windows.Forms.Padding(2);
            this.grbNewEmployee.Size = new System.Drawing.Size(349, 243);
            this.grbNewEmployee.TabIndex = 13;
            this.grbNewEmployee.TabStop = false;
            this.grbNewEmployee.Text = "New Employee";
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Location = new System.Drawing.Point(105, 122);
            this.txtNewEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewEmail.MaxLength = 50;
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(150, 26);
            this.txtNewEmail.TabIndex = 10;
            // 
            // txtNewAlias
            // 
            this.txtNewAlias.Location = new System.Drawing.Point(105, 92);
            this.txtNewAlias.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewAlias.MaxLength = 50;
            this.txtNewAlias.Name = "txtNewAlias";
            this.txtNewAlias.Size = new System.Drawing.Size(150, 26);
            this.txtNewAlias.TabIndex = 9;
            // 
            // txtNewLastName
            // 
            this.txtNewLastName.Location = new System.Drawing.Point(105, 62);
            this.txtNewLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewLastName.MaxLength = 50;
            this.txtNewLastName.Name = "txtNewLastName";
            this.txtNewLastName.Size = new System.Drawing.Size(150, 26);
            this.txtNewLastName.TabIndex = 8;
            // 
            // txtNewFirstName
            // 
            this.txtNewFirstName.Location = new System.Drawing.Point(105, 30);
            this.txtNewFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewFirstName.MaxLength = 50;
            this.txtNewFirstName.Name = "txtNewFirstName";
            this.txtNewFirstName.Size = new System.Drawing.Size(150, 26);
            this.txtNewFirstName.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(4, 125);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(4, 95);
            this.lblAlias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(51, 20);
            this.lblAlias.TabIndex = 3;
            this.lblAlias.Text = "Alias:";
            // 
            // lblNewLastName
            // 
            this.lblNewLastName.AutoSize = true;
            this.lblNewLastName.Location = new System.Drawing.Point(4, 65);
            this.lblNewLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewLastName.Name = "lblNewLastName";
            this.lblNewLastName.Size = new System.Drawing.Size(96, 20);
            this.lblNewLastName.TabIndex = 2;
            this.lblNewLastName.Text = "Last Name:";
            // 
            // lblNewFirstName
            // 
            this.lblNewFirstName.AutoSize = true;
            this.lblNewFirstName.Location = new System.Drawing.Point(4, 33);
            this.lblNewFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewFirstName.Name = "lblNewFirstName";
            this.lblNewFirstName.Size = new System.Drawing.Size(97, 20);
            this.lblNewFirstName.TabIndex = 1;
            this.lblNewFirstName.Text = "First Name:";
            // 
            // btnSubmitEmployee
            // 
            this.btnSubmitEmployee.Location = new System.Drawing.Point(183, 184);
            this.btnSubmitEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitEmployee.Name = "btnSubmitEmployee";
            this.btnSubmitEmployee.Size = new System.Drawing.Size(152, 32);
            this.btnSubmitEmployee.TabIndex = 0;
            this.btnSubmitEmployee.Text = "Submit Employee";
            this.btnSubmitEmployee.UseVisualStyleBackColor = true;
            this.btnSubmitEmployee.Click += new System.EventHandler(this.btnSubmitEmployee_Click);
            // 
            // tpAdd
            // 
            this.tpAdd.AutoScroll = true;
            this.tpAdd.BackColor = System.Drawing.Color.DarkGray;
            this.tpAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpAdd.Controls.Add(this.grbAddReference);
            this.tpAdd.Controls.Add(this.grbAddInfo);
            this.tpAdd.Location = new System.Drawing.Point(4, 29);
            this.tpAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Size = new System.Drawing.Size(595, 250);
            this.tpAdd.TabIndex = 2;
            this.tpAdd.Text = "Add Info/Reference";
            // 
            // grbAddReference
            // 
            this.grbAddReference.Controls.Add(this.btnSubmitRef);
            this.grbAddReference.Controls.Add(this.txtRefEmail);
            this.grbAddReference.Controls.Add(this.txtRefPosition);
            this.grbAddReference.Controls.Add(this.lblRefEmail);
            this.grbAddReference.Controls.Add(this.lblPosition);
            this.grbAddReference.Controls.Add(this.txtRefLastName);
            this.grbAddReference.Controls.Add(this.txtRefFirstName);
            this.grbAddReference.Controls.Add(this.lblRefLastName);
            this.grbAddReference.Controls.Add(this.lblRefFirstName);
            this.grbAddReference.Location = new System.Drawing.Point(17, 155);
            this.grbAddReference.Margin = new System.Windows.Forms.Padding(2);
            this.grbAddReference.Name = "grbAddReference";
            this.grbAddReference.Padding = new System.Windows.Forms.Padding(2);
            this.grbAddReference.Size = new System.Drawing.Size(350, 218);
            this.grbAddReference.TabIndex = 14;
            this.grbAddReference.TabStop = false;
            this.grbAddReference.Text = "Add Reference Person To Select Employee";
            // 
            // btnSubmitRef
            // 
            this.btnSubmitRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSubmitRef.Location = new System.Drawing.Point(158, 165);
            this.btnSubmitRef.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitRef.Name = "btnSubmitRef";
            this.btnSubmitRef.Size = new System.Drawing.Size(181, 28);
            this.btnSubmitRef.TabIndex = 17;
            this.btnSubmitRef.Text = "Submit Reference";
            this.btnSubmitRef.UseVisualStyleBackColor = true;
            this.btnSubmitRef.Click += new System.EventHandler(this.btnSubmitRef_Click);
            // 
            // txtRefEmail
            // 
            this.txtRefEmail.Location = new System.Drawing.Point(108, 127);
            this.txtRefEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtRefEmail.Name = "txtRefEmail";
            this.txtRefEmail.Size = new System.Drawing.Size(106, 26);
            this.txtRefEmail.TabIndex = 16;
            // 
            // txtRefPosition
            // 
            this.txtRefPosition.Location = new System.Drawing.Point(108, 98);
            this.txtRefPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtRefPosition.Name = "txtRefPosition";
            this.txtRefPosition.Size = new System.Drawing.Size(106, 26);
            this.txtRefPosition.TabIndex = 15;
            // 
            // lblRefEmail
            // 
            this.lblRefEmail.AutoSize = true;
            this.lblRefEmail.Location = new System.Drawing.Point(8, 129);
            this.lblRefEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRefEmail.Name = "lblRefEmail";
            this.lblRefEmail.Size = new System.Drawing.Size(56, 20);
            this.lblRefEmail.TabIndex = 14;
            this.lblRefEmail.Text = "Email:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(7, 98);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(74, 20);
            this.lblPosition.TabIndex = 13;
            this.lblPosition.Text = "Position:";
            // 
            // txtRefLastName
            // 
            this.txtRefLastName.Location = new System.Drawing.Point(107, 65);
            this.txtRefLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRefLastName.Name = "txtRefLastName";
            this.txtRefLastName.Size = new System.Drawing.Size(106, 26);
            this.txtRefLastName.TabIndex = 12;
            // 
            // txtRefFirstName
            // 
            this.txtRefFirstName.Location = new System.Drawing.Point(107, 35);
            this.txtRefFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRefFirstName.Name = "txtRefFirstName";
            this.txtRefFirstName.Size = new System.Drawing.Size(106, 26);
            this.txtRefFirstName.TabIndex = 11;
            // 
            // lblRefLastName
            // 
            this.lblRefLastName.AutoSize = true;
            this.lblRefLastName.Location = new System.Drawing.Point(7, 66);
            this.lblRefLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRefLastName.Name = "lblRefLastName";
            this.lblRefLastName.Size = new System.Drawing.Size(96, 20);
            this.lblRefLastName.TabIndex = 10;
            this.lblRefLastName.Text = "Last Name:";
            // 
            // lblRefFirstName
            // 
            this.lblRefFirstName.AutoSize = true;
            this.lblRefFirstName.Location = new System.Drawing.Point(6, 35);
            this.lblRefFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRefFirstName.Name = "lblRefFirstName";
            this.lblRefFirstName.Size = new System.Drawing.Size(97, 20);
            this.lblRefFirstName.TabIndex = 9;
            this.lblRefFirstName.Text = "First Name:";
            // 
            // grbAddInfo
            // 
            this.grbAddInfo.Controls.Add(this.lblURL);
            this.grbAddInfo.Controls.Add(this.txtNewURL);
            this.grbAddInfo.Controls.Add(this.btnURLSubmit);
            this.grbAddInfo.Location = new System.Drawing.Point(17, 14);
            this.grbAddInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grbAddInfo.Name = "grbAddInfo";
            this.grbAddInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grbAddInfo.Size = new System.Drawing.Size(350, 137);
            this.grbAddInfo.TabIndex = 14;
            this.grbAddInfo.TabStop = false;
            this.grbAddInfo.Text = "Add Info To Current Skill ";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(6, 38);
            this.lblURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(84, 20);
            this.lblURL.TabIndex = 16;
            this.lblURL.Text = "URL/UNC";
            // 
            // txtNewURL
            // 
            this.txtNewURL.Location = new System.Drawing.Point(98, 35);
            this.txtNewURL.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewURL.Name = "txtNewURL";
            this.txtNewURL.Size = new System.Drawing.Size(242, 26);
            this.txtNewURL.TabIndex = 15;
            // 
            // btnURLSubmit
            // 
            this.btnURLSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnURLSubmit.Location = new System.Drawing.Point(232, 68);
            this.btnURLSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnURLSubmit.Name = "btnURLSubmit";
            this.btnURLSubmit.Size = new System.Drawing.Size(108, 28);
            this.btnURLSubmit.TabIndex = 14;
            this.btnURLSubmit.Text = "Submit info";
            this.btnURLSubmit.UseVisualStyleBackColor = true;
            this.btnURLSubmit.Click += new System.EventHandler(this.btnURLSubmit_Click);
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.txtSearch);
            this.grbSearch.Controls.Add(this.btnClear);
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grbSearch.Location = new System.Drawing.Point(497, 294);
            this.grbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Padding = new System.Windows.Forms.Padding(2);
            this.grbSearch.Size = new System.Drawing.Size(603, 114);
            this.grbSearch.TabIndex = 15;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search For Skills";
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleDescription = "";
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtSearch.Location = new System.Drawing.Point(6, 25);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(593, 26);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.Text = "Add Keywords separated by a space. Press <Enter> to search";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.txtSearch_Leave);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(392, 66);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 28);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(503, 66);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 28);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtboxSkillAndReference
            // 
            this.txtboxSkillAndReference.Location = new System.Drawing.Point(497, 42);
            this.txtboxSkillAndReference.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxSkillAndReference.Multiline = true;
            this.txtboxSkillAndReference.Name = "txtboxSkillAndReference";
            this.txtboxSkillAndReference.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxSkillAndReference.Size = new System.Drawing.Size(603, 248);
            this.txtboxSkillAndReference.TabIndex = 13;
            // 
            // lblSkillOrRef
            // 
            this.lblSkillOrRef.AutoSize = true;
            this.lblSkillOrRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSkillOrRef.Location = new System.Drawing.Point(493, 15);
            this.lblSkillOrRef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSkillOrRef.Name = "lblSkillOrRef";
            this.lblSkillOrRef.Size = new System.Drawing.Size(137, 20);
            this.lblSkillOrRef.TabIndex = 14;
            this.lblSkillOrRef.Text = "Skill/Reference";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1006, 722);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 28);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frnMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 763);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSkillOrRef);
            this.Controls.Add(this.txtboxSkillAndReference);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grbSkills);
            this.Controls.Add(this.grbEmployees);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frnMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.frnMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployeesSkills)).EndInit();
            this.grbEmployees.ResumeLayout(false);
            this.grbSkills.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbNewEmployeeOrSkill.ResumeLayout(false);
            this.grbNewSkill.ResumeLayout(false);
            this.grbNewSkill.PerformLayout();
            this.grbNewEmployee.ResumeLayout(false);
            this.grbNewEmployee.PerformLayout();
            this.tpAdd.ResumeLayout(false);
            this.grbAddReference.ResumeLayout(false);
            this.grbAddReference.PerformLayout();
            this.grbAddInfo.ResumeLayout(false);
            this.grbAddInfo.PerformLayout();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvEmployees;
        private System.Windows.Forms.DataGridView grvEmployeesSkills;
        private System.Windows.Forms.GroupBox grbEmployees;
        private System.Windows.Forms.GroupBox grbSkills;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbNewEmployeeOrSkill;
        private System.Windows.Forms.TabPage tpAdd;
        private System.Windows.Forms.GroupBox grbNewEmployee;
        private System.Windows.Forms.GroupBox grbNewSkill;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtNewURL;
        private System.Windows.Forms.Button btnURLSubmit;
        private System.Windows.Forms.GroupBox grbAddReference;
        private System.Windows.Forms.GroupBox grbAddInfo;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNewSkillName;
        private System.Windows.Forms.TextBox txtNewBriefDesc;
        private System.Windows.Forms.Button btnSubmitSkill;
        private System.Windows.Forms.Label lblSkillName;
        private System.Windows.Forms.Label lblBriefDescription;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.TextBox txtNewAlias;
        private System.Windows.Forms.TextBox txtNewLastName;
        private System.Windows.Forms.TextBox txtNewFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Label lblNewLastName;
        private System.Windows.Forms.Label lblNewFirstName;
        private System.Windows.Forms.Button btnSubmitEmployee;
        private System.Windows.Forms.Button btnSubmitRef;
        private System.Windows.Forms.TextBox txtRefEmail;
        private System.Windows.Forms.TextBox txtRefPosition;
        private System.Windows.Forms.Label lblRefEmail;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtRefLastName;
        private System.Windows.Forms.TextBox txtRefFirstName;
        private System.Windows.Forms.Label lblRefLastName;
        private System.Windows.Forms.Label lblRefFirstName;
        private System.Windows.Forms.TextBox txtboxSkillAndReference;
        private System.Windows.Forms.Label lblSkillOrRef;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn alias;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn briefDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillEmployeesID;
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace EmployeeProj.DB
{
    public class InitiClass
    {
        public static void StarUP()
        {
            SqlConnection sqlCon = new SqlConnection();
            string conStr = ConfigurationManager.ConnectionStrings["EmployeesConStr"].ConnectionString;
            int testCon = 0;
            sqlCon.ConnectionString = conStr;
            /* A Try/Catch execption to check if EmployeeDB was already created */
            try
            {
                sqlCon.Open();
            }
            catch (SqlException se)
                {
                    testCon = 1;
                    Console.WriteLine("Eror connectiong to DB: \n{0}", se.Message);
                }
            sqlCon.Close();
            switch (testCon)
            {
                case 0:
                    break;
                case 1:
                    sqlCon.Close();

                    StartEmploye();
                    break;
            }
        }

        public static void StartEmploye()
        {
            using (EmpContext empContext = new EmpContext())
            {
                #region Creation
                
                Employee employee1 = new Employee() { FirstName = "Dave S." ,LastName = "Kremni",Alias = "Don" ,Email = "DsK@Gmail.com" };
                Employee employee2 = new Employee() { FirstName = "Alex" ,LastName = "Harsh Kremni" ,Alias = "Roza" ,Email = "AHK@Gmail.com" };
                Employee employee3 = new Employee() { FirstName = "Danny" ,LastName = "Middle" ,Alias = "Alona" ,Email = "DM@Gmail.com" };
                Employee employee4 = new Employee() { FirstName = "Alona" ,LastName = "Bach" ,Alias = "Danny" ,Email = "AB@Gmail.com" };
                Employee employee5 = new Employee() { FirstName = "Ori" ,LastName = "Edel" ,Alias = "Jonny" ,Email = "OE@Gmail.com" };
                Employee employee6 = new Employee() { FirstName = "Jonny" ,LastName = "Ben Shab" ,Alias = "Ori" ,Email = "JBS@Gmail.com" };
                Employee employee7 = new Employee() { FirstName = "Almog" ,LastName = "Yehoda" ,Alias = "Liraz"  ,Email = "AY@Gmail.com" };
                Employee employee8 = new Employee() { FirstName = "Ruth" ,LastName = "Gadliahu K"  ,Alias = "Ori" ,Email = "RGK@Gmail.com" };
                Employee employee9 = new Employee() { FirstName = "Vitali" ,LastName = "Elizar" ,Email = "VE@Gmail.com" };
                Employee employee10 = new Employee() { FirstName = "Daniel" ,LastName = "Wiensttein", Alias = "Dave" ,Email = "DW@Gmail.com" };
                Employee employee11 = new Employee() { FirstName = "Shanon" ,LastName = "Bar" ,Email = "SB@Gmail.com" };
                Skill skill1 = new Skill() { SkillName = "Snowboarding", BriefDescription = "Snowboarding is a recreational activity and Olympic and Paralympic sport that involves descending a snow-covered slope while standing on a snowboard attached to a rider's feet. The development of snowboarding was inspire by skateboarding, sledding, surfing and skiing. It was developed in the United States in the 1960s, became a Winter Olympic Sport at Nagano in 1998 and first featured in the Winter Paralympics at Sochi in 2014. Its popularity (as measured by equipment sales) in the United States peaked in 2007 and has been in a decline since", EmployeeID = 2 };
                Skill skill2 = new Skill() { SkillName = "Gamer", BriefDescription = "A dude that playes a lot of video games", EmployeeID = 3 };
                Skill skill3 = new Skill() { SkillName = "Gamer", BriefDescription = "A dude that playes a lot of video games", EmployeeID = 1 };
                Skill skill4 = new Skill() { SkillName = "Desgining jewlary", BriefDescription = "The Crafting and making of jewlary", EmployeeID = 2 };
                Skill skill5 = new Skill() { SkillName = "Bicycle mechanic", BriefDescription = "The best and awsome bicycle maehanic i've ever met", EmployeeID =  9};
                Skill skill6 = new Skill() { SkillName = "Bartender", BriefDescription = "A bartender (also known as a barkeep, barman, barmaid, bar chef, tapster, mixologist, alcohol server, flairman or an alcohol chef) is a person who formulates and serves alcoholic or soft drink beverages behind the bar, usually in a licensed establishment. Bartenders also usually maintain the supplies and inventory for the bar. A bartender can generally mix classic cocktails such as a Cosmopolitan, Manhattan, Old Fashioned, and Mojito. The bartending profession was generally a second occupation, used as transitional work for students to gain customer experience or to save money for university fees. This however is changing around the world and bartending has become a profession by choice rather than necessity. Cocktail competitions such as World Class and Bacardi Legacy have recognised talented bartenders in the past decade and these bartenders, and others, spread the love of cocktails and hospitality throughout the world. Bartenders are also usually responsible for confirming that customers meet the legal drinking age requirements before serving them alcoholic beverages. In certain countries, such as the United Kingdom and Sweden, bartenders are legally required to refuse more alcohol to drunk customers.", EmployeeID = 1 };
                Skill skill7 = new Skill() { SkillName = "Bartender", BriefDescription = "A bartender (also known as a barkeep, barman, barmaid, bar chef, tapster, mixologist, alcohol server, flairman or an alcohol chef) is a person who formulates and serves alcoholic or soft drink beverages behind the bar, usually in a licensed establishment. Bartenders also usually maintain the supplies and inventory for the bar. A bartender can generally mix classic cocktails such as a Cosmopolitan, Manhattan, Old Fashioned, and Mojito. The bartending profession was generally a second occupation, used as transitional work for students to gain customer experience or to save money for university fees. This however is changing around the world and bartending has become a profession by choice rather than necessity. Cocktail competitions such as World Class and Bacardi Legacy have recognised talented bartenders in the past decade and these bartenders, and others, spread the love of cocktails and hospitality throughout the world. Bartenders are also usually responsible for confirming that customers meet the legal drinking age requirements before serving them alcoholic beverages. In certain countries, such as the United Kingdom and Sweden, bartenders are legally required to refuse more alcohol to drunk customers.", EmployeeID = 10 };
                Skill skill8 = new Skill() { SkillName = "Doctor", BriefDescription = "A physician, medical practitioner, medical doctor, or simply doctor is a professional who practises medicine, which is concerned with promoting, maintaining, or restoring health through the study, diagnosis, and treatment of disease, injury, and other physical and mental impairments. Physicians may focus their practice on certain disease categories, types of patients and methods of treatment—known as specialities—or they may assume responsibility for the provision of continuing and comprehensive medical care to individuals, families, and communities—known as general practice. Medical practice properly requires both a detailed knowledge of the academic disciplines (such as anatomy and physiology) underlying diseases and their treatment—the science of medicine—and also a decent competence in its applied practice—the art or craft of medicine. ", EmployeeID = 8 };
                Skill skill9 = new Skill() { SkillName = "Photography", BriefDescription = "Photography is the science, art, application and practice of creating durable images by recording light or other electromagnetic radiation, either electronically by means of an image sensor, or chemically by means of a light-sensitive material such as photographic film. Typically, a lens is used to focus the light reflected or emitted from objects into a real image on the light-sensitive surface inside a camera during a timed exposure. With an electronic image sensor, this produces an electrical charge at each pixel, which is electronically processed and stored in a digital image file for subsequent display or processing. The result with photographic emulsion is an invisible latent image, which is later chemically 'developed' into a visible image, either negative or positive depending on the purpose of the photographic material and the method of processing. A negative image on film is traditionally used to photographically create a positive image on a paper base, known as a print, either by using an enlarger or by contact printing. Photography is employed in many fields of science, manufacturing (e.g., photolithography), and business, as well as its more direct uses for art, film and video production, recreational purposes, hobby, and mass communication.", EmployeeID = 5 };
                Skill skill10 = new Skill() { SkillName = "Marketing", BriefDescription = "Marketing is the study and management of exchange relationships. Marketing is used to create, keep and satisfy the customer. With the customer as the focus of its activities, it can be concluded that Marketing is one of the premier components of Business Management - the other being Innovation.", EmployeeID = 3 };
                Skill skill11 = new Skill() { SkillName = "Teacher", BriefDescription = "A teacher (also called a school teacher or, in some contexts, an educator) is a person who helps others to acquire knowledge, competences or values. Informally the role of teacher may be taken on by anyone (e.g. when showing a colleague how to perform a specific task). In some countries, teaching young people of school age may be carried out in an informal setting, such as within the family, (homeschooling) rather than in a formal setting such as a school or college. Some other professions may involve a significant amount of teaching (e.g. youth worker, pastor).In most countries, formal teaching of students is usually carried out by paid professional teachers.", EmployeeID = 7 };
                SkillsInfo sInfo1 = new SkillsInfo() { SkillID = 1, URL = "https://en.wikipedia.org/wiki/Snowboarding" };
                SkillsInfo sInfo2 = new SkillsInfo() { SkillID = 5, URL = "https://en.wikipedia.org/wiki/Bicycle_mechanic" };
                SkillsInfo sInfo3 = new SkillsInfo() { SkillID = 6 , URL = "https://en.wikipedia.org/wiki/Bartender" };
                SkillsInfo sInfo4 = new SkillsInfo() { SkillID = 7, URL = "https://en.wikipedia.org/wiki/Bartender" };
                SkillsInfo sInfo5 = new SkillsInfo() { SkillID = 8, URL = "https://en.wikipedia.org/wiki/Physician" };
                SkillsInfo sInfo8 = new SkillsInfo() { SkillID = 9, URL = "https://en.wikipedia.org/wiki/Photography" };
                SkillsInfo sInfo6 = new SkillsInfo() { SkillID = 10, URL = "https://en.wikipedia.org/wiki/Marketing" };
                SkillsInfo sInfo7 = new SkillsInfo() { SkillID = 11, URL = "https://en.wikipedia.org/wiki/Teacher" };
                EmployeesReferences refer1 = new EmployeesReferences() { EmployeeID = 1, FirstName ="Don", LastName = "Kremni", Email = "DK@Gmail.com ", Position = "Father", Alias = "Dave" };
                EmployeesReferences refer2 = new EmployeesReferences() { EmployeeID = 2, FirstName ="Roza", LastName = "Harsh", Email = "RH@gmaiol.com", Position = "Mother", Alias = "Alex" };
                EmployeesReferences refer3 = new EmployeesReferences() { EmployeeID = 3, FirstName ="Alona", LastName = "Bach", Email = "AB@Gmail.com", Position = "Army", Alias = "Danny" };
                EmployeesReferences refer4 = new EmployeesReferences() { EmployeeID = 4, FirstName ="Danny", LastName = "Midle", Email = "DM@Gmail.com", Position = "Markting", Alias = "Alona" };
                EmployeesReferences refer5 = new EmployeesReferences() { EmployeeID = 5, FirstName ="Ori", LastName = "Edel", Email = "OE@Gmail.com", Position = "Photographer", Alias = "Jhony" };
                EmployeesReferences refer6 = new EmployeesReferences() { EmployeeID = 6, FirstName ="Johny", LastName = "Ben Shab", Email = "JBS@Gmail.com", Position = "Friend", Alias = "Ori" };
                EmployeesReferences refer7 = new EmployeesReferences() { EmployeeID = 7, FirstName ="Ruth", LastName = "Galiahu K", Email = "RGK@Gmail.com", Position = "Doctor", Alias = "Dave" };
                EmployeesReferences refer8 = new EmployeesReferences() { EmployeeID = 8, FirstName ="Vitali", LastName = "Elizar", Email = "VE@Gmail.com", Position = "Mechanic", Alias = "Ori" };
                #endregion

                #region Adding all the data from the Cretion region to Empcontext

                empContext.Employees.Add(employee1);
                empContext.Employees.Add(employee2);
                empContext.Employees.Add(employee3);
                empContext.Employees.Add(employee4);
                empContext.Employees.Add(employee5);
                empContext.Employees.Add(employee6);
                empContext.Employees.Add(employee7);
                empContext.Employees.Add(employee8);
                empContext.Employees.Add(employee9);
                empContext.Employees.Add(employee10);
                empContext.Employees.Add(employee11);
                empContext.Skills.Add(skill1);
                empContext.Skills.Add(skill2);
                empContext.Skills.Add(skill3);
                empContext.Skills.Add(skill4);
                empContext.Skills.Add(skill5);
                empContext.Skills.Add(skill6);
                empContext.Skills.Add(skill7);
                empContext.Skills.Add(skill8);
                empContext.Skills.Add(skill9);
                empContext.Skills.Add(skill10);
                empContext.Skills.Add(skill11);
                empContext.SkillsInfo.Add(sInfo1);
                empContext.SkillsInfo.Add(sInfo2);
                empContext.SkillsInfo.Add(sInfo3);
                empContext.SkillsInfo.Add(sInfo4);
                empContext.SkillsInfo.Add(sInfo5);
                empContext.SkillsInfo.Add(sInfo6);
                empContext.SkillsInfo.Add(sInfo7);
                empContext.EmployeesReferences.Add(refer1);
                empContext.EmployeesReferences.Add(refer2);
                empContext.EmployeesReferences.Add(refer3);
                empContext.EmployeesReferences.Add(refer4);
                empContext.EmployeesReferences.Add(refer5);
                empContext.EmployeesReferences.Add(refer6);
                empContext.EmployeesReferences.Add(refer7);
                empContext.EmployeesReferences.Add(refer8);

                #endregion

                try
                {
                    empContext.SaveChanges();
                    Console.WriteLine("EmployeeDB created");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
     

    
    }
}
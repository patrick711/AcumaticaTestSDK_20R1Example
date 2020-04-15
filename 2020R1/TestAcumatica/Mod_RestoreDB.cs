using Core.Config;
using Core.Core.Browser;
using Core.Login;
using Core.TestExecution;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAcumatica.Extensions;
using static TestAcumatica.Objects;
/***************************
Mod_RestoreDB - This class encapsulates the process of restoring Acumatica instance to clean state
1. Unpublish customizations to remove Web elements
2. Restore db backup
3. Log into the site
Patrick Chen SPS Commerce
04-2020
***************************/

namespace TestAcumatica
{
    class Mod_RestoreDB
    {
        public virtual void ResetSite(InputVars myVars)
        {

            Console.WriteLine("- UnPublish Customizations");
            
            using (TestExecution.CreateTestCaseGroup("UnPublish Customizations"))
            {

                string dir = Directory.GetCurrentDirectory();
                CustomizationMgr myMgr = new CustomizationMgr();
                myMgr.OpenScreen();
                myMgr.ActionUndoPublish();

            }

            using (TestExecution.CreateTestCaseGroup("Restore fresh database"))
            {
                Console.WriteLine("- Restore SQL DB");
                DatabaseOperations db = new DatabaseOperations();
                db.RestoreDB(myVars.sQLServerName, myVars.databaseName, myVars.backupLocation);
            }

            using (TestExecution.CreateTestStepGroup("Sign in"))
            {
                Console.WriteLine("Logging into " + Config.SITE_DST_URL);
                Browser.StartingUrl =Config.SITE_DST_URL;
                PxLogin LoginPage = new PxLogin();

                String login = Config.SITE_DST_LOGIN;
                String company = "";
                int location = login.IndexOf("@");
                if (location > 0)
                {

                    company = login.Substring(location + 1);
                    login = login.Substring(0, location);
                }

                LoginPage.Username.Type(login);
                LoginPage.Password.Type(Config.SITE_DST_PASSWORD);
                if (company != "")
                    LoginPage.CompanyId.SelectValue(company);
                LoginPage.SignIn.Click();
                Console.WriteLine("You have successfully logged into Acumatica.");
            }
            
        }
    }
}

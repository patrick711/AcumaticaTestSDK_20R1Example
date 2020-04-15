using Core.Config;
using Core.Core.Browser;
using Core.Login;
using Core.TestExecution;
using System;
/***************************
BeforeAndAfter - Codebase that will bookend your Automated Test
Patrick Chen SPS Commerce
04-2020
***************************/

namespace TestAcumatica
{
    public class BeforeAndAfter : Check
    {
        private DateTime startTime = DateTime.Now;
        #region Before and After
        //This method executes before the test.
        public override void BeforeExecute()
        {
            using (TestExecution.CreateTestCaseGroup("Preparation"))
            {
                using (TestExecution.CreateTestStepGroup("Sign in"))
                {
                    Console.WriteLine("\n************************");
                    Console.WriteLine("\nWelcome, you are executing Test: '" + this.ToString() + "' for site " + Config.SITE_DST_URL);

                    Console.WriteLine("\n Time: " + startTime.ToString());
                    Console.WriteLine("\n************************");
                    Browser.StartingUrl = Config.SITE_DST_URL;
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

        //This method executes after the test.
        public override void AfterExecute()
        {
            using (TestExecution.CreateTestCaseGroup("Finalization"))
            {
                using (TestExecution.CreateTestStepGroup("Sign out and close the browser."))
                {
                    //Companies Companies = new Companies();
                    //Companies.OpenScreen();
                    //Companies.LogOut();

                    DateTime endTime = DateTime.Now;
                    int seconds = (int)endTime.Subtract(startTime).TotalSeconds;
                    int minutes = seconds / 60;
                    seconds = seconds % 60;
                    Console.WriteLine("\n************************");
                    Console.WriteLine("Test End. Logging out.");
                    Console.WriteLine("\n Time: " + endTime.ToString());
                    Console.WriteLine("\n Elapsed Time: " + minutes.ToString() + " mins & " + seconds.ToString() + " seconds");

                    Console.WriteLine("\n************************");
                    Browser.Stop();
                }

            }
        }
        #endregion

    }
}

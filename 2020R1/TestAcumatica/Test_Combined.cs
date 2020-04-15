using Core.Config;
using Core.TestExecution;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestAcumatica.Objects;
/***************************
Test_Combined - Control object that runs when the test is executed

Patrick Chen SPS Commerce
04-2020
***************************/

namespace TestAcumatica
{
    class Test_Combined: BeforeAndAfter
    {

        public override void Execute()
        {
            #region Setup and display Variables

            //Vars
            String sConfig = Config.SITE_SRC_LOGIN.ToString(); // get Inputs
            InputVars myVars = new InputVars();
            Mod_SetupVars dispVars = new Mod_SetupVars();
            dispVars.Setup(sConfig, ref myVars);


            #endregion

            #region Unpublish and Restore
            if (myVars.restore)
            {


                if (String.IsNullOrEmpty(myVars.sQLServerName) || String.IsNullOrEmpty(myVars.databaseName) || string.IsNullOrEmpty(myVars.backupLocation))
                    throw new Exception("Not enough inputs to attempt Restore");

                if (!File.Exists(myVars.backupLocation.ToString()))
                {
                    Console.WriteLine("Backup file not found!  " + myVars.backupLocation.ToString());
                    throw new Exception("Backup File not found!");
                }
                Mod_RestoreDB restore = new Mod_RestoreDB();
                restore.ResetSite(myVars);
            }
            #endregion

        }
    }
}

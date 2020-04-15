using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestAcumatica.Objects;
/***************************
Mod_SetupVars - Codebase that will tale config inputs and create variable object
Patrick Chen SPS Commerce
04-2020
***************************/


namespace TestAcumatica
{
    public class Mod_SetupVars

    { 
        public virtual void Setup(String Config, ref InputVars myVars)
        {
            string[] Creds = Config.Split(';');
            myVars.buildName = Creds[0] != null ? Creds[0].Trim() : "";
            myVars.userName = Creds[1] != null ? Creds[1].Trim() : "";
            myVars.password = Creds[2] != null ? Creds[2].Trim() : "";
            myVars.uRL = Creds[3] != null ? Creds[3].Trim() : "";

            myVars.restore = Creds[4] != null ? Convert.ToBoolean(Creds[4].ToString()) : false;
            myVars.sQLServerName = Creds[5] != null ? Creds[5].Trim() : "";
            myVars.databaseName = Creds[6] != null ? Creds[6].Trim() : "";
            myVars.backupLocation = Creds[7] != null ? Creds[7].Trim() : "";

            myVars.regresionSetups = Creds[8] != null ? Convert.ToBoolean(Creds[8].ToString()) : false;
            myVars.publish = Creds[9] != null ? Convert.ToBoolean(Creds[9].ToString()) : false;
            myVars.testXrefs = Creds[10] != null ? Convert.ToBoolean(Creds[10].ToString()) : false;
            myVars.testCustomer = Creds[11] != null ? Convert.ToBoolean(Creds[11].ToString()) : false;
            myVars.shipmentType = Creds[12] != null ? Creds[12].Trim() : "";
            myVars.printLabels = Creds[13] != null ? Convert.ToBoolean(Creds[13].ToString()) : false;
            myVars.processShipments = Creds[14] != null ? Convert.ToBoolean(Creds[14].ToString()) : false;
            myVars.testVendor = Creds[15] != null ? Convert.ToBoolean(Creds[15].ToString()) : false;

            Console.WriteLine("-------------");
            Console.WriteLine(" Test Inputs");
            string[] varNames = myVars.varNames.Split(';');
            int count = 0;
            foreach (string var in varNames)
            {
                Console.WriteLine(var + " : " + Creds[count].Trim());
                count++;
            }
            Console.WriteLine("-------------");

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************
Objects - Variable Object definition
Patrick Chen SPS Commerce
04-2020
***************************/

namespace TestAcumatica
{
    public class Objects
    {
        public class InputVars
        {
	        //<!--0. Build-->my_customization;
	        //<!--1. custom username-->my_username;
	        //<!--2. custom password-->my_password;
	        //<!--3. CLOUD URL-->https://my_url;
	        //<!--4. Restore?-->true;
	        //<!--5. SQL ServerName -->my_computer;
	        //<!--6. DatabaseName-->Acumatica19R2T;
	        //<!--7. Backup Location-->C:\\SQLBackups\\Acumatica19R2T.bak;
	        //<!--8. Regression Setups?-->true;
	        //<!--9. Do you want the test to publish the customization-->true;
	        //<!--10. Do you want to test Xrefs? -->true;
	        //<!--11. Do you want to test Customer side-->true; 
		       // <!--12. The Shipment Type for your shipment-->TypeTwo;
		       // <!--13. Do you want the test to print Labels?-->false;
		       // <!--14. T for create Shipments by Process Shipments or F for manual creation from Shipment Entry-->true;
	        //<!--15. Do you want to test Vendor side?-->false;
            public string buildName = "";
            public string userName = "";
            public string password = "";
            public string uRL = "";
            public bool restore = false;
            public string sQLServerName = "";
            public string databaseName = "";
            public string backupLocation = "";
            public bool regresionSetups = false;
            public bool publish = false;
            public bool testXrefs = false;
            public bool testCustomer = false;
            public string shipmentType = "";
            public bool printLabels = false;
            public bool processShipments = false;
            public bool testVendor = false;

            public string varNames = "Build;UserName;Password;URL;Restore?;SQL Server Name;Database Name;Backup Location;Regression Setup?;Publish?;Test Xrefs?;" +
                "Test Customer?;Shipment Type;Print Labels?;Use Process Shipments?;Test Vendor?";

            //Extra Vars
            public string customer = "";
            public string vendor = "";
            public string inventoryID = "";

        }
    }
}

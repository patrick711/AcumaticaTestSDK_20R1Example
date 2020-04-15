using GeneratedWrappers.Acumatica;

namespace TestAcumatica.Extensions
{
    class APVendor : AP303000_VendorMaint
    {
        public c_baccount_baccount Form
        {
            get
            {
                return base.BAccount_BAccount;
            }
        }

        public c_currentvendor_tab details
        {
            get { return base.CurrentVendor_tab; }
        }

        public c_deflocation_deflocation ship
        {
            get { return base.DefLocation_DefLocation; }
        }

        public c_currentvendor_deflocationpayment payment
        {
            get { return base.CurrentVendor_DefLocationPayment; }
        }
    }
}

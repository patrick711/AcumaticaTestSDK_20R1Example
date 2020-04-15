using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.EmailEdit;
using Controls.Editors.LinkEdit;
using Controls.Editors.Selector;
using Controls.FileColumnButton;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.Grid.Upload;
using Controls.Input;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.NoteColumnButton;
using Controls.PxControlCollection;
using Controls.RichTextEdit;
using Controls.ToolBarButton;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace GeneratedWrappers.Acumatica
{
    
    
    public class AP303000_VendorMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
        protected c_baccount_baccount BAccount_BAccount { get; } = new c_baccount_baccount("ctl00_phF_BAccount", "BAccount_BAccount");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_defaddress_defaddress DefAddress_DefAddress { get; } = new c_defaddress_defaddress("ctl00_phG_tab_t0_DefAddress", "DefAddress_DefAddress");
        protected c_remitaddress_remitaddress RemitAddress_RemitAddress { get; } = new c_remitaddress_remitaddress("ctl00_phG_tab_t1_DefLocationPayment_RemitAddress", "RemitAddress_RemitAddress");
        protected c_defcontact_defcontact DefContact_DefContact { get; } = new c_defcontact_defcontact("ctl00_phG_tab_t0_DefContact", "DefContact_DefContact");
        protected c_defcontact_edcontactgdpr DefContact_edContactGDPR { get; } = new c_defcontact_edcontactgdpr("ctl00_phG_tab_t0_edContactGDPR", "DefContact_edContactGDPR");
        protected c_deflocationcontact_deflocationcontact DefLocationContact_DefLocationContact { get; } = new c_deflocationcontact_deflocationcontact("ctl00_phG_tab_t2_DefLocation_DefLocationContact", "DefLocationContact_DefLocationContact");
        protected c_remitcontact_remitcontact RemitContact_RemitContact { get; } = new c_remitcontact_remitcontact("ctl00_phG_tab_t1_DefLocationPayment_RemitContact", "RemitContact_RemitContact");
        protected c_locations_grdlocations Locations_grdLocations { get; } = new c_locations_grdlocations("ctl00_phG_tab_t3_grdLocations", "Locations_grdLocations");
        protected c_locations_lv0 Locations_lv0 { get; } = new c_locations_lv0("ctl00_phG_tab_t3_grdLocations_lv0", "Locations_lv0");
        protected c_deflocation_deflocationpayment DefLocation_DefLocationPayment { get; } = new c_deflocation_deflocationpayment("ctl00_phG_tab_t1_DefLocationPayment", "DefLocation_DefLocationPayment");
        protected c_currentvendor_deflocationpayment CurrentVendor_DefLocationPayment { get; } = new c_currentvendor_deflocationpayment("ctl00_phG_tab_t1_DefLocationPayment", "CurrentVendor_DefLocationPayment");
        protected c_deflocation_deflocation DefLocation_DefLocation { get; } = new c_deflocation_deflocation("ctl00_phG_tab_t2_DefLocation", "DefLocation_DefLocation");
        protected c_deflocation_deflocationglaccounts DefLocation_DefLocationGLAccounts { get; } = new c_deflocation_deflocationglaccounts("ctl00_phG_tab_t7_DefLocationGLAccounts", "DefLocation_DefLocationGLAccounts");
        protected c_deflocation_formretainage DefLocation_formRetainage { get; } = new c_deflocation_formretainage("ctl00_phG_tab_t7_formRetainage", "DefLocation_formRetainage");
        protected c_extcontacts_grdcontacts ExtContacts_grdContacts { get; } = new c_extcontacts_grdcontacts("ctl00_phG_tab_t4_grdContacts", "ExtContacts_grdContacts");
        protected c_extcontacts_lv0 ExtContacts_lv0 { get; } = new c_extcontacts_lv0("ctl00_phG_tab_t4_grdContacts_lv0", "ExtContacts_lv0");
        protected c_paymentdetails_grdpaymentdetails PaymentDetails_grdPaymentDetails { get; } = new c_paymentdetails_grdpaymentdetails("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails", "PaymentDetails_grdPaymentDetails");
        protected c_paymentdetails_lv0 PaymentDetails_lv0 { get; } = new c_paymentdetails_lv0("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lv0", "PaymentDetails_lv0");
        protected c_vendorbalance_vendorbalance VendorBalance_VendorBalance { get; } = new c_vendorbalance_vendorbalance("ctl00_phF_BAccount_t0_VendorBalance", "VendorBalance_VendorBalance");
        protected c_notificationsources_gridns NotificationSources_gridNS { get; } = new c_notificationsources_gridns("ctl00_phG_tab_t9_sp1_gridNS", "NotificationSources_gridNS");
        protected c_notificationsources_lv0 NotificationSources_lv0 { get; } = new c_notificationsources_lv0("ctl00_phG_tab_t9_sp1_gridNS_lv0", "NotificationSources_lv0");
        protected c_notificationrecipients_gridnr NotificationRecipients_gridNR { get; } = new c_notificationrecipients_gridnr("ctl00_phG_tab_t9_sp1_gridNR", "NotificationRecipients_gridNR");
        protected c_notificationrecipients_lv0 NotificationRecipients_lv0 { get; } = new c_notificationrecipients_lv0("ctl00_phG_tab_t9_sp1_gridNR_lv0", "NotificationRecipients_lv0");
        protected c_activities_activities_grid Activities_Activities_grid { get; } = new c_activities_activities_grid("ctl00_phG_tab_t6_gridActivities_Activities_grid", "Activities_Activities_grid");
        protected c_activities_lv0 Activities_lv0 { get; } = new c_activities_lv0("ctl00_phG_tab_t6_gridActivities_Activities_grid_lv0", "Activities_lv0");
        protected c_activities_preview_activities_form Activities_Preview_Activities_form { get; } = new c_activities_preview_activities_form("ctl00_phG_tab_t6_gridActivities_Activities_form", "Activities$Preview_Activities_form");
        protected c_answers_pxgridanswers Answers_PXGridAnswers { get; } = new c_answers_pxgridanswers("ctl00_phG_tab_t5_PXGridAnswers", "Answers_PXGridAnswers");
        protected c_answers_lv0 Answers_lv0 { get; } = new c_answers_lv0("ctl00_phG_tab_t5_PXGridAnswers_lv0", "Answers_lv0");
        protected c_suppliedbyvendors_pxgridsuppliedbyvendors SuppliedByVendors_PXGridSuppliedByVendors { get; } = new c_suppliedbyvendors_pxgridsuppliedbyvendors("ctl00_phG_tab_t10_PXGridSuppliedByVendors", "SuppliedByVendors_PXGridSuppliedByVendors");
        protected c_suppliedbyvendors_lv0 SuppliedByVendors_lv0 { get; } = new c_suppliedbyvendors_lv0("ctl00_phG_tab_t10_PXGridSuppliedByVendors_lv0", "SuppliedByVendors_lv0");
        protected c_currentvendor_tab CurrentVendor_tab { get; } = new c_currentvendor_tab("ctl00_phG_tab", "CurrentVendor_tab");
        protected c_baccount_tab BAccount_tab { get; } = new c_baccount_tab("ctl00_phG_tab", "BAccount_tab");
        protected c_changeiddialog_formchangeid ChangeIDDialog_formChangeID { get; } = new c_changeiddialog_formchangeid("ctl00_phF_pnlChangeID_formChangeID", "ChangeIDDialog_formChangeID");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        public c_attributes Attributes { get; } = new c_attributes("ctl00_phF_BAccount_t1", "Attributes");
        
        public AP303000_VendorMaint()
        {
            ScreenId = "AP303000";
            ScreenUrl = "/Pages/AP/AP303000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual AP303000_VendorMaint ReadOne(Gate gate, string AcctCD)
        {
            new BiObject<AP303000_VendorMaint>(gate).ReadOne(this, AcctCD);
            return this;
        }
        
        public virtual AP303000_VendorMaint ReadOne(string AcctCD)
        {
            return this.ReadOne(ApiConnection.Source, AcctCD);
        }
        
        public virtual void SyncTOC()
        {
            ToolBar.SyncTOC.Click();
        }
        
        public virtual void Favorites()
        {
            ToolBar.Favorites.Click();
        }
        
        public virtual void Note()
        {
            ToolBar.Note.Click();
        }
        
        public virtual void FilesMenuShow()
        {
            ToolBar.FilesMenuShow.Click();
        }
        
        public virtual void NotifyShow()
        {
            ToolBar.NotifyShow.Click();
        }
        
        public virtual void Custom()
        {
            ToolBar.Custom.Click();
        }
        
        public virtual void ActionSelectWorkingProject()
        {
            ToolBar.ActionSelectWorkingProject.Click();
        }
        
        public virtual void InspectElementCtrlAltClick()
        {
            ToolBar.InspectElementCtrlAltClick.Click();
        }
        
        public virtual void ManageAttributes()
        {
            ToolBar.ManageAttributes.Click();
        }
        
        public virtual void MenuEditProj()
        {
            ToolBar.MenuEditProj.Click();
        }
        
        public virtual void ManageCustomizations()
        {
            ToolBar.ManageCustomizations.Click();
        }
        
        public virtual void KeyBtnRefresh()
        {
            ToolBar.KeyBtnRefresh.Click();
        }
        
        public virtual void Help()
        {
            ToolBar.Help.Click();
        }
        
        public virtual void CancelClose()
        {
            ToolBar.CancelClose.Click();
        }
        
        public virtual void SaveClose()
        {
            ToolBar.SaveClose.Click();
        }
        
        public virtual void Save()
        {
            ToolBar.Save.Click();
        }
        
        public virtual void Cancel()
        {
            ToolBar.Cancel.Click();
        }
        
        public virtual void Insert()
        {
            ToolBar.Insert.Click();
        }
        
        public virtual void Clipboard()
        {
            ToolBar.Clipboard.Click();
        }
        
        public virtual void CopyDocument()
        {
            ToolBar.CopyDocument.Click();
        }
        
        public virtual void PasteDocument()
        {
            ToolBar.PasteDocument.Click();
        }
        
        public virtual void SaveTemplate()
        {
            ToolBar.SaveTemplate.Click();
        }
        
        public virtual void Delete()
        {
            ToolBar.Delete.Click();
        }
        
        public virtual void First()
        {
            ToolBar.First.Click();
        }
        
        public virtual void Prev()
        {
            ToolBar.Prev.Click();
        }
        
        public virtual void Next()
        {
            ToolBar.Next.Click();
        }
        
        public virtual void Last()
        {
            ToolBar.Last.Click();
        }
        
        public virtual void ViewAllActivities()
        {
            ToolBar.ViewAllActivities.Click();
        }
        
        public virtual void Actions()
        {
            ToolBar.Actions.Click();
        }
        
        public virtual void ViewCustomer()
        {
            ToolBar.ViewCustomer.Click();
        }
        
        public virtual void ViewBusnessAccount()
        {
            ToolBar.ViewBusnessAccount.Click();
        }
        
        public virtual void NewBillAdjustment()
        {
            ToolBar.NewBillAdjustment.Click();
        }
        
        public virtual void NewManualCheck()
        {
            ToolBar.NewManualCheck.Click();
        }
        
        public virtual void ExtendToCustomer()
        {
            ToolBar.ExtendToCustomer.Click();
        }
        
        public virtual void ViewRestrictionGroups()
        {
            ToolBar.ViewRestrictionGroups.Click();
        }
        
        public virtual void ValidateAddresses()
        {
            ToolBar.ValidateAddresses.Click();
        }
        
        public virtual void ChangeID()
        {
            ToolBar.ChangeID.Click();
        }
        
        public virtual void Inquiries()
        {
            ToolBar.Inquiries.Click();
        }
        
        public virtual void VendorDetails()
        {
            ToolBar.VendorDetails.Click();
        }
        
        public virtual void ApproveBillsForPayments()
        {
            ToolBar.ApproveBillsForPayments.Click();
        }
        
        public virtual void PayBills()
        {
            ToolBar.PayBills.Click();
        }
        
        public virtual void VendorPrice()
        {
            ToolBar.VendorPrice.Click();
        }
        
        public virtual void Reports()
        {
            ToolBar.Reports.Click();
        }
        
        public virtual void BalanceByVendor()
        {
            ToolBar.BalanceByVendor.Click();
        }
        
        public virtual void VendorHistory()
        {
            ToolBar.VendorHistory.Click();
        }
        
        public virtual void APAgedPastDue()
        {
            ToolBar.APAgedPastDue.Click();
        }
        
        public virtual void APAgedOutstanding()
        {
            ToolBar.APAgedOutstanding.Click();
        }
        
        public virtual void APDocumentRegister()
        {
            ToolBar.APDocumentRegister.Click();
        }
        
        public virtual void RepVendorDetails()
        {
            ToolBar.RepVendorDetails.Click();
        }
        
        public virtual void ChangeIDHidden()
        {
            ToolBar.ChangeIDHidden.Click();
        }
        
        public virtual void LongRun()
        {
            ToolBar.LongRun.Click();
        }
        
        public virtual void ElapsedTime()
        {
            ToolBar.ElapsedTime.Click();
        }
        
        public class PxToolBar : PxControlCollection
        {
            
			public ToolBarButton SyncTOC { get; }
			public ToolBarButton Favorites { get; }
			public ToolBarButton Note { get; }
			public ToolBarButton FilesMenuShow { get; }
			public ToolBarButton NotifyShow { get; }
			public ToolBarButton Custom { get; }
			public ToolBarButton ActionSelectWorkingProject { get; }
			public ToolBarButton InspectElementCtrlAltClick { get; }
			public ToolBarButton ManageAttributes { get; }
			public ToolBarButton MenuEditProj { get; }
			public ToolBarButton ManageCustomizations { get; }
			public ToolBarButton KeyBtnRefresh { get; }
			public ToolBarButton Help { get; }
			public ToolBarButton CancelClose { get; }
			public ToolBarButton SaveClose { get; }
			public ToolBarButton Save { get; }
			public ToolBarButton Cancel { get; }
			public ToolBarButton Insert { get; }
			public ToolBarButton Clipboard { get; }
			public ToolBarButton CopyDocument { get; }
			public ToolBarButton PasteDocument { get; }
			public ToolBarButton SaveTemplate { get; }
			public ToolBarButton Delete { get; }
			public ToolBarButton First { get; }
			public ToolBarButton Prev { get; }
			public ToolBarButton Next { get; }
			public ToolBarButton Last { get; }
			public ToolBarButton ViewAllActivities { get; }
			public ToolBarButton Actions { get; }
			public ToolBarButton ViewCustomer { get; }
			public ToolBarButton ViewBusnessAccount { get; }
			public ToolBarButton NewBillAdjustment { get; }
			public ToolBarButton NewManualCheck { get; }
			public ToolBarButton ExtendToCustomer { get; }
			public ToolBarButton ViewRestrictionGroups { get; }
			public ToolBarButton ValidateAddresses { get; }
			public ToolBarButton ChangeID { get; }
			public ToolBarButton Inquiries { get; }
			public ToolBarButton VendorDetails { get; }
			public ToolBarButton ApproveBillsForPayments { get; }
			public ToolBarButton PayBills { get; }
			public ToolBarButton VendorPrice { get; }
			public ToolBarButton Reports { get; }
			public ToolBarButton BalanceByVendor { get; }
			public ToolBarButton VendorHistory { get; }
			public ToolBarButton APAgedPastDue { get; }
			public ToolBarButton APAgedOutstanding { get; }
			public ToolBarButton APDocumentRegister { get; }
			public ToolBarButton RepVendorDetails { get; }
			public ToolBarButton ChangeIDHidden { get; }
			public ToolBarButton LongRun { get; }
			public ToolBarButton ElapsedTime { get; }
            
            public PxToolBar(string locator)
            {
                SyncTOC = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                Favorites = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'favorites\']", "Add to Favorites", locator, null);
                Note = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'NoteShow\']", "Add Note", locator, null);
                FilesMenuShow = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'FilesMenuShow\']", "Files", locator, null);
                NotifyShow = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'NotifyShow\']", "Notifications", locator, null);
                Custom = new ToolBarButton("css=#ctl00_usrCaption_CustomizationDialogs_PXToolBar1 div[data-cmd=\'Custom\']", "Customization", locator, null);
                ActionSelectWorkingProject = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "ActionSelectWorkingProject\']", "Select Project...", locator, Custom);
                InspectElementCtrlAltClick = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li.menuItem d" +
                        "iv:textEqual(\"Inspect Element (Ctrl+Alt+Click)\")", "Inspect Element (Ctrl+Alt+Click)", locator, Custom);
                ManageAttributes = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "ManageAttributes\']", "Manage User-Defined Fields", locator, Custom);
                MenuEditProj = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "menuEditProj\']", "Edit Project...", locator, Custom);
                ManageCustomizations = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li.menuItem d" +
                        "iv:textEqual(\"Manage Customizations...\")", "Manage Customizations...", locator, Custom);
                KeyBtnRefresh = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'keyBtnRefresh\']", "Click to refresh page.", locator, null);
                Help = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'help\']", "View Tools", locator, null);
                CancelClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'CancelClose\']", "Discard Changes and Close", locator, null);
                SaveClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'SaveClose\']", "Save the current record and close the screen (Ctrl+Shift+S).", locator, null);
                Save = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Save\']", "Save (Ctrl+S).", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Cancel\']", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                Insert = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Insert\']", "Add New Record (Ctrl+Ins)", locator, null);
                Clipboard = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div.toolsBtn[tooltip=\'Clipboard\']", "Clipboard", locator, null);
                CopyDocument = new ToolBarButton("css=li[data-cmd=\'Edit@CopyDocument\']", "Copy", locator, Clipboard);
                PasteDocument = new ToolBarButton("css=li[data-cmd=\'Edit@PasteDocument\']", "Paste", locator, Clipboard);
                SaveTemplate = new ToolBarButton("css=li[data-cmd=\'Edit@SaveTemplate\']", "Save as Template...", locator, Clipboard);
                Delete = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Delete\']", "Delete (Ctrl+Del).", locator, null);
                Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                First = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'First\']", "Go to First Record", locator, null);
                Prev = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Prev\']", "Go to Previous Record (PgUp)", locator, null);
                Next = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Next\']", "Go to Next Record (PgDn)", locator, null);
                Last = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'Last\']", "Go to Last Record", locator, null);
                ViewAllActivities = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ViewAllActivities\']", "View Activities", locator, null);
                Actions = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Actions\") > div[data-type=\'drop\']", "Actions", locator, null);
                ViewCustomer = new ToolBarButton("css=li[data-cmd=\'Action@ViewCustomer\']", "View Customer", locator, Actions);
                ViewBusnessAccount = new ToolBarButton("css=li[data-cmd=\'Action@ViewBusnessAccount\']", "View Business Account", locator, Actions);
                NewBillAdjustment = new ToolBarButton("css=li[data-cmd=\'Action@NewBillAdjustment\']", "Enter Bill", locator, Actions);
                NewManualCheck = new ToolBarButton("css=li[data-cmd=\'Action@NewManualCheck\']", "Create Check", locator, Actions);
                ExtendToCustomer = new ToolBarButton("css=li[data-cmd=\'Action@ExtendToCustomer\']", "Extend To Customer", locator, Actions);
                ViewRestrictionGroups = new ToolBarButton("css=li[data-cmd=\'Action@ViewRestrictionGroups\']", "View Restriction Groups", locator, Actions);
                ValidateAddresses = new ToolBarButton("css=li[data-cmd=\'Action@ValidateAddresses\']", "Validate Addresses", locator, Actions);
                ChangeID = new ToolBarButton("css=li[data-cmd=\'Action@ChangeID\']", "Change ID", locator, Actions);
                Inquiries = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Inquiries\") > div[data-type=\'drop\']", "Inquiries", locator, null);
                VendorDetails = new ToolBarButton("css=li[data-cmd=\'Inquiry@VendorDetails\']", "Vendor Details", locator, Inquiries);
                ApproveBillsForPayments = new ToolBarButton("css=li[data-cmd=\'Inquiry@ApproveBillsForPayments\']", "Approve Bills for Payment", locator, Inquiries);
                PayBills = new ToolBarButton("css=li[data-cmd=\'Inquiry@PayBills\']", "Pay Bills", locator, Inquiries);
                VendorPrice = new ToolBarButton("css=li[data-cmd=\'Inquiry@VendorPrice\']", "Vendor Prices", locator, Inquiries);
                Reports = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div:textEqual(\"Reports\") > div[data-type=\'drop\']", "Reports", locator, null);
                BalanceByVendor = new ToolBarButton("css=li[data-cmd=\'Report@BalanceByVendor\']", "AP Balance by Vendor", locator, Reports);
                VendorHistory = new ToolBarButton("css=li[data-cmd=\'Report@VendorHistory\']", "Vendor History", locator, Reports);
                APAgedPastDue = new ToolBarButton("css=li[data-cmd=\'Report@APAgedPastDue\']", "AP Aged Past Due", locator, Reports);
                APAgedOutstanding = new ToolBarButton("css=li[data-cmd=\'Report@APAgedOutstanding\']", "AP Aged Outstanding", locator, Reports);
                APDocumentRegister = new ToolBarButton("css=li[data-cmd=\'Report@APDocumentRegister\']", "AP Register", locator, Reports);
                RepVendorDetails = new ToolBarButton("css=li[data-cmd=\'Report@RepVendorDetails\']", "Vendor Profile", locator, Reports);
                ChangeIDHidden = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ChangeID\']", "Change ID", locator, null);
                LongRun = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
            }
        }
        
        public class c_baccount_baccount : Container
        {
            
			public Selector AcctCD { get; }
			public Label AcctCDLabel { get; }
			public PXTextEdit AcctName { get; }
			public Label AcctNameLabel { get; }
			public DropDown Status { get; }
			public Label StatusLabel { get; }
            
            public c_baccount_baccount(string locator, string name) : 
                    base(locator, name)
            {
                AcctCD = new Selector("ctl00_phF_BAccount_t0_edAcctCD", "Vendor ID", locator, null);
                AcctCDLabel = new Label(AcctCD);
                AcctCD.DataField = "AcctCD";
                AcctName = new PXTextEdit("ctl00_phF_BAccount_t0_edAcctName", "Vendor Name", locator, null);
                AcctNameLabel = new Label(AcctName);
                AcctName.DataField = "AcctName";
                Status = new DropDown("ctl00_phF_BAccount_t0_edStatus", "Status", locator, null);
                StatusLabel = new Label(Status);
                Status.DataField = "Status";
                Status.Items.Add("A", "Active");
                Status.Items.Add("H", "On Hold");
                Status.Items.Add("P", "Hold Payments");
                Status.Items.Add("I", "Inactive");
                Status.Items.Add("T", "One-Time");
                DataMemberName = "BAccount";
            }
        }
        
        public class c_parameters_gridwizard : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox IsDefault { get; }
			public Label IsDefaultLabel { get; }
			public CheckBox Override { get; }
			public Label OverrideLabel { get; }
			public Selector RoleName { get; }
			public Label RoleNameLabel { get; }
            
            public c_parameters_gridwizard(string locator, string name) : 
                    base(locator, name)
            {
                IsDefault = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_defaultCkbx", "Is Default", locator, null);
                IsDefaultLabel = new Label(IsDefault);
                IsDefault.DataField = "IsDefault";
                Override = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_overrideCkbx", "Override", locator, null);
                OverrideLabel = new Label(Override);
                Override.DataField = "Override";
                RoleName = new Selector("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_edRole", "Role Name", locator, null);
                RoleNameLabel = new Label(RoleName);
                RoleName.DataField = "RoleName";
                DataMemberName = "Parameters";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Finish()
            {
                Buttons.Finish.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Cancel { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Finish { get; }
                
                public PxButtonCollection()
                {
                    Cancel = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_cancel", "Cancel", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                    Prev = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_prev", "Prev", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                    Next = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_next", "Next", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                    Finish = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_save", "Finish", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                }
            }
        }
        
        public class c_firstselect_formactions : Container
        {
            
			public PXTextEdit Key { get; }
			public Label KeyLabel { get; }
            
            public c_firstselect_formactions(string locator, string name) : 
                    base(locator, name)
            {
                Key = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions_edKey", "Key", locator, null);
                KeyLabel = new Label(Key);
                Key.DataField = "Key";
                DataMemberName = "FirstSelect";
            }
        }
        
        public class c_vieweleminfo_formeleminfo : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AspxControl { get; }
			public Label AspxControlLabel { get; }
			public PXTextEdit CacheType { get; }
			public Label CacheTypeLabel { get; }
			public PXTextEdit FieldName { get; }
			public Label FieldNameLabel { get; }
			public PXTextEdit ViewName { get; }
			public Label ViewNameLabel { get; }
			public PXTextEdit GraphName { get; }
			public Label GraphNameLabel { get; }
			public PXTextEdit ActionName { get; }
			public Label ActionNameLabel { get; }
            
            public c_vieweleminfo_formeleminfo(string locator, string name) : 
                    base(locator, name)
            {
                AspxControl = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_edAspxControl", "Control Type", locator, null);
                AspxControlLabel = new Label(AspxControl);
                AspxControl.DataField = "AspxControl";
                CacheType = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_CacheType", "Data Class", locator, null);
                CacheTypeLabel = new Label(CacheType);
                CacheType.DataField = "CacheType";
                FieldName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_FieldName", "Data Field", locator, null);
                FieldNameLabel = new Label(FieldName);
                FieldName.DataField = "FieldName";
                ViewName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_ViewName", "View Name", locator, null);
                ViewNameLabel = new Label(ViewName);
                ViewName.DataField = "ViewName";
                GraphName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_GraphName", "Business Logic", locator, null);
                GraphNameLabel = new Label(GraphName);
                GraphName.DataField = "GraphName";
                ActionName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_ActionName", "Action Name", locator, null);
                ActionNameLabel = new Label(ActionName);
                ActionName.DataField = "ActionName";
                DataMemberName = "ViewElemInfo";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Customize()
            {
                Buttons.Customize.Click();
            }
            
            public virtual void Actions()
            {
                Buttons.Actions.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Customize { get; }
			public Button Actions { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Customize = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_PXButton3", "Customize", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                    Actions = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_ButtonGraphActions", "Actions", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_PXButton4", "Cancel", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                }
            }
        }
        
        public class c_filterworkingproject_formnewproject : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NewProject { get; }
			public Label NewProjectLabel { get; }
            
            public c_filterworkingproject_formnewproject(string locator, string name) : 
                    base(locator, name)
            {
                NewProject = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject_edNewProject", "Project Name", locator, null);
                NewProjectLabel = new Label(NewProject);
                NewProject.DataField = "NewProject";
                DataMemberName = "FilterWorkingProject";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_DlgNewProjectButtonOk", "OK", "ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_DlgNewProjectButtonCancel", "Cancel", "ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject");
                }
            }
        }
        
        public class c_filterworkingproject_formselectproject : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Name { get; }
			public Label NameLabel { get; }
            
            public c_filterworkingproject_formselectproject(string locator, string name) : 
                    base(locator, name)
            {
                Name = new Selector("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject_edWP", "Project Name", locator, null);
                NameLabel = new Label(Name);
                Name.DataField = "Name";
                DataMemberName = "FilterWorkingProject";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void New()
            {
                Buttons.New.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
			public Button New { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_SelectProjectOk", "OK", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_SelectProjectCancel", "Cancel", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                    New = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_BtnNewProject", "New...", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                }
            }
        }
        
        public class c_gridlist_gridgrid : Grid<c_gridlist_gridgrid.c_grid_row, c_gridlist_gridgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_gridlist_gridgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid");
                DataMemberName = "GridList";
                FilterForm = new c_grid_filter("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_fe_gf", "FilterForm");
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXTextEdit View { get; }
			public PXTextEdit Id { get; }
                
                public c_grid_row(c_gridlist_gridgrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ef", "Included", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    View = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ei", "Table ID", grid.Locator, "View");
                    View.DataField = "View";
                    Id = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ei", "Grid ID", grid.Locator, "Id");
                    Id.DataField = "Id";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter View { get; }
				public PXTextEditColumnFilter Id { get; }
                
                public c_grid_header(c_gridlist_gridgrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    View = new PXTextEditColumnFilter(grid.Row.View);
                    Id = new PXTextEditColumnFilter(grid.Row.Id);
                }
            }
        }
        
        public class c_userlist_usergrid : Grid<c_userlist_usergrid.c_grid_row, c_userlist_usergrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_userlist_usergrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid");
                DataMemberName = "UserList";
                FilterForm = new c_grid_filter("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Included { get; }
			public Selector Username { get; }
			public PXTextEdit DisplayName { get; }
			public PXTextEdit Email { get; }
			public PXTextEdit Guest { get; }
			public DropDown State { get; }
                
                public c_grid_row(c_userlist_usergrid grid) : 
                        base(grid)
                {
                    Included = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ef", "Included", grid.Locator, "Included");
                    Included.DataField = "Included";
                    Username = new Selector("_ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_es", "Login", grid.Locator, "Username");
                    Username.DataField = "Username";
                    DisplayName = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ei", "Display Name", grid.Locator, "DisplayName");
                    DisplayName.DataField = "DisplayName";
                    Email = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ei", "Email", grid.Locator, "Email");
                    Email.DataField = "Email";
                    Guest = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ef", "Guest Account", grid.Locator, "Guest");
                    Guest.DataField = "Guest";
                    State = new DropDown("_ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_ec", "Status", grid.Locator, "State");
                    State.DataField = "State";
                    State.Items.Add("N", "Not Created");
                    State.Items.Add("O", "Online");
                    State.Items.Add("P", "Pending Activation");
                    State.Items.Add("D", "Disabled");
                    State.Items.Add("A", "Active");
                    State.Items.Add("L", "Temporarily Locked");
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Included { get; }
				public SelectorColumnFilter Username { get; }
				public PXTextEditColumnFilter DisplayName { get; }
				public PXTextEditColumnFilter Email { get; }
				public PXTextEditColumnFilter Guest { get; }
				public DropDownColumnFilter State { get; }
                
                public c_grid_header(c_userlist_usergrid grid) : 
                        base(grid)
                {
                    Included = new CheckBoxColumnFilter(grid.Row.Included);
                    Username = new SelectorColumnFilter(grid.Row.Username);
                    DisplayName = new PXTextEditColumnFilter(grid.Row.DisplayName);
                    Email = new PXTextEditColumnFilter(grid.Row.Email);
                    Guest = new PXTextEditColumnFilter(grid.Row.Guest);
                    State = new DropDownColumnFilter(grid.Row.State);
                }
            }
        }
        
        public class c_userlist_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_userlist_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "UserList";
            }
        }
        
        public class c_defaddress_defaddress : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox IsValidated { get; }
			public Label IsValidatedLabel { get; }
			public PXTextEdit AddressLine1 { get; }
			public Label AddressLine1Label { get; }
			public PXTextEdit AddressLine2 { get; }
			public Label AddressLine2Label { get; }
			public PXTextEdit City { get; }
			public Label CityLabel { get; }
			public Selector CountryID { get; }
			public Label CountryIDLabel { get; }
			public Selector State { get; }
			public Label StateLabel { get; }
			public PXTextEdit PostalCode { get; }
			public Label PostalCodeLabel { get; }
            
            public c_defaddress_defaddress(string locator, string name) : 
                    base(locator, name)
            {
                IsValidated = new CheckBox("ctl00_phG_tab_t0_DefAddress_edIsValidated", "Validated", locator, null);
                IsValidatedLabel = new Label(IsValidated);
                IsValidated.DataField = "IsValidated";
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t0_DefAddress_edAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t0_DefAddress_edAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t0_DefAddress_edCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                CountryID = new Selector("ctl00_phG_tab_t0_DefAddress_edCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                State = new Selector("ctl00_phG_tab_t0_DefAddress_edState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t0_DefAddress_edPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                DataMemberName = "DefAddress";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void VendorClassIDEdit()
            {
                Buttons.VendorClassIDEdit.Click();
            }
            
            public virtual void TermsIDEdit()
            {
                Buttons.TermsIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ViewonMap { get; }
			public Button VendorClassIDEdit { get; }
			public Button TermsIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ViewonMap = new Button("ctl00_phG_tab_t0_DefAddress_btnViewMainOnMap", "View on Map", "ctl00_phG_tab_t0_DefAddress");
                    VendorClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edVendorClassID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "VendorClassIDEdit", "ctl00_phG_tab_t0_DefAddress");
                    VendorClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    TermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edTermsID\'] div[class=\'editBtnCont\'] > div > div", "TermsIDEdit", "ctl00_phG_tab_t0_DefAddress");
                    TermsIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_remitaddress_remitaddress : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox IsValidated { get; }
			public Label IsValidatedLabel { get; }
			public PXTextEdit AddressLine1 { get; }
			public Label AddressLine1Label { get; }
			public PXTextEdit AddressLine2 { get; }
			public Label AddressLine2Label { get; }
			public PXTextEdit City { get; }
			public Label CityLabel { get; }
			public Selector CountryID { get; }
			public Label CountryIDLabel { get; }
			public Selector State { get; }
			public Label StateLabel { get; }
			public PXTextEdit PostalCode { get; }
			public Label PostalCodeLabel { get; }
            
            public c_remitaddress_remitaddress(string locator, string name) : 
                    base(locator, name)
            {
                IsValidated = new CheckBox("ctl00_phG_tab_t1_DefLocationPayment_RemitAddress_edIsValidated", "Validated", locator, null);
                IsValidatedLabel = new Label(IsValidated);
                IsValidated.DataField = "IsValidated";
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t1_DefLocationPayment_RemitAddress_edAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t1_DefLocationPayment_RemitAddress_edAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t1_DefLocationPayment_RemitAddress_edCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                CountryID = new Selector("ctl00_phG_tab_t1_DefLocationPayment_RemitAddress_edCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                State = new Selector("ctl00_phG_tab_t1_DefLocationPayment_RemitAddress_edState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t1_DefLocationPayment_RemitAddress_edPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                DataMemberName = "RemitAddress";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ViewonMap { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    ViewonMap = new Button("ctl00_phG_tab_t1_DefLocationPayment_RemitAddress_btnViewRemitOnMap", "View on Map", "ctl00_phG_tab_t1_DefLocationPayment_RemitAddress");
                    First = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfFirst0", "First", "ctl00_phG_tab_t1_DefLocationPayment_RemitAddress");
                    Prev = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfPrev0", "Prev", "ctl00_phG_tab_t1_DefLocationPayment_RemitAddress");
                    Next = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfNext0", "Next", "ctl00_phG_tab_t1_DefLocationPayment_RemitAddress");
                    Last = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfLast0", "Last", "ctl00_phG_tab_t1_DefLocationPayment_RemitAddress");
                }
            }
        }
        
        public class c_defcontact_defcontact : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit FullName { get; }
			public Label FullNameLabel { get; }
			public PXTextEdit Attention { get; }
			public Label AttentionLabel { get; }
			public EmailEdit EMail { get; }
			public Label EMailLabel { get; }
			public LinkEdit WebSite { get; }
			public Label WebSiteLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public PXTextEdit Phone2 { get; }
			public Label Phone2Label { get; }
			public PXTextEdit Fax { get; }
			public Label FaxLabel { get; }
            
            public c_defcontact_defcontact(string locator, string name) : 
                    base(locator, name)
            {
                FullName = new PXTextEdit("ctl00_phG_tab_t0_DefContact_edFullName", "Company Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Attention = new PXTextEdit("ctl00_phG_tab_t0_DefContact_edAttention", "Attention", locator, null);
                AttentionLabel = new Label(Attention);
                Attention.DataField = "Attention";
                EMail = new EmailEdit("ctl00_phG_tab_t0_DefContact_edEMail", "Email", locator, null);
                EMailLabel = new Label(EMail);
                EMail.DataField = "EMail";
                WebSite = new LinkEdit("ctl00_phG_tab_t0_DefContact_edWebSite", "Web", locator, null);
                WebSiteLabel = new Label(WebSite);
                WebSite.DataField = "WebSite";
                Phone1 = new PXTextEdit("ctl00_phG_tab_t0_DefContact_edPhone1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Phone2 = new PXTextEdit("ctl00_phG_tab_t0_DefContact_edPhone2", "Phone 2", locator, null);
                Phone2Label = new Label(Phone2);
                Phone2.DataField = "Phone2";
                Fax = new PXTextEdit("ctl00_phG_tab_t0_DefContact_edFax", "Fax", locator, null);
                FaxLabel = new Label(Fax);
                Fax.DataField = "Fax";
                DataMemberName = "DefContact";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void VendorClassIDEdit()
            {
                Buttons.VendorClassIDEdit.Click();
            }
            
            public virtual void TermsIDEdit()
            {
                Buttons.TermsIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ViewonMap { get; }
			public Button VendorClassIDEdit { get; }
			public Button TermsIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ViewonMap = new Button("ctl00_phG_tab_t0_DefAddress_btnViewMainOnMap", "View on Map", "ctl00_phG_tab_t0_DefContact");
                    VendorClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edVendorClassID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "VendorClassIDEdit", "ctl00_phG_tab_t0_DefContact");
                    VendorClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    TermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edTermsID\'] div[class=\'editBtnCont\'] > div > div", "TermsIDEdit", "ctl00_phG_tab_t0_DefContact");
                    TermsIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_defcontact_edcontactgdpr : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox ConsentAgreement { get; }
			public Label ConsentAgreementLabel { get; }
			public DateSelector ConsentDate { get; }
			public Label ConsentDateLabel { get; }
			public DateSelector ConsentExpirationDate { get; }
			public Label ConsentExpirationDateLabel { get; }
            
            public c_defcontact_edcontactgdpr(string locator, string name) : 
                    base(locator, name)
            {
                ConsentAgreement = new CheckBox("ctl00_phG_tab_t0_edContactGDPR_PXCheckBox1", "Consented to the Processing of Personal Data", locator, null);
                ConsentAgreementLabel = new Label(ConsentAgreement);
                ConsentAgreement.DataField = "ConsentAgreement";
                ConsentDate = new DateSelector("ctl00_phG_tab_t0_edContactGDPR_edConsentDate", "Date of Consent", locator, null);
                ConsentDateLabel = new Label(ConsentDate);
                ConsentDate.DataField = "ConsentDate";
                ConsentExpirationDate = new DateSelector("ctl00_phG_tab_t0_edContactGDPR_edConsentExpirationDate", "Consent Expires", locator, null);
                ConsentExpirationDateLabel = new Label(ConsentExpirationDate);
                ConsentExpirationDate.DataField = "ConsentExpirationDate";
                DataMemberName = "DefContact";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void VendorClassIDEdit()
            {
                Buttons.VendorClassIDEdit.Click();
            }
            
            public virtual void TermsIDEdit()
            {
                Buttons.TermsIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ViewonMap { get; }
			public Button VendorClassIDEdit { get; }
			public Button TermsIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ViewonMap = new Button("ctl00_phG_tab_t0_DefAddress_btnViewMainOnMap", "View on Map", "ctl00_phG_tab_t0_edContactGDPR");
                    VendorClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edVendorClassID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "VendorClassIDEdit", "ctl00_phG_tab_t0_edContactGDPR");
                    VendorClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    TermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edTermsID\'] div[class=\'editBtnCont\'] > div > div", "TermsIDEdit", "ctl00_phG_tab_t0_edContactGDPR");
                    TermsIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_deflocationcontact_deflocationcontact : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit FullName { get; }
			public Label FullNameLabel { get; }
			public PXTextEdit Attention { get; }
			public Label AttentionLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public PXTextEdit Phone2 { get; }
			public Label Phone2Label { get; }
			public PXTextEdit Fax { get; }
			public Label FaxLabel { get; }
			public EmailEdit EMail { get; }
			public Label EMailLabel { get; }
			public LinkEdit WebSite { get; }
			public Label WebSiteLabel { get; }
            
            public c_deflocationcontact_deflocationcontact(string locator, string name) : 
                    base(locator, name)
            {
                FullName = new PXTextEdit("ctl00_phG_tab_t2_DefLocation_DefLocationContact_edFullName", "Company Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Attention = new PXTextEdit("ctl00_phG_tab_t2_DefLocation_DefLocationContact_edAttention", "Attention", locator, null);
                AttentionLabel = new Label(Attention);
                Attention.DataField = "Attention";
                Phone1 = new PXTextEdit("ctl00_phG_tab_t2_DefLocation_DefLocationContact_edPhone1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Phone2 = new PXTextEdit("ctl00_phG_tab_t2_DefLocation_DefLocationContact_edPhone2", "Phone 2", locator, null);
                Phone2Label = new Label(Phone2);
                Phone2.DataField = "Phone2";
                Fax = new PXTextEdit("ctl00_phG_tab_t2_DefLocation_DefLocationContact_edFax", "Fax", locator, null);
                FaxLabel = new Label(Fax);
                Fax.DataField = "Fax";
                EMail = new EmailEdit("ctl00_phG_tab_t2_DefLocation_DefLocationContact_edEMail", "Email", locator, null);
                EMailLabel = new Label(EMail);
                EMail.DataField = "EMail";
                WebSite = new LinkEdit("ctl00_phG_tab_t2_DefLocation_DefLocationContact_edWebSite", "Web", locator, null);
                WebSiteLabel = new Label(WebSite);
                WebSite.DataField = "WebSite";
                DataMemberName = "DefLocationContact";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void VBranchIDEdit()
            {
                Buttons.VBranchIDEdit.Click();
            }
            
            public virtual void VTaxZoneIDEdit()
            {
                Buttons.VTaxZoneIDEdit.Click();
            }
            
            public virtual void VShipTermsIDEdit()
            {
                Buttons.VShipTermsIDEdit.Click();
            }
            
            public virtual void VCarrierIDEdit()
            {
                Buttons.VCarrierIDEdit.Click();
            }
            
            public virtual void VFOBPointIDEdit()
            {
                Buttons.VFOBPointIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ViewonMap { get; }
			public Button VBranchIDEdit { get; }
			public Button VTaxZoneIDEdit { get; }
			public Button VShipTermsIDEdit { get; }
			public Button VCarrierIDEdit { get; }
			public Button VFOBPointIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ViewonMap = new Button("ctl00_phG_tab_t2_DefLocation_btnViewDefLoactionOnMap", "View on Map", "ctl00_phG_tab_t2_DefLocation_DefLocationContact");
                    VBranchIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_DefLocation_edVBranchID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "VBranchIDEdit", "ctl00_phG_tab_t2_DefLocation_DefLocationContact");
                    VBranchIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    VTaxZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_DefLocation_edTaxZoneID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "VTaxZoneIDEdit", "ctl00_phG_tab_t2_DefLocation_DefLocationContact");
                    VTaxZoneIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    VShipTermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_DefLocation_edShipTermsID\'] div[class=\'editBtnCont\']" +
                            " > div > div", "VShipTermsIDEdit", "ctl00_phG_tab_t2_DefLocation_DefLocationContact");
                    VShipTermsIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    VCarrierIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_DefLocation_edVCarrierID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "VCarrierIDEdit", "ctl00_phG_tab_t2_DefLocation_DefLocationContact");
                    VCarrierIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    VFOBPointIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_DefLocation_edFOBPointID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "VFOBPointIDEdit", "ctl00_phG_tab_t2_DefLocation_DefLocationContact");
                    VFOBPointIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_remitcontact_remitcontact : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit FullName { get; }
			public Label FullNameLabel { get; }
			public PXTextEdit Attention { get; }
			public Label AttentionLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public PXTextEdit Phone2 { get; }
			public Label Phone2Label { get; }
			public PXTextEdit Fax { get; }
			public Label FaxLabel { get; }
			public EmailEdit EMail { get; }
			public Label EMailLabel { get; }
			public LinkEdit WebSite { get; }
			public Label WebSiteLabel { get; }
            
            public c_remitcontact_remitcontact(string locator, string name) : 
                    base(locator, name)
            {
                FullName = new PXTextEdit("ctl00_phG_tab_t1_DefLocationPayment_RemitContact_edFullName", "Company Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Attention = new PXTextEdit("ctl00_phG_tab_t1_DefLocationPayment_RemitContact_edAttention", "Attention", locator, null);
                AttentionLabel = new Label(Attention);
                Attention.DataField = "Attention";
                Phone1 = new PXTextEdit("ctl00_phG_tab_t1_DefLocationPayment_RemitContact_edPhone1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Phone2 = new PXTextEdit("ctl00_phG_tab_t1_DefLocationPayment_RemitContact_edPhone2", "Phone 2", locator, null);
                Phone2Label = new Label(Phone2);
                Phone2.DataField = "Phone2";
                Fax = new PXTextEdit("ctl00_phG_tab_t1_DefLocationPayment_RemitContact_edFax", "Fax", locator, null);
                FaxLabel = new Label(Fax);
                Fax.DataField = "Fax";
                EMail = new EmailEdit("ctl00_phG_tab_t1_DefLocationPayment_RemitContact_edEMail", "Email", locator, null);
                EMailLabel = new Label(EMail);
                EMail.DataField = "EMail";
                WebSite = new LinkEdit("ctl00_phG_tab_t1_DefLocationPayment_RemitContact_edWebSite", "Web", locator, null);
                WebSiteLabel = new Label(WebSite);
                WebSite.DataField = "WebSite";
                DataMemberName = "RemitContact";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ViewonMap { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    ViewonMap = new Button("ctl00_phG_tab_t1_DefLocationPayment_RemitAddress_btnViewRemitOnMap", "View on Map", "ctl00_phG_tab_t1_DefLocationPayment_RemitContact");
                    First = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfFirst0", "First", "ctl00_phG_tab_t1_DefLocationPayment_RemitContact");
                    Prev = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfPrev0", "Prev", "ctl00_phG_tab_t1_DefLocationPayment_RemitContact");
                    Next = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfNext0", "Next", "ctl00_phG_tab_t1_DefLocationPayment_RemitContact");
                    Last = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfLast0", "Last", "ctl00_phG_tab_t1_DefLocationPayment_RemitContact");
                }
            }
        }
        
        public class c_locations_grdlocations : Grid<c_locations_grdlocations.c_grid_row, c_locations_grdlocations.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_locations_grdlocations(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t3_grdLocations");
                DataMemberName = "Locations";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t3_grdLocations_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void NewLocation()
            {
                ToolBar.NewLocation.Click();
            }
            
            public virtual void LocationDetails()
            {
                ToolBar.LocationDetails.Click();
            }
            
            public virtual void SetDefault()
            {
                ToolBar.SetDefault.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public virtual void LocationCDEdit()
            {
                Buttons.LocationCDEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid NewLocation { get; }
			public ToolBarButtonGrid LocationDetails { get; }
			public ToolBarButtonGrid SetDefault { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdLocations_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    NewLocation = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdLocations_at_tlb div[data-cmd=\'NewLocation\']", "Add Location", locator, null);
                    LocationDetails = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdLocations_at_tlb div[data-cmd=\'cmdViewLocation\']", "Location Details", locator, null);
                    SetDefault = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdLocations_at_tlb div[data-cmd=\'SetDefault\']", "Set as Default", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdLocations_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdLocations_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdLocations_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdLocations_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdLocations_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdLocations_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdLocations_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdLocations_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button LocationCDEdit { get; }
                
                public PxButtonCollection()
                {
                    LocationCDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_grdLocations_lv0_edLocationCD\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "LocationCDEdit", "ctl00_phG_tab_t3_grdLocations");
                    LocationCDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox IsActive { get; }
			public CheckBox IsDefault { get; }
			public Selector LocationBAccountID { get; }
			public PXNumberEdit LocationID { get; }
			public Selector LocationCD { get; }
			public PXTextEdit Descr { get; }
			public PXTextEdit City { get; }
			public Selector CountryID { get; }
			public Selector State { get; }
			public Selector VTaxZoneID { get; }
			public Selector VExpenseAcctID { get; }
			public Selector VExpenseSubID { get; }
                
                public c_grid_row(c_locations_grdlocations grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    IsActive = new CheckBox("ctl00_phG_tab_t3_grdLocations_ef", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    IsDefault = new CheckBox("ctl00_phG_tab_t3_grdLocations_ef", "Is Default", grid.Locator, "IsDefault");
                    IsDefault.DataField = "IsDefault";
                    LocationBAccountID = new Selector("_ctl00_phG_tab_t3_grdLocations_lv0_es", "Business Account ID", grid.Locator, "LocationBAccountID");
                    LocationBAccountID.DataField = "LocationBAccountID";
                    LocationID = new PXNumberEdit("ctl00_phG_tab_t3_grdLocations_en", "LocationID", grid.Locator, "LocationID");
                    LocationID.DataField = "LocationID";
                    LocationCD = new Selector("_ctl00_phG_tab_t3_grdLocations_lv0_edLocationCD", "Location ID", grid.Locator, "LocationCD");
                    LocationCD.DataField = "LocationCD";
                    Descr = new PXTextEdit("ctl00_phG_tab_t3_grdLocations_ei", "Location Name", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    City = new PXTextEdit("ctl00_phG_tab_t3_grdLocations_ei", "City", grid.Locator, "City");
                    City.DataField = "City";
                    CountryID = new Selector("_ctl00_phG_tab_t3_grdLocations_lv0_es", "Country", grid.Locator, "CountryID");
                    CountryID.DataField = "CountryID";
                    State = new Selector("_ctl00_phG_tab_t3_grdLocations_lv0_es", "State", grid.Locator, "State");
                    State.DataField = "State";
                    VTaxZoneID = new Selector("_ctl00_phG_tab_t3_grdLocations_lv0_es", "Tax Zone", grid.Locator, "VTaxZoneID");
                    VTaxZoneID.DataField = "VTaxZoneID";
                    VExpenseAcctID = new Selector("_ctl00_phG_tab_t3_grdLocations_lv0_es", "Expense Account", grid.Locator, "VExpenseAcctID");
                    VExpenseAcctID.DataField = "VExpenseAcctID";
                    VExpenseSubID = new Selector("_ctl00_phG_tab_t3_grdLocations_lv0_es", "Expense Sub.", grid.Locator, "VExpenseSubID");
                    VExpenseSubID.DataField = "VExpenseSubID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter IsActive { get; }
				public CheckBoxColumnFilter IsDefault { get; }
				public SelectorColumnFilter LocationBAccountID { get; }
				public PXNumberEditColumnFilter LocationID { get; }
				public SelectorColumnFilter LocationCD { get; }
				public PXTextEditColumnFilter Descr { get; }
				public PXTextEditColumnFilter City { get; }
				public SelectorColumnFilter CountryID { get; }
				public SelectorColumnFilter State { get; }
				public SelectorColumnFilter VTaxZoneID { get; }
				public SelectorColumnFilter VExpenseAcctID { get; }
				public SelectorColumnFilter VExpenseSubID { get; }
                
                public c_grid_header(c_locations_grdlocations grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    IsDefault = new CheckBoxColumnFilter(grid.Row.IsDefault);
                    LocationBAccountID = new SelectorColumnFilter(grid.Row.LocationBAccountID);
                    LocationID = new PXNumberEditColumnFilter(grid.Row.LocationID);
                    LocationCD = new SelectorColumnFilter(grid.Row.LocationCD);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    City = new PXTextEditColumnFilter(grid.Row.City);
                    CountryID = new SelectorColumnFilter(grid.Row.CountryID);
                    State = new SelectorColumnFilter(grid.Row.State);
                    VTaxZoneID = new SelectorColumnFilter(grid.Row.VTaxZoneID);
                    VExpenseAcctID = new SelectorColumnFilter(grid.Row.VExpenseAcctID);
                    VExpenseSubID = new SelectorColumnFilter(grid.Row.VExpenseSubID);
                }
            }
        }
        
        public class c_locations_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector LocationCD { get; }
			public Label LocationCDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_locations_lv0(string locator, string name) : 
                    base(locator, name)
            {
                LocationCD = new Selector("ctl00_phG_tab_t3_grdLocations_lv0_edLocationCD", "Location ID", locator, null);
                LocationCDLabel = new Label(LocationCD);
                LocationCD.DataField = "LocationCD";
                Es = new Selector("ctl00_phG_tab_t3_grdLocations_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t3_grdLocations_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Locations";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void LocationCDEdit()
            {
                Buttons.LocationCDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button LocationCDEdit { get; }
                
                public PxButtonCollection()
                {
                    LocationCDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_grdLocations_lv0_edLocationCD\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "LocationCDEdit", "ctl00_phG_tab_t3_grdLocations_lv0");
                    LocationCDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_deflocation_deflocationpayment : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox IsRemitContactSameAsMain { get; }
			public Label IsRemitContactSameAsMainLabel { get; }
			public CheckBox IsRemitAddressSameAsMain { get; }
			public Label IsRemitAddressSameAsMainLabel { get; }
			public Selector VPaymentMethodID { get; }
			public Label VPaymentMethodIDLabel { get; }
			public Selector VCashAccountID { get; }
			public Label VCashAccountIDLabel { get; }
			public DropDown VPaymentByType { get; }
			public Label VPaymentByTypeLabel { get; }
			public PXNumberEdit VPaymentLeadTime { get; }
			public Label VPaymentLeadTimeLabel { get; }
			public CheckBox VSeparateCheck { get; }
			public Label VSeparateCheckLabel { get; }
			public PXNumberEdit VPrepaymentPct { get; }
			public Label VPrepaymentPctLabel { get; }
            
            public c_deflocation_deflocationpayment(string locator, string name) : 
                    base(locator, name)
            {
                IsRemitContactSameAsMain = new CheckBox("ctl00_phG_tab_t1_DefLocationPayment_chkIsRemitContactSameAsMain", "Same as Main", locator, null);
                IsRemitContactSameAsMainLabel = new Label(IsRemitContactSameAsMain);
                IsRemitContactSameAsMain.DataField = "IsRemitContactSameAsMain";
                IsRemitAddressSameAsMain = new CheckBox("ctl00_phG_tab_t1_DefLocationPayment_chkIsRemitAddressSameAsMain", "Same as Main", locator, null);
                IsRemitAddressSameAsMainLabel = new Label(IsRemitAddressSameAsMain);
                IsRemitAddressSameAsMain.DataField = "IsRemitAddressSameAsMain";
                VPaymentMethodID = new Selector("ctl00_phG_tab_t1_DefLocationPayment_edVPaymentMethodID", "Payment Method", locator, null);
                VPaymentMethodIDLabel = new Label(VPaymentMethodID);
                VPaymentMethodID.DataField = "VPaymentMethodID";
                VCashAccountID = new Selector("ctl00_phG_tab_t1_DefLocationPayment_edVCashAccountID", "Cash Account", locator, null);
                VCashAccountIDLabel = new Label(VCashAccountID);
                VCashAccountID.DataField = "VCashAccountID";
                VPaymentByType = new DropDown("ctl00_phG_tab_t1_DefLocationPayment_edVPaymentByType", "Payment By", locator, null);
                VPaymentByTypeLabel = new Label(VPaymentByType);
                VPaymentByType.DataField = "VPaymentByType";
                VPaymentByType.Items.Add("0", "Due Date");
                VPaymentByType.Items.Add("1", "Discount Date");
                VPaymentLeadTime = new PXNumberEdit("ctl00_phG_tab_t1_DefLocationPayment_edVPaymentLeadTime", "Payment Lead Time (Days)", locator, null);
                VPaymentLeadTimeLabel = new Label(VPaymentLeadTime);
                VPaymentLeadTime.DataField = "VPaymentLeadTime";
                VSeparateCheck = new CheckBox("ctl00_phG_tab_t1_DefLocationPayment_chkVSeparateCheck", "Pay Separately", locator, null);
                VSeparateCheckLabel = new Label(VSeparateCheck);
                VSeparateCheck.DataField = "VSeparateCheck";
                VPrepaymentPct = new PXNumberEdit("ctl00_phG_tab_t1_DefLocationPayment_edVPrepaymentPct", "Prepayment Percent", locator, null);
                VPrepaymentPctLabel = new Label(VPrepaymentPct);
                VPrepaymentPct.DataField = "VPrepaymentPct";
                DataMemberName = "DefLocation";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void CurrentVendorPayToVendorIDEdit()
            {
                Buttons.CurrentVendorPayToVendorIDEdit.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button CurrentVendorPayToVendorIDEdit { get; }
			public Button ViewonMap { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    CurrentVendorPayToVendorIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_DefLocationPayment_edPayToVendorID\'] div[class=\'edit" +
                            "BtnCont\'] > div > div", "CurrentVendor.PayToVendorIDEdit", "ctl00_phG_tab_t1_DefLocationPayment");
                    CurrentVendorPayToVendorIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    ViewonMap = new Button("ctl00_phG_tab_t1_DefLocationPayment_RemitAddress_btnViewRemitOnMap", "View on Map", "ctl00_phG_tab_t1_DefLocationPayment");
                    First = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfFirst0", "First", "ctl00_phG_tab_t1_DefLocationPayment");
                    Prev = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfPrev0", "Prev", "ctl00_phG_tab_t1_DefLocationPayment");
                    Next = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfNext0", "Next", "ctl00_phG_tab_t1_DefLocationPayment");
                    Last = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfLast0", "Last", "ctl00_phG_tab_t1_DefLocationPayment");
                }
            }
        }
        
        public class c_currentvendor_deflocationpayment : Container
        {
            
			public Selector PayToVendorID { get; }
			public Label PayToVendorIDLabel { get; }
			public CheckBox PaymentsByLinesAllowed { get; }
			public Label PaymentsByLinesAllowedLabel { get; }
            
            public c_currentvendor_deflocationpayment(string locator, string name) : 
                    base(locator, name)
            {
                PayToVendorID = new Selector("ctl00_phG_tab_t1_DefLocationPayment_edPayToVendorID", "Pay-to Vendor", locator, null);
                PayToVendorIDLabel = new Label(PayToVendorID);
                PayToVendorID.DataField = "PayToVendorID";
                PaymentsByLinesAllowed = new CheckBox("ctl00_phG_tab_t1_DefLocationPayment_chkPaymentsByLinesAllowed", "Pay by Line", locator, null);
                PaymentsByLinesAllowedLabel = new Label(PaymentsByLinesAllowed);
                PaymentsByLinesAllowed.DataField = "PaymentsByLinesAllowed";
                DataMemberName = "CurrentVendor";
            }
        }
        
        public class c_deflocation_deflocation : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox IsContactSameAsMain { get; }
			public Label IsContactSameAsMainLabel { get; }
			public CheckBox IsAddressSameAsMain { get; }
			public Label IsAddressSameAsMainLabel { get; }
			public CheckBox IsValidated { get; }
			public Label IsValidatedLabel { get; }
			public PXTextEdit AddressLine1 { get; }
			public Label AddressLine1Label { get; }
			public PXTextEdit AddressLine2 { get; }
			public Label AddressLine2Label { get; }
			public PXTextEdit City { get; }
			public Label CityLabel { get; }
			public Selector CountryID { get; }
			public Label CountryIDLabel { get; }
			public Selector State { get; }
			public Label StateLabel { get; }
			public PXTextEdit PostalCode { get; }
			public Label PostalCodeLabel { get; }
			public PXTextEdit Descr { get; }
			public Label DescrLabel { get; }
			public Selector VBranchID { get; }
			public Label VBranchIDLabel { get; }
			public Selector VTaxZoneID { get; }
			public Label VTaxZoneIDLabel { get; }
			public DropDown VTaxCalcMode { get; }
			public Label VTaxCalcModeLabel { get; }
			public PXTextEdit TaxRegistrationID { get; }
			public Label TaxRegistrationIDLabel { get; }
			public CheckBox VPrintOrder { get; }
			public Label VPrintOrderLabel { get; }
			public CheckBox VEmailOrder { get; }
			public Label VEmailOrderLabel { get; }
			public Selector VSiteID { get; }
			public Label VSiteIDLabel { get; }
			public Selector VShipTermsID { get; }
			public Label VShipTermsIDLabel { get; }
			public Selector VCarrierID { get; }
			public Label VCarrierIDLabel { get; }
			public Selector VFOBPointID { get; }
			public Label VFOBPointIDLabel { get; }
			public PXNumberEdit VLeadTime { get; }
			public Label VLeadTimeLabel { get; }
			public CheckBox VAllowAPBillBeforeReceipt { get; }
			public Label VAllowAPBillBeforeReceiptLabel { get; }
			public PXNumberEdit VRcptQtyMin { get; }
			public Label VRcptQtyMinLabel { get; }
			public PXNumberEdit VRcptQtyMax { get; }
			public Label VRcptQtyMaxLabel { get; }
			public PXNumberEdit VRcptQtyThreshold { get; }
			public Label VRcptQtyThresholdLabel { get; }
			public DropDown VRcptQtyAction { get; }
			public Label VRcptQtyActionLabel { get; }
            
            public c_deflocation_deflocation(string locator, string name) : 
                    base(locator, name)
            {
                IsContactSameAsMain = new CheckBox("ctl00_phG_tab_t2_DefLocation_chkIsContactSameAsMain", "Same as Main", locator, null);
                IsContactSameAsMainLabel = new Label(IsContactSameAsMain);
                IsContactSameAsMain.DataField = "IsContactSameAsMain";
                IsAddressSameAsMain = new CheckBox("ctl00_phG_tab_t2_DefLocation_chkIsMain", "Same as Main", locator, null);
                IsAddressSameAsMainLabel = new Label(IsAddressSameAsMain);
                IsAddressSameAsMain.DataField = "IsAddressSameAsMain";
                IsValidated = new CheckBox("ctl00_phG_tab_t2_DefLocation_edIsValidated", "Validated", locator, null);
                IsValidatedLabel = new Label(IsValidated);
                IsValidated.DataField = "IsValidated";
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t2_DefLocation_edAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t2_DefLocation_edAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t2_DefLocation_edCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                CountryID = new Selector("ctl00_phG_tab_t2_DefLocation_edCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                State = new Selector("ctl00_phG_tab_t2_DefLocation_edState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t2_DefLocation_edPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                Descr = new PXTextEdit("ctl00_phG_tab_t2_DefLocation_edDescr", "Location Name", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                VBranchID = new Selector("ctl00_phG_tab_t2_DefLocation_edVBranchID", "Receiving Branch", locator, null);
                VBranchIDLabel = new Label(VBranchID);
                VBranchID.DataField = "VBranchID";
                VTaxZoneID = new Selector("ctl00_phG_tab_t2_DefLocation_edTaxZoneID", "Tax Zone", locator, null);
                VTaxZoneIDLabel = new Label(VTaxZoneID);
                VTaxZoneID.DataField = "VTaxZoneID";
                VTaxCalcMode = new DropDown("ctl00_phG_tab_t2_DefLocation_edTaxCalcMode", "Tax Calculation Mode", locator, null);
                VTaxCalcModeLabel = new Label(VTaxCalcMode);
                VTaxCalcMode.DataField = "VTaxCalcMode";
                VTaxCalcMode.Items.Add("T", "Tax Settings");
                VTaxCalcMode.Items.Add("G", "Gross");
                VTaxCalcMode.Items.Add("N", "Net");
                TaxRegistrationID = new PXTextEdit("ctl00_phG_tab_t2_DefLocation_edTaxRegistrationID", "Tax Registration ID", locator, null);
                TaxRegistrationIDLabel = new Label(TaxRegistrationID);
                TaxRegistrationID.DataField = "TaxRegistrationID";
                VPrintOrder = new CheckBox("ctl00_phG_tab_t2_DefLocation_chkVPrintOrder", "Print Orders", locator, null);
                VPrintOrderLabel = new Label(VPrintOrder);
                VPrintOrder.DataField = "VPrintOrder";
                VEmailOrder = new CheckBox("ctl00_phG_tab_t2_DefLocation_chkVEmailOrder", "Send Orders by Email", locator, null);
                VEmailOrderLabel = new Label(VEmailOrder);
                VEmailOrder.DataField = "VEmailOrder";
                VSiteID = new Selector("ctl00_phG_tab_t2_DefLocation_edVSiteID", "Warehouse", locator, null);
                VSiteIDLabel = new Label(VSiteID);
                VSiteID.DataField = "VSiteID";
                VShipTermsID = new Selector("ctl00_phG_tab_t2_DefLocation_edShipTermsID", "Shipping Terms", locator, null);
                VShipTermsIDLabel = new Label(VShipTermsID);
                VShipTermsID.DataField = "VShipTermsID";
                VCarrierID = new Selector("ctl00_phG_tab_t2_DefLocation_edVCarrierID", "Ship Via", locator, null);
                VCarrierIDLabel = new Label(VCarrierID);
                VCarrierID.DataField = "VCarrierID";
                VFOBPointID = new Selector("ctl00_phG_tab_t2_DefLocation_edFOBPointID", "FOB Point", locator, null);
                VFOBPointIDLabel = new Label(VFOBPointID);
                VFOBPointID.DataField = "VFOBPointID";
                VLeadTime = new PXNumberEdit("ctl00_phG_tab_t2_DefLocation_edLeadTime", "Lead Time (Days)", locator, null);
                VLeadTimeLabel = new Label(VLeadTime);
                VLeadTime.DataField = "VLeadTime";
                VAllowAPBillBeforeReceipt = new CheckBox("ctl00_phG_tab_t2_DefLocation_chkVAllowAPBillBeforeReceipt", "Allow AP Bill Before Receipt", locator, null);
                VAllowAPBillBeforeReceiptLabel = new Label(VAllowAPBillBeforeReceipt);
                VAllowAPBillBeforeReceipt.DataField = "VAllowAPBillBeforeReceipt";
                VRcptQtyMin = new PXNumberEdit("ctl00_phG_tab_t2_DefLocation_edVRcptQtyMin", "Min. Receipt (%)", locator, null);
                VRcptQtyMinLabel = new Label(VRcptQtyMin);
                VRcptQtyMin.DataField = "VRcptQtyMin";
                VRcptQtyMax = new PXNumberEdit("ctl00_phG_tab_t2_DefLocation_edVRcptQtyMax", "Max. Receipt (%)", locator, null);
                VRcptQtyMaxLabel = new Label(VRcptQtyMax);
                VRcptQtyMax.DataField = "VRcptQtyMax";
                VRcptQtyThreshold = new PXNumberEdit("ctl00_phG_tab_t2_DefLocation_edVRcptQtyThreshold", "Threshold Receipt (%)", locator, null);
                VRcptQtyThresholdLabel = new Label(VRcptQtyThreshold);
                VRcptQtyThreshold.DataField = "VRcptQtyThreshold";
                VRcptQtyAction = new DropDown("ctl00_phG_tab_t2_DefLocation_edVRcptQtyAction", "Receipt Action", locator, null);
                VRcptQtyActionLabel = new Label(VRcptQtyAction);
                VRcptQtyAction.DataField = "VRcptQtyAction";
                VRcptQtyAction.Items.Add("R", "Reject");
                VRcptQtyAction.Items.Add("W", "Accept but Warn");
                VRcptQtyAction.Items.Add("A", "Accept");
                DataMemberName = "DefLocation";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void VBranchIDEdit()
            {
                Buttons.VBranchIDEdit.Click();
            }
            
            public virtual void VTaxZoneIDEdit()
            {
                Buttons.VTaxZoneIDEdit.Click();
            }
            
            public virtual void VSiteIDEdit()
            {
                Buttons.VSiteIDEdit.Click();
            }
            
            public virtual void VShipTermsIDEdit()
            {
                Buttons.VShipTermsIDEdit.Click();
            }
            
            public virtual void VCarrierIDEdit()
            {
                Buttons.VCarrierIDEdit.Click();
            }
            
            public virtual void VFOBPointIDEdit()
            {
                Buttons.VFOBPointIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ViewonMap { get; }
			public Button VBranchIDEdit { get; }
			public Button VTaxZoneIDEdit { get; }
			public Button VSiteIDEdit { get; }
			public Button VShipTermsIDEdit { get; }
			public Button VCarrierIDEdit { get; }
			public Button VFOBPointIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ViewonMap = new Button("ctl00_phG_tab_t2_DefLocation_btnViewDefLoactionOnMap", "View on Map", "ctl00_phG_tab_t2_DefLocation");
                    VBranchIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_DefLocation_edVBranchID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "VBranchIDEdit", "ctl00_phG_tab_t2_DefLocation");
                    VBranchIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    VTaxZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_DefLocation_edTaxZoneID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "VTaxZoneIDEdit", "ctl00_phG_tab_t2_DefLocation");
                    VTaxZoneIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    VSiteIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_DefLocation_edVSiteID\'] div[class=\'editBtnCont\'] > d" +
                            "iv > div", "VSiteIDEdit", "ctl00_phG_tab_t2_DefLocation");
                    VSiteIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    VShipTermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_DefLocation_edShipTermsID\'] div[class=\'editBtnCont\']" +
                            " > div > div", "VShipTermsIDEdit", "ctl00_phG_tab_t2_DefLocation");
                    VShipTermsIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    VCarrierIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_DefLocation_edVCarrierID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "VCarrierIDEdit", "ctl00_phG_tab_t2_DefLocation");
                    VCarrierIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    VFOBPointIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_DefLocation_edFOBPointID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "VFOBPointIDEdit", "ctl00_phG_tab_t2_DefLocation");
                    VFOBPointIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_deflocation_deflocationglaccounts : Container
        {
            
			public Selector VAPAccountID { get; }
			public Label VAPAccountIDLabel { get; }
			public Selector VAPSubID { get; }
			public Label VAPSubIDLabel { get; }
			public Selector VExpenseAcctID { get; }
			public Label VExpenseAcctIDLabel { get; }
			public Selector VExpenseSubID { get; }
			public Label VExpenseSubIDLabel { get; }
			public Selector VDiscountAcctID { get; }
			public Label VDiscountAcctIDLabel { get; }
			public Selector VDiscountSubID { get; }
			public Label VDiscountSubIDLabel { get; }
            
            public c_deflocation_deflocationglaccounts(string locator, string name) : 
                    base(locator, name)
            {
                VAPAccountID = new Selector("ctl00_phG_tab_t7_DefLocationGLAccounts_edVAPAccountID", "AP Account", locator, null);
                VAPAccountIDLabel = new Label(VAPAccountID);
                VAPAccountID.DataField = "VAPAccountID";
                VAPSubID = new Selector("ctl00_phG_tab_t7_DefLocationGLAccounts_edVAPSubID", "AP Sub.", locator, null);
                VAPSubIDLabel = new Label(VAPSubID);
                VAPSubID.DataField = "VAPSubID";
                VExpenseAcctID = new Selector("ctl00_phG_tab_t7_DefLocationGLAccounts_edVExpenseAcctID", "Expense Account", locator, null);
                VExpenseAcctIDLabel = new Label(VExpenseAcctID);
                VExpenseAcctID.DataField = "VExpenseAcctID";
                VExpenseSubID = new Selector("ctl00_phG_tab_t7_DefLocationGLAccounts_edVExpenseSubID", "Expense Sub.", locator, null);
                VExpenseSubIDLabel = new Label(VExpenseSubID);
                VExpenseSubID.DataField = "VExpenseSubID";
                VDiscountAcctID = new Selector("ctl00_phG_tab_t7_DefLocationGLAccounts_edVDiscountAcctID", "Discount Account", locator, null);
                VDiscountAcctIDLabel = new Label(VDiscountAcctID);
                VDiscountAcctID.DataField = "VDiscountAcctID";
                VDiscountSubID = new Selector("ctl00_phG_tab_t7_DefLocationGLAccounts_edVDiscountSubID", "Discount Sub.", locator, null);
                VDiscountSubIDLabel = new Label(VDiscountSubID);
                VDiscountSubID.DataField = "VDiscountSubID";
                DataMemberName = "DefLocation";
            }
        }
        
        public class c_deflocation_formretainage : Container
        {
            
			public Selector VRetainageAcctID { get; }
			public Label VRetainageAcctIDLabel { get; }
			public Selector VRetainageSubID { get; }
			public Label VRetainageSubIDLabel { get; }
            
            public c_deflocation_formretainage(string locator, string name) : 
                    base(locator, name)
            {
                VRetainageAcctID = new Selector("ctl00_phG_tab_t7_formRetainage_edVRetainageAcctID", "Retainage Payable Account", locator, null);
                VRetainageAcctIDLabel = new Label(VRetainageAcctID);
                VRetainageAcctID.DataField = "VRetainageAcctID";
                VRetainageSubID = new Selector("ctl00_phG_tab_t7_formRetainage_edVRetainageSubID", "Retainage Payable Sub.", locator, null);
                VRetainageSubIDLabel = new Label(VRetainageSubID);
                VRetainageSubID.DataField = "VRetainageSubID";
                DataMemberName = "DefLocation";
            }
        }
        
        public class c_extcontacts_grdcontacts : Grid<c_extcontacts_grdcontacts.c_grid_row, c_extcontacts_grdcontacts.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_extcontacts_grdcontacts(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t4_grdContacts");
                DataMemberName = "ExtContacts";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t4_grdContacts_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void NewContact()
            {
                ToolBar.NewContact.Click();
            }
            
            public virtual void ViewContact()
            {
                ToolBar.ViewContact.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid NewContact { get; }
			public ToolBarButtonGrid ViewContact { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdContacts_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    NewContact = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdContacts_at_tlb div[data-cmd=\'NewContact\']", "Add Contact", locator, null);
                    ViewContact = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdContacts_at_tlb div[data-cmd=\'ViewContact\']", "Contact Details", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdContacts_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdContacts_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdContacts_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdContacts_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdContacts_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdContacts_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdContacts_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grdContacts_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXNumberEdit ContactBAccountID { get; }
			public PXNumberEdit ContactID { get; }
			public CheckBox IsActive { get; }
			public PXTextEdit Salutation { get; }
			public Selector ContactDisplayName { get; }
			public PXTextEdit City { get; }
			public PXTextEdit EMail { get; }
			public PXTextEdit Phone1 { get; }
                
                public c_grid_row(c_extcontacts_grdcontacts grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    ContactBAccountID = new PXNumberEdit("ctl00_phG_tab_t4_grdContacts_en", "Business Account ID", grid.Locator, "ContactBAccountID");
                    ContactBAccountID.DataField = "ContactBAccountID";
                    ContactID = new PXNumberEdit("ctl00_phG_tab_t4_grdContacts_en", "ContactID", grid.Locator, "ContactID");
                    ContactID.DataField = "ContactID";
                    IsActive = new CheckBox("ctl00_phG_tab_t4_grdContacts_ef", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    Salutation = new PXTextEdit("ctl00_phG_tab_t4_grdContacts_ei", "Job Title", grid.Locator, "Salutation");
                    Salutation.DataField = "Salutation";
                    ContactDisplayName = new Selector("_ctl00_phG_tab_t4_grdContacts_lv0_es", "Name", grid.Locator, "ContactDisplayName");
                    ContactDisplayName.DataField = "ContactDisplayName";
                    City = new PXTextEdit("ctl00_phG_tab_t4_grdContacts_ei", "City", grid.Locator, "City");
                    City.DataField = "City";
                    EMail = new PXTextEdit("ctl00_phG_tab_t4_grdContacts_ei", "Email", grid.Locator, "EMail");
                    EMail.DataField = "EMail";
                    Phone1 = new PXTextEdit("ctl00_phG_tab_t4_grdContacts_ei", "Phone 1", grid.Locator, "Phone1");
                    Phone1.DataField = "Phone1";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXNumberEditColumnFilter ContactBAccountID { get; }
				public PXNumberEditColumnFilter ContactID { get; }
				public CheckBoxColumnFilter IsActive { get; }
				public PXTextEditColumnFilter Salutation { get; }
				public SelectorColumnFilter ContactDisplayName { get; }
				public PXTextEditColumnFilter City { get; }
				public PXTextEditColumnFilter EMail { get; }
				public PXTextEditColumnFilter Phone1 { get; }
                
                public c_grid_header(c_extcontacts_grdcontacts grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    ContactBAccountID = new PXNumberEditColumnFilter(grid.Row.ContactBAccountID);
                    ContactID = new PXNumberEditColumnFilter(grid.Row.ContactID);
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    Salutation = new PXTextEditColumnFilter(grid.Row.Salutation);
                    ContactDisplayName = new SelectorColumnFilter(grid.Row.ContactDisplayName);
                    City = new PXTextEditColumnFilter(grid.Row.City);
                    EMail = new PXTextEditColumnFilter(grid.Row.EMail);
                    Phone1 = new PXTextEditColumnFilter(grid.Row.Phone1);
                }
            }
        }
        
        public class c_extcontacts_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_extcontacts_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t4_grdContacts_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "ExtContacts";
            }
        }
        
        public class c_paymentdetails_grdpaymentdetails : Grid<c_paymentdetails_grdpaymentdetails.c_grid_row, c_paymentdetails_grdpaymentdetails.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_paymentdetails_grdpaymentdetails(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "PaymentDetails";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ViewonMap { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    ViewonMap = new Button("ctl00_phG_tab_t1_DefLocationPayment_RemitAddress_btnViewRemitOnMap", "View on Map", "ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails");
                    First = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfFirst0", "First", "ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails");
                    Prev = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfPrev0", "Prev", "ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails");
                    Next = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfNext0", "Next", "ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails");
                    Last = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfLast0", "Last", "ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public InputLocalizable PaymentMethodDetail__descr { get; }
			public PXTextEdit DetailValue { get; }
			public PXNumberEdit BAccountID { get; }
			public PXNumberEdit LocationID { get; }
			public Selector PaymentMethodID { get; }
			public Selector DetailID { get; }
                
                public c_grid_row(c_paymentdetails_grdpaymentdetails grid) : 
                        base(grid)
                {
                    PaymentMethodDetail__descr = new InputLocalizable("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_ei", "Description", grid.Locator, "PaymentMethodDetail__descr");
                    PaymentMethodDetail__descr.DataField = "PaymentMethodDetail__descr";
                    DetailValue = new PXTextEdit("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_ei", "Value", grid.Locator, "DetailValue");
                    DetailValue.DataField = "DetailValue";
                    BAccountID = new PXNumberEdit("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_en", "BAccountID", grid.Locator, "BAccountID");
                    BAccountID.DataField = "BAccountID";
                    LocationID = new PXNumberEdit("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_en", "LocationID", grid.Locator, "LocationID");
                    LocationID.DataField = "LocationID";
                    PaymentMethodID = new Selector("_ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lv0_es", "Payment Method", grid.Locator, "PaymentMethodID");
                    PaymentMethodID.DataField = "PaymentMethodID";
                    DetailID = new Selector("_ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lv0_es", "ID", grid.Locator, "DetailID");
                    DetailID.DataField = "DetailID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter PaymentMethodDetail__descr { get; }
				public PXTextEditColumnFilter DetailValue { get; }
				public PXNumberEditColumnFilter BAccountID { get; }
				public PXNumberEditColumnFilter LocationID { get; }
				public SelectorColumnFilter PaymentMethodID { get; }
				public SelectorColumnFilter DetailID { get; }
                
                public c_grid_header(c_paymentdetails_grdpaymentdetails grid) : 
                        base(grid)
                {
                    PaymentMethodDetail__descr = new PXTextEditColumnFilter(grid.Row.PaymentMethodDetail__descr);
                    DetailValue = new PXTextEditColumnFilter(grid.Row.DetailValue);
                    BAccountID = new PXNumberEditColumnFilter(grid.Row.BAccountID);
                    LocationID = new PXNumberEditColumnFilter(grid.Row.LocationID);
                    PaymentMethodID = new SelectorColumnFilter(grid.Row.PaymentMethodID);
                    DetailID = new SelectorColumnFilter(grid.Row.DetailID);
                }
            }
        }
        
        public class c_paymentdetails_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_paymentdetails_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "PaymentDetails";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ViewonMap { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    ViewonMap = new Button("ctl00_phG_tab_t1_DefLocationPayment_RemitAddress_btnViewRemitOnMap", "View on Map", "ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lv0");
                    First = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfFirst0", "First", "ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lv0");
                    Prev = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfPrev0", "Prev", "ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lv0");
                    Next = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfNext0", "Next", "ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lv0");
                    Last = new Button("ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lfLast0", "Last", "ctl00_phG_tab_t1_DefLocationPayment_grdPaymentDetails_lv0");
                }
            }
        }
        
        public class c_vendorbalance_vendorbalance : Container
        {
            
			public PXNumberEdit Balance { get; }
			public Label BalanceLabel { get; }
			public PXNumberEdit DepositsBalance { get; }
			public Label DepositsBalanceLabel { get; }
			public PXNumberEdit RetainageBalance { get; }
			public Label RetainageBalanceLabel { get; }
            
            public c_vendorbalance_vendorbalance(string locator, string name) : 
                    base(locator, name)
            {
                Balance = new PXNumberEdit("ctl00_phF_BAccount_t0_VendorBalance_edBalance", "Balance", locator, null);
                BalanceLabel = new Label(Balance);
                Balance.DataField = "Balance";
                DepositsBalance = new PXNumberEdit("ctl00_phF_BAccount_t0_VendorBalance_edDepositsBalance", "Prepayment Balance", locator, null);
                DepositsBalanceLabel = new Label(DepositsBalance);
                DepositsBalance.DataField = "DepositsBalance";
                RetainageBalance = new PXNumberEdit("ctl00_phF_BAccount_t0_VendorBalance_edRetainageBalance", "Retained Balance", locator, null);
                RetainageBalanceLabel = new Label(RetainageBalance);
                RetainageBalance.DataField = "RetainageBalance";
                DataMemberName = "VendorBalance";
            }
        }
        
        public class c_notificationsources_gridns : Grid<c_notificationsources_gridns.c_grid_row, c_notificationsources_gridns.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_notificationsources_gridns(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t9_sp1_gridNS");
                DataMemberName = "NotificationSources";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t9_sp1_gridNS_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public virtual void ContactIDEdit()
            {
                Buttons.ContactIDEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNS_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNS_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNS_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNS_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNS_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNS_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNS_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNS_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNS_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNS_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNS_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t9_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phG_tab_t9_sp1_gridNS");
                    ContactIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector SetupID { get; }
			public Selector NBranchID { get; }
			public Selector EMailAccountID { get; }
			public Selector ReportID { get; }
			public Selector NotificationID { get; }
			public DropDown Format { get; }
			public CheckBox Active { get; }
			public CheckBox OverrideSource { get; }
			public PXNumberEdit SourceID { get; }
                
                public c_grid_row(c_notificationsources_gridns grid) : 
                        base(grid)
                {
                    SetupID = new Selector("_ctl00_phG_tab_t9_sp1_gridNS_lv0_edSetupID", "Mailing ID", grid.Locator, "SetupID");
                    SetupID.DataField = "SetupID";
                    NBranchID = new Selector("_ctl00_phG_tab_t9_sp1_gridNS_lv0_edNBranchID", "Branch", grid.Locator, "NBranchID");
                    NBranchID.DataField = "NBranchID";
                    EMailAccountID = new Selector("_ctl00_phG_tab_t9_sp1_gridNS_lv0_edEMailAccountID", "Email Account", grid.Locator, "EMailAccountID");
                    EMailAccountID.DataField = "EMailAccountID";
                    ReportID = new Selector("_ctl00_phG_tab_t9_sp1_gridNS_lv0_edReportID", "Report", grid.Locator, "ReportID");
                    ReportID.DataField = "ReportID";
                    NotificationID = new Selector("_ctl00_phG_tab_t9_sp1_gridNS_lv0_edNotificationID", "Notification Template", grid.Locator, "NotificationID");
                    NotificationID.DataField = "NotificationID";
                    Format = new DropDown("_ctl00_phG_tab_t9_sp1_gridNS_lv0_edFormat", "Format", grid.Locator, "Format");
                    Format.DataField = "Format";
                    Format.Items.Add("H", "Html");
                    Format.Items.Add("E", "Excel");
                    Format.Items.Add("P", "PDF");
                    Active = new CheckBox("_ctl00_phG_tab_t9_sp1_gridNS_lv0_chkActive", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    OverrideSource = new CheckBox("ctl00_phG_tab_t9_sp1_gridNS_ef", "Overridden", grid.Locator, "OverrideSource");
                    OverrideSource.DataField = "OverrideSource";
                    SourceID = new PXNumberEdit("ctl00_phG_tab_t9_sp1_gridNS_en", "SourceID", grid.Locator, "SourceID");
                    SourceID.DataField = "SourceID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter SetupID { get; }
				public SelectorColumnFilter NBranchID { get; }
				public SelectorColumnFilter EMailAccountID { get; }
				public SelectorColumnFilter ReportID { get; }
				public SelectorColumnFilter NotificationID { get; }
				public DropDownColumnFilter Format { get; }
				public CheckBoxColumnFilter Active { get; }
				public CheckBoxColumnFilter OverrideSource { get; }
				public PXNumberEditColumnFilter SourceID { get; }
                
                public c_grid_header(c_notificationsources_gridns grid) : 
                        base(grid)
                {
                    SetupID = new SelectorColumnFilter(grid.Row.SetupID);
                    NBranchID = new SelectorColumnFilter(grid.Row.NBranchID);
                    EMailAccountID = new SelectorColumnFilter(grid.Row.EMailAccountID);
                    ReportID = new SelectorColumnFilter(grid.Row.ReportID);
                    NotificationID = new SelectorColumnFilter(grid.Row.NotificationID);
                    Format = new DropDownColumnFilter(grid.Row.Format);
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    OverrideSource = new CheckBoxColumnFilter(grid.Row.OverrideSource);
                    SourceID = new PXNumberEditColumnFilter(grid.Row.SourceID);
                }
            }
        }
        
        public class c_notificationsources_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown Format { get; }
			public Label FormatLabel { get; }
			public Selector NBranchID { get; }
			public Label NBranchIDLabel { get; }
			public CheckBox Active { get; }
			public Label ActiveLabel { get; }
			public Selector SetupID { get; }
			public Label SetupIDLabel { get; }
			public Selector ReportID { get; }
			public Label ReportIDLabel { get; }
			public Selector NotificationID { get; }
			public Label NotificationIDLabel { get; }
			public Selector EMailAccountID { get; }
			public Label EMailAccountIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_notificationsources_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Format = new DropDown("ctl00_phG_tab_t9_sp1_gridNS_lv0_edFormat", "Format", locator, null);
                FormatLabel = new Label(Format);
                Format.DataField = "Format";
                Format.Items.Add("H", "Html");
                Format.Items.Add("E", "Excel");
                Format.Items.Add("P", "PDF");
                NBranchID = new Selector("ctl00_phG_tab_t9_sp1_gridNS_lv0_edNBranchID", "Branch", locator, null);
                NBranchIDLabel = new Label(NBranchID);
                NBranchID.DataField = "NBranchID";
                Active = new CheckBox("ctl00_phG_tab_t9_sp1_gridNS_lv0_chkActive", "Active", locator, null);
                ActiveLabel = new Label(Active);
                Active.DataField = "Active";
                SetupID = new Selector("ctl00_phG_tab_t9_sp1_gridNS_lv0_edSetupID", "Mailing ID", locator, null);
                SetupIDLabel = new Label(SetupID);
                SetupID.DataField = "SetupID";
                ReportID = new Selector("ctl00_phG_tab_t9_sp1_gridNS_lv0_edReportID", "Report", locator, null);
                ReportIDLabel = new Label(ReportID);
                ReportID.DataField = "ReportID";
                NotificationID = new Selector("ctl00_phG_tab_t9_sp1_gridNS_lv0_edNotificationID", "Notification Template", locator, null);
                NotificationIDLabel = new Label(NotificationID);
                NotificationID.DataField = "NotificationID";
                EMailAccountID = new Selector("ctl00_phG_tab_t9_sp1_gridNS_lv0_edEMailAccountID", "Email Account", locator, null);
                EMailAccountIDLabel = new Label(EMailAccountID);
                EMailAccountID.DataField = "EMailAccountID";
                Es = new Selector("ctl00_phG_tab_t9_sp1_gridNS_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "NotificationSources";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ContactIDEdit()
            {
                Buttons.ContactIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t9_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phG_tab_t9_sp1_gridNS_lv0");
                    ContactIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_notificationrecipients_gridnr : Grid<c_notificationrecipients_gridnr.c_grid_row, c_notificationrecipients_gridnr.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_notificationrecipients_gridnr(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t9_sp1_gridNR");
                DataMemberName = "NotificationRecipients";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t9_sp1_gridNR_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public virtual void ContactIDEdit()
            {
                Buttons.ContactIDEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNR_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNR_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNR_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNR_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNR_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNR_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNR_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNR_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNR_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNR_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_sp1_gridNR_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t9_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phG_tab_t9_sp1_gridNR");
                    ContactIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public DropDown ContactType { get; }
			public PXNumberEdit OriginalContactID { get; }
			public Selector ContactID { get; }
			public PXTextEdit Email { get; }
			public DropDown Format { get; }
			public CheckBox Active { get; }
			public CheckBox Hidden { get; }
			public PXNumberEdit NotificationID { get; }
                
                public c_grid_row(c_notificationrecipients_gridnr grid) : 
                        base(grid)
                {
                    ContactType = new DropDown("_ctl00_phG_tab_t9_sp1_gridNR_lv0_edContactType", "Contact Type", grid.Locator, "ContactType");
                    ContactType.DataField = "ContactType";
                    ContactType.Items.Add("P", "Primary");
                    ContactType.Items.Add("R", "Remittance");
                    ContactType.Items.Add("S", "Shipping");
                    ContactType.Items.Add("E", "Employee");
                    ContactType.Items.Add("C", "Contact");
                    OriginalContactID = new PXNumberEdit("ctl00_phG_tab_t9_sp1_gridNR_en", "OriginalContactID", grid.Locator, "OriginalContactID");
                    OriginalContactID.DataField = "OriginalContactID";
                    ContactID = new Selector("_ctl00_phG_tab_t9_sp1_gridNR_lv0_edContactID", "Contact ID", grid.Locator, "ContactID");
                    ContactID.DataField = "ContactID";
                    Email = new PXTextEdit("ctl00_phG_tab_t9_sp1_gridNR_ei", "Email", grid.Locator, "Email");
                    Email.DataField = "Email";
                    Format = new DropDown("_ctl00_phG_tab_t9_sp1_gridNR_lv0_ec", "Format", grid.Locator, "Format");
                    Format.DataField = "Format";
                    Format.Items.Add("H", "Html");
                    Format.Items.Add("E", "Excel");
                    Format.Items.Add("P", "PDF");
                    Active = new CheckBox("ctl00_phG_tab_t9_sp1_gridNR_ef", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    Hidden = new CheckBox("ctl00_phG_tab_t9_sp1_gridNR_ef", "Bcc", grid.Locator, "Hidden");
                    Hidden.DataField = "Hidden";
                    NotificationID = new PXNumberEdit("ctl00_phG_tab_t9_sp1_gridNR_en", "NotificationID", grid.Locator, "NotificationID");
                    NotificationID.DataField = "NotificationID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public DropDownColumnFilter ContactType { get; }
				public PXNumberEditColumnFilter OriginalContactID { get; }
				public SelectorColumnFilter ContactID { get; }
				public PXTextEditColumnFilter Email { get; }
				public DropDownColumnFilter Format { get; }
				public CheckBoxColumnFilter Active { get; }
				public CheckBoxColumnFilter Hidden { get; }
				public PXNumberEditColumnFilter NotificationID { get; }
                
                public c_grid_header(c_notificationrecipients_gridnr grid) : 
                        base(grid)
                {
                    ContactType = new DropDownColumnFilter(grid.Row.ContactType);
                    OriginalContactID = new PXNumberEditColumnFilter(grid.Row.OriginalContactID);
                    ContactID = new SelectorColumnFilter(grid.Row.ContactID);
                    Email = new PXTextEditColumnFilter(grid.Row.Email);
                    Format = new DropDownColumnFilter(grid.Row.Format);
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    Hidden = new CheckBoxColumnFilter(grid.Row.Hidden);
                    NotificationID = new PXNumberEditColumnFilter(grid.Row.NotificationID);
                }
            }
        }
        
        public class c_notificationrecipients_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown ContactType { get; }
			public Label ContactTypeLabel { get; }
			public Selector ContactID { get; }
			public Label ContactIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_notificationrecipients_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ContactType = new DropDown("ctl00_phG_tab_t9_sp1_gridNR_lv0_edContactType", "Contact Type", locator, null);
                ContactTypeLabel = new Label(ContactType);
                ContactType.DataField = "ContactType";
                ContactType.Items.Add("P", "Primary");
                ContactType.Items.Add("R", "Remittance");
                ContactType.Items.Add("S", "Shipping");
                ContactType.Items.Add("E", "Employee");
                ContactType.Items.Add("C", "Contact");
                ContactID = new Selector("ctl00_phG_tab_t9_sp1_gridNR_lv0_edContactID", "Contact ID", locator, null);
                ContactIDLabel = new Label(ContactID);
                ContactID.DataField = "ContactID";
                Es = new Selector("ctl00_phG_tab_t9_sp1_gridNR_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t9_sp1_gridNR_lv0_ec", "Ec", locator, null);
                DataMemberName = "NotificationRecipients";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ContactIDEdit()
            {
                Buttons.ContactIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t9_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phG_tab_t9_sp1_gridNR_lv0");
                    ContactIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_activities_activities_grid : Grid<c_activities_activities_grid.c_grid_row, c_activities_activities_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_activities_activities_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t6_gridActivities_Activities_grid");
                DataMemberName = "Activities";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t6_gridActivities_Activities_grid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void AddTask()
            {
                ToolBar.AddTask.Click();
            }
            
            public virtual void AddEvent()
            {
                ToolBar.AddEvent.Click();
            }
            
            public virtual void AddEmail()
            {
                ToolBar.AddEmail.Click();
            }
            
            public virtual void AddActivity()
            {
                ToolBar.AddActivity.Click();
            }
            
            public virtual void AddNote()
            {
                ToolBar.AddNote.Click();
            }
            
            public virtual void AddChat()
            {
                ToolBar.AddChat.Click();
            }
            
            public virtual void AddAppointment()
            {
                ToolBar.AddAppointment.Click();
            }
            
            public virtual void AddMessage()
            {
                ToolBar.AddMessage.Click();
            }
            
            public virtual void AddPhoneCall()
            {
                ToolBar.AddPhoneCall.Click();
            }
            
            public virtual void AddWorkItem()
            {
                ToolBar.AddWorkItem.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid AddTask { get; }
			public ToolBarButtonGrid AddEvent { get; }
			public ToolBarButtonGrid AddEmail { get; }
			public ToolBarButtonGrid AddActivity { get; }
			public ToolBarButtonGrid AddNote { get; }
			public ToolBarButtonGrid AddChat { get; }
			public ToolBarButtonGrid AddAppointment { get; }
			public ToolBarButtonGrid AddMessage { get; }
			public ToolBarButtonGrid AddPhoneCall { get; }
			public ToolBarButtonGrid AddWorkItem { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_gridActivities_Activities_grid_at_tlb div[data-cmd=\'Refresh" +
                            "\']", "Refresh", locator, null);
                    AddTask = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_gridActivities_Activities_grid_at_tlb div[data-cmd=\'cmdAddT" +
                            "ask\']", "Add Task", locator, null);
                    AddEvent = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_gridActivities_Activities_grid_at_tlb div[data-cmd=\'cmdAddE" +
                            "vent\']", "Add Event", locator, null);
                    AddEmail = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_gridActivities_Activities_grid_at_tlb div[data-cmd=\'cmdAddE" +
                            "mail\']", "Add Email", locator, null);
                    AddActivity = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_gridActivities_Activities_grid_at_tlb div[data-cmd=\'cmdAddA" +
                            "ctivity\']", "Add Activity", locator, null);
                    AddNote = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t6_gridActivities_Activities_grid_at_tlb_menucmdAddActivity" +
                            " li[data-cmd=\'NewActivity@N    \']", "Add Note", locator, AddActivity);
                    AddChat = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t6_gridActivities_Activities_grid_at_tlb_menucmdAddActivity" +
                            " li[data-cmd=\'NewActivity@C    \']", "Add Chat", locator, AddActivity);
                    AddAppointment = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t6_gridActivities_Activities_grid_at_tlb_menucmdAddActivity" +
                            " li[data-cmd=\'NewActivity@E    \']", "Add Appointment", locator, AddActivity);
                    AddMessage = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t6_gridActivities_Activities_grid_at_tlb_menucmdAddActivity" +
                            " li[data-cmd=\'NewActivity@M    \']", "Add Message", locator, AddActivity);
                    AddPhoneCall = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t6_gridActivities_Activities_grid_at_tlb_menucmdAddActivity" +
                            " li[data-cmd=\'NewActivity@P    \']", "Add Phone Call", locator, AddActivity);
                    AddWorkItem = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t6_gridActivities_Activities_grid_at_tlb_menucmdAddActivity" +
                            " li[data-cmd=\'NewActivity@W    \']", "Add Work Item", locator, AddActivity);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_gridActivities_Activities_grid_at_tlb div[data-cmd=\'AdjustC" +
                            "olumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_gridActivities_Activities_grid_at_tlb div[data-cmd=\'ExportE" +
                            "xcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_gridActivities_Activities_grid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_gridActivities_Activities_grid_ab_tlb div[data-cmd=\'PageFir" +
                            "st\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_gridActivities_Activities_grid_ab_tlb div[data-cmd=\'PagePre" +
                            "v\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_gridActivities_Activities_grid_ab_tlb div[data-cmd=\'PageNex" +
                            "t\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_gridActivities_Activities_grid_ab_tlb div[data-cmd=\'PageLas" +
                            "t\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_gridActivities_Activities_grid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXTextEdit IsCompleteIcon { get; }
			public PXTextEdit PriorityIcon { get; }
			public PXTextEdit CRReminder__ReminderIcon { get; }
			public PXTextEdit ClassIcon { get; }
			public PXTextEdit ClassInfo { get; }
			public PXTextEdit RefNoteID { get; }
			public Selector Subject { get; }
			public DropDown UIStatus { get; }
			public CheckBox Released { get; }
			public DateSelector StartDate { get; }
			public DateSelector CreatedDateTime { get; }
			public DropDown TimeSpent { get; }
			public Selector CreatedByID { get; }
			public PXTextEdit CreatedByID_Creator_Username { get; }
			public Selector WorkgroupID { get; }
			public Selector OwnerID { get; }
			public Selector ProjectID { get; }
			public Selector ProjectTaskID { get; }
			public PXTextEdit Source { get; }
			public PXTextEdit NoteID { get; }
                
                public c_grid_row(c_activities_activities_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    IsCompleteIcon = new PXTextEdit("ctl00_phG_tab_t6_gridActivities_Activities_grid_ei", "Complete Icon", grid.Locator, "IsCompleteIcon");
                    IsCompleteIcon.DataField = "IsCompleteIcon";
                    PriorityIcon = new PXTextEdit("ctl00_phG_tab_t6_gridActivities_Activities_grid_ei", "Priority Icon", grid.Locator, "PriorityIcon");
                    PriorityIcon.DataField = "PriorityIcon";
                    CRReminder__ReminderIcon = new PXTextEdit("ctl00_phG_tab_t6_gridActivities_Activities_grid_ei", "Reminder Icon", grid.Locator, "CRReminder__ReminderIcon");
                    CRReminder__ReminderIcon.DataField = "CRReminder__ReminderIcon";
                    ClassIcon = new PXTextEdit("ctl00_phG_tab_t6_gridActivities_Activities_grid_ei", "Class Icon", grid.Locator, "ClassIcon");
                    ClassIcon.DataField = "ClassIcon";
                    ClassInfo = new PXTextEdit("ctl00_phG_tab_t6_gridActivities_Activities_grid_ei", "Type", grid.Locator, "ClassInfo");
                    ClassInfo.DataField = "ClassInfo";
                    RefNoteID = new PXTextEdit("ctl00_phG_tab_t6_gridActivities_Activities_grid_ei", "RefNoteID", grid.Locator, "RefNoteID");
                    RefNoteID.DataField = "RefNoteID";
                    Subject = new Selector("_ctl00_phG_tab_t6_gridActivities_Activities_grid_lv0_es", "Summary", grid.Locator, "Subject");
                    Subject.DataField = "Subject";
                    UIStatus = new DropDown("_ctl00_phG_tab_t6_gridActivities_Activities_grid_lv0_ec", "Status", grid.Locator, "UIStatus");
                    UIStatus.DataField = "UIStatus";
                    UIStatus.Items.Add("DR", "Draft");
                    UIStatus.Items.Add("OP", "Open");
                    UIStatus.Items.Add("IP", "Processing");
                    UIStatus.Items.Add("CD", "Completed");
                    UIStatus.Items.Add("AP", "Approved");
                    UIStatus.Items.Add("RJ", "Rejected");
                    UIStatus.Items.Add("CL", "Canceled");
                    UIStatus.Items.Add("PA", "Pending Approval");
                    UIStatus.Items.Add("RL", "Released");
                    Released = new CheckBox("ctl00_phG_tab_t6_gridActivities_Activities_grid", "Released", grid.Locator, "Released");
                    Released.DataField = "Released";
                    StartDate = new DateSelector("_ctl00_phG_tab_t6_gridActivities_Activities_grid_lv0_ed11", "Start Date", grid.Locator, "StartDate");
                    StartDate.DataField = "StartDate";
                    CreatedDateTime = new DateSelector("_ctl00_phG_tab_t6_gridActivities_Activities_grid_lv0_ed12", "Created At", grid.Locator, "CreatedDateTime");
                    CreatedDateTime.DataField = "CreatedDateTime";
                    TimeSpent = new DropDown("_ctl00_phG_tab_t6_gridActivities_Activities_grid_lv0_ec", "Time Spent", grid.Locator, "TimeSpent");
                    TimeSpent.DataField = "TimeSpent";
                    TimeSpent.Items.Add("0", "00:00");
                    TimeSpent.Items.Add("30", "00:30");
                    TimeSpent.Items.Add("60", "01:00");
                    TimeSpent.Items.Add("90", "01:30");
                    TimeSpent.Items.Add("120", "02:00");
                    TimeSpent.Items.Add("150", "02:30");
                    TimeSpent.Items.Add("180", "03:00");
                    TimeSpent.Items.Add("210", "03:30");
                    TimeSpent.Items.Add("240", "04:00");
                    TimeSpent.Items.Add("270", "04:30");
                    TimeSpent.Items.Add("300", "05:00");
                    TimeSpent.Items.Add("330", "05:30");
                    TimeSpent.Items.Add("360", "06:00");
                    TimeSpent.Items.Add("390", "06:30");
                    TimeSpent.Items.Add("420", "07:00");
                    TimeSpent.Items.Add("450", "07:30");
                    TimeSpent.Items.Add("480", "08:00");
                    TimeSpent.Items.Add("510", "08:30");
                    TimeSpent.Items.Add("540", "09:00");
                    TimeSpent.Items.Add("570", "09:30");
                    TimeSpent.Items.Add("600", "10:00");
                    TimeSpent.Items.Add("630", "10:30");
                    TimeSpent.Items.Add("660", "11:00");
                    TimeSpent.Items.Add("690", "11:30");
                    TimeSpent.Items.Add("720", "12:00");
                    TimeSpent.Items.Add("750", "12:30");
                    TimeSpent.Items.Add("780", "13:00");
                    TimeSpent.Items.Add("810", "13:30");
                    TimeSpent.Items.Add("840", "14:00");
                    TimeSpent.Items.Add("870", "14:30");
                    TimeSpent.Items.Add("900", "15:00");
                    TimeSpent.Items.Add("930", "15:30");
                    TimeSpent.Items.Add("960", "16:00");
                    TimeSpent.Items.Add("990", "16:30");
                    TimeSpent.Items.Add("1020", "17:00");
                    TimeSpent.Items.Add("1050", "17:30");
                    TimeSpent.Items.Add("1080", "18:00");
                    TimeSpent.Items.Add("1110", "18:30");
                    TimeSpent.Items.Add("1140", "19:00");
                    TimeSpent.Items.Add("1170", "19:30");
                    TimeSpent.Items.Add("1200", "20:00");
                    TimeSpent.Items.Add("1230", "20:30");
                    TimeSpent.Items.Add("1260", "21:00");
                    TimeSpent.Items.Add("1290", "21:30");
                    TimeSpent.Items.Add("1320", "22:00");
                    TimeSpent.Items.Add("1350", "22:30");
                    TimeSpent.Items.Add("1380", "23:00");
                    TimeSpent.Items.Add("1410", "23:30");
                    CreatedByID = new Selector("_ctl00_phG_tab_t6_gridActivities_Activities_grid_lv0_es", "CreatedByID", grid.Locator, "CreatedByID");
                    CreatedByID.DataField = "CreatedByID";
                    CreatedByID_Creator_Username = new PXTextEdit("ctl00_phG_tab_t6_gridActivities_Activities_grid_ei", "Created By", grid.Locator, "CreatedByID_Creator_Username");
                    CreatedByID_Creator_Username.DataField = "CreatedByID_Creator_Username";
                    WorkgroupID = new Selector("_ctl00_phG_tab_t6_gridActivities_Activities_grid_lv0_es", "Workgroup", grid.Locator, "WorkgroupID");
                    WorkgroupID.DataField = "WorkgroupID";
                    OwnerID = new Selector("_ctl00_phG_tab_t6_gridActivities_Activities_grid_lv0_es", "Owner", grid.Locator, "OwnerID");
                    OwnerID.DataField = "OwnerID";
                    ProjectID = new Selector("_ctl00_phG_tab_t6_gridActivities_Activities_grid_lv0_es", "Project", grid.Locator, "ProjectID");
                    ProjectID.DataField = "ProjectID";
                    ProjectTaskID = new Selector("_ctl00_phG_tab_t6_gridActivities_Activities_grid_lv0_es", "Project Task", grid.Locator, "ProjectTaskID");
                    ProjectTaskID.DataField = "ProjectTaskID";
                    Source = new PXTextEdit("ctl00_phG_tab_t6_gridActivities_Activities_grid_ei", "Related Entity Description", grid.Locator, "Source");
                    Source.DataField = "Source";
                    NoteID = new PXTextEdit("ctl00_phG_tab_t6_gridActivities_Activities_grid_ei", "NoteID", grid.Locator, "NoteID");
                    NoteID.DataField = "NoteID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXTextEditColumnFilter IsCompleteIcon { get; }
				public PXTextEditColumnFilter PriorityIcon { get; }
				public PXTextEditColumnFilter CRReminder__ReminderIcon { get; }
				public PXTextEditColumnFilter ClassIcon { get; }
				public PXTextEditColumnFilter ClassInfo { get; }
				public PXTextEditColumnFilter RefNoteID { get; }
				public SelectorColumnFilter Subject { get; }
				public DropDownColumnFilter UIStatus { get; }
				public CheckBoxColumnFilter Released { get; }
				public DateSelectorColumnFilter StartDate { get; }
				public DateSelectorColumnFilter CreatedDateTime { get; }
				public DropDownColumnFilter TimeSpent { get; }
				public SelectorColumnFilter CreatedByID { get; }
				public PXTextEditColumnFilter CreatedByID_Creator_Username { get; }
				public SelectorColumnFilter WorkgroupID { get; }
				public SelectorColumnFilter OwnerID { get; }
				public SelectorColumnFilter ProjectID { get; }
				public SelectorColumnFilter ProjectTaskID { get; }
				public PXTextEditColumnFilter Source { get; }
				public PXTextEditColumnFilter NoteID { get; }
                
                public c_grid_header(c_activities_activities_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    IsCompleteIcon = new PXTextEditColumnFilter(grid.Row.IsCompleteIcon);
                    PriorityIcon = new PXTextEditColumnFilter(grid.Row.PriorityIcon);
                    CRReminder__ReminderIcon = new PXTextEditColumnFilter(grid.Row.CRReminder__ReminderIcon);
                    ClassIcon = new PXTextEditColumnFilter(grid.Row.ClassIcon);
                    ClassInfo = new PXTextEditColumnFilter(grid.Row.ClassInfo);
                    RefNoteID = new PXTextEditColumnFilter(grid.Row.RefNoteID);
                    Subject = new SelectorColumnFilter(grid.Row.Subject);
                    UIStatus = new DropDownColumnFilter(grid.Row.UIStatus);
                    Released = new CheckBoxColumnFilter(grid.Row.Released);
                    StartDate = new DateSelectorColumnFilter(grid.Row.StartDate);
                    CreatedDateTime = new DateSelectorColumnFilter(grid.Row.CreatedDateTime);
                    TimeSpent = new DropDownColumnFilter(grid.Row.TimeSpent);
                    CreatedByID = new SelectorColumnFilter(grid.Row.CreatedByID);
                    CreatedByID_Creator_Username = new PXTextEditColumnFilter(grid.Row.CreatedByID_Creator_Username);
                    WorkgroupID = new SelectorColumnFilter(grid.Row.WorkgroupID);
                    OwnerID = new SelectorColumnFilter(grid.Row.OwnerID);
                    ProjectID = new SelectorColumnFilter(grid.Row.ProjectID);
                    ProjectTaskID = new SelectorColumnFilter(grid.Row.ProjectTaskID);
                    Source = new PXTextEditColumnFilter(grid.Row.Source);
                    NoteID = new PXTextEditColumnFilter(grid.Row.NoteID);
                }
            }
        }
        
        public class c_activities_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_activities_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t6_gridActivities_Activities_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t6_gridActivities_Activities_grid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t6_gridActivities_Activities_grid_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t6_gridActivities_Activities_grid_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Activities";
            }
        }
        
        public class c_activities_preview_activities_form : Container
        {
            
			public RichTextEdit Body { get; }
			public Label BodyLabel { get; }
            
            public c_activities_preview_activities_form(string locator, string name) : 
                    base(locator, name)
            {
                Body = new RichTextEdit("ctl00_phG_tab_t6_gridActivities_Activities_form_edBody", "Body", locator, null);
                BodyLabel = new Label(Body);
                Body.DataField = "body";
                DataMemberName = "Activities$Preview";
            }
        }
        
        public class c_answers_pxgridanswers : Grid<c_answers_pxgridanswers.c_grid_row, c_answers_pxgridanswers.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_answers_pxgridanswers(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t5_PXGridAnswers");
                DataMemberName = "Answers";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t5_PXGridAnswers_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridAnswers_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridAnswers_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridAnswers_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridAnswers_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridAnswers_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridAnswers_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridAnswers_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridAnswers_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridAnswers_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector AttributeID { get; }
			public CheckBox IsRequired { get; }
			public PXTextEdit Value { get; }
			public PXTextEdit RefNoteID { get; }
                
                public c_grid_row(c_answers_pxgridanswers grid) : 
                        base(grid)
                {
                    AttributeID = new Selector("_ctl00_phG_tab_t5_PXGridAnswers_lv0_es", "Attribute", grid.Locator, "AttributeID");
                    AttributeID.DataField = "AttributeID";
                    IsRequired = new CheckBox("ctl00_phG_tab_t5_PXGridAnswers", "Required", grid.Locator, "isRequired");
                    IsRequired.DataField = "isRequired";
                    Value = new PXTextEdit("ctl00_phG_tab_t5_PXGridAnswers_ei", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                    RefNoteID = new PXTextEdit("ctl00_phG_tab_t5_PXGridAnswers_ei", "RefNoteID", grid.Locator, "RefNoteID");
                    RefNoteID.DataField = "RefNoteID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter AttributeID { get; }
				public CheckBoxColumnFilter IsRequired { get; }
				public PXTextEditColumnFilter Value { get; }
				public PXTextEditColumnFilter RefNoteID { get; }
                
                public c_grid_header(c_answers_pxgridanswers grid) : 
                        base(grid)
                {
                    AttributeID = new SelectorColumnFilter(grid.Row.AttributeID);
                    IsRequired = new CheckBoxColumnFilter(grid.Row.IsRequired);
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                    RefNoteID = new PXTextEditColumnFilter(grid.Row.RefNoteID);
                }
            }
        }
        
        public class c_answers_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_answers_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t5_PXGridAnswers_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t5_PXGridAnswers_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t5_PXGridAnswers_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t5_PXGridAnswers_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Answers";
            }
        }
        
        public class c_suppliedbyvendors_pxgridsuppliedbyvendors : Grid<c_suppliedbyvendors_pxgridsuppliedbyvendors.c_grid_row, c_suppliedbyvendors_pxgridsuppliedbyvendors.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_suppliedbyvendors_pxgridsuppliedbyvendors(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t10_PXGridSuppliedByVendors");
                DataMemberName = "SuppliedByVendors";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t10_PXGridSuppliedByVendors_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_PXGridSuppliedByVendors_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_PXGridSuppliedByVendors_at_tlb div[data-cmd=\'AdjustColumns" +
                            "\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_PXGridSuppliedByVendors_at_tlb div[data-cmd=\'ExportExcel\']" +
                            "", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_PXGridSuppliedByVendors_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_PXGridSuppliedByVendors_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_PXGridSuppliedByVendors_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_PXGridSuppliedByVendors_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_PXGridSuppliedByVendors_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_PXGridSuppliedByVendors_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public Selector AcctCD { get; }
			public PXTextEdit AcctName { get; }
                
                public c_grid_row(c_suppliedbyvendors_pxgridsuppliedbyvendors grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    AcctCD = new Selector("_ctl00_phG_tab_t10_PXGridSuppliedByVendors_lv0_es", "Vendor", grid.Locator, "AcctCD");
                    AcctCD.DataField = "AcctCD";
                    AcctName = new PXTextEdit("ctl00_phG_tab_t10_PXGridSuppliedByVendors_ei", "Vendor Name", grid.Locator, "AcctName");
                    AcctName.DataField = "AcctName";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter AcctCD { get; }
				public PXTextEditColumnFilter AcctName { get; }
                
                public c_grid_header(c_suppliedbyvendors_pxgridsuppliedbyvendors grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    AcctCD = new SelectorColumnFilter(grid.Row.AcctCD);
                    AcctName = new PXTextEditColumnFilter(grid.Row.AcctName);
                }
            }
        }
        
        public class c_suppliedbyvendors_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_suppliedbyvendors_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t10_PXGridSuppliedByVendors_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "SuppliedByVendors";
            }
        }
        
        public class c_currentvendor_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AcctReferenceNbr { get; }
			public Label AcctReferenceNbrLabel { get; }
			public Selector ParentBAccountID { get; }
			public Label ParentBAccountIDLabel { get; }
			public Selector VendorClassID { get; }
			public Label VendorClassIDLabel { get; }
			public Selector TermsID { get; }
			public Label TermsIDLabel { get; }
			public Selector CuryID { get; }
			public Label CuryIDLabel { get; }
			public CheckBox AllowOverrideCury { get; }
			public Label AllowOverrideCuryLabel { get; }
			public Selector CuryRateTypeID { get; }
			public Label CuryRateTypeIDLabel { get; }
			public CheckBox AllowOverrideRate { get; }
			public Label AllowOverrideRateLabel { get; }
			public CheckBox LandedCostVendor { get; }
			public Label LandedCostVendorLabel { get; }
			public CheckBox TaxAgency { get; }
			public Label TaxAgencyLabel { get; }
			public CheckBox IsLaborUnion { get; }
			public Label IsLaborUnionLabel { get; }
			public CheckBox Vendor1099 { get; }
			public Label Vendor1099Label { get; }
			public Selector Box1099 { get; }
			public Label Box1099Label { get; }
			public CheckBox ForeignEntity { get; }
			public Label ForeignEntityLabel { get; }
			public CheckBox FATCA { get; }
			public Label FATCALabel { get; }
			public CheckBox SDEnabled { get; }
			public Label SDEnabledLabel { get; }
			public CheckBox RetainageApply { get; }
			public Label RetainageApplyLabel { get; }
			public PXNumberEdit RetainagePct { get; }
			public Label RetainagePctLabel { get; }
			public Selector DiscTakenAcctID { get; }
			public Label DiscTakenAcctIDLabel { get; }
			public Selector DiscTakenSubID { get; }
			public Label DiscTakenSubIDLabel { get; }
			public Selector PrepaymentAcctID { get; }
			public Label PrepaymentAcctIDLabel { get; }
			public Selector PrepaymentSubID { get; }
			public Label PrepaymentSubIDLabel { get; }
			public Selector POAccrualAcctID { get; }
			public Label POAccrualAcctIDLabel { get; }
			public Selector POAccrualSubID { get; }
			public Label POAccrualSubIDLabel { get; }
			public Selector PrebookAcctID { get; }
			public Label PrebookAcctIDLabel { get; }
			public Selector PrebookSubID { get; }
			public Label PrebookSubIDLabel { get; }
			public Selector SalesTaxAcctID { get; }
			public Label SalesTaxAcctIDLabel { get; }
			public Selector SalesTaxSubID { get; }
			public Label SalesTaxSubIDLabel { get; }
			public Selector PurchTaxAcctID { get; }
			public Label PurchTaxAcctIDLabel { get; }
			public Selector PurchTaxSubID { get; }
			public Label PurchTaxSubIDLabel { get; }
			public Selector TaxExpenseAcctID { get; }
			public Label TaxExpenseAcctIDLabel { get; }
			public Selector TaxExpenseSubID { get; }
			public Label TaxExpenseSubIDLabel { get; }
			public DropDown SVATReversalMethod { get; }
			public Label SVATReversalMethodLabel { get; }
			public DropDown SVATInputTaxEntryRefNbr { get; }
			public Label SVATInputTaxEntryRefNbrLabel { get; }
			public DropDown SVATOutputTaxEntryRefNbr { get; }
			public Label SVATOutputTaxEntryRefNbrLabel { get; }
			public Selector SVATTaxInvoiceNumberingID { get; }
			public Label SVATTaxInvoiceNumberingIDLabel { get; }
			public DropDown TaxPeriodType { get; }
			public Label TaxPeriodTypeLabel { get; }
			public CheckBox TaxReportFinPeriod { get; }
			public Label TaxReportFinPeriodLabel { get; }
			public CheckBox UpdClosedTaxPeriods { get; }
			public Label UpdClosedTaxPeriodsLabel { get; }
			public CheckBox AutoGenerateTaxBill { get; }
			public Label AutoGenerateTaxBillLabel { get; }
			public DropDown TaxReportRounding { get; }
			public Label TaxReportRoundingLabel { get; }
			public PXNumberEdit TaxReportPrecision { get; }
			public Label TaxReportPrecisionLabel { get; }
			public CheckBox TaxUseVendorCurPrecision { get; }
			public Label TaxUseVendorCurPrecisionLabel { get; }
            
            public c_currentvendor_tab(string locator, string name) : 
                    base(locator, name)
            {
                AcctReferenceNbr = new PXTextEdit("ctl00_phG_tab_t0_edAcctReferenceNbr", "Account Ref.#", locator, null);
                AcctReferenceNbrLabel = new Label(AcctReferenceNbr);
                AcctReferenceNbr.DataField = "AcctReferenceNbr";
                ParentBAccountID = new Selector("ctl00_phG_tab_t0_edParentBAccountID", "Parent Account", locator, null);
                ParentBAccountIDLabel = new Label(ParentBAccountID);
                ParentBAccountID.DataField = "ParentBAccountID";
                VendorClassID = new Selector("ctl00_phG_tab_t0_edVendorClassID", "Vendor Class", locator, null);
                VendorClassIDLabel = new Label(VendorClassID);
                VendorClassID.DataField = "VendorClassID";
                TermsID = new Selector("ctl00_phG_tab_t0_edTermsID", "Terms", locator, null);
                TermsIDLabel = new Label(TermsID);
                TermsID.DataField = "TermsID";
                CuryID = new Selector("ctl00_phG_tab_t0_edCuryID", "Currency ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                AllowOverrideCury = new CheckBox("ctl00_phG_tab_t0_chkAllowOverrideCury", "Enable Currency Override", locator, null);
                AllowOverrideCuryLabel = new Label(AllowOverrideCury);
                AllowOverrideCury.DataField = "AllowOverrideCury";
                CuryRateTypeID = new Selector("ctl00_phG_tab_t0_edCuryRateTypeID", "Curr. Rate Type", locator, null);
                CuryRateTypeIDLabel = new Label(CuryRateTypeID);
                CuryRateTypeID.DataField = "CuryRateTypeID";
                AllowOverrideRate = new CheckBox("ctl00_phG_tab_t0_chkAllowOverrideRate", "Enable Rate Override", locator, null);
                AllowOverrideRateLabel = new Label(AllowOverrideRate);
                AllowOverrideRate.DataField = "AllowOverrideRate";
                LandedCostVendor = new CheckBox("ctl00_phG_tab_t0_chkLandedCostVendor", "Landed Cost Vendor", locator, null);
                LandedCostVendorLabel = new Label(LandedCostVendor);
                LandedCostVendor.DataField = "LandedCostVendor";
                TaxAgency = new CheckBox("ctl00_phG_tab_t0_chkTaxAgency", "Vendor is Tax Agency", locator, null);
                TaxAgencyLabel = new Label(TaxAgency);
                TaxAgency.DataField = "TaxAgency";
                IsLaborUnion = new CheckBox("ctl00_phG_tab_t0_chkLaborUnion", "Vendor is Labor Union", locator, null);
                IsLaborUnionLabel = new Label(IsLaborUnion);
                IsLaborUnion.DataField = "IsLaborUnion";
                Vendor1099 = new CheckBox("ctl00_phG_tab_t0_chkVendor1099", "1099 Vendor", locator, null);
                Vendor1099Label = new Label(Vendor1099);
                Vendor1099.DataField = "Vendor1099";
                Box1099 = new Selector("ctl00_phG_tab_t0_edBox1099", "1099 Box", locator, null);
                Box1099Label = new Label(Box1099);
                Box1099.DataField = "Box1099";
                ForeignEntity = new CheckBox("ctl00_phG_tab_t0_edForeignEntity", "Foreign Entity", locator, null);
                ForeignEntityLabel = new Label(ForeignEntity);
                ForeignEntity.DataField = "ForeignEntity";
                FATCA = new CheckBox("ctl00_phG_tab_t0_chkFATCA", "FATCA", locator, null);
                FATCALabel = new Label(FATCA);
                FATCA.DataField = "FATCA";
                SDEnabled = new CheckBox("ctl00_phG_tab_t0_edSDEnabled", "Staff Member in Service Management", locator, null);
                SDEnabledLabel = new Label(SDEnabled);
                SDEnabled.DataField = "SDEnabled";
                RetainageApply = new CheckBox("ctl00_phG_tab_t0_edRetainageApply", "Apply Retainage", locator, null);
                RetainageApplyLabel = new Label(RetainageApply);
                RetainageApply.DataField = "RetainageApply";
                RetainagePct = new PXNumberEdit("ctl00_phG_tab_t0_edRetainagePct", "Retainage Percent", locator, null);
                RetainagePctLabel = new Label(RetainagePct);
                RetainagePct.DataField = "RetainagePct";
                DiscTakenAcctID = new Selector("ctl00_phG_tab_t7_edDiscTakenAcctID", "Cash Discount Account", locator, null);
                DiscTakenAcctIDLabel = new Label(DiscTakenAcctID);
                DiscTakenAcctID.DataField = "DiscTakenAcctID";
                DiscTakenSubID = new Selector("ctl00_phG_tab_t7_edDiscTakenSubID", "Cash Discount Sub.", locator, null);
                DiscTakenSubIDLabel = new Label(DiscTakenSubID);
                DiscTakenSubID.DataField = "DiscTakenSubID";
                PrepaymentAcctID = new Selector("ctl00_phG_tab_t7_edPrepaymentAcctID", "Prepayment Account", locator, null);
                PrepaymentAcctIDLabel = new Label(PrepaymentAcctID);
                PrepaymentAcctID.DataField = "PrepaymentAcctID";
                PrepaymentSubID = new Selector("ctl00_phG_tab_t7_edPrepaymentSubID", "Prepayment Sub.", locator, null);
                PrepaymentSubIDLabel = new Label(PrepaymentSubID);
                PrepaymentSubID.DataField = "PrepaymentSubID";
                POAccrualAcctID = new Selector("ctl00_phG_tab_t7_edPOAccrualAcctID", "PO Accrual Account", locator, null);
                POAccrualAcctIDLabel = new Label(POAccrualAcctID);
                POAccrualAcctID.DataField = "POAccrualAcctID";
                POAccrualSubID = new Selector("ctl00_phG_tab_t7_edPOAccrualSubID", "PO Accrual Sub.", locator, null);
                POAccrualSubIDLabel = new Label(POAccrualSubID);
                POAccrualSubID.DataField = "POAccrualSubID";
                PrebookAcctID = new Selector("ctl00_phG_tab_t7_edPrebookAcctID", "Reclassification Account", locator, null);
                PrebookAcctIDLabel = new Label(PrebookAcctID);
                PrebookAcctID.DataField = "PrebookAcctID";
                PrebookSubID = new Selector("ctl00_phG_tab_t7_edPrebookSubID", "Reclassification Subaccount", locator, null);
                PrebookSubIDLabel = new Label(PrebookSubID);
                PrebookSubID.DataField = "PrebookSubID";
                SalesTaxAcctID = new Selector("ctl00_phG_tab_t8_edSalesTaxAcctID", "Tax Payable Account", locator, null);
                SalesTaxAcctIDLabel = new Label(SalesTaxAcctID);
                SalesTaxAcctID.DataField = "SalesTaxAcctID";
                SalesTaxSubID = new Selector("ctl00_phG_tab_t8_edSalesTaxSubID", "Tax Payable Sub.", locator, null);
                SalesTaxSubIDLabel = new Label(SalesTaxSubID);
                SalesTaxSubID.DataField = "SalesTaxSubID";
                PurchTaxAcctID = new Selector("ctl00_phG_tab_t8_edPurchTaxAcctID", "Tax Claimable Account", locator, null);
                PurchTaxAcctIDLabel = new Label(PurchTaxAcctID);
                PurchTaxAcctID.DataField = "PurchTaxAcctID";
                PurchTaxSubID = new Selector("ctl00_phG_tab_t8_edPurchTaxSubID", "Tax Claimable Sub.", locator, null);
                PurchTaxSubIDLabel = new Label(PurchTaxSubID);
                PurchTaxSubID.DataField = "PurchTaxSubID";
                TaxExpenseAcctID = new Selector("ctl00_phG_tab_t8_edTaxExpenseAcctID", "Tax Expense Account", locator, null);
                TaxExpenseAcctIDLabel = new Label(TaxExpenseAcctID);
                TaxExpenseAcctID.DataField = "TaxExpenseAcctID";
                TaxExpenseSubID = new Selector("ctl00_phG_tab_t8_edTaxExpenseSubID", "Tax Expense Sub.", locator, null);
                TaxExpenseSubIDLabel = new Label(TaxExpenseSubID);
                TaxExpenseSubID.DataField = "TaxExpenseSubID";
                SVATReversalMethod = new DropDown("ctl00_phG_tab_t8_edSVATReversalMethod", "VAT Recognition Method", locator, null);
                SVATReversalMethodLabel = new Label(SVATReversalMethod);
                SVATReversalMethod.DataField = "SVATReversalMethod";
                SVATReversalMethod.Items.Add("P", "On Payments");
                SVATReversalMethod.Items.Add("D", "On Documents");
                SVATInputTaxEntryRefNbr = new DropDown("ctl00_phG_tab_t8_edSVATInputTaxEntryRefNbr", "Input Tax Entry Ref. Nbr.", locator, null);
                SVATInputTaxEntryRefNbrLabel = new Label(SVATInputTaxEntryRefNbr);
                SVATInputTaxEntryRefNbr.DataField = "SVATInputTaxEntryRefNbr";
                SVATInputTaxEntryRefNbr.Items.Add("D", "Document Ref. Nbr.");
                SVATInputTaxEntryRefNbr.Items.Add("P", "Payment Ref. Nbr.");
                SVATInputTaxEntryRefNbr.Items.Add("M", "Manually Entered");
                SVATOutputTaxEntryRefNbr = new DropDown("ctl00_phG_tab_t8_edSVATOutputTaxEntryRefNbr", "Output Tax Entry Ref. Nbr.", locator, null);
                SVATOutputTaxEntryRefNbrLabel = new Label(SVATOutputTaxEntryRefNbr);
                SVATOutputTaxEntryRefNbr.DataField = "SVATOutputTaxEntryRefNbr";
                SVATOutputTaxEntryRefNbr.Items.Add("D", "Document Ref. Nbr.");
                SVATOutputTaxEntryRefNbr.Items.Add("P", "Payment Ref. Nbr.");
                SVATOutputTaxEntryRefNbr.Items.Add("T", "Tax Invoice Nbr.");
                SVATOutputTaxEntryRefNbr.Items.Add("M", "Manually Entered");
                SVATTaxInvoiceNumberingID = new Selector("ctl00_phG_tab_t8_edSVATTaxInvoiceNumberingID", "Tax Invoice Numbering", locator, null);
                SVATTaxInvoiceNumberingIDLabel = new Label(SVATTaxInvoiceNumberingID);
                SVATTaxInvoiceNumberingID.DataField = "SVATTaxInvoiceNumberingID";
                TaxPeriodType = new DropDown("ctl00_phG_tab_t8_edTaxPeriodType", "Default Tax Period Type", locator, null);
                TaxPeriodTypeLabel = new Label(TaxPeriodType);
                TaxPeriodType.DataField = "TaxPeriodType";
                TaxPeriodType.Items.Add("B", "Half a Month");
                TaxPeriodType.Items.Add("M", "Month");
                TaxPeriodType.Items.Add("E", "Two Months");
                TaxPeriodType.Items.Add("Q", "Quarter");
                TaxPeriodType.Items.Add("H", "Half a Year");
                TaxPeriodType.Items.Add("Y", "Year");
                TaxPeriodType.Items.Add("F", "Financial Period");
                TaxReportFinPeriod = new CheckBox("ctl00_phG_tab_t8_chktaxReportFinPeriod", "Define Tax Period by End Date of Financial Period", locator, null);
                TaxReportFinPeriodLabel = new Label(TaxReportFinPeriod);
                TaxReportFinPeriod.DataField = "TaxReportFinPeriod";
                UpdClosedTaxPeriods = new CheckBox("ctl00_phG_tab_t8_chkUpdClosedTaxPeriods", "Update Closed Tax Periods", locator, null);
                UpdClosedTaxPeriodsLabel = new Label(UpdClosedTaxPeriods);
                UpdClosedTaxPeriods.DataField = "UpdClosedTaxPeriods";
                AutoGenerateTaxBill = new CheckBox("ctl00_phG_tab_t8_chkAutoGenerateTaxBill", "Automatically Generate Tax Bill", locator, null);
                AutoGenerateTaxBillLabel = new Label(AutoGenerateTaxBill);
                AutoGenerateTaxBill.DataField = "AutoGenerateTaxBill";
                TaxReportRounding = new DropDown("ctl00_phG_tab_t8_edTaxReportRounding", "Tax Report Rounding", locator, null);
                TaxReportRoundingLabel = new Label(TaxReportRounding);
                TaxReportRounding.DataField = "TaxReportRounding";
                TaxReportRounding.Items.Add("R", "Mathematical");
                TaxReportRounding.Items.Add("C", "Ceiling");
                TaxReportRounding.Items.Add("F", "Floor");
                TaxReportPrecision = new PXNumberEdit("ctl00_phG_tab_t8_edTaxReportPrecision", "Tax Report Precision", locator, null);
                TaxReportPrecisionLabel = new Label(TaxReportPrecision);
                TaxReportPrecision.DataField = "TaxReportPrecision";
                TaxUseVendorCurPrecision = new CheckBox("ctl00_phG_tab_t8_chkTaxUseVendorCurPrecision", "Use Currency Precision", locator, null);
                TaxUseVendorCurPrecisionLabel = new Label(TaxUseVendorCurPrecision);
                TaxUseVendorCurPrecision.DataField = "TaxUseVendorCurPrecision";
                DataMemberName = "CurrentVendor";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ParentBAccountIDEdit()
            {
                Buttons.ParentBAccountIDEdit.Click();
            }
            
            public virtual void VendorClassIDEdit()
            {
                Buttons.VendorClassIDEdit.Click();
            }
            
            public virtual void TermsIDEdit()
            {
                Buttons.TermsIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ParentBAccountIDEdit { get; }
			public Button VendorClassIDEdit { get; }
			public Button TermsIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ParentBAccountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edParentBAccountID\'] div[class=\'editBtnCont\'] > div " +
                            "> div", "ParentBAccountIDEdit", "ctl00_phG_tab");
                    ParentBAccountIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    VendorClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edVendorClassID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "VendorClassIDEdit", "ctl00_phG_tab");
                    VendorClassIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                    TermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edTermsID\'] div[class=\'editBtnCont\'] > div > div", "TermsIDEdit", "ctl00_phG_tab");
                    TermsIDEdit.WaitAction = () => Wait.WaitForPageToLoad(true);
                }
            }
        }
        
        public class c_baccount_tab : Container
        {
            
			public Selector LocaleName { get; }
			public Label LocaleNameLabel { get; }
            
            public c_baccount_tab(string locator, string name) : 
                    base(locator, name)
            {
                LocaleName = new Selector("ctl00_phG_tab_t0_edLocale", "Locale", locator, null);
                LocaleNameLabel = new Label(LocaleName);
                LocaleName.DataField = "LocaleName";
                DataMemberName = "BAccount";
            }
        }
        
        public class c_changeiddialog_formchangeid : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector CD { get; }
			public Label CDLabel { get; }
            
            public c_changeiddialog_formchangeid(string locator, string name) : 
                    base(locator, name)
            {
                CD = new Selector("ctl00_phF_pnlChangeID_formChangeID_edAcctCD", "Vendor ID", locator, null);
                CDLabel = new Label(CD);
                CD.DataField = "CD";
                DataMemberName = "ChangeIDDialog";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phF_pnlChangeID_btnOK", "OK", "ctl00_phF_pnlChangeID_formChangeID");
                    Cancel = new Button("ctl00_phF_pnlChangeID_btnCancel", "Cancel", "ctl00_phF_pnlChangeID_formChangeID");
                }
            }
        }
        
        public class c_filterpreview_formpreview : Container
        {
            
            public PxButtonCollection Buttons;
            
            public c_filterpreview_formpreview(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "FilterPreview";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_usrCaption_PanelDynamicForm_PXButtonOK", "OK", "ctl00_usrCaption_PanelDynamicForm_FormPreview");
                    Cancel = new Button("ctl00_usrCaption_PanelDynamicForm_PXButtonCancel", "Cancel", "ctl00_usrCaption_PanelDynamicForm_FormPreview");
                }
            }
        }
        
        public class c_attributes : Container
        {
            
            public c_attributes(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = null;
            }
        }
    }
}

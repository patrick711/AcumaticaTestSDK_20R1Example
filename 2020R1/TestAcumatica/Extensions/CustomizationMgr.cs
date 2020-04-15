using Controls.CompilationPanel;
using Controls.Grid.Upload;
using GeneratedWrappers.Acumatica;


namespace TestAcumatica.Extensions
{
    public class CustomizationMgr : SM204505_ProjectList
    {
        public c_projects_grid Details
        {
            get { return base.Projects_grid; }
            //set { base.Projects_grid = value; }
        }

        public c_grid_upload OpenPackage
        {
            get { return base.OpenPackage; }
        }
        public CompilationPanel CompilationPanel
        {
            get { return base.CompilationPanel; }
        }

        public CustomizationMgr()
        {

            ToolBar.ActionPublish.WaitAction = () =>
            {
                CompilationPanel.Validate(true,
                    "Validation finished successfully.");
                CompilationPanel.Publish(true,
                    "Website has been updated.");
                CompilationPanel.Close();
            };
        }
    }
}
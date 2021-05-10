using SpecFlowEasyHire.Models;
using SpecFlowEasyHire.Pages.Forms;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowEasyHire.Utils
{
    [Binding]
    public class TableTransformations
    {
        [StepArgumentTransformation]
        public LoginUser TransformLoginUserModel(Table inputTable) => inputTable.CreateInstance<LoginUser>();
        
        [StepArgumentTransformation]
        public SignUpUser TransformSignUpUserModel(Table inputTable) => inputTable.CreateInstance<SignUpUser>();
    }
}
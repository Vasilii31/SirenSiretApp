using SirenSiretApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirenSiretApp.ViewModel
{
    public class MainWindowBusiness
    {
        public string TitleOfMainWindow { get; set; }

        public string InformativeText { get; set; }

        public string ErrorOrResult { get; set; }

        public string InputBox { get; set; }

        public MainWindowBusiness()
        {
            TitleOfMainWindow = "Siren/Siret Verification App";
            InformativeText = "Welcome to the Siren/Siret Verification App ! Please Enter your Siren or Siret number and click on the Verify Button";
            ErrorOrResult = "";
            InputBox = "Enter Siren/Siret here ...";

        }

        public string VerifyResult(string textInput)
        {
            Input newUserInput = new Input(textInput);

            if (newUserInput.CheckGlobalCorrect() == false)
            {

                return("Sorry, wrong format.");

            }
            else
            {
                if (newUserInput.KeyLhunAlgorithm() == true)
                    return ($"Congratulation ! {textInput} is a valid Siren/Siret !");
                else
                    return($"Sorry, {textInput} is not a valid Siren/Siret.");
            }
        }
    }
}

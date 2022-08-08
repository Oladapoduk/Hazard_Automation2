using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazard_Automation.Businessb
{
    class FailureWarningSwallower : IFailuresPreprocessor
    {
        public FailureProcessingResult PreprocessFailures(FailuresAccessor failuresAccessor)
        {
            try
            {
                IList<FailureMessageAccessor> failures = failuresAccessor.GetFailureMessages();

                foreach (FailureMessageAccessor failureMessageAccessor in failures)
                {
                    FailureSeverity failureSeverity = failureMessageAccessor.GetSeverity();
                    switch (failureSeverity)
                    {
                        case FailureSeverity.Warning:
                            failuresAccessor.DeleteWarning(failureMessageAccessor);
                            break;
                        default:
                            return FailureProcessingResult.ProceedWithRollBack;
                    }
                }

                return FailureProcessingResult.Continue;
            }
            catch (Exception)
            {
                return FailureProcessingResult.ProceedWithCommit;
            }
        }
    }
    public class FamilyLoadingOptions : IFamilyLoadOptions
    {
        public bool OnFamilyFound(bool familyInUse, out bool overwriteParameterValues)
        {
            if (!familyInUse)
            {
                overwriteParameterValues = true;
                return true;
            }
            else
            {
                overwriteParameterValues = true;
                return true;
            }
        }

        public bool OnSharedFamilyFound(Family sharedFamily, bool familyInUse, out FamilySource source, out bool overwriteParameterValues)
        {
            if (!familyInUse)
            {
                source = FamilySource.Family;
                overwriteParameterValues = true;
                return true;
            }
            else
            {
                source = FamilySource.Family;
                overwriteParameterValues = true;
                return true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Entitetlager
{
    public class Diagnosis
    {
        public int PatientNumber { get; set; }
        public string DiagnosisDescription { get; set; }
        public DateTime DiagnosisDate { get; set; }
        public string TreatmentProposal { get; set; }

    }
}

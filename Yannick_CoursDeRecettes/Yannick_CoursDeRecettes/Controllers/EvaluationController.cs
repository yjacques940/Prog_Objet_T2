using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yannick_CoursDeRecettes
{
    class EvaluationController
    {
        EvaluationRepository repository;
        public decimal Utility { get; set; }
        public decimal Difficulty { get; set; }
        public decimal Appreciation { get; set; }
        public string CourseNumber { get; set; }

        public EvaluationController()
        {
            repository = new EvaluationRepository();
        }
        internal void SaveEvaluationInDatabase()
        {
            repository.SaveNewEvaluation(Utility,Difficulty,Appreciation,CourseNumber);
        }
    }
}

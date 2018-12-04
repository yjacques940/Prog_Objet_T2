using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yannick_CoursDeRecettes;
//les namespace ne sont pas les mêmes partout
namespace Yannick_CoursDeRecettes
{
    class CourseRepository
    {
        MySqlConnection connexion;
        public CourseRepository()
        {
            Connexion.BD = "cuisine";
            Connexion.User = "root";
            Connexion.Password = "";
            connexion = Connexion.getInstance();
        }

        internal Course SearchCourseByCourseNumber(string courseNumber)
        {
            MySqlCommand commandCourse;
            MySqlDataReader readerCourse;
            
            Course course = new TechnicalCourse();
            if (connexion != null)
            {
                commandCourse = connexion.CreateCommand();
                commandCourse.CommandText = "Select * from cours where codeCours='" + courseNumber.ToString() +"'";
                readerCourse = commandCourse.ExecuteReader();
                //on place les valeurs de l'enregistrement trouvé à l'intérieur d'un objet métier (notre classe TEditeur)
                if (readerCourse.Read())
                {
                    if (Convert.ToInt32(readerCourse["typeCours"]) == 2)
                    {
                         course = new AdvancedCourse();
                    }
                    
                    course.CourseName = readerCourse["titreCours"].ToString();
                    course.RegistrationCost = readerCourse["prixCours"].ToString();
                    course.TechnicalDescription = readerCourse["descriptionTechnique"].ToString();
                    course.TechnicalName = readerCourse["technique"].ToString();
                    course.Requirements = readerCourse["prerequis"].ToString();
                    course.feature.Duration = readerCourse["dureeCours"].ToString();
                    course.feature.DifficultyLevel = readerCourse["niveauDifficulte"].ToString();
                    course.feature.Comments = readerCourse["commentaires"].ToString();
                }
                readerCourse.Close();
            }
            return course;
        }
    }
}

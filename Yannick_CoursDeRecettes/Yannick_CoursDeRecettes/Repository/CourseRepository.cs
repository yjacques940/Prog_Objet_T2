using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yannick_CoursDeRecettes.Classes;
using Yannick_CoursDeRecettes;
//les namespace ne sont pas les mêmes partout
namespace Yannick_CoursDeRecettes.Repository
{
    class CourseRepository
    {
        MySqlConnection connexion;
        public CourseRepository()
        {
            Connexion.BD = "" ; 
        }
        internal Course SearchCourseByCourseNumber(string courseNumber)
        {
            MySqlCommand commandCourse;
            MySqlDataReader readerCourse;
            
            var course = new TechnicalCourse();
            if (connexion != null)
            {
                commandCourse = connexion.CreateCommand();
                commandCourse.CommandText = "Select * from publishers where Pubid='" + courseNumber.ToString() +"'";
                readerCourse = commandCourse.ExecuteReader();
                //on place les valeurs de l'enregistrement trouvé à l'intérieur d'un objet métier (notre classe TEditeur)
                if (readerCourse.Read())
                {
                    Editeur.Identifiant = Convert.ToInt32(readerCourse["PubId"]);
                    Editeur.Nom = readerCourse["Name"].ToString();
                    Editeur.Cie = readerCourse["CompanyName"].ToString();
                    Editeur.Adresse = readerCourse["Address"].ToString();
                    Editeur.Ville = readerCourse["City"].ToString();
                    Editeur.Pays = readerCourse["State"].ToString();
                }
                readerCourse.Close();
            }
            return Editeur;
        }
    }
}


	Employe unEmploye = new Enseignant();
	// préférable de ne pas retourner de référence null alors
	// on crée un des objets de la hiérarchie à l’aide du constructeur par défaut

	// Select selon le no reçu
…
if (readerEmploye.Read())
    {
        // vérification du type d’employé
        if (Convert.ToInt32(readerEmploye["typeEmploye"]) == 2)
        {
            unEmploye = new ConseillerPedagogique();
            // remplace le new précédent afin d’avoir le bon type d’objet
        }
        unEmploye.Nom = //données du reader;
…
//utilisation des propriétés virtuelles
unEmploye.Discipline = //données du reader;
unEmploye.Poste = //données du reader;
}
    //fermeture du reader
    return unEmploye;
}

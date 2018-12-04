using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yannick_CoursDeRecettes
{
    class EvaluationRepository
    {

        MySqlConnection connexion;
        public EvaluationRepository()
        {
            Connexion.BD = "cuisine";
            Connexion.User = "root";
            Connexion.Password = "";
            connexion = Connexion.getInstance();
        }

        internal void SaveNewEvaluation(decimal utility, decimal difficulty, decimal appreciation,string courseNumber)
        {
            int add;
            MySqlCommand commandAdd;
            if(connexion != null)
            {
                commandAdd = connexion.CreateCommand();
                commandAdd.CommandText = $"insert into evaluation(noteDifficulte,noteUtilite,noteAppreciaiton,codeCours)" +
                    $"values('{Convert.ToInt32(difficulty)}','{Convert.ToInt32(utility)}','{Convert.ToInt32(appreciation)}','{courseNumber}')";
                add = commandAdd.ExecuteNonQuery();
            }
        }
    }
}
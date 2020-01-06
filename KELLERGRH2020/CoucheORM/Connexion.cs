using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.SqlClient;

namespace KELLERGRH2020
{
    public static class Connexion
    {
        //Une classe statique est fondamentalement identique à une classe non statique, à une différence près : une classe statique ne peut pas être instanciée.
        //En d'autres termes, vous ne pouvez pas utiliser le mot clé new pour créer une variable du type classe. 
        //Étant donné qu'il n'y a aucune variable d'instance, vous accédez aux membres d'une classe statique en utilisant le nom de classe lui-même.

        private static string laChaine = @"data source=srv-sql-2016;initial catalog=FARIELLO;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

        public static string getChaine()
        {
            return laChaine;
        }
    }
}

using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpNetCoreTemplate.DBSteps
{
    public class SolicitacaoDBSteps
    {
        public static List<string> Select()
        {
            string query = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Queries/atualizaDataDoItemSolicitacaoParaAgora.sql", Encoding.UTF8);
            return  DBHelpers.RetornaDadosQuery(query);
        }
        //MEU TESTE
        public static List<string> RetornaIdProblemaDB()
        {
            string query = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Queries/retornaIdProblema.sql", Encoding.UTF8);
            return DBHelpers.RetornaDadosQuery(query);
        }

        public static List<string> RetornaIdProjetoNoteDB()
        {
            string query = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Queries/retornaIdProjetoNote.sql", Encoding.UTF8);
            return DBHelpers.RetornaDadosQuery(query);
        }

        public static List<string> RetornaNameProject()
        {
            string query = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Queries/nameProject.sql", Encoding.UTF8);
            return DBHelpers.RetornaDadosQuery(query);
        }
        public static List<string> RetornaIDProject()
        {
            string query = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Queries/idProject.sql", Encoding.UTF8);
            return DBHelpers.RetornaDadosQuery(query);
        }
        public static List<string> RetornaIdUser()
        {
            string query = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Queries/IdUserMantis.sql", Encoding.UTF8);
            return DBHelpers.RetornaDadosQuery(query);
        }
        public static List<string> RetornaNameAleatorioProjeto()
        {
            string query = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Queries/nomeAleatorioProjec.sql", Encoding.UTF8);
            return DBHelpers.RetornaDadosQuery(query);
        }

        /*__________________________________________________________________________________________________*/

        public static void AtualizaDataDoItemSolicitacaoParaAgoraDB(string solicitacaoItemId)
        {
            string query = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Queries/atualizaDataDoItemSolicitacaoParaAgora.sql", Encoding.UTF8);
            query = query.Replace("$solicitacaoItemId", solicitacaoItemId);

            DBHelpers.ExecuteQuery(query);

            ExtentReportHelpers.AddTestInfo(2, "PARAMETERS: solicitacaoItemId = " + solicitacaoItemId);
        }

        public static List<string> DeleteDadosDB()
        {
            string query = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Queries/Deletes/DeleteDados.sql", Encoding.UTF8);
            return DBHelpers.RetornaDadosQuery(query);
        }
        public static List<string> InserirProject()
        {
            string query = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Queries/Inserts/inserirProject.sql", Encoding.UTF8);
            return DBHelpers.RetornaDadosQuery(query);
        }


        public static void InsereTodosRegistrosDB()
        {
            string query = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Queries/inserirTodosRegistrosTabela.sql", Encoding.UTF8);
          //  ExtentReportHelpers.AddTestInfo(2, "Insere todos registros para inciar testes ");
            DBHelpers.ExecuteQuery(query);
        }
    }
}

using NUnit.Framework;
using RestSharpNetCoreTemplate.DBSteps;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpNetCoreTemplate.Bases
{
    public class TestBase
    {
        
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            SolicitacaoDBSteps.InsereTodosRegistrosDB();
            ExtentReportHelpers.CreateReport();
            SolicitacaoDBSteps.DeleteDadosDB();
        }

        [SetUp]
        public void SetUp()
        {
            ExtentReportHelpers.AddTest();
        }

        [TearDown]
        public void TearDown()
        {
            ExtentReportHelpers.AddTestResult();
            
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            ExtentReportHelpers.GenerateReport();
            
        }
    }
}

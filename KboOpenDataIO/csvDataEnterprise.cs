using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KboOpenDataIO
{
    class CsvDataEnterprise
    {
        public void CsvReadFile(string fileLocation, string cnn)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(cnn))
            {
                try
                {
                    List<KboEnterprise> values = File
                        .ReadAllLines(fileLocation)
                        .Skip(1)
                        .Select(ClsKboEnterprise.FromCsv).ToList();

                    try
                    {
                        connection.Execute("spKboEnterprises_InsertFull @Id, @Status, @JuridicalSituation, @TypeOfEnterprise, @JuridicalForm, @StartDate", values);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }

    class ClsKboEnterprise
    {
        public static KboEnterprise FromCsv(string csvLine)
        {
            DateTime resDate;
            // CultureInfo provider = CultureInfo.InvariantCulture;

            var values = csvLine.Split(',');

            string thisYear;
            string thisMonth;
            string thisDay;
            string result;

            try
            {
                thisYear = values[5].Substring(6, 4);
                thisMonth = values[5].Substring(3, 2);
                thisDay = values[5].Substring(0, 2);

                result = thisYear + '-' + thisMonth + '-' + thisDay;
                resDate = Convert.ToDateTime(result); // DateTime.ParseExact(values[5], "dd-MM-yyyy", provider);
            }
            catch (Exception)
            {
                throw;
            }

            KboEnterprise kboEnterprise = new KboEnterprise
            {
                Id = values[0].Trim('"'),
                Status = values[1].Trim('"'),
                JuridicalSituation = values[2].Trim('"'),
                TypeOfEnterprise = values[3].Trim('"'),
                JuridicalForm = values[4].Trim('"'),
                StartDate = resDate
            };
            return kboEnterprise;
        }
    }
}

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
    class CsvDataCode
    {
        public void CsvReadFile(string fileLocation, string cnn)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(cnn))
            {
                try
                {
                    List<KboCode> values = File
                        .ReadAllLines(fileLocation)
                        .Skip(1)
                        .Select(ClsKboCode.FromCsv).ToList();

                    try
                    {
                        connection.Execute("spKboCodes_InsertFull @Category, @Code, @Language, @Description", values);
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

    class ClsKboCode
    {
        public static KboCode FromCsv(string csvLine)
        {
            var values = csvLine.Split(',');

            KboCode kboCode = new KboCode
            {
                Category = values[0].Trim('"'),
                Code = values[1].Trim('"'),
                Language = values[2].Trim('"'),
                Description = values[3].Trim('"')
            };
            return kboCode;
        }
    }
}


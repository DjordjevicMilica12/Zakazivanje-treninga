using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Vezbe:IEntity
    {
        public int id { get; set; }
        public PlanTreninga planTreninga { get; set; }
        public string nazivVezbe { get; set; }

        public string TableName => "Vezbe";

        public string Values => $"{planTreninga.id}, '{nazivVezbe}'";


        public object JoinValues { get; set; }
        public object JoinCondition { get; set; }
        public object UpdateValues { get; set; }
        public object UpdateCondition { get; set; }

        public override string ToString()
        {
            return nazivVezbe;
        }

        List<IEntity> IEntity.GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        List<IEntity> IEntity.GetReaderListJoin(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {

                Vezbe vezbe = new Vezbe();
                vezbe.id = (int)reader["idVezbe"];
           /*     vezbe.planTreninga = new PlanTreninga()
                {
                    id = (int)reader["planTrneingaID"]
                };
           */
                vezbe.nazivVezbe = (string)reader["nazivVezbe"];
            
                list.Add(vezbe);
            }

            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Program:IEntity
    {
        public int sifraPrograma { get; set; }
        public string nazivPrograma{ get; set; }

        public string TableName => "Program";

        public string Values => $"{sifraPrograma}, {nazivPrograma}";

        public object JoinValues { get ; set ; }
        public object JoinCondition { get ; set; }
        public object UpdateValues { get ; set ; }
        public object UpdateCondition { get; set ; }

        public override string ToString()
        {
            return nazivPrograma;
        }

        List<IEntity> IEntity.GetReaderList(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {

                Program dete = new Program();
                dete.sifraPrograma = (int)reader["sifraPrograma"];
                dete.nazivPrograma = (string)reader["nazivPrograma"];
                list.Add(dete);
            }

            return list;
        }

        List<IEntity> IEntity.GetReaderListJoin(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}

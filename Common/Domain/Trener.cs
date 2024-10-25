using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Trener:IEntity
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public string TableName =>"Trener";

        public string Values => "";

        public object JoinValues { get; set; }
        public object JoinCondition { get; set; }
        public object UpdateValues { get; set; }
        public object UpdateCondition { get; set; }

        public override string ToString()
        {
            return ime +" " +prezime;
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
                Trener trener = new Trener();
                trener.id = (int)reader["idTrener"];
                trener.ime = (string)reader["ime"];
                trener.prezime = (string)reader["prezime"];
                trener.username = (string)reader["username"];
                trener.password = (string)reader["password"];
                list.Add(trener);
            }

            return list;
        }
    }
}

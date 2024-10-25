using Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Roditelj:IEntity
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime{ get; set; }
        public string username { get; set;}
        public string password { get; set;}

        public string TableName => "Roditelj";

        public string Values => "";

        public object JoinValues { get; set; }
        public object JoinCondition { get; set; }
        public object UpdateValues { get; set; }
        public object UpdateCondition { get; set; }

        public override string ToString()
    {
        return  ime+" "+prezime;
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

                Roditelj roditelj = new Roditelj();
                roditelj.username = (string)reader["username"];
                roditelj.password = (string)reader["password"];
                roditelj.ime = (string)reader["ime"];
                roditelj.prezime = (string)reader["prezime"];
                roditelj.id = (int)reader["idRoditelj"];
              
                list.Add(roditelj);
            }

            return list;
        }
    }


}

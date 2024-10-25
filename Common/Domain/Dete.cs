using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Dete:IEntity
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public bool clanstvo{ get; set; }
        public Roditelj roditelj{ get; set; }
        public DateTime datumRodjenja { get; set; }

        public string TableName => "Dete";

        public string Values => $"'{ime}', '{prezime}', '{datumRodjenja}', '{clanstvo}', {roditelj.id}";

        public object JoinValues { get ; set; }
        public object JoinCondition { get ; set ; }
        public object UpdateValues { get ; set ; }
        public object UpdateCondition { get ; set ; }

        public string ImePrezime=> ime+ " "+ prezime;
        List<IEntity> IEntity.GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        List<IEntity> IEntity.GetReaderListJoin(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {

                Dete dete = new Dete();
                dete.id = (int)reader["idDete"];
                dete.ime = (string)reader["ime"];
                dete.prezime = (string)reader["prezime"];
                dete.datumRodjenja = (DateTime)reader["datumRodjenja"];
                dete.clanstvo = true;
                dete.roditelj = new Roditelj() { id = (int)reader["roditeljID"] };
                list.Add(dete);
            }

            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class PlanTreninga:IEntity
    {
        public int id { get; set; }
        public string opis { get; set; }
        public string cilj { get; set; }
        public Dete dete { get; set; }
        public Program program{ get; set; }

        public string TableName => "PlanTreninga";

        public string Values => $"{id},{dete.id},{program.sifraPrograma}";

        public object JoinValues { get; set ; }
        public object JoinCondition { get ; set; }
        public object UpdateValues { get; set; }
        public object UpdateCondition { get ; set; }

        List<IEntity> IEntity.GetReaderList(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {

                PlanTreninga pl = new PlanTreninga();
                pl.id = (int)reader["idPlanTreninga"];
                pl.dete = new Dete();
                pl.dete.id = (int)reader["deteID"];
                pl.program = new Program();
                pl.program.sifraPrograma = (int)reader["programID"];

                list.Add(pl);
            }

            return list;
        }

        List<IEntity> IEntity.GetReaderListJoin(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {

                PlanTreninga pl = new PlanTreninga();
                pl.id = (int)reader["idPlanTreninga"];
                pl.dete = new Dete();
                pl.dete.id = (int)reader["idDete"];
               pl.program=new Program();
                pl.program.sifraPrograma = (int)reader["sifraPrograma"];
               
                list.Add(pl);
            }

            return list;
        }

       
    }
}

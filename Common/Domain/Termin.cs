using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Termin:IEntity
    {
        public int id { get; set; }
        public DateTime datumIVreme { get; set; }
        

        public bool slobodan { get; set; }
        public PlanTreninga planTreninga { get; set; } = null;
        public string ImeDete => planTreninga?.dete?.ime;
        public string PrezimeDete => planTreninga?.dete?.prezime;
        public string NazivPrograma => planTreninga?.program?.nazivPrograma;
        public Trener trener { get; set; }
        public object vrednost
        { get
            {
                if (planTreninga != null) {
                    return planTreninga.id;
                } else { return null; }
            } }

        public string TableName => "Termin";

        /*  public string Values => $"'{datumIVreme.ToString("yyyy-MM-dd HH:mm")}', '{slobodan}', {vrednost} ,{trener.id}";
        */
        public string Values
        {
            get
            {
                string planTreningaValue = (planTreninga != null) ? planTreninga.id.ToString() : "NULL";
                return $"'{datumIVreme.ToString("yyyy-MM-dd HH:mm")}', '{slobodan}', {planTreningaValue}, {trener.id}";
            }
        }


        public object JoinValues { get; set; }
        public object JoinCondition { get; set; }
        public object UpdateValues { get; set; }
        public object UpdateCondition { get; set; }

        List<IEntity> IEntity.GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        List<IEntity> IEntity.GetReaderListJoin(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {

                Termin termin = new Termin();
              
                termin.id = (int)reader["idTermin"];
                
                
                termin.datumIVreme = (DateTime)reader["datumIVreme"];
                termin.slobodan = (bool)reader["slobodan"];
          
                int? planTreningaID = reader["planTreningaID"] as int?;
                if (planTreningaID.HasValue)
                {
                    termin.planTreninga = new PlanTreninga()
                    {
                        id = planTreningaID.Value,
                        
                    };
                }
                else
                {
                    termin.planTreninga = null;
                }

                if (planTreningaID != null)
                {
                    termin.planTreninga.program = new Common.Domain.Program()
                    {
                        sifraPrograma = (int)reader["sifraPrograma"],
                        nazivPrograma = (string)reader["nazivPrograma"],
                      
                    };
                }


                if (planTreningaID != null)
                {
                termin.planTreninga.dete = new Dete()
                {
                    ime = (string)reader["ime"],
                    prezime = (string)reader["prezime"],
                    datumRodjenja = (DateTime)reader["datumRodjenja"]
                };
                }
                termin.trener = new Trener() { id = (int)reader["trenerID"] };
                
                list.Add(termin);
            }

            return list;
        }
    }
}

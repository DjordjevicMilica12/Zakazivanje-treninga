using Common;
using Common.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class Broker
    {
        private DbConnection connection;
        public Broker()
        {
            connection = new DbConnection();
        }

        public void Rollback()
        {
            connection.Rollback();
        }
        public void CloseConnection()
        {
            connection.CloseConnection();
        }

        public void OpenConnection()
        {
            connection.OpenConnection();
        }
        public void Commit()
        {
            connection.Commit();
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }


        public void Add(IEntity obj)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"insert into {obj.TableName} values({obj.Values})";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public List<IEntity> getAll(IEntity obj)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from {obj.TableName}";
            SqlDataReader reader = command.ExecuteReader();
            List<IEntity> list = obj.GetReaderList(reader);
            reader.Close();
            command.Dispose();
            return list;
        }

        public List<IEntity> getAllWithCondition(IEntity obj, string condition = "")
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select {obj.JoinValues} from {obj.TableName} {obj.JoinCondition} {condition}";
            SqlDataReader reader = command.ExecuteReader();
            List<IEntity> list = obj.GetReaderListJoin(reader);
            reader.Close();
            command.Dispose();
            return list;
        }

        public void Update(IEntity obj)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"update {obj.TableName} set {obj.UpdateValues} where {obj.UpdateCondition}";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public void Delete(IEntity obj)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"delete from {obj.TableName} where {obj.UpdateValues}";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }




    }
}
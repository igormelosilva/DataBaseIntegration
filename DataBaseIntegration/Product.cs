using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DataBaseIntegration
{
    public class Product
    {
        //Atributos
        int Id { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public int quantity { get; set; }

        public float value { get; set; }

        //metodos
        public bool Add(Product product)
        {
            bool result = false;
            DataBaseAccess dba = new DataBaseAccess();

            try
            {
                using(NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"INSERT INTO products " +
                                      @"(name, model, quantity, value)" +
                                      @"VALUES" +
                                      @"(@name, @model, @quantity, @value);";
                    cmd.Parameters.AddWithValue("@name", product.name);
                    cmd.Parameters.AddWithValue("@model", product.model);
                    cmd.Parameters.AddWithValue("@quantity", product.quantity);
                    cmd.Parameters.AddWithValue("@value", product.value);

                    using(cmd.Connection = dba.OpenConnection())
                    {
                        cmd.ExecuteNonQuery();
                        result = true;
                    }
                }
            }
            catch (Exception)
            {

                
            }
            return result;
        }

    }
}

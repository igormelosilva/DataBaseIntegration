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
        public int id { get; set; }
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

        public Product Get(int id)
        {
            Product result = new Product();
            DataBaseAccess dba =new DataBaseAccess();

            try
            {
                using(NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"SELECT * FROM products " +
                                      @"WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", id);

                    using(cmd.Connection=dba.OpenConnection())
                    using(NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result.id = Convert.ToInt32(reader["id"]);
                            result.name = reader["name"].ToString();
                            result.model = reader["model"].ToString();
                            result.quantity = Convert.ToInt32(reader["value"].ToString());
                        }
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public List<Product> GetAll()
        {
            List<Product> result = new List<Product>();
            DataBaseAccess dba = new DataBaseAccess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"SELECT * FROM products;";

                    cmd.Parameters.AddWithValue("@id", id);

                    using (cmd.Connection = dba.OpenConnection())
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product();
                            product.id = Convert.ToInt32(reader["id"]);
                            product.name = reader["name"].ToString();
                            product.model = reader["model"].ToString();
                            product.quantity = Convert.ToInt32(reader["value"].ToString());

                            result.Add(product);
                        }
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            return result;


        }
        
        public bool Delete(int id)
        {
            bool result = false;
            DataBaseAccess dba = new DataBaseAccess();

            try
            {
                using(NpgsqlCommand cmd = new NpgsqlCommand()) 
                {
                    cmd.CommandText = @"DELETE FROM products " +
                                      @"WHERE id = @id;";

                    cmd.Parameters.AddWithValue ("@id", id);

                    using(cmd.Connection = dba.OpenConnection())
                    {
                        cmd.ExecuteNonQuery();
                        result = true;
                    }
                        
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }

        public bool Update(Product product) 
        {
            bool result = false;
            DataBaseAccess dba = new DataBaseAccess();

            try
            {
                using(NpgsqlCommand cmd = new NpgsqlCommand()) 
                {
                    cmd.CommandText = @"UPDATE products " +
                                      @"SET name = @name, model = @model, quantity = @quantity, value = @value " +
                                      @"WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", product.id);
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
            catch (Exception ex)
            {

                throw;
            }
            return result;
        
        }
    }
}

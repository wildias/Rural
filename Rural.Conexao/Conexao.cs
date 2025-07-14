using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Rural.Dominio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rural.Conexao
{
    public class Conexao
    {
        public static string stringConexao;
        public static bool BancoLocal { get; set; }

        public Conexao()
        {

        }

        public static string DataSourceCon => new RuralContext(stringConexao).Database.GetDbConnection().DataSource;

        public static bool Migrar()
        {
            try
            {
                try
                {
                    using (var contexto = new RuralContext(stringConexao))
                    {
                        var pendingMigrations = contexto.Database?.GetPendingMigrations();

                        //var pendingMigrations = contexto.Database?.GetPendingMigrations()?.ToList();

                        //if ((pendingMigrations?.Count ?? 0) > 0)
                        //{
                        //    contexto.Database.Migrate();
                        //}

                        if ((pendingMigrations != null))
                        {
                            contexto.Database.Migrate();
                        }
                    }

                }
                catch (SqlException sqlError)
                {
                    
                }

                return true;
            }
            catch (Exception erro)
            {
                return false;
            }
        }
    }
}

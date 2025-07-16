using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Rural.Dominio.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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

        public static int Insert(object objeto, string nomeTabela = null, string[] omitirColunas = null, string bancoDeDados = null)
        {
            try
            {
                using (var contexto = new RuralContext(stringConexao))
                {
                    contexto.Add(objeto);
                    contexto.SaveChanges();
                }

                return 1;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static int InsertListaZCore(object[] objeto)
        {
            try
            {
                using (var contexto = new RuralContext(stringConexao))
                {
                    contexto.BulkInsert(objeto, options =>
                    {
                        options.AutoMapOutputDirection = false;
                    });
                }

                return 1;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static int AtualizarListaZCore(object[] objeto, string colunaChavePrimaria, string[] omitirColunas = null, bool gravarIntegracao = true)
        {
            try
            {
                using (var contexto = new RuralContext(stringConexao))
                {
                    contexto.BulkUpdate(objeto, options =>
                    {
                        options.AutoMapOutputDirection = false;
                    });
                }

                return 1;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static int Update(object objeto, string nomeTabela, string colunaChavePrimaria, string[] omitirColunas = null, string BancoDeDados = null)
        {

            try
            {
                using (var contexto = new RuralContext(stringConexao))
                {
                    contexto.Entry(objeto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    contexto.Update(objeto);
                    contexto.SaveChanges();

                    return 1;
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static List<T> Query<T>(string sql, object parameters = null, int? timeOut = null) /*where T : new()*/
        {
            using (var contexto = new RuralContext(stringConexao))
            using (var connect = contexto.Database.GetDbConnection())
            {
                return connect.Query<T>(sql, parameters, commandTimeout: timeOut).ToList();
            }
        }

        public static int Execute(string sql, object parameters = null, bool gravarIntegracao = false)
        {
            using (var contexto = new RuralContext(stringConexao))
            using (var connect = contexto.Database.GetDbConnection())
            {
                connect.Execute(sql, parameters);

                return 1;
            }

        }

        private static string ObterStringInsert(object objeto, string nomeTabela, string bancoDeDados = "RURAL", string[] omitirColunas = null)
        {

            if (string.IsNullOrEmpty(bancoDeDados))
            {
                bancoDeDados = "RURAL";
            }
            var valuesSql = string.Empty;

            try
            {
                var prinf = objeto.GetType().GetProperties().Where(pp => !pp.GetGetMethod().IsVirtual).ToList();

                prinf.RemoveAll(pp => pp.GetGetMethod().IsStatic);

                if (prinf != null)
                {
                    foreach (var pf in prinf)
                    {
                        if (!(pf.DeclaringType?.Name ?? "").Contains(nomeTabela)) continue;

                        if (!(omitirColunas ?? new[] { "" }).Contains(pf.Name))
                        {
                            valuesSql += $@",@{pf.Name}";
                        }
                    }

                    valuesSql = valuesSql.Substring(1, valuesSql.Length - 1);

                    var sql = $@"INSERT INTO {(bancoDeDados ?? "Farma")}..{nomeTabela} ({valuesSql.Replace("@", "")}) Values ({valuesSql})";
                    return sql;

                }
                return null;

            }
            catch (Exception erro)
            {
                //LogPdv.Instance.Error(erro);
                return null;
            }
        }

        private static string ObterStringUpdate(object objeto, string nomeTabela, string colunaChavePrimaria, string banco = "RURAL", string[] omitirColunas = null, bool ignorarVirtual = true)
        {
            try
            {
                string valuesSql = string.Empty;

                List<PropertyInfo> prinf = null;
                if (ignorarVirtual)
                {
                    prinf = objeto.GetType().GetProperties().Where(pp =>
                    !pp.GetGetMethod().IsVirtual
                    && pp.GetCustomAttributesData().FirstOrDefault(c => c.AttributeType.Name.Equals("jsonignoreattribute", StringComparison.OrdinalIgnoreCase)) == null)
                    .ToList();
                }
                else
                {
                    prinf = objeto.GetType().GetProperties().Where(pp =>
                     pp.GetCustomAttributesData().FirstOrDefault(c => c.AttributeType.Name.Equals("jsonignoreattribute", StringComparison.OrdinalIgnoreCase)) == null)
                    .ToList();
                }

                prinf.RemoveAll(x => x.GetGetMethod().IsStatic);

                if (prinf != null)
                {
                    foreach (var pf in prinf)
                    {
                        if (pf.ReflectedType?.Name == nomeTabela)
                        {
                            if (!(omitirColunas ?? new[] { "" }).Contains(pf.Name) && !pf.Name.Contains("Navigation"))
                            {
                                valuesSql += $@",{pf.Name} = @{pf.Name}";
                            }
                        }
                    }

                    valuesSql = valuesSql.Substring(1, valuesSql.Length - 1);

                    if (!string.IsNullOrEmpty(banco))
                    {
                        banco = "RURAL";
                    }

                    var sql = $@"UPDATE {banco}..{nomeTabela} SET {valuesSql} WHERE {colunaChavePrimaria} = @{colunaChavePrimaria}";

                    return sql;
                }

                return null;
            }
            catch (Exception erro)
            {
                return null;
            }
        }

        public static string TratarStringConexaoMaster()
        {
            try
            {
                string stringConexaoLocal = string.Empty;
                if (BancoLocal)
                {
                    stringConexaoLocal = $@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true";
                }
                else if (!string.IsNullOrEmpty(stringConexao))
                {
                    var conexao = stringConexao.Split(';');
                    var host = conexao[0].Split('\\')[0].Split('=')[1];
                    if (host == "." ||
                        host.ToLower().Contains("localhost") ||
                        host.ToLower().Contains("127.0.0.1") ||
                        host.ToLower().Contains(Environment.MachineName))
                    {
                        stringConexaoLocal =
                            $@"{conexao[0].Trim()}; {conexao[1].Trim()}; {conexao[2].Trim()};{conexao[3].Trim()};";
                    }
                    else
                    {
                        return null;
                    }
                }

                return stringConexaoLocal;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static RuralContext CreateContexto() => new RuralContext(stringConexao);

        public static IDbConnection CreateConnection(bool integracao = false, int timeOut = 60)
        {
            var strConexao = (integracao) ? stringConexao : stringConexao;

            if (!stringConexao?.Contains("Connection Timeout") ?? false)
            {
                strConexao += $";Connection Timeout={timeOut}";
            }

            return new RuralContext(strConexao).Database.GetDbConnection();
        }
    }
}

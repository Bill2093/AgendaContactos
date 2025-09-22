using System.Data;
using System.IO;
using Microsoft.Data.Sqlite;

public static class SqliteDb
{
    private static readonly string _dbPath =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "agenda.db");
    private static readonly string _connStr = $"Data Source={_dbPath}";

    public static void EnsureCreated()
    {
        // SQLite crea el archivo al abrir la conexión si no existe.
        using var con = new SqliteConnection(_connStr);
        con.Open();
        using var cmd = con.CreateCommand();
        cmd.CommandText =
        @"CREATE TABLE IF NOT EXISTS contactos(
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Nombre   TEXT NOT NULL,
            Telefono TEXT,
            Correo   TEXT,
            Direccion TEXT
          );";
        cmd.ExecuteNonQuery();
    }

    public static DataTable GetAll()
    {
        using var con = new SqliteConnection(_connStr);
        con.Open();
        using var cmd = con.CreateCommand();
        cmd.CommandText = "SELECT * FROM contactos ORDER BY Id DESC";
        using var reader = cmd.ExecuteReader();
        var dt = new DataTable();
        dt.Load(reader);
        return dt;
    }

    public static void Insert(Contacto c)
    {
        using var con = new SqliteConnection(_connStr);
        con.Open();
        using var cmd = con.CreateCommand();
        cmd.CommandText = @"INSERT INTO contactos(Nombre,Telefono,Correo,Direccion)
                            VALUES($n,$t,$c,$d)";
        cmd.Parameters.AddWithValue("$n", c.Nombre);
        cmd.Parameters.AddWithValue("$t", c.Telefono);
        cmd.Parameters.AddWithValue("$c", c.Correo);
        cmd.Parameters.AddWithValue("$d", c.Direccion);
        cmd.ExecuteNonQuery();
    }

    public static void Update(Contacto c)
    {
        using var con = new SqliteConnection(_connStr);
        con.Open();
        using var cmd = con.CreateCommand();
        cmd.CommandText = @"UPDATE contactos
                            SET Nombre=$n, Telefono=$t, Correo=$c, Direccion=$d
                            WHERE Id=$id";
        cmd.Parameters.AddWithValue("$n", c.Nombre);
        cmd.Parameters.AddWithValue("$t", c.Telefono);
        cmd.Parameters.AddWithValue("$c", c.Correo);
        cmd.Parameters.AddWithValue("$d", c.Direccion);
        cmd.Parameters.AddWithValue("$id", c.Id);
        cmd.ExecuteNonQuery();
    }

    public static void Delete(int id)
    {
        using var con = new SqliteConnection(_connStr);
        con.Open();
        using var cmd = con.CreateCommand();
        cmd.CommandText = "DELETE FROM contactos WHERE Id=$id";
        cmd.Parameters.AddWithValue("$id", id);
        cmd.ExecuteNonQuery();
    }

    public static DataTable Search(string term)
    {
        using var con = new SqliteConnection(_connStr);
        con.Open();
        using var cmd = con.CreateCommand();
        cmd.CommandText =
            @"SELECT * FROM contactos
              WHERE Nombre LIKE $q OR Telefono LIKE $q OR Correo LIKE $q OR Direccion LIKE $q
              ORDER BY Id DESC";
        cmd.Parameters.AddWithValue("$q", $"%{term}%");
        using var reader = cmd.ExecuteReader();
        var dt = new DataTable();
        dt.Load(reader);
        return dt;
    }
}

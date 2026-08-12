using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string connectionString = "Server = (localhost)\\SQLEXPRESS; Database = ContactDB; Trusted_Connection = True; MultipleActiveResultSets = true";

using (var connection = new SqlConnection(connectionString))
{
    connection.Open();
    using var createDbCommand = connection.CreateCommand();
    createDbCommand.CommandText = @"IF NOT EXISTS (SELECT * FROM sys.database WHERE name = 'ContactDB')
                                    BEGIN
                                        CREATE DATABASE ContactDB
                                    END";
    createDbCommand.ExecuteNonQuery();
    connection.ChangeDatabase("ContactDB");
    using var command = connection.CreateCommand();
    command.CommandText = @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Contacts' AND xtype = 'U'
                            BEGIN
                                CREATE TABLE IF NOT EXISTS Contacts(
                                ContactId INT AUTO_INCREMENT PRIMARY KEY,
                                ContactName VARCHAR(20),
                                ContactEmail VARCHAR(100),
                                ContactNumber VARCHAR(10)
                                )
                            END";
    command.ExecuteNonQuery();
}

app.MapGet("/api/Contacts", () =>
{
    var contacts = new List<ContactModel>();
    using var connection = new SqlConnection(connectionString);
    connection.Open();
    using var command = connection.CreateCommand();
    command.CommandText = "SELECT ContactId, ContactName, ContactEmail, ContactNumber FROM Contacts";
    using var reader = command.ExecuteReader();
    while (reader.Read())
    {
        contacts.Add(new ContactModel
        {
            ContactId =  reader.GetInt32(0),
            ContactName = reader.IsDBNull(1)?string.Empty : reader.GetString(1),
            ContactEmail = reader.IsDBNull(2)?string.Empty : reader.GetString(2),
            ContactNumber = reader.IsDBNull(3)?string.Empty : reader.GetString(3)
        });
    }

    return Results.Ok(contacts);
});

app.MapPost("/api/Contacts", (ContactModel contact) =>
{
    using var connection = new SqlConnection(connectionString);
    connection.Open();

    using var command = connection.CreateCommand();
    command.CommandText = "INSERT INTO Contacts(ContactName ,ContactEmail ,ContactNumber) VALUES(@ContactName, @ContactEmail, @ContactNumber)";

    command.Parameters.AddWithValue("@ContactName", contact.ContactName);
    command.Parameters.AddWithValue("@ContactEmail", contact.ContactEmail);
    command.Parameters.AddWithValue("@ContactNumber", contact.ContactNumber);

    command.ExecuteNonQuery();
    return Results.Created("/api/Contacts", contact);
});

app.MapDelete("/api/Contacts/{contactId}", (int contactId) =>
{
    using var connection = new SqlConnection(connectionString);
    connection.Open();

    using var command = connection.CreateCommand();
    command.CommandText = "DELETE FROM Contacts WHERE ContactId = @contactId";
    command.Parameters.AddWithValue("@contactId", contactId);
    int rowsAffected = command.ExecuteNonQuery();
    return rowsAffected > 0 ? Results.NoContent() : Results.NotFound();
});    

app.Run();

public partial class Program{ }
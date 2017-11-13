using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using BandTracker.Models;
using MySql.Data.MySqlClient;

namespace BandTracker.Tests
{
  [TestClass]
  public class BandTest : IDisposable
  {
    public BandTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=band_tracker_test;";
    }
    public void Dispose()
    {
        Band.DeleteAll();
        Venue.DeleteAll();
        MySqlConnection conn = DB.Connection();
        conn.Open();
        var cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"TRUNCATE TABLE bands_venues;";
        cmd.ExecuteNonQuery();
        conn.Close();
        if (conn != null)
        {
          conn.Dispose();
        }
      }

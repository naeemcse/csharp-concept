﻿using AdoNetExample;

AdonetUtility adonetUtility = new AdonetUtility();
var sql = "insert into Student (name,dateofBirth,ismarried) values (@name,@dateofbirth,@ismarried)";
var dataSql = "select * from Student where id<@ID";
Dictionary<string, object> DataToInsert = new Dictionary<string, object>();
DataToInsert.Add("name", "abcd");
DataToInsert.Add("dateofbirth", new DateTime(2008, 2, 1));
DataToInsert.Add("ismarried", false);


// for insertign data 
//adonetUtility.RunSql(sql, DataToInsert);



Dictionary<string,object> parameters = new Dictionary<string, object>();
parameters.Add("ID", 10);

var result = adonetUtility.GetData(dataSql, parameters);

foreach (var row in result)
{
    foreach (var itemSql in row.Keys)
    {
        Console.Write(row[itemSql]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
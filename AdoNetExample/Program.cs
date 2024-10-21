using AdoNetExample;

AdonetUtility adonetUtility = new AdonetUtility();
var sql = "insert into Student (name,dateofBirth,ismarried) values ('Jaladuddin','2/2/1998',1)";
var dataSql = "select * from Student";
//adonetUtility.RunSql(sql);


var result = adonetUtility.GetData(dataSql);

foreach (var row in result)
{
    foreach (var itemSql in row.Keys)
    {
        Console.Write(row[itemSql]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
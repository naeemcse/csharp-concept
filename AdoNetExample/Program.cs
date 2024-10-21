using AdoNetExample;

AdonetUtility adonetUtility = new AdonetUtility();
var sql = "insert into Student (name,dateofBirth,ismarried) values ('Jaladuddin','2/2/1998',1)";
adonetUtility.RunSql(sql);
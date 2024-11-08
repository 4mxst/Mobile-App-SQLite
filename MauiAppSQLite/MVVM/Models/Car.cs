using System;
using SQLite;

namespace MauiAppSQLite.MVVM.Model;

public class Car
{
    [PrimaryKey , AutoIncrement]
    public int ID { get ; set ;}
    
    [Column("car_id")]
    public string CarId { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("group_no")]
    public int GroupNo { get; set; }

    [Column("avatar") , MaxLength(200)]
    public string Avatar { get; set; }
}

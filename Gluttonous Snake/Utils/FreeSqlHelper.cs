﻿using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gluttonous_Snake.Utils
{
    public class FreeSqlHelper
    {
        public IFreeSql SqliteDb { get; set; }
        public FreeSqlHelper()
        {
            var baseUrl = AppDomain.CurrentDomain.BaseDirectory.ToString();
            var connectStr = $"Data Source={baseUrl}sqliteDb.db";
            GD.Print($"sqliteDb数据库连接位置为:{connectStr}");
            //CodeFrist不需要安装即可运行
            SqliteDb = new FreeSql.FreeSqlBuilder()
                .UseConnectionString(FreeSql.DataType.Sqlite, connectStr)//数据库连接地址
                .UseAutoSyncStructure(true)//DbFirst模式
                .Build();
        }
    }
}

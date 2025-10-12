using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace ParallelProcessingApp
{
    // === Задача 2: Микросервисы ===
    public class Goods { public int Id { get; set; } }

    public class Order
    {
        public int Id { get; set; }
        public List<Goods> GoodsList { get; set; } = new();
        public double PersonalDiscount { get; set; }
        public string Address { get; set; }
    }

    public class Info { public double Price { get; set; } public int Count { get; set; } }

    public class Storage
    {
        public ConcurrentDictionary<Goods, Info> Inventory { get; } = new();
    }

    // === Задача 3: LINQ vs PLINQ ===
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<OrderSimple> Orders { get; set; } = new();
    }

    public class OrderSimple
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
    }
}
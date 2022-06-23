﻿using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Configuration;

public class ContextBase: DbContext
{
    public ContextBase(DbContextOptions<ContextBase> options): base(options)
    {
        
    }
    
    public DbSet<Product> Product{ get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(GetStringConnectionConfig);
        base.OnConfiguring(optionsBuilder);
    }

    private string GetStringConnectionConfig()
    {
        string strCon = "";
        return strCon;
    }
}


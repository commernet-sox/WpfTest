﻿using CPC.DBCore;
using DataCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCore
{
    /// <summary>
    /// 加入审计功能，继承AuditDbContext，不加审计直接继承DbContext
    /// </summary>
    public class TestApiContext : AuditDbContext
    {
        public TestApiContext(DbContextOptions<TestApiContext> options) : base(options)
        {

        }

        public DbSet<TestApi> TestApi { get; set; }

        public override int SaveChanges()
        {
            Audit audit = new Audit();
            audit.PreSaveChanges(this);
            var rowAffecteds = base.SaveChanges();
            audit.PostSaveChanges();

            this.AuditEntry.AddRange(audit.Entries);
            base.SaveChanges();
            //if (audit.Configuration.AutoSavePreAction != null && !audit.Entries.IsNull())
            //{

            //    audit.Configuration.AutoSavePreAction(this, audit);
            //    this.AuditEntry.AddRange(audit.Entries);
            //    base.SaveChanges();
            //}

            return rowAffecteds;
        }

    }
}

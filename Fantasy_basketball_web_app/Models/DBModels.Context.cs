﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fantasy_basketball_web_app.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class nbaStatsEntities : DbContext
    {
        public nbaStatsEntities()
            : base("name=nbaStatsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C2018_2019> C2018_2019 { get; set; }
        public virtual DbSet<C1985_1986> C1985_1986 { get; set; }
        public virtual DbSet<C1986_1987> C1986_1987 { get; set; }
        public virtual DbSet<C1987_1988> C1987_1988 { get; set; }
        public virtual DbSet<C1988_1989> C1988_1989 { get; set; }
        public virtual DbSet<C1989_1990> C1989_1990 { get; set; }
        public virtual DbSet<C1990_1991> C1990_1991 { get; set; }
        public virtual DbSet<C1991_1992> C1991_1992 { get; set; }
        public virtual DbSet<C1992_1993> C1992_1993 { get; set; }
        public virtual DbSet<C1993_1994> C1993_1994 { get; set; }
        public virtual DbSet<C1994_1995> C1994_1995 { get; set; }
        public virtual DbSet<C1995_1996> C1995_1996 { get; set; }
        public virtual DbSet<C1996_1997> C1996_1997 { get; set; }
        public virtual DbSet<C1997_1998> C1997_1998 { get; set; }
        public virtual DbSet<C1998_1999> C1998_1999 { get; set; }
        public virtual DbSet<C1999_2000> C1999_2000 { get; set; }
        public virtual DbSet<C2000_2001> C2000_2001 { get; set; }
        public virtual DbSet<C2001_2002> C2001_2002 { get; set; }
        public virtual DbSet<C2002_2003> C2002_2003 { get; set; }
        public virtual DbSet<C2003_2004> C2003_2004 { get; set; }
        public virtual DbSet<C2004_2005> C2004_2005 { get; set; }
        public virtual DbSet<C2005_2006> C2005_2006 { get; set; }
        public virtual DbSet<C2006_2007> C2006_2007 { get; set; }
        public virtual DbSet<C2007_2008> C2007_2008 { get; set; }
        public virtual DbSet<C2008_2009> C2008_2009 { get; set; }
        public virtual DbSet<C2009_2010> C2009_2010 { get; set; }
        public virtual DbSet<C2010_2011> C2010_2011 { get; set; }
        public virtual DbSet<C2011_2012> C2011_2012 { get; set; }
        public virtual DbSet<C2012_2013> C2012_2013 { get; set; }
        public virtual DbSet<C2013_2014> C2013_2014 { get; set; }
        public virtual DbSet<C2014_2015> C2014_2015 { get; set; }
        public virtual DbSet<C2015_2016> C2015_2016 { get; set; }
        public virtual DbSet<C2016_2017> C2016_2017 { get; set; }
        public virtual DbSet<C2017_2018> C2017_2018 { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanceDataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FinanceEntities : DbContext
    {
        public FinanceEntities()
            : base("name=FinanceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company> Companys { get; set; }
        public virtual DbSet<IncomeStatement> IncomeStatements { get; set; }
    
        [DbFunction("FinanceEntities", "ufn_LessRevenuePeers")]
        public virtual IQueryable<ufn_LessRevenuePeers_Result> ufn_LessRevenuePeers(string symbol)
        {
            var symbolParameter = symbol != null ?
                new ObjectParameter("symbol", symbol) :
                new ObjectParameter("symbol", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ufn_LessRevenuePeers_Result>("[FinanceEntities].[ufn_LessRevenuePeers](@symbol)", symbolParameter);
        }
    
        [DbFunction("FinanceEntities", "ufn_MaxStmtDate")]
        public virtual IQueryable<ufn_MaxStmtDate_Result> ufn_MaxStmtDate(string symbol)
        {
            var symbolParameter = symbol != null ?
                new ObjectParameter("symbol", symbol) :
                new ObjectParameter("symbol", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ufn_MaxStmtDate_Result>("[FinanceEntities].[ufn_MaxStmtDate](@symbol)", symbolParameter);
        }
    
        [DbFunction("FinanceEntities", "ufn_MoreRevenuePeers")]
        public virtual IQueryable<ufn_MoreRevenuePeers_Result> ufn_MoreRevenuePeers(string symbol)
        {
            var symbolParameter = symbol != null ?
                new ObjectParameter("symbol", symbol) :
                new ObjectParameter("symbol", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ufn_MoreRevenuePeers_Result>("[FinanceEntities].[ufn_MoreRevenuePeers](@symbol)", symbolParameter);
        }
    
        [DbFunction("FinanceEntities", "ufn_TargetRevenue")]
        public virtual IQueryable<ufn_TargetRevenue_Result> ufn_TargetRevenue(string symbol)
        {
            var symbolParameter = symbol != null ?
                new ObjectParameter("symbol", symbol) :
                new ObjectParameter("symbol", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ufn_TargetRevenue_Result>("[FinanceEntities].[ufn_TargetRevenue](@symbol)", symbolParameter);
        }
    
        public virtual ObjectResult<getSectorsByIPO_Result> getSectorsByIPO(Nullable<int> iPOYear)
        {
            var iPOYearParameter = iPOYear.HasValue ?
                new ObjectParameter("IPOYear", iPOYear) :
                new ObjectParameter("IPOYear", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getSectorsByIPO_Result>("getSectorsByIPO", iPOYearParameter);
        }
    
        public virtual ObjectResult<proc_LessRevenuePeers_Result> proc_LessRevenuePeers(string symbol)
        {
            var symbolParameter = symbol != null ?
                new ObjectParameter("symbol", symbol) :
                new ObjectParameter("symbol", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_LessRevenuePeers_Result>("proc_LessRevenuePeers", symbolParameter);
        }
    
        public virtual ObjectResult<proc_MoreRevenuePeers_Result> proc_MoreRevenuePeers(string symbol)
        {
            var symbolParameter = symbol != null ?
                new ObjectParameter("symbol", symbol) :
                new ObjectParameter("symbol", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_MoreRevenuePeers_Result>("proc_MoreRevenuePeers", symbolParameter);
        }
    }
}

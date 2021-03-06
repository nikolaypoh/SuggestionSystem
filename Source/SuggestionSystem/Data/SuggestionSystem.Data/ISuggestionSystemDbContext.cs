﻿namespace SuggestionSystem.Data
{
    using Models;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Threading.Tasks;

    public interface ISuggestionSystemDbContext
    {
        IDbSet<User> Users { get; set; }

        IDbSet<Suggestion> Suggestions { get; set; }

        IDbSet<Comment> Comments { get; set; }

        IDbSet<Vote> Votes { get; set; }

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();

        Task<int> SaveChangesAsync();

        void Dispose();
    }
}

﻿using CleanStore.Application.SharedContext.Repositories.Abstractions;

namespace CleanStore.Infrastructure.SharedContext.Data
{
    public class UnitOfWork(AppDbContext context) : IUnityOfWork
    {
        public async Task CommitAsync()
        {
            await context.SaveChangesAsync();
        }

        public  Task RollbackAsync() => Task.CompletedTask;
    }
}

﻿using Demo.Domain;
using Demo.Domain.Repository;
using Demo.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;

        public IBookRepository BookRepository { get; private set; }
        public IAuthorRepository AuthorRepository { get; private set; }
        public UnitOfWork(DbContext context)
        {
            _dbContext = context;
            BookRepository = new BookRepository((ApplicationDbContext)context);
            AuthorRepository = new AuthorRepository((ApplicationDbContext)context);
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}

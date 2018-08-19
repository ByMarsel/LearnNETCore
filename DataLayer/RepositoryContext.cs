using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options){



        }

        public DbSet<Post> Posts;
        public DbSet<Comment> Comments;
        public DbSet<Tag> Tags;
        public DbSet<User> Users; 
    }
}

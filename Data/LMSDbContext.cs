
using System;
using LMS.Models;
using Microsoft.EntityFrameworkCore;

namespace LMS.Data;

public class LMSDbContext : DbContext
{
  public LMSDbContext(DbContextOptions<LMSDbContext> options) : base(options)
  {
  }

  public DbSet<Category> Categories { get; set; } = default!;

}
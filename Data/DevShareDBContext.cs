using DevShareWebApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevShareWebApi.Data;

public class DevShareDBContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
}
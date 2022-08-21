using Microsoft.EntityFrameworkCore;
using ApiToDo.models;

namespace ApiToDo.Data
{
    public class ApiContext : Dbcontext 
    {


        public DbSet<Todo> Todo { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options)
        {

        }
    }

    public class DbContextOptions<T>
    {
    }

    public class Todo
    {
    }

    public class Dbcontext
    {
    }
}

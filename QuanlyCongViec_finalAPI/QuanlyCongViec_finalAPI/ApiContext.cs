using Microsoft.EntityFrameworkCore;
using System;

namespace QuanlyCongViec_finalAPI
{
    public class ApiContext : DbContext
    {
        public ApiContext() { }
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
    }
}

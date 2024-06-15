using Infrastructure.Contexts;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories;

public class UserRepository(DataContext context) : Repo<UserEntity>(context)
{
    private readonly DataContext _context = context;
}

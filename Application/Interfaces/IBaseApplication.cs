﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IBaseApplication<Entity> where Entity: class
    {
        Task Add(Entity entity);
        Task Updade(Entity entity);
        Task Delete(Entity entity);
        Task<Entity> SearchById(Entity entity);
        Task<List<Entity>> List();
    }
}

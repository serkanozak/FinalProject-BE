﻿using Core.DataAccess.Repositories;
using Entities;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IExperienceDal : IRepository<Experience, Guid>, IAsyncRepository<Experience, Guid>
{

}


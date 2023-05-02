﻿using Core.DataAccess.Abstract;
using MezuniyetSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezuniyetSistemi.DataAccess.Abstract
{
    public interface IProfileDal : IRepositoryBase<Profile>
    {
    }
}
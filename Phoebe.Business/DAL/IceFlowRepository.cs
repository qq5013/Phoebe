﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Phoebe.Business.DAL
{
    using Phoebe.Base;
    using Phoebe.Model;

    /// <summary>
    /// 冰块流水Repository
    /// </summary>
    public class IceFlowRepository : SqlDataAccess<PhoebeContext>, IBaseDataAccess<IceFlow>
    {
        #region Method
        public IceFlow FindById(object id)
        {
            throw new NotImplementedException();
        }

        public IceFlow FindOne(Expression<Func<IceFlow, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IceFlow> Find(Expression<Func<IceFlow, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IceFlow> FindAll()
        {
            throw new NotImplementedException();
        }

        public ErrorCode Create(IceFlow entity)
        {
            throw new NotImplementedException();
        }

        public ErrorCode CreateRange(List<IceFlow> entities)
        {
            throw new NotImplementedException();
        }

        public ErrorCode Update(IceFlow entity)
        {
            throw new NotImplementedException();
        }

        public ErrorCode Delete(IceFlow entity)
        {
            throw new NotImplementedException();
        }
        #endregion //Method
    }
}

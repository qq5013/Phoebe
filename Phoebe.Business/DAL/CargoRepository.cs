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
    /// 货品Repository
    /// </summary>
    public class CargoRepository : SqlDataAccess<PhoebeContext>, IBaseDataAccess<Cargo>
    {
        #region Method
        /// <summary>
        /// 根据ID查找
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public Cargo FindById(object id)
        {
            return this.context.Cargoes.Find(id);
        }

        /// <summary>
        /// 查找所有货品
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Cargo> FindAll()
        {
            return this.context.Cargoes;
        }

        /// <summary>
        /// 按条件查找货品
        /// </summary>
        /// <param name="predicate">查询条件</param>
        /// <returns></returns>
        public IEnumerable<Cargo> Find(Expression<Func<Cargo, bool>> predicate)
        {
            return this.context.Cargoes.Where(predicate);
        }

        /// <summary>
        /// 添加货品
        /// </summary>
        /// <param name="entity">货品实体</param>
        /// <returns></returns>
        public ErrorCode Create(Cargo entity)
        {
            try
            {
                this.context.Cargoes.Add(entity);
                this.context.SaveChanges();
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }

            return ErrorCode.Success;
        }

        public ErrorCode CreateRange(List<Cargo> entities)
        {
            throw new NotImplementedException();
        }

        public ErrorCode Update(Cargo entity)
        {
            throw new NotImplementedException();
        }

        public ErrorCode Delete(Cargo entity)
        {
            throw new NotImplementedException();
        }

        public Cargo FindOne(Expression<Func<Cargo, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        #endregion //Method
    }
}

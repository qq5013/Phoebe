﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Phoebe.Business
{
    using Phoebe.Base;
    using Phoebe.Model;
    using Phoebe.Business.DAL;

    /// <summary>
    /// 出库业务类
    /// </summary>
    public class StockOutBusiness : BaseBusiness<StockOut>
    {
        #region Field
        /// <summary>
        /// 数据访问接口
        /// </summary>
        private IBaseDataAccess<StockOut> dal;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 出库业务类
        /// </summary>
        public StockOutBusiness() : base()
        {
            this.dal = RepositoryFactory<StockOutRepository>.Instance;
            base.Init(this.dal);
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 获取最新流水单号
        /// </summary>
        /// <param name="outTime">出库时间</param>
        /// <returns></returns>
        private string GetLastFlowNumber(DateTime outTime)
        {
            Expression<Func<StockOut, bool>> predicate = r => r.OutTime == outTime;
            var data = this.dal.Find(predicate).OrderByDescending(r => r.FlowNumber);

            if (data.Count() == 0)
                return string.Format("{0}{1}{2}0001",
                    outTime.Year, outTime.Month.ToString().PadLeft(2, '0'), outTime.Day.ToString().PadLeft(2, '0'));
            else
            {
                int newNumber = Convert.ToInt32(data.First().FlowNumber.Substring(8)) + 1;
                return string.Format("{0}{1}{2}{3}", outTime.Year, outTime.Month.ToString().PadLeft(2, '0'),
                    outTime.Day.ToString().PadLeft(2, '0'), newNumber.ToString().PadLeft(4, '0'));
            }
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 获取出库月份分组
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// 用于树形导航分组
        /// </remarks>
        public string[] GetMonthGroup()
        {
            var data = this.dal.FindAll().GroupBy(r => r.MonthTime).Select(g => g.Key).OrderByDescending(s => s);
            return data.ToArray();
        }

        /// <summary>
        /// 按月度获取出库记录
        /// </summary>
        /// <param name="monthTime">月份</param>
        /// <returns></returns>
        public List<StockOut> GetByMonth(string monthTime)
        {
            Expression<Func<StockOut, bool>> predicate = r => r.MonthTime == monthTime;
            var data = this.dal.Find(predicate).OrderByDescending(r => r.FlowNumber);
            return data.ToList();
        }

        /// <summary>
        /// 根据客户查找出库单
        /// </summary>
        /// <param name="customerId">客户ID</param>
        /// <returns></returns>
        public List<StockOut> GetByCustomer(int customerId)
        {
            var data = this.dal.Find(r => r.Contract.CustomerId == customerId).OrderByDescending(r => r.FlowNumber);
            return data.ToList();
        }

        /// <summary>
        /// 根据合同查找出库单
        /// </summary>
        /// <param name="contractId">合同ID</param>
        /// <returns></returns>
        public List<StockOut> GetByContract(int contractId)
        {
            var data = this.dal.Find(r => r.ContractId == contractId).OrderByDescending(r => r.FlowNumber);
            return data.ToList();
        }

        /// <summary>
        /// 创建出库单
        /// </summary>
        /// <param name="entity">出库单对象</param>
        /// <param name="models">出库信息模型</param>
        /// <returns></returns>
        public ErrorCode Create(StockOut entity, List<StockOutModel> models)
        {
            try
            {
                // set stock out
                entity.FlowNumber = GetLastFlowNumber(entity.OutTime.Date);
                entity.Status = (int)EntityStatus.StockOutReady;

                // generate stock out details
                List<StockOutDetail> details = new List<StockOutDetail>();
                foreach (var item in models)
                {
                    StockOutDetail detail = new StockOutDetail();
                    detail.Id = Guid.NewGuid();
                    detail.StockOutId = entity.Id;
                    detail.StoreId = item.StoreId;
                    detail.StoreCount = item.StoreCount;
                    detail.Count = item.OutCount;
                    detail.OutWeight = item.OutWeight;
                    detail.OutVolume = item.OutVolume;
                    detail.Remark = item.Remark;
                    detail.Status = (int)EntityStatus.StockOutReady;

                    details.Add(detail);
                }

                var trans = new TransactionRepository();
                ErrorCode result = trans.StockOutAddTrans(entity, details);

                return result;
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }
        }

        /// <summary>
        /// 出库确认
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ErrorCode Confirm(Guid id)
        {
            try
            {
                StockOut stockOut = this.dal.FindById(id);
                if (stockOut == null)
                    return ErrorCode.ObjectNotFound;

                if (stockOut.Status == (int)EntityStatus.StockOut)
                    return ErrorCode.StockOutHasConfirm;

                // check store count
                foreach (var item in stockOut.StockOutDetails)
                {
                    var store = item.Store;
                    if (store.StoreCount < item.Count)
                        return ErrorCode.StockOutCountOverflow;
                }

                var trans = new TransactionRepository();
                var result = trans.StockOutConfirmTrans(stockOut);

                return result;
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }
        }

        /// <summary>
        /// 出库编辑
        /// </summary>
        /// <param name="stockOut">出库单对象</param>
        /// <param name="models">出库数据</param>
        /// <returns></returns>
        public ErrorCode Edit(StockOut stockOut, List<StockOutModel> models)
        {
            try
            {
                if (stockOut.Status == (int)EntityStatus.StockOut)
                    return ErrorCode.StockOutHasConfirm;

                // generate stock out details
                List<StockOutDetail> details = new List<StockOutDetail>();
                foreach (var item in models)
                {
                    StockOutDetail detail = new StockOutDetail();
                    detail.Id = Guid.NewGuid();
                    detail.StockOutId = stockOut.Id;
                    detail.StoreId = item.StoreId;
                    detail.StoreCount = item.StoreCount;
                    detail.Count = item.OutCount;
                    detail.OutWeight = item.OutWeight;
                    detail.OutVolume = item.OutVolume;
                    detail.Remark = item.Remark;
                    detail.Status = (int)EntityStatus.StockOutReady;

                    details.Add(detail);
                }

                var trans = new TransactionRepository();
                ErrorCode result = trans.StockOutUpdateTrans(stockOut, details);

                return result;
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }
        }

        /// <summary>
        /// 出库删除
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ErrorCode Delete(Guid id)
        {
            try
            {
                StockOut stockOut = this.dal.FindById(id);
                if (stockOut == null)
                    return ErrorCode.ObjectNotFound;

                if (stockOut.Status == (int)EntityStatus.StockOut)
                    return ErrorCode.StockOutCannotDelete;

                var result = this.dal.Delete(stockOut);

                return result;
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }
        }

        /// <summary>
        /// 出库撤回
        /// </summary>
        /// <param name="id">出库单ID</param>
        /// <returns></returns>
        public ErrorCode Revert(Guid id)
        {
            try
            {
                StockOut stockOut = this.dal.FindById(id);
                if (stockOut == null)
                    return ErrorCode.ObjectNotFound;

                if (stockOut.Status != (int)EntityStatus.StockOut)
                    return ErrorCode.StockOutCannotRevert;

                foreach (var item in stockOut.StockOutDetails)
                {
                    // get relate store
                    var store = item.Store;

                    // check has stock out
                    if (RepositoryFactory<StockOutDetailsRepository>.Instance.Find(r => r.StoreId == store.Id && string.Compare(r.StockOut.FlowNumber, stockOut.FlowNumber) > 0).Count() > 0)
                        return ErrorCode.StockOutCannotRevert;

                    // check has stock move
                    if (RepositoryFactory<StockMoveDetailsRepository>.Instance.Find(r => r.SourceStoreId == store.Id && r.StockMove.MoveTime >= stockOut.OutTime).Count() > 0)
                        return ErrorCode.StockOutCannotRevert;
                }

                var trans = new TransactionRepository();
                var result = trans.StockOutRevertTrans(stockOut);

                return result;
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }
        }
        #endregion //Method
    }
}

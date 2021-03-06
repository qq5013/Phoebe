﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoebe.Model
{
    /// <summary>
    /// 出库模型，货品出库时使用
    /// </summary>
    public class StockOutModel
    {
        /// <summary>
        /// 出库记录ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 出库单ID
        /// </summary>
        public Guid StockOutId { get; set; }

        /// <summary>
        /// 库存ID
        /// </summary>
        public Guid StoreId { get; set; }

        /// <summary>
        /// 合同ID
        /// </summary>
        public int ContractId { get; set; }

        /// <summary>
        /// 货品ID
        /// </summary>
        public Guid CargoId { get; set; }

        /// <summary>
        /// 类别ID
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// 类别编码
        /// </summary>
        public string CategoryNumber { get; set; }

        /// <summary>
        /// 类别名称
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        public string Specification { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 在库数量
        /// </summary>
        public int StoreCount { get; set; }

        /// <summary>
        /// 出库数量
        /// </summary>
        public int OutCount { get; set; }

        /// <summary>
        /// 货品分组方式
        /// </summary>
        public int GroupType { get; set; }

        /// <summary>
        /// 单位重量
        /// </summary>
        public decimal UnitWeight { get; set; }

        /// <summary>
        /// 出库重量
        /// </summary>
        public decimal OutWeight { get; set; }

        /// <summary>
        /// 单位体积
        /// </summary>
        public decimal UnitVolume { get; set; }

        /// <summary>
        /// 出库体积
        /// </summary>
        public decimal OutVolume { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        public string WarehouseNumber { get; set; }

        /// <summary>
        /// 入库时间
        /// </summary>
        public DateTime InTime { get; set; }

        /// <summary>
        /// 移入时间
        /// </summary>
        public DateTime MoveTime { get; set; }

        /// <summary>
        /// 产地
        /// </summary>
        public string OriginPlace { get; set; }

        /// <summary>
        /// 保质期
        /// </summary>
        public int ShelfLife { get; set; }

        /// <summary>
        /// 入库备注
        /// </summary>
        public string StockInRemark { get; set; }

        /// <summary>
        /// 备注 
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }
    }
}

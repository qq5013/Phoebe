﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Phoebe.Business;
using Phoebe.Common;
using Phoebe.Model;

namespace Phoebe.UI.Controllers
{
    /// <summary>
    /// 类别控制器
    /// </summary>
    public class CategoryController : Controller
    {
        #region Field
        /// <summary>
        /// 类别业务
        /// </summary>
        private CategoryBusiness categoryBusiness;
        #endregion //Field

        #region Constructor
        public CategoryController()
        {
            this.categoryBusiness = new CategoryBusiness();
        }
        #endregion ///Constructor

        #region Action
        /// <summary>
        /// 类别主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var data = this.categoryBusiness.GetFirstCategory();
            return View(data);
        }

        /// <summary>
        /// 添加一级分类
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult CreateFirstCategory()
        {
            return View();
        }

        /// <summary>
        /// 添加一级分类
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CreateFirstCategory(FirstCategory model)
        {
            if (ModelState.IsValid)
            {
                ErrorCode result = this.categoryBusiness.CreateFirstCategory(model);
                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "添加一级分类成功";
                    return RedirectToAction("Index", new { controller = "Category" });
                }
                else
                {
                    TempData["Message"] = "添加一级分类失败";
                    ModelState.AddModelError("", "添加一级分类失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 添加二级分类
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult CreateSecondCategory()
        {
            return View();
        }

        /// <summary>
        /// 添加二级分类
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CreateSecondCategory(SecondCategory model)
        {
            if (ModelState.IsValid)
            {
                ErrorCode result = this.categoryBusiness.CreateSecondCategory(model);
                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "添加二级分类成功";
                    return RedirectToAction("Index", new { controller = "Category" });
                }
                else
                {
                    TempData["Message"] = "添加二级分类失败";
                    ModelState.AddModelError("", "添加二级分类失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 添加三级分类
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult CreateThirdCategory()
        {
            return View();
        }

        /// <summary>
        /// 添加三级分类
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CreateThirdCategory(ThirdCategory model)
        {
            if (ModelState.IsValid)
            {
                ErrorCode result = this.categoryBusiness.CreateThirdCategory(model);
                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "添加三级分类成功";
                    return RedirectToAction("Index", new { controller = "Category" });
                }
                else
                {
                    TempData["Message"] = "添加三级分类失败";
                    ModelState.AddModelError("", "添加三级分类失败: " + result.DisplayName());
                }
            }

            return View(model);
        }
        #endregion //Action

        #region JSON
        /// <summary>
        /// 获取一级分类
        /// </summary>
        /// <remarks>
        /// 调用:
        /// /Category/CreateThirdCategory
        /// </remarks>
        /// <returns></returns>
        public JsonResult GetFirstCategory()
        {
            var first = this.categoryBusiness.GetFirstCategory();
            var data = from r in first
                       select new { r.ID, r.Name };

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 获取二级分类
        /// </summary>
        /// <param name="first">一级分类ID</param>
        /// <remarks>
        /// 调用：
        /// /Category/CreateThirdCategory
        /// </remarks>
        /// <returns></returns>
        public JsonResult GetSecondCategory(int first)
        {
            var second = this.categoryBusiness.GetSecondCategoryByFirst(first);
            var data = from r in second
                       select new { r.ID, r.Name };

            return Json(data, JsonRequestBehavior.AllowGet);
        }
        #endregion //JSON
    }
}
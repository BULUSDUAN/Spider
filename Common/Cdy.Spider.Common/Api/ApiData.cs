﻿//==============================================================
//  Copyright (C) 2020  Inc. All rights reserved.
//
//==============================================================
//  Create by 种道洋 at 2020/8/11 16:24:42.
//  Version 1.0
//  种道洋
//==============================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Cdy.Spider
{
    /// <summary>
    /// 
    /// </summary>
    public class ApiData
    {

        #region ... Variables  ...
        
        /// <summary>
        /// 
        /// </summary>
        public enum TransType 
        {
            /// <summary>
            /// 定时
            /// </summary>
            Timer,
            /// <summary>
            /// 值改变
            /// </summary>
            ValueChanged
        }

        #endregion ...Variables...

        #region ... Events     ...

        #endregion ...Events...

        #region ... Constructor...

        #endregion ...Constructor...

        #region ... Properties ...

        /// <summary>
        /// 定时周期
        /// </summary>
        public int Circle { get; set; }

        /// <summary>
        /// 传输类型
        /// </summary>
        public TransType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ServerIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }

        #endregion ...Properties...

        #region ... Methods    ...

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual XElement SaveToXML()
        {
            XElement xx = new XElement("ApiData");
            xx.SetAttributeValue("Type", (int)Type);
            xx.SetAttributeValue("Circle", Circle);
            xx.SetAttributeValue("UserName", UserName);
            xx.SetAttributeValue("Password", Password);
            return xx;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xe"></param>
        public virtual void LoadFromXML(XElement xe)
        {
            if (xe.Attribute("Type") != null)
            {
                this.Type = (TransType)(int.Parse(xe.Attribute("Name").Value));
            }
            this.UserName = xe.Attribute("UserName")?.Value;
            this.Password = xe.Attribute("Password")?.Value;
            if (xe.Attribute("Circle") != null)
            {
                this.Circle = int.Parse(xe.Attribute("Circle").Value);
            }
        }

        #endregion ...Methods...

        #region ... Interfaces ...

        #endregion ...Interfaces...
    }
}
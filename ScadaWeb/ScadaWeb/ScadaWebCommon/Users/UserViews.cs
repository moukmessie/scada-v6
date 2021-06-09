﻿/*
 * Copyright 2021 Rapid Software LLC
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : ScadaWebCommon
 * Summary  : Contains view explorer nodes available to a user
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2016
 * Modified : 2021
 */

using Scada.Data.Models;
using Scada.Lang;
using Scada.Log;
using Scada.Web.Plugins;
using Scada.Web.Services;
using Scada.Web.TreeView;
using System;
using System.Collections.Generic;

namespace Scada.Web.Users
{
    /// <summary>
    /// Contains view explorer nodes available to a user.
    /// <para>Содержит узлы дерева представлений, доступные пользователю.</para>
    /// </summary>
    public class UserViews
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public UserViews()
        {
            ViewNodes = new List<ViewNode>();
        }


        /// <summary>
        /// Gets the root view nodes, which can contain child nodes.
        /// </summary>
        public List<ViewNode> ViewNodes { get; }


        /// <summary>
        /// Initializes the user views.
        /// </summary>
        public void Init(IWebContext webContext, UserRights userRights)
        {
            if (webContext == null)
                throw new ArgumentNullException(nameof(webContext));
            if (userRights == null)
                throw new ArgumentNullException(nameof(userRights));

            try
            {
            }
            catch (Exception ex)
            {
                webContext.Log.WriteException(ex, Locale.IsRussian ?
                    "Ошибка при инициализации представлений пользователя" :
                    "Error initializing user views");
            }
        }
    }
}
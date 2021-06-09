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
 * Summary  : Represents a user configuration
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2021
 * Modified : 2021
 */

using System;
using System.Collections.Generic;

namespace Scada.Web.Users
{
    /// <summary>
    /// Represents a user configuration.
    /// <para>Представляет конфигурацию пользователя.</para>
    /// </summary>
    public class UserConfig
    {
        /// <summary>
        /// Gets or sets the time zone identifier.
        /// </summary>
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the start page.
        /// </summary>
        public string StartPage { get; set; }
    }
}
﻿/*
 * Copyright 2022 Rapid Software LLC
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
 * Module   : ScadaCommon
 * Summary  : Specifies the severity levels
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2021
 * Modified : 2021
 */

namespace Scada.Data.Const
{
    /// <summary>
    /// Specifies the severity levels.
    /// <para>Задаёт уровни серьезности.</para>
    /// </summary>
    public static class Severity
    {
        /// <summary>
        /// The minimum severity.
        /// </summary>
        public const int Min = 1;

        /// <summary>
        /// The maximum severity.
        /// </summary>
        public const int Max = 999;

        /// <summary>
        /// The undefined severity.
        /// </summary>
        public const int Undefined = 0;

        /// <summary>
        /// The critical severity from 1 to 249.
        /// </summary>
        public const int Critical = 1;

        /// <summary>
        /// The major severity from 250 to 499.
        /// </summary>
        public const int Major = 250;

        /// <summary>
        /// The minor severity from 500 to 749.
        /// </summary>
        public const int Minor = 500;

        /// <summary>
        /// The informational severity from 750 to 999.
        /// </summary>
        public const int Info = 750;


        /// <summary>
        /// Gets the closest known severity.
        /// </summary>
        public static int Closest(int value)
        {
            if (Critical <= value && value < Major)
                return Critical;
            else if (Major <= value && value < Minor)
                return Major;
            else if (Minor <= value && value < Info)
                return Minor;
            else if (Info <= value && value < Max)
                return Info;
            else
                return Undefined;
        }
    }
}

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
 * Module   : ScadaAdminCommon
 * Summary  : Contains the main nodes of the project explorer tree
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2022
 * Modified : 2022
 */

using System.Windows.Forms;

namespace Scada.Admin.Extensions
{
    /// <summary>
    /// Contains the main nodes of the project explorer tree.
    /// <para>Содержит основные узлы дерева проводника проекта.</para>
    /// </summary>
    public class ProjectNodes
    {
        /// <summary>
        /// Gets the project node.
        /// </summary>
        public TreeNode ProjectNode { get; init; }

        /// <summary>
        /// Gets the configuration database node.
        /// </summary>
        public TreeNode BaseNode { get; init; }

        /// <summary>
        /// Gets the views node.
        /// </summary>
        public TreeNode ViewsNode { get; init; }

        /// <summary>
        /// Gets the instances node.
        /// </summary>
        public TreeNode InstancesNode { get; init; }
    }
}
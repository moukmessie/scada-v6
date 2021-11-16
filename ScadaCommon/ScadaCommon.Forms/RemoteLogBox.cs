﻿// Copyright (c) Rapid Software LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Scada.Agent;
using Scada.Protocol;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Scada.Forms
{
    /// <summary>
    /// Provides displaying and updating both local and remote log.
    /// <para>Обеспечивает отображение и обновление как локального, так и удалённого журнала.</para>
    /// </summary>
    public class RemoteLogBox : LogBox
    {
        /// <summary>
        /// The remote path of the log.
        /// </summary>
        protected RelativePath logPath;


        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public RemoteLogBox(ListBox listBox, bool colorize = false)
            : base(listBox, colorize)
        {
            logPath = new RelativePath();
            AgentClient = null;
        }


        /// <summary>
        /// Gets or sets the client of the Agent service.
        /// </summary>
        public IAgentClient AgentClient { get; set; }

        /// <summary>
        /// Gets or sets the remote path of the log.
        /// </summary>
        public RelativePath LogPath
        {
            get
            {
                return logPath;
            }
            set
            {
                logPath = value;
                logFileAge = DateTime.MinValue;
            }
        }


        /// <summary>
        /// Refresh log content with Agent.
        /// </summary>
        protected void RefreshWithAgent()
        {
            try
            {
                if (FullLogView && AgentClient.ReadTextFile(logPath, ref logFileAge, out ICollection<string> lines) ||
                    !FullLogView && AgentClient.ReadTextFile(logPath, LogViewSize, ref logFileAge, out lines))
                {
                    if (!listBox.IsDisposed)
                        SetLines(lines);
                }
            }
            catch (Exception ex)
            {
                if (!listBox.IsDisposed)
                    SetFirstLine(ex.Message);
            }
        }

        /// <summary>
        /// Refresh log content.
        /// </summary>
        public void Refresh()
        {
            if (AgentClient != null)
            {
                if (AgentClient.IsLocal)
                    RefreshFromFile();
                else
                    RefreshWithAgent();
            }
        }
    }
}

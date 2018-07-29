﻿using Ft.Penzai.Api.Dataaccess;
using Ft.Penzai.Api.Dataaccess.Entities;
using Ft.Penzai.Api.Dataaccess.Extensions;
using Ft.Penzai.Api.Dtos.Logging;
using Ft.Penzai.Api.Services.LoggerProviders.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ft.Penzai.Api.Services.LoggerProviders
{
    public class EfLogService : ILogService
    {
        #region Field

        private readonly ApplicationDbContext context;

        #endregion Field

        public EfLogService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<LogEntry>> GetLogsAsync()
        {
            return this.context.LogEntries.Select(le => le.ToDto()).ToList();
        }

        public async Task LogAsync(string message)
        {
            this.context.LogEntries.Add(LogEntryEntity.Create(message));
        }
    }
}

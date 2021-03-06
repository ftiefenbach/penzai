﻿using Ft.Penzai.Api.Dataaccess.Entities;
using Ft.Penzai.Api.Dtos.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ft.Penzai.Api.Dataaccess.Extensions
{
    public static class LogEntryExtensions
    {
        public static LogEntry ToDto(this LogEntryEntity entry)
        {
            var ret = new LogEntry
            {
                CreatedOn = entry.CreatedOn.UtcDateTime,
                Message = entry.Message,
                Context = entry.Context,
                UserAgent = entry.UserAgent
                
            };

            return ret;
        }

        public static LogEntryEntity ToEntity(this LogEntry entry, string userAgent)
        {
            var ret = LogEntryEntity.Create(entry.Context, entry.Message, userAgent);
            return ret;
        }
    }
}

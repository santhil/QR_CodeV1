﻿using Dttl.Qr.Service.ActionFilters;
using Microsoft.AspNetCore.Mvc;

namespace Dttl.Qr.Service
{
    [PerformAuditLog]
    [HandleError]
    [ValidateModel]
    public class BaseController : ControllerBase
    {
        public readonly ILogger _logger;

        public BaseController(ILogger logger)
        {
            _logger = logger;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DevFreela.API.Enuns
{
    public enum ProjectStatusEnum
    {
        Created = 0,
        InProgress = 1,
        Suspended = 2,
        Cancelled = 3,
        Completed = 4,
        PaymentPending = 5

    }
}
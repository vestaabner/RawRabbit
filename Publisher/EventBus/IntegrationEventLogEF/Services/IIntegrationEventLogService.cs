using Microsoft.EntityFrameworkCore.Storage;
using MicroTest1.EventBus.EventBus.Events;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace MicroTest1.EventBus.IntegrationEventLogEF.Services
{
    public interface IIntegrationEventLogService
    {
        Task<IEnumerable<IntegrationEventLogEntry>> RetrieveEventLogsPendingToPublishAsync(Guid transactionId);
        Task SaveEventAsync(IntegrationEvent @event, IDbContextTransaction transaction);
        Task MarkEventAsPublishedAsync(Guid eventId);
        Task MarkEventAsInProgressAsync(Guid eventId);
        Task MarkEventAsFailedAsync(Guid eventId);
    }
}

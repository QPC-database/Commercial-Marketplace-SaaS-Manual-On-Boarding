﻿using System.Threading;
using System.Threading.Tasks;
using CommandCenter.Models;

namespace CommandCenter
{
    public interface IMarketplaceNotificationHandler
    {
        Task NotifyChangePlanAsync(NotificationModel notificationModel, CancellationToken cancellationToken = default);

        Task ProcessActivateAsync(
            AzureSubscriptionProvisionModel provisionModel,
            CancellationToken cancellationToken = default);

        Task ProcessChangePlanAsync(
            AzureSubscriptionProvisionModel provisionModel,
            CancellationToken cancellationToken = default);

        Task ProcessChangeQuantityAsync(
            NotificationModel notificationModel,
            CancellationToken cancellationToken = default);

        Task ProcessOperationFailOrConflictAsync(
            NotificationModel notificationModel,
            CancellationToken cancellationToken = default);

        Task ProcessReinstatedAsync(NotificationModel notificationModel, CancellationToken cancellationToken = default);

        Task ProcessSuspendedAsync(NotificationModel notificationModel, CancellationToken cancellationToken = default);

        Task ProcessUnsubscribedAsync(
            NotificationModel notificationModel,
            CancellationToken cancellationToken = default);
    }
}
﻿// ==========================================================================
//  RuleActionHandler.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using System;
using System.Threading.Tasks;
using Squidex.Domain.Apps.Core.Rules;
using Squidex.Domain.Apps.Events;
using Squidex.Infrastructure.CQRS.Events;

namespace Squidex.Domain.Apps.Core.HandleRules
{
    public abstract class RuleActionHandler<T> : IRuleActionHandler where T : RuleAction
    {
        Type IRuleActionHandler.ActionType
        {
            get { return typeof(T); }
        }

        (string Description, RuleJobData Data) IRuleActionHandler.CreateJob(Envelope<AppEvent> @event, string eventName, RuleAction action)
        {
            return CreateJob(@event, eventName, (T)action);
        }

        protected abstract (string Description, RuleJobData Data) CreateJob(Envelope<AppEvent> @event, string eventName, T action);

        public abstract Task<(string Dump, Exception Exception)> ExecuteJobAsync(RuleJobData job);
    }
}

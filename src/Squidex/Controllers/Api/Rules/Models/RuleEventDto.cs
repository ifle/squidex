﻿// ==========================================================================
//  RuleEventDto.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using System;
using System.ComponentModel.DataAnnotations;
using NodaTime;
using Squidex.Domain.Apps.Core.HandleRules;
using Squidex.Domain.Apps.Read.Rules;

namespace Squidex.Controllers.Api.Rules.Models
{
    public sealed class RuleEventDto
    {
        /// <summary>
        /// The id of the event.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The time when the event has been created.
        /// </summary>
        public Instant Created { get; set; }

        /// <summary>
        /// The description
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// The name of the event.
        /// </summary>
        [Required]
        public string EventName { get; set; }

        /// <summary>
        /// The last dump.
        /// </summary>
        public string LastDump { get; set; }

        /// <summary>
        /// The number of calls.
        /// </summary>
        public int NumCalls { get; set; }

        /// <summary>
        /// The next attempt.
        /// </summary>
        public Instant? NextAttempt { get; set; }

        /// <summary>
        /// The result of the event.
        /// </summary>
        public RuleResult Result { get; set; }

        /// <summary>
        /// The result of the job.
        /// </summary>
        public RuleJobResult JobResult { get; set; }
    }
}

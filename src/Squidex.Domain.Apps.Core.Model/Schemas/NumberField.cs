﻿// ==========================================================================
//  NumberField.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

namespace Squidex.Domain.Apps.Core.Schemas
{
    public sealed class NumberField : Field<NumberFieldProperties>
    {
        public NumberField(long id, string name, Partitioning partitioning)
            : base(id, name, partitioning, new NumberFieldProperties())
        {
        }

        public NumberField(long id, string name, Partitioning partitioning, NumberFieldProperties properties)
            : base(id, name, partitioning, properties)
        {
        }

        public override T Accept<T>(IFieldVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

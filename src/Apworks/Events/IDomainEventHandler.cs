﻿using Apworks.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apworks.Events
{
    [MessageHandlerStub(typeof(IDomainEvent), 1)]
    public interface IDomainEventHandler : IEventHandler<IDomainEvent>
    {
    }
}

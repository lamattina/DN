﻿using DN.SharedKernel.Events.Contracts;
using System;
using System.Collections.Generic;

namespace DN.SharedKernel.Contracts
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
    }
}

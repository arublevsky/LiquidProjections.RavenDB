﻿using System;

namespace ConsoleHost.Events
{
    internal class ContractNegotiatedEvent
    {
        public string Number { get; set; }
        public string Kind { get; set; }
        public Guid Country { get; set; }
        public string InitialState { get; set; }
    }
}
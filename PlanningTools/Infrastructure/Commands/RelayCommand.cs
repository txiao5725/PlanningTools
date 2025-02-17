﻿using System;
using XerParser.Infrastructure.Commands.Base;

namespace XerParser.Infrastructure.Commands
{
    internal class RelayCommand : CommandBase
    {
        private readonly Action<object> _Execute;
        private readonly Func<object, bool> _CanExecute;

        public RelayCommand(Action<object> Execute, Func<object, bool> CanExecute)
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = CanExecute;
        }

        public override bool CanExecute(object? parameter) => _CanExecute?.Invoke(parameter!) ?? true;

        public override void Execute(object? parameter) => _Execute(parameter!);
    }
}

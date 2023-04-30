using NetChat.Application.Commands.Base;
using System;

namespace NetChat.WPF.Commands
{
    internal class LambdaCommand : CommandBase // Реализация структурного шаблона проектирования - адаптер
    {
        private Action<object> execute { get; set; }
        private Func<object, bool> canExecute { get; set; }
        public LambdaCommand(Action<object> _execute, Func<object, bool> _canExecute)
        {
            execute = _execute ?? throw new ArgumentNullException($"{nameof(LambdaCommand)} - {nameof(_execute)} - contains null");
            canExecute = _canExecute;
        }
        public override bool CanExecute(object? param) => canExecute?.Invoke(param) ?? true;
        public override void Execute(object? param) => execute?.Invoke(param);
    }
}

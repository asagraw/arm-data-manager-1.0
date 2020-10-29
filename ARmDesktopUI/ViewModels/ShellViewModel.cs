using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARmDesktopUI.EventModels;
using Caliburn.Micro;

namespace ARmDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<Object>, IHandle<LogOnEvent>
    {
        private LoginViewModel _loginVM;
        private IEventAggregator _events;
        private SalesViewModel _salesVM;

        public ShellViewModel(LoginViewModel loginVM, IEventAggregator events, SalesViewModel salesVM)
        {
            _events = events;
            _events.Subscribe(this);

            _loginVM = loginVM;
            _salesVM = salesVM;
            ActivateItem(loginVM);
        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(_salesVM);
            _loginVM = IoC.Get<LoginViewModel>();
        }
    }
}

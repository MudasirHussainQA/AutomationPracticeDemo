using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeDemo
{
    public interface IDriver : INavigationService, IBrowserService, ICookiesService, IElementFindService, IDialogService
    {
    }
}

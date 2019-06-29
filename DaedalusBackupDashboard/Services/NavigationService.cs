using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaedalusBackupDashboard.Services
{
    public class NavigationService
    {
        private string _lastTitle;
        private string _currentTitle;
        public string Title { get; set; }
    }
}

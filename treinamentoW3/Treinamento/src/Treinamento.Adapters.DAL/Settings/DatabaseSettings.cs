using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Adapters.DAL.Settings
{
    public class DatabaseSettings
    {
        private string _conString;

        public string DefaultConnection { get => _conString; }
        public DatabaseSettings(string conString)
        {
            _conString = conString;
        }

    }
}

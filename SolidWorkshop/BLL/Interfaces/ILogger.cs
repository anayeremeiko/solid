using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop.BLL
{
    public interface ILogger
    {
        /// <summary>
        /// Log message.
        /// </summary>
        /// <param name="logText">Message.</param>
        void Log(string logText);
    }
}

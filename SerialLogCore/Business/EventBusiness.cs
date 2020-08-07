using SerialLogCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;
using SerialLogCore;

namespace SerialLogCore.Business
{
    /// <summary>
    /// 
    /// </summary>
    public class EventBusiness
    {
        private EventBusiness()
        {

        }
        private static EventBusiness _instance;
        /// <summary>
        /// 
        /// </summary>
        public static EventBusiness Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (typeof(EventBusiness))
                        _instance = new EventBusiness();
                }
                return _instance;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Save(EventModel model)
        {
            var log = new LoggerConfiguration().WriteTo.File("log.txt").CreateLogger();
            log.Information("Objeto : Evento\n Ação: Save", model.Guid, model.Id, model.Name, model.Data, model.Local, model.Description);

            return log.ToString();
        }
    }
}

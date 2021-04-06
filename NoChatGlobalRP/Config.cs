using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoChatGlobalRP
{
  public  class Config : IRocketPluginConfiguration
    {
        public string mensaje;
        public void LoadDefaults()
        {
            mensaje = "No Puedes Escribir En Global";
        }
    }
}

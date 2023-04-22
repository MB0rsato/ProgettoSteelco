using Monitoring_Infortuni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring_Infortuni.Services
{
    internal interface ISediDataService
    {
        List<SediModel> TutteLeSedi();
        int Inserisci(SediModel sede);
        int Modifica(SediModel sede);
        int Elimina(SediModel sede);

    }
}

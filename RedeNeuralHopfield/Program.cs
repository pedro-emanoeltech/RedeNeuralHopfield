using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RedeNeuralHopfield.Configuration;
using RedeNeuralHopfieldDomain.Interfaces.Repository;
using RedeNeuralHopfieldDomain.Interfaces.Services;
using RedeNeuralHopfieldDomain.Services;
using RedeNeuralHopfieldInfras.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RedeNeuralHopfield
{
    
    public static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = DependencyInjectionConfiguration.hostservices();
            Application.Run(services.GetRequiredService<FrmPrincipal>());

        }


    }
}

using Docker.DotNet;
using Docker.DotNet.Models;
using ErpSigmaVenda.navegacao;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErpSigmaVenda
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            using (var client = new DockerClientConfiguration(new Uri("npipe://./pipe/docker_engine")).CreateClient())
            {
                try
                {
                    
                    var containerName = "sqlserver-container"; 
                    var startParameters = new ContainerStartParameters();

                    await client.Containers.StartContainerAsync(containerName, startParameters);
                    Console.WriteLine($"Contêiner {containerName} iniciado com sucesso.");
                }
                catch (Docker.DotNet.DockerApiException ex)
                {
                    Console.WriteLine($"Erro ao iniciar o contêiner SQL Server: {ex.Message}");
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmTelaPrincipal());

            using (var client = new DockerClientConfiguration(new Uri("npipe://./pipe/docker_engine")).CreateClient())
            {
                try
                {
                    
                    var containerName = "sqlserver-container";
                    var stopParameters = new ContainerStopParameters
                    {
                        WaitBeforeKillSeconds = 5
                    };

                    await client.Containers.StopContainerAsync(containerName, stopParameters);
                    Console.WriteLine($"Contêiner {containerName} parado com sucesso.");
                }
                catch (Docker.DotNet.DockerApiException ex)
                {
                    Console.WriteLine($"Erro ao parar o contêiner SQL Server: {ex.Message}");
                }
            }

        }


    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace hello_docker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DockerController : ControllerBase
    {

        private readonly ILogger<DockerController> _logger;

        public DockerController(ILogger<DockerController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/hello-docker")]
        public HelloDocker greeting()
        {
            //_logger.LogInformation("Endpoint /hello-docker is called!!!");
            //var hostName = Environment.GetEnvironmentVariable("COMPUTERNAME");
            var hostName = Environment.GetEnvironmentVariable("HOSTNAME");

            return new HelloDocker(
                        "Hello Docker",
                        hostName
                    );
        }
    }
}
package br.com.erudio

import org.springframework.web.bind.annotation.RequestMapping
import org.springframework.web.bind.annotation.RestController

@RestController
class DockerController {
    
    @RequestMapping("/hello-docker")
    fun greeting(): HelloDocker {

        var hostName = System.getenv("HOSTNAME")

        if (hostName.isNullOrBlank()) hostName = System.getenv("COMPUTERNAME")

        return HelloDocker(
            "Hello Docker",
            hostName
        )
    }
}
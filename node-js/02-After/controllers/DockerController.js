module.exports = {
    async greeting(request, response) {

        // console.log("Endpoint /hello-docker is called!!!");
    
        var hostName = process.env.HOSTNAME;
        
        return response.json({
                content: "Hello Docker",
                environment: hostName
            }
        );
    }
}
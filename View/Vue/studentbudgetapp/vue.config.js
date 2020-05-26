module.exports = {
    devServer: {
        proxy: {
            "localhost/": {
                target: "https://localhost:5001/",
                changeOrigin: true,
                secure:false,
                ws: false,
                pathRewrite: {'/localhost':''},
          logLevel: 'debug' 
            }
        }
    }
}
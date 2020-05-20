module.exports = {
    devServer: {
        proxy: {
            '^localhost:500': {
                target: 'http://localhost:5000/api',
                ws: true,
                changeOrigin: true
            }
        }
    }
}
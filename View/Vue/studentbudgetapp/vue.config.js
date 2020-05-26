module.exports = {
    devServer: {
        proxy: {
            '^localhost:500': {
                target: 'https://localhost:5001/api',
                ws: true,
                changeOrigin: true
            }
        }
    }
}
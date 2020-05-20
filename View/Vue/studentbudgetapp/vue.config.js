module.exports = {
    devServer: {
        proxy: {
            '^': {
                ws: true,
                changeOrigin: true
            }
        }
    }
}
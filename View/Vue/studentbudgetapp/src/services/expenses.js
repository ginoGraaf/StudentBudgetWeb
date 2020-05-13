//const apiUrl = 'http://localhost:5000'

export const expenseService = {
    getAll,
    getById,
    update,
    deleteById
}

function getAll() {
    return {
           expenses: [
                {
                    id: 1,
                    name: "Boodschappen",
                    amount: "18.34"
                },
                {
                    id: 2,
                    name: "Zorgverzekering",
                    amount: "99.50"
                },
                {
                    id: 3,
                    name: "Autoverzekering",
                    amount: "84.38"
                }
            ] 
    }
}

function getById() {

}

function update() {

}

function deleteById() {

}
import axios from "axios"
import { config } from './config'

export const expenseService = {
    getAll,
    getById,
    update,
    deleteById
}

async function getAll() {
    return await axios.get(`${config.apiUrl}/Expense/`, {headers: config.headers})
        .then(resp => {console.log(resp.data); return resp.data})
    // return {
    //        expenses: [
    //             {
    //                 id: 1,
    //                 name: "Boodschappen",
    //                 amount: "18.34"
    //             },
    //             {
    //                 id: 2,
    //                 name: "Zorgverzekering",
    //                 amount: "99.50"
    //             },
    //             {
    //                 id: 3,
    //                 name: "Autoverzekering",
    //                 amount: "84.38"
    //             }
    //         ] 
    // }
}

function getById() {

}

function update() {

}

function deleteById() {

}
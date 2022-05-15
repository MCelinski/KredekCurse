import Axios from 'axios'

Axios.interceptors.response.use(null, error =>{
    const expectedError = error.response && error.response.status >= 400 && error.response.status <500
    if(!expectedError){
        console.log(error)
        alert("Cos poszlo nie tak:(")
    }
    return Promise.reject(error)
    })

export default {
    get: Axios.get,
    post: Axios.post,
    put: Axios.put,
    delete: Axios.delete
}
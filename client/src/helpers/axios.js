import axios from 'axios';

const instance = axios.create({
    baseURL: 'http://localhost:5089/api', // Server API URL
});

export default instance;

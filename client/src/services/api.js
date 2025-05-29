import axios from 'axios';

const api = axios.create({
    baseURL: 'https://localhost:5001/api', // Adjust if your API uses another port
});

export default api;

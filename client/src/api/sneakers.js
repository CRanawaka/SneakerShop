import axios from 'axios';

export const getSneakers = async () => {
    const response = await axios.get('http://localhost:5000/api/sneakers');
    return response.data;
};

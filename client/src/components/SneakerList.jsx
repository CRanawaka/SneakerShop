import React, { useEffect, useState } from 'react';
import { getSneakers } from '../api/sneakers';

const SneakerList = () => {
    const [sneakers, setSneakers] = useState([]);

    useEffect(() => {
        getSneakers().then(setSneakers);
    }, []);

    return (
        <div>
            <h1>Sneakers</h1>
            <ul>
                {sneakers.map((sneaker) => (
                    <li key={sneaker.id}>
                        {sneaker.name} - ${sneaker.price}
                    </li>
                ))}
            </ul>
        </div>
    );
};

export default SneakerList;

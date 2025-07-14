
import './App.css';
import React, {useEffect, useState} from "react";
import ProductTable from "../components/ProductTable";
import axios from "axios";

function AppCopy() {

    const [products, setProducts] = useState([
        { name: "Mudd",
            description: "Sticks to feets"
        }
    ]);

    useEffect(() => {
        axios.get('/api/product')
            .then((response) => {
                setProducts(response.data)
            })
    }, []);



    return (
        <div className="App">
            <ProductTable products={products} />
            <button onClick={() => {
                axios.post('/api/product',
                    {
                        name: "Ball",
                        description: "Is bouncy"
                    }
                )
                    .then((response) => {
                        console.log(response);
                    })
            }}>
                Click to add
            </button>

        </div>
    );
}

export default AppCopy;

import React from 'react';
import {Link} from "react-router";


const ProductCard = ({product}) => {

    return (
        <div className="card">
            <img className="cover" src="https://bok.hstrom.se/cdn/shop/articles/9789100802226.jpg?v=1719136577" alt={product.image}/>
            <div>
                {/*<Link className="details-link" to={`/`}>{product.title}</Link>*/}
                <p className="price">{product.price}</p>
                <p>{product.title}</p>
                <p>{product.published}</p>
                <p>{product.publisher}</p>
                <p>{product.isbn}</p>
            </div>
        </div>
    );
};

export default ProductCard;
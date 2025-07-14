import './App.css'
import {bookdata} from "./data/book-data.js";
import ProductCard from "./components/ProductCard.jsx";

function App() {

  return (
    <>
        {bookdata.map((book) => <ProductCard product={book}/>)}


    </>
  )
}

export default App

import React from 'react';
import styled from "styled-components";
import axios from "axios";
import {useLoaderData} from "react-router";

const Container = styled.div`
    width: 1200px;
    margin: auto;
    & div > div > ul > li {
        padding: 10px 30px;
    }
`;

// eslint-disable-next-line react-refresh/only-export-components
export const userLoader = () => {
    return axios.get('/api/customer').then(response => response.data);
}
const User = () => {
    const userData = useLoaderData();

    return (
        <Container>
            <h1>User</h1>
            <div>
                <div>
                    {userData.orders.map( (order, index) =>
                        (
                            <p key={index}>{order}</p>
                        )
                    )}
                </div>
                <div >
                    <p>{userData.account}</p>
                </div>
                <div >
                    {userData.invoices.map( (invoice, index) =>
                        (
                            <p key={index}>{invoice}</p>
                        )
                    )}
                </div>
                <div>
                    <p>{userData.paymentOptions}</p>
                </div>
            </div>
        </Container>


    );
};

export default User;
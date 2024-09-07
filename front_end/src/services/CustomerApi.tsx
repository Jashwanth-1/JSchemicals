import { useState, useEffect } from 'react';
import Customer from '../models/Customer';

const baseCustomerUrl = "https://localhost:7222/api/customers/";

export function GetCustomers() {
    const [customerData,setData] = useState<Customer[]>([]);

    useEffect(() => {
        fetch(baseCustomerUrl + "getCustomers")
            .then(response => response.json())
            .then(json => setData(json))
            .catch(error => console.error(error));
        }, []);
    return customerData;
}

export function AddCustomer(){
    const [customerData, setData] = useState([]);
    
    useEffect(() => {
        fetch(baseCustomerUrl + "addCustomer")
            .then(response => response.json())
            .then(json => setData(json))
            .catch(error => console.error(error));
        }, []);
    return customerData;
}
import Navbar from "../navbar/Navbar";
import "./Customers.css";
import { useState } from 'react';
import Button from 'react-bootstrap/Button';
import Form from "react-bootstrap/esm/Form";
import Modal from 'react-bootstrap/Modal';
import { GetCustomers } from "../../services/CustomerApi";
import Customer from "../../models/Customer"

function Customers() {

    const [show, setShow] = useState(false);
    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);
    const customers : Customer[] = GetCustomers();

    function searchCustomer(){
        console.log("ab")
    }

    function addCustomer(){
        console.log("ab")
    }

    const saveModal = () => {
        addCustomer();
        handleClose();
    }

    const customerMap= () => {
        customers.map(customer => {
            <div>
                <li>{customer.CustomerName}</li>
                <li>{customer.GSTIN}</li>
                <li>{customer.Email}</li>
                <li>{customer.Address}</li>
            </div>
        })
    }

    return(<>
        <Navbar />

        <div>
            <input type="text" className="form-control"placeholder="Search Customer" onKeyUp={searchCustomer} />
            <Button variant="primary" onClick={handleShow}>Add Customer+</Button> 
        </div>

        <div className="Customer-Card">
            {customerMap}
        </div>

        <Modal show={show} onHide={handleClose} centered className="">
            <Modal.Header closeButton>
                <Modal.Title>New Customer</Modal.Title>
            </Modal.Header>
            <Modal.Body>
                <Form>
                    <Form.Group className="mb-3" controlId="CustomerForm.Name">
                        <Form.Label>Customer Name</Form.Label>
                        <Form.Control type="text" placeholder="Company Name" />
                    </Form.Group>
                    <Form.Group className="mb-3" controlId="CustomerForm.Name">
                        <Form.Label>Customer GSTIN</Form.Label>
                        <Form.Control type="text" placeholder="GST Number" />
                    </Form.Group>
                    <Form.Group className="mb-3" controlId="CustomerForm.Email">
                        <Form.Label>Email address</Form.Label>
                        <Form.Control type="email" placeholder="name@example.com" />
                    </Form.Group>
                    <Form.Group className="mb-3" controlId="CustomerForm.Address">
                        <Form.Label>Address</Form.Label>
                        <Form.Control as="textarea" />
                    </Form.Group>
                </Form>
            </Modal.Body>
            <Modal.Footer>
            <Button variant="secondary" onClick={handleClose}>
                Close
            </Button>
            <Button variant="primary" onClick={saveModal}>
                Save Changes
            </Button>
            </Modal.Footer>
      </Modal> 
    </>
    )
}

export default Customers;
import React, { Component } from 'react';
import EmployeeRow from './EmployeeRow';
import axios from 'axios';

class EmployeeTable extends Component {
    state = {
        employees: []
    }

    componentDidMount() {
        axios.get("employees").then(response => {
            let employees = response.data;
            employees.forEach(employee => {
                employee.HiredAt = this.parseDate(employee.HiredAt);
                if (employee.FiredAt) {
                    employee.FiredAt = this.parseDate(employee.FiredAt);
                }
            });
            this.setState({
                employees: employees
            });
        });
    }

    parseDate(date) {
        // received date format is "\/Date(1239018869048)\/" 
        // [.substr(6)] takes out the "/Date(" part
        // [.parseInt] ignores the non-number characters at the end
        return new Date(parseInt(date.substr(6)));
    }

    render() {
        const { employees } = this.state;
        return (
            <div className="table">
                <h1>Employees</h1>

                <div className="trow header">
                    <div className="cell">Employee ID</div>
                    <div className="cell">Full Name</div>
                    <div className="cell">Job Title</div>
                    <div className="cell">Salary</div>
                    <div className="cell">Hired At</div>
                    <div className="cell">Fired At</div>
                    <div className="cell">Email</div>
                    <div className="cell">Phone number</div>
                </div>


                {employees.map((employee) => (
                    <EmployeeRow
                        employee={employee}
                        key={employee.EmployeeID + "Row"}
                    />))}

            </div>
        );
    }
}

export default EmployeeTable;
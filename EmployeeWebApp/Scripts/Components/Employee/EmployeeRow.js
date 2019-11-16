import React from 'react';

const EmployeeRow = (props) => {
    const { employee } = props;

    return (

        <div className="trow">
            <div className="cell" data-title="Employee ID">
                {employee.EmployeeID}
            </div>
            <div className="cell" data-title="Full Name">
                {employee.FullName}
            </div>
            <div className="cell" data-title="Job Title">
                {employee.JobTitle}
            </div>
            <div className="cell" data-title="Salary">
                {employee.Salary}
            </div>
            <div className="cell" data-title="Hired At">
               {new Intl.DateTimeFormat('en-GB').format(employee.HiredAt)}
            </div>
            <div className="cell" data-title="Fired At">
                {employee.FiredAt ? Intl.DateTimeFormat('en-GB').format(employee.FiredAt) : "" }
            </div>
            <div className="cell" data-title="Email">
                {employee.Email}
            </div>
            <div className="cell" data-title="PhoneNumber">
                {employee.PhoneNumber}
            </div>

        </div>
    )
}

export default EmployeeRow;

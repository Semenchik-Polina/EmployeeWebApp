import React from 'react';
import { render } from 'react-dom'
import { Route, Switch, BrowserRouter } from 'react-router-dom';
import Nav from './Nav';
import EmployeeTable from './Employee/EmployeeTable';
import CandidateTable from './Candidate/CandidateTable';

const App = () => {
    return (
        <BrowserRouter>
            <div>
                <Nav />
                <Switch>
                    <Route exact path="/" component={EmployeeTable} />
                    <Route exact path="/employees" component={EmployeeTable} />
                    <Route exact path="/candidates" component={CandidateTable} />
                </Switch>
            </div>
        </BrowserRouter>
    )
}

render(
    <App />,
    document.getElementById("content")
)
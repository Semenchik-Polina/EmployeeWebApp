import React, { Component } from 'react';
import CandidateRow from './CandidateRow';
import axios from 'axios';

class CandidateTable extends Component {
    state = {
        candidates: []
    }

    componentDidMount() {
        axios.get("candidates").then(response => {
            this.setState({
                candidates: response.data
            });
        });
    }

    render() {
        const { candidates } = this.state;
        return (
            <div className="table">
                <h1>Candidates</h1>

                <div className="trow header">
                    <div className="cell">Candidate ID</div>
                    <div className="cell">Vacancy</div>
                    <div className="cell">Interview Begins At</div>
                    <div className="cell">Full Name</div>
                    <div className="cell">Email</div>
                    <div className="cell">Phone number</div>
                </div>

                {candidates.map((candidate) => (
                    <CandidateRow
                        candidate={candidate}
                        key={candidate.CandidateID + "Row"}
                    />))}

            </div>
        );
    }
}

export default CandidateTable;
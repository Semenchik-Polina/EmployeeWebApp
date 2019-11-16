import React, { Component } from 'react';
import CandidateRow from './CandidateRow';
import axios from 'axios';

class CandidateTable extends Component {
    state = {
        candidates: []
    }

    componentDidMount() {
        axios.get("candidates").then(response => {
            let candidates = response.data;
            candidates.forEach(candidate => {
                candidate.InterviewBeginsAt = this.parseDate(candidate.InterviewBeginsAt);
            });
            this.setState({
                candidates: response.data
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
        const { candidates } = this.state;
        return (
            <div className="table">
                <h1>Candidates</h1>

                <div className="trow header">
                    <div className="cell">Candidate ID</div>
                    <div className="cell">Full Name</div>
                    <div className="cell">Vacancy</div>
                    <div className="cell">Interview Begins At</div>
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
import React from 'react';

const CandidateRow = (props) => {
    const { candidate } = props;

    return (

        <div className="trow">
            <div className="cell" data-title="Candidate ID">
                {candidate.CandidateID}
            </div>
            <div className="cell" data-title="Vacancy">
                {candidate.Vacancy}
            </div>
            <div className="cell" data-title="Interview Begins At">
                {candidate.InterviewBeginsAt ? new Intl.DateTimeFormat('en-GB').format(candidate.InterviewBeginsAt.value) : ""}
            </div>
            <div className="cell" data-title="Full Name">
                {candidate.FullName}
            </div>
            <div className="cell" data-title="Email">
                {candidate.Email}
            </div>
            <div className="cell" data-title="PhoneNumber">
                {candidate.PhoneNumber}
            </div>
        </div>
    )
}

export default CandidateRow 
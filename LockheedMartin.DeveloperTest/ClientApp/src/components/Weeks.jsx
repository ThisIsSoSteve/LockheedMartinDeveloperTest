import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { AddWeek } from './AddWeek';

export class Weeks extends Component {

    constructor(props) {
        super(props);
        this.state = { weeks: [], loading: true, error: false };

        this.populateWeekData = this.populateWeekData.bind(this);
    }

    componentDidMount() {
        this.populateWeekData();
    }

    static renderWeeksTable(weeks) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    {weeks.map(week =>
                        <tr key={week.id}>
                            <td>{week.name}</td>
                            <td>
                                <Link to={`/${week.id}?name=${week.name}`} className="btn btn-primary float-right">
                                    View
                                 </Link>
                            </td>
                        </tr>
                    )}
                </tbody>
                </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Weeks.renderWeeksTable(this.state.weeks);

        let error = this.state.error
            ? <div className="alert alert-danger" role="alert">
                An error has occured while trying to fetch your data, please try again later.
            </div>
            : <></>

        return (
            <div>
                <h1 id="tabelLabel" >Weeks</h1>
                <AddWeek refresh={this.populateWeekData} />
                {contents}
                {error}
            </div>
        );
    }

    async populateWeekData() {
        const response = await fetch('api/week');
        if (response.ok) {
            const data = await response.json();

            this.setState({ weeks: data, loading: false });
        }
        else {
            this.setState({ error: true });
        }
    }
}

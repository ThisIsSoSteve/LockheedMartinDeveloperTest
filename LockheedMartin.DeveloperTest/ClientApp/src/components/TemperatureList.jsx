import React, { Component } from 'react';
import { AddTemperature } from './AddTemperature';

export class TemperatureList extends Component {

    constructor(props) {
        super(props);
        this.state = { temperatures: [], loading: true };

        this.populateTemperatureData = this.populateTemperatureData.bind(this);
    }

    componentDidMount() {
        this.populateTemperatureData(this.props.weekid, this.props.dayid);
    }

    static renderWeeksTable(temperatures) {
        
        return (
            <ul className="list-group">
                {temperatures.map(temperature =>
                    <li key={temperature.id} className="list-group-item">{temperature.temperatureC}&deg;C</li>
                )}
            </ul>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : TemperatureList.renderWeeksTable(this.state.temperatures);

        return (
            <div className="card mb-3 mr-3 text-center">
                <div className="card-body">
                    <h5 className="card-title">{this.props.dayName}</h5>
                    <AddTemperature weekid={this.props.weekid} dayid={this.props.dayid} refresh={this.populateTemperatureData} />
                    {contents}
               </div>
            </div>
        );
    }

    async populateTemperatureData(id, dayId) {
        const response = await fetch(`api/temperature/${id}?dayId=${dayId}`);
        const data = await response.json();
        this.setState({ temperatures: data, loading: false });
        this.props.refreshChart(true);
    }
}

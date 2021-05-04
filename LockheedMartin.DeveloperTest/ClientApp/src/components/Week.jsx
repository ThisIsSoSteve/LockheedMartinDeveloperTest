import React, { Component } from 'react';
import { TemperatureList } from './TemperatureList'
import { Chart } from './Chart'

export class Week extends Component {

    constructor(props) {
        super(props);
        const weekid = this.props.match.params.weekid;

        const query = new URLSearchParams(this.props.location.search);
        const weekName = query.get('name')

        this.state = { currentCount: 0, weekid: weekid, weekName: weekName, refreshChart: false };

        this.setRefreshChart = this.setRefreshChart.bind(this);
    }

    setRefreshChart(refresh) {
        this.setState({ refreshChart: refresh });
    }

    render() {
        return (
            <div>
                <h1>Week {this.state.weekName}</h1>
                <Chart weekid={this.state.weekid} refresh={this.state.refreshChart} refreshChart={this.setRefreshChart}/>
                <div className="row">
                    <TemperatureList weekid={this.state.weekid} dayid={0} dayName="Sunday" refreshChart={this.setRefreshChart} />
                    <TemperatureList weekid={this.state.weekid} dayid={1} dayName="Monday" refreshChart={this.setRefreshChart}/>
                    <TemperatureList weekid={this.state.weekid} dayid={2} dayName="Tuesday" refreshChart={this.setRefreshChart}/>
                    <TemperatureList weekid={this.state.weekid} dayid={3} dayName="Wednesday" refreshChart={this.setRefreshChart}/>
                    <TemperatureList weekid={this.state.weekid} dayid={4} dayName="Thursday" refreshChart={this.setRefreshChart}/>
                    <TemperatureList weekid={this.state.weekid} dayid={5} dayName="Friday" refreshChart={this.setRefreshChart}/>
                    <TemperatureList weekid={this.state.weekid} dayid={6} dayName="Saturday" refreshChart={this.setRefreshChart}/>
                </div>
            </div>
        );
    }
}

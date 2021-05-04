import React, { Component } from 'react';
import Highcharts from 'highcharts'
import HighchartsReact from 'highcharts-react-official'
require("highcharts/modules/annotations")(Highcharts);

export class Chart extends Component {

    constructor(props) {
        super(props);

        this.state = {
            chartOptions: {
                chart: {
                    type: 'scatter',
                    marginTop: 100
                },
                title: {
                    text: 'Temperatures by Week'
                },
                yAxis: {
                    title: {
                        enabled: true,
                        text: 'Temperature &deg;C'
                    },
                },
                xAxis: {
                    title: {
                        enabled: true,
                        text: 'Days'
                    },
                    allowDecimals: false,
                    categories: ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'],

                },
                tooltip: {
                    valueDecimals: 2,
                    headerFormat: '<b>{series.name}</b><br>',
                    pointFormat: '{point.y}',
                    valueSuffix: '&deg;C'
                },
                series: [{}]
            },
            loading: true
        };

        this.getWeekChartData = this.getWeekChartData.bind(this);
    }

    afterChartCreated = (chart) => {
        this.internalChart = chart;
    }

    componentDidMount() {
        this.getWeekChartData();
    }

    componentDidUpdate(prevProps) {
        if (this.props.refresh) {

            this.getWeekChartData();
        }
    }

    render() {
        const { chartOptions } = this.state;
        return (
            <div>
                <HighchartsReact
                    highcharts={Highcharts}
                    options={chartOptions}
                    callback={this.afterChartCreated}
                />
            </div>
        );
    }

    async getWeekChartData() {

        const [SundayResponse, MondayResponse, TuesdayResponse, WednesdayResponse, ThursdayResponse, FridayResponse, SaturdayResponse] = await Promise.all([
            fetch(`api/data/${this.props.weekid}?dayId=${0}`),
            fetch(`api/data/${this.props.weekid}?dayId=${1}`),
            fetch(`api/data/${this.props.weekid}?dayId=${2}`),
            fetch(`api/data/${this.props.weekid}?dayId=${3}`),
            fetch(`api/data/${this.props.weekid}?dayId=${4}`),
            fetch(`api/data/${this.props.weekid}?dayId=${5}`),
            fetch(`api/data/${this.props.weekid}?dayId=${6}`),
        ]);

        const Sunday = await SundayResponse.json();
        const Monday = await MondayResponse.json();
        const Tuesday = await TuesdayResponse.json();
        const Wednesday = await WednesdayResponse.json();
        const Thursday = await ThursdayResponse.json();
        const Friday = await FridayResponse.json();
        const Saturday = await SaturdayResponse.json();

        let data = [Sunday.dataPlots, Monday.dataPlots, Tuesday.dataPlots, Wednesday.dataPlots, Thursday.dataPlots, Friday.dataPlots, Saturday.dataPlots,
        Sunday.mean, Monday.mean, Tuesday.mean, Wednesday.mean, Thursday.mean, Friday.mean, Saturday.mean]

        let labels = {
            draggable: '',
            labelOptions: {
                overflow: 'none',
                shape: 'rect',

            },
            labels: [this.getLabel(0, Sunday.standardDeviation),
            this.getLabel(1, Monday.standardDeviation),
            this.getLabel(2, Tuesday.standardDeviation),
            this.getLabel(3, Wednesday.standardDeviation),
            this.getLabel(4, Thursday.standardDeviation),
            this.getLabel(5, Friday.standardDeviation),
            this.getLabel(6, Saturday.standardDeviation)
            ]
        };

        this.setState({
            chartOptions: {
                series: data,
                annotations: labels
            },
            loading: false
        });

        this.props.refreshChart(false);
    }

    getLabel(axis, text) {
        return {
            point: {
                xAxis: 0,
                x: axis,
                y: 0
            },
            text: "SD " + text.toFixed(2).toString()
        };
    }
}
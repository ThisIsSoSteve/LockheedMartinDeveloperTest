import React, { Component } from 'react';

export class AddTemperature extends Component {

    constructor(props) {
        super(props);
        this.state = { temperature: "", loading: false, weekId: this.props.weekid, dayId: this.props.dayid };

        this.addNewTemperature = this.addNewTemperature.bind(this);
        this.handleChange = this.handleChange.bind(this);
    }

    async addNewTemperature(e) {
        e.preventDefault();
        this.setState({ loading: true });


        const response = await fetch('api/temperature', {
            method: "POST",
            headers: new Headers({
                "Content-Type": "application/json",
            }),
            body: JSON.stringify(
                {
                    TemperatureC: parseFloat(this.state.temperature),
                    WeekId: this.state.weekId,
                    Day: this.state.dayId
                }
            ),
        });

        if (response.ok) {
            this.props.refresh(this.state.weekId, this.state.dayId);
            this.setState({ temperature: "" });
        }

        this.setState({ loading: false });
    }

    handleChange(changeObject) {
        this.setState(changeObject);
    }

    render() {
        return (
            <form onSubmit={this.addNewTemperature} className="form-inline">
                <div className="form-group mx-sm-3 mb-2">
                    <label htmlFor="temperature" className="sr-only">
                        Week's Name
                        </label>
                    <input
                        required
                        name="temperature"
                        id="temperature"
                        type="number"
                        step="0.01"
                        className="form-control"
                        placeholder="Add Temperature &deg;C"
                        value={this.state.temperature}
                        disabled={this.state.loading}
                        onChange={(e) =>
                            this.handleChange({ temperature: e.target.value })
                        }
                    />
                </div>

                <button type="submit" className="btn btn-primary mb-2" disabled={this.state.loading} >Add</button>

            </form>
        );
    }
}

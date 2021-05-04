import React, { Component } from 'react';

export class AddWeek extends Component {

    constructor(props) {
        super(props);
        this.state = { name: "", loading: false };
        this.addNewWeek = this.addNewWeek.bind(this);
        this.handleChange = this.handleChange.bind(this);
    }

    async addNewWeek(e) {
        e.preventDefault();
        this.setState({ loading: true });
        
        const response = await fetch('api/week', {
            method: "POST",
            headers: new Headers({
                "Content-Type": "application/json",
            }),
            body: JSON.stringify({Name: this.state.name}),
        });

        if (response.ok) {
            this.props.refresh();
            this.setState({ name: "" });
        }

        this.setState({ loading: false });
    }

    handleChange(changeObject) {
        this.setState(changeObject);
    }

    render() {
        return (
            <form onSubmit={this.addNewWeek} className="form-inline">
                <div className="form-group mx-sm-3 mb-2">
                    <label htmlFor="weekname" className="sr-only">
                        Week's Name
                        </label>
                    <input
                        required
                        name="weekname"
                        id="weekname"
                        type="text"
                        className="form-control"
                        placeholder="New Week Name"
                        value={this.state.name}
                        disabled={this.state.loading}
                        onChange={(e) =>
                            this.handleChange({ name: e.target.value })
                        }
                    />
                </div>
                
                <button type="submit" className="btn btn-primary mb-2" disabled={this.state.loading} >Add</button>
                
            </form>
        );
    }
}

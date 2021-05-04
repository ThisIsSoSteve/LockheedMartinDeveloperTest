import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Week } from './components/Week';
import { Weeks } from './components/Weeks';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
            <Route exact path='/' component={Weeks} />
            <Route path='/:weekid' component={Week} />
      </Layout>
    );
  }
}

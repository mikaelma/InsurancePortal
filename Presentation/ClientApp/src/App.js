import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { AddUser } from './components/AddUserComponent/AddUser';
import { AddCarInsurance } from './components/AddInsuranceComponent/AddCarInsurance';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/add-new-user' component={AddUser} />
        <Route path='/new-car-insurance' component={AddCarInsurance} />
      </Layout>
    );
  }
}

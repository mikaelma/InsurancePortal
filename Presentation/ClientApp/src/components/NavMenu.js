import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
//import './NavMenu.css';

export class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor (props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true
    };
  }

  toggleNavbar () {
    this.setState({
      collapsed: !this.state.collapsed
    });
  }

  render () {
    return (
      <header class="gb global-header">
        <nav class="gb global-header-navigation">
          <a href="/add-new-user" class="gb global-header-navigation-link">Add User</a>
          <a href="/my-information" class="gb global-header-navigation-link">My Information</a>
          <a href="/add-new-user" class="gb global-header-navigation-link">Holder item</a>

        </nav>
        <a href="/" class="gb logo">
          <span class="gb axe sr-only">Home</span>
        </a>
      </header>
      
    );
  }
}

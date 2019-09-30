import React from 'react';
 

export class AddUser extends React.Component{

    constructor(props){
        super(props);
        this.state={
            email: '',
            password: '',
            firstName: '',
            lastName: '',
            telephoneNumber: '',
            socialSecurityNumber: '',
            streetNameAndNumber: '',
            postalCode: '',
            city: '',
            country: ''
        }
        this.handleClick = this.handleClick.bind(this);
        this.handleChange = this.handleChange.bind(this);
      }
    
      handleClick(event){
        fetch('api/Customer/AddCustomer',{
                   method: 'POST',
                   headers: {
                       'Accept' : 'application/json',
                       'Content-Type' : 'application/json',
                   },
                   body: JSON.stringify({
                      email: this.state.email,
                      password: this.state.password,
                      firstname: this.state.firstName,
                      lastname: this.state.lastName,
                      telephonenumber: this.state.telephoneNumber,
                      socialSecurityNumber: this.state.socialSecurityNumber,
                      streetNameAndNumber: this.state.streetNameAndNumber,
                      postalCode: this.state.postalCode,
                      city: this.state.city,
                      country: this.state.country
                   })
               });
           }
    
    
           handleChange(event){
            const name = event.target.name;
            const value = event.target.value;
            this.setState({[name]: value});
        }
    
      render () {
        return (
            <div>
                <section class="gb block color bg green">
                    <header class="gb block-header">
                    <h2 class="gb block-headerTitle">Register new user</h2>

                    <form class="gb form" >
                        <div class="gb placeholder" style = {divStyle}>
                            <input placeholder= "First Name" type="text" name = "firstName" 
                            value={this.state.firstName} onChange={this.handleChange} />

                            <input placeholder= "Last Name" type="text" name = "lastName" 
                            value={this.state.lastName} onChange={this.handleChange} />

                            <input placeholder= "Phone Number" type="number" name = "telephoneNumber" 
                            value={this.state.telephoneNumber} onChange={this.handleChange} />

                            <input placeholder= "Social Security Number" type="number" name = "socialSecurityNumber" 
                            value={this.state.socialSecurityNumber} onChange={this.handleChange}/>

                            <input placeholder= "Email" type="email" name = "email" 
                            value={this.state.email} onChange={this.handleChange} />

                            <input placeholder= "Password" type="password" name = "password" 
                            value={this.state.password} onChange={this.handleChange} />

                            <input placeholder= "Street Address" type="text" name = "streetNameAndNumber"
                            value={this.state.streetNameAndNumber} onChange={this.handleChange} />

                            <input placeholder= "Postal Code" type="text" name = "postalCode" 
                            value={this.state.postalCode} onChange={this.handleChange} />
                            
                            <input placeholder= "City" type="text" name = "city" 
                            value={this.state.city} onChange={this.handleChange} />

                            <input placeholder= "Country" type="text" name = "country" 
                            value={this.state.country} onChange={this.handleChange} />
                            <br/>
                            <button type="submit" class="gb button primary" name="Submit" onClick={(event)=>this.handleClick(event)}>Submit</button>
                        </div>
                    </form>    
                </header>
        </section>
        <br/>
        <br/>
        <br/>
        <br/>
        </div>

        
            );
      }
}

const divStyle= {
    background: "#B4DED3",
    border: "none"
}
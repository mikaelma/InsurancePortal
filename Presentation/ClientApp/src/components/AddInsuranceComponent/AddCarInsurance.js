import React from 'react';
import DatePicker from 'react-datepicker';
import { Redirect } from 'react-router-dom';


export class AddCarInsurance extends React.Component{

    constructor(props){
        super(props)
        this.state={
            registrationNumber: '',
            customerNumber: '',
            redirect: false
        };
        this.handleChange = this.handleChange.bind(this);
    }

      handleChange(event){
        const name = event.target.name;
        const value = event.target.value;
        this.setState({[name]: value});
    }

    
    async handleClick(event){
        const url = 'api/Insurance/AddCarInsurance';
        const data = {
            registrationNumber: this.state.registrationNumber,
            customerNumber: this.state.customerNumber,
        }
        let response = await fetch(url,{
            method: 'POST',
            headers: {
                'Content-Type' : 'application/json',
            },
            body: JSON.stringify(data)
        });

        let result = await response.json();
        alert(result.toString());
        
    }
        
    

      render(){
        if(this.state.redirect === true){
            return <Redirect to="/" />
        }

          return(
              <div>
                <section class="gb block color bg green">
                    <header class="gb block-header">
                    <h2 class="gb block-headerTitle">Buy New Car Insurance</h2>
                        <form class="gb form" >                        
                        <div class="gb placeholder" style = {divStyle}>

                            <input placeholder= "Registration Number " type="text" name = "registrationNumber" value={this.state.registrationNumber} onChange={this.handleChange} />
                            <br/>
                            <input placeholder= "Customer Number " type="text" name = "customerNumber" value={this.state.customerNumber} onChange={this.handleChange} />                                
                           

                            <br/>
                            <button type="submit" class="gb button primary" name="Submit" onClick={(event)=>this.handleClick(event)}>Submit</button>
                                    
                            </div>
                        </form>
                    </header>
            
                </section>
                <footer class = "gb footer" style={footerStyle}>
                <a href="/add-new-user" class="gb global-header-navigation-link" style = {fontColor}>Dont have an account? Register here!</a>
            </footer>
            </div>
          )
      }
}


const divStyle= {
    background: "#B4DED3",
    border: "none"
}

const footerStyle={
    background: "gray"
}

const fontColor={
    color: "white"
}
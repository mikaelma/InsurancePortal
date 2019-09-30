import React, { Component } from 'react';



export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>

        <section class="gb block color bg orange">
          <header class="gb block-header">
            <h2 class="gb block-headerTitle">Heisann din lille luring</h2>
              <strong class="gb block-headerTagline">UTE ETTER NOE FORSIKRING ELLER????</strong>
              <br />
              <a href="/new-car-insurance" aria-labelledby="linkBox-label1" class="gb link-box overlay">
              [<img src="https://cdnsc.azureedge.net/resources/contentimage-1510-s940x530-sha2mAehcNt2FTTSulz1TnpU8Onh8og.jpg" alt="Link Box/Large" class="gb link-box-image"/>]
                <span class="gb link-box-heading">
                Buy new car insurance
                </span>
              </a>
          </header>
        </section>

        <ul class="gb cards">
          <li class="gb card"> 
            <div class="gb card-header border-bottom">
              <h2>Header</h2>
              <small>Sub title</small>
            </div>
            <div class="gb card-body">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla eu odio justo. 
              Integer cursus, sem in aliquam eleifend, arcu orci pellentesque odio, ut tincidunt erat neque 
              finibus massa. Donec dignissim pulvinar nulla et pellentesque. Quisque purus eros, dictum nec 
              mattis ut, vehicula nec diam. Integer nec libero rhoncus, scelerisque lectus in, commodo odio.
              Aliquam faucibus arcu ante, ac consequat metus convallis non. Phasellus sem nunc, consequat at 
              lectus ac, sagittis aliquam tortor. In luctus vel sapien a sodales.
            </div>
            <div class="gb card-footer">
              <a class="gb card-footerLink" href="#">A link</a> <a class="gb card-footerLink" href="#">A link</a>
            </div>
          </li>
          
          <li class="gb card"> 
            <div class="gb card-header border-bottom">
              <h2>Header</h2>
              <small>Sub title</small>
            </div>
            <div class="gb card-body">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla eu odio justo. 
              Integer cursus, sem in aliquam eleifend, arcu orci pellentesque odio, ut tincidunt erat neque 
              finibus massa. Donec dignissim pulvinar nulla et pellentesque. Quisque purus eros, dictum nec 
              mattis ut, vehicula nec diam. Integer nec libero rhoncus, scelerisque lectus in, commodo odio.
              Aliquam faucibus arcu ante, ac consequat metus convallis non. Phasellus sem nunc, consequat at 
              lectus ac, sagittis aliquam tortor. In luctus vel sapien a sodales.
            </div>
            <div class="gb card-footer">
              <a class="gb card-footerLink" href="#">A link</a> <a class="gb card-footerLink" href="#">A link</a>
            </div>
          </li>

          <li class="gb card"> 
            <div class="gb card-header border-bottom">
              <h2>Header</h2>
              <small>Sub title</small>
            </div>
            <div class="gb card-body">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla eu odio justo. 
              Integer cursus, sem in aliquam eleifend, arcu orci pellentesque odio, ut tincidunt erat neque 
              finibus massa. Donec dignissim pulvinar nulla et pellentesque. Quisque purus eros, dictum nec 
              mattis ut, vehicula nec diam. Integer nec libero rhoncus, scelerisque lectus in, commodo odio.
              Aliquam faucibus arcu ante, ac consequat metus convallis non. Phasellus sem nunc, consequat at 
              lectus ac, sagittis aliquam tortor. In luctus vel sapien a sodales.
            </div>
            <div class="gb card-footer">
              <a class="gb card-footerLink" href="#">A link</a> <a class="gb card-footerLink" href="#">A link</a>
            </div>
          </li>
          </ul>
      </div>
    );
  }
}

import React from 'react';
import ReactDOM from 'react-dom';
import { Route, BrowserRouter as Router, Switch } from 'react-router-dom';

import './index.css';

import wishlist from './pages/wishlist.jsx'

import reportWebVitals from './reportWebVitals';


const routing = (
  < Router >
    <div>
      <Switch>
        <Route path='/' component={wishlist}></Route>
      </Switch>
      </div>
  </Router >
)
ReactDOM.render(
  routing,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();

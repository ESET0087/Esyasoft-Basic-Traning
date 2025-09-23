import React from 'react'
import { Link } from 'react-router-dom'

const NavBar = () => {
  return (
    <div>
        NavBar &nbsp;
        <Link to='/'>Home</Link> &nbsp;
        <Link to='/about'>About</Link> &nbsp;
        <Link to='/api'>API</Link>
    </div>
  )
}

export default NavBar
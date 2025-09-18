import { useState } from "react";

const LoginComponent = () => {
    const [loginState, setLoginState] = useState({
        name: "",
        password: ""
    });

    const handleNameChange = (e) => {
        setLoginState({
            ...loginState,
            name: e.target.value
        })
    }

    const handlePasswordChange = (e) => {
        setLoginState({
            ...loginState,
            password: e.target.value
        })
    }

    const loginHandler = (e) => {
        e.preventDefault();
            
        if(loginState.name !== 'Dharmesh') {
            alert('Invalid user');
            return;
        }
        if(loginState.password !== 'dk') {
            alert('Invalid password');
            return;
        }
        alert('Login Successfull');
    }

  return (
    <form onSubmit={loginHandler} style={{background:"pink", margin:'10px'}}>
        <input type="text" placeholder="Name" value={loginState.name} onChange={handleNameChange} />
        <br />
        <input type="password" placeholder="Password" value={loginState.password} onChange={handlePasswordChange} />
        <br/>
        <button type='submit'> Login </button>
    </form>
  )
}

export default LoginComponent
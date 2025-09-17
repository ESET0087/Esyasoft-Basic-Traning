import { useState } from "react";

const LoginComponent = () => {
    const [name, setName] = useState("");
    const [password, setPassword] = useState("");

    const loginHandler = (e) => {
        e.preventDefault();
            
        if(name !== 'Dharmesh') {
            alert('Invalid user');
            return;
        }
        if(password !== 'dk') {
            alert('Invalid password');
            return;
        }
        alert('Login Successfull');
    }

  return (
    // form onSubmit event 
    <form onSubmit={loginHandler} style={{background:"pink", margin:'10px'}}>
        <input type="text" placeholder="Name" value={name} onChange={(e) => setName(e.target.value)} />
        <br />
        <input type="password" placeholder="Password" value={password} onChange={(e) => setPassword(e.target.value) } />
        <br/>
        <button type='submit'> Login </button>
    </form>
  )
}

export default LoginComponent
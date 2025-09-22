import Button from "./Button";
import { useState } from "react";

function App() {
  const [count, setCount] = useState(0);

  const handleIncrement = () => {
    console.log('Increment clicked');
    setCount(count + 1);
  };

  const handleDecrement = () => {
    console.log('Decrement clicked');
    setCount(count - 1);
  };

  return (
    <div className="App" style={{textAlign: 'center'}}>
      <h1>{count}</h1>
      <Button label='Increment' onClick={handleIncrement}/>
      <Button label='Decrement' onClick={handleDecrement}/>
    </div>
  );
}

export default App;

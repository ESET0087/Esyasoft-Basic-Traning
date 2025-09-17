import { useState } from 'react'

const Counter = () => {
    // using DOM Manipulation 

  // let count = 0;
  // const increment = () => {
  //   count++;
  //   document.getElementById('cnt').innerText = count;
  // }
  // const decrement = () => {
  //   count--;
  //   document.getElementById('cnt').innerText = count;
  // } 

  // Using useState hook
    
    const [count, setCount] = useState(0);

  return (
    <div>
    <h1 id='cnt'> {count} </h1>
    <button onClick={() => setCount(count ? count - 1 : 0) }>-</button>
    <button onClick={() => setCount(count + 1) }>+</button>
    </div>
  )
}

export default Counter  
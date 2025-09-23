import React, { useState } from 'react'

export default function ParentComponent() {
    const [count, setCount] = useState(0);
  return (
    <div>
        <Child1 count={count}/>
        <Child2 setCount={setCount}/>
    </div>
  )
}

function Child1({count}) {
    return (
        <div> {count} </div>
    )
}

function Child2({setCount}) {
    return (
        <>
            <button onClick={() => setCount(count => count + 1)}>increment</button>
            <button onClick={() => setCount(count => count - 1)}>decrement</button>
        </>
    )
}

import React, { useRef } from 'react'

const UseRef = () => {
    const ref = useRef(null);
    const buttonHandler = () => {
      ref.current.focus();
    }

  return (
    <div>
        <input ref={ref}/>
        <button onClick={buttonHandler}> focus </button>
    </div>
  )
}

export default UseRef
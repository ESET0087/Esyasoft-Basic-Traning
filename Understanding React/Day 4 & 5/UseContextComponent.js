import React, { useContext } from 'react'
import { Context } from './App';

const UseContextComponent = () => {
    const {theme} = useContext(Context);

  return (
    <div>
        {theme}
    </div>
  )
}

export default UseContextComponent
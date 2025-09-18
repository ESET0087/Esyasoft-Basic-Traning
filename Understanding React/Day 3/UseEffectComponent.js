import React, { useEffect, useState } from 'react'

const list = ['laptop', 'mobile', 'phone'];

function UseEffectComponent() {

    const [search, setSearch] = useState("");
    const [recommedntaion, setRecommendation] = useState([]);

    useEffect (() => {
        setRecommendation(list.filter(item => item.includes(search))) 
    }, [search]);

  return (
    <div>
        <input value={search} placeholder='type here' onChange={(e) => setSearch(e.target.value)} />
        {
            recommedntaion.map((item, index) => <div key={index}> {index+1}. {item} </div>)
        }
    </div>
  )
}

export default UseEffectComponent;

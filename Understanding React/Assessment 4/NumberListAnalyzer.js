import React, { useMemo, useState, useCallback } from 'react'

const NumberListAnalyzer = () => {
    const [list, setList] = useState([]);
    const [input, setInput] = useState('');

    // useMemo for sum and largest
    const { sum, largest } = useMemo(() => {        
        if (list.length === 0) {
            return { sum: 0, largest: null };
        }

        const sum = list.reduce((acc, num) => acc + num, 0);
        const largest = Math.max(...list);
        
        return { sum, largest };
    }, [list]);
    
    // Callback to remove 
    const handleRemoveNumber = useCallback((indexToRemove) => {
        setList(prevNumbers => 
            prevNumbers.filter((_, index) => index !== indexToRemove)
        );
    }, []);
    
    const handleAddNumber = () => {
        const num = parseInt(input);
        setList(prevNumbers => [...prevNumbers, num]);
        setInput('');
    }

    const handleChange = (e) => {
        setInput(e.target.value);
    }

  return (
    <div>
        <h1>Number List Analyser</h1>
        <input type='number' value={input} onChange={handleChange} placeholder='type a number' />
        <button onClick={handleAddNumber}>Add</button>
        
        {/* Display list */}
        {
            list.map((num, index) => (
            <div key={index}>
                {num}
                <button style={{marginLeft: '10px'}} onClick={() => handleRemoveNumber(index)}>Remove</button>
            </div>
            ))
        }

        {/* Statistics */}
        <div>
            <p>Sum of all numbers: {sum}</p>
            { largest && <p>Largest number: {largest}</p> }
        </div>
    </div>
  )
}

export default NumberListAnalyzer
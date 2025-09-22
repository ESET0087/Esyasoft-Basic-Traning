import React, { useRef, useState } from 'react';

const ColorBox = () => {
  const boxRefs = useRef([]);
  const [highlight, setHighlight] = useState(-1);

  const colors = ['red', 'green', 'blue'];
  
  const highlightNextBox = () => {
    if (highlight >= 0) {
      boxRefs.current[highlight].classList.remove('highlighted');
    }

    const next = (highlight + 1) % colors.length;
    
    if (boxRefs.current[next]) {
      boxRefs.current[next].classList.add('highlighted');
    }

    setHighlight(next);
  };

  return (
    <div className="container">
      <h2>Color Box Highlighter</h2>
      
      <div className="button-group">
        <button onClick={highlightNextBox}>
          Highlight Next Box
        </button>
      </div>

      <div className="boxes-container">
        {colors.map((color, index) => (
          <div
            key={color}
            ref={e => boxRefs.current[index] = e}
            className={`color-box ${color}`}
          >
            {color.toUpperCase()}
          </div>
        ))}
      </div>

      <p>Current Highlight: {highlight >= 0 ? colors[highlight] : 'None'}</p>
    </div>
  );
};

export default ColorBox;
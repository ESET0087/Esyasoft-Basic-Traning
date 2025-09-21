import React, { useState, useEffect } from 'react';

const MouseTracker = () => {
  const [mousePosition, setMousePosition] = useState({ x: 0, y: 0 });

  useEffect(() => {
    const handleMouseMove = (e) => {
      setMousePosition({
        x: e.clientX,
        y: e.clientY
      }); 
    };

    window.addEventListener('mousemove', handleMouseMove);

    return () => {
      window.removeEventListener('mousemove', handleMouseMove);
    };
  }, []);

  return (
    <div style={{ padding: '20px'}}>
      <h2>Mouse Tracker</h2>
      <div>
          Current Position: X: {mousePosition.x}, Y: {mousePosition.y}
      </div>
    </div>
  );
};

export default MouseTracker;
# Problem

Build a React component “MouseTracker” that:
 
- Uses useState to store the current mouse position (x, y).
- Uses useEffect to add a mousemove event listener when the component mounts.
- Updates the state with the new mouse coordinates whenever the mouse moves.
- Cleans up the event listener when the component unmounts (using the cleanup function).
const EventComponent = () => {
    const onChangeHandler = (e) => {
        console.log(e.target.value);
        
        if(e.target.value === 'Dharmesh') console.log('ok!');
    }

  return (
    <>
        {/* onMouseEnter event  */}
        <div style={{margin:'10px', background: '#83d820', padding: '10px'}} onMouseEnter={() => console.log("Mouse Enter event")}>
            Welcome! 
        </div>
        
        {/* onChange event */}
        <input type='text' placeholder='type here' onChange={onChangeHandler} />
    </>
  )
}

export default EventComponent   